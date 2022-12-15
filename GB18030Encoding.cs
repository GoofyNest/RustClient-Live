public class GB18030Encoding : MonoEncoding // TypeDefIndex: 7851
{
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string BodyName { get; }
	public override string WebName { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }


	public void .ctor() { }

	public override string get_EncodingName() { }

	public override string get_HeaderName() { }

	public override string get_BodyName() { }

	public override string get_WebName() { }

	public override bool get_IsMailNewsDisplay() { }

	public override bool get_IsMailNewsSave() { }

	public override bool get_IsBrowserDisplay() { }

	public override bool get_IsBrowserSave() { }

	public override int GetMaxByteCount(int len) { }

	public override int GetMaxCharCount(int len) { }

	public override int GetByteCount(char[] chars, int index, int length) { }

	public override int GetByteCountImpl(char* chars, int count) { }

	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int start, int len) { }

	public override int GetChars(byte[] bytes, int byteIdx, int srclen, char[] chars, int charIdx) { }

	public override Encoder GetEncoder() { }

	public override Decoder GetDecoder() { }

}

