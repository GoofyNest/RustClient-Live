public class UnicodeEncoding : Encoding // TypeDefIndex: 465
{	// Fields
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal bool isThrowException; // 0x38
	internal bool bigEndian; // 0x39
	internal bool byteOrderMark; // 0x3A
	private static readonly ulong highLowPatternMask; // 0x0

	// Methods

	// RVA: 0x14A3940 Offset: 0x14A2D40 VA: 0x1814A3940
	public void .ctor() { }

	// RVA: 0x14A3880 Offset: 0x14A2C80 VA: 0x1814A3880
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x14A38D0 Offset: 0x14A2CD0 VA: 0x1814A38D0
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14A3720 Offset: 0x14A2B20 VA: 0x1814A3720
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x14A3730 Offset: 0x14A2B30 VA: 0x1814A3730 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x14A05E0 Offset: 0x149F9E0 VA: 0x1814A05E0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x149FD00 Offset: 0x149F100 VA: 0x18149FD00 Slot: 18
	public override int GetByteCount(string s) { }

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x149FDA0 Offset: 0x149F1A0 VA: 0x18149FDA0 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x14A10D0 Offset: 0x14A04D0 VA: 0x1814A10D0 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x14A1470 Offset: 0x14A0870 VA: 0x1814A1470 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x14A1330 Offset: 0x14A0730 VA: 0x1814A1330 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x14A20E0 Offset: 0x14A14E0 VA: 0x1814A20E0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x14A16D0 Offset: 0x14A0AD0 VA: 0x1814A16D0 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x14A2270 Offset: 0x14A1670 VA: 0x1814A2270 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x14A24D0 Offset: 0x14A18D0 VA: 0x1814A24D0 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x14A3590 Offset: 0x14A2990 VA: 0x1814A3590 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x149FEA0 Offset: 0x149F2A0 VA: 0x18149FEA0 Slot: 21
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x14A0770 Offset: 0x149FB70 VA: 0x1814A0770 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x14A17D0 Offset: 0x14A0BD0 VA: 0x1814A17D0 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x14A2610 Offset: 0x14A1A10 VA: 0x1814A2610 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x14A3120 Offset: 0x14A2520 VA: 0x1814A3120 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x14A30C0 Offset: 0x14A24C0 VA: 0x1814A30C0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x14A3480 Offset: 0x14A2880 VA: 0x1814A3480 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x14A3220 Offset: 0x14A2620 VA: 0x1814A3220 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x14A3350 Offset: 0x14A2750 VA: 0x1814A3350 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x149FBE0 Offset: 0x149EFE0 VA: 0x18149FBE0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x14A3180 Offset: 0x14A2580 VA: 0x1814A3180 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14A3800 Offset: 0x14A2C00 VA: 0x1814A3800
	private static void .cctor() { }

}

private class UnicodeEncoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 466
{	// Fields
	internal int lastByte; // 0x30
	internal char lastChar; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x148D410 Offset: 0x148C810 VA: 0x18148D410
	public void .ctor(UnicodeEncoding encoding) { }

	// RVA: 0x148D420 Offset: 0x148C820 VA: 0x18148D420
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x148D290 Offset: 0x148C690 VA: 0x18148D290 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x148D260 Offset: 0x148C660 VA: 0x18148D260 Slot: 4
	public override void Reset() { }

	// RVA: 0x148D780 Offset: 0x148CB80 VA: 0x18148D780 Slot: 14
	internal override bool get_HasState() { }

}

