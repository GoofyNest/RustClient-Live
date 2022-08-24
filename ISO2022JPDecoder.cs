internal class ISO2022JPDecoder : Decoder // TypeDefIndex: 7806
{
	private static JISConvert convert; 
	private readonly bool allow_shift_io; 
	private ISO2022JPMode m; 
	private bool shifted_in_conv; 
	private bool shifted_in_count; 


public void .ctor(bool allow1ByteKana, bool allowShiftIO) { }

private static void .cctor() { }

public override int GetCharCount(byte[] bytes, int index, int count) { }

private int ToChar(int value) { }

public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

public override void Reset() { }

}

