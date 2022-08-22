public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 6109
{	private DateTimeStyles _dateTimeStyles; // 0x10
	private string _dateTimeFormat; // 0x18
	private CultureInfo _culture; // 0x20

	public CultureInfo Culture { get; }


	public CultureInfo get_Culture() { }

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public void .ctor() { }

}

