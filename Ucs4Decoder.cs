internal abstract class Ucs4Decoder : Decoder // TypeDefIndex: 2019
{	// Fields
	internal byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0xE493E0 Offset: 0xE487E0 VA: 0x180E493E0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0xE493F0 Offset: 0xE487F0 VA: 0x180E493F0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0xE49180 Offset: 0xE48580 VA: 0x180E49180 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0xE495D0 Offset: 0xE489D0 VA: 0x180E495D0
	internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex) { }

	// RVA: 0xE489A0 Offset: 0xE47DA0 VA: 0x180E489A0
	protected void .ctor() { }

}

