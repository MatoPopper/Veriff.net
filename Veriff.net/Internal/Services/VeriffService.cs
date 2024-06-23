using Veriff.net.Internal.Interfaces;

namespace Veriff.net.Internal.Services;

internal class VeriffService: IVeriffService
{
    public VeriffService(ISessionService sessionService, IMediaService mediaService)
    { 
        Sessions = sessionService ?? throw new ArgumentNullException(nameof(sessionService));
        Medias = mediaService ?? throw new ArgumentNullException(nameof(mediaService));
    }

    public ISessionService Sessions { get;}
    public IMediaService Medias { get;}
}
