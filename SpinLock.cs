public struct SpinLock // TypeDefIndex: 762
{
	private int m_owner;
	private static int MAXIMUM_WAITERS;

	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }


	public void .ctor(bool enableThreadOwnerTracking) { }

	public void Enter(ref bool lockTaken) { }

	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	private void DecrementWaiters() { }

	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContractAttribute]
	public void Exit(bool useMemoryBarrier) { }

	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContractAttribute]
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContractAttribute]
	public bool get_IsThreadOwnerTrackingEnabled() { }

	private static void .cctor() { }

}

