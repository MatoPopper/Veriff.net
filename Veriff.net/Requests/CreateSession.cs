using System.Text.Json.Serialization;

namespace Veriff.net.Requests;

public class CreateSession
{
    [JsonPropertyName("verification")]
    public Verification Verification { get; set; } = null!;
}

public class Verification
{
    [JsonPropertyName("callback")]
    public string Callback { get; set; } = null!;

    [JsonPropertyName("vendorData")]
    public string VendorData { get; set; } = null!;
}
