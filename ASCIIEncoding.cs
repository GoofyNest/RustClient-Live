public class ASCIIEncoding : Encoding // TypeDefIndex: 432
{	// Properties
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override bool IsSingleByte { get; }

	// Methods

	// RVA: 0x18A6120 Offset: 0x18A5520 VA: 0x1818A6120
	public void .ctor() { }

	// RVA: 0x18A60E0 Offset: 0x18A54E0 VA: 0x1818A60E0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x18A4380 Offset: 0x18A3780 VA: 0x1818A4380 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x18A42E0 Offset: 0x18A36E0 VA: 0x1818A42E0 Slot: 18
	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x18A3E90 Offset: 0x18A3290 VA: 0x1818A3E90 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x18A4510 Offset: 0x18A3910 VA: 0x1818A4510 Slot: 26
	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x18A4770 Offset: 0x18A3B70 VA: 0x1818A4770 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x18A49D0 Offset: 0x18A3DD0 VA: 0x1818A49D0 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x18A5150 Offset: 0x18A4550 VA: 0x1818A5150 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x18A5050 Offset: 0x18A4450 VA: 0x1818A5050 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x18A55A0 Offset: 0x18A49A0 VA: 0x1818A55A0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x18A5460 Offset: 0x18A4860 VA: 0x1818A5460 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x18A5EA0 Offset: 0x18A52A0 VA: 0x1818A5EA0 Slot: 43
	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	// RVA: 0x18A3F90 Offset: 0x18A3390 VA: 0x1818A3F90 Slot: 21
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x18A4B10 Offset: 0x18A3F10 VA: 0x1818A4B10 Slot: 27
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x18A52E0 Offset: 0x18A46E0 VA: 0x1818A52E0 Slot: 31
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x18A5800 Offset: 0x18A4C00 VA: 0x1818A5800 Slot: 35
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x18A5C60 Offset: 0x18A5060 VA: 0x1818A5C60 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x18A5D80 Offset: 0x18A5180 VA: 0x1818A5D80 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 16
	public override bool get_IsSingleByte() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18A5B60 Offset: 0x18A4F60 VA: 0x1818A5B60 Slot: 38
	public override Decoder GetDecoder() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18A5C00 Offset: 0x18A5000 VA: 0x1818A5C00 Slot: 39
	public override Encoder GetEncoder() { }

}

