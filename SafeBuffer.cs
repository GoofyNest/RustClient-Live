public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 1357
{	// Fields
	private bool inited; // 0x20

	// Methods

	[ReliabilityContractAttribute] // RVA: 0xE0E60 Offset: 0xE0260 VA: 0x1800E0E60
	[CLSCompliantAttribute] // RVA: 0xE0E60 Offset: 0xE0260 VA: 0x1800E0E60
	// RVA: 0xFF02E0 Offset: 0xFEF6E0 VA: 0x180FF02E0
	public void AcquirePointer(ref byte* pointer) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFF0370 Offset: 0xFEF770 VA: 0x180FF0370
	public void ReleasePointer() { }

}

