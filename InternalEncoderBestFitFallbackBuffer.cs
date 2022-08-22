internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 446
{	private char cBestFit; // 0x30
	private InternalEncoderBestFitFallback oFallback; // 0x38
	private int iCount; // 0x40
	private int iSize; // 0x44
	private static object s_InternalSyncObject; // 0x0

	private static object InternalSyncObject { get; }
	public override int Remaining { get; }


	private static object get_InternalSyncObject() { }

	public void .ctor(InternalEncoderBestFitFallback fallback) { }

	public override bool Fallback(char charUnknown, int index) { }

	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	public override char GetNextChar() { }

	public override bool MovePrevious() { }

	public override int get_Remaining() { }

	public override void Reset() { }

	private char TryBestFit(char cUnknown) { }

}

