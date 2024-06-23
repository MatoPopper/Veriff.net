using System.Text.Json;
using Veriff.net.Internal.Interfaces;

namespace Veriff.net.Internal.Services;
internal class Serializer : ISerializer
{
    private static readonly JsonSerializerOptions Options = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public T? Deserialize<T>(string value)
    {
        return JsonSerializer.Deserialize<T>(value, Options);
    }

    public string Serialize<T>(T value)
    {
        return JsonSerializer.Serialize(value, Options);
    }
}
