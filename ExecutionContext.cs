public sealed class ExecutionContext : IDisposable, ISerializable // TypeDefIndex: 782
{
	private SynchronizationContext _syncContext; 
	private SynchronizationContext _syncContextNoFlow; 
	private LogicalCallContext _logicalCallContext; 
	private IllogicalCallContext _illogicalCallContext; 
	private ExecutionContext.Flags _flags; 
	private Dictionary<IAsyncLocal, object> _localValues; 
	private List<IAsyncLocal> _localChangeNotifications; 
	private static readonly ExecutionContext s_dummyDefaultEC; 

	internal bool isNewCapture { get; set; }
	internal bool isFlowSuppressed { get; set; }
	internal static ExecutionContext PreAllocatedDefault { get; }
	internal bool IsPreAllocatedDefault { get; }
	internal LogicalCallContext LogicalCallContext { get; set; }
	internal IllogicalCallContext IllogicalCallContext { get; set; }
	internal SynchronizationContext SynchronizationContext { get; set; }
	internal SynchronizationContext SynchronizationContextNoFlow { get; set; }


	internal bool get_isNewCapture() { }

	internal void set_isNewCapture(bool value) { }

	internal bool get_isFlowSuppressed() { }

	internal void set_isFlowSuppressed(bool value) { }

	internal static ExecutionContext get_PreAllocatedDefault() { }

	internal bool get_IsPreAllocatedDefault() { }

	[ReliabilityContractAttribute] 
	internal void .ctor() { }

	[ReliabilityContractAttribute] 
	internal void .ctor(bool isPreAllocatedDefault) { }

	internal static object GetLocalValue(IAsyncLocal local) { }

	internal static void SetLocalValue(IAsyncLocal local, object newValue, bool needChangeNotifications) { }

	[HandleProcessCorruptedStateExceptionsAttribute] 
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	internal LogicalCallContext get_LogicalCallContext() { }

	internal void set_LogicalCallContext(LogicalCallContext value) { }

	internal IllogicalCallContext get_IllogicalCallContext() { }

	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[ReliabilityContractAttribute] 
	internal SynchronizationContext get_SynchronizationContext() { }

	[ReliabilityContractAttribute] 
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[ReliabilityContractAttribute] 
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[ReliabilityContractAttribute] 
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	public void Dispose() { }

	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[FriendAccessAllowedAttribute] 
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	[HandleProcessCorruptedStateExceptionsAttribute] 
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[HandleProcessCorruptedStateExceptionsAttribute] 
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	public ExecutionContext CreateCopy() { }

	internal ExecutionContext CreateMutableCopy() { }

	public static bool IsFlowSuppressed() { }

	public static ExecutionContext Capture() { }

	[FriendAccessAllowedAttribute] 
	internal static ExecutionContext FastCapture() { }

	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options) { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	private static void .cctor() { }

}

private enum ExecutionContext.Flags // TypeDefIndex: 783
{
	public int value__; 
	public const ExecutionContext.Flags None = 0;
	public const ExecutionContext.Flags IsNewCapture = 1;
	public const ExecutionContext.Flags IsFlowSuppressed = 2;
	public const ExecutionContext.Flags IsPreAllocatedDefault = 4;

}

internal struct ExecutionContext.Reader // TypeDefIndex: 784
{
	private ExecutionContext m_ec; 

	public bool IsNull { get; }
	public bool IsFlowSuppressed { get; }
	public SynchronizationContext SynchronizationContext { get; }
	public SynchronizationContext SynchronizationContextNoFlow { get; }
	public LogicalCallContext.Reader LogicalCallContext { get; }


	public void .ctor(ExecutionContext ec) { }

	public ExecutionContext DangerousGetRawExecutionContext() { }

	public bool get_IsNull() { }

	public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	public bool get_IsFlowSuppressed() { }

	public SynchronizationContext get_SynchronizationContext() { }

	public SynchronizationContext get_SynchronizationContextNoFlow() { }

	public LogicalCallContext.Reader get_LogicalCallContext() { }

	public object GetLocalValue(IAsyncLocal local) { }

	public bool HasSameLocalValues(ExecutionContext other) { }

}

internal enum ExecutionContext.CaptureOptions // TypeDefIndex: 785
{
	public int value__; 
	public const ExecutionContext.CaptureOptions None = 0;
	public const ExecutionContext.CaptureOptions IgnoreSyncCtx = 1;
	public const ExecutionContext.CaptureOptions OptimizeDefaultCase = 2;

}

