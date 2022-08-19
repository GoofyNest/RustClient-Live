public class GB18030Encoding : MonoEncoding // TypeDefIndex: 7830
{	// Properties
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string BodyName { get; }
	public override string WebName { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }

	// Methods

	// RVA: 0x2245E60 Offset: 0x2245260 VA: 0x182245E60
	public void .ctor() { }

	// RVA: 0x224A8C0 Offset: 0x2249CC0 VA: 0x18224A8C0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224A8F0 Offset: 0x2249CF0 VA: 0x18224A8F0 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224A890 Offset: 0x2249C90 VA: 0x18224A890 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224A920 Offset: 0x2249D20 VA: 0x18224A920 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x224A880 Offset: 0x2249C80 VA: 0x18224A880 Slot: 40
	public override int GetMaxByteCount(int len) { }

	// RVA: 0x797E80 Offset: 0x797280 VA: 0x180797E80 Slot: 41
	public override int GetMaxCharCount(int len) { }

	// RVA: 0x224A510 Offset: 0x2249910 VA: 0x18224A510 Slot: 19
	public override int GetByteCount(char[] chars, int index, int length) { }

	// RVA: 0x224A470 Offset: 0x2249870 VA: 0x18224A470 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224A5C0 Offset: 0x22499C0 VA: 0x18224A5C0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224A680 Offset: 0x2249A80 VA: 0x18224A680 Slot: 29
	public override int GetCharCount(byte[] bytes, int start, int len) { }

	// RVA: 0x224A720 Offset: 0x2249B20 VA: 0x18224A720 Slot: 33
	public override int GetChars(byte[] bytes, int byteIdx, int srclen, char[] chars, int charIdx) { }

	// RVA: 0x224A820 Offset: 0x2249C20 VA: 0x18224A820 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x224A7C0 Offset: 0x2249BC0 VA: 0x18224A7C0 Slot: 38
	public override Decoder GetDecoder() { }

}

