public class UTF8Encoding : Encoding // TypeDefIndex: 474
{	// Fields
	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39

	// Methods

	// RVA: 0x1927DD0 Offset: 0x19271D0 VA: 0x181927DD0
	public void .ctor() { }

	// RVA: 0x1927D60 Offset: 0x1927160 VA: 0x181927D60
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x1927CD0 Offset: 0x19270D0 VA: 0x181927CD0
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x1927C00 Offset: 0x1927000 VA: 0x181927C00 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1924CC0 Offset: 0x19240C0 VA: 0x181924CC0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1924E50 Offset: 0x1924250 VA: 0x181924E50 Slot: 18
	public override int GetByteCount(string chars) { }

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x1924530 Offset: 0x1923930 VA: 0x181924530 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1925D20 Offset: 0x1925120 VA: 0x181925D20 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1925AC0 Offset: 0x1924EC0 VA: 0x181925AC0 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x1925F80 Offset: 0x1925380 VA: 0x181925F80 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x19266B0 Offset: 0x1925AB0 VA: 0x1819266B0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x19265B0 Offset: 0x19259B0 VA: 0x1819265B0 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1926980 Offset: 0x1925D80 VA: 0x181926980 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x1926840 Offset: 0x1925C40 VA: 0x181926840 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x1927A50 Offset: 0x1926E50 VA: 0x181927A50 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1924630 Offset: 0x1923A30 VA: 0x181924630 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1927BE0 Offset: 0x1926FE0 VA: 0x181927BE0
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x1927BF0 Offset: 0x1926FF0 VA: 0x181927BF0
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0xE533C0 Offset: 0xE527C0 VA: 0x180E533C0
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x1925220 Offset: 0x1924620 VA: 0x181925220 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x19260C0 Offset: 0x19254C0 VA: 0x1819260C0 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1926BE0 Offset: 0x1925FE0 VA: 0x181926BE0 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1924460 Offset: 0x1923860 VA: 0x181924460
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x19244E0 Offset: 0x19238E0 VA: 0x1819244E0
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x1924EF0 Offset: 0x19242F0 VA: 0x181924EF0
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x1927640 Offset: 0x1926A40 VA: 0x181927640 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x19276A0 Offset: 0x1926AA0 VA: 0x1819276A0 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x1927770 Offset: 0x1926B70 VA: 0x181927770 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1927890 Offset: 0x1926C90 VA: 0x181927890 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x19279B0 Offset: 0x1926DB0 VA: 0x1819279B0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1924370 Offset: 0x1923770 VA: 0x181924370 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1927700 Offset: 0x1926B00 VA: 0x181927700 Slot: 2
	public override int GetHashCode() { }

}

internal class UTF8Encoding.UTF8Encoder : EncoderNLS, ISerializable // TypeDefIndex: 475
{	// Fields
	internal int surrogateChar; // 0x38

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x149FBC0 Offset: 0x149EFC0 VA: 0x18149FBC0
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x149F960 Offset: 0x149ED60 VA: 0x18149F960
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x149F880 Offset: 0x149EC80 VA: 0x18149F880 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x149F850 Offset: 0x149EC50 VA: 0x18149F850 Slot: 4
	public override void Reset() { }

	// RVA: 0x149FBD0 Offset: 0x149EFD0 VA: 0x18149FBD0 Slot: 12
	internal override bool get_HasState() { }

}

internal class UTF8Encoding.UTF8Decoder : DecoderNLS, ISerializable // TypeDefIndex: 476
{	// Fields
	internal int bits; // 0x30

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x149F5E0 Offset: 0x149E9E0 VA: 0x18149F5E0
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x149F5F0 Offset: 0x149E9F0 VA: 0x18149F5F0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x149F4D0 Offset: 0x149E8D0 VA: 0x18149F4D0 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x149F4A0 Offset: 0x149E8A0 VA: 0x18149F4A0 Slot: 4
	public override void Reset() { }

	// RVA: 0xF3FDD0 Offset: 0xF3F1D0 VA: 0x180F3FDD0 Slot: 14
	internal override bool get_HasState() { }

}

