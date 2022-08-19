internal class BinHexDecoder : IncrementalReadDecoder // TypeDefIndex: 1816
{	// Fields
	private byte[] buffer; // 0x10
	private int curIndex; // 0x18
	private int endIndex; // 0x1C
	private bool hasHalfByteCached; // 0x20
	private byte cachedHalfByte; // 0x21

	// Properties
	internal override bool IsFull { get; }

	// Methods

	// RVA: 0x12D8BF0 Offset: 0x12D7FF0 VA: 0x1812D8BF0 Slot: 4
	internal override bool get_IsFull() { }

	// RVA: 0x12D89F0 Offset: 0x12D7DF0 VA: 0x1812D89F0 Slot: 5
	internal override int Decode(char[] chars, int startPos, int len) { }

	// RVA: 0x12D8650 Offset: 0x12D7A50 VA: 0x1812D8650
	public static byte[] Decode(char[] chars, bool allowOddChars) { }

	// RVA: 0x12D8860 Offset: 0x12D7C60 VA: 0x1812D8860
	private static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }

}

