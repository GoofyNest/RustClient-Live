public class VectorConverter : JsonConverter // TypeDefIndex: 6116
{
	private static readonly Type V2;
	private static readonly Type V3;
	private static readonly Type V4;
	[CompilerGeneratedAttribute]
	private bool <EnableVector2>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <EnableVector3>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <EnableVector4>k__BackingField;

	public bool EnableVector2 { get; set; }
	public bool EnableVector3 { get; set; }
	public bool EnableVector4 { get; set; }


	[CompilerGeneratedAttribute]
	public bool get_EnableVector2() { }

	[CompilerGeneratedAttribute]
	public void set_EnableVector2(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_EnableVector3() { }

	[CompilerGeneratedAttribute]
	public void set_EnableVector3(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_EnableVector4() { }

	[CompilerGeneratedAttribute]
	public void set_EnableVector4(bool value) { }

	public void .ctor() { }

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	private static void WriteVector(JsonWriter writer, float x, float y, Nullable<float> z, Nullable<float> w) { }

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public override bool CanConvert(Type objectType) { }

	private static Vector2 PopulateVector2(JsonReader reader) { }

	private static Vector3 PopulateVector3(JsonReader reader) { }

	private static Vector4 PopulateVector4(JsonReader reader) { }

	private static void .cctor() { }

}

