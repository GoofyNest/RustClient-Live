internal class ISO2022JPEncoder : MonoEncoder // TypeDefIndex: 7778
{
	private static JISConvert convert; 
	private readonly bool allow_1byte_kana; 
	private readonly bool allow_shift_io; 
	private ISO2022JPMode m; 
	private bool shifted_in_count; 
	private bool shifted_in_conv; 
	private static readonly char[] full_width_map; 


	public void .ctor(MonoEncoding owner, bool allow1ByteKana, bool allowShiftIO) { }

	private static void .cctor() { }

	public override int GetByteCountImpl(char* chars, int charCount, bool flush) { }

	private void SwitchMode(byte* bytes, ref int byteIndex, ref int byteCount, ref ISO2022JPMode cur, ISO2022JPMode next) { }

	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	public override void Reset() { }

}

