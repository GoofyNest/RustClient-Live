public class ASCIIEncoding : Encoding // TypeDefIndex: 432
{
	[ComVisibleAttribute] 
	public override bool IsSingleByte { get; }


	public void .ctor() { }

	internal override void SetDefaultFallbacks() { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
	public override int GetByteCount(char* chars, int count) { }

	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
	public override int GetCharCount(byte* bytes, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] 
	[ComVisibleAttribute] 
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override bool get_IsSingleByte() { }

	[ComVisibleAttribute] 
	public override Decoder GetDecoder() { }

	[ComVisibleAttribute] 
	public override Encoder GetEncoder() { }

}

