internal class ISO2022JPDecoder : Decoder // TypeDefIndex: 7806
{	private static JISConvert convert; // 0x0
	private readonly bool allow_shift_io; // 0x20
	private ISO2022JPMode m; // 0x24
	private bool shifted_in_conv; // 0x28
	private bool shifted_in_count; // 0x29


	public void .ctor(bool allow1ByteKana, bool allowShiftIO) { }

	private static void .cctor() { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	private int ToChar(int value) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override void Reset() { }

}

