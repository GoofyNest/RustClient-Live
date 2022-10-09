public sealed class AsyncCallback : MulticastDelegate // TypeDefIndex: 173
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(IAsyncResult ar) { }

	public virtual IAsyncResult BeginInvoke(IAsyncResult ar, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AsyncLocal<T> : IAsyncLocal // TypeDefIndex: 774
{
	private readonly Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler; 

	public T Value { get; set; }


	public void .ctor(Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler) { }
	/* GenericInstMethod :
	|
	|-AsyncLocal<ActivityTracker.ActivityInfo>..ctor
	|-AsyncLocal<CultureInfo>..ctor
	|-AsyncLocal<object>..ctor
	*/

	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-AsyncLocal<ActivityTracker.ActivityInfo>.get_Value
	|-AsyncLocal<object>.get_Value
	*/

	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-AsyncLocal<ActivityTracker.ActivityInfo>.set_Value
	|-AsyncLocal<CultureInfo>.set_Value
	|-AsyncLocal<object>.set_Value
	*/

	private void System.Threading.IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged) { }
	/* GenericInstMethod :
	|
	|-AsyncLocal<object>.System.Threading.IAsyncLocal.OnValueChanged
	*/

}

public struct AsyncLocalValueChangedArgs<T> // TypeDefIndex: 776
{
	[CompilerGeneratedAttribute] 
	private T <PreviousValue>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private T <CurrentValue>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <ThreadContextChanged>k__BackingField; 

	public T PreviousValue { get; set; }
	public T CurrentValue { get; set; }
	private bool ThreadContextChanged { set; }


	[CompilerGeneratedAttribute] 
	public T get_PreviousValue() { }
	/* GenericInstMethod :
	|
	|-AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo>.get_PreviousValue
	|-AsyncLocalValueChangedArgs<object>.get_PreviousValue
	*/

	[CompilerGeneratedAttribute] 
	private void set_PreviousValue(T value) { }
	/* GenericInstMethod :
	|
	|-AsyncLocalValueChangedArgs<object>.set_PreviousValue
	*/

	[CompilerGeneratedAttribute] 
	public T get_CurrentValue() { }
	/* GenericInstMethod :
	|
	|-AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo>.get_CurrentValue
	|-AsyncLocalValueChangedArgs<CultureInfo>.get_CurrentValue
	|-AsyncLocalValueChangedArgs<object>.get_CurrentValue
	*/

	[CompilerGeneratedAttribute] 
	private void set_CurrentValue(T value) { }
	/* GenericInstMethod :
	|
	|-AsyncLocalValueChangedArgs<object>.set_CurrentValue
	*/

	[CompilerGeneratedAttribute] 
	private void set_ThreadContextChanged(bool value) { }
	/* GenericInstMethod :
	|
	|-AsyncLocalValueChangedArgs<object>.set_ThreadContextChanged
	*/

	internal void .ctor(T previousValue, T currentValue, bool contextChanged) { }
	/* GenericInstMethod :
	|
	|-AsyncLocalValueChangedArgs<object>..ctor
	*/

}

internal enum AsyncCausalityStatus // TypeDefIndex: 838
{
	public int value__; 
	public const AsyncCausalityStatus Started = 0;
	public const AsyncCausalityStatus Completed = 1;
	public const AsyncCausalityStatus Canceled = 2;
	public const AsyncCausalityStatus Error = 3;

}

internal static class AsyncCausalityTracer // TypeDefIndex: 841
{
	[FriendAccessAllowedAttribute] 
	internal static bool LoggingOn { get; }


	[FriendAccessAllowedAttribute] 
	internal static bool get_LoggingOn() { }

	[FriendAccessAllowedAttribute] 
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	[FriendAccessAllowedAttribute] 
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	internal static void TraceOperationRelation(CausalityTraceLevel traceLevel, int taskId, CausalityRelation relation) { }

	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

}

internal class AsyncRequest // TypeDefIndex: 1193
{
	internal IMessageSink ReplySink; 
	internal IMessage MsgRequest; 


	public void .ctor(IMessage msgRequest, IMessageSink replySink) { }

}

public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 1223
{
	private object async_state; 
	private WaitHandle handle; 
	private object async_delegate; 
	private IntPtr data; 
	private object object_data; 
	private bool sync_completed; 
	private bool completed; 
	private bool endinvoke_called; 
	private object async_callback; 
	private ExecutionContext current; 
	private ExecutionContext original; 
	private long add_time; 
	private MonoMethodMessage call_message; 
	private IMessageCtrl message_ctrl; 
	private IMessage reply_message; 
	private WaitCallback orig_cb; 
	internal static ContextCallback ccb; 

	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }


	internal void .ctor() { }

	internal void .ctor(WaitCallback cb, object state, bool capture_context) { }

	private static void WaitCallback_Context(object state) { }

	public virtual object get_AsyncState() { }

	public virtual WaitHandle get_AsyncWaitHandle() { }

	public virtual bool get_CompletedSynchronously() { }

	public virtual bool get_IsCompleted() { }

	public bool get_EndInvokeCalled() { }

	public void set_EndInvokeCalled(bool value) { }

	public virtual object get_AsyncDelegate() { }

	public IMessageSink get_NextSink() { }

	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public virtual IMessage GetReplyMessage() { }

	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	internal void SetCompletedSynchronously(bool completed) { }

	internal IMessage EndInvoke() { }

	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	internal MonoMethodMessage get_CallMessage() { }

	internal void set_CallMessage(MonoMethodMessage value) { }

	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	internal object Invoke() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] 
	private void <.ctor>b__17_0(object <p0>) { }

}

public struct AsyncVoidMethodBuilder // TypeDefIndex: 1273
{
	private SynchronizationContext m_synchronizationContext; 
	private AsyncMethodBuilderCore m_coreState; 
	private Task m_task; 

	private Task Task { get; }


