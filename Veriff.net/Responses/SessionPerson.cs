using System.Text.Json.Serialization;

namespace Veriff.net.Responses;

public class SessionPerson
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("person")]
    public PersonSessionPerson? Person { get; set; }
}

public class PersonSessionPerson
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }

    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }

    [JsonPropertyName("idCode")]
    public string? IdCode { get; set; }

    [JsonPropertyName("dateOfBirth")]
    public string? DateOfBirth { get; set; }

    [JsonPropertyName("gender")]
    public string? Gender { get; set; }

    [JsonPropertyName("nationality")]
    public string? Nationality { get; set; }

    [JsonPropertyName("placeOfBirth")]
    public string? PlaceOfBirth { get; set; }

    [JsonPropertyName("citizenships")]
    public List<string>? Citizenships { get; set; }

    [JsonPropertyName("pepSanctionMatches")]
    public List<PepSanctionMatch>? PepSanctionMatches { get; set; }
}

public class PepSanctionMatch
{
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    [JsonPropertyName("numberOfMatches")]
    public int? NumberOfMatches { get; set; }

    [JsonPropertyName("date")]
    public string? Date { get; set; }

    [JsonPropertyName("matches")]
    public List<string>? Matches { get; set; }

    [JsonPropertyName("hits")]
    public List<Hit>? Hits { get; set; }
}

public class Hit
{
    [JsonPropertyName("doc")]
    public Doc? Doc { get; set; }

    [JsonPropertyName("matchTypes")]
    public List<string>? MatchTypes { get; set; }

    [JsonPropertyName("matchTypesDetails")]
    public Dictionary<string, MatchTypeDetail>? MatchTypesDetails { get; set; }

    [JsonPropertyName("matchStatus")]
    public string? MatchStatus { get; set; }

    [JsonPropertyName("isWhitelisted")]
    public bool? IsWhitelisted { get; set; }

    [JsonPropertyName("score")]
    public double? Score { get; set; }
}

public class Doc
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lastUpdatedUtc")]
    public string? LastUpdatedUtc { get; set; }

    [JsonPropertyName("createdUtc")]
    public string? CreatedUtc { get; set; }

    [JsonPropertyName("fields")]
    public List<Field>? Fields { get; set; }

    [JsonPropertyName("types")]
    public List<string>? Types { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("entityType")]
    public string? EntityType { get; set; }

    [JsonPropertyName("aka")]
    public List<Aka>? Aka { get; set; }

    [JsonPropertyName("associates")]
    public List<Associate>? Associates { get; set; }

    [JsonPropertyName("sources")]
    public List<string>? Sources { get; set; }

    [JsonPropertyName("keywords")]
    public List<string>? Keywords { get; set; }

    [JsonPropertyName("media")]
    public List<MediaSessionPerson>? Media { get; set; }

    [JsonPropertyName("assets")]
    public List<Asset>? Assets { get; set; }

    [JsonPropertyName("sourceNotes")]
    public Dictionary<string, SourceNote>? SourceNotes { get; set; }
}

public class Field
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public class Aka
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public class Associate
{
    [JsonPropertyName("association")]
    public string? Association { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public class MediaSessionPerson
{
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    [JsonPropertyName("snippet")]
    public string? Snippet { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public class Asset
{
    [JsonPropertyName("publicUrl")]
    public string? PublicUrl { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public class SourceNote
{
    [JsonPropertyName("amlTypes")]
    public List<string>? AmlTypes { get; set; }

    [JsonPropertyName("listingStartedUtc")]
    public string? ListingStartedUtc { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public class MatchTypeDetail
{
    [JsonPropertyName("matchTypes")]
    public Dictionary<string, List<string>>? MatchTypes { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
