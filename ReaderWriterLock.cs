public sealed class ReaderWriterLock : CriticalFinalizerObject // TypeDefIndex: 829
{	// Fields
	private int seq_num; // 0x10
	private int state; // 0x14
	private int readers; // 0x18
	private int writer_lock_owner; // 0x1C
	private LockQueue writer_queue; // 0x20
	private Hashtable reader_locks; // 0x28

	// Methods

	// RVA: 0x1493060 Offset: 0x1492460 VA: 0x181493060
	public void .ctor() { }

	// RVA: 0x1492DC0 Offset: 0x14921C0 VA: 0x181492DC0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1492DB0 Offset: 0x14921B0 VA: 0x181492DB0
	public void AcquireWriterLock(int millisecondsTimeout) { }

	// RVA: 0x1492BA0 Offset: 0x1491FA0 VA: 0x181492BA0
	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1492E50 Offset: 0x1492250 VA: 0x181492E50
	public void ReleaseWriterLock() { }

	// RVA: 0x1493000 Offset: 0x1492400 VA: 0x181493000
	private void ReleaseWriterLock(int releaseCount) { }

	// RVA: 0x1492E20 Offset: 0x1492220 VA: 0x181492E20
	private bool HasWriterLock() { }

}

