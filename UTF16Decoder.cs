internal class UTF16Decoder : Decoder // TypeDefIndex: 2012
{
	private bool bigEndian; 
	private int lastByte; 


public void .ctor(bool bigEndian) { }

public override int GetCharCount(byte[] bytes, int index, int count) { }

public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

}

