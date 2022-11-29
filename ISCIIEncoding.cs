public abstract class ISCIIEncoding : MonoEncoding // TypeDefIndex: 7889
{
	private int shift; 
	private string encodingName; 
	private string webName; 

	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }


	protected void .ctor(int codePage, int shift, string encodingName, string webName) { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(string s) { }

	public override int GetByteCountImpl(char* chars, int count) { }

	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override string get_BodyName() { }

	public override string get_EncodingName() { }

	public override string get_HeaderName() { }

	public override string get_WebName() { }

}

