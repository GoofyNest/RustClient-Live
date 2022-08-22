internal class BinHexDecoder : IncrementalReadDecoder // TypeDefIndex: 1816
{	private byte[] buffer; // 0x10
	private int curIndex; // 0x18
	private int endIndex; // 0x1C
	private bool hasHalfByteCached; // 0x20
	private byte cachedHalfByte; // 0x21

	internal override bool IsFull { get; }


	internal override bool get_IsFull() { }

	internal override int Decode(char[] chars, int startPos, int len) { }

	public static byte[] Decode(char[] chars, bool allowOddChars) { }

	private static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }

}

