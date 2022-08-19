public struct SpinLock // TypeDefIndex: 762
{	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x1F08D0 Offset: 0x1EFCD0 VA: 0x1801F08D0
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x1F0750 Offset: 0x1EFB50 VA: 0x1801F0750
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x1F0840 Offset: 0x1EFC40 VA: 0x1801F0840
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1F0730 Offset: 0x1EFB30 VA: 0x1801F0730
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1F0740 Offset: 0x1EFB40 VA: 0x1801F0740
	private void DecrementWaiters() { }

	// RVA: 0x1F0720 Offset: 0x1EFB20 VA: 0x1801F0720
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1F07E0 Offset: 0x1EFBE0 VA: 0x1801F07E0
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x1F07D0 Offset: 0x1EFBD0 VA: 0x1801F07D0
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1F0910 Offset: 0x1EFD10 VA: 0x1801F0910
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1F0920 Offset: 0x1EFD20 VA: 0x1801F0920
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x1495CB0 Offset: 0x14950B0 VA: 0x181495CB0
	private static void .cctor() { }

}