	public static AsyncVoidMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] 
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-AsyncVoidMethodBuilder.Start<CompanionSetupScreen.<Disable>d__26>
	|
	|-AsyncVoidMethodBuilder.Start<CompanionSetupScreen.<Enable>d__25>
	|
	|-AsyncVoidMethodBuilder.Start<CompanionSetupScreen.<RefreshImpl>d__24>
	|
	|-AsyncVoidMethodBuilder.Start<ConnectionScreen.<LoadServerInfo>d__13>
	|
	|-AsyncVoidMethodBuilder.Start<ConnectionScreen.<LoadServerRules>d__14>
	|
	|-AsyncVoidMethodBuilder.Start<ItemStore.<Checkout>d__24>
	|
	|-AsyncVoidMethodBuilder.Start<ItemStore.<RefreshList>d__17>
	|
	|-AsyncVoidMethodBuilder.Start<LoadingScreen.<<ChooseBackgroundImage>g__PreloadBackgroundImage|62_0>d>
	|
	|-AsyncVoidMethodBuilder.Start<SteamPlatform.<LoadAvatarFromSteamAsync>d__1>
	|
	|-AsyncVoidMethodBuilder.Start<RestRgbService.<EventImpl>d__40>
	|
	|-AsyncVoidMethodBuilder.Start<RestRgbService.<PulseColorImpl>d__38>
	|
	|-AsyncVoidMethodBuilder.Start<RestRgbService.<SendHeartbeatAndWait>d__34>
	|
	|-AsyncVoidMethodBuilder.Start<RestRgbService.<StaticColorImpl>d__36>
	|
	|-AsyncVoidMethodBuilder.Start<RgbController.<Worker>d__14>
	|
	|-AsyncVoidMethodBuilder.Start<ReportBug.<SendReport>d__29>
	|
	|-AsyncVoidMethodBuilder.Start<ReportPlayer.<SendReport>d__21>
	|
	|-AsyncVoidMethodBuilder.Start<ServerBrowserInfo.<QueryRules>d__19>
	|
	|-AsyncVoidMethodBuilder.Start<ShoutcastStreamer.<ReadData>d__46>
	|
	|-AsyncVoidMethodBuilder.Start<SteamUserButton.<UpdateFromUser>d__14>
	|
	|-AsyncVoidMethodBuilder.Start<Dispatch.<LoopClientAsync>d__22>
	|
	|-AsyncVoidMethodBuilder.Start<object>
	*/

	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CompanionSetupScreen.<Disable>d__26>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CompanionSetupScreen.<Enable>d__25>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<EventImpl>d__40>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<PulseColorImpl>d__38>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<SendHeartbeatAndWait>d__34>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<StaticColorImpl>d__36>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Dispatch.<LoopClientAsync>d__22>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<CompanionSubscription.Status>, CompanionSetupScreen.<RefreshImpl>d__24>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSetupScreen.<RefreshImpl>d__24>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IPlayerInfo>, SteamUserButton.<UpdateFromUser>d__14>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamUserButton.<UpdateFromUser>d__14>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, RestRgbService.<SendHeartbeatAndWait>d__34>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ShoutcastStreamer.<ReadData>d__46>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ConnectionScreen.<LoadServerRules>d__14>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ConnectionScreen.<LoadServerRules>d__14>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ServerBrowserInfo.<QueryRules>d__19>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ServerBrowserInfo.<QueryRules>d__19>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IPlayerItemDefinition>>, ItemStore.<RefreshList>d__17>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ItemStore.<RefreshList>d__17>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<ServerInfo>>, ConnectionScreen.<LoadServerInfo>d__13>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<Image>>, SteamPlatform.<LoadAvatarFromSteamAsync>d__1>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryPurchaseResult>>, ItemStore.<Checkout>d__24>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, LoadingScreen.<<ChooseBackgroundImage>g__PreloadBackgroundImage|62_0>d>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, LoadingScreen.<<ChooseBackgroundImage>g__PreloadBackgroundImage|62_0>d>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ReportBug.<SendReport>d__29>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, ReportBug.<SendReport>d__29>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ReportPlayer.<SendReport>d__21>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, ReportPlayer.<SendReport>d__21>
	|
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<Worker>d__14>
	*/

	public void SetResult() { }

	public void SetException(Exception exception) { }

	private void NotifySynchronizationContextOfCompletion() { }

	private Task get_Task() { }

}

public struct AsyncTaskMethodBuilder // TypeDefIndex: 1274
{
	private static readonly Task<VoidTaskResult> s_cachedCompleted; 
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; 

	public Task Task { get; }


	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] 
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<Report>d__11>
	|
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunAsync>d__7>
	|
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunBenchmarkScene>d__9>
	|
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunBenchmarksInScene>d__10>
	|
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunDemoBasedBenchmark>d__12>
	|
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunSingleSceneAsync>d__8>
	|
	|-AsyncTaskMethodBuilder.Start<Client.<Connect>d__37>
	|
	|-AsyncTaskMethodBuilder.Start<CompanionSubscription.<Add>d__6>
	|
	|-AsyncTaskMethodBuilder.Start<CompanionSubscription.<Remove>d__7>
	|
	|-AsyncTaskMethodBuilder.Start<EAC.<OnJoinServer>d__16>
	|
	|-AsyncTaskMethodBuilder.Start<Account.<ReadAllNotices>d__7>
	|
	|-AsyncTaskMethodBuilder.Start<Account.<Refresh>d__6>
	|
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-AsyncTaskMethodBuilder.Start<SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-AsyncTaskMethodBuilder.Start<RestRgbService.<Start>d__31>
	|
	|-AsyncTaskMethodBuilder.Start<RestRgbService.<Stop>d__32>
	|
	|-AsyncTaskMethodBuilder.Start<RestRgbService.<Update>d__33>
	|
	|-AsyncTaskMethodBuilder.Start<RgbController.<StartServices>d__15>
	|
	|-AsyncTaskMethodBuilder.Start<RgbController.<StopServices>d__16>
	|
	|-AsyncTaskMethodBuilder.Start<RgbController.<UpdateServices>d__17>
	|
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<SendEvent>d__15>
	|
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<SendHeartbeat>d__12>
	|
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<SendPulseColor>d__14>
	|
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<SendStaticColor>d__13>
	|
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-AsyncTaskMethodBuilder.Start<Hero.<ShowAsync>d__10>
	|
	|-AsyncTaskMethodBuilder.Start<SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-AsyncTaskMethodBuilder.Start<SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-AsyncTaskMethodBuilder.Start<SteamInventoryManager.<FixStacks>d__9>
	|
	|-AsyncTaskMethodBuilder.Start<SteamInventoryManager.<Refresh>d__8>
	|
	|-AsyncTaskMethodBuilder.Start<SteamInventoryNewItem.<Open>d__0>
	|
	|-AsyncTaskMethodBuilder.Start<Publisher.<DoExport>d__15>
	|
	|-AsyncTaskMethodBuilder.Start<Publisher.<DoExport>d__21>
	|
	|-AsyncTaskMethodBuilder.Start<Publisher.<ExportTexture>d__19>
	|
	|-AsyncTaskMethodBuilder.Start<Publisher.<ExportToFolder>d__16>
	|
	|-AsyncTaskMethodBuilder.Start<Publisher.<PublishToSteam>d__18>
	|
	|-AsyncTaskMethodBuilder.Start<WorkshopItemList.<Refresh>d__26>
	|
	|-AsyncTaskMethodBuilder.Start<ServerHistory.<Refresh>d__4>
	|
	|-AsyncTaskMethodBuilder.Start<ShoutcastStream.<ConnectAsync>d__42>
	|
	|-AsyncTaskMethodBuilder.Start<ShoutcastStream.<ShutdownSafely>d__54>
	|
	|-AsyncTaskMethodBuilder.Start<Friend.<RequestInfoAsync>d__13>
	|
	|-AsyncTaskMethodBuilder.Start<SourceServerQuery.<Send>d__8>
	|
	|-AsyncTaskMethodBuilder.Start<SteamFriends.<CacheUserInformationAsync>d__51>
	|
	|-AsyncTaskMethodBuilder.Start<Stream.<CopyToAsyncInternal>d__27>
	|
	|-AsyncTaskMethodBuilder.Start<HttpContent.<LoadIntoBufferAsync>d__17>
	|
	|-AsyncTaskMethodBuilder.Start<object>
	|
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__37>
	*/

	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<object, object>
	|
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<CopyToAsyncInternal>d__27>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<LoadIntoBufferAsync>d__17>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<CopyToAsyncInternal>d__27>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunAsync>d__7>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunBenchmarkScene>d__9>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunBenchmarksInScene>d__10>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunDemoBasedBenchmark>d__12>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunSingleSceneAsync>d__8>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Client.<Connect>d__37>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, EAC.<OnJoinServer>d__16>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Account.<ReadAllNotices>d__7>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Start>d__31>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryManager.<FixStacks>d__9>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryManager.<Refresh>d__8>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryNewItem.<Open>d__0>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<DoExport>d__15>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<DoExport>d__21>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<ExportTexture>d__19>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<ExportToFolder>d__16>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, ServerHistory.<Refresh>d__4>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, ShoutcastStream.<ShutdownSafely>d__54>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Friend.<RequestInfoAsync>d__13>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamFriends.<CacheUserInformationAsync>d__51>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, CompanionSubscription.<Add>d__6>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, CompanionSubscription.<Add>d__6>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<Add>d__6>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, CompanionSubscription.<Remove>d__7>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, CompanionSubscription.<Remove>d__7>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<Remove>d__7>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, Account.<ReadAllNotices>d__7>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Account.<ReadAllNotices>d__7>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Account.<ReadAllNotices>d__7>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, Account.<Refresh>d__6>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Account.<Refresh>d__6>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Account.<Refresh>d__6>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IPlayerInventory>, SteamInventoryCrafting.<ExchangeItems>d__33>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IPlayerInventory[]>, SteamInventoryCrafting.<ExchangeItems>d__33>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IPlayerInventory>, SteamInventoryManager.<Refresh>d__8>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryManager.<Refresh>d__8>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<MP3Stream>, ShoutcastStream.<ConnectAsync>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, ShoutcastStream.<ConnectAsync>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, ShoutcastStream.<ConnectAsync>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ShoutcastStream.<ConnectAsync>d__42>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<PublishResult>, Publisher.<PublishToSteam>d__18>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, EAC.<OnJoinServer>d__16>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EAC.<OnJoinServer>d__16>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, SourceServerQuery.<Send>d__8>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<SendEvent>d__15>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendEvent>d__15>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<SendHeartbeat>d__12>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendHeartbeat>d__12>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<SendPulseColor>d__14>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendPulseColor>d__14>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<SendStaticColor>d__13>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendStaticColor>d__13>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventoryManager.<FixStacks>d__9>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<Item>>, Publisher.<PublishToSteam>d__18>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<ResultPage>>, WorkshopItemList.<Refresh>d__26>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Benchmarking.<Report>d__11>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Benchmarking.<Report>d__11>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Hero.<ShowAsync>d__10>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Hero.<ShowAsync>d__10>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Publisher.<DoExport>d__21>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Publisher.<DoExport>d__21>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Update>d__33>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StartServices>d__15>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StopServices>d__16>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<UpdateServices>d__17>
	|
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, RestRgbService.<Start>d__31>
	*/

	public Task get_Task() { }

	public void SetResult() { }

	public void SetException(Exception exception) { }

	private static void .cctor() { }

}

