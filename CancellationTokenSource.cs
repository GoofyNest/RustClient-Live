public class CancellationTokenSource : IDisposable // TypeDefIndex: 751
{
	private static readonly CancellationTokenSource _staticSource_Set; 
	private static readonly CancellationTokenSource _staticSource_NotCancelable; 
	private static readonly int s_nLists; 
	private ManualResetEvent m_kernelEvent; 
	private SparselyPopulatedArray<CancellationCallbackInfo>[] m_registeredCallbacksLists; 
	private const int CANNOT_BE_CANCELED = 0;
	private const int NOT_CANCELED = 1;
	private const int NOTIFYING = 2;
	private const int NOTIFYINGCOMPLETE = 3;
	private int m_state; 
	private int m_threadIDExecutingCallbacks; 
	private bool m_disposed; 
	private CancellationTokenRegistration[] m_linkingRegistrations; 
	private static readonly Action<object> s_LinkedTokenCancelDelegate; 
	private CancellationCallbackInfo m_executingCallback; 
	private Timer m_timer; 
	private static readonly TimerCallback s_timerCallback; 

	public bool IsCancellationRequested { get; }
	internal bool IsCancellationCompleted { get; }
	internal bool IsDisposed { get; }
	internal int ThreadIDExecutingCallbacks { get; set; }
	public CancellationToken Token { get; }
	internal bool CanBeCanceled { get; }
	internal CancellationCallbackInfo ExecutingCallback { get; }


	private static void LinkedTokenCancelDelegate(object source) { }

	public bool get_IsCancellationRequested() { }

	internal bool get_IsCancellationCompleted() { }

	internal bool get_IsDisposed() { }

	internal void set_ThreadIDExecutingCallbacks(int value) { }

	internal int get_ThreadIDExecutingCallbacks() { }

	public CancellationToken get_Token() { }

	internal bool get_CanBeCanceled() { }

	internal CancellationCallbackInfo get_ExecutingCallback() { }

	public void .ctor() { }

	private void .ctor(bool set) { }

	public void Cancel() { }

	public void Cancel(bool throwOnFirstException) { }

	public void CancelAfter(TimeSpan delay) { }

	public void CancelAfter(int millisecondsDelay) { }

	private static void TimerCallbackLogic(object obj) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	internal void ThrowIfDisposed() { }

	private static void ThrowObjectDisposedException() { }

	internal static CancellationTokenSource InternalGetStaticSource(bool set) { }

	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	private void NotifyCancellation(bool throwOnFirstException) { }

	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

	private static void .cctor() { }

}

