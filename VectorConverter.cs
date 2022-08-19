public class VectorConverter : JsonConverter // TypeDefIndex: 6107
{	// Fields
	private static readonly Type V2; // 0x0
	private static readonly Type V3; // 0x8
	private static readonly Type V4; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <EnableVector2>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <EnableVector3>k__BackingField; // 0x11
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <EnableVector4>k__BackingField; // 0x12

	// Properties
	public bool EnableVector2 { get; set; }
	public bool EnableVector3 { get; set; }
	public bool EnableVector4 { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_EnableVector2() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E50 Offset: 0x497250 VA: 0x180497E50
	public void set_EnableVector2(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF86260 Offset: 0xF85660 VA: 0x180F86260
	public bool get_EnableVector3() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF86270 Offset: 0xF85670 VA: 0x180F86270
	public void set_EnableVector3(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF99010 Offset: 0xF98410 VA: 0x180F99010
	public bool get_EnableVector4() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF99020 Offset: 0xF98420 VA: 0x180F99020
	public void set_EnableVector4(bool value) { }

	// RVA: 0xF98FF0 Offset: 0xF983F0 VA: 0x180F98FF0
	public void .ctor() { }

	// RVA: 0xF98AA0 Offset: 0xF97EA0 VA: 0x180F98AA0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF98DA0 Offset: 0xF981A0 VA: 0x180F98DA0
	private static void WriteVector(JsonWriter writer, float x, float y, Nullable<float> z, Nullable<float> w) { }

	// RVA: 0xF98670 Offset: 0xF97A70 VA: 0x180F98670 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF98290 Offset: 0xF97690 VA: 0x180F98290 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xF98380 Offset: 0xF97780 VA: 0x180F98380
	private static Vector2 PopulateVector2(JsonReader reader) { }

	// RVA: 0xF98460 Offset: 0xF97860 VA: 0x180F98460
	private static Vector3 PopulateVector3(JsonReader reader) { }

	// RVA: 0xF98550 Offset: 0xF97950 VA: 0x180F98550
	private static Vector4 PopulateVector4(JsonReader reader) { }

	// RVA: 0xF98F20 Offset: 0xF98320 VA: 0x180F98F20
	private static void .cctor() { }

}

