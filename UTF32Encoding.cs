public sealed class UTF32Encoding : Encoding // TypeDefIndex: 467
{	// Fields
	private bool emitUTF32ByteOrderMark; // 0x38
	private bool isThrowException; // 0x39
	private bool bigEndian; // 0x3A

	// Methods

	// RVA: 0x19220B0 Offset: 0x19214B0 VA: 0x1819220B0
	public void .ctor() { }

	// RVA: 0x1921FE0 Offset: 0x19213E0 VA: 0x181921FE0
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x1922030 Offset: 0x1921430 VA: 0x181922030
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	// RVA: 0x1921F10 Offset: 0x1921310 VA: 0x181921F10 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x191F680 Offset: 0x191EA80 VA: 0x18191F680 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x191FCB0 Offset: 0x191F0B0 VA: 0x18191FCB0 Slot: 18
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x191F810 Offset: 0x191EC10 VA: 0x18191F810 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1920630 Offset: 0x191FA30 VA: 0x181920630 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19203D0 Offset: 0x191F7D0 VA: 0x1819203D0 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x191FD50 Offset: 0x191F150 VA: 0x18191FD50 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1920990 Offset: 0x191FD90 VA: 0x181920990 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1920890 Offset: 0x191FC90 VA: 0x181920890 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x19214D0 Offset: 0x19208D0 VA: 0x1819214D0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1921730 Offset: 0x1920B30 VA: 0x181921730 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1921D60 Offset: 0x1921160 VA: 0x181921D60 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x191F910 Offset: 0x191ED10 VA: 0x18191F910 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x191FE90 Offset: 0x191F290 VA: 0x18191FE90 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1920B20 Offset: 0x191FF20 VA: 0x181920B20 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1920F10 Offset: 0x1920310 VA: 0x181920F10 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1921EF0 Offset: 0x19212F0 VA: 0x181921EF0
	private uint GetSurrogate(char cHigh, char cLow) { }

	// RVA: 0x1921A10 Offset: 0x1920E10 VA: 0x181921A10
	private char GetHighSurrogate(uint iChar) { }

	// RVA: 0x1921A30 Offset: 0x1920E30 VA: 0x181921A30
	private char GetLowSurrogate(uint iChar) { }

	// RVA: 0x1921870 Offset: 0x1920C70 VA: 0x181921870 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x19218D0 Offset: 0x1920CD0 VA: 0x1819218D0 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x1921A50 Offset: 0x1920E50 VA: 0x181921A50 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1921B80 Offset: 0x1920F80 VA: 0x181921B80 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1921C50 Offset: 0x1921050 VA: 0x181921C50 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x191F5B0 Offset: 0x191E9B0 VA: 0x18191F5B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1921970 Offset: 0x1920D70 VA: 0x181921970 Slot: 2
	public override int GetHashCode() { }

}

internal class UTF32Encoding.UTF32Decoder : DecoderNLS // TypeDefIndex: 468
{	// Fields
	internal int iChar; // 0x30
	internal int readByteCount; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x149F5E0 Offset: 0x149E9E0 VA: 0x18149F5E0
	public void .ctor(UTF32Encoding encoding) { }

	// RVA: 0x191F580 Offset: 0x191E980 VA: 0x18191F580 Slot: 4
	public override void Reset() { }

	// RVA: 0x1787430 Offset: 0x1786830 VA: 0x181787430 Slot: 14
	internal override bool get_HasState() { }

}

