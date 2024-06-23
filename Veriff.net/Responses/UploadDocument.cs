
using System.Text.Json.Serialization;

namespace Veriff.net.Responses;

public class UploadDocument
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("image")]
    public DocumentImage? Image { get; set; }
}

public class DocumentImage
{
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("timestamp")] // deprecated, not mapped
    public object? Timestamp { get; set; }  // Can be null, since it's deprecated

    [JsonPropertyName("size")]
    public long Size { get; set; }

    [JsonPropertyName("mimetype")]
    public string? MimeType { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
