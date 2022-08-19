public class CancellationTokenSource : IDisposable // TypeDefIndex: 751
{	// Fields
	private static readonly CancellationTokenSource _staticSource_Set; // 0x0
	private static readonly CancellationTokenSource _staticSource_NotCancelable; // 0x8
	private static readonly int s_nLists; // 0x10
	private ManualResetEvent m_kernelEvent; // 0x10
	private SparselyPopulatedArray<CancellationCallbackInfo>[] m_registeredCallbacksLists; // 0x18
	private const int CANNOT_BE_CANCELED = 0;
	private const int NOT_CANCELED = 1;
	private const int NOTIFYING = 2;
	private const int NOTIFYINGCOMPLETE = 3;
	private int m_state; // 0x20
	private int m_threadIDExecutingCallbacks; // 0x24
	private bool m_disposed; // 0x28
	private CancellationTokenRegistration[] m_linkingRegistrations; // 0x30
	private static readonly Action<object> s_LinkedTokenCancelDelegate; // 0x18
	private CancellationCallbackInfo m_executingCallback; // 0x38
	private Timer m_timer; // 0x40
	private static readonly TimerCallback s_timerCallback; // 0x20

	// Properties
	public bool IsCancellationRequested { get; }
	internal bool IsCancellationCompleted { get; }
	internal bool IsDisposed { get; }
	internal int ThreadIDExecutingCallbacks { get; set; }
	public CancellationToken Token { get; }
	internal bool CanBeCanceled { get; }
	internal CancellationCallbackInfo ExecutingCallback { get; }

	// Methods

	// RVA: 0x148BF70 Offset: 0x148B370 VA: 0x18148BF70
	private static void LinkedTokenCancelDelegate(object source) { }

	// RVA: 0x148C6C0 Offset: 0x148BAC0 VA: 0x18148C6C0
	public bool get_IsCancellationRequested() { }

	// RVA: 0x148C6A0 Offset: 0x148BAA0 VA: 0x18148C6A0
	internal bool get_IsCancellationCompleted() { }

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0
	internal bool get_IsDisposed() { }

	// RVA: 0x148C770 Offset: 0x148BB70 VA: 0x18148C770
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	// RVA: 0x148C6E0 Offset: 0x148BAE0 VA: 0x18148C6E0
	internal int get_ThreadIDExecutingCallbacks() { }

	// RVA: 0x148C700 Offset: 0x148BB00 VA: 0x18148C700
	public CancellationToken get_Token() { }

	// RVA: 0x148C660 Offset: 0x148BA60 VA: 0x18148C660
	internal bool get_CanBeCanceled() { }

	// RVA: 0x148C680 Offset: 0x148BA80 VA: 0x18148C680
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	// RVA: 0x148C5E0 Offset: 0x148B9E0 VA: 0x18148C5E0
	public void .ctor() { }

	// RVA: 0x148C620 Offset: 0x148BA20 VA: 0x18148C620
	private void .ctor(bool set) { }

	// RVA: 0x148B120 Offset: 0x148A520 VA: 0x18148B120
	public void Cancel() { }

	// RVA: 0x148B190 Offset: 0x148A590 VA: 0x18148B190
	public void Cancel(bool throwOnFirstException) { }

	// RVA: 0x148B090 Offset: 0x148A490 VA: 0x18148B090
	public void CancelAfter(TimeSpan delay) { }

	// RVA: 0x148AEC0 Offset: 0x148A2C0 VA: 0x18148AEC0
	public void CancelAfter(int millisecondsDelay) { }

	// RVA: 0x148C250 Offset: 0x148B650 VA: 0x18148C250
	private static void TimerCallbackLogic(object obj) { }

	// RVA: 0x148B5A0 Offset: 0x148A9A0 VA: 0x18148B5A0 Slot: 4
	public void Dispose() { }

	// RVA: 0x148B610 Offset: 0x148AA10 VA: 0x18148B610 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x148C180 Offset: 0x148B580 VA: 0x18148C180
	internal void ThrowIfDisposed() { }

	// RVA: 0x148C1E0 Offset: 0x148B5E0 VA: 0x18148C1E0
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x148BB00 Offset: 0x148AF00 VA: 0x18148BB00
	internal static CancellationTokenSource InternalGetStaticSource(bool set) { }

	// RVA: 0x148BBA0 Offset: 0x148AFA0 VA: 0x18148BBA0
	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	// RVA: 0x148C070 Offset: 0x148B470 VA: 0x18148C070
	private void NotifyCancellation(bool throwOnFirstException) { }

	// RVA: 0x148B730 Offset: 0x148AB30 VA: 0x18148B730
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	// RVA: 0x148B200 Offset: 0x148A600 VA: 0x18148B200
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	// RVA: 0x148B280 Offset: 0x148A680 VA: 0x18148B280
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	// RVA: 0x148B350 Offset: 0x148A750 VA: 0x18148B350
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	// RVA: 0x148C370 Offset: 0x148B770 VA: 0x18148C370
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

	// RVA: 0x148C470 Offset: 0x148B870 VA: 0x18148C470
	private static void .cctor() { }

}

