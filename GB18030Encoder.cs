internal class GB18030Encoder : MonoEncoder // TypeDefIndex: 7832
{	private static DbcsConvert gb2312; // 0x0
	private char incomplete_byte_count; // 0x28
	private char incomplete_bytes; // 0x2A


	public void .ctor(MonoEncoding owner) { }

	private static void .cctor() { }

	public override int GetByteCountImpl(char* chars, int count, bool refresh) { }

	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh) { }

}

