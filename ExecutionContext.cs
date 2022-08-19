public sealed class ExecutionContext : IDisposable, ISerializable // TypeDefIndex: 782
{	// Fields
	private SynchronizationContext _syncContext; // 0x10
	private SynchronizationContext _syncContextNoFlow; // 0x18
	private LogicalCallContext _logicalCallContext; // 0x20
	private IllogicalCallContext _illogicalCallContext; // 0x28
	private ExecutionContext.Flags _flags; // 0x30
	private Dictionary<IAsyncLocal, object> _localValues; // 0x38
	private List<IAsyncLocal> _localChangeNotifications; // 0x40
	private static readonly ExecutionContext s_dummyDefaultEC; // 0x0

	// Properties
	internal bool isNewCapture { get; set; }
	internal bool isFlowSuppressed { get; set; }
	internal static ExecutionContext PreAllocatedDefault { get; }
	internal bool IsPreAllocatedDefault { get; }
	internal LogicalCallContext LogicalCallContext { get; set; }
	internal IllogicalCallContext IllogicalCallContext { get; set; }
	internal SynchronizationContext SynchronizationContext { get; set; }
	internal SynchronizationContext SynchronizationContextNoFlow { get; set; }

	// Methods

	// RVA: 0x148F420 Offset: 0x148E820 VA: 0x18148F420
	internal bool get_isNewCapture() { }

	// RVA: 0x148F450 Offset: 0x148E850 VA: 0x18148F450
	internal void set_isNewCapture(bool value) { }

	// RVA: 0x148F410 Offset: 0x148E810 VA: 0x18148F410
	internal bool get_isFlowSuppressed() { }

	// RVA: 0x148F430 Offset: 0x148E830 VA: 0x18148F430
	internal void set_isFlowSuppressed(bool value) { }

	// RVA: 0x148F350 Offset: 0x148E750 VA: 0x18148F350
	internal static ExecutionContext get_PreAllocatedDefault() { }

	// RVA: 0x148F2D0 Offset: 0x148E6D0 VA: 0x18148F2D0
	internal bool get_IsPreAllocatedDefault() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x148F230 Offset: 0x148E630 VA: 0x18148F230
	internal void .ctor(bool isPreAllocatedDefault) { }

	// RVA: 0x148E3F0 Offset: 0x148D7F0 VA: 0x18148E3F0
	internal static object GetLocalValue(IAsyncLocal local) { }

	// RVA: 0x148EF10 Offset: 0x148E310 VA: 0x18148EF10
	internal static void SetLocalValue(IAsyncLocal local, object newValue, bool needChangeNotifications) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x148E5E0 Offset: 0x148D9E0 VA: 0x18148E5E0
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	// RVA: 0x148F2E0 Offset: 0x148E6E0 VA: 0x18148F2E0
	internal LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x148F260 Offset: 0x148E660 VA: 0x18148F260
	internal IllogicalCallContext get_IllogicalCallContext() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal SynchronizationContext get_SynchronizationContext() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	// RVA: 0x488BC0 Offset: 0x487FC0 VA: 0x180488BC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x148EC00 Offset: 0x148E000 VA: 0x18148EC00
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x148ED10 Offset: 0x148E110 VA: 0x18148ED10
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x148E960 Offset: 0x148DD60 VA: 0x18148E960
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x148E2E0 Offset: 0x148D6E0 VA: 0x18148E2E0
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	// RVA: 0x148E270 Offset: 0x148D670 VA: 0x18148E270
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x148EDA0 Offset: 0x148E1A0 VA: 0x18148EDA0
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	// RVA: 0x148DED0 Offset: 0x148D2D0 VA: 0x18148DED0
	public ExecutionContext CreateCopy() { }

	// RVA: 0x148E080 Offset: 0x148D480 VA: 0x18148E080
	internal ExecutionContext CreateMutableCopy() { }

	// RVA: 0x148E5A0 Offset: 0x148D9A0 VA: 0x18148E5A0
	public static bool IsFlowSuppressed() { }

	// RVA: 0x148DE80 Offset: 0x148D280 VA: 0x18148DE80
	public static ExecutionContext Capture() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x148E390 Offset: 0x148D790 VA: 0x18148E390
	internal static ExecutionContext FastCapture() { }

	// RVA: 0x148DC80 Offset: 0x148D080 VA: 0x18148DC80
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options) { }

	// RVA: 0x148E480 Offset: 0x148D880 VA: 0x18148E480 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x148F150 Offset: 0x148E550 VA: 0x18148F150
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x148E550 Offset: 0x148D950 VA: 0x18148E550
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x148F0F0 Offset: 0x148E4F0 VA: 0x18148F0F0
	private static void .cctor() { }

}

private enum ExecutionContext.Flags // TypeDefIndex: 783
{	// Fields
	public int value__; // 0x0
	public const ExecutionContext.Flags None = 0;
	public const ExecutionContext.Flags IsNewCapture = 1;
	public const ExecutionContext.Flags IsFlowSuppressed = 2;
	public const ExecutionContext.Flags IsPreAllocatedDefault = 4;

}

internal struct ExecutionContext.Reader // TypeDefIndex: 784
{	// Fields
	private ExecutionContext m_ec; // 0x0

	// Properties
	public bool IsNull { get; }
	public bool IsFlowSuppressed { get; }
	public SynchronizationContext SynchronizationContext { get; }
	public SynchronizationContext SynchronizationContextNoFlow { get; }
	public LogicalCallContext.Reader LogicalCallContext { get; }

	// Methods

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	public void .ctor(ExecutionContext ec) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public ExecutionContext DangerousGetRawExecutionContext() { }

	// RVA: 0x1186B0 Offset: 0x117AB0 VA: 0x1801186B0
	public bool get_IsNull() { }

	// RVA: 0x1F05F0 Offset: 0x1EF9F0 VA: 0x1801F05F0
	public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x1F0650 Offset: 0x1EFA50 VA: 0x1801F0650
	public bool get_IsFlowSuppressed() { }

	// RVA: 0x1F06C0 Offset: 0x1EFAC0 VA: 0x1801F06C0
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x1F06B0 Offset: 0x1EFAB0 VA: 0x1801F06B0
	public SynchronizationContext get_SynchronizationContextNoFlow() { }

	// RVA: 0x1F0670 Offset: 0x1EFA70 VA: 0x1801F0670
	public LogicalCallContext.Reader get_LogicalCallContext() { }

	// RVA: 0x1F05B0 Offset: 0x1EF9B0 VA: 0x1801F05B0
	public object GetLocalValue(IAsyncLocal local) { }

	// RVA: 0x1F05C0 Offset: 0x1EF9C0 VA: 0x1801F05C0
	public bool HasSameLocalValues(ExecutionContext other) { }

}

internal enum ExecutionContext.CaptureOptions // TypeDefIndex: 785
{	// Fields
	public int value__; // 0x0
	public const ExecutionContext.CaptureOptions None = 0;
	public const ExecutionContext.CaptureOptions IgnoreSyncCtx = 1;
	public const ExecutionContext.CaptureOptions OptimizeDefaultCase = 2;

}

