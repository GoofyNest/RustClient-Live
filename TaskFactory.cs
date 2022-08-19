private sealed class TaskFactory.FromAsyncTrimPromise<TResult, TInstance> : Task<TResult> // TypeDefIndex: 846
{	// Fields
	internal static readonly AsyncCallback s_completeFromAsyncResult; // 0x0
	private TInstance m_thisRef; // 0x0
	private Func<TInstance, IAsyncResult, TResult> m_endMethod; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A79F10 Offset: 0x1A79310 VA: 0x181A79F10
	|-TaskFactory.FromAsyncTrimPromise<int, object>..ctor
	|-TaskFactory.FromAsyncTrimPromise<object, object>..ctor
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static void CompleteFromAsyncResult(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A79690 Offset: 0x1A78A90 VA: 0x181A79690
	|-TaskFactory.FromAsyncTrimPromise<int, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x1A79470 Offset: 0x1A78870 VA: 0x181A79470
	|-TaskFactory.FromAsyncTrimPromise<object, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x1A79250 Offset: 0x1A78650 VA: 0x181A79250
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.CompleteFromAsyncResult
	*/

	// RVA: -1 Offset: -1
	internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A79A10 Offset: 0x1A78E10 VA: 0x181A79A10
	|-TaskFactory.FromAsyncTrimPromise<int, object>.Complete
	|
	|-RVA: 0x1A79B70 Offset: 0x1A78F70 VA: 0x181A79B70
	|-TaskFactory.FromAsyncTrimPromise<object, object>.Complete
	|
	|-RVA: 0x1A798B0 Offset: 0x1A78CB0 VA: 0x181A798B0
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.Complete
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A79CD0 Offset: 0x1A790D0 VA: 0x181A79CD0
	|-TaskFactory.FromAsyncTrimPromise<int, object>..cctor
	|
	|-RVA: 0x1A79D90 Offset: 0x1A79190 VA: 0x181A79D90
	|-TaskFactory.FromAsyncTrimPromise<object, object>..cctor
	|
	|-RVA: 0x1A79E50 Offset: 0x1A79250 VA: 0x181A79E50
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..cctor
	*/

}

private sealed class TaskFactory.<>c__DisplayClass35_0<TResult> // TypeDefIndex: 847
{	// Fields
	public Func<IAsyncResult, TResult> endFunction; // 0x0
	public Action<IAsyncResult> endAction; // 0x0
	public Task<TResult> promise; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-TaskFactory.<>c__DisplayClass35_0<PublishResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<bool>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<int>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<UdpReceiveResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<ServerInfo>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<Image>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<InventoryPurchaseResult>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<InventoryResult>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<Item>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<ResultPage>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<int>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<Int32Enum>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<object>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1363F40 Offset: 0x1363340 VA: 0x181363F40
	|-TaskFactory.<>c__DisplayClass35_0<PublishResult>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<bool>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<int>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<UdpReceiveResult>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<ServerInfo>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<Image>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<InventoryPurchaseResult>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<InventoryResult>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<Item>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<ResultPage>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<int>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<Int32Enum>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<object>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<VoidTaskResult>.<FromAsyncImpl>b__0
	*/

}

private sealed class TaskFactory.<>c__DisplayClass35_1<TResult> // TypeDefIndex: 848
{	// Fields
	public AtomicBoolean invoked; // 0x0
	public TaskFactory.<>c__DisplayClass35_0<TResult> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-TaskFactory.<>c__DisplayClass35_1<PublishResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<bool>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<int>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<UdpReceiveResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<ServerInfo>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<Image>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<InventoryPurchaseResult>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<InventoryResult>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<Item>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<ResultPage>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<int>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<Int32Enum>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<object>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__1(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1363F80 Offset: 0x1363380 VA: 0x181363F80
	|-TaskFactory.<>c__DisplayClass35_1<PublishResult>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<bool>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<int>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<UdpReceiveResult>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<ServerInfo>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<Image>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<InventoryPurchaseResult>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<InventoryResult>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<Item>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<ResultPage>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<int>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<Int32Enum>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<object>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<VoidTaskResult>.<FromAsyncImpl>b__1
	*/

}

private sealed class TaskFactory.<>c__DisplayClass41_0<TResult, TArg1, TArg2> // TypeDefIndex: 849
{	// Fields
	public Func<IAsyncResult, TResult> endFunction; // 0x0
	public Action<IAsyncResult> endAction; // 0x0
	public Task<TResult> promise; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-TaskFactory.<>c__DisplayClass41_0<int, object, int>..ctor
	|-TaskFactory.<>c__DisplayClass41_0<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1363F40 Offset: 0x1363340 VA: 0x181363F40
	|-TaskFactory.<>c__DisplayClass41_0<int, object, int>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass41_0<object, object, object>.<FromAsyncImpl>b__0
	*/

}

private sealed class TaskFactory.<>c__DisplayClass41_1<TResult, TArg1, TArg2> // TypeDefIndex: 850
{	// Fields
	public AtomicBoolean invoked; // 0x0
	public TaskFactory.<>c__DisplayClass41_0<TResult, TArg1, TArg2> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-TaskFactory.<>c__DisplayClass41_1<int, object, int>..ctor
	|-TaskFactory.<>c__DisplayClass41_1<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__1(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1363F80 Offset: 0x1363380 VA: 0x181363F80
	|-TaskFactory.<>c__DisplayClass41_1<int, object, int>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass41_1<object, object, object>.<FromAsyncImpl>b__1
	*/

}

public class TaskFactory // TypeDefIndex: 884
{	// Fields
	private CancellationToken m_defaultCancellationToken; // 0x10
	private TaskScheduler m_defaultScheduler; // 0x18
	private TaskCreationOptions m_defaultCreationOptions; // 0x20
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x24

	// Methods

	// RVA: 0x1603F20 Offset: 0x1603320 VA: 0x181603F20
	public void .ctor() { }

	// RVA: 0x1603CE0 Offset: 0x16030E0 VA: 0x181603CE0
	public void .ctor(CancellationToken cancellationToken) { }

	// RVA: 0x1603D60 Offset: 0x1603160 VA: 0x181603D60
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1603740 Offset: 0x1602B40 VA: 0x181603740
	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	// RVA: 0x1603C70 Offset: 0x1603070 VA: 0x181603C70
	public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state) { }

	// RVA: 0x1603C10 Offset: 0x1603010 VA: 0x181603C10
	public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state, TaskCreationOptions creationOptions) { }

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1549A40 Offset: 0x1548E40 VA: 0x181549A40
	|-TaskFactory.FromAsync<ISocket>
	|-TaskFactory.FromAsync<object>
	*/

	// RVA: 0x16037B0 Offset: 0x1602BB0 VA: 0x1816037B0
	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	// RVA: 0x16039D0 Offset: 0x1602DD0 VA: 0x1816039D0
	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	// RVA: 0x16038C0 Offset: 0x1602CC0 VA: 0x1816038C0
	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }

}

internal sealed class TaskFactory.CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction // TypeDefIndex: 885
{	// Fields
	private IList<Task> _tasks; // 0x58
	private int m_firstTaskAlreadyCompleted; // 0x60

	// Methods

	// RVA: 0x1600A60 Offset: 0x15FFE60 VA: 0x181600A60
	public void .ctor(IList<Task> tasks) { }

	// RVA: 0x1600840 Offset: 0x15FFC40 VA: 0x181600840 Slot: 20
	public void Invoke(Task completingTask) { }

}

