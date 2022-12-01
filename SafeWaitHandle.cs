public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 116
{

	[ReliabilityContractAttribute]
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	protected override bool ReleaseHandle() { }

}

