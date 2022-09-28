public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 1357
{
	private bool inited; 


	[CLSCompliantAttribute] 
	[ReliabilityContractAttribute] 
	public void AcquirePointer(ref byte* pointer) { }

	[ReliabilityContractAttribute] 
	public void ReleasePointer() { }

}

