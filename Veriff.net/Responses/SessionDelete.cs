using System.Text.Json.Serialization;

namespace Veriff.net.Responses;

public class SessionDelete
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("verification")]
    public VerificationSessionDelete? Verification { get; set; }
}

public class VerificationSessionDelete
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
