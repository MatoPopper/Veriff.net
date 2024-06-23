namespace Veriff.net.Internal.Interfaces;

internal interface IHmac
{
    public string? GetXHmac(byte[] payloadBytes);
}
