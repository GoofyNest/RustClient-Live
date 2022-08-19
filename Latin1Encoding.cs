internal class Latin1Encoding : EncodingNLS, ISerializable // TypeDefIndex: 462
{	// Fields
	private static readonly char[] arrayCharBestFit; // 0x12F70

	// Properties
	public override bool IsSingleByte { get; }

	// Methods

	// RVA: 0x19181B0 Offset: 0x19175B0 VA: 0x1819181B0
	public void .ctor() { }

	// RVA: 0x1918120 Offset: 0x1917520 VA: 0x181918120
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1917F30 Offset: 0x1917330 VA: 0x181917F30 Slot: 46
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1917550 Offset: 0x1916950 VA: 0x181917550 Slot: 21
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x1917740 Offset: 0x1916B40 VA: 0x181917740 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1917BD0 Offset: 0x1916FD0 VA: 0x181917BD0 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x1917BE0 Offset: 0x1916FE0 VA: 0x181917BE0 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x1917CE0 Offset: 0x19170E0 VA: 0x181917CE0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1917E00 Offset: 0x1917200 VA: 0x181917E00 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 16
	public override bool get_IsSingleByte() { }

	// RVA: 0x1917F20 Offset: 0x1917320 VA: 0x181917F20 Slot: 37
	public override bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x19174F0 Offset: 0x19168F0 VA: 0x1819174F0 Slot: 44
	internal override char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x19180B0 Offset: 0x19174B0 VA: 0x1819180B0
	private static void .cctor() { }

}

