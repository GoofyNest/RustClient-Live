public class UnicodeEncoding : Encoding // TypeDefIndex: 465
{
	[OptionalFieldAttribute] 
	internal bool isThrowException; 
	internal bool bigEndian; 
	internal bool byteOrderMark; 
	private static readonly ulong highLowPatternMask; 


public void .ctor() { }

public void .ctor(bool bigEndian, bool byteOrderMark) { }

public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	[OnDeserializingAttribute] 
private void OnDeserializing(StreamingContext ctx) { }

internal override void SetDefaultFallbacks() { }

public override int GetByteCount(char[] chars, int index, int count) { }

public override int GetByteCount(string s) { }

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
public override int GetByteCount(char* chars, int count) { }

public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] 
	[ComVisibleAttribute] 
public override int GetCharCount(byte* bytes, int count) { }

public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] 
	[ComVisibleAttribute] 
public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] 
public override string GetString(byte[] bytes, int index, int count) { }

internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	[ComVisibleAttribute] 
public override Encoder GetEncoder() { }

public override Decoder GetDecoder() { }

public override byte[] GetPreamble() { }

public override int GetMaxByteCount(int charCount) { }

public override int GetMaxCharCount(int byteCount) { }

public override bool Equals(object value) { }

public override int GetHashCode() { }

private static void .cctor() { }

}

private class UnicodeEncoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 466
{
	internal int lastByte; 
	internal char lastChar; 

internal override bool HasState { get; }


public void .ctor(UnicodeEncoding encoding) { }

internal void .ctor(SerializationInfo info, StreamingContext context) { }

private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

public override void Reset() { }

internal override bool get_HasState() { }

}

