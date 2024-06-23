using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Veriff.net.Internal.Interfaces;
using Veriff.net.Internal.Services;

namespace Veriff.net.Shared;

public static class VeriffDotNetApiServiceCollectionExtensions
{
    /// <summary>
    /// Service collection
    /// </summary>
    /// <param name="services"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public static IHttpClientBuilder AddVeriffDotNet(this IServiceCollection services)
    {
        services.AddSingleton(serviceProvider =>
        {
            var options = serviceProvider
                .GetRequiredService<IConfiguration>()
                .GetSection("Veriff").Get<VeriffConfig>();
            if (string.IsNullOrWhiteSpace(options?.ApiKey) || string.IsNullOrWhiteSpace(options?.SecretKey))
            {
                throw new InvalidOperationException("ApiKey and SecretKey are required to connect to Veriff");
            }

            return options;
        });

        services.AddSingleton<ISerializer, Serializer>();
        services.AddSingleton<IHmac, Hmac>();
        var assemblyName = typeof(IVeriffService).Assembly.GetName();
        var userAgentHeader = $"{assemblyName.Name}/{assemblyName.Version}";
        /*
         services.AddHttpClient(TokensService.HttpClientName, (serviceProvider, client) =>
         {
             var options = serviceProvider
                               .GetRequiredService<VeriffConfig>() ??
                           throw new ArgumentNullException(nameof(VeriffConfig));
             client.DefaultRequestHeaders.Add("Accept", Constants.AcceptedMediaType);
             client.DefaultRequestHeaders.Add("User-Agent", userAgentHeader);
             client.BaseAddress = new Uri($"{options.Url.TrimEnd('/')}");
         });
        */
        services.AddSingleton<IVeriffHttpClient, VeriffHttpClient>();
        services.AddSingleton<IVeriffService, VeriffService>();
        services.AddSingleton<ISessionService, SessionService>();
        services.AddSingleton<IMediaService, MediaService>();
        return services.AddHttpClient(VeriffHttpClient.HttpClientName, (serviceProvider, client) =>
        {
            var options = serviceProvider
                              .GetRequiredService<VeriffConfig>() ??
                          throw new ArgumentNullException(nameof(VeriffConfig));
            client.DefaultRequestHeaders.Add("Accept", Constants.AcceptedMediaType);
            client.DefaultRequestHeaders.Add("User-Agent", userAgentHeader);
            client.BaseAddress = new Uri($"{options.BaseUrl.TrimEnd('/')}");
        });
    }
}
