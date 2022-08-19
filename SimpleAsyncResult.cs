internal class SimpleAsyncResult : IAsyncResult // TypeDefIndex: 3022
{	// Fields
	private ManualResetEvent handle; // 0x10
	private bool synch; // 0x18
	private bool isCompleted; // 0x19
	private readonly SimpleAsyncCallback cb; // 0x20
	private object state; // 0x28
	private bool callbackDone; // 0x30
	private Exception exc; // 0x38
	private object locker; // 0x40
	private Nullable<bool> user_read_synch; // 0x48

	// Properties
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	internal bool CompletedSynchronouslyPeek { get; }
	public bool IsCompleted { get; }
	internal bool GotException { get; }
	internal Exception Exception { get; }

	// Methods

	// RVA: 0xFFAD90 Offset: 0xFFA190 VA: 0x180FFAD90
	private void .ctor(SimpleAsyncCallback cb) { }

	// RVA: 0xFFAC70 Offset: 0xFFA070 VA: 0x180FFAC70
	protected void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0xFFA8E0 Offset: 0xFF9CE0 VA: 0x180FFA8E0
	public static void Run(Func<SimpleAsyncResult, bool> func, SimpleAsyncCallback callback) { }

	// RVA: 0xFFA7D0 Offset: 0xFF9BD0 VA: 0x180FFA7D0
	public static void RunWithLock(object locker, Func<SimpleAsyncResult, bool> func, SimpleAsyncCallback callback) { }

	// RVA: 0xFFA700 Offset: 0xFF9B00 VA: 0x180FFA700
	protected void Reset_internal() { }

	// RVA: 0xFFAB60 Offset: 0xFF9F60 VA: 0x180FFAB60
	internal void SetCompleted(bool synch, Exception e) { }

	// RVA: 0xFFAB20 Offset: 0xFF9F20 VA: 0x180FFAB20
	internal void SetCompleted(bool synch) { }

	// RVA: 0xFFAA40 Offset: 0xFF9E40 VA: 0x180FFAA40
	private void SetCompleted_internal(bool synch, Exception e) { }

	// RVA: 0xFFAB10 Offset: 0xFF9F10 VA: 0x180FFAB10
	protected void SetCompleted_internal(bool synch) { }

	// RVA: 0xFFA6D0 Offset: 0xFF9AD0 VA: 0x180FFA6D0
	private void DoCallback_private() { }

	// RVA: 0xFFA6A0 Offset: 0xFF9AA0 VA: 0x180FFA6A0
	protected void DoCallback_internal() { }

	// RVA: 0xFFAC20 Offset: 0xFFA020 VA: 0x180FFAC20
	internal void WaitUntilComplete() { }

	// RVA: 0xFFABA0 Offset: 0xFF9FA0 VA: 0x180FFABA0
	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0xFFAE10 Offset: 0xFFA210 VA: 0x180FFAE10 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0xFFAF30 Offset: 0xFFA330 VA: 0x180FFAF30 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	internal bool get_CompletedSynchronouslyPeek() { }

	// RVA: 0xFFAFA0 Offset: 0xFFA3A0 VA: 0x180FFAFA0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x6EAA20 Offset: 0x6E9E20 VA: 0x1806EAA20
	internal bool get_GotException() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	internal Exception get_Exception() { }

}

private sealed class SimpleAsyncResult.<>c__DisplayClass9_0 // TypeDefIndex: 3023
{	// Fields
	public AsyncCallback cb; // 0x10
	public SimpleAsyncResult <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1009830 Offset: 0x1008C30 VA: 0x181009830
	internal void <.ctor>b__0(SimpleAsyncResult result) { }

}

private sealed class SimpleAsyncResult.<>c__DisplayClass11_0 // TypeDefIndex: 3024
{	// Fields
	public Func<SimpleAsyncResult, bool> func; // 0x10
	public object locker; // 0x18
	public SimpleAsyncCallback callback; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1009550 Offset: 0x1008950 VA: 0x181009550
	internal bool <RunWithLock>b__0(SimpleAsyncResult inner) { }

	// RVA: 0x10095D0 Offset: 0x10089D0 VA: 0x1810095D0
	internal void <RunWithLock>b__1(SimpleAsyncResult inner) { }

}

