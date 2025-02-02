namespace NISTWebApi.Service.Model;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, WriteIndented = true, AllowTrailingCommas = true, NumberHandling = JsonNumberHandling.AllowReadingFromString)]
[JsonSerializable(typeof(CPEPageModel))]
[JsonSerializable(typeof(MatchPageModel))]
[JsonSerializable(typeof(CVEPageModel))]
[JsonSerializable(typeof(HistoryPageModel))]
internal partial class SourceGenerationContext : JsonSerializerContext
{ }

