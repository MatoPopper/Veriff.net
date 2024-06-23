using System.Text.Json.Serialization;

namespace Veriff.net.Responses;

public class SessionAttempts
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("verifications")]
    public List<VerificationAttempt>? Verifications { get; set; }
}

public class VerificationAttempt
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("userDefinedData")]
    public List<UserDefinedData>? UserDefinedData { get; set; }

    [JsonPropertyName("createdTime")]
    public DateTime? CreatedTime { get; set; }
}

public class UserDefinedData
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    [JsonPropertyName("reasonCode")]
    public string? ReasonCode { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }
}
