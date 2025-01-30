namespace NISTWebApi.Service.Model;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, WriteIndented = true, AllowTrailingCommas = true, NumberHandling = JsonNumberHandling.AllowReadingFromString)]
[JsonSerializable(typeof(CPEPageModel))]
[JsonSerializable(typeof(CVEPageModel))]
internal partial class SourceGenerationContext : JsonSerializerContext
{ }

