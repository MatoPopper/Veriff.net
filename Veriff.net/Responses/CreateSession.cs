using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Veriff.net.Responses
{
    public class CreateSession
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("verification")]
        public Verification Verification { get; set; }
    }

    public class Verification
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("vendorData")]
        public string? VendorData { get; set; }

        [JsonPropertyName("host")]
        public string? Host { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("sessionToken")]
        public string? SessionToken { get; set; }
    }
}
