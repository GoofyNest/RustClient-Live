public sealed class AsyncCallback : MulticastDelegate // TypeDefIndex: 173
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x497240 Offset: 0x496640 VA: 0x180497240 Slot: 12
	public virtual void Invoke(IAsyncResult ar) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(IAsyncResult ar, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AsyncLocal<T> : IAsyncLocal // TypeDefIndex: 774
{	// Fields
	private readonly Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler; // 0x0

	// Properties
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1354950 Offset: 0x1353D50 VA: 0x181354950
	|-AsyncLocal<ActivityTracker.ActivityInfo>..ctor
	|-AsyncLocal<CultureInfo>..ctor
	|-AsyncLocal<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1354990 Offset: 0x1353D90 VA: 0x181354990
	|-AsyncLocal<ActivityTracker.ActivityInfo>.get_Value
	|-AsyncLocal<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1354A40 Offset: 0x1353E40 VA: 0x181354A40
	|-AsyncLocal<ActivityTracker.ActivityInfo>.set_Value
	|-AsyncLocal<CultureInfo>.set_Value
	|-AsyncLocal<object>.set_Value
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void System.Threading.IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13547B0 Offset: 0x1353BB0 VA: 0x1813547B0
	|-AsyncLocal<object>.System.Threading.IAsyncLocal.OnValueChanged
	*/

}

public struct AsyncLocalValueChangedArgs<T> // TypeDefIndex: 776
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private T <PreviousValue>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private T <CurrentValue>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <ThreadContextChanged>k__BackingField; // 0x0

	// Properties
	public T PreviousValue { get; set; }
	public T CurrentValue { get; set; }
	private bool ThreadContextChanged { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public T get_PreviousValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	|-AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo>.get_PreviousValue
	|-AsyncLocalValueChangedArgs<object>.get_PreviousValue
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	private void set_PreviousValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	|-AsyncLocalValueChangedArgs<object>.set_PreviousValue
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public T get_CurrentValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	|-AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo>.get_CurrentValue
	|-AsyncLocalValueChangedArgs<CultureInfo>.get_CurrentValue
	|-AsyncLocalValueChangedArgs<object>.get_CurrentValue
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	private void set_CurrentValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1390 Offset: 0xF0790 VA: 0x1800F1390
	|-AsyncLocalValueChangedArgs<object>.set_CurrentValue
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	private void set_ThreadContextChanged(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E21F0 Offset: 0x1E15F0 VA: 0x1801E21F0
	|-AsyncLocalValueChangedArgs<object>.set_ThreadContextChanged
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(T previousValue, T currentValue, bool contextChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E21E0 Offset: 0x1E15E0 VA: 0x1801E21E0
	|-AsyncLocalValueChangedArgs<object>..ctor
	*/

}

internal enum AsyncCausalityStatus // TypeDefIndex: 838
{	// Fields
	public int value__; // 0x0
	public const AsyncCausalityStatus Started = 0;
	public const AsyncCausalityStatus Completed = 1;
	public const AsyncCausalityStatus Canceled = 2;
	public const AsyncCausalityStatus Error = 3;

}

internal static class AsyncCausalityTracer // TypeDefIndex: 841
{	// Properties
	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static bool LoggingOn { get; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	internal static bool get_LoggingOn() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal static void TraceOperationRelation(CausalityTraceLevel traceLevel, int taskId, CausalityRelation relation) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

}

internal class AsyncRequest // TypeDefIndex: 1193
{	// Fields
	internal IMessageSink ReplySink; // 0x10
	internal IMessage MsgRequest; // 0x18

	// Methods

	// RVA: 0xFD7210 Offset: 0xFD6610 VA: 0x180FD7210
	public void .ctor(IMessage msgRequest, IMessageSink replySink) { }

}

public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 1223
{	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78
	internal static ContextCallback ccb; // 0x0

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x1469620 Offset: 0x1468A20 VA: 0x181469620
	internal void .ctor(WaitCallback cb, object state, bool capture_context) { }

	// RVA: 0x1469520 Offset: 0x1468920 VA: 0x181469520
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x1469720 Offset: 0x1468B20 VA: 0x181469720 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x8B1130 Offset: 0x8B0530 VA: 0x1808B1130 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x115AFB0 Offset: 0x115A3B0 VA: 0x18115AFB0
	public bool get_EndInvokeCalled() { }

	// RVA: 0x115B3C0 Offset: 0x115A7C0 VA: 0x18115B3C0
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x1469190 Offset: 0x1468590 VA: 0x181469190 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30 Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x78BED0 Offset: 0x78B2D0 VA: 0x18078BED0
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x14691E0 Offset: 0x14685E0 VA: 0x1814691E0
	internal IMessage EndInvoke() { }

	// RVA: 0x1469310 Offset: 0x1468710 VA: 0x181469310 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x1469300 Offset: 0x1468700 VA: 0x181469300 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1469300 Offset: 0x1468700 VA: 0x181469300
	internal object Invoke() { }

	// RVA: 0x14695B0 Offset: 0x14689B0 VA: 0x1814695B0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1469470 Offset: 0x1468870 VA: 0x181469470
	private void <.ctor>b__17_0(object <p0>) { }

}

public struct AsyncVoidMethodBuilder // TypeDefIndex: 1273
{	// Fields
	private SynchronizationContext m_synchronizationContext; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x8
	private Task m_task; // 0x18

	// Properties
	private Task Task { get; }

	// Methods

	// RVA: 0xFD7660 Offset: 0xFD6A60 VA: 0x180FD7660
	public static AsyncVoidMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13B710 Offset: 0x13AB10 VA: 0x18013B710
	|-AsyncVoidMethodBuilder.Start<CompanionSetupScreen.<Disable>d__26>
	|
	|-RVA: 0x13B720 Offset: 0x13AB20 VA: 0x18013B720
	|-AsyncVoidMethodBuilder.Start<CompanionSetupScreen.<Enable>d__25>
	|
	|-RVA: 0x13B7B0 Offset: 0x13ABB0 VA: 0x18013B7B0
	|-AsyncVoidMethodBuilder.Start<CompanionSetupScreen.<RefreshImpl>d__24>
	|
	|-RVA: 0x13B750 Offset: 0x13AB50 VA: 0x18013B750
	|-AsyncVoidMethodBuilder.Start<ConnectionScreen.<LoadServerInfo>d__13>
	|
	|-RVA: 0x13B760 Offset: 0x13AB60 VA: 0x18013B760
	|-AsyncVoidMethodBuilder.Start<ConnectionScreen.<LoadServerRules>d__14>
	|
	|-RVA: 0x13B700 Offset: 0x13AB00 VA: 0x18013B700
	|-AsyncVoidMethodBuilder.Start<ItemStore.<Checkout>d__24>
	|
	|-RVA: 0x13B7C0 Offset: 0x13ABC0 VA: 0x18013B7C0
	|-AsyncVoidMethodBuilder.Start<ItemStore.<RefreshList>d__17>
	|
	|-RVA: 0x13B810 Offset: 0x13AC10 VA: 0x18013B810
	|-AsyncVoidMethodBuilder.Start<LoadingScreen.<<ChooseBackgroundImage>g__PreloadBackgroundImage|56_0>d>
	|
	|-RVA: 0x13B740 Offset: 0x13AB40 VA: 0x18013B740
	|-AsyncVoidMethodBuilder.Start<SteamPlatform.<LoadAvatarFromSteamAsync>d__1>
	|
	|-RVA: 0x13B730 Offset: 0x13AB30 VA: 0x18013B730
	|-AsyncVoidMethodBuilder.Start<RestRgbService.<EventImpl>d__40>
	|
	|-RVA: 0x13B780 Offset: 0x13AB80 VA: 0x18013B780
	|-AsyncVoidMethodBuilder.Start<RestRgbService.<PulseColorImpl>d__38>
	|
	|-RVA: 0x13B7D0 Offset: 0x13ABD0 VA: 0x18013B7D0
	|-AsyncVoidMethodBuilder.Start<RestRgbService.<SendHeartbeatAndWait>d__34>
	|
	|-RVA: 0x13B800 Offset: 0x13AC00 VA: 0x18013B800
	|-AsyncVoidMethodBuilder.Start<RestRgbService.<StaticColorImpl>d__36>
	|
	|-RVA: 0x13B830 Offset: 0x13AC30 VA: 0x18013B830
	|-AsyncVoidMethodBuilder.Start<RgbController.<Worker>d__14>
	|
	|-RVA: 0x13B7F0 Offset: 0x13ABF0 VA: 0x18013B7F0
	|-AsyncVoidMethodBuilder.Start<ReportBug.<SendReport>d__29>
	|
	|-RVA: 0x13B7E0 Offset: 0x13ABE0 VA: 0x18013B7E0
	|-AsyncVoidMethodBuilder.Start<ReportPlayer.<SendReport>d__21>
	|
	|-RVA: 0x13B790 Offset: 0x13AB90 VA: 0x18013B790
	|-AsyncVoidMethodBuilder.Start<ServerBrowserInfo.<QueryRules>d__19>
	|
	|-RVA: 0x13B7A0 Offset: 0x13ABA0 VA: 0x18013B7A0
	|-AsyncVoidMethodBuilder.Start<ShoutcastStreamer.<ReadData>d__46>
	|
	|-RVA: 0x13B820 Offset: 0x13AC20 VA: 0x18013B820
	|-AsyncVoidMethodBuilder.Start<SteamUserButton.<UpdateFromUser>d__14>
	|
	|-RVA: 0x13B770 Offset: 0x13AB70 VA: 0x18013B770
	|-AsyncVoidMethodBuilder.Start<Dispatch.<LoopClientAsync>d__22>
	|
	|-RVA: 0x13B6F0 Offset: 0x13AAF0 VA: 0x18013B6F0
	|-AsyncVoidMethodBuilder.Start<object>
	*/

	// RVA: 0x14BD80 Offset: 0x14B180 VA: 0x18014BD80
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13B590 Offset: 0x13A990 VA: 0x18013B590
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x13B670 Offset: 0x13AA70 VA: 0x18013B670
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CompanionSetupScreen.<Disable>d__26>
	|
	|-RVA: 0x13B680 Offset: 0x13AA80 VA: 0x18013B680
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CompanionSetupScreen.<Enable>d__25>
	|
	|-RVA: 0x13B690 Offset: 0x13AA90 VA: 0x18013B690
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<EventImpl>d__40>
	|
	|-RVA: 0x13B6B0 Offset: 0x13AAB0 VA: 0x18013B6B0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<PulseColorImpl>d__38>
	|
	|-RVA: 0x13B6C0 Offset: 0x13AAC0 VA: 0x18013B6C0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<SendHeartbeatAndWait>d__34>
	|
	|-RVA: 0x13B6D0 Offset: 0x13AAD0 VA: 0x18013B6D0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<StaticColorImpl>d__36>
	|
	|-RVA: 0x13B6A0 Offset: 0x13AAA0 VA: 0x18013B6A0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Dispatch.<LoopClientAsync>d__22>
	|
	|-RVA: 0x13B5F0 Offset: 0x13A9F0 VA: 0x18013B5F0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<CompanionSubscription.Status>, CompanionSetupScreen.<RefreshImpl>d__24>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSetupScreen.<RefreshImpl>d__24>
	|
	|-RVA: 0x13B640 Offset: 0x13AA40 VA: 0x18013B640
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IPlayerInfo>, SteamUserButton.<UpdateFromUser>d__14>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamUserButton.<UpdateFromUser>d__14>
	|
	|-RVA: 0x13B660 Offset: 0x13AA60 VA: 0x18013B660
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, RestRgbService.<SendHeartbeatAndWait>d__34>
	|
	|-RVA: 0x13B650 Offset: 0x13AA50 VA: 0x18013B650
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ShoutcastStreamer.<ReadData>d__46>
	|
	|-RVA: 0x13B5D0 Offset: 0x13A9D0 VA: 0x18013B5D0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ConnectionScreen.<LoadServerRules>d__14>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ConnectionScreen.<LoadServerRules>d__14>
	|
	|-RVA: 0x13B5E0 Offset: 0x13A9E0 VA: 0x18013B5E0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ServerBrowserInfo.<QueryRules>d__19>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ServerBrowserInfo.<QueryRules>d__19>
	|
	|-RVA: 0x13B600 Offset: 0x13AA00 VA: 0x18013B600
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IPlayerItemDefinition>>, ItemStore.<RefreshList>d__17>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ItemStore.<RefreshList>d__17>
	|
	|-RVA: 0x13B5C0 Offset: 0x13A9C0 VA: 0x18013B5C0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<ServerInfo>>, ConnectionScreen.<LoadServerInfo>d__13>
	|
	|-RVA: 0x13B5B0 Offset: 0x13A9B0 VA: 0x18013B5B0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<Image>>, SteamPlatform.<LoadAvatarFromSteamAsync>d__1>
	|
	|-RVA: 0x13B5A0 Offset: 0x13A9A0 VA: 0x18013B5A0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryPurchaseResult>>, ItemStore.<Checkout>d__24>
	|
	|-RVA: 0x13B630 Offset: 0x13AA30 VA: 0x18013B630
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, LoadingScreen.<<ChooseBackgroundImage>g__PreloadBackgroundImage|56_0>d>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, LoadingScreen.<<ChooseBackgroundImage>g__PreloadBackgroundImage|56_0>d>
	|
	|-RVA: 0x13B620 Offset: 0x13AA20 VA: 0x18013B620
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ReportBug.<SendReport>d__29>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, ReportBug.<SendReport>d__29>
	|
	|-RVA: 0x13B610 Offset: 0x13AA10 VA: 0x18013B610
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ReportPlayer.<SendReport>d__21>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, ReportPlayer.<SendReport>d__21>
	|
	|-RVA: 0x13B6E0 Offset: 0x13AAE0 VA: 0x18013B6E0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<Worker>d__14>
	*/

	// RVA: 0x14BD20 Offset: 0x14B120 VA: 0x18014BD20
	public void SetResult() { }

	// RVA: 0x14BD10 Offset: 0x14B110 VA: 0x18014BD10
	public void SetException(Exception exception) { }

	// RVA: 0x14BD00 Offset: 0x14B100 VA: 0x18014BD00
	private void NotifySynchronizationContextOfCompletion() { }

	// RVA: 0x14BE40 Offset: 0x14B240 VA: 0x18014BE40
	private Task get_Task() { }

}

public struct AsyncTaskMethodBuilder // TypeDefIndex: 1274
{	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0xDA3350 Offset: 0xDA2750 VA: 0x180DA3350
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121AD0 Offset: 0x120ED0 VA: 0x180121AD0
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<Report>d__11>
	|
	|-RVA: 0x121AF0 Offset: 0x120EF0 VA: 0x180121AF0
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunAsync>d__7>
	|
	|-RVA: 0x121B00 Offset: 0x120F00 VA: 0x180121B00
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunBenchmarkScene>d__9>
	|
	|-RVA: 0x121B10 Offset: 0x120F10 VA: 0x180121B10
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunBenchmarksInScene>d__10>
	|
	|-RVA: 0x121B20 Offset: 0x120F20 VA: 0x180121B20
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunDemoBasedBenchmark>d__12>
	|
	|-RVA: 0x121B30 Offset: 0x120F30 VA: 0x180121B30
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunSingleSceneAsync>d__8>
	|
	|-RVA: 0x121960 Offset: 0x120D60 VA: 0x180121960
	|-AsyncTaskMethodBuilder.Start<Client.<Connect>d__37>
	|
	|-RVA: 0x121930 Offset: 0x120D30 VA: 0x180121930
	|-AsyncTaskMethodBuilder.Start<CompanionSubscription.<Add>d__6>
	|
	|-RVA: 0x121AC0 Offset: 0x120EC0 VA: 0x180121AC0
	|-AsyncTaskMethodBuilder.Start<CompanionSubscription.<Remove>d__7>
	|
	|-RVA: 0x121A20 Offset: 0x120E20 VA: 0x180121A20
	|-AsyncTaskMethodBuilder.Start<EAC.<OnJoinServer>d__16>
	|
	|-RVA: 0x121A70 Offset: 0x120E70 VA: 0x180121A70
	|-AsyncTaskMethodBuilder.Start<Account.<ReadAllNotices>d__7>
	|
	|-RVA: 0x121AA0 Offset: 0x120EA0 VA: 0x180121AA0
	|-AsyncTaskMethodBuilder.Start<Account.<Refresh>d__6>
	|
	|-RVA: 0x121A50 Offset: 0x120E50 VA: 0x180121A50
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x1219F0 Offset: 0x120DF0 VA: 0x1801219F0
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x121A40 Offset: 0x120E40 VA: 0x180121A40
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x121A00 Offset: 0x120E00 VA: 0x180121A00
	|-AsyncTaskMethodBuilder.Start<SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-RVA: 0x121BD0 Offset: 0x120FD0 VA: 0x180121BD0
	|-AsyncTaskMethodBuilder.Start<RestRgbService.<Start>d__31>
	|
	|-RVA: 0x121BF0 Offset: 0x120FF0 VA: 0x180121BF0
	|-AsyncTaskMethodBuilder.Start<RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x121C10 Offset: 0x121010 VA: 0x180121C10
	|-AsyncTaskMethodBuilder.Start<RestRgbService.<Update>d__33>
	|
	|-RVA: 0x121BC0 Offset: 0x120FC0 VA: 0x180121BC0
	|-AsyncTaskMethodBuilder.Start<RgbController.<StartServices>d__15>
	|
	|-RVA: 0x121BE0 Offset: 0x120FE0 VA: 0x180121BE0
	|-AsyncTaskMethodBuilder.Start<RgbController.<StopServices>d__16>
	|
	|-RVA: 0x121C00 Offset: 0x121000 VA: 0x180121C00
	|-AsyncTaskMethodBuilder.Start<RgbController.<UpdateServices>d__17>
	|
	|-RVA: 0x121B40 Offset: 0x120F40 VA: 0x180121B40
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<SendEvent>d__15>
	|
	|-RVA: 0x121B50 Offset: 0x120F50 VA: 0x180121B50
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<SendHeartbeat>d__12>
	|
	|-RVA: 0x121B60 Offset: 0x120F60 VA: 0x180121B60
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<SendPulseColor>d__14>
	|
	|-RVA: 0x121B70 Offset: 0x120F70 VA: 0x180121B70
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<SendStaticColor>d__13>
	|
	|-RVA: 0x121BB0 Offset: 0x120FB0 VA: 0x180121BB0
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-RVA: 0x121B90 Offset: 0x120F90 VA: 0x180121B90
	|-AsyncTaskMethodBuilder.Start<Hero.<ShowAsync>d__10>
	|
	|-RVA: 0x1219B0 Offset: 0x120DB0 VA: 0x1801219B0
	|-AsyncTaskMethodBuilder.Start<SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-RVA: 0x121980 Offset: 0x120D80 VA: 0x180121980
	|-AsyncTaskMethodBuilder.Start<SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-RVA: 0x1219E0 Offset: 0x120DE0 VA: 0x1801219E0
	|-AsyncTaskMethodBuilder.Start<SteamInventoryManager.<FixStacks>d__9>
	|
	|-RVA: 0x121AB0 Offset: 0x120EB0 VA: 0x180121AB0
	|-AsyncTaskMethodBuilder.Start<SteamInventoryManager.<Refresh>d__8>
	|
	|-RVA: 0x121A30 Offset: 0x120E30 VA: 0x180121A30
	|-AsyncTaskMethodBuilder.Start<SteamInventoryNewItem.<Open>d__0>
	|
	|-RVA: 0x121990 Offset: 0x120D90 VA: 0x180121990
	|-AsyncTaskMethodBuilder.Start<Publisher.<DoExport>d__15>
	|
	|-RVA: 0x1219A0 Offset: 0x120DA0 VA: 0x1801219A0
	|-AsyncTaskMethodBuilder.Start<Publisher.<DoExport>d__21>
	|
	|-RVA: 0x1219C0 Offset: 0x120DC0 VA: 0x1801219C0
	|-AsyncTaskMethodBuilder.Start<Publisher.<ExportTexture>d__19>
	|
	|-RVA: 0x1219D0 Offset: 0x120DD0 VA: 0x1801219D0
	|-AsyncTaskMethodBuilder.Start<Publisher.<ExportToFolder>d__16>
	|
	|-RVA: 0x121A60 Offset: 0x120E60 VA: 0x180121A60
	|-AsyncTaskMethodBuilder.Start<Publisher.<PublishToSteam>d__18>
	|
	|-RVA: 0x121A80 Offset: 0x120E80 VA: 0x180121A80
	|-AsyncTaskMethodBuilder.Start<WorkshopItemList.<Refresh>d__26>
	|
	|-RVA: 0x121A90 Offset: 0x120E90 VA: 0x180121A90
	|-AsyncTaskMethodBuilder.Start<ServerHistory.<Refresh>d__4>
	|
	|-RVA: 0x121950 Offset: 0x120D50 VA: 0x180121950
	|-AsyncTaskMethodBuilder.Start<ShoutcastStream.<ConnectAsync>d__42>
	|
	|-RVA: 0x121BA0 Offset: 0x120FA0 VA: 0x180121BA0
	|-AsyncTaskMethodBuilder.Start<ShoutcastStream.<ShutdownSafely>d__54>
	|
	|-RVA: 0x121AE0 Offset: 0x120EE0 VA: 0x180121AE0
	|-AsyncTaskMethodBuilder.Start<Friend.<RequestInfoAsync>d__13>
	|
	|-RVA: 0x121B80 Offset: 0x120F80 VA: 0x180121B80
	|-AsyncTaskMethodBuilder.Start<SourceServerQuery.<Send>d__8>
	|
	|-RVA: 0x121940 Offset: 0x120D40 VA: 0x180121940
	|-AsyncTaskMethodBuilder.Start<SteamFriends.<CacheUserInformationAsync>d__51>
	|
	|-RVA: 0x121970 Offset: 0x120D70 VA: 0x180121970
	|-AsyncTaskMethodBuilder.Start<Stream.<CopyToAsyncInternal>d__27>
	|
	|-RVA: 0x121A10 Offset: 0x120E10 VA: 0x180121A10
	|-AsyncTaskMethodBuilder.Start<HttpContent.<LoadIntoBufferAsync>d__17>
	|
	|-RVA: 0x121920 Offset: 0x120D20 VA: 0x180121920
	|-AsyncTaskMethodBuilder.Start<object>
	|
	|-RVA: 0x121C20 Offset: 0x121020 VA: 0x180121C20
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: 0x14BC50 Offset: 0x14B050 VA: 0x18014BC50
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123750 Offset: 0x122B50 VA: 0x180123750
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x123740 Offset: 0x122B40 VA: 0x180123740
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1237E0 Offset: 0x122BE0 VA: 0x1801237E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x1237B0 Offset: 0x122BB0 VA: 0x1801237B0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x123790 Offset: 0x122B90 VA: 0x180123790
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x123780 Offset: 0x122B80 VA: 0x180123780
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<CopyToAsyncInternal>d__27>
	|
	|-RVA: 0x1237A0 Offset: 0x122BA0 VA: 0x1801237A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<LoadIntoBufferAsync>d__17>
	|
	|-RVA: 0x1237C0 Offset: 0x122BC0 VA: 0x1801237C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x1237D0 Offset: 0x122BD0 VA: 0x1801237D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x123760 Offset: 0x122B60 VA: 0x180123760
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<CopyToAsyncInternal>d__27>
	|
	|-RVA: 0x123770 Offset: 0x122B70 VA: 0x180123770
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x1239E0 Offset: 0x122DE0 VA: 0x1801239E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunAsync>d__7>
	|
	|-RVA: 0x1239F0 Offset: 0x122DF0 VA: 0x1801239F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunBenchmarkScene>d__9>
	|
	|-RVA: 0x123A00 Offset: 0x122E00 VA: 0x180123A00
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunBenchmarksInScene>d__10>
	|
	|-RVA: 0x123A10 Offset: 0x122E10 VA: 0x180123A10
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunDemoBasedBenchmark>d__12>
	|
	|-RVA: 0x123A20 Offset: 0x122E20 VA: 0x180123A20
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunSingleSceneAsync>d__8>
	|
	|-RVA: 0x123900 Offset: 0x122D00 VA: 0x180123900
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Client.<Connect>d__37>
	|
	|-RVA: 0x1239A0 Offset: 0x122DA0 VA: 0x1801239A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Account.<ReadAllNotices>d__7>
	|
	|-RVA: 0x123980 Offset: 0x122D80 VA: 0x180123980
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-RVA: 0x123A40 Offset: 0x122E40 VA: 0x180123A40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Start>d__31>
	|
	|-RVA: 0x123A50 Offset: 0x122E50 VA: 0x180123A50
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x123940 Offset: 0x122D40 VA: 0x180123940
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-RVA: 0x123910 Offset: 0x122D10 VA: 0x180123910
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-RVA: 0x123970 Offset: 0x122D70 VA: 0x180123970
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryManager.<FixStacks>d__9>
	|
	|-RVA: 0x1239C0 Offset: 0x122DC0 VA: 0x1801239C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryManager.<Refresh>d__8>
	|
	|-RVA: 0x123990 Offset: 0x122D90 VA: 0x180123990
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryNewItem.<Open>d__0>
	|
	|-RVA: 0x123920 Offset: 0x122D20 VA: 0x180123920
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<DoExport>d__15>
	|
	|-RVA: 0x123930 Offset: 0x122D30 VA: 0x180123930
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<DoExport>d__21>
	|
	|-RVA: 0x123950 Offset: 0x122D50 VA: 0x180123950
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<ExportTexture>d__19>
	|
	|-RVA: 0x123960 Offset: 0x122D60 VA: 0x180123960
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<ExportToFolder>d__16>
	|
	|-RVA: 0x1239B0 Offset: 0x122DB0 VA: 0x1801239B0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, ServerHistory.<Refresh>d__4>
	|
	|-RVA: 0x123A30 Offset: 0x122E30 VA: 0x180123A30
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, ShoutcastStream.<ShutdownSafely>d__54>
	|
	|-RVA: 0x1239D0 Offset: 0x122DD0 VA: 0x1801239D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Friend.<RequestInfoAsync>d__13>
	|
	|-RVA: 0x1238F0 Offset: 0x122CF0 VA: 0x1801238F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamFriends.<CacheUserInformationAsync>d__51>
	|
	|-RVA: 0x123820 Offset: 0x122C20 VA: 0x180123820
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, CompanionSubscription.<Add>d__6>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, CompanionSubscription.<Add>d__6>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<Add>d__6>
	|
	|-RVA: 0x123860 Offset: 0x122C60 VA: 0x180123860
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, CompanionSubscription.<Remove>d__7>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, CompanionSubscription.<Remove>d__7>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<Remove>d__7>
	|
	|-RVA: 0x123840 Offset: 0x122C40 VA: 0x180123840
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, Account.<ReadAllNotices>d__7>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Account.<ReadAllNotices>d__7>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Account.<ReadAllNotices>d__7>
	|
	|-RVA: 0x123850 Offset: 0x122C50 VA: 0x180123850
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, Account.<Refresh>d__6>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Account.<Refresh>d__6>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Account.<Refresh>d__6>
	|
	|-RVA: 0x121870 Offset: 0x120C70 VA: 0x180121870
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IPlayerInventory>, SteamInventoryCrafting.<ExchangeItems>d__33>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IPlayerInventory[]>, SteamInventoryCrafting.<ExchangeItems>d__33>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-RVA: 0x121880 Offset: 0x120C80 VA: 0x180121880
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IPlayerInventory>, SteamInventoryManager.<Refresh>d__8>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryManager.<Refresh>d__8>
	|
	|-RVA: 0x121850 Offset: 0x120C50 VA: 0x180121850
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<MP3Stream>, ShoutcastStream.<ConnectAsync>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, ShoutcastStream.<ConnectAsync>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, ShoutcastStream.<ConnectAsync>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ShoutcastStream.<ConnectAsync>d__42>
	|
	|-RVA: 0x1237F0 Offset: 0x122BF0 VA: 0x1801237F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<PublishResult>, Publisher.<PublishToSteam>d__18>
	|
	|-RVA: 0x123830 Offset: 0x122C30 VA: 0x180123830
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, EAC.<OnJoinServer>d__16>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EAC.<OnJoinServer>d__16>
	|
	|-RVA: 0x123810 Offset: 0x122C10 VA: 0x180123810
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, SourceServerQuery.<Send>d__8>
	|
	|-RVA: 0x123880 Offset: 0x122C80 VA: 0x180123880
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<SendEvent>d__15>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendEvent>d__15>
	|
	|-RVA: 0x123890 Offset: 0x122C90 VA: 0x180123890
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<SendHeartbeat>d__12>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendHeartbeat>d__12>
	|
	|-RVA: 0x1238A0 Offset: 0x122CA0 VA: 0x1801238A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<SendPulseColor>d__14>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendPulseColor>d__14>
	|
	|-RVA: 0x121890 Offset: 0x120C90 VA: 0x180121890
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<SendStaticColor>d__13>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendStaticColor>d__13>
	|
	|-RVA: 0x1238E0 Offset: 0x122CE0 VA: 0x1801238E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-RVA: 0x1238C0 Offset: 0x122CC0 VA: 0x1801238C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-RVA: 0x1238D0 Offset: 0x122CD0 VA: 0x1801238D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventoryManager.<FixStacks>d__9>
	|
	|-RVA: 0x123800 Offset: 0x122C00 VA: 0x180123800
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<Item>>, Publisher.<PublishToSteam>d__18>
	|
	|-RVA: 0x1238B0 Offset: 0x122CB0 VA: 0x1801238B0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<ResultPage>>, WorkshopItemList.<Refresh>d__26>
	|
	|-RVA: 0x123870 Offset: 0x122C70 VA: 0x180123870
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Benchmarking.<Report>d__11>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Benchmarking.<Report>d__11>
	|
	|-RVA: 0x1218B0 Offset: 0x120CB0 VA: 0x1801218B0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-RVA: 0x1218A0 Offset: 0x120CA0 VA: 0x1801218A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Hero.<ShowAsync>d__10>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Hero.<ShowAsync>d__10>
	|
	|-RVA: 0x121860 Offset: 0x120C60 VA: 0x180121860
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Publisher.<DoExport>d__21>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Publisher.<DoExport>d__21>
	|
	|-RVA: 0x1218F0 Offset: 0x120CF0 VA: 0x1801218F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x121910 Offset: 0x120D10 VA: 0x180121910
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Update>d__33>
	|
	|-RVA: 0x1218D0 Offset: 0x120CD0 VA: 0x1801218D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StartServices>d__15>
	|
	|-RVA: 0x1218E0 Offset: 0x120CE0 VA: 0x1801218E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StopServices>d__16>
	|
	|-RVA: 0x121900 Offset: 0x120D00 VA: 0x180121900
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<UpdateServices>d__17>
	|
	|-RVA: 0x1218C0 Offset: 0x120CC0 VA: 0x1801218C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, RestRgbService.<Start>d__31>
	*/

	// RVA: 0x14BCA0 Offset: 0x14B0A0 VA: 0x18014BCA0
	public Task get_Task() { }

	// RVA: 0x14BBE0 Offset: 0x14AFE0 VA: 0x18014BBE0
	public void SetResult() { }

	// RVA: 0x14BB90 Offset: 0x14AF90 VA: 0x18014BB90
	public void SetException(Exception exception) { }

	// RVA: 0xFD75B0 Offset: 0xFD69B0 VA: 0x180FD75B0
	private static void .cctor() { }

}

public struct AsyncTaskMethodBuilder<TResult> // TypeDefIndex: 1275
{	// Fields
	internal static readonly Task<TResult> s_defaultResultTask; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x0
	private Task<TResult> m_task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDA3350 Offset: 0xDA2750 VA: 0x180DA3350
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.Create
	|-AsyncTaskMethodBuilder<IAuthTicket>.Create
	|-AsyncTaskMethodBuilder<IPlayerInfo>.Create
	|-AsyncTaskMethodBuilder<IPlayerInventory>.Create
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.Create
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.Create
	|-AsyncTaskMethodBuilder<AuthTicket>.Create
	|-AsyncTaskMethodBuilder<InventoryDef[]>.Create
	|-AsyncTaskMethodBuilder<PublishResult>.Create
	|-AsyncTaskMethodBuilder<byte[]>.Create
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Create
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.Create
	|-AsyncTaskMethodBuilder<Stream>.Create
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.Create
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.Create
	|-AsyncTaskMethodBuilder<Nullable<Image>>.Create
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.Create
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Create
	|-AsyncTaskMethodBuilder<Nullable<Result>>.Create
	|-AsyncTaskMethodBuilder<Nullable<Item>>.Create
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.Create
	|-AsyncTaskMethodBuilder<Nullable<int>>.Create
	|-AsyncTaskMethodBuilder<string>.Create
	|-AsyncTaskMethodBuilder<bool>.Create
	|-AsyncTaskMethodBuilder<int>.Create
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.Create
	|-AsyncTaskMethodBuilder<object>.Create
	|-AsyncTaskMethodBuilder<VoidTaskResult>.Create
	*/

	[DebuggerStepThroughAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1215B0 Offset: 0x1209B0 VA: 0x1801215B0
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.Start<CompanionSubscription.<CheckStatus>d__5>
	|-AsyncTaskMethodBuilder<object>.Start<CompanionSubscription.<CheckStatus>d__5>
	|
	|-RVA: 0x121630 Offset: 0x120A30 VA: 0x180121630
	|-AsyncTaskMethodBuilder<IAuthTicket>.Start<SteamPlatform.<GetAuthSessionTicketAsync>d__53>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<GetAuthSessionTicketAsync>d__53>
	|
	|-RVA: 0x121670 Offset: 0x120A70 VA: 0x180121670
	|-AsyncTaskMethodBuilder<IPlayerInfo>.Start<SteamPlatform.<GetPlayerInformationAsync>d__57>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<GetPlayerInformationAsync>d__57>
	|
	|-RVA: 0x1215F0 Offset: 0x1209F0 VA: 0x1801215F0
	|-AsyncTaskMethodBuilder<IPlayerInventory>.Start<SteamPlatform.<CraftItem>d__20>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<CraftItem>d__20>
	|
	|-RVA: 0x121730 Offset: 0x120B30 VA: 0x180121730
	|-AsyncTaskMethodBuilder<IPlayerInventory>.Start<SteamPlatform.<RefreshAndGetItems>d__19>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<RefreshAndGetItems>d__19>
	|
	|-RVA: 0x1217D0 Offset: 0x120BD0 VA: 0x1801217D0
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|-AsyncTaskMethodBuilder<object>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0x13B260 Offset: 0x13A660 VA: 0x18013B260
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.Start<SteamInventoryCrafting.<GetMarketPrice>d__29>
	|-AsyncTaskMethodBuilder<object>.Start<SteamInventoryCrafting.<GetMarketPrice>d__29>
	|
	|-RVA: 0x13B250 Offset: 0x13A650 VA: 0x18013B250
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.Start<SteamInventoryCrafting.<GetMarketPriceImpl>d__30>
	|-AsyncTaskMethodBuilder<object>.Start<SteamInventoryCrafting.<GetMarketPriceImpl>d__30>
	|
	|-RVA: 0x13B210 Offset: 0x13A610 VA: 0x18013B210
	|-AsyncTaskMethodBuilder<AuthTicket>.Start<SteamUser.<GetAuthSessionTicketAsync>d__54>
	|-AsyncTaskMethodBuilder<object>.Start<SteamUser.<GetAuthSessionTicketAsync>d__54>
	|
	|-RVA: 0x13B230 Offset: 0x13A630 VA: 0x18013B230
	|-AsyncTaskMethodBuilder<InventoryDef[]>.Start<SteamInventory.<GetDefinitionsWithPricesAsync>d__19>
	|-AsyncTaskMethodBuilder<object>.Start<SteamInventory.<GetDefinitionsWithPricesAsync>d__19>
	|
	|-RVA: 0x121800 Offset: 0x120C00 VA: 0x180121800
	|-AsyncTaskMethodBuilder<PublishResult>.Start<Editor.<SubmitAsync>d__40>
	|
	|-RVA: 0x121690 Offset: 0x120A90 VA: 0x180121690
	|-AsyncTaskMethodBuilder<bool>.Start<SteelSeriesGameSenseService.<Initialize>d__10>
	|
	|-RVA: 0x121710 Offset: 0x120B10 VA: 0x180121710
	|-AsyncTaskMethodBuilder<bool>.Start<ShoutcastStream.<ReadDataAsync>d__43>
	|
	|-RVA: 0x121720 Offset: 0x120B20 VA: 0x180121720
	|-AsyncTaskMethodBuilder<bool>.Start<ShoutcastStream.<ReadDataAsync>d__44>
	|
	|-RVA: 0x121750 Offset: 0x120B50 VA: 0x180121750
	|-AsyncTaskMethodBuilder<bool>.Start<Base.<RunQueryAsync>d__15>
	|
	|-RVA: 0x121760 Offset: 0x120B60 VA: 0x180121760
	|-AsyncTaskMethodBuilder<bool>.Start<IpList.<RunQueryAsync>d__4>
	|
	|-RVA: 0x121840 Offset: 0x120C40 VA: 0x180121840
	|-AsyncTaskMethodBuilder<bool>.Start<SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-RVA: 0x13B220 Offset: 0x13A620 VA: 0x18013B220
	|-AsyncTaskMethodBuilder<byte[]>.Start<SourceServerQuery.<GetChallengeData>d__7>
	|-AsyncTaskMethodBuilder<object>.Start<SourceServerQuery.<GetChallengeData>d__7>
	|
	|-RVA: 0x13B300 Offset: 0x13A700 VA: 0x18013B300
	|-AsyncTaskMethodBuilder<byte[]>.Start<SourceServerQuery.<Receive>d__6>
	|-AsyncTaskMethodBuilder<object>.Start<SourceServerQuery.<Receive>d__6>
	|
	|-RVA: 0x13B310 Offset: 0x13A710 VA: 0x18013B310
	|-AsyncTaskMethodBuilder<byte[]>.Start<SteamUser.<RequestEncryptedAppTicketAsync>d__71>
	|-AsyncTaskMethodBuilder<object>.Start<SteamUser.<RequestEncryptedAppTicketAsync>d__71>
	|
	|-RVA: 0x13B2C0 Offset: 0x13A6C0 VA: 0x18013B2C0
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<ServerInfoExtensions.<QueryRulesAsync>d__0>
	|-AsyncTaskMethodBuilder<object>.Start<ServerInfoExtensions.<QueryRulesAsync>d__0>
	|
	|-RVA: 0x13B2B0 Offset: 0x13A6B0 VA: 0x18013B2B0
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<ServerInfoHelpers.<LoadRules>d__1>
	|-AsyncTaskMethodBuilder<object>.Start<ServerInfoHelpers.<LoadRules>d__1>
	|
	|-RVA: 0x13B2D0 Offset: 0x13A6D0 VA: 0x18013B2D0
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<ServerInfo.<QueryRulesAsync>d__85>
	|-AsyncTaskMethodBuilder<object>.Start<ServerInfo.<QueryRulesAsync>d__85>
	|
	|-RVA: 0x13B290 Offset: 0x13A690 VA: 0x18013B290
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<SourceServerQuery.<GetRules>d__5>
	|-AsyncTaskMethodBuilder<object>.Start<SourceServerQuery.<GetRules>d__5>
	|
	|-RVA: 0x13B280 Offset: 0x13A680 VA: 0x18013B280
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<SourceServerQuery.<GetRulesImpl>d__4>
	|-AsyncTaskMethodBuilder<object>.Start<SourceServerQuery.<GetRulesImpl>d__4>
	|
	|-RVA: 0x121640 Offset: 0x120A40 VA: 0x180121640
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.Start<SteamPlatform.<GetItemDefinitionsWithPrices>d__21>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<GetItemDefinitionsWithPrices>d__21>
	|
	|-RVA: 0x13B200 Offset: 0x13A600 VA: 0x18013B200
	|-AsyncTaskMethodBuilder<Stream>.Start<HttpContent.<CreateContentReadStreamAsync>d__12>
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<CreateContentReadStreamAsync>d__12>
	|
	|-RVA: 0x13B2E0 Offset: 0x13A6E0 VA: 0x18013B2E0
	|-AsyncTaskMethodBuilder<Stream>.Start<HttpContent.<ReadAsStreamAsync>d__18>
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<ReadAsStreamAsync>d__18>
	|
	|-RVA: 0x13B270 Offset: 0x13A670 VA: 0x18013B270
	|-AsyncTaskMethodBuilder<Stream>.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|-AsyncTaskMethodBuilder<object>.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0x1216B0 Offset: 0x120AB0 VA: 0x1801216B0
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x1217E0 Offset: 0x120BE0 VA: 0x1801217E0
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<StartOperation>d__58>
	|
	|-RVA: 0x121700 Offset: 0x120B00 VA: 0x180121700
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x13B340 Offset: 0x13A740 VA: 0x18013B340
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.Start<HttpClient.<SendAsyncWorker>d__47>
	|-AsyncTaskMethodBuilder<object>.Start<HttpClient.<SendAsyncWorker>d__47>
	|
	|-RVA: 0x13B330 Offset: 0x13A730 VA: 0x18013B330
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.Start<HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<object>.Start<HttpClientHandler.<SendAsync>d__64>
	|
	|-RVA: 0x1216C0 Offset: 0x120AC0 VA: 0x1801216C0
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.Start<ServerInfoHelpers.<Load>d__0>
	|
	|-RVA: 0x121650 Offset: 0x120A50 VA: 0x180121650
	|-AsyncTaskMethodBuilder<Nullable<Image>>.Start<SteamFriends.<GetMediumAvatarAsync>d__53>
	|
	|-RVA: 0x1217F0 Offset: 0x120BF0 VA: 0x1801217F0
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.Start<SteamInventory.<StartPurchaseAsync>d__39>
	|
	|-RVA: 0x1215A0 Offset: 0x1209A0 VA: 0x1801215A0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<InventoryItem.<AddAsync>d__23>
	|
	|-RVA: 0x1215C0 Offset: 0x1209C0 VA: 0x1801215C0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<InventoryItem.<ConsumeAsync>d__21>
	|
	|-RVA: 0x1217C0 Offset: 0x120BC0 VA: 0x1801217C0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<InventoryItem.<SplitStackAsync>d__22>
	|
	|-RVA: 0x121620 Offset: 0x120A20 VA: 0x180121620
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<InventoryResult.<GetAsync>d__11>
	|
	|-RVA: 0x1215D0 Offset: 0x1209D0 VA: 0x1801215D0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<CraftItemAsync>d__33>
	|
	|-RVA: 0x1215E0 Offset: 0x1209E0 VA: 0x1801215E0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<CraftItemAsync>d__34>
	|
	|-RVA: 0x121610 Offset: 0x120A10 VA: 0x180121610
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<GetAllItemsAsync>d__31>
	|
	|-RVA: 0x121680 Offset: 0x120A80 VA: 0x180121680
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<GrantPromoItemsAsync>d__36>
	|
	|-RVA: 0x121810 Offset: 0x120C10 VA: 0x180121810
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<TriggerItemDropAsync>d__37>
	|
	|-RVA: 0x121830 Offset: 0x120C30 VA: 0x180121830
	|-AsyncTaskMethodBuilder<Nullable<Result>>.Start<Item.<Vote>d__83>
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.Start<Item.<Vote>d__83>
	|
	|-RVA: 0x1216F0 Offset: 0x120AF0 VA: 0x1801216F0
	|-AsyncTaskMethodBuilder<Nullable<Item>>.Start<SteamUGC.<QueryFileAsync>d__19>
	|
	|-RVA: 0x121660 Offset: 0x120A60 VA: 0x180121660
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.Start<Query.<GetPageAsync>d__76>
	|
	|-RVA: 0x1216A0 Offset: 0x120AA0 VA: 0x1801216A0
	|-AsyncTaskMethodBuilder<Nullable<int>>.Start<AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x121820 Offset: 0x120C20 VA: 0x180121820
	|-AsyncTaskMethodBuilder<object>.Start<BenchmarkData.<Upload>d__13>
	|-AsyncTaskMethodBuilder<string>.Start<BenchmarkData.<Upload>d__13>
	|
	|-RVA: 0x121740 Offset: 0x120B40 VA: 0x180121740
	|-AsyncTaskMethodBuilder<object>.Start<Feedback.<Report>d__0>
	|-AsyncTaskMethodBuilder<string>.Start<Feedback.<Report>d__0>
	|
	|-RVA: 0x121600 Offset: 0x120A00 VA: 0x180121600
	|-AsyncTaskMethodBuilder<object>.Start<WebUtil.<DownloadFileTemp>d__3>
	|-AsyncTaskMethodBuilder<string>.Start<WebUtil.<DownloadFileTemp>d__3>
	|
	|-RVA: 0x1216D0 Offset: 0x120AD0 VA: 0x1801216D0
	|-AsyncTaskMethodBuilder<object>.Start<WebUtil.<PostAsync>d__6>
	|-AsyncTaskMethodBuilder<string>.Start<WebUtil.<PostAsync>d__6>
	|
	|-RVA: 0x1216E0 Offset: 0x120AE0 VA: 0x1801216E0
	|-AsyncTaskMethodBuilder<object>.Start<WebUtil.<PostDataAsync>d__8>
	|-AsyncTaskMethodBuilder<string>.Start<WebUtil.<PostDataAsync>d__8>
	|
	|-RVA: 0x121780 Offset: 0x120B80 VA: 0x180121780
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>>
	|
	|-RVA: 0x121790 Offset: 0x120B90 VA: 0x180121790
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>>
	|
	|-RVA: 0x1217B0 Offset: 0x120BB0 VA: 0x1801217B0
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<GameMetadata>>
	|
	|-RVA: 0x1217A0 Offset: 0x120BA0 VA: 0x1801217A0
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<LoadGoLispHandlers>>
	|
	|-RVA: 0x121770 Offset: 0x120B70 VA: 0x180121770
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<RegisterGameEvent>>
	|
	|-RVA: 0x13B350 Offset: 0x13A750 VA: 0x18013B350
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<RegisterTimelineEvents>>
	|
	|-RVA: 0x13B360 Offset: 0x13A760 VA: 0x18013B360
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<RemoveGame>>
	|
	|-RVA: 0x13B320 Offset: 0x13A720 VA: 0x18013B320
	|-AsyncTaskMethodBuilder<object>.Start<FileDialog.<SaveAsync>d__24>
	|-AsyncTaskMethodBuilder<string>.Start<FileDialog.<SaveAsync>d__24>
	|
	|-RVA: 0x13B2A0 Offset: 0x13A6A0 VA: 0x18013B2A0
	|-AsyncTaskMethodBuilder<object>.Start<HttpClient.<GetStringAsync>d__52>
	|-AsyncTaskMethodBuilder<string>.Start<HttpClient.<GetStringAsync>d__52>
	|
	|-RVA: 0x13B2F0 Offset: 0x13A6F0 VA: 0x18013B2F0
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<ReadAsStringAsync>d__20>
	|-AsyncTaskMethodBuilder<string>.Start<HttpContent.<ReadAsStringAsync>d__20>
	|
	|-RVA: 0x13B1F0 Offset: 0x13A5F0 VA: 0x18013B1F0
	|-AsyncTaskMethodBuilder<object>.Start<object>
	|
	|-RVA: 0x13B240 Offset: 0x13A640 VA: 0x18013B240
	|-AsyncTaskMethodBuilder<object>.Start<XmlUrlResolver.<GetEntityAsync>d__15>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2880 Offset: 0x1E1C80 VA: 0x1801E2880
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.SetStateMachine
	|-AsyncTaskMethodBuilder<IAuthTicket>.SetStateMachine
	|-AsyncTaskMethodBuilder<IPlayerInfo>.SetStateMachine
	|-AsyncTaskMethodBuilder<IPlayerInventory>.SetStateMachine
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.SetStateMachine
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.SetStateMachine
	|-AsyncTaskMethodBuilder<AuthTicket>.SetStateMachine
	|-AsyncTaskMethodBuilder<InventoryDef[]>.SetStateMachine
	|-AsyncTaskMethodBuilder<PublishResult>.SetStateMachine
	|-AsyncTaskMethodBuilder<bool>.SetStateMachine
	|-AsyncTaskMethodBuilder<byte[]>.SetStateMachine
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.SetStateMachine
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Stream>.SetStateMachine
	|-AsyncTaskMethodBuilder<int>.SetStateMachine
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<Image>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<Result>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<Item>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.SetStateMachine
	|-AsyncTaskMethodBuilder<object>.SetStateMachine
	|-AsyncTaskMethodBuilder<string>.SetStateMachine
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1210F0 Offset: 0x1204F0 VA: 0x1801210F0
	|-AsyncTaskMethodBuilder<InventoryDef[]>.AwaitOnCompleted<CallResult<SteamInventoryRequestPricesResult_t>, SteamInventory.<GetDefinitionsWithPricesAsync>d__19>
	|-AsyncTaskMethodBuilder<object>.AwaitOnCompleted<CallResult<SteamInventoryRequestPricesResult_t>, SteamInventory.<GetDefinitionsWithPricesAsync>d__19>
	|
	|-RVA: 0x121110 Offset: 0x120510 VA: 0x180121110
	|-AsyncTaskMethodBuilder<PublishResult>.AwaitOnCompleted<CallResult<CreateItemResult_t>, Editor.<SubmitAsync>d__40>
	|
	|-RVA: 0x1210D0 Offset: 0x1204D0 VA: 0x1801210D0
	|-AsyncTaskMethodBuilder<byte[]>.AwaitOnCompleted<CallResult<EncryptedAppTicketResponse_t>, SteamUser.<RequestEncryptedAppTicketAsync>d__71>
	|-AsyncTaskMethodBuilder<object>.AwaitOnCompleted<CallResult<EncryptedAppTicketResponse_t>, SteamUser.<RequestEncryptedAppTicketAsync>d__71>
	|
	|-RVA: 0x121120 Offset: 0x120520 VA: 0x180121120
	|-AsyncTaskMethodBuilder<int>.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x1210E0 Offset: 0x1204E0 VA: 0x1801210E0
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.AwaitOnCompleted<CallResult<SteamInventoryStartPurchaseResult_t>, SteamInventory.<StartPurchaseAsync>d__39>
	|
	|-RVA: 0x1210C0 Offset: 0x1204C0 VA: 0x1801210C0
	|-AsyncTaskMethodBuilder<Nullable<Result>>.AwaitOnCompleted<CallResult<SetUserItemVoteResult_t>, Item.<Vote>d__83>
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.AwaitOnCompleted<CallResult<SetUserItemVoteResult_t>, Item.<Vote>d__83>
	|
	|-RVA: 0x121100 Offset: 0x120500 VA: 0x180121100
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.AwaitOnCompleted<CallResult<SteamUGCQueryCompleted_t>, Query.<GetPageAsync>d__76>
	|
	|-RVA: 0x121130 Offset: 0x120530 VA: 0x180121130
	|-AsyncTaskMethodBuilder<object>.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x13AE10 Offset: 0x13A210 VA: 0x18013AE10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x13AE00 Offset: 0x13A200 VA: 0x18013AE00
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121290 Offset: 0x120690 VA: 0x180121290
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, CompanionSubscription.<CheckStatus>d__5>
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, CompanionSubscription.<CheckStatus>d__5>
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.AwaitUnsafeOnCompleted<TaskAwaiter<string>, CompanionSubscription.<CheckStatus>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<CheckStatus>d__5>
	|
	|-RVA: 0x1212A0 Offset: 0x1206A0 VA: 0x1801212A0
	|-AsyncTaskMethodBuilder<IAuthTicket>.AwaitUnsafeOnCompleted<TaskAwaiter<AuthTicket>, SteamPlatform.<GetAuthSessionTicketAsync>d__53>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamPlatform.<GetAuthSessionTicketAsync>d__53>
	|
	|-RVA: 0x121510 Offset: 0x120910 VA: 0x180121510
	|-AsyncTaskMethodBuilder<IPlayerInfo>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamPlatform.<GetPlayerInformationAsync>d__57>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamPlatform.<GetPlayerInformationAsync>d__57>
	|
	|-RVA: 0x121440 Offset: 0x120840 VA: 0x180121440
	|-AsyncTaskMethodBuilder<IPlayerInventory>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<CraftItem>d__20>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<CraftItem>d__20>
	|
	|-RVA: 0x121470 Offset: 0x120870 VA: 0x180121470
	|-AsyncTaskMethodBuilder<IPlayerInventory>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<RefreshAndGetItems>d__19>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<RefreshAndGetItems>d__19>
	|
	|-RVA: 0x1211D0 Offset: 0x1205D0 VA: 0x1801211D0
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0x1212E0 Offset: 0x1206E0 VA: 0x1801212E0
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.AwaitUnsafeOnCompleted<TaskAwaiter<SteamInventoryCrafting.MarketPrice>, SteamInventoryCrafting.<GetMarketPrice>d__29>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryCrafting.<GetMarketPrice>d__29>
	|
	|-RVA: 0x1212D0 Offset: 0x1206D0 VA: 0x1801212D0
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.AwaitUnsafeOnCompleted<TaskAwaiter<string>, SteamInventoryCrafting.<GetMarketPriceImpl>d__30>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryCrafting.<GetMarketPriceImpl>d__30>
	|
	|-RVA: 0x1214E0 Offset: 0x1208E0 VA: 0x1801214E0
	|-AsyncTaskMethodBuilder<AuthTicket>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamUser.<GetAuthSessionTicketAsync>d__54>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamUser.<GetAuthSessionTicketAsync>d__54>
	|
	|-RVA: 0x121590 Offset: 0x120990 VA: 0x180121590
	|-AsyncTaskMethodBuilder<PublishResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Editor.<SubmitAsync>d__40>
	|
	|-RVA: 0x121170 Offset: 0x120570 VA: 0x180121170
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-RVA: 0x121250 Offset: 0x120650 VA: 0x180121250
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-RVA: 0x121570 Offset: 0x120970 VA: 0x180121570
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter, Base.<RunQueryAsync>d__15>
	|
	|-RVA: 0x1214A0 Offset: 0x1208A0 VA: 0x1801214A0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ShoutcastStream.<ReadDataAsync>d__43>
	|
	|-RVA: 0x1214B0 Offset: 0x1208B0 VA: 0x1801214B0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, IpList.<RunQueryAsync>d__4>
	|
	|-RVA: 0x121280 Offset: 0x120680 VA: 0x180121280
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ShoutcastStream.<ReadDataAsync>d__44>
	|
	|-RVA: 0x121310 Offset: 0x120710 VA: 0x180121310
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Initialize>d__10>
	|
	|-RVA: 0x1214F0 Offset: 0x1208F0 VA: 0x1801214F0
	|-AsyncTaskMethodBuilder<byte[]>.AwaitUnsafeOnCompleted<TaskAwaiter, SourceServerQuery.<GetChallengeData>d__7>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, SourceServerQuery.<GetChallengeData>d__7>
	|
	|-RVA: 0x1212B0 Offset: 0x1206B0 VA: 0x1801212B0
	|-AsyncTaskMethodBuilder<byte[]>.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, SourceServerQuery.<GetChallengeData>d__7>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SourceServerQuery.<GetChallengeData>d__7>
	|
	|-RVA: 0x121270 Offset: 0x120670 VA: 0x180121270
	|-AsyncTaskMethodBuilder<byte[]>.AwaitUnsafeOnCompleted<TaskAwaiter<UdpReceiveResult>, SourceServerQuery.<Receive>d__6>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<UdpReceiveResult>, SourceServerQuery.<Receive>d__6>
	|
	|-RVA: 0x121530 Offset: 0x120930 VA: 0x180121530
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter, ServerInfoHelpers.<LoadRules>d__1>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, ServerInfoHelpers.<LoadRules>d__1>
	|
	|-RVA: 0x121520 Offset: 0x120920 VA: 0x180121520
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter, SourceServerQuery.<GetRules>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, SourceServerQuery.<GetRules>d__5>
	|
	|-RVA: 0x121300 Offset: 0x120700 VA: 0x180121300
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, SourceServerQuery.<GetRules>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SourceServerQuery.<GetRules>d__5>
	|
	|-RVA: 0x121330 Offset: 0x120730 VA: 0x180121330
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ServerInfoExtensions.<QueryRulesAsync>d__0>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ServerInfoExtensions.<QueryRulesAsync>d__0>
	|
	|-RVA: 0x121320 Offset: 0x120720 VA: 0x180121320
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ServerInfoHelpers.<LoadRules>d__1>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ServerInfoHelpers.<LoadRules>d__1>
	|
	|-RVA: 0x121340 Offset: 0x120740 VA: 0x180121340
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ServerInfo.<QueryRulesAsync>d__85>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ServerInfo.<QueryRulesAsync>d__85>
	|
	|-RVA: 0x1212F0 Offset: 0x1206F0 VA: 0x1801212F0
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, SourceServerQuery.<GetRulesImpl>d__4>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SourceServerQuery.<GetRulesImpl>d__4>
	|
	|-RVA: 0x1212C0 Offset: 0x1206C0 VA: 0x1801212C0
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.AwaitUnsafeOnCompleted<TaskAwaiter<InventoryDef[]>, SteamPlatform.<GetItemDefinitionsWithPrices>d__21>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamPlatform.<GetItemDefinitionsWithPrices>d__21>
	|
	|-RVA: 0x121180 Offset: 0x120580 VA: 0x180121180
	|-AsyncTaskMethodBuilder<Stream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<CreateContentReadStreamAsync>d__12>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<CreateContentReadStreamAsync>d__12>
	|
	|-RVA: 0x121210 Offset: 0x120610 VA: 0x180121210
	|-AsyncTaskMethodBuilder<Stream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>, HttpContent.<ReadAsStreamAsync>d__18>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpContent.<ReadAsStreamAsync>d__18>
	|
	|-RVA: 0x1211F0 Offset: 0x1205F0 VA: 0x1801211F0
	|-AsyncTaskMethodBuilder<Stream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse>, XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0x1211A0 Offset: 0x1205A0 VA: 0x1801211A0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x121240 Offset: 0x120640 VA: 0x180121240
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<StartOperation>d__58>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<StartOperation>d__58>
	|
	|-RVA: 0x121150 Offset: 0x120550 VA: 0x180121150
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x121160 Offset: 0x120560 VA: 0x180121160
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x1211C0 Offset: 0x1205C0 VA: 0x1801211C0
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClient.<SendAsyncWorker>d__47>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClient.<SendAsyncWorker>d__47>
	|
	|-RVA: 0x1211B0 Offset: 0x1205B0 VA: 0x1801211B0
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClientHandler.<SendAsync>d__64>
	|
	|-RVA: 0x121220 Offset: 0x120620 VA: 0x180121220
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>, HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse>, HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpClientHandler.<SendAsync>d__64>
	|
	|-RVA: 0x121230 Offset: 0x120630 VA: 0x180121230
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage>, HttpClient.<SendAsyncWorker>d__47>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpClient.<SendAsyncWorker>d__47>
	|
	|-RVA: 0x121360 Offset: 0x120760 VA: 0x180121360
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, HttpClientHandler.<SendAsync>d__64>
	|
	|-RVA: 0x121540 Offset: 0x120940 VA: 0x180121540
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.AwaitUnsafeOnCompleted<TaskAwaiter, ServerInfoHelpers.<Load>d__0>
	|
	|-RVA: 0x121500 Offset: 0x120900 VA: 0x180121500
	|-AsyncTaskMethodBuilder<Nullable<Image>>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamFriends.<GetMediumAvatarAsync>d__53>
	|
	|-RVA: 0x1214D0 Offset: 0x1208D0 VA: 0x1801214D0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter, InventoryResult.<GetAsync>d__11>
	|
	|-RVA: 0x121400 Offset: 0x120800 VA: 0x180121400
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, InventoryItem.<AddAsync>d__23>
	|
	|-RVA: 0x121410 Offset: 0x120810 VA: 0x180121410
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, InventoryItem.<ConsumeAsync>d__21>
	|
	|-RVA: 0x121480 Offset: 0x120880 VA: 0x180121480
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, InventoryItem.<SplitStackAsync>d__22>
	|
	|-RVA: 0x121420 Offset: 0x120820 VA: 0x180121420
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<CraftItemAsync>d__33>
	|
	|-RVA: 0x121430 Offset: 0x120830 VA: 0x180121430
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<CraftItemAsync>d__34>
	|
	|-RVA: 0x121450 Offset: 0x120850 VA: 0x180121450
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<GetAllItemsAsync>d__31>
	|
	|-RVA: 0x121460 Offset: 0x120860 VA: 0x180121460
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<GrantPromoItemsAsync>d__36>
	|
	|-RVA: 0x121490 Offset: 0x120890 VA: 0x180121490
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<TriggerItemDropAsync>d__37>
	|
	|-RVA: 0x1213F0 Offset: 0x1207F0 VA: 0x1801213F0
	|-AsyncTaskMethodBuilder<Nullable<Item>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<ResultPage>>, SteamUGC.<QueryFileAsync>d__19>
	|
	|-RVA: 0x121140 Offset: 0x120540 VA: 0x180121140
	|-AsyncTaskMethodBuilder<Nullable<int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x121260 Offset: 0x120660 VA: 0x180121260
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x121190 Offset: 0x120590 VA: 0x180121190
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<ReadAsStringAsync>d__20>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<ReadAsStringAsync>d__20>
	|
	|-RVA: 0x1211E0 Offset: 0x1205E0 VA: 0x1801211E0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>, XmlUrlResolver.<GetEntityAsync>d__15>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-RVA: 0x121200 Offset: 0x120600 VA: 0x180121200
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpClient.<GetStringAsync>d__52>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage>, HttpClient.<GetStringAsync>d__52>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string>, HttpClient.<GetStringAsync>d__52>
	|
	|-RVA: 0x1214C0 Offset: 0x1208C0 VA: 0x1801214C0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<DownloadFileTemp>d__3>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<DownloadFileTemp>d__3>
	|
	|-RVA: 0x121550 Offset: 0x120950 VA: 0x180121550
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<PostAsync>d__6>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<PostAsync>d__6>
	|
	|-RVA: 0x121560 Offset: 0x120960 VA: 0x180121560
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<PostDataAsync>d__8>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<PostDataAsync>d__8>
	|
	|-RVA: 0x121580 Offset: 0x120980 VA: 0x180121580
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, FileDialog.<SaveAsync>d__24>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter, FileDialog.<SaveAsync>d__24>
	|
	|-RVA: 0x1213E0 Offset: 0x1207E0 VA: 0x1801213E0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, BenchmarkData.<Upload>d__13>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter<string>, BenchmarkData.<Upload>d__13>
	|
	|-RVA: 0x121350 Offset: 0x120750 VA: 0x180121350
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Feedback.<Report>d__0>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, Feedback.<Report>d__0>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Feedback.<Report>d__0>
	|
	|-RVA: 0x121390 Offset: 0x120790 VA: 0x180121390
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>>
	|
	|-RVA: 0x1213B0 Offset: 0x1207B0 VA: 0x1801213B0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>>
	|
	|-RVA: 0x1213D0 Offset: 0x1207D0 VA: 0x1801213D0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<GameMetadata>>
	|
	|-RVA: 0x1213C0 Offset: 0x1207C0 VA: 0x1801213C0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<LoadGoLispHandlers>>
	|
	|-RVA: 0x121370 Offset: 0x120770 VA: 0x180121370
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<RegisterGameEvent>>
	|
	|-RVA: 0x121380 Offset: 0x120780 VA: 0x180121380
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<RegisterTimelineEvents>>
	|
	|-RVA: 0x1213A0 Offset: 0x1207A0 VA: 0x1801213A0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<RemoveGame>>
	|
	|-RVA: 0x13AEA0 Offset: 0x13A2A0 VA: 0x18013AEA0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x13AE70 Offset: 0x13A270 VA: 0x18013AE70
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x13AE50 Offset: 0x13A250 VA: 0x18013AE50
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x13AE40 Offset: 0x13A240 VA: 0x18013AE40
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<CopyToAsyncInternal>d__27>
	|
	|-RVA: 0x13AE60 Offset: 0x13A260 VA: 0x18013AE60
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<LoadIntoBufferAsync>d__17>
	|
	|-RVA: 0x13AE80 Offset: 0x13A280 VA: 0x18013AE80
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x13AE20 Offset: 0x13A220 VA: 0x18013AE20
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<CopyToAsyncInternal>d__27>
	|
	|-RVA: 0x13AE30 Offset: 0x13A230 VA: 0x18013AE30
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x13AE90 Offset: 0x13A290 VA: 0x18013AE90
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x13B110 Offset: 0x13A510 VA: 0x18013B110
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunAsync>d__7>
	|
	|-RVA: 0x13B120 Offset: 0x13A520 VA: 0x18013B120
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunBenchmarkScene>d__9>
	|
	|-RVA: 0x13B130 Offset: 0x13A530 VA: 0x18013B130
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunBenchmarksInScene>d__10>
	|
	|-RVA: 0x13B140 Offset: 0x13A540 VA: 0x18013B140
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunDemoBasedBenchmark>d__12>
	|
	|-RVA: 0x13B150 Offset: 0x13A550 VA: 0x18013B150
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunSingleSceneAsync>d__8>
	|
	|-RVA: 0x13B030 Offset: 0x13A430 VA: 0x18013B030
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Client.<Connect>d__37>
	|
	|-RVA: 0x13B0D0 Offset: 0x13A4D0 VA: 0x18013B0D0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Account.<ReadAllNotices>d__7>
	|
	|-RVA: 0x13B0B0 Offset: 0x13A4B0 VA: 0x18013B0B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-RVA: 0x13B170 Offset: 0x13A570 VA: 0x18013B170
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Start>d__31>
	|
	|-RVA: 0x13B180 Offset: 0x13A580 VA: 0x18013B180
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x13B070 Offset: 0x13A470 VA: 0x18013B070
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-RVA: 0x13B040 Offset: 0x13A440 VA: 0x18013B040
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-RVA: 0x13B0A0 Offset: 0x13A4A0 VA: 0x18013B0A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryManager.<FixStacks>d__9>
	|
	|-RVA: 0x13B0F0 Offset: 0x13A4F0 VA: 0x18013B0F0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryManager.<Refresh>d__8>
	|
	|-RVA: 0x13B0C0 Offset: 0x13A4C0 VA: 0x18013B0C0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryNewItem.<Open>d__0>
	|
	|-RVA: 0x13B050 Offset: 0x13A450 VA: 0x18013B050
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<DoExport>d__15>
	|
	|-RVA: 0x13B060 Offset: 0x13A460 VA: 0x18013B060
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<DoExport>d__21>
	|
	|-RVA: 0x13B080 Offset: 0x13A480 VA: 0x18013B080
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<ExportTexture>d__19>
	|
	|-RVA: 0x13B090 Offset: 0x13A490 VA: 0x18013B090
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<ExportToFolder>d__16>
	|
	|-RVA: 0x13B0E0 Offset: 0x13A4E0 VA: 0x18013B0E0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, ServerHistory.<Refresh>d__4>
	|
	|-RVA: 0x13B160 Offset: 0x13A560 VA: 0x18013B160
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, ShoutcastStream.<ShutdownSafely>d__54>
	|
	|-RVA: 0x13B100 Offset: 0x13A500 VA: 0x18013B100
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Friend.<RequestInfoAsync>d__13>
	|
	|-RVA: 0x13B020 Offset: 0x13A420 VA: 0x18013B020
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamFriends.<CacheUserInformationAsync>d__51>
	|
	|-RVA: 0x13AEB0 Offset: 0x13A2B0 VA: 0x18013AEB0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<PublishResult>, Publisher.<PublishToSteam>d__18>
	|
	|-RVA: 0x13AED0 Offset: 0x13A2D0 VA: 0x18013AED0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<int>, SourceServerQuery.<Send>d__8>
	|
	|-RVA: 0x13B010 Offset: 0x13A410 VA: 0x18013B010
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-RVA: 0x13AFF0 Offset: 0x13A3F0 VA: 0x18013AFF0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-RVA: 0x13B000 Offset: 0x13A400 VA: 0x18013B000
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventoryManager.<FixStacks>d__9>
	|
	|-RVA: 0x13AEC0 Offset: 0x13A2C0 VA: 0x18013AEC0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<Item>>, Publisher.<PublishToSteam>d__18>
	|
	|-RVA: 0x13AFE0 Offset: 0x13A3E0 VA: 0x18013AFE0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<ResultPage>>, WorkshopItemList.<Refresh>d__26>
	|
	|-RVA: 0x13AF70 Offset: 0x13A370 VA: 0x18013AF70
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Benchmarking.<Report>d__11>
	|
	|-RVA: 0x13AEE0 Offset: 0x13A2E0 VA: 0x18013AEE0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<Add>d__6>
	|
	|-RVA: 0x13AF60 Offset: 0x13A360 VA: 0x18013AF60
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<Remove>d__7>
	|
	|-RVA: 0x13AF20 Offset: 0x13A320 VA: 0x18013AF20
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EAC.<OnJoinServer>d__16>
	|
	|-RVA: 0x13AF30 Offset: 0x13A330 VA: 0x18013AF30
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Account.<ReadAllNotices>d__7>
	|
	|-RVA: 0x13AF40 Offset: 0x13A340 VA: 0x18013AF40
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Account.<Refresh>d__6>
	|
	|-RVA: 0x13AF80 Offset: 0x13A380 VA: 0x18013AF80
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendEvent>d__15>
	|
	|-RVA: 0x13AF90 Offset: 0x13A390 VA: 0x18013AF90
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendHeartbeat>d__12>
	|
	|-RVA: 0x13AFA0 Offset: 0x13A3A0 VA: 0x18013AFA0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendPulseColor>d__14>
	|
	|-RVA: 0x13AFB0 Offset: 0x13A3B0 VA: 0x18013AFB0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendStaticColor>d__13>
	|
	|-RVA: 0x13AFD0 Offset: 0x13A3D0 VA: 0x18013AFD0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-RVA: 0x13AFC0 Offset: 0x13A3C0 VA: 0x18013AFC0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Hero.<ShowAsync>d__10>
	|
	|-RVA: 0x13AF10 Offset: 0x13A310 VA: 0x18013AF10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-RVA: 0x13AF50 Offset: 0x13A350 VA: 0x18013AF50
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryManager.<Refresh>d__8>
	|
	|-RVA: 0x13AF00 Offset: 0x13A300 VA: 0x18013AF00
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Publisher.<DoExport>d__21>
	|
	|-RVA: 0x13AEF0 Offset: 0x13A2F0 VA: 0x18013AEF0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ShoutcastStream.<ConnectAsync>d__42>
	|
	|-RVA: 0x13B1C0 Offset: 0x13A5C0 VA: 0x18013B1C0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x13B1E0 Offset: 0x13A5E0 VA: 0x18013B1E0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Update>d__33>
	|
	|-RVA: 0x13B1A0 Offset: 0x13A5A0 VA: 0x18013B1A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StartServices>d__15>
	|
	|-RVA: 0x13B1B0 Offset: 0x13A5B0 VA: 0x18013B1B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StopServices>d__16>
	|
	|-RVA: 0x13B1D0 Offset: 0x13A5D0 VA: 0x18013B1D0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<UpdateServices>d__17>
	|
	|-RVA: 0x13B190 Offset: 0x13A590 VA: 0x18013B190
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, RestRgbService.<Start>d__31>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2890 Offset: 0x1E1C90 VA: 0x1801E2890
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.get_Task
	|-AsyncTaskMethodBuilder<IAuthTicket>.get_Task
	|-AsyncTaskMethodBuilder<IPlayerInfo>.get_Task
	|-AsyncTaskMethodBuilder<IPlayerInventory>.get_Task
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.get_Task
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.get_Task
	|-AsyncTaskMethodBuilder<AuthTicket>.get_Task
	|-AsyncTaskMethodBuilder<InventoryDef[]>.get_Task
	|-AsyncTaskMethodBuilder<PublishResult>.get_Task
	|-AsyncTaskMethodBuilder<byte[]>.get_Task
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.get_Task
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.get_Task
	|-AsyncTaskMethodBuilder<Stream>.get_Task
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<Image>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<Result>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<Item>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<int>>.get_Task
	|-AsyncTaskMethodBuilder<string>.get_Task
	|-AsyncTaskMethodBuilder<bool>.get_Task
	|-AsyncTaskMethodBuilder<int>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.get_Task
	|-AsyncTaskMethodBuilder<object>.get_Task
	|-AsyncTaskMethodBuilder<VoidTaskResult>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2710 Offset: 0x1E1B10 VA: 0x1801E2710
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.SetResult
	|-AsyncTaskMethodBuilder<IAuthTicket>.SetResult
	|-AsyncTaskMethodBuilder<IPlayerInfo>.SetResult
	|-AsyncTaskMethodBuilder<IPlayerInventory>.SetResult
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.SetResult
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.SetResult
	|-AsyncTaskMethodBuilder<AuthTicket>.SetResult
	|-AsyncTaskMethodBuilder<InventoryDef[]>.SetResult
	|-AsyncTaskMethodBuilder<byte[]>.SetResult
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.SetResult
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.SetResult
	|-AsyncTaskMethodBuilder<Stream>.SetResult
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.SetResult
	|-AsyncTaskMethodBuilder<object>.SetResult
	|-AsyncTaskMethodBuilder<string>.SetResult
	|
	|-RVA: 0x213F20 Offset: 0x213320 VA: 0x180213F20
	|-AsyncTaskMethodBuilder<PublishResult>.SetResult
	|
	|-RVA: 0x213FD0 Offset: 0x2133D0 VA: 0x180213FD0
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x213F50 Offset: 0x213350 VA: 0x180213F50
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x213D60 Offset: 0x213160 VA: 0x180213D60
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.SetResult
	|
	|-RVA: 0x213CD0 Offset: 0x2130D0 VA: 0x180213CD0
	|-AsyncTaskMethodBuilder<Nullable<Image>>.SetResult
	|
	|-RVA: 0x213DC0 Offset: 0x2131C0 VA: 0x180213DC0
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.SetResult
	|
	|-RVA: 0x1E2730 Offset: 0x1E1B30 VA: 0x1801E2730
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.SetResult
	|
	|-RVA: 0x1E2520 Offset: 0x1E1920 VA: 0x1801E2520
	|-AsyncTaskMethodBuilder<Nullable<Result>>.SetResult
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.SetResult
	|
	|-RVA: 0x1E2610 Offset: 0x1E1A10 VA: 0x1801E2610
	|-AsyncTaskMethodBuilder<Nullable<Item>>.SetResult
	|
	|-RVA: 0x1E2420 Offset: 0x1E1820 VA: 0x1801E2420
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.SetResult
	|
	|-RVA: 0x1E2720 Offset: 0x1E1B20 VA: 0x1801E2720
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x1E2410 Offset: 0x1E1810 VA: 0x1801E2410
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	*/

	// RVA: -1 Offset: -1
	internal void SetResult(Task<TResult> completedTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x213FE0 Offset: 0x2133E0 VA: 0x180213FE0
	|-AsyncTaskMethodBuilder<PublishResult>.SetResult
	|
	|-RVA: 0x213C70 Offset: 0x213070 VA: 0x180213C70
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x213D00 Offset: 0x213100 VA: 0x180213D00
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x213DF0 Offset: 0x2131F0 VA: 0x180213DF0
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.SetResult
	|
	|-RVA: 0x213EA0 Offset: 0x2132A0 VA: 0x180213EA0
	|-AsyncTaskMethodBuilder<Nullable<Image>>.SetResult
	|
	|-RVA: 0x213F60 Offset: 0x213360 VA: 0x180213F60
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.SetResult
	|
	|-RVA: 0x1E2530 Offset: 0x1E1930 VA: 0x1801E2530
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.SetResult
	|
	|-RVA: 0x1E2760 Offset: 0x1E1B60 VA: 0x1801E2760
	|-AsyncTaskMethodBuilder<Nullable<Item>>.SetResult
	|
	|-RVA: 0x1E24B0 Offset: 0x1E18B0 VA: 0x1801E24B0
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.SetResult
	|
	|-RVA: 0x1E2450 Offset: 0x1E1850 VA: 0x1801E2450
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x1E23B0 Offset: 0x1E17B0 VA: 0x1801E23B0
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.SetResult
	|
	|-RVA: 0x1E26B0 Offset: 0x1E1AB0 VA: 0x1801E26B0
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0x1E25B0 Offset: 0x1E19B0 VA: 0x1801E25B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2370 Offset: 0x1E1770 VA: 0x1801E2370
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.SetException
	|-AsyncTaskMethodBuilder<IAuthTicket>.SetException
	|-AsyncTaskMethodBuilder<IPlayerInfo>.SetException
	|-AsyncTaskMethodBuilder<IPlayerInventory>.SetException
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.SetException
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.SetException
	|-AsyncTaskMethodBuilder<AuthTicket>.SetException
	|-AsyncTaskMethodBuilder<InventoryDef[]>.SetException
	|-AsyncTaskMethodBuilder<byte[]>.SetException
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.SetException
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.SetException
	|-AsyncTaskMethodBuilder<Stream>.SetException
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.SetException
	|-AsyncTaskMethodBuilder<object>.SetException
	|-AsyncTaskMethodBuilder<string>.SetException
	|
	|-RVA: 0x213C50 Offset: 0x213050 VA: 0x180213C50
	|-AsyncTaskMethodBuilder<PublishResult>.SetException
	|
	|-RVA: 0x213C40 Offset: 0x213040 VA: 0x180213C40
	|-AsyncTaskMethodBuilder<bool>.SetException
	|
	|-RVA: 0x213C60 Offset: 0x213060 VA: 0x180213C60
	|-AsyncTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x213C10 Offset: 0x213010 VA: 0x180213C10
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.SetException
	|
	|-RVA: 0x213C30 Offset: 0x213030 VA: 0x180213C30
	|-AsyncTaskMethodBuilder<Nullable<Image>>.SetException
	|
	|-RVA: 0x213C20 Offset: 0x213020 VA: 0x180213C20
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.SetException
	|
	|-RVA: 0x1E2340 Offset: 0x1E1740 VA: 0x1801E2340
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.SetException
	|
	|-RVA: 0x1E2350 Offset: 0x1E1750 VA: 0x1801E2350
	|-AsyncTaskMethodBuilder<Nullable<Result>>.SetException
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.SetException
	|
	|-RVA: 0x1E23A0 Offset: 0x1E17A0 VA: 0x1801E23A0
	|-AsyncTaskMethodBuilder<Nullable<Item>>.SetException
	|
	|-RVA: 0x1E2380 Offset: 0x1E1780 VA: 0x1801E2380
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.SetException
	|
	|-RVA: 0x1E2360 Offset: 0x1E1760 VA: 0x1801E2360
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetException
	|
	|-RVA: 0x1E2390 Offset: 0x1E1790 VA: 0x1801E2390
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetException
	*/

	// RVA: -1 Offset: -1
	private Task<TResult> GetTaskForResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x213BE0 Offset: 0x212FE0 VA: 0x180213BE0
	|-AsyncTaskMethodBuilder<PublishResult>.GetTaskForResult
	|
	|-RVA: 0x213B70 Offset: 0x212F70 VA: 0x180213B70
	|-AsyncTaskMethodBuilder<bool>.GetTaskForResult
	|
	|-RVA: 0x213B30 Offset: 0x212F30 VA: 0x180213B30
	|-AsyncTaskMethodBuilder<int>.GetTaskForResult
	|
	|-RVA: 0x213B80 Offset: 0x212F80 VA: 0x180213B80
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.GetTaskForResult
	|
	|-RVA: 0x213B00 Offset: 0x212F00 VA: 0x180213B00
	|-AsyncTaskMethodBuilder<Nullable<Image>>.GetTaskForResult
	|
	|-RVA: 0x213B40 Offset: 0x212F40 VA: 0x180213B40
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.GetTaskForResult
	|
	|-RVA: 0x1E22E0 Offset: 0x1E16E0 VA: 0x1801E22E0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.GetTaskForResult
	|
	|-RVA: 0x1E2240 Offset: 0x1E1640 VA: 0x1801E2240
	|-AsyncTaskMethodBuilder<Nullable<Item>>.GetTaskForResult
	|
	|-RVA: 0x1E2310 Offset: 0x1E1710 VA: 0x1801E2310
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.GetTaskForResult
	|
	|-RVA: 0x1E2200 Offset: 0x1E1600 VA: 0x1801E2200
	|-AsyncTaskMethodBuilder<Nullable<int>>.GetTaskForResult
	|
	|-RVA: 0x1E2220 Offset: 0x1E1620 VA: 0x1801E2220
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.GetTaskForResult
	|
	|-RVA: 0x1E2210 Offset: 0x1E1610 VA: 0x1801E2210
	|-AsyncTaskMethodBuilder<object>.GetTaskForResult
	|
	|-RVA: 0x1E2230 Offset: 0x1E1630 VA: 0x1801E2230
	|-AsyncTaskMethodBuilder<VoidTaskResult>.GetTaskForResult
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189A0C0 Offset: 0x18994C0 VA: 0x18189A0C0
	|-AsyncTaskMethodBuilder<PublishResult>..cctor
	|
	|-RVA: 0x189A2D0 Offset: 0x18996D0 VA: 0x18189A2D0
	|-AsyncTaskMethodBuilder<bool>..cctor
	|
	|-RVA: 0x189A4D0 Offset: 0x18998D0 VA: 0x18189A4D0
	|-AsyncTaskMethodBuilder<int>..cctor
	|
	|-RVA: 0x189A5C0 Offset: 0x18999C0 VA: 0x18189A5C0
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>..cctor
	|
	|-RVA: 0x189A3C0 Offset: 0x18997C0 VA: 0x18189A3C0
	|-AsyncTaskMethodBuilder<Nullable<Image>>..cctor
	|
	|-RVA: 0x189A1D0 Offset: 0x18995D0 VA: 0x18189A1D0
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>..cctor
	|
	|-RVA: 0x135D830 Offset: 0x135CC30 VA: 0x18135D830
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>..cctor
	|
	|-RVA: 0x135D4C0 Offset: 0x135C8C0 VA: 0x18135D4C0
	|-AsyncTaskMethodBuilder<Nullable<Item>>..cctor
	|
	|-RVA: 0x135D1E0 Offset: 0x135C5E0 VA: 0x18135D1E0
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>..cctor
	|
	|-RVA: 0x135D2E0 Offset: 0x135C6E0 VA: 0x18135D2E0
	|-AsyncTaskMethodBuilder<Nullable<int>>..cctor
	|
	|-RVA: 0x135D740 Offset: 0x135CB40 VA: 0x18135D740
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>..cctor
	|
	|-RVA: 0x135D3D0 Offset: 0x135C7D0 VA: 0x18135D3D0
	|-AsyncTaskMethodBuilder<object>..cctor
	|
	|-RVA: 0x135D650 Offset: 0x135CA50 VA: 0x18135D650
	|-AsyncTaskMethodBuilder<VoidTaskResult>..cctor
	*/

}

internal static class AsyncTaskCache // TypeDefIndex: 1276
{	// Fields
	internal static readonly Task<bool> TrueTask; // 0x0
	internal static readonly Task<bool> FalseTask; // 0x8
	internal static readonly Task<int>[] Int32Tasks; // 0x10

	// Methods

	// RVA: 0xFD7260 Offset: 0xFD6660 VA: 0x180FD7260
	private static Task<int>[] CreateInt32Tasks() { }

	// RVA: -1 Offset: -1
	internal static Task<TResult> CreateCacheableTask<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7CCB0 Offset: 0xE7C0B0 VA: 0x180E7CCB0
	|-AsyncTaskCache.CreateCacheableTask<PublishResult>
	|-AsyncTaskCache.CreateCacheableTask<Nullable<Image>>
	|
	|-RVA: 0xE7C910 Offset: 0xE7BD10 VA: 0x180E7C910
	|-AsyncTaskCache.CreateCacheableTask<bool>
	|
	|-RVA: 0xE7C990 Offset: 0xE7BD90 VA: 0x180E7C990
	|-AsyncTaskCache.CreateCacheableTask<int>
	|
	|-RVA: 0xE7CD40 Offset: 0xE7C140 VA: 0x180E7CD40
	|-AsyncTaskCache.CreateCacheableTask<Nullable<ServerInfo>>
	|
	|-RVA: 0xE7CB20 Offset: 0xE7BF20 VA: 0x180E7CB20
	|-AsyncTaskCache.CreateCacheableTask<Nullable<InventoryPurchaseResult>>
	|-AsyncTaskCache.CreateCacheableTask<Nullable<ResultPage>>
	|
	|-RVA: 0xE7CA90 Offset: 0xE7BE90 VA: 0x180E7CA90
	|-AsyncTaskCache.CreateCacheableTask<Nullable<InventoryResult>>
	|
	|-RVA: 0xE7CBB0 Offset: 0xE7BFB0 VA: 0x180E7CBB0
	|-AsyncTaskCache.CreateCacheableTask<Nullable<Item>>
	|
	|-RVA: 0xE7CA10 Offset: 0xE7BE10 VA: 0x180E7CA10
	|-AsyncTaskCache.CreateCacheableTask<Nullable<int>>
	|-AsyncTaskCache.CreateCacheableTask<Nullable<Int32Enum>>
	|
	|-RVA: 0xE7CE10 Offset: 0xE7C210 VA: 0x180E7CE10
	|-AsyncTaskCache.CreateCacheableTask<object>
	|
	|-RVA: 0xE7CE90 Offset: 0xE7C290 VA: 0x180E7CE90
	|-AsyncTaskCache.CreateCacheableTask<VoidTaskResult>
	*/

	// RVA: 0xFD7340 Offset: 0xFD6740 VA: 0x180FD7340
	private static void .cctor() { }

}

internal struct AsyncMethodBuilderCore // TypeDefIndex: 1277
{	// Fields
	internal IAsyncStateMachine m_stateMachine; // 0x0
	internal Action m_defaultContextAction; // 0x8

	// Methods

	// RVA: 0x14BAB0 Offset: 0x14AEB0 VA: 0x18014BAB0
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: 0x14B920 Offset: 0x14AD20 VA: 0x18014B920
	internal Action GetCompletionAction(Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize) { }

	// RVA: 0x14B930 Offset: 0x14AD30 VA: 0x18014B930
	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation) { }

	// RVA: 0x14B940 Offset: 0x14AD40 VA: 0x18014B940
	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask) { }

	// RVA: 0xFD6EB0 Offset: 0xFD62B0 VA: 0x180FD6EB0
	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext) { }

	// RVA: 0xFD6780 Offset: 0xFD5B80 VA: 0x180FD6780
	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0xFD7190 Offset: 0xFD6590 VA: 0x180FD7190
	internal static Task TryGetContinuationTask(Action action) { }

}

internal sealed class AsyncMethodBuilderCore.MoveNextRunner // TypeDefIndex: 1278
{	// Fields
	private readonly ExecutionContext m_context; // 0x10
	internal IAsyncStateMachine m_stateMachine; // 0x18
	private static ContextCallback s_invokeMoveNext; // 0x0

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(ExecutionContext context, IAsyncStateMachine stateMachine) { }

	// RVA: 0xFE5F40 Offset: 0xFE5340 VA: 0x180FE5F40
	internal void Run() { }

	// RVA: 0xFE5EA0 Offset: 0xFE52A0 VA: 0x180FE5EA0
	private static void InvokeMoveNext(object stateMachine) { }

}

private class AsyncMethodBuilderCore.ContinuationWrapper // TypeDefIndex: 1279
{	// Fields
	internal readonly Action m_continuation; // 0x10
	private readonly Action m_invokeAction; // 0x18
	internal readonly Task m_innerTask; // 0x20

	// Methods

	// RVA: 0xFDF8A0 Offset: 0xFDECA0 VA: 0x180FDF8A0
	internal void .ctor(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0xFDF880 Offset: 0xFDEC80 VA: 0x180FDF880
	internal void Invoke() { }

}

private sealed class AsyncMethodBuilderCore.<>c__DisplayClass4_0 // TypeDefIndex: 1280
{	// Fields
	public Task innerTask; // 0x10
	public Action continuation; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFF1A10 Offset: 0xFF0E10 VA: 0x180FF1A10
	internal void <OutputAsyncCausalityEvents>b__0() { }

}

private sealed class AsyncMethodBuilderCore.<>c // TypeDefIndex: 1281
{	// Fields
	public static readonly AsyncMethodBuilderCore.<>c <>9; // 0x0
	public static SendOrPostCallback <>9__6_0; // 0x8
	public static WaitCallback <>9__6_1; // 0x10

	// Methods

	// RVA: 0xFF1A70 Offset: 0xFF0E70 VA: 0x180FF1A70
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFF1950 Offset: 0xFF0D50 VA: 0x180FF1950
	internal void <ThrowAsync>b__6_0(object state) { }

	// RVA: 0xFF19B0 Offset: 0xFF0DB0 VA: 0x180FF19B0
	internal void <ThrowAsync>b__6_1(object state) { }

}

public sealed class AsyncStateMachineAttribute : StateMachineAttribute // TypeDefIndex: 1282
{	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(Type stateMachineType) { }

}

internal static class AsyncHelper // TypeDefIndex: 1812
{	// Fields
	public static readonly Task DoneTask; // 0x0
	public static readonly Task<bool> DoneTaskTrue; // 0x8
	public static readonly Task<bool> DoneTaskFalse; // 0x10
	public static readonly Task<int> DoneTaskZero; // 0x18

	// Methods

	// RVA: 0x12D7E20 Offset: 0x12D7220 VA: 0x1812D7E20
	private static void .cctor() { }

}

internal enum AsyncOperationStatus // TypeDefIndex: 2532
{	// Fields
	public int value__; // 0x0
	public const AsyncOperationStatus Initialize = 0;
	public const AsyncOperationStatus Continue = 1;
	public const AsyncOperationStatus ReadDone = 2;
	public const AsyncOperationStatus Complete = 3;

}

internal class AsyncProtocolResult // TypeDefIndex: 2533
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <UserResult>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly ExceptionDispatchInfo <Error>k__BackingField; // 0x18

	// Properties
	public int UserResult { get; }
	public ExceptionDispatchInfo Error { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_UserResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int result) { }

	// RVA: 0x10B06F0 Offset: 0x10AFAF0 VA: 0x1810B06F0
	public void .ctor(ExceptionDispatchInfo error) { }

}

internal abstract class AsyncProtocolRequest // TypeDefIndex: 2534
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_RunSynchronously() { }

	// RVA: 0x6E61B0 Offset: 0x6E55B0 VA: 0x1806E61B0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public int get_UserResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2E0 Offset: 0x95A6E0 VA: 0x18095B2E0
	protected void set_UserResult(int value) { }

	// RVA: 0x120A4C0 Offset: 0x12098C0 VA: 0x18120A4C0
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x120A260 Offset: 0x1209660 VA: 0x18120A260
	internal void RequestRead(int size) { }

	// RVA: 0x120A320 Offset: 0x1209720 VA: 0x18120A320
	internal void RequestWrite() { }

	[AsyncStateMachineAttribute] // RVA: 0xA2980 Offset: 0xA1D80 VA: 0x1800A2980
	// RVA: 0x120A330 Offset: 0x1209730 VA: 0x18120A330
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA2B40 Offset: 0xA1F40 VA: 0x1800A2B40
	// RVA: 0x120A140 Offset: 0x1209540 VA: 0x18120A140
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA2B90 Offset: 0xA1F90 VA: 0x1800A2B90
	// RVA: 0x120A020 Offset: 0x1209420 VA: 0x18120A020
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status);

	// RVA: 0x120A450 Offset: 0x1209850 VA: 0x18120A450 Slot: 3
	public override string ToString() { }

}

private struct AsyncProtocolRequest.<StartOperation>d__23 : IAsyncStateMachine // TypeDefIndex: 2535
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<AsyncProtocolResult> <>t__builder; // 0x8
	public AsyncProtocolRequest <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1D1D30 Offset: 0x1D1130 VA: 0x1801D1D30 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D1D40 Offset: 0x1D1140 VA: 0x1801D1D40 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct AsyncProtocolRequest.<ProcessOperation>d__24 : IAsyncStateMachine // TypeDefIndex: 2536
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public AsyncProtocolRequest <>4__this; // 0x28
	private AsyncOperationStatus <status>5__1; // 0x30
	private AsyncOperationStatus <newStatus>5__2; // 0x34
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x1D1D20 Offset: 0x1D1120 VA: 0x1801D1D20 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct AsyncProtocolRequest.<InnerRead>d__25 : IAsyncStateMachine // TypeDefIndex: 2537
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<int>> <>t__builder; // 0x8
	public AsyncProtocolRequest <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private int <requestedSize>5__1; // 0x30
	private Nullable<int> <totalRead>5__2; // 0x34
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x40

	// Methods

	// RVA: 0x1D1C40 Offset: 0x1D1040 VA: 0x1801D1C40 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D1C50 Offset: 0x1D1050 VA: 0x1801D1C50 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

internal class AsyncHandshakeRequest : AsyncProtocolRequest // TypeDefIndex: 2538
{	// Methods

	// RVA: 0x120A010 Offset: 0x1209410 VA: 0x18120A010
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x1209FF0 Offset: 0x12093F0 VA: 0x181209FF0 Slot: 4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest // TypeDefIndex: 2539
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <CurrentSize>k__BackingField; // 0x40

	// Properties
	protected BufferOffsetSize UserBuffer { get; }
	protected int CurrentSize { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	protected BufferOffsetSize get_UserBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	protected int get_CurrentSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6B9860 Offset: 0x6B8C60 VA: 0x1806B9860
	protected void set_CurrentSize(int value) { }

	// RVA: 0x120A5D0 Offset: 0x12099D0 VA: 0x18120A5D0
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x120A560 Offset: 0x1209960 VA: 0x18120A560 Slot: 3
	public override string ToString() { }

}

internal class AsyncReadRequest : AsyncReadOrWriteRequest // TypeDefIndex: 2540
{	// Methods

	// RVA: 0x120A6F0 Offset: 0x1209AF0 VA: 0x18120A6F0
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x120A670 Offset: 0x1209A70 VA: 0x18120A670 Slot: 4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

internal class AsyncWriteRequest : AsyncReadOrWriteRequest // TypeDefIndex: 2541
{	// Methods

	// RVA: 0x120A6F0 Offset: 0x1209AF0 VA: 0x18120A6F0
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x120A700 Offset: 0x1209B00 VA: 0x18120A700 Slot: 4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

internal class AsyncStreamReader // TypeDefIndex: 2647
{	// Fields
	private Stream stream; // 0x10
	private Encoding encoding; // 0x18
	private Decoder decoder; // 0x20
	private byte[] byteBuffer; // 0x28
	private char[] charBuffer; // 0x30
	private bool cancelOperation; // 0x38
	private ManualResetEvent eofEvent; // 0x40
	private object syncObject; // 0x48

	// Methods

	// RVA: 0x1009F60 Offset: 0x1009360 VA: 0x181009F60 Slot: 4
	public virtual void Close() { }

	// RVA: 0x17227B0 Offset: 0x1721BB0 VA: 0x1817227B0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17227A0 Offset: 0x1721BA0 VA: 0x1817227A0
	internal void CancelOperation() { }

}

public class AsyncCompletedEventArgs : EventArgs // TypeDefIndex: 2662
{	// Fields
	private readonly Exception error; // 0x10
	private readonly bool cancelled; // 0x18
	private readonly object userState; // 0x20

	// Properties
	[SRDescriptionAttribute] // RVA: 0xA9480 Offset: 0xA8880 VA: 0x1800A9480
	public bool Cancelled { get; }
	[SRDescriptionAttribute] // RVA: 0xA94F0 Offset: 0xA88F0 VA: 0x1800A94F0
	public Exception Error { get; }

	// Methods

	// RVA: 0x1596FD0 Offset: 0x15963D0 VA: 0x181596FD0
	public void .ctor(Exception error, bool cancelled, object userState) { }

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_Cancelled() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Exception get_Error() { }

	// RVA: 0x1596EF0 Offset: 0x15962F0 VA: 0x181596EF0
	protected void RaiseExceptionIfNecessary() { }

}

public sealed class AsyncCompletedEventHandler : MulticastDelegate // TypeDefIndex: 2663
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, AsyncCompletedEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, AsyncCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AsyncOperation // TypeDefIndex: 2664
{	// Fields
	private SynchronizationContext syncContext; // 0x10
	private object userSuppliedState; // 0x18
	private bool alreadyCompleted; // 0x20

	// Properties
	public object UserSuppliedState { get; }

	// Methods

	// RVA: 0x1597750 Offset: 0x1596B50 VA: 0x181597750
	private void .ctor(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x1597280 Offset: 0x1596680 VA: 0x181597280 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public object get_UserSuppliedState() { }

	// RVA: 0x1597530 Offset: 0x1596930 VA: 0x181597530
	public void Post(SendOrPostCallback d, object arg) { }

	// RVA: 0x1597410 Offset: 0x1596810 VA: 0x181597410
	public void PostOperationCompleted(SendOrPostCallback d, object arg) { }

	// RVA: 0x1597330 Offset: 0x1596730 VA: 0x181597330
	private void OperationCompletedCore() { }

	// RVA: 0x15976D0 Offset: 0x1596AD0 VA: 0x1815976D0
	private void VerifyNotCompleted() { }

	// RVA: 0x1597650 Offset: 0x1596A50 VA: 0x181597650
	private void VerifyDelegateNotNull(SendOrPostCallback d) { }

	// RVA: 0x15971E0 Offset: 0x15965E0 VA: 0x1815971E0
	internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext) { }

}

public static class AsyncOperationManager // TypeDefIndex: 2665
{	// Properties
	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public static SynchronizationContext SynchronizationContext { get; }

	// Methods

	// RVA: 0x1597070 Offset: 0x1596470 VA: 0x181597070
	public static AsyncOperation CreateOperation(object userSuppliedState) { }

	// RVA: 0x1597170 Offset: 0x1596570 VA: 0x181597170
	public static SynchronizationContext get_SynchronizationContext() { }

}

public class AsyncOperation : YieldInstruction // TypeDefIndex: 3491
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }
	public int priority { set; }

	// Methods

	[NativeMethodAttribute] // RVA: 0xB6770 Offset: 0xB5B70 VA: 0x1800B6770
	[StaticAccessorAttribute] // RVA: 0xB6770 Offset: 0xB5B70 VA: 0x1800B6770
	// RVA: 0x1819B10 Offset: 0x1818F10 VA: 0x181819B10
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethodAttribute] // RVA: 0x90A30 Offset: 0x8FE30 VA: 0x180090A30
	// RVA: 0x1819BB0 Offset: 0x1818FB0 VA: 0x181819BB0
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0xB6AC0 Offset: 0xB5EC0 VA: 0x1800B6AC0
	// RVA: 0x1819BF0 Offset: 0x1818FF0 VA: 0x181819BF0
	public void set_priority(int value) { }

	// RVA: 0x1819A60 Offset: 0x1818E60 VA: 0x181819A60 Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1819B50 Offset: 0x1818F50 VA: 0x181819B50
	internal void InvokeCompletionEvent() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public struct AsyncGPUReadbackRequest // TypeDefIndex: 3802
{	// Fields
	internal IntPtr m_Ptr; // 0x0
	internal int m_Version; // 0x8

	// Properties
	public bool done { get; }
	public bool hasError { get; }
	public int layerCount { get; }
	public int layerDataSize { get; }

	// Methods

	// RVA: -1 Offset: -1
	public NativeArray<T> GetData<T>(int layer = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AFA0 Offset: 0x22A3A0 VA: 0x18022AFA0
	|-AsyncGPUReadbackRequest.GetData<Color32>
	*/

	// RVA: 0x221660 Offset: 0x220A60 VA: 0x180221660
	public bool get_done() { }

	// RVA: 0x221620 Offset: 0x220A20 VA: 0x180221620
	public bool get_hasError() { }

	// RVA: 0x2215A0 Offset: 0x2209A0 VA: 0x1802215A0
	public int get_layerCount() { }

	// RVA: 0x2215E0 Offset: 0x2209E0 VA: 0x1802215E0
	public int get_layerDataSize() { }

	// RVA: 0x221660 Offset: 0x220A60 VA: 0x180221660
	private bool IsDone() { }

	// RVA: 0x221620 Offset: 0x220A20 VA: 0x180221620
	private bool HasError() { }

	// RVA: 0x2215A0 Offset: 0x2209A0 VA: 0x1802215A0
	private int GetLayerCount() { }

	// RVA: 0x2215E0 Offset: 0x2209E0 VA: 0x1802215E0
	private int GetLayerDataSize() { }

	// RVA: 0x2216A0 Offset: 0x220AA0 VA: 0x1802216A0
	internal void SetScriptingCallback(Action<AsyncGPUReadbackRequest> callback) { }

	// RVA: 0x221550 Offset: 0x220950 VA: 0x180221550
	private IntPtr GetDataRaw(int layer) { }

	// RVA: 0x199FB30 Offset: 0x199EF30 VA: 0x18199FB30
	private static bool IsDone_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	// RVA: 0x199FAF0 Offset: 0x199EEF0 VA: 0x18199FAF0
	private static bool HasError_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	// RVA: 0x199FA70 Offset: 0x199EE70 VA: 0x18199FA70
	private static int GetLayerCount_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	// RVA: 0x199FAB0 Offset: 0x199EEB0 VA: 0x18199FAB0
	private static int GetLayerDataSize_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	// RVA: 0x199FB70 Offset: 0x199EF70 VA: 0x18199FB70
	private static void SetScriptingCallback_Injected(ref AsyncGPUReadbackRequest _unity_self, Action<AsyncGPUReadbackRequest> callback) { }

	// RVA: 0x199FA30 Offset: 0x199EE30 VA: 0x18199FA30
	private static IntPtr GetDataRaw_Injected(ref AsyncGPUReadbackRequest _unity_self, int layer) { }

}

public static class AsyncGPUReadback // TypeDefIndex: 3803
{	// Methods

	// RVA: 0x199FE60 Offset: 0x199F260 VA: 0x18199FE60
	private static void SetUpScriptingRequest(AsyncGPUReadbackRequest request, Action<AsyncGPUReadbackRequest> callback) { }

	// RVA: 0x199FDC0 Offset: 0x199F1C0 VA: 0x18199FDC0
	public static AsyncGPUReadbackRequest Request(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	// RVA: 0x199FD10 Offset: 0x199F110 VA: 0x18199FD10
	public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex = 0, Action<AsyncGPUReadbackRequest> callback) { }

	[NativeMethodAttribute] // RVA: 0x6FD90 Offset: 0x6F190 VA: 0x18006FD90
	// RVA: 0x199FC10 Offset: 0x199F010 VA: 0x18199FC10
	private static AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_1(ComputeBuffer buffer) { }

	[NativeMethodAttribute] // RVA: 0x6FD90 Offset: 0x6F190 VA: 0x18006FD90
	// RVA: 0x199FCB0 Offset: 0x199F0B0 VA: 0x18199FCB0
	private static AsyncGPUReadbackRequest Request_Internal_Texture_1(Texture src, int mipIndex) { }

	// RVA: 0x199FBC0 Offset: 0x199EFC0 VA: 0x18199FBC0
	private static void Request_Internal_ComputeBuffer_1_Injected(ComputeBuffer buffer, out AsyncGPUReadbackRequest ret) { }

	// RVA: 0x199FC60 Offset: 0x199F060 VA: 0x18199FC60
	private static void Request_Internal_Texture_1_Injected(Texture src, int mipIndex, out AsyncGPUReadbackRequest ret) { }

}

public class AsyncTextureLoad : CustomYieldInstruction // TypeDefIndex: 6627
{	// Fields
	private IntPtr buffer; // 0x10
	private int size; // 0x18
	private int width; // 0x1C
	private int height; // 0x20
	private int format; // 0x24
	public string filename; // 0x28
	public bool normal; // 0x30
	public bool dither; // 0x31
	public bool hqmode; // 0x32
	public bool cache; // 0x33
	private Action worker; // 0x38

	// Properties
	public override bool keepWaiting { get; }
	public bool isDone { get; }
	public bool isValid { get; }
	public Texture2D texture { get; }

	// Methods

	// RVA: 0x6EAA20 Offset: 0x6E9E20 VA: 0x1806EAA20 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x1313D00 Offset: 0x1313100 VA: 0x181313D00
	public bool get_isDone() { }

	// RVA: 0x1B98F40 Offset: 0x1B98340 VA: 0x181B98F40
	public bool get_isValid() { }

	// RVA: 0x1B99030 Offset: 0x1B98430 VA: 0x181B99030
	public Texture2D get_texture() { }

	// RVA: 0x1B989E0 Offset: 0x1B97DE0 VA: 0x181B989E0
	public void LoadIntoTexture(Texture2D tex) { }

	// RVA: 0x1B98D40 Offset: 0x1B98140 VA: 0x181B98D40
	public void WriteToCache(string cachename) { }

	// RVA: 0x1B988A0 Offset: 0x1B97CA0 VA: 0x181B988A0
	private static extern void FreeTexture(ref IntPtr buffer) { }

	// RVA: 0x1B98B70 Offset: 0x1B97F70 VA: 0x181B98B70
	private static extern void LoadTextureFromFile(string filename, ref IntPtr buffer, ref int size, ref int width, ref int height, ref int channels, bool normal, bool dither, bool hqmode) { }

	// RVA: 0x1B98A90 Offset: 0x1B97E90 VA: 0x181B98A90
	private static extern void LoadTextureFromCache(string filename, ref IntPtr buffer, ref int size, ref int width, ref int height, ref int format) { }

	// RVA: 0x1B98C70 Offset: 0x1B98070 VA: 0x181B98C70
	private static extern void SaveTextureToCache(string filename, IntPtr buffer, int size, int width, int height, int format) { }

	// RVA: 0x1B98E20 Offset: 0x1B98220 VA: 0x181B98E20
	public void .ctor(string filename, bool normal, bool dither, bool hqmode, bool cache) { }

	// RVA: 0x1B986D0 Offset: 0x1B97AD0 VA: 0x181B986D0
	private void DoWork() { }

	// RVA: 0x1B98920 Offset: 0x1B97D20 VA: 0x181B98920
	private void Invoke() { }

	// RVA: 0x1B98690 Offset: 0x1B97A90 VA: 0x181B98690
	private void Callback(IAsyncResult result) { }

}

public sealed class AsyncMethodBuilderAttribute : Attribute // TypeDefIndex: 7091
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly Type <BuilderType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(Type builderType) { }

}

public struct AsyncValueTaskMethodBuilder // TypeDefIndex: 7092
{	// Fields
	private AsyncTaskMethodBuilder _methodBuilder; // 0x0
	private bool _haveResult; // 0x18
	private bool _useBuilder; // 0x19

	// Properties
	public ValueTask Task { get; }

	// Methods

	// RVA: 0x4CC380 Offset: 0x4CB780 VA: 0x1804CC380
	public static AsyncValueTaskMethodBuilder Create() { }

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13B540 Offset: 0x13A940 VA: 0x18013B540
	|-AsyncValueTaskMethodBuilder.Start<RestRgbService.<Start>d__31>
	|
	|-RVA: 0x13B560 Offset: 0x13A960 VA: 0x18013B560
	|-AsyncValueTaskMethodBuilder.Start<RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x13B580 Offset: 0x13A980 VA: 0x18013B580
	|-AsyncValueTaskMethodBuilder.Start<RestRgbService.<Update>d__33>
	|
	|-RVA: 0x13B530 Offset: 0x13A930 VA: 0x18013B530
	|-AsyncValueTaskMethodBuilder.Start<RgbController.<StartServices>d__15>
	|
	|-RVA: 0x13B550 Offset: 0x13A950 VA: 0x18013B550
	|-AsyncValueTaskMethodBuilder.Start<RgbController.<StopServices>d__16>
	|
	|-RVA: 0x13B570 Offset: 0x13A970 VA: 0x18013B570
	|-AsyncValueTaskMethodBuilder.Start<RgbController.<UpdateServices>d__17>
	|
	|-RVA: 0x13B520 Offset: 0x13A920 VA: 0x18013B520
	|-AsyncValueTaskMethodBuilder.Start<SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-RVA: 0x13B510 Offset: 0x13A910 VA: 0x18013B510
	|-AsyncValueTaskMethodBuilder.Start<object>
	*/

	// RVA: 0x240460 Offset: 0x23F860 VA: 0x180240460
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: 0x240440 Offset: 0x23F840 VA: 0x180240440
	public void SetResult() { }

	// RVA: 0x240430 Offset: 0x23F830 VA: 0x180240430
	public void SetException(Exception exception) { }

	// RVA: 0x240470 Offset: 0x23F870 VA: 0x180240470
	public ValueTask get_Task() { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13B3D0 Offset: 0x13A7D0 VA: 0x18013B3D0
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x13B410 Offset: 0x13A810 VA: 0x18013B410
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Start>d__31>
	|
	|-RVA: 0x13B430 Offset: 0x13A830 VA: 0x18013B430
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x13B3F0 Offset: 0x13A7F0 VA: 0x18013B3F0
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<Shutdown>d__11>
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-RVA: 0x13B4B0 Offset: 0x13A8B0 VA: 0x18013B4B0
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x13B4F0 Offset: 0x13A8F0 VA: 0x18013B4F0
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Update>d__33>
	|
	|-RVA: 0x13B470 Offset: 0x13A870 VA: 0x18013B470
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StartServices>d__15>
	|
	|-RVA: 0x13B490 Offset: 0x13A890 VA: 0x18013B490
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StopServices>d__16>
	|
	|-RVA: 0x13B4D0 Offset: 0x13A8D0 VA: 0x18013B4D0
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<UpdateServices>d__17>
	|
	|-RVA: 0x13B450 Offset: 0x13A850 VA: 0x18013B450
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, RestRgbService.<Start>d__31>
	*/

}

public struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 7093
{	// Fields
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; // 0x0
	private TResult _result; // 0x0
	private bool _haveResult; // 0x0
	private bool _useBuilder; // 0x0

	// Properties
	public ValueTask<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4CC380 Offset: 0x4CB780 VA: 0x1804CC380
	|-AsyncValueTaskMethodBuilder<bool>.Create
	|
	|-RVA: 0x135DA20 Offset: 0x135CE20 VA: 0x18135DA20
	|-AsyncValueTaskMethodBuilder<object>.Create
	*/

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13B3C0 Offset: 0x13A7C0 VA: 0x18013B3C0
	|-AsyncValueTaskMethodBuilder<bool>.Start<SteelSeriesGameSenseService.<Initialize>d__10>
	|
	|-RVA: 0x13B3B0 Offset: 0x13A7B0 VA: 0x18013B3B0
	|-AsyncValueTaskMethodBuilder<object>.Start<object>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2A70 Offset: 0x1E1E70 VA: 0x1801E2A70
	|-AsyncValueTaskMethodBuilder<bool>.SetStateMachine
	|
	|-RVA: 0x1E2A30 Offset: 0x1E1E30 VA: 0x1801E2A30
	|-AsyncValueTaskMethodBuilder<object>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2940 Offset: 0x1E1D40 VA: 0x1801E2940
	|-AsyncValueTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x1E29B0 Offset: 0x1E1DB0 VA: 0x1801E29B0
	|-AsyncValueTaskMethodBuilder<object>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28F0 Offset: 0x1E1CF0 VA: 0x1801E28F0
	|-AsyncValueTaskMethodBuilder<bool>.SetException
	|
	|-RVA: 0x1E28A0 Offset: 0x1E1CA0 VA: 0x1801E28A0
	|-AsyncValueTaskMethodBuilder<object>.SetException
	*/

	// RVA: -1 Offset: -1
	public ValueTask<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2BC0 Offset: 0x1E1FC0 VA: 0x1801E2BC0
	|-AsyncValueTaskMethodBuilder<bool>.get_Task
	|
	|-RVA: 0x1E2AC0 Offset: 0x1E1EC0 VA: 0x1801E2AC0
	|-AsyncValueTaskMethodBuilder<object>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13B390 Offset: 0x13A790 VA: 0x18013B390
	|-AsyncValueTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<Initialize>d__10>
	|-AsyncValueTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Initialize>d__10>
	|
	|-RVA: 0x13B370 Offset: 0x13A770 VA: 0x18013B370
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	*/

}

public class AsyncTerrainNavMeshBake : CustomYieldInstruction // TypeDefIndex: 10313
{	// Fields
	private List<int> indices; // 0x10
	private List<Vector3> vertices; // 0x18
	private List<Vector3> normals; // 0x20
	private List<int> triangles; // 0x28
	private Vector3 pivot; // 0x30
	private int width; // 0x3C
	private int height; // 0x40
	private bool normal; // 0x44
	private bool alpha; // 0x45
	private Action worker; // 0x48

	// Properties
	public override bool keepWaiting { get; }
	public bool isDone { get; }
	public Mesh mesh { get; }

	// Methods

	// RVA: 0x82F590 Offset: 0x82E990 VA: 0x18082F590 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x82F580 Offset: 0x82E980 VA: 0x18082F580
	public bool get_isDone() { }

	// RVA: 0x82E900 Offset: 0x82DD00 VA: 0x18082E900
	public NavMeshBuildSource CreateNavMeshBuildSource() { }

	// RVA: 0x82EC10 Offset: 0x82E010 VA: 0x18082EC10
	public NavMeshBuildSource CreateNavMeshBuildSource(int area) { }

	// RVA: 0x82F5A0 Offset: 0x82E9A0 VA: 0x18082F5A0
	public Mesh get_mesh() { }

	// RVA: 0x82F3A0 Offset: 0x82E7A0 VA: 0x18082F3A0
	public void .ctor(Vector3 pivot, int width, int height, bool normal, bool alpha) { }

	// RVA: 0x82ECB0 Offset: 0x82E0B0 VA: 0x18082ECB0
	private void DoWork() { }

	// RVA: 0x82F2E0 Offset: 0x82E6E0 VA: 0x18082F2E0
	private void Invoke() { }

	// RVA: 0x82E8C0 Offset: 0x82DCC0 VA: 0x18082E8C0
	private void Callback(IAsyncResult result) { }

}

