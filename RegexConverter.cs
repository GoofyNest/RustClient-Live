public class RegexConverter : JsonConverter // TypeDefIndex: 6114
{

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	private void WriteBson(BsonWriter writer, Regex regex) { }

	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	private object ReadRegexString(JsonReader reader) { }

	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	public override bool CanConvert(Type objectType) { }

	public void .ctor() { }

}

