internal class Latin1Encoding : EncodingNLS, ISerializable // TypeDefIndex: 462
{
	private static readonly char[] arrayCharBestFit;

	public override bool IsSingleByte { get; }


	public void .ctor() { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override bool get_IsSingleByte() { }

	public override bool IsAlwaysNormalized(NormalizationForm form) { }

	internal override char[] GetBestFitUnicodeToBytesData() { }

	private static void .cctor() { }

}

