namespace Veriff.net.Internal.Interfaces;

public interface IVeriffService
{
    /// <summary>
    /// Session management
    /// https://developers.veriff.com/#post-sessions
    /// </summary>
    ISessionService Sessions { get; }

    /// <summary>
    /// Media management
    /// https://developers.veriff.com/#get-attempts-attemptid-media
    /// </summary>
    IMediaService Medias { get; }
}
