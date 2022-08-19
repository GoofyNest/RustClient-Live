public class ReaderWriterLockSlim : IDisposable // TypeDefIndex: 3191
{	// Fields
	private bool fIsReentrant; // 0x10
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

	// Properties
	public bool IsReadLockHeld { get; }
	public bool IsUpgradeableReadLockHeld { get; }
	public bool IsWriteLockHeld { get; }
	public int RecursiveReadCount { get; }
	public int RecursiveUpgradeCount { get; }
	public int RecursiveWriteCount { get; }
	public int WaitingReadCount { get; }
	public int WaitingUpgradeCount { get; }
	public int WaitingWriteCount { get; }

	// Methods

	// RVA: 0x2226300 Offset: 0x2225700 VA: 0x182226300
	private void InitializeThreadCounts() { }

	// RVA: 0x2227420 Offset: 0x2226820 VA: 0x182227420
	public void .ctor() { }

	// RVA: 0x2227480 Offset: 0x2226880 VA: 0x182227480
	public void .ctor(LockRecursionPolicy recursionPolicy) { }

	// RVA: 0x2226310 Offset: 0x2225710 VA: 0x182226310
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	// RVA: 0x2226350 Offset: 0x2225750 VA: 0x182226350
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	// RVA: 0x22260C0 Offset: 0x22254C0 VA: 0x1822260C0
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	// RVA: 0x2225AF0 Offset: 0x2224EF0 VA: 0x182225AF0
	public void EnterWriteLock() { }

	// RVA: 0x22271C0 Offset: 0x22265C0 VA: 0x1822271C0
	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	// RVA: 0x2227260 Offset: 0x2226660 VA: 0x182227260
	private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x2226AD0 Offset: 0x2225ED0 VA: 0x182226AD0
	private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x2225AA0 Offset: 0x2224EA0 VA: 0x182225AA0
	public void EnterUpgradeableReadLock() { }

	// RVA: 0x2226A20 Offset: 0x2225E20 VA: 0x182226A20
	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	// RVA: 0x2226AC0 Offset: 0x2225EC0 VA: 0x182226AC0
	private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x22264E0 Offset: 0x22258E0 VA: 0x1822264E0
	private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x2225F10 Offset: 0x2225310 VA: 0x182225F10
	public void ExitWriteLock() { }

	// RVA: 0x2225D30 Offset: 0x2225130 VA: 0x182225D30
	public void ExitUpgradeableReadLock() { }

	// RVA: 0x2226380 Offset: 0x2225780 VA: 0x182226380
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	// RVA: 0x2227270 Offset: 0x2226670 VA: 0x182227270
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter) { }

	// RVA: 0x2225C70 Offset: 0x2225070 VA: 0x182225C70
	private void ExitAndWakeUpAppropriateWaiters() { }

	// RVA: 0x2225BE0 Offset: 0x2224FE0 VA: 0x182225BE0
	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	// RVA: 0x2225B40 Offset: 0x2224F40 VA: 0x182225B40
	private void ExitAndWakeUpAppropriateReadWaiters() { }

	// RVA: 0x2226370 Offset: 0x2225770 VA: 0x182226370
	private bool IsWriterAcquired() { }

	// RVA: 0x2226470 Offset: 0x2225870 VA: 0x182226470
	private void SetWriterAcquired() { }

	// RVA: 0x2225640 Offset: 0x2224A40 VA: 0x182225640
	private void ClearWriterAcquired() { }

	// RVA: 0x2226480 Offset: 0x2225880 VA: 0x182226480
	private void SetWritersWaiting() { }

	// RVA: 0x2225650 Offset: 0x2224A50 VA: 0x182225650
	private void ClearWritersWaiting() { }

	// RVA: 0x2226460 Offset: 0x2225860 VA: 0x182226460
	private void SetUpgraderWaiting() { }

	// RVA: 0x2225630 Offset: 0x2224A30 VA: 0x182225630
	private void ClearUpgraderWaiting() { }

	// RVA: 0x22260B0 Offset: 0x22254B0 VA: 0x1822260B0
	private uint GetNumReaders() { }

	// RVA: 0x2225A00 Offset: 0x2224E00 VA: 0x182225A00
	private void EnterMyLock() { }

	// RVA: 0x2225970 Offset: 0x2224D70 VA: 0x182225970
	private void EnterMyLockSpin() { }

	// RVA: 0x2225D10 Offset: 0x2225110 VA: 0x182225D10
	private void ExitMyLock() { }

	// RVA: 0x2226490 Offset: 0x2225890 VA: 0x182226490
	private static void SpinWait(int SpinCount) { }

	// RVA: 0x2225660 Offset: 0x2224A60 VA: 0x182225660 Slot: 4
	public void Dispose() { }

	// RVA: 0x2225670 Offset: 0x2224A70 VA: 0x182225670
	private void Dispose(bool disposing) { }

	// RVA: 0x22274F0 Offset: 0x22268F0 VA: 0x1822274F0
	public bool get_IsReadLockHeld() { }

	// RVA: 0x2227560 Offset: 0x2226960 VA: 0x182227560
	public bool get_IsUpgradeableReadLockHeld() { }

	// RVA: 0x22275F0 Offset: 0x22269F0 VA: 0x1822275F0
	public bool get_IsWriteLockHeld() { }

	// RVA: 0x2227680 Offset: 0x2226A80 VA: 0x182227680
	public int get_RecursiveReadCount() { }

	// RVA: 0x22276F0 Offset: 0x2226AF0 VA: 0x1822276F0
	public int get_RecursiveUpgradeCount() { }

	// RVA: 0x22277A0 Offset: 0x2226BA0 VA: 0x1822277A0
	public int get_RecursiveWriteCount() { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public int get_WaitingReadCount() { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public int get_WaitingUpgradeCount() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_WaitingWriteCount() { }

}

private struct ReaderWriterLockSlim.TimeoutTracker // TypeDefIndex: 3192
{	// Fields
	private int m_total; // 0x0
	private int m_start; // 0x4

	// Properties
	public int RemainingMilliseconds { get; }
	public bool IsExpired { get; }

	// Methods

	// RVA: 0x2375A0 Offset: 0x2369A0 VA: 0x1802375A0
	public void .ctor(int millisecondsTimeout) { }

	// RVA: 0x237600 Offset: 0x236A00 VA: 0x180237600
	public int get_RemainingMilliseconds() { }

	// RVA: 0x2375B0 Offset: 0x2369B0 VA: 0x1802375B0
	public bool get_IsExpired() { }

}

