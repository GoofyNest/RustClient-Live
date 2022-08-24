public class StringEnumConverter : JsonConverter // TypeDefIndex: 6106
{
	[CompilerGeneratedAttribute] 
	private bool <CamelCaseText>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <AllowIntegerValues>k__BackingField; 

public bool CamelCaseText { get; }
public bool AllowIntegerValues { get; set; }


	[CompilerGeneratedAttribute] 
public bool get_CamelCaseText() { }

	[CompilerGeneratedAttribute] 
public bool get_AllowIntegerValues() { }

	[CompilerGeneratedAttribute] 
public void set_AllowIntegerValues(bool value) { }

public void .ctor() { }

public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

public override bool CanConvert(Type objectType) { }

}

