
namespace Veriff.net.Internal.Interfaces;

public interface ISessionService
{
    Task<Responses.CreateSession?> CreateSession(Requests.CreateSession request, CancellationToken cancellationToken);

    Task<Responses.UploadDocument?> UploadDocument(string sessionId, Requests.UploadDocument request, CancellationToken cancellationToken);

    Task<bool> SubmitSession(string sessionId, CancellationToken cancellationToken);

    Task<Responses.SessionAttempts?> SessionAttempts(string sessionId, CancellationToken cancellationToken);

    Task<Responses.SessionDecision?> SessionDecision(string sessionId, CancellationToken cancellationToken);

    Task<Responses.SessionMedia?> SessionMedia(string sessionId, CancellationToken cancellationToken);

    Task<Responses.SessionPerson?> SessionPerson(string sessionId, CancellationToken cancellationToken);

    Task<Responses.SessionWatchlistScreening?> SessionWatchlistScreening(string sessionId, CancellationToken cancellationToken);

    Task<Responses.SessionDelete?> SessionDelete(string sessionId, CancellationToken cancellationToken);
}
