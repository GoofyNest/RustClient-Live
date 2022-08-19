public class UTF7Encoding : Encoding // TypeDefIndex: 469
{	// Fields
	private byte[] base64Bytes; // 0x38
	private sbyte[] base64Values; // 0x40
	private bool[] directEncode; // 0x48
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private bool m_allowOptionals; // 0x50

	// Methods

	// RVA: 0x1924310 Offset: 0x1923710 VA: 0x181924310
	public void .ctor() { }

	// RVA: 0x19242A0 Offset: 0x19236A0 VA: 0x1819242A0
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x1923E90 Offset: 0x1923290 VA: 0x181923E90
	private void MakeTables() { }

	// RVA: 0x19241F0 Offset: 0x19235F0 VA: 0x1819241F0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1915540 Offset: 0x1914940 VA: 0x181915540
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1924120 Offset: 0x1923520 VA: 0x181924120
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x19220F0 Offset: 0x19214F0 VA: 0x1819220F0 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x1923B10 Offset: 0x1922F10 VA: 0x181923B10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1922310 Offset: 0x1921710 VA: 0x181922310 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x19224A0 Offset: 0x19218A0 VA: 0x1819224A0 Slot: 18
	public override int GetByteCount(string s) { }

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x1922210 Offset: 0x1921610 VA: 0x181922210 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x1922E10 Offset: 0x1922210 VA: 0x181922E10 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1922540 Offset: 0x1921940 VA: 0x181922540 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x1922CD0 Offset: 0x19220D0 VA: 0x181922CD0 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1923170 Offset: 0x1922570 VA: 0x181923170 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x1923070 Offset: 0x1922470 VA: 0x181923070 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x19237B0 Offset: 0x1922BB0 VA: 0x1819237B0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x1923670 Offset: 0x1922A70 VA: 0x181923670 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x1923D00 Offset: 0x1923100 VA: 0x181923D00 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x19221E0 Offset: 0x19215E0 VA: 0x1819221E0 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x19227A0 Offset: 0x1921BA0 VA: 0x1819227A0 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1923300 Offset: 0x1922700 VA: 0x181923300 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1923330 Offset: 0x1922730 VA: 0x181923330 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1923A10 Offset: 0x1922E10 VA: 0x181923A10 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x1923A70 Offset: 0x1922E70 VA: 0x181923A70 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x1923B90 Offset: 0x1922F90 VA: 0x181923B90 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1923C70 Offset: 0x1923070 VA: 0x181923C70 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

}

private class UTF7Encoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 470
{	// Fields
	internal int bits; // 0x30
	internal int bitCount; // 0x34
	internal bool firstByte; // 0x38

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x149F5E0 Offset: 0x149E9E0 VA: 0x18149F5E0
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x190D5D0 Offset: 0x190C9D0 VA: 0x18190D5D0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x190D500 Offset: 0x190C900 VA: 0x18190D500 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x190D4D0 Offset: 0x190C8D0 VA: 0x18190D4D0 Slot: 4
	public override void Reset() { }

	// RVA: 0x190D810 Offset: 0x190CC10 VA: 0x18190D810 Slot: 14
	internal override bool get_HasState() { }

}

private class UTF7Encoding.Encoder : EncoderNLS, ISerializable // TypeDefIndex: 471
{	// Fields
	internal int bits; // 0x38
	internal int bitCount; // 0x3C

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x190F7B0 Offset: 0x190EBB0 VA: 0x18190F7B0
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x1910230 Offset: 0x190F630 VA: 0x181910230
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1910180 Offset: 0x190F580 VA: 0x181910180 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1910150 Offset: 0x190F550 VA: 0x181910150 Slot: 4
	public override void Reset() { }

	// RVA: 0x1910450 Offset: 0x190F850 VA: 0x181910450 Slot: 12
	internal override bool get_HasState() { }

}

internal sealed class UTF7Encoding.DecoderUTF7Fallback : DecoderFallback // TypeDefIndex: 472
{	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0x190D420 Offset: 0x190C820 VA: 0x18190D420 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x190D470 Offset: 0x190C870 VA: 0x18190D470 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x190D4C0 Offset: 0x190C8C0 VA: 0x18190D4C0 Slot: 2
	public override int GetHashCode() { }

}

internal sealed class UTF7Encoding.DecoderUTF7FallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 473
{	// Fields
	private char cFallback; // 0x20
	private int iCount; // 0x24
	private int iSize; // 0x28

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x190D400 Offset: 0x190C800 VA: 0x18190D400
	public void .ctor(UTF7Encoding.DecoderUTF7Fallback fallback) { }

	// RVA: 0x190D2F0 Offset: 0x190C6F0 VA: 0x18190D2F0 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x190D340 Offset: 0x190C740 VA: 0x18190D340 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x190D410 Offset: 0x190C810 VA: 0x18190D410 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x190D3F0 Offset: 0x190C7F0 VA: 0x18190D3F0 Slot: 7
	public override void Reset() { }

	// RVA: 0x190D360 Offset: 0x190C760 VA: 0x18190D360 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

}

