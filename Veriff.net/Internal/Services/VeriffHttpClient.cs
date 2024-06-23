using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Veriff.net.Internal.Interfaces;
using Veriff.net.Responses;
using Veriff.net.Shared;

namespace Veriff.net.Internal.Services
{
    internal class VeriffHttpClient : IVeriffHttpClient
    {
        internal const string HttpClientName = "api";

        private readonly IHmac _hmac;
        private readonly ISerializer _serializer;
        private readonly HttpClient _client;
        private readonly VeriffConfig _options;
        private readonly object _lock = new object();

        public VeriffHttpClient(
            IHmac hmac,
            IHttpClientFactory factory,
            ISerializer serializer,
            VeriffConfig options)
        {
            _hmac = hmac;
            _client = factory.CreateClient(HttpClientName);
            _options = options;
            _serializer = serializer;

            _client.DefaultRequestHeaders.Add("X-AUTH-CLIENT", _options.ApiKey);
        }

        public async Task<T?> Get<T>(string url, CancellationToken cancellationToken)
            where T : class
        {
            var message = await _client.GetAsync(url, cancellationToken);

            Type typeOfT = typeof(T);
            if (typeOfT == typeof(string))
            {
                var ret = message.IsSuccessStatusCode
                ? "Ok" as T
                : null;
                return ret;
            }

            return message.IsSuccessStatusCode
                ? (T?)_serializer.Deserialize<T?>(await message.Content.ReadAsStringAsync(cancellationToken))
                : null;
        }

        public async Task<bool> Check(string url, CancellationToken cancellationToken)
        {
            var message = await _client.GetAsync(url, cancellationToken);

            return message.IsSuccessStatusCode;
        }

        public async Task<TResult?> Post<T, TResult>(T model, string url, bool hmac = true, CancellationToken cancellationToken = default)
            where T : class
        {
            if(hmac) 
            {
                byte[] payloadBytes = Encoding.UTF8.GetBytes(_serializer.Serialize(model));
                _client.DefaultRequestHeaders.Add("X-HMAC-SIGNATURE", _hmac.GetXHmac(payloadBytes));
            }

            var content = new StringContent(_serializer.Serialize(model), Encoding.UTF8, Constants.ContentMediaType);

                HttpResponseMessage message = await _client.PostAsync(url, content, cancellationToken);
                return message.IsSuccessStatusCode
                    ? (TResult?)_serializer.Deserialize<TResult>(await message.Content.ReadAsStringAsync(cancellationToken))
                    : throw new UnauthorizedAccessException();
        }

        public async Task<TResult?> PostUrlEncoded<T, TResult>(T model, string url, CancellationToken cancellationToken = default)
            where T : class
        {
            var content = new FormUrlEncodedContent(GetDictionary(model));
            var message = await _client.PostAsync(url, content, cancellationToken);
            var res = await message.Content.ReadAsStringAsync();
            return message.IsSuccessStatusCode
                ? _serializer.Deserialize<TResult>(res)
                : throw new UnauthorizedAccessException();
        }

        private Dictionary<string, string?> GetDictionary<T>(T obj)
        {
            var dict = new Dictionary<string, string?>();
            var t = typeof(T);

            foreach (var propertyInfo in t.GetProperties())
            {
                var jsonAttribute = propertyInfo.CustomAttributes
                    .FirstOrDefault(a => a.AttributeType == typeof(JsonPropertyNameAttribute));

                var name = jsonAttribute?.ConstructorArguments?.First().Value?.ToString();

                dict.Add(name ?? propertyInfo.Name, propertyInfo.GetValue(obj)?.ToString());
            }

            return dict;
        }
        
        public async Task<SessionDelete?> Delete(string url, CancellationToken cancellationToken = default)
        {
            var message = await _client.DeleteAsync(url, cancellationToken);
            return message.IsSuccessStatusCode
                ? (SessionDelete?)_serializer.Deserialize<SessionDelete>(await message.Content.ReadAsStringAsync())
                : throw new UnauthorizedAccessException(); ;
        }

        public async Task<bool> Patch(string url, CancellationToken cancellationToken = default)
        {
            var requestBody = new
            {
                verification = new
                {
                    status = "submitted"
                }
            };

            var jsonRequestBody = JsonSerializer.Serialize(requestBody);
            HttpContent content = new StringContent(jsonRequestBody, Encoding.UTF8, Constants.ContentMediaType);

            var message = await _client.PatchAsync(url, content, cancellationToken);
            return message.IsSuccessStatusCode
                ? true
                : throw new UnauthorizedAccessException(); ;
        }
    }
}
