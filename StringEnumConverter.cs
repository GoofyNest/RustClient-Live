public class StringEnumConverter : JsonConverter // TypeDefIndex: 6106
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <CamelCaseText>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <AllowIntegerValues>k__BackingField; // 0x11

	// Properties
	public bool CamelCaseText { get; }
	public bool AllowIntegerValues { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_CamelCaseText() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF86260 Offset: 0xF85660 VA: 0x180F86260
	public bool get_AllowIntegerValues() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF86270 Offset: 0xF85670 VA: 0x180F86270
	public void set_AllowIntegerValues(bool value) { }

	// RVA: 0xF98270 Offset: 0xF97670 VA: 0x180F98270
	public void .ctor() { }

	// RVA: 0xF980B0 Offset: 0xF974B0 VA: 0x180F980B0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF97CC0 Offset: 0xF970C0 VA: 0x180F97CC0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF97C50 Offset: 0xF97050 VA: 0x180F97C50 Slot: 6
	public override bool CanConvert(Type objectType) { }

}

