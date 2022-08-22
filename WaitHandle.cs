public abstract class WaitHandle : MarshalByRefObject, IDisposable // TypeDefIndex: 822
{	public const int WaitTimeout = 258;
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

	[ObsoleteAttribute] // RVA: 0xB9A80 Offset: 0xB8E80 VA: 0x1800B9A80
	public virtual IntPtr Handle { set; }
	public SafeWaitHandle SafeWaitHandle { get; set; }


	protected void .ctor() { }

	private void Init() { }

	public virtual void set_Handle(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public SafeWaitHandle get_SafeWaitHandle() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public void set_SafeWaitHandle(SafeWaitHandle value) { }

	internal void SetHandleInternal(SafeWaitHandle handle) { }

	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	public virtual bool WaitOne() { }

	public virtual bool WaitOne(int millisecondsTimeout) { }

	private bool WaitOne(long timeout, bool exitContext) { }

	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	private static void ThrowAbandonedMutexException() { }

	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	public virtual void Close() { }

	protected virtual void Dispose(bool explicitDisposing) { }

	public void Dispose() { }

	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	private static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	private static void .cctor() { }

}

