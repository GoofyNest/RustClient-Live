public class TextElementEnumerator : IEnumerator // TypeDefIndex: 718
{	// Fields
	private string str; // 0x10
	private int index; // 0x18
	private int startIndex; // 0x1C
	private int strLen; // 0x20
	private int currTextElementLen; // 0x24
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private UnicodeCategory uc; // 0x28
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private int charLen; // 0x2C
	private int endIndex; // 0x30
	private int nextTextElementLen; // 0x34

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1382440 Offset: 0x1381840 VA: 0x181382440
	internal void .ctor(string str, int startIndex, int strLen) { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1382360 Offset: 0x1381760 VA: 0x181382360
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13822C0 Offset: 0x13816C0 VA: 0x1813822C0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1382370 Offset: 0x1381770 VA: 0x181382370
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1382120 Offset: 0x1381520 VA: 0x181382120 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1382040 Offset: 0x1381440 VA: 0x181382040 Slot: 5
	public object get_Current() { }

	// RVA: 0x1382040 Offset: 0x1381440 VA: 0x181382040
	public string GetTextElement() { }

	// RVA: 0x1382380 Offset: 0x1381780 VA: 0x181382380 Slot: 6
	public void Reset() { }

	// RVA: 0x1382410 Offset: 0x1381810 VA: 0x181382410
	internal void .ctor() { }

}

