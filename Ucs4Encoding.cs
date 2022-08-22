internal class Ucs4Encoding : Encoding // TypeDefIndex: 2014
{	internal Ucs4Decoder ucs4Decoder; // 0x38

	public override string WebName { get; }
	public override int CodePage { get; }
	internal static Encoding UCS4_Littleendian { get; }
	internal static Encoding UCS4_Bigendian { get; }
	internal static Encoding UCS4_2143 { get; }
	internal static Encoding UCS4_3412 { get; }


	public override string get_WebName() { }

	public override Decoder GetDecoder() { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override byte[] GetBytes(string s) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override int get_CodePage() { }

	public override Encoder GetEncoder() { }

	internal static Encoding get_UCS4_Littleendian() { }

	internal static Encoding get_UCS4_Bigendian() { }

	internal static Encoding get_UCS4_2143() { }

	internal static Encoding get_UCS4_3412() { }

	public void .ctor() { }

}

