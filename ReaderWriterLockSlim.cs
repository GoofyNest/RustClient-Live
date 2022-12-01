public class ReaderWriterLockSlim : IDisposable // TypeDefIndex: 3191
{
	private bool fIsReentrant;
	private int myLock;
	private uint numWriteWaiters;
	private uint numReadWaiters;
	private uint numWriteUpgradeWaiters;
	private uint numUpgradeWaiters;
	private bool fNoWaiters;
	private int upgradeLockOwnerId;
	private int writeLockOwnerId;
	private EventWaitHandle writeEvent;
	private EventWaitHandle readEvent;
	private EventWaitHandle upgradeEvent;
	private EventWaitHandle waitUpgradeEvent;
	private static long s_nextLockID;
	private long lockID;
	[ThreadStaticAttribute]
	private static ReaderWriterCount t_rwc;
	private bool fUpgradeThreadHoldingRead;
	private uint owners;
	private bool fDisposed;

	public bool IsReadLockHeld { get; }
	public bool IsUpgradeableReadLockHeld { get; }
	public bool IsWriteLockHeld { get; }
	public int RecursiveReadCount { get; }
	public int RecursiveUpgradeCount { get; }
	public int RecursiveWriteCount { get; }
	public int WaitingReadCount { get; }
	public int WaitingUpgradeCount { get; }
	public int WaitingWriteCount { get; }


	private void InitializeThreadCounts() { }

	public void .ctor() { }

	public void .ctor(LockRecursionPolicy recursionPolicy) { }

	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	public void EnterWriteLock() { }

	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	public void EnterUpgradeableReadLock() { }

	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	public void ExitWriteLock() { }

	public void ExitUpgradeableReadLock() { }

	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter) { }

	private void ExitAndWakeUpAppropriateWaiters() { }

	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	private void ExitAndWakeUpAppropriateReadWaiters() { }

	private bool IsWriterAcquired() { }

	private void SetWriterAcquired() { }

	private void ClearWriterAcquired() { }

	private void SetWritersWaiting() { }

	private void ClearWritersWaiting() { }

	private void SetUpgraderWaiting() { }

	private void ClearUpgraderWaiting() { }

	private uint GetNumReaders() { }

	private void EnterMyLock() { }

	private void EnterMyLockSpin() { }

	private void ExitMyLock() { }

	private static void SpinWait(int SpinCount) { }

	public void Dispose() { }

	private void Dispose(bool disposing) { }

	public bool get_IsReadLockHeld() { }

	public bool get_IsUpgradeableReadLockHeld() { }

	public bool get_IsWriteLockHeld() { }

	public int get_RecursiveReadCount() { }

	public int get_RecursiveUpgradeCount() { }

	public int get_RecursiveWriteCount() { }

	public int get_WaitingReadCount() { }

	public int get_WaitingUpgradeCount() { }

	public int get_WaitingWriteCount() { }

}

private struct ReaderWriterLockSlim.TimeoutTracker // TypeDefIndex: 3192
{
	private int m_total;
	private int m_start;

	public int RemainingMilliseconds { get; }
	public bool IsExpired { get; }


	public void .ctor(int millisecondsTimeout) { }

	public int get_RemainingMilliseconds() { }

	public bool get_IsExpired() { }

}

