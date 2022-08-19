internal class DecoderNLS : Decoder, ISerializable // TypeDefIndex: 441
{	// Fields
	protected Encoding m_encoding; // 0x20
	protected bool m_mustFlush; // 0x28
	internal bool m_throwOnOverflow; // 0x29
	internal int m_bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x18A7D00 Offset: 0x18A7100 VA: 0x1818A7D00
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18A7B80 Offset: 0x18A6F80 VA: 0x1818A7B80 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18A7C50 Offset: 0x18A7050 VA: 0x1818A7C50
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x18A7CC0 Offset: 0x18A70C0 VA: 0x1818A7CC0
	internal void .ctor() { }

	// RVA: 0x18A7B60 Offset: 0x18A6F60 VA: 0x1818A7B60 Slot: 4
	public override void Reset() { }

	// RVA: 0xE483C0 Offset: 0xE477C0 VA: 0x180E483C0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x18A75A0 Offset: 0x18A69A0 VA: 0x1818A75A0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x18A7480 Offset: 0x18A6880 VA: 0x1818A7480 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x18A7B20 Offset: 0x18A6F20 VA: 0x1818A7B20 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x18A7750 Offset: 0x18A6B50 VA: 0x1818A7750 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x18A79D0 Offset: 0x18A6DD0 VA: 0x1818A79D0 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x18A7170 Offset: 0x18A6570 VA: 0x1818A7170 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x18A6FA0 Offset: 0x18A63A0 VA: 0x1818A6FA0 Slot: 12
	public override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0
	public bool get_MustFlush() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 14
	internal virtual bool get_HasState() { }

	// RVA: 0x18A6F90 Offset: 0x18A6390 VA: 0x1818A6F90
	internal void ClearMustFlush() { }

}

