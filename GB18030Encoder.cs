internal class GB18030Encoder : MonoEncoder // TypeDefIndex: 7832
{	// Fields
	private static DbcsConvert gb2312; // 0x0
	private char incomplete_byte_count; // 0x28
	private char incomplete_bytes; // 0x2A

	// Methods

	// RVA: 0x2245750 Offset: 0x2244B50 VA: 0x182245750
	public void .ctor(MonoEncoding owner) { }

	// RVA: 0x224A400 Offset: 0x2249800 VA: 0x18224A400
	private static void .cctor() { }

	// RVA: 0x2249D60 Offset: 0x2249160 VA: 0x182249D60 Slot: 11
	public override int GetByteCountImpl(char* chars, int count, bool refresh) { }

	// RVA: 0x2249F70 Offset: 0x2249370 VA: 0x182249F70 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh) { }

}

