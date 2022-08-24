public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 1357
{
	private bool inited; 


	[ReliabilityContractAttribute] 
	[CLSCompliantAttribute] 
	public void AcquirePointer(ref byte* pointer) { }

	[ReliabilityContractAttribute] 
	public void ReleasePointer() { }

}

