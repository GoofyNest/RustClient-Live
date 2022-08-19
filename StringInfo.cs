public class StringInfo // TypeDefIndex: 716
{	// Fields
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private string m_str; // 0x10
	private int[] m_indexes; // 0x18

	// Properties
	public string String { set; }

	// Methods

	// RVA: 0x1381840 Offset: 0x1380C40 VA: 0x181381840
	public void .ctor() { }

	// RVA: 0x1381910 Offset: 0x1380D10 VA: 0x181381910
	public void .ctor(string value) { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13817F0 Offset: 0x1380BF0 VA: 0x1813817F0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13817B0 Offset: 0x1380BB0 VA: 0x1813817B0
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x1381280 Offset: 0x1380680 VA: 0x181381280 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0xDDCF60 Offset: 0xDDC360 VA: 0x180DDCF60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13819C0 Offset: 0x1380DC0 VA: 0x1813819C0
	public void set_String(string value) { }

	// RVA: 0x1381320 Offset: 0x1380720 VA: 0x181381320
	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount) { }

	// RVA: 0x13814C0 Offset: 0x13808C0 VA: 0x1813814C0
	public static TextElementEnumerator GetTextElementEnumerator(string str) { }

	// RVA: 0x1381630 Offset: 0x1380A30 VA: 0x181381630
	public static TextElementEnumerator GetTextElementEnumerator(string str, int index) { }

}

