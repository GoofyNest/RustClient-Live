internal class GB18030Encoder : MonoEncoder // TypeDefIndex: 7853
{
	private static DbcsConvert gb2312;
	private char incomplete_byte_count;
	private char incomplete_bytes;


	public void .ctor(MonoEncoding owner) { }

	private static void .cctor() { }

	public override int GetByteCountImpl(char* chars, int count, bool refresh) { }

	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh) { }

}