public struct AsyncTaskMethodBuilder<TResult> // TypeDefIndex: 1275
{
	internal static readonly Task<TResult> s_defaultResultTask; 
	private AsyncMethodBuilderCore m_coreState; 
	private Task<TResult> m_task; 

	public Task<TResult> Task { get; }


	public static AsyncTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
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

	[DebuggerStepThroughAttribute] 
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.Start<CompanionSubscription.<CheckStatus>d__5>
	|-AsyncTaskMethodBuilder<object>.Start<CompanionSubscription.<CheckStatus>d__5>
	|
	|-AsyncTaskMethodBuilder<IAuthTicket>.Start<SteamPlatform.<GetAuthSessionTicketAsync>d__53>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<GetAuthSessionTicketAsync>d__53>
	|
	|-AsyncTaskMethodBuilder<IPlayerInfo>.Start<SteamPlatform.<GetPlayerInformationAsync>d__57>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<GetPlayerInformationAsync>d__57>
	|
	|-AsyncTaskMethodBuilder<IPlayerInventory>.Start<SteamPlatform.<CraftItem>d__20>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<CraftItem>d__20>
	|
	|-AsyncTaskMethodBuilder<IPlayerInventory>.Start<SteamPlatform.<RefreshAndGetItems>d__19>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<RefreshAndGetItems>d__19>
	|
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|-AsyncTaskMethodBuilder<object>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.Start<SteamInventoryCrafting.<GetMarketPrice>d__29>
	|-AsyncTaskMethodBuilder<object>.Start<SteamInventoryCrafting.<GetMarketPrice>d__29>
	|
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.Start<SteamInventoryCrafting.<GetMarketPriceImpl>d__30>
	|-AsyncTaskMethodBuilder<object>.Start<SteamInventoryCrafting.<GetMarketPriceImpl>d__30>
	|
	|-AsyncTaskMethodBuilder<AuthTicket>.Start<SteamUser.<GetAuthSessionTicketAsync>d__54>
	|-AsyncTaskMethodBuilder<object>.Start<SteamUser.<GetAuthSessionTicketAsync>d__54>
	|
	|-AsyncTaskMethodBuilder<InventoryDef[]>.Start<SteamInventory.<GetDefinitionsWithPricesAsync>d__19>
	|-AsyncTaskMethodBuilder<object>.Start<SteamInventory.<GetDefinitionsWithPricesAsync>d__19>
	|
	|-AsyncTaskMethodBuilder<PublishResult>.Start<Editor.<SubmitAsync>d__40>
	|
	|-AsyncTaskMethodBuilder<bool>.Start<SteelSeriesGameSenseService.<Initialize>d__10>
	|
	|-AsyncTaskMethodBuilder<bool>.Start<ShoutcastStream.<ReadDataAsync>d__43>
	|
	|-AsyncTaskMethodBuilder<bool>.Start<ShoutcastStream.<ReadDataAsync>d__44>
	|
	|-AsyncTaskMethodBuilder<bool>.Start<Base.<RunQueryAsync>d__15>
	|
	|-AsyncTaskMethodBuilder<bool>.Start<IpList.<RunQueryAsync>d__4>
	|
	|-AsyncTaskMethodBuilder<bool>.Start<SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-AsyncTaskMethodBuilder<byte[]>.Start<SourceServerQuery.<GetChallengeData>d__7>
	|-AsyncTaskMethodBuilder<object>.Start<SourceServerQuery.<GetChallengeData>d__7>
	|
	|-AsyncTaskMethodBuilder<byte[]>.Start<SourceServerQuery.<Receive>d__6>
	|-AsyncTaskMethodBuilder<object>.Start<SourceServerQuery.<Receive>d__6>
	|
	|-AsyncTaskMethodBuilder<byte[]>.Start<SteamUser.<RequestEncryptedAppTicketAsync>d__71>
	|-AsyncTaskMethodBuilder<object>.Start<SteamUser.<RequestEncryptedAppTicketAsync>d__71>
	|
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<ServerInfoExtensions.<QueryRulesAsync>d__0>
	|-AsyncTaskMethodBuilder<object>.Start<ServerInfoExtensions.<QueryRulesAsync>d__0>
	|
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<ServerInfoHelpers.<LoadRules>d__1>
	|-AsyncTaskMethodBuilder<object>.Start<ServerInfoHelpers.<LoadRules>d__1>
	|
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<ServerInfo.<QueryRulesAsync>d__85>
	|-AsyncTaskMethodBuilder<object>.Start<ServerInfo.<QueryRulesAsync>d__85>
	|
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<SourceServerQuery.<GetRules>d__5>
	|-AsyncTaskMethodBuilder<object>.Start<SourceServerQuery.<GetRules>d__5>
	|
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<SourceServerQuery.<GetRulesImpl>d__4>
	|-AsyncTaskMethodBuilder<object>.Start<SourceServerQuery.<GetRulesImpl>d__4>
	|
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.Start<SteamPlatform.<GetItemDefinitionsWithPrices>d__21>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<GetItemDefinitionsWithPrices>d__21>
	|
	|-AsyncTaskMethodBuilder<Stream>.Start<HttpContent.<CreateContentReadStreamAsync>d__12>
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<CreateContentReadStreamAsync>d__12>
	|
	|-AsyncTaskMethodBuilder<Stream>.Start<HttpContent.<ReadAsStreamAsync>d__18>
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<ReadAsStreamAsync>d__18>
	|
	|-AsyncTaskMethodBuilder<Stream>.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|-AsyncTaskMethodBuilder<object>.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<StartOperation>d__58>
	|
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.Start<HttpClient.<SendAsyncWorker>d__47>
	|-AsyncTaskMethodBuilder<object>.Start<HttpClient.<SendAsyncWorker>d__47>
	|
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.Start<HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<object>.Start<HttpClientHandler.<SendAsync>d__64>
	|
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.Start<ServerInfoHelpers.<Load>d__0>
	|
	|-AsyncTaskMethodBuilder<Nullable<Image>>.Start<SteamFriends.<GetMediumAvatarAsync>d__53>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.Start<SteamInventory.<StartPurchaseAsync>d__39>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<InventoryItem.<AddAsync>d__23>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<InventoryItem.<ConsumeAsync>d__21>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<InventoryItem.<SplitStackAsync>d__22>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<InventoryResult.<GetAsync>d__11>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<CraftItemAsync>d__33>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<CraftItemAsync>d__34>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<GetAllItemsAsync>d__31>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<GrantPromoItemsAsync>d__36>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<TriggerItemDropAsync>d__37>
	|
	|-AsyncTaskMethodBuilder<Nullable<Result>>.Start<Item.<Vote>d__83>
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.Start<Item.<Vote>d__83>
	|
	|-AsyncTaskMethodBuilder<Nullable<Item>>.Start<SteamUGC.<QueryFileAsync>d__19>
	|
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.Start<Query.<GetPageAsync>d__76>
	|
	|-AsyncTaskMethodBuilder<Nullable<int>>.Start<AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-AsyncTaskMethodBuilder<object>.Start<BenchmarkData.<Upload>d__13>
	|-AsyncTaskMethodBuilder<string>.Start<BenchmarkData.<Upload>d__13>
	|
	|-AsyncTaskMethodBuilder<object>.Start<Feedback.<Report>d__0>
	|-AsyncTaskMethodBuilder<string>.Start<Feedback.<Report>d__0>
	|
	|-AsyncTaskMethodBuilder<object>.Start<WebUtil.<DownloadFileTemp>d__3>
	|-AsyncTaskMethodBuilder<string>.Start<WebUtil.<DownloadFileTemp>d__3>
	|
	|-AsyncTaskMethodBuilder<object>.Start<WebUtil.<PostAsync>d__6>
	|-AsyncTaskMethodBuilder<string>.Start<WebUtil.<PostAsync>d__6>
	|
	|-AsyncTaskMethodBuilder<object>.Start<WebUtil.<PostDataAsync>d__8>
	|-AsyncTaskMethodBuilder<string>.Start<WebUtil.<PostDataAsync>d__8>
	|
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>>
	|
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>>
	|
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<GameMetadata>>
	|
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<LoadGoLispHandlers>>
	|
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<RegisterGameEvent>>
	|
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<RegisterTimelineEvents>>
	|
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<RemoveGame>>
	|
	|-AsyncTaskMethodBuilder<object>.Start<FileDialog.<SaveAsync>d__24>
	|-AsyncTaskMethodBuilder<string>.Start<FileDialog.<SaveAsync>d__24>
	|
	|-AsyncTaskMethodBuilder<object>.Start<HttpClient.<GetStringAsync>d__52>
	|-AsyncTaskMethodBuilder<string>.Start<HttpClient.<GetStringAsync>d__52>
	|
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<ReadAsStringAsync>d__20>
	|-AsyncTaskMethodBuilder<string>.Start<HttpContent.<ReadAsStringAsync>d__20>
	|
	|-AsyncTaskMethodBuilder<object>.Start<object>
	|
	|-AsyncTaskMethodBuilder<object>.Start<XmlUrlResolver.<GetEntityAsync>d__15>
	*/

	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
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

	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-AsyncTaskMethodBuilder<InventoryDef[]>.AwaitOnCompleted<CallResult<SteamInventoryRequestPricesResult_t>, SteamInventory.<GetDefinitionsWithPricesAsync>d__19>
	|-AsyncTaskMethodBuilder<object>.AwaitOnCompleted<CallResult<SteamInventoryRequestPricesResult_t>, SteamInventory.<GetDefinitionsWithPricesAsync>d__19>
	|
	|-AsyncTaskMethodBuilder<PublishResult>.AwaitOnCompleted<CallResult<CreateItemResult_t>, Editor.<SubmitAsync>d__40>
	|
	|-AsyncTaskMethodBuilder<byte[]>.AwaitOnCompleted<CallResult<EncryptedAppTicketResponse_t>, SteamUser.<RequestEncryptedAppTicketAsync>d__71>
	|-AsyncTaskMethodBuilder<object>.AwaitOnCompleted<CallResult<EncryptedAppTicketResponse_t>, SteamUser.<RequestEncryptedAppTicketAsync>d__71>
	|
	|-AsyncTaskMethodBuilder<int>.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.AwaitOnCompleted<CallResult<SteamInventoryStartPurchaseResult_t>, SteamInventory.<StartPurchaseAsync>d__39>
	|
	|-AsyncTaskMethodBuilder<Nullable<Result>>.AwaitOnCompleted<CallResult<SetUserItemVoteResult_t>, Item.<Vote>d__83>
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.AwaitOnCompleted<CallResult<SetUserItemVoteResult_t>, Item.<Vote>d__83>
	|
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.AwaitOnCompleted<CallResult<SteamUGCQueryCompleted_t>, Query.<GetPageAsync>d__76>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitOnCompleted<object, object>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<object, object>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, CompanionSubscription.<CheckStatus>d__5>
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, CompanionSubscription.<CheckStatus>d__5>
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.AwaitUnsafeOnCompleted<TaskAwaiter<string>, CompanionSubscription.<CheckStatus>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<CheckStatus>d__5>
	|
	|-AsyncTaskMethodBuilder<IAuthTicket>.AwaitUnsafeOnCompleted<TaskAwaiter<AuthTicket>, SteamPlatform.<GetAuthSessionTicketAsync>d__53>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamPlatform.<GetAuthSessionTicketAsync>d__53>
	|
	|-AsyncTaskMethodBuilder<IPlayerInfo>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamPlatform.<GetPlayerInformationAsync>d__57>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamPlatform.<GetPlayerInformationAsync>d__57>
	|
	|-AsyncTaskMethodBuilder<IPlayerInventory>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<CraftItem>d__20>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<CraftItem>d__20>
	|
	|-AsyncTaskMethodBuilder<IPlayerInventory>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<RefreshAndGetItems>d__19>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<RefreshAndGetItems>d__19>
	|
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.AwaitUnsafeOnCompleted<TaskAwaiter<SteamInventoryCrafting.MarketPrice>, SteamInventoryCrafting.<GetMarketPrice>d__29>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryCrafting.<GetMarketPrice>d__29>
	|
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.AwaitUnsafeOnCompleted<TaskAwaiter<string>, SteamInventoryCrafting.<GetMarketPriceImpl>d__30>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryCrafting.<GetMarketPriceImpl>d__30>
	|
	|-AsyncTaskMethodBuilder<AuthTicket>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamUser.<GetAuthSessionTicketAsync>d__54>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamUser.<GetAuthSessionTicketAsync>d__54>
	|
	|-AsyncTaskMethodBuilder<PublishResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Editor.<SubmitAsync>d__40>
	|
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter, Base.<RunQueryAsync>d__15>
	|
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ShoutcastStream.<ReadDataAsync>d__43>
	|
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, IpList.<RunQueryAsync>d__4>
	|
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ShoutcastStream.<ReadDataAsync>d__44>
	|
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Initialize>d__10>
	|
	|-AsyncTaskMethodBuilder<byte[]>.AwaitUnsafeOnCompleted<TaskAwaiter, SourceServerQuery.<GetChallengeData>d__7>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, SourceServerQuery.<GetChallengeData>d__7>
	|
	|-AsyncTaskMethodBuilder<byte[]>.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, SourceServerQuery.<GetChallengeData>d__7>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SourceServerQuery.<GetChallengeData>d__7>
	|
	|-AsyncTaskMethodBuilder<byte[]>.AwaitUnsafeOnCompleted<TaskAwaiter<UdpReceiveResult>, SourceServerQuery.<Receive>d__6>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<UdpReceiveResult>, SourceServerQuery.<Receive>d__6>
	|
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter, ServerInfoHelpers.<LoadRules>d__1>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, ServerInfoHelpers.<LoadRules>d__1>
	|
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter, SourceServerQuery.<GetRules>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, SourceServerQuery.<GetRules>d__5>
	|
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, SourceServerQuery.<GetRules>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SourceServerQuery.<GetRules>d__5>
	|
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ServerInfoExtensions.<QueryRulesAsync>d__0>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ServerInfoExtensions.<QueryRulesAsync>d__0>
	|
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ServerInfoHelpers.<LoadRules>d__1>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ServerInfoHelpers.<LoadRules>d__1>
	|
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ServerInfo.<QueryRulesAsync>d__85>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ServerInfo.<QueryRulesAsync>d__85>
	|
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, SourceServerQuery.<GetRulesImpl>d__4>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SourceServerQuery.<GetRulesImpl>d__4>
	|
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.AwaitUnsafeOnCompleted<TaskAwaiter<InventoryDef[]>, SteamPlatform.<GetItemDefinitionsWithPrices>d__21>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamPlatform.<GetItemDefinitionsWithPrices>d__21>
	|
	|-AsyncTaskMethodBuilder<Stream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<CreateContentReadStreamAsync>d__12>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<CreateContentReadStreamAsync>d__12>
	|
	|-AsyncTaskMethodBuilder<Stream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>, HttpContent.<ReadAsStreamAsync>d__18>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpContent.<ReadAsStreamAsync>d__18>
	|
	|-AsyncTaskMethodBuilder<Stream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse>, XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<StartOperation>d__58>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<StartOperation>d__58>
	|
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClient.<SendAsyncWorker>d__47>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClient.<SendAsyncWorker>d__47>
	|
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClientHandler.<SendAsync>d__64>
	|
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>, HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse>, HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpClientHandler.<SendAsync>d__64>
	|
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage>, HttpClient.<SendAsyncWorker>d__47>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpClient.<SendAsyncWorker>d__47>
	|
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, HttpClientHandler.<SendAsync>d__64>
	|
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.AwaitUnsafeOnCompleted<TaskAwaiter, ServerInfoHelpers.<Load>d__0>
	|
	|-AsyncTaskMethodBuilder<Nullable<Image>>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamFriends.<GetMediumAvatarAsync>d__53>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter, InventoryResult.<GetAsync>d__11>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, InventoryItem.<AddAsync>d__23>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, InventoryItem.<ConsumeAsync>d__21>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, InventoryItem.<SplitStackAsync>d__22>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<CraftItemAsync>d__33>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<CraftItemAsync>d__34>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<GetAllItemsAsync>d__31>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<GrantPromoItemsAsync>d__36>
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<TriggerItemDropAsync>d__37>
	|
	|-AsyncTaskMethodBuilder<Nullable<Item>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<ResultPage>>, SteamUGC.<QueryFileAsync>d__19>
	|
	|-AsyncTaskMethodBuilder<Nullable<int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<ReadAsStringAsync>d__20>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<ReadAsStringAsync>d__20>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>, XmlUrlResolver.<GetEntityAsync>d__15>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpClient.<GetStringAsync>d__52>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage>, HttpClient.<GetStringAsync>d__52>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string>, HttpClient.<GetStringAsync>d__52>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<DownloadFileTemp>d__3>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<DownloadFileTemp>d__3>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<PostAsync>d__6>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<PostAsync>d__6>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<PostDataAsync>d__8>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<PostDataAsync>d__8>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, FileDialog.<SaveAsync>d__24>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter, FileDialog.<SaveAsync>d__24>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, BenchmarkData.<Upload>d__13>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter<string>, BenchmarkData.<Upload>d__13>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Feedback.<Report>d__0>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, Feedback.<Report>d__0>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Feedback.<Report>d__0>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<GameMetadata>>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<LoadGoLispHandlers>>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<RegisterGameEvent>>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<RegisterTimelineEvents>>
	|
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<RemoveGame>>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<object, object>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<CopyToAsyncInternal>d__27>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<LoadIntoBufferAsync>d__17>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<CopyToAsyncInternal>d__27>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunAsync>d__7>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunBenchmarkScene>d__9>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunBenchmarksInScene>d__10>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunDemoBasedBenchmark>d__12>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunSingleSceneAsync>d__8>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Client.<Connect>d__37>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, EAC.<OnJoinServer>d__16>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Account.<ReadAllNotices>d__7>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Start>d__31>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryManager.<FixStacks>d__9>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryManager.<Refresh>d__8>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryNewItem.<Open>d__0>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<DoExport>d__15>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<DoExport>d__21>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<ExportTexture>d__19>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<ExportToFolder>d__16>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, ServerHistory.<Refresh>d__4>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, ShoutcastStream.<ShutdownSafely>d__54>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Friend.<RequestInfoAsync>d__13>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamFriends.<CacheUserInformationAsync>d__51>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<PublishResult>, Publisher.<PublishToSteam>d__18>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<int>, SourceServerQuery.<Send>d__8>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventoryManager.<FixStacks>d__9>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<Item>>, Publisher.<PublishToSteam>d__18>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<ResultPage>>, WorkshopItemList.<Refresh>d__26>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Benchmarking.<Report>d__11>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<Add>d__6>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<Remove>d__7>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EAC.<OnJoinServer>d__16>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Account.<ReadAllNotices>d__7>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Account.<Refresh>d__6>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendEvent>d__15>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendHeartbeat>d__12>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendPulseColor>d__14>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendStaticColor>d__13>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Hero.<ShowAsync>d__10>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryManager.<Refresh>d__8>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Publisher.<DoExport>d__21>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ShoutcastStream.<ConnectAsync>d__42>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Update>d__33>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StartServices>d__15>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StopServices>d__16>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<UpdateServices>d__17>
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, RestRgbService.<Start>d__31>
	*/

	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
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

	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
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
	|-AsyncTaskMethodBuilder<PublishResult>.SetResult
	|
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<Image>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<Result>>.SetResult
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<Item>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	*/

