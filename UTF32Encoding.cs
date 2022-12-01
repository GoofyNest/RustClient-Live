public sealed class UTF32Encoding : Encoding // TypeDefIndex: 467
{
	private bool emitUTF32ByteOrderMark;
	private bool isThrowException;
	private bool bigEndian;


	public void .ctor() { }

	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	internal override void SetDefaultFallbacks() { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute]
	public override int GetByteCount(char* chars, int count) { }

	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute]
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute]
	public override int GetCharCount(byte* bytes, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute]
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	public override string GetString(byte[] bytes, int index, int count) { }

	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	private uint GetSurrogate(char cHigh, char cLow) { }

	private char GetHighSurrogate(uint iChar) { }

	private char GetLowSurrogate(uint iChar) { }

	public override Decoder GetDecoder() { }

	public override Encoder GetEncoder() { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override byte[] GetPreamble() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

}

internal class UTF32Encoding.UTF32Decoder : DecoderNLS // TypeDefIndex: 468
{
	internal int iChar;
	internal int readByteCount;

	internal override bool HasState { get; }


	public void .ctor(UTF32Encoding encoding) { }

	public override void Reset() { }

	internal override bool get_HasState() { }

}

