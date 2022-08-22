public struct SpinLock // TypeDefIndex: 762
{	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }


	public void .ctor(bool enableThreadOwnerTracking) { }

	public void Enter(ref bool lockTaken) { }

	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	private void DecrementWaiters() { }

	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public void Exit(bool useMemoryBarrier) { }

	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public bool get_IsThreadOwnerTrackingEnabled() { }

	private static void .cctor() { }

}

