public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 116
{
	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	protected override bool ReleaseHandle() { }

}

