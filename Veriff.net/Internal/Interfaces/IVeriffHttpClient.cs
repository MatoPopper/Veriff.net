using Veriff.net.Responses;

namespace Veriff.net.Internal.Interfaces;

internal interface IVeriffHttpClient
{
    Task<T?> Get<T>(string url, CancellationToken cancellationToken = default)
   where T : class;

    Task<TResult?> Post<T, TResult>(T model, string url, bool hmac = true, CancellationToken cancellationToken = default)
        where T : class;

    Task<TResult?> PostUrlEncoded<T, TResult>(T model, string url,
        CancellationToken cancellationToken = default)
        where T : class;

    Task<bool> Patch(string url, CancellationToken cancellationToken = default);

    Task<SessionDelete?> Delete(string url, CancellationToken cancellationToken = default);

    Task<bool> Check(string url, CancellationToken cancellationToken);
}
