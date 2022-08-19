public abstract class WaitHandle : MarshalByRefObject, IDisposable // TypeDefIndex: 822
{	// Fields
	public const int WaitTimeout = 258;
	private const int MAX_WAITHANDLES = 64;
	private IntPtr waitHandle; // 0x18
	internal SafeWaitHandle safeWaitHandle; // 0x20
	internal bool hasThreadAffinity; // 0x28
	private const int WAIT_OBJECT_0 = 0;
	private const int WAIT_ABANDONED = 128;
	private const int WAIT_FAILED = 2147483647;
	private const int ERROR_TOO_MANY_POSTS = 298;
	protected static readonly IntPtr InvalidHandle; // 0x0
	internal const int MaxWaitHandles = 64;

	// Properties
	[ObsoleteAttribute] // RVA: 0xB9A80 Offset: 0xB8E80 VA: 0x1800B9A80
	public virtual IntPtr Handle { set; }
	public SafeWaitHandle SafeWaitHandle { get; set; }

	// Methods

	// RVA: 0x1617DC0 Offset: 0x16171C0 VA: 0x181617DC0
	protected void .ctor() { }

	// RVA: 0x1616F00 Offset: 0x1616300 VA: 0x181616F00
	private void Init() { }

	// RVA: 0x1617F10 Offset: 0x1617310 VA: 0x181617F10 Slot: 7
	public virtual void set_Handle(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x1617E50 Offset: 0x1617250 VA: 0x181617E50
	public SafeWaitHandle get_SafeWaitHandle() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1618020 Offset: 0x1617420 VA: 0x181618020
	public void set_SafeWaitHandle(SafeWaitHandle value) { }

	// RVA: 0x1617090 Offset: 0x1616490 VA: 0x181617090
	internal void SetHandleInternal(SafeWaitHandle handle) { }

	// RVA: 0x1617A00 Offset: 0x1616E00 VA: 0x181617A00 Slot: 8
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x1617D50 Offset: 0x1617150 VA: 0x181617D50 Slot: 9
	public virtual bool WaitOne() { }

	// RVA: 0x1617D30 Offset: 0x1617130 VA: 0x181617D30 Slot: 10
	public virtual bool WaitOne(int millisecondsTimeout) { }

	// RVA: 0x1617BD0 Offset: 0x1616FD0 VA: 0x181617BD0
	private bool WaitOne(long timeout, bool exitContext) { }

	// RVA: 0x1616F80 Offset: 0x1616380 VA: 0x181616F80
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x1617190 Offset: 0x1616590 VA: 0x181617190
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x16174F0 Offset: 0x16168F0 VA: 0x1816174F0
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	// RVA: 0x16170E0 Offset: 0x16164E0 VA: 0x1816170E0
	private static void ThrowAbandonedMutexException() { }

	// RVA: 0x1617130 Offset: 0x1616530 VA: 0x181617130
	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	// RVA: 0x1616DD0 Offset: 0x16161D0 VA: 0x181616DD0 Slot: 11
	public virtual void Close() { }

	// RVA: 0x1616E40 Offset: 0x1616240 VA: 0x181616E40 Slot: 12
	protected virtual void Dispose(bool explicitDisposing) { }

	// RVA: 0x1616E90 Offset: 0x1616290 VA: 0x181616E90 Slot: 6
	public void Dispose() { }

	// RVA: 0x16175F0 Offset: 0x16169F0 VA: 0x1816175F0
	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	// RVA: 0x16178C0 Offset: 0x1616CC0 VA: 0x1816178C0
	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	// RVA: 0x1617D70 Offset: 0x1617170 VA: 0x181617D70
	private static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	// RVA: 0x1617D80 Offset: 0x1617180 VA: 0x181617D80
	private static void .cctor() { }

}

