
using System.Text.Json.Serialization;

namespace Veriff.net.Responses;

public class SessionMedia
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("videos")]
    public List<Media>? Videos { get; set; }

    [JsonPropertyName("images")]
    public List<Media>? Images { get; set; }
}

public class Media
{
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("mimetype")]
    public string? Mimetype { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("timestamp")]
    public object? Timestamp { get; set; } // Deprecated, keeping as object to allow null values

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
