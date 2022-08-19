public class ISO2022JPEncoding : MonoEncoding // TypeDefIndex: 7803
{	// Fields
	private readonly bool allow_1byte_kana; // 0x40
	private readonly bool allow_shift_io; // 0x41

	// Properties
	public override string BodyName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x224D610 Offset: 0x224CA10 VA: 0x18224D610
	public void .ctor(int codePage, bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x224D650 Offset: 0x224CA50 VA: 0x18224D650 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224D680 Offset: 0x224CA80 VA: 0x18224D680 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224D6B0 Offset: 0x224CAB0 VA: 0x18224D6B0 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x224D600 Offset: 0x224CA00 VA: 0x18224D600 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x797E80 Offset: 0x797280 VA: 0x180797E80 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x224D330 Offset: 0x224C730 VA: 0x18224D330 Slot: 19
	public override int GetByteCount(char[] chars, int charIndex, int charCount) { }

	// RVA: 0x224D280 Offset: 0x224C680 VA: 0x18224D280 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224D3F0 Offset: 0x224C7F0 VA: 0x18224D3F0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224D4C0 Offset: 0x224C8C0 VA: 0x18224D4C0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224D560 Offset: 0x224C960 VA: 0x18224D560 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

}

