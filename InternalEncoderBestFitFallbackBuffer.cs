internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 446
{
	private char cBestFit; 
	private InternalEncoderBestFitFallback oFallback; 
	private int iCount; 
	private int iSize; 
	private static object s_InternalSyncObject; 

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

