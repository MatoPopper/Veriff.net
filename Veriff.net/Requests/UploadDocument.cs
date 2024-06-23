using System.Text.Json.Serialization;

namespace Veriff.net.Requests;

public class UploadDocument
{
    [JsonPropertyName("image")]
    public Image Image { get; set; } = null!;
}

public class Image
{
    [JsonPropertyName("context")]
    public string Context { get; set; } = null!;

    [JsonPropertyName("content")]
    public string Content { get; set; } = null!;
}
