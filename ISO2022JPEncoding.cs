public class ISO2022JPEncoding : MonoEncoding // TypeDefIndex: 7803
{
	private readonly bool allow_1byte_kana; 
	private readonly bool allow_shift_io; 

public override string BodyName { get; }
public override string HeaderName { get; }
public override string WebName { get; }


public void .ctor(int codePage, bool allow1ByteKana, bool allowShiftIO) { }

public override string get_BodyName() { }

public override string get_HeaderName() { }

public override string get_WebName() { }

public override int GetMaxByteCount(int charCount) { }

public override int GetMaxCharCount(int byteCount) { }

public override int GetByteCount(char[] chars, int charIndex, int charCount) { }

public override int GetByteCountImpl(char* chars, int count) { }

public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

public override int GetCharCount(byte[] bytes, int index, int count) { }

public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

}

