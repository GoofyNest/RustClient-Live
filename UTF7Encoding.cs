public class UTF7Encoding : Encoding // TypeDefIndex: 469
{
	private byte[] base64Bytes;
	private sbyte[] base64Values;
	private bool[] directEncode;
	[OptionalFieldAttribute]
	private bool m_allowOptionals;


	public void .ctor() { }

	public void .ctor(bool allowOptionals) { }

	private void MakeTables() { }

	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute]
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute]
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute]
	public override bool Equals(object value) { }

	[ComVisibleAttribute]
	public override int GetHashCode() { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute]
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute]
	[ComVisibleAttribute]
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute]
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute]
	[ComVisibleAttribute]
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute]
	[ComVisibleAttribute]
	public override int GetCharCount(byte* bytes, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute]
	[CLSCompliantAttribute]
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute]
	public override string GetString(byte[] bytes, int index, int count) { }

	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	public override Decoder GetDecoder() { }

	public override Encoder GetEncoder() { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

}

private class UTF7Encoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 470
{
	internal int bits;
	internal int bitCount;
	internal bool firstByte;

	internal override bool HasState { get; }


	public void .ctor(UTF7Encoding encoding) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override void Reset() { }

	internal override bool get_HasState() { }

}

private class UTF7Encoding.Encoder : EncoderNLS, ISerializable // TypeDefIndex: 471
{
	internal int bits;
	internal int bitCount;

	internal override bool HasState { get; }


	public void .ctor(UTF7Encoding encoding) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override void Reset() { }

	internal override bool get_HasState() { }

}

internal sealed class UTF7Encoding.DecoderUTF7Fallback : DecoderFallback // TypeDefIndex: 472
{
	public override int MaxCharCount { get; }


	public void .ctor() { }

	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	public override int get_MaxCharCount() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

}

internal sealed class UTF7Encoding.DecoderUTF7FallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 473
{
	private char cFallback;
	private int iCount;
	private int iSize;

	public override int Remaining { get; }


	public void .ctor(UTF7Encoding.DecoderUTF7Fallback fallback) { }

	public override bool Fallback(byte[] bytesUnknown, int index) { }

	public override char GetNextChar() { }

	public override int get_Remaining() { }

	public override void Reset() { }

	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

}

