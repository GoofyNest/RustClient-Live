public sealed class ReaderWriterLock : CriticalFinalizerObject // TypeDefIndex: 829
{	private int seq_num; // 0x10
	private int state; // 0x14
	private int readers; // 0x18
	private int writer_lock_owner; // 0x1C
	private LockQueue writer_queue; // 0x20
	private Hashtable reader_locks; // 0x28


	public void .ctor() { }

	protected override void Finalize() { }

	public void AcquireWriterLock(int millisecondsTimeout) { }

	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public void ReleaseWriterLock() { }

	private void ReleaseWriterLock(int releaseCount) { }

	private bool HasWriterLock() { }

}

