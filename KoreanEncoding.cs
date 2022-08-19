internal class KoreanEncoding : DbcsEncoding // TypeDefIndex: 7817
{	// Fields
	private bool useUHC; // 0x40

	// Methods

	// RVA: 0x224E660 Offset: 0x224DA60 VA: 0x18224E660
	public void .ctor(int codepage, bool useUHC) { }

	// RVA: 0x224E570 Offset: 0x224D970 VA: 0x18224E570 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x224E2A0 Offset: 0x224D6A0 VA: 0x18224E2A0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224E3A0 Offset: 0x224D7A0 VA: 0x18224E3A0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2247AA0 Offset: 0x2246EA0 VA: 0x182247AA0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2247B10 Offset: 0x2246F10 VA: 0x182247B10 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224E5D0 Offset: 0x224D9D0 VA: 0x18224E5D0 Slot: 38
	public override Decoder GetDecoder() { }

}

private sealed class KoreanEncoding.KoreanDecoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7818
{	// Fields
	private bool useUHC; // 0x28
	private int last_byte_count; // 0x2C
	private int last_byte_conv; // 0x30

	// Methods

	// RVA: 0x224E250 Offset: 0x224D650 VA: 0x18224E250
	public void .ctor(DbcsConvert convert, bool useUHC) { }

	// RVA: 0x224DE00 Offset: 0x224D200 VA: 0x18224DE00 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224DB40 Offset: 0x224CF40 VA: 0x18224DB40 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x224DE20 Offset: 0x224D220 VA: 0x18224DE20 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224DE50 Offset: 0x224D250 VA: 0x18224DE50 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

