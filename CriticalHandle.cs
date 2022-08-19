public abstract class CriticalHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1345
{	// Fields
	protected IntPtr handle; // 0x10
	private bool _isClosed; // 0x18

	// Properties
	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }

	// Methods

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0xFDFB80 Offset: 0xFDEF80 VA: 0x180FDFB80
	protected void .ctor(IntPtr invalidHandleValue) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFDFAE0 Offset: 0xFDEEE0 VA: 0x180FDFAE0 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFDF9E0 Offset: 0xFDEDE0 VA: 0x180FDF9E0
	private void Cleanup() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void FireCustomerDebugProbe() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x8B1160 Offset: 0x8B0560 VA: 0x1808B1160
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_IsClosed() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsInvalid();

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFDFAC0 Offset: 0xFDEEC0 VA: 0x180FDFAC0
	public void Close() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFDFAC0 Offset: 0xFDEEC0 VA: 0x180FDFAC0 Slot: 4
	public void Dispose() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFDF9E0 Offset: 0xFDEDE0 VA: 0x180FDF9E0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();

}

