internal class UTF16Decoder : Decoder // TypeDefIndex: 2012
{	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0xE486F0 Offset: 0xE47AF0 VA: 0x180E486F0
	public void .ctor(bool bigEndian) { }

	// RVA: 0xE483C0 Offset: 0xE477C0 VA: 0x180E483C0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0xE482D0 Offset: 0xE476D0 VA: 0x180E482D0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0xE483F0 Offset: 0xE477F0 VA: 0x180E483F0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0xE47F60 Offset: 0xE47360 VA: 0x180E47F60 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

}

