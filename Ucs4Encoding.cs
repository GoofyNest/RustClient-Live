internal class Ucs4Encoding : Encoding // TypeDefIndex: 2014
{	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Properties
	public override string WebName { get; }
	public override int CodePage { get; }
	internal static Encoding UCS4_Littleendian { get; }
	internal static Encoding UCS4_Bigendian { get; }
	internal static Encoding UCS4_2143 { get; }
	internal static Encoding UCS4_3412 { get; }

	// Methods

	// RVA: 0x4BF5F0 Offset: 0x4BE9F0 VA: 0x1804BF5F0 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0xE49BA0 Offset: 0xE48FA0 VA: 0x180E49BA0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 25
	public override byte[] GetBytes(string s) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0xE49C00 Offset: 0xE49000 VA: 0x180E49C00 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0xE49C30 Offset: 0xE49030 VA: 0x180E49C30 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0xE49C60 Offset: 0xE49060 VA: 0x180E49C60 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 36
	public override int get_CodePage() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0xE49EF0 Offset: 0xE492F0 VA: 0x180E49EF0
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0xE49E20 Offset: 0xE49220 VA: 0x180E49E20
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0xE49C80 Offset: 0xE49080 VA: 0x180E49C80
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0xE49D50 Offset: 0xE49150 VA: 0x180E49D50
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0xE49C70 Offset: 0xE49070 VA: 0x180E49C70
	public void .ctor() { }

}

