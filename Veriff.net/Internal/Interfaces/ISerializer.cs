namespace Veriff.net.Internal.Interfaces;

internal interface ISerializer
{
    T? Deserialize<T>(string value);

    string Serialize<T>(T value);
}