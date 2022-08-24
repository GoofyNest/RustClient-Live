public sealed class ReaderWriterLock : CriticalFinalizerObject // TypeDefIndex: 829
{
	private int seq_num; 
	private int state; 
	private int readers; 
	private int writer_lock_owner; 
	private LockQueue writer_queue; 
	private Hashtable reader_locks; 


	public void .ctor() { }

	protected override void Finalize() { }

	public void AcquireWriterLock(int millisecondsTimeout) { }

	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[ReliabilityContractAttribute] 
	public void ReleaseWriterLock() { }

	private void ReleaseWriterLock(int releaseCount) { }

	private bool HasWriterLock() { }

}

