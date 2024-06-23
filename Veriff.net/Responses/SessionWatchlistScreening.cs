using System.Text.Json.Serialization;

namespace Veriff.net.Responses;

public class SessionWatchlistScreening
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("data")]
    public WatchlistData? Data { get; set; }
}

public class WatchlistData
{
    [JsonPropertyName("attemptId")]
    public string? AttemptId { get; set; }

    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    [JsonPropertyName("vendorData")]
    public object? VendorData { get; set; }

    [JsonPropertyName("checkType")]
    public string? CheckType { get; set; }

    [JsonPropertyName("matchStatus")]
    public string? MatchStatus { get; set; }

    [JsonPropertyName("searchTerm")]
    public SearchTerm? SearchTerm { get; set; }

    [JsonPropertyName("totalHits")]
    public int? TotalHits { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("hits")]
    public List<HitSessionWatchlistScreening>? Hits { get; set; }
}

public class SearchTerm
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("year")]
    public string? Year { get; set; }
}

public class HitSessionWatchlistScreening
{
    [JsonPropertyName("matchedName")]
    public string? MatchedName { get; set; }

    [JsonPropertyName("countries")]
    public List<string>? Countries { get; set; }

    [JsonPropertyName("dateOfBirth")]
    public string? DateOfBirth { get; set; }

    [JsonPropertyName("dateOfDeath")]
    public object? DateOfDeath { get; set; }

    [JsonPropertyName("matchTypes")]
    public List<string>? MatchTypes { get; set; }

    [JsonPropertyName("aka")]
    public List<string>? Aka { get; set; }

    [JsonPropertyName("associates")]
    public List<string>? Associates { get; set; }

    [JsonPropertyName("listingsRelatedToMatch")]
    public ListingsRelatedToMatch? ListingsRelatedToMatch { get; set; }
}

public class ListingsRelatedToMatch
{
    [JsonPropertyName("warnings")]
    public List<Warning>? Warnings { get; set; }

    [JsonPropertyName("sanctions")]
    public List<Sanction>? Sanctions { get; set; }

    [JsonPropertyName("fitnessProbity")]
    public List<object>? FitnessProbity { get; set; }

    [JsonPropertyName("pep")]
    public List<Pep>? Pep { get; set; }

    [JsonPropertyName("adverseMedia")]
    public List<AdverseMedia>? AdverseMedia { get; set; }
}

public class Warning
{
    [JsonPropertyName("sourceName")]
    public string? SourceName { get; set; }

    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }

    [JsonPropertyName("date")]
    public object? Date { get; set; }
}

public class Sanction
{
    [JsonPropertyName("sourceName")]
    public string? SourceName { get; set; }

    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }

    [JsonPropertyName("date")]
    public object? Date { get; set; }
}

public class Pep
{
    [JsonPropertyName("sourceName")]
    public string? SourceName { get; set; }

    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }

    [JsonPropertyName("date")]
    public object? Date { get; set; }
}

public class AdverseMedia
{
    [JsonPropertyName("sourceName")]
    public string? SourceName { get; set; }

    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }

    [JsonPropertyName("date")]
    public object? Date { get; set; }
}