	internal void SetResult(Task<TResult> completedTask) { }
	/* GenericInstMethod :
	|
	|-AsyncTaskMethodBuilder<PublishResult>.SetResult
	|
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<Image>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<Item>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.SetResult
	|
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	*/

	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
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
	|-AsyncTaskMethodBuilder<PublishResult>.SetException
	|
	|-AsyncTaskMethodBuilder<bool>.SetException
	|
	|-AsyncTaskMethodBuilder<int>.SetException
	|
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.SetException
	|
	|-AsyncTaskMethodBuilder<Nullable<Image>>.SetException
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.SetException
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.SetException
	|
	|-AsyncTaskMethodBuilder<Nullable<Result>>.SetException
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.SetException
	|
	|-AsyncTaskMethodBuilder<Nullable<Item>>.SetException
	|
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.SetException
	|
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetException
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetException
	*/

	private Task<TResult> GetTaskForResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-AsyncTaskMethodBuilder<PublishResult>.GetTaskForResult
	|
	|-AsyncTaskMethodBuilder<bool>.GetTaskForResult
	|
	|-AsyncTaskMethodBuilder<int>.GetTaskForResult
	|
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.GetTaskForResult
	|
	|-AsyncTaskMethodBuilder<Nullable<Image>>.GetTaskForResult
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.GetTaskForResult
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.GetTaskForResult
	|
	|-AsyncTaskMethodBuilder<Nullable<Item>>.GetTaskForResult
	|
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.GetTaskForResult
	|
	|-AsyncTaskMethodBuilder<Nullable<int>>.GetTaskForResult
	|
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.GetTaskForResult
	|
	|-AsyncTaskMethodBuilder<object>.GetTaskForResult
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>.GetTaskForResult
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-AsyncTaskMethodBuilder<PublishResult>..cctor
	|
	|-AsyncTaskMethodBuilder<bool>..cctor
	|
	|-AsyncTaskMethodBuilder<int>..cctor
	|
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>..cctor
	|
	|-AsyncTaskMethodBuilder<Nullable<Image>>..cctor
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>..cctor
	|
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>..cctor
	|
	|-AsyncTaskMethodBuilder<Nullable<Item>>..cctor
	|
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>..cctor
	|
	|-AsyncTaskMethodBuilder<Nullable<int>>..cctor
	|
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>..cctor
	|
	|-AsyncTaskMethodBuilder<object>..cctor
	|
	|-AsyncTaskMethodBuilder<VoidTaskResult>..cctor
	*/

}

