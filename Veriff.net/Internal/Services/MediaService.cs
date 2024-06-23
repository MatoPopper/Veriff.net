using Veriff.net.Internal.Interfaces;

namespace Veriff.net.Internal.Services;

internal class MediaService : IMediaService
{
    private readonly IVeriffHttpClient _client;

    public MediaService(IVeriffHttpClient client)
    {
        _client = client;
    }


}
