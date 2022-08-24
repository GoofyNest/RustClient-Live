public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 443
{
	private string strDefault; 
	private int fallbackCount; 
	private int fallbackIndex; 

	public override int Remaining { get; }


	public void .ctor(DecoderReplacementFallback fallback) { }

	public override bool Fallback(byte[] bytesUnknown, int index) { }

	public override char GetNextChar() { }

	public override int get_Remaining() { }

	public override void Reset() { }

	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

}

