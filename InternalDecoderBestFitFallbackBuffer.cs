internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 435
{	// Fields
	internal char cBestFit; // 0x20
	internal int iCount; // 0x24
	internal int iSize; // 0x28
	private InternalDecoderBestFitFallback oFallback; // 0x30
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x19169F0 Offset: 0x1915DF0 VA: 0x1819169F0
	private static object get_InternalSyncObject() { }

	// RVA: 0x1916840 Offset: 0x1915C40 VA: 0x181916840
	public void .ctor(InternalDecoderBestFitFallback fallback) { }

	// RVA: 0x19165C0 Offset: 0x19159C0 VA: 0x1819165C0 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x1916610 Offset: 0x1915A10 VA: 0x181916610 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x190D410 Offset: 0x190C810 VA: 0x18190D410 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x190D3F0 Offset: 0x190C7F0 VA: 0x18190D3F0 Slot: 7
	public override void Reset() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x1916630 Offset: 0x1915A30 VA: 0x181916630
	private char TryBestFit(byte[] bytesCheck) { }

}

