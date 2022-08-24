internal abstract class Ucs4Decoder : Decoder // TypeDefIndex: 2019
{
	internal byte[] lastBytes; 
	internal int lastBytesCount; 


	public override int GetCharCount(byte[] bytes, int index, int count) { }

	internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex) { }

	protected void .ctor() { }

}

