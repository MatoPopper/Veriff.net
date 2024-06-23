using Veriff.net.Internal.Interfaces;

namespace Veriff.net.Internal.Services;

internal class SessionService : ISessionService
{
    private readonly IVeriffHttpClient _client;

    public SessionService(IVeriffHttpClient client)
    {
        _client = client;
    }

    public async Task<Responses.CreateSession?> CreateSession(Requests.CreateSession request, CancellationToken cancellationToken) =>
        await _client.Post<Requests.CreateSession, Responses.CreateSession>(request, "/v1/sessions/",false, cancellationToken);

    public async Task<Responses.UploadDocument?> UploadDocument(string sessionId, Requests.UploadDocument request, CancellationToken cancellationToken) =>
        await _client.Post<Requests.UploadDocument, Responses.UploadDocument>(request, "/v1/sessions/" + sessionId + "/media", true, cancellationToken);

    public async Task<bool> SubmitSession(string sessionId, CancellationToken cancellationToken) =>
       await _client.Patch("/v1/sessions/" + sessionId, cancellationToken);

    public async Task<Responses.SessionAttempts?> SessionAttempts(string sessionId, CancellationToken cancellationToken) =>
        await _client.Get<Responses.SessionAttempts>("/v1/sessions/" + sessionId + "/attempts", cancellationToken);

    public async Task<Responses.SessionDecision?> SessionDecision(string sessionId, CancellationToken cancellationToken) =>
        await _client.Get<Responses.SessionDecision>("/v1/sessions/"+ sessionId+ "/decision", cancellationToken);

    public async Task<Responses.SessionMedia?> SessionMedia(string sessionId, CancellationToken cancellationToken) =>
         await _client.Get<Responses.SessionMedia>("/v1/sessions/" + sessionId + "/media", cancellationToken);

    public async Task<Responses.SessionPerson?> SessionPerson(string sessionId, CancellationToken cancellationToken) =>
         await _client.Get<Responses.SessionPerson>("/v1/sessions/" + sessionId + "/person", cancellationToken);

    public async Task<Responses.SessionWatchlistScreening?> SessionWatchlistScreening(string sessionId, CancellationToken cancellationToken) =>
         await _client.Get<Responses.SessionWatchlistScreening>("/v1/sessions/" + sessionId + "/watchlist-screening", cancellationToken);

    public async Task<Responses.SessionDelete?> SessionDelete(string sessionId, CancellationToken cancellationToken) =>
         await _client.Delete("/v1/sessions/" + sessionId, cancellationToken);

}
