public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 1357
{	private bool inited; // 0x20


	[ReliabilityContractAttribute] // RVA: 0xE0E60 Offset: 0xE0260 VA: 0x1800E0E60
	[CLSCompliantAttribute] // RVA: 0xE0E60 Offset: 0xE0260 VA: 0x1800E0E60
	public void AcquirePointer(ref byte* pointer) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public void ReleasePointer() { }

}

