public abstract class SafeHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1351
{	// Fields
	protected IntPtr handle; // 0x10
	private int _state; // 0x18
	private bool _ownsHandle; // 0x1C
	private bool _fullyInitialized; // 0x1D
	private const int RefCount_Mask = 2147483644;
	private const int RefCount_One = 4;

	// Properties
	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }

	// Methods

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0xFF08F0 Offset: 0xFEFCF0 VA: 0x180FF08F0
	protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

	// RVA: 0xFDFAE0 Offset: 0xFDEEE0 VA: 0x180FDFAE0 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x8B1160 Offset: 0x8B0560 VA: 0x1808B1160
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public IntPtr DangerousGetHandle() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x83ED80 Offset: 0x83E180 VA: 0x18083ED80
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
	// RVA: 0xFF06C0 Offset: 0xFEFAC0 VA: 0x180FF06C0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFF0820 Offset: 0xFEFC20 VA: 0x180FF0820
	public void SetHandleAsInvalid() { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0xFF03E0 Offset: 0xFEF7E0 VA: 0x180FF03E0
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFF06B0 Offset: 0xFEFAB0 VA: 0x180FF06B0
	public void DangerousRelease() { }

	// RVA: 0xFF0770 Offset: 0xFEFB70 VA: 0x180FF0770
	private void InternalDispose() { }

	// RVA: 0xFF0800 Offset: 0xFEFC00 VA: 0x180FF0800
	private void InternalFinalize() { }

	// RVA: 0xFF0500 Offset: 0xFEF900 VA: 0x180FF0500
	private void DangerousReleaseInternal(bool dispose) { }

}

