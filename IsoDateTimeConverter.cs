public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 6109
{	// Fields
	private DateTimeStyles _dateTimeStyles; // 0x10
	private string _dateTimeFormat; // 0x18
	private CultureInfo _culture; // 0x20

	// Properties
	public CultureInfo Culture { get; }

	// Methods

	// RVA: 0xF84200 Offset: 0xF83600 VA: 0x180F84200
	public CultureInfo get_Culture() { }

	// RVA: 0xF83F80 Offset: 0xF83380 VA: 0x180F83F80 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF839D0 Offset: 0xF82DD0 VA: 0x180F839D0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF841F0 Offset: 0xF835F0 VA: 0x180F841F0
	public void .ctor() { }

}

