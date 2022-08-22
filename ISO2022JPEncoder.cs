internal class ISO2022JPEncoder : MonoEncoder // TypeDefIndex: 7805
{	private static JISConvert convert; // 0x0
	private readonly bool allow_1byte_kana; // 0x28
	private readonly bool allow_shift_io; // 0x29
	private ISO2022JPMode m; // 0x2C
	private bool shifted_in_count; // 0x30
	private bool shifted_in_conv; // 0x31
	private static readonly char[] full_width_map; // 0x8


	public void .ctor(MonoEncoding owner, bool allow1ByteKana, bool allowShiftIO) { }

	private static void .cctor() { }

	public override int GetByteCountImpl(char* chars, int charCount, bool flush) { }

	private void SwitchMode(byte* bytes, ref int byteIndex, ref int byteCount, ref ISO2022JPMode cur, ISO2022JPMode next) { }

	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	public override void Reset() { }

}

