namespace NistWebApi.Service.Model;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, WriteIndented = true, AllowTrailingCommas = true, NumberHandling = JsonNumberHandling.AllowReadingFromString)]
[JsonSerializable(typeof(CpePageModel))]
[JsonSerializable(typeof(MatchPageModel))]
[JsonSerializable(typeof(CvePageModel))]
[JsonSerializable(typeof(HistoryPageModel))]
internal partial class SourceGenerationContext : JsonSerializerContext
{ }