internal static class AsyncTaskCache // TypeDefIndex: 1276
{
	internal static readonly Task<bool> TrueTask; 
	internal static readonly Task<bool> FalseTask; 
	internal static readonly Task<int>[] Int32Tasks; 


	private static Task<int>[] CreateInt32Tasks() { }

	internal static Task<TResult> CreateCacheableTask<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-AsyncTaskCache.CreateCacheableTask<PublishResult>
	|-AsyncTaskCache.CreateCacheableTask<Nullable<Image>>
	|
	|-AsyncTaskCache.CreateCacheableTask<bool>
	|
	|-AsyncTaskCache.CreateCacheableTask<int>
	|
	|-AsyncTaskCache.CreateCacheableTask<Nullable<ServerInfo>>
	|
	|-AsyncTaskCache.CreateCacheableTask<Nullable<InventoryPurchaseResult>>
	|-AsyncTaskCache.CreateCacheableTask<Nullable<ResultPage>>
	|
	|-AsyncTaskCache.CreateCacheableTask<Nullable<InventoryResult>>
	|
	|-AsyncTaskCache.CreateCacheableTask<Nullable<Item>>
	|
	|-AsyncTaskCache.CreateCacheableTask<Nullable<int>>
	|-AsyncTaskCache.CreateCacheableTask<Nullable<Int32Enum>>
	|
	|-AsyncTaskCache.CreateCacheableTask<object>
	|
	|-AsyncTaskCache.CreateCacheableTask<VoidTaskResult>
	*/

