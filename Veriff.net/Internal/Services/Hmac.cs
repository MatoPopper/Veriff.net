using System.Security.Cryptography;
using System.Text;
using Veriff.net.Internal.Interfaces;
using Veriff.net.Shared;

namespace Veriff.net.Internal.Services;

internal class Hmac : IHmac
{
    private readonly VeriffConfig _options;

    public Hmac(VeriffConfig options)
    {
        _options = options;
    }

    public string? GetXHmac(byte[] payloadBytes)
    {
        string? code = null;

        byte[] sharedSecretKeyBytes = Encoding.UTF8.GetBytes(_options.SecretKey);

        using (var hmac = new HMACSHA256(sharedSecretKeyBytes))
        {
            byte[] hash = hmac.ComputeHash(payloadBytes);

            code = BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        return code;
    }
}
