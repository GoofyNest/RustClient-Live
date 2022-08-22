internal class DecoderNLS : Decoder, ISerializable // TypeDefIndex: 441
{	protected Encoding m_encoding; // 0x20
	protected bool m_mustFlush; // 0x28
	internal bool m_throwOnOverflow; // 0x29
	internal int m_bytesUsed; // 0x2C

	public bool MustFlush { get; }
	internal virtual bool HasState { get; }


	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal void .ctor(Encoding encoding) { }

	internal void .ctor() { }

	public override void Reset() { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	public override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	public bool get_MustFlush() { }

	internal virtual bool get_HasState() { }

	internal void ClearMustFlush() { }

}