	private static void .cctor() { }

}

internal struct AsyncMethodBuilderCore // TypeDefIndex: 1277
{
	internal IAsyncStateMachine m_stateMachine; 
	internal Action m_defaultContextAction; 


	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	internal Action GetCompletionAction(Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize) { }

	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation) { }

	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask) { }

	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext) { }

	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask) { }

	internal static Task TryGetContinuationTask(Action action) { }

}

internal sealed class AsyncMethodBuilderCore.MoveNextRunner // TypeDefIndex: 1278
{
	private readonly ExecutionContext m_context; 
	internal IAsyncStateMachine m_stateMachine; 
	private static ContextCallback s_invokeMoveNext; 


	internal void .ctor(ExecutionContext context, IAsyncStateMachine stateMachine) { }

	internal void Run() { }

	private static void InvokeMoveNext(object stateMachine) { }

}

private class AsyncMethodBuilderCore.ContinuationWrapper // TypeDefIndex: 1279
{
	internal readonly Action m_continuation; 
	private readonly Action m_invokeAction; 
	internal readonly Task m_innerTask; 


	internal void .ctor(Action continuation, Action invokeAction, Task innerTask) { }

	internal void Invoke() { }

}

private sealed class AsyncMethodBuilderCore.<>c__DisplayClass4_0 // TypeDefIndex: 1280
{
	public Task innerTask; 
	public Action continuation; 


	public void .ctor() { }

	internal void <OutputAsyncCausalityEvents>b__0() { }

}

private sealed class AsyncMethodBuilderCore.<>c // TypeDefIndex: 1281
{
	public static readonly AsyncMethodBuilderCore.<>c <>9; 
	public static SendOrPostCallback <>9__6_0; 
	public static WaitCallback <>9__6_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <ThrowAsync>b__6_0(object state) { }

