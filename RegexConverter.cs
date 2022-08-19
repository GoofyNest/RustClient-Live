public class RegexConverter : JsonConverter // TypeDefIndex: 6105
{	// Methods

	// RVA: 0xF97660 Offset: 0xF96A60 VA: 0x180F97660 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF96E90 Offset: 0xF96290 VA: 0x180F96E90
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0xF97450 Offset: 0xF96850 VA: 0x180F97450
	private void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0xF97AA0 Offset: 0xF96EA0 VA: 0x180F97AA0
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0xF96EA0 Offset: 0xF962A0 VA: 0x180F96EA0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF972F0 Offset: 0xF966F0 VA: 0x180F972F0
	private object ReadRegexString(JsonReader reader) { }

	// RVA: 0xF97090 Offset: 0xF96490 VA: 0x180F97090
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0xF96E20 Offset: 0xF96220 VA: 0x180F96E20 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

