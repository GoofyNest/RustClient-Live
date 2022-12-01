internal class BinHexDecoder : IncrementalReadDecoder // TypeDefIndex: 1816
{
	private byte[] buffer;
	private int curIndex;
	private int endIndex;
	private bool hasHalfByteCached;
	private byte cachedHalfByte;

	internal override bool IsFull { get; }


	internal override bool get_IsFull() { }

	internal override int Decode(char[] chars, int startPos, int len) { }

	public static byte[] Decode(char[] chars, bool allowOddChars) { }

	private static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }

}