	internal void <ThrowAsync>b__6_1(object state) { }

}

public sealed class AsyncStateMachineAttribute : StateMachineAttribute // TypeDefIndex: 1282
{

	public void .ctor(Type stateMachineType) { }

}

internal static class AsyncHelper // TypeDefIndex: 1812
{
	public static readonly Task DoneTask; 
	public static readonly Task<bool> DoneTaskTrue; 
	public static readonly Task<bool> DoneTaskFalse; 
	public static readonly Task<int> DoneTaskZero; 


	private static void .cctor() { }

}

internal enum AsyncOperationStatus // TypeDefIndex: 2532
{
	public int value__; 
	public const AsyncOperationStatus Initialize = 0;
	public const AsyncOperationStatus Continue = 1;
	public const AsyncOperationStatus ReadDone = 2;
	public const AsyncOperationStatus Complete = 3;

}

internal class AsyncProtocolResult // TypeDefIndex: 2533
{
	[CompilerGeneratedAttribute] 
	private readonly int <UserResult>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly ExceptionDispatchInfo <Error>k__BackingField; 

	public int UserResult { get; }
	public ExceptionDispatchInfo Error { get; }


	[CompilerGeneratedAttribute] 
	public int get_UserResult() { }

	[CompilerGeneratedAttribute] 
	public ExceptionDispatchInfo get_Error() { }

	public void .ctor(int result) { }

	public void .ctor(ExceptionDispatchInfo error) { }

}

internal abstract class AsyncProtocolRequest // TypeDefIndex: 2534
{
	[CompilerGeneratedAttribute] 
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly bool <RunSynchronously>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <UserResult>k__BackingField; 
	private int Started; 
	private int RequestedSize; 
	private int WriteRequested; 
	private readonly object locker; 

	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }


	[CompilerGeneratedAttribute] 
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGeneratedAttribute] 
	public bool get_RunSynchronously() { }

	public string get_Name() { }

	[CompilerGeneratedAttribute] 
	public int get_UserResult() { }

	[CompilerGeneratedAttribute] 
	protected void set_UserResult(int value) { }

	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	internal void RequestRead(int size) { }

	internal void RequestWrite() { }

	[AsyncStateMachineAttribute] 
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] 
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] 
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status);

	public override string ToString() { }

}

private struct AsyncProtocolRequest.<StartOperation>d__23 : IAsyncStateMachine // TypeDefIndex: 2535
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<AsyncProtocolResult> <>t__builder; 
	public AsyncProtocolRequest <>4__this; 
	public CancellationToken cancellationToken; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct AsyncProtocolRequest.<ProcessOperation>d__24 : IAsyncStateMachine // TypeDefIndex: 2536
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public CancellationToken cancellationToken; 
	public AsyncProtocolRequest <>4__this; 
	private AsyncOperationStatus <status>5__1; 
	private AsyncOperationStatus <newStatus>5__2; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>> <>u__1; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct AsyncProtocolRequest.<InnerRead>d__25 : IAsyncStateMachine // TypeDefIndex: 2537
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<Nullable<int>> <>t__builder; 
	public AsyncProtocolRequest <>4__this; 
	public CancellationToken cancellationToken; 
	private int <requestedSize>5__1; 
	private Nullable<int> <totalRead>5__2; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

internal class AsyncHandshakeRequest : AsyncProtocolRequest // TypeDefIndex: 2538
{

	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest // TypeDefIndex: 2539
{
	[CompilerGeneratedAttribute] 
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <CurrentSize>k__BackingField; 

	protected BufferOffsetSize UserBuffer { get; }
	protected int CurrentSize { get; set; }


	[CompilerGeneratedAttribute] 
	protected BufferOffsetSize get_UserBuffer() { }

	[CompilerGeneratedAttribute] 
	protected int get_CurrentSize() { }

	[CompilerGeneratedAttribute] 
	protected void set_CurrentSize(int value) { }

	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	public override string ToString() { }

}

internal class AsyncReadRequest : AsyncReadOrWriteRequest // TypeDefIndex: 2540
{

	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

internal class AsyncWriteRequest : AsyncReadOrWriteRequest // TypeDefIndex: 2541
{

	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

internal class AsyncStreamReader // TypeDefIndex: 2647
{
	private Stream stream; 
	private Encoding encoding; 
	private Decoder decoder; 
	private byte[] byteBuffer; 
	private char[] charBuffer; 
	private bool cancelOperation; 
	private ManualResetEvent eofEvent; 
	private object syncObject; 


	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	internal void CancelOperation() { }

}

public class AsyncCompletedEventArgs : EventArgs // TypeDefIndex: 2662
{
	private readonly Exception error; 
	private readonly bool cancelled; 
	private readonly object userState; 

	[SRDescriptionAttribute] 
	public bool Cancelled { get; }
	[SRDescriptionAttribute] 
	public Exception Error { get; }


	public void .ctor(Exception error, bool cancelled, object userState) { }

	public bool get_Cancelled() { }

	public Exception get_Error() { }

	protected void RaiseExceptionIfNecessary() { }

}

public sealed class AsyncCompletedEventHandler : MulticastDelegate // TypeDefIndex: 2663
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, AsyncCompletedEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, AsyncCompletedEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AsyncOperation // TypeDefIndex: 2664
{
	private SynchronizationContext syncContext; 
	private object userSuppliedState; 
	private bool alreadyCompleted; 

	public object UserSuppliedState { get; }


	private void .ctor(object userSuppliedState, SynchronizationContext syncContext) { }

	protected override void Finalize() { }

	public object get_UserSuppliedState() { }

	public void Post(SendOrPostCallback d, object arg) { }

	public void PostOperationCompleted(SendOrPostCallback d, object arg) { }

	private void OperationCompletedCore() { }

	private void VerifyNotCompleted() { }

	private void VerifyDelegateNotNull(SendOrPostCallback d) { }

	internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext) { }

}

public static class AsyncOperationManager // TypeDefIndex: 2665
{
	[EditorBrowsableAttribute] 
	public static SynchronizationContext SynchronizationContext { get; }


	public static AsyncOperation CreateOperation(object userSuppliedState) { }

	public static SynchronizationContext get_SynchronizationContext() { }

}

public class AsyncOperation : YieldInstruction // TypeDefIndex: 3493
{
	internal IntPtr m_Ptr; 
	private Action<AsyncOperation> m_completeCallback; 

	public bool isDone { get; }
	public int priority { set; }


	[StaticAccessorAttribute] 
	[NativeMethodAttribute] 
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethodAttribute] 
	public bool get_isDone() { }

	[NativeMethodAttribute] 
	public void set_priority(int value) { }

	protected override void Finalize() { }

	[RequiredByNativeCodeAttribute] 
	internal void InvokeCompletionEvent() { }

	public void .ctor() { }

}

public struct AsyncGPUReadbackRequest // TypeDefIndex: 3804
{
	internal IntPtr m_Ptr; 
	internal int m_Version; 

	public bool done { get; }
	public bool hasError { get; }
	public int layerCount { get; }
	public int layerDataSize { get; }


	public NativeArray<T> GetData<T>(int layer = 0) { }
	/* GenericInstMethod :
	|
	|-AsyncGPUReadbackRequest.GetData<Color32>
	*/

