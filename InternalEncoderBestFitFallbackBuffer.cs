internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 446
{	// Fields
	private char cBestFit; // 0x30
	private InternalEncoderBestFitFallback oFallback; // 0x38
	private int iCount; // 0x40
	private int iSize; // 0x44
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x19172D0 Offset: 0x19166D0 VA: 0x1819172D0
	private static object get_InternalSyncObject() { }

	// RVA: 0x1917120 Offset: 0x1916520 VA: 0x181917120
	public void .ctor(InternalEncoderBestFitFallback fallback) { }

	// RVA: 0x1916C00 Offset: 0x1916000 VA: 0x181916C00 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x1916D40 Offset: 0x1916140 VA: 0x181916D40 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x1916FB0 Offset: 0x19163B0 VA: 0x181916FB0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x1916FD0 Offset: 0x19163D0 VA: 0x181916FD0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x1917360 Offset: 0x1916760 VA: 0x181917360 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x1916FF0 Offset: 0x19163F0 VA: 0x181916FF0 Slot: 9
	public override void Reset() { }

	// RVA: 0x1917010 Offset: 0x1916410 VA: 0x181917010
	private char TryBestFit(char cUnknown) { }

}

