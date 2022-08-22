public class ReaderWriterLockSlim : IDisposable // TypeDefIndex: 3191
{	private bool fIsReentrant; // 0x10
	private int myLock; // 0x14
	private uint numWriteWaiters; // 0x18
	private uint numReadWaiters; // 0x1C
	private uint numWriteUpgradeWaiters; // 0x20
	private uint numUpgradeWaiters; // 0x24
	private bool fNoWaiters; // 0x28
	private int upgradeLockOwnerId; // 0x2C
	private int writeLockOwnerId; // 0x30
	private EventWaitHandle writeEvent; // 0x38
	private EventWaitHandle readEvent; // 0x40
	private EventWaitHandle upgradeEvent; // 0x48
	private EventWaitHandle waitUpgradeEvent; // 0x50
	private static long s_nextLockID; // 0x0
	private long lockID; // 0x58
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static ReaderWriterCount t_rwc; // 0x80000000
	private bool fUpgradeThreadHoldingRead; // 0x60
	private uint owners; // 0x64
	private bool fDisposed; // 0x68

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
{	private int m_total; // 0x0
	private int m_start; // 0x4

	public int RemainingMilliseconds { get; }
	public bool IsExpired { get; }


	public void .ctor(int millisecondsTimeout) { }

	public int get_RemainingMilliseconds() { }

	public bool get_IsExpired() { }

}

