using System.Text.Json.Serialization;

namespace Veriff.net.Responses;

public class SessionDecision
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("verification")]
    public VerificationSessionDecision? Verification { get; set; }
}

public class VerificationSessionDecision
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("person")]
    public Person? Person { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("comments")]
    public List<string>? Comments { get; set; }

    [JsonPropertyName("document")]
    public Document? Document { get; set; }

    [JsonPropertyName("reasonCode")]
    public string? ReasonCode { get; set; }

    [JsonPropertyName("vendorData")]
    public string? VendorData { get; set; }

    [JsonPropertyName("decisionTime")]
    public DateTime? DecisionTime { get; set; }

    [JsonPropertyName("acceptanceTime")]
    public DateTime? AcceptanceTime { get; set; }

    [JsonPropertyName("additionalVerifiedData")]
    public AdditionalVerifiedData? AdditionalVerifiedData { get; set; }

    [JsonPropertyName("riskScore")]
    public RiskScore? RiskScore { get; set; }

    [JsonPropertyName("riskLabels")]
    public List<RiskLabel>? RiskLabels { get; set; }

    [JsonPropertyName("biometricAuthentication")]
    public BiometricAuthentication? BiometricAuthentication { get; set; }
}

public class Person
{
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }

    [JsonPropertyName("idNumber")]
    public string? IdNumber { get; set; }

    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }

    [JsonPropertyName("addresses")]
    public List<Address>? Addresses { get; set; }

    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }

    [JsonPropertyName("citizenship")]
    public string? Citizenship { get; set; }

    [JsonPropertyName("dateOfBirth")]
    public DateTime? DateOfBirth { get; set; }

    [JsonPropertyName("nationality")]
    public string? Nationality { get; set; }

    [JsonPropertyName("yearOfBirth")]
    public string? YearOfBirth { get; set; }

    [JsonPropertyName("placeOfBirth")]
    public string? PlaceOfBirth { get; set; }

    [JsonPropertyName("occupation")]
    public string? Occupation { get; set; }

    [JsonPropertyName("employer")]
    public string? Employer { get; set; }

    [JsonPropertyName("foreignerStatus")]
    public string? ForeignerStatus { get; set; }

    [JsonPropertyName("extraNames")]
    public string? ExtraNames { get; set; }

    [JsonPropertyName("pepSanctionMatch")]
    public string? PepSanctionMatch { get; set; }
}

public class Address
{
    [JsonPropertyName("fullAddress")]
    public string? FullAddress { get; set; }

    [JsonPropertyName("parsedAddress")]
    public ParsedAddress? ParsedAddress { get; set; }
}

public class ParsedAddress
{
    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("street")]
    public string? Street { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("postcode")]
    public string? Postcode { get; set; }

    [JsonPropertyName("houseNumber")]
    public string? HouseNumber { get; set; }
}

public class Document
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("number")]
    public string? Number { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("placeOfIssue")]
    public string? PlaceOfIssue { get; set; }

    [JsonPropertyName("validFrom")]
    public DateTime? ValidFrom { get; set; }

    [JsonPropertyName("validUntil")]
    public DateTime? ValidUntil { get; set; }

    [JsonPropertyName("firstIssue")]
    public DateTime? FirstIssue { get; set; }

    [JsonPropertyName("issueNumber")]
    public string? IssueNumber { get; set; }

    [JsonPropertyName("issuedBy")]
    public string? IssuedBy { get; set; }

    [JsonPropertyName("nfcValidated")]
    public string? NfcValidated { get; set; }

    [JsonPropertyName("residencePermitType")]
    public string? ResidencePermitType { get; set; }
}

public class AdditionalVerifiedData
{
    [JsonPropertyName("driversLicenseCategory")]
    public Dictionary<string, bool>? DriversLicenseCategory { get; set; }

    [JsonPropertyName("driversLicenseCategoryFrom")]
    public Dictionary<string, DateTime>? DriversLicenseCategoryFrom { get; set; }

    [JsonPropertyName("driversLicenseCategoryUntil")]
    public Dictionary<string, DateTime>? DriversLicenseCategoryUntil { get; set; }

    [JsonPropertyName("estimatedAge")]
    public int? EstimatedAge { get; set; }

    [JsonPropertyName("estimatedGender")]
    public double? EstimatedGender { get; set; }

    [JsonPropertyName("processNumber")]
    public string? ProcessNumber { get; set; }

    [JsonPropertyName("driversLicenseNumber")]
    public string? DriversLicenseNumber { get; set; }

    [JsonPropertyName("cpfValidated")]
    public CpfValidated? CpfValidated { get; set; }

    [JsonPropertyName("ineBiometricRegistryValidation")]
    public IneBiometricRegistryValidation? IneBiometricRegistryValidation { get; set; }
}

public class CpfValidated
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("cpfNumber")]
    public string? CpfNumber { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("dateOfBirth")]
    public DateTime? DateOfBirth { get; set; }

    [JsonPropertyName("yearOfDeath")]
    public string? YearOfDeath { get; set; }
}

public class IneBiometricRegistryValidation
{
    [JsonPropertyName("faceMatch")]
    public bool? FaceMatch { get; set; }

    [JsonPropertyName("faceMatchPercentage")]
    public int? FaceMatchPercentage { get; set; }

    [JsonPropertyName("responseStatus")]
    public string? ResponseStatus { get; set; }
}

public class RiskScore
{
    [JsonPropertyName("score")]
    public double? Score { get; set; }
}

public class RiskLabel
{
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("sessionIds")]
    public List<string>? SessionIds { get; set; }
}

public class BiometricAuthentication
{
    [JsonPropertyName("matchedSessionId")]
    public string? MatchedSessionId { get; set; }

    [JsonPropertyName("matchedSessionVendorData")]
    public string? MatchedSessionVendorData { get; set; }
}

public class TechnicalData
{
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}