	public bool get_done() { }

	public bool get_hasError() { }

	public int get_layerCount() { }

	public int get_layerDataSize() { }

	private bool IsDone() { }

	private bool HasError() { }

	private int GetLayerCount() { }

	private int GetLayerDataSize() { }

	internal void SetScriptingCallback(Action<AsyncGPUReadbackRequest> callback) { }

	private IntPtr GetDataRaw(int layer) { }

	private static bool IsDone_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	private static bool HasError_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	private static int GetLayerCount_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	private static int GetLayerDataSize_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	private static void SetScriptingCallback_Injected(ref AsyncGPUReadbackRequest _unity_self, Action<AsyncGPUReadbackRequest> callback) { }

	private static IntPtr GetDataRaw_Injected(ref AsyncGPUReadbackRequest _unity_self, int layer) { }

}

public static class AsyncGPUReadback // TypeDefIndex: 3805
{

	private static void SetUpScriptingRequest(AsyncGPUReadbackRequest request, Action<AsyncGPUReadbackRequest> callback) { }

	public static AsyncGPUReadbackRequest Request(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex = 0, Action<AsyncGPUReadbackRequest> callback) { }

	[NativeMethodAttribute] 
	private static AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_1(ComputeBuffer buffer) { }

	[NativeMethodAttribute] 
	private static AsyncGPUReadbackRequest Request_Internal_Texture_1(Texture src, int mipIndex) { }

	private static void Request_Internal_ComputeBuffer_1_Injected(ComputeBuffer buffer, out AsyncGPUReadbackRequest ret) { }

	private static void Request_Internal_Texture_1_Injected(Texture src, int mipIndex, out AsyncGPUReadbackRequest ret) { }

}

public class AsyncTextureLoad : CustomYieldInstruction // TypeDefIndex: 6632
{
	private IntPtr buffer; 
	private int size; 
	private int width; 
	private int height; 
	private int format; 
	public string filename; 
	public bool normal; 
	public bool dither; 
	public bool hqmode; 
	public bool cache; 
	private Action worker; 

	public override bool keepWaiting { get; }
	public bool isDone { get; }
	public bool isValid { get; }
	public Texture2D texture { get; }


	public override bool get_keepWaiting() { }

	public bool get_isDone() { }

	public bool get_isValid() { }

	public Texture2D get_texture() { }

	public void LoadIntoTexture(Texture2D tex) { }

	public void WriteToCache(string cachename) { }

	private static extern void FreeTexture(ref IntPtr buffer) { }

	private static extern void LoadTextureFromFile(string filename, ref IntPtr buffer, ref int size, ref int width, ref int height, ref int channels, bool normal, bool dither, bool hqmode) { }

	private static extern void LoadTextureFromCache(string filename, ref IntPtr buffer, ref int size, ref int width, ref int height, ref int format) { }

	private static extern void SaveTextureToCache(string filename, IntPtr buffer, int size, int width, int height, int format) { }

	public void .ctor(string filename, bool normal, bool dither, bool hqmode, bool cache) { }

	private void DoWork() { }

	private void Invoke() { }

	private void Callback(IAsyncResult result) { }

}

public sealed class AsyncMethodBuilderAttribute : Attribute // TypeDefIndex: 7126
{
	[CompilerGeneratedAttribute] 
	private readonly Type <BuilderType>k__BackingField; 


	public void .ctor(Type builderType) { }

}

public struct AsyncValueTaskMethodBuilder // TypeDefIndex: 7127
{
	private AsyncTaskMethodBuilder _methodBuilder; 
	private bool _haveResult; 
	private bool _useBuilder; 

	public ValueTask Task { get; }


	public static AsyncValueTaskMethodBuilder Create() { }

	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-AsyncValueTaskMethodBuilder.Start<RestRgbService.<Start>d__31>
	|
	|-AsyncValueTaskMethodBuilder.Start<RestRgbService.<Stop>d__32>
	|
	|-AsyncValueTaskMethodBuilder.Start<RestRgbService.<Update>d__33>
	|
	|-AsyncValueTaskMethodBuilder.Start<RgbController.<StartServices>d__15>
	|
	|-AsyncValueTaskMethodBuilder.Start<RgbController.<StopServices>d__16>
	|
	|-AsyncValueTaskMethodBuilder.Start<RgbController.<UpdateServices>d__17>
	|
	|-AsyncValueTaskMethodBuilder.Start<SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-AsyncValueTaskMethodBuilder.Start<object>
	*/

	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	public void SetResult() { }

	public void SetException(Exception exception) { }

	public ValueTask get_Task() { }

	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Start>d__31>
	|
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<Shutdown>d__11>
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Update>d__33>
	|
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StartServices>d__15>
	|
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StopServices>d__16>
	|
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<UpdateServices>d__17>
	|
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, RestRgbService.<Start>d__31>
	*/

}

public struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 7128
{
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; 
	private TResult _result; 
	private bool _haveResult; 
	private bool _useBuilder; 

	public ValueTask<TResult> Task { get; }


	public static AsyncValueTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-AsyncValueTaskMethodBuilder<bool>.Create
	|
	|-AsyncValueTaskMethodBuilder<object>.Create
	*/

	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-AsyncValueTaskMethodBuilder<bool>.Start<SteelSeriesGameSenseService.<Initialize>d__10>
	|
	|-AsyncValueTaskMethodBuilder<object>.Start<object>
	*/

	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-AsyncValueTaskMethodBuilder<bool>.SetStateMachine
	|
	|-AsyncValueTaskMethodBuilder<object>.SetStateMachine
	*/

	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-AsyncValueTaskMethodBuilder<bool>.SetResult
	|
	|-AsyncValueTaskMethodBuilder<object>.SetResult
	*/

	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-AsyncValueTaskMethodBuilder<bool>.SetException
	|
	|-AsyncValueTaskMethodBuilder<object>.SetException
	*/

	public ValueTask<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-AsyncValueTaskMethodBuilder<bool>.get_Task
	|
	|-AsyncValueTaskMethodBuilder<object>.get_Task
	*/

	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-AsyncValueTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<Initialize>d__10>
	|-AsyncValueTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Initialize>d__10>
	|
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	*/

}

public class AsyncTerrainNavMeshBake : CustomYieldInstruction // TypeDefIndex: 12032
{
	private List<int> indices; 
	private List<Vector3> vertices; 
	private List<Vector3> normals; 
	private List<int> triangles; 
	private Vector3 pivot; 
	private int width; 
	private int height; 
	private bool normal; 
	private bool alpha; 
	private Action worker; 

	public override bool keepWaiting { get; }
	public bool isDone { get; }
	public Mesh mesh { get; }


	public override bool get_keepWaiting() { }

	public bool get_isDone() { }

	public NavMeshBuildSource CreateNavMeshBuildSource() { }

	public NavMeshBuildSource CreateNavMeshBuildSource(int area) { }

	public Mesh get_mesh() { }

	public void .ctor(Vector3 pivot, int width, int height, bool normal, bool alpha) { }

	private void DoWork() { }

	private void Invoke() { }

	private void Callback(IAsyncResult result) { }

}

