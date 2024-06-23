# VeriffDotNet
.NET client for the [Veriff](https://www.veriff.com/) API.

# Usage

1. Add configuration (for optional values see [options](Veriff.net/Shared/CollectionExtensions.cs))
   ```yaml
   "Veriff": {
    "BaseUrl": "https://stationapi.veriff.com",
    "ApiKey": null,
    "SecretKey": null
   ```

2. Register services (see [Veriff.netTest](VeriffTest/Program.cs))
   ```csharp
    builder.Services.Configure<VeriffConfig>(builder.Configuration.GetRequiredSection("Veriff"));
    builder.Services.AddVeriffDotNet();
   ```
# Known issues