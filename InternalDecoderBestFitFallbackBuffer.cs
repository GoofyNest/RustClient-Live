internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 435
{
	internal char cBestFit; 
	internal int iCount; 
	internal int iSize; 
	private InternalDecoderBestFitFallback oFallback; 
	private static object s_InternalSyncObject; 

	private static object InternalSyncObject { get; }
	public override int Remaining { get; }


	private static object get_InternalSyncObject() { }

	public void .ctor(InternalDecoderBestFitFallback fallback) { }

	public override bool Fallback(byte[] bytesUnknown, int index) { }

	public override char GetNextChar() { }

	public override int get_Remaining() { }

	public override void Reset() { }

	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	private char TryBestFit(byte[] bytesCheck) { }

}

