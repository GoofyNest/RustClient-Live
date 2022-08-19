public sealed class Thread : CriticalFinalizerObject, _Thread // TypeDefIndex: 801
{	// Fields
	private static LocalDataStoreMgr s_LocalDataStoreMgr; // 0x0
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static LocalDataStoreHolder s_LocalDataStore; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static CultureInfo m_CurrentCulture; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static CultureInfo m_CurrentUICulture; // 0x80000010
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; // 0x8
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; // 0x10
	private InternalThread internal_thread; // 0x10
	private object m_ThreadStartArg; // 0x18
	private object pending_exception; // 0x20
	private IPrincipal principal; // 0x28
	private int principal_version; // 0x30
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Thread current_thread; // 0x80000018
	private MulticastDelegate m_Delegate; // 0x38
	private ExecutionContext m_ExecutionContext; // 0x40
	private bool m_ExecutionContextBelongsToOuterScope; // 0x48

	// Properties
	internal bool ExecutionContextBelongsToCurrentScope { get; set; }
	public ThreadPriority Priority { set; }
	public CultureInfo CurrentUICulture { get; set; }
	public CultureInfo CurrentCulture { get; set; }
	private InternalThread Internal { get; }
	public static Context CurrentContext { get; }
	public static Thread CurrentThread { get; }
	internal static int CurrentThreadId { get; }
	public bool IsThreadPoolThread { get; }
	internal bool IsThreadPoolThreadInternal { get; }
	public bool IsAlive { get; }
	public bool IsBackground { set; }
	public string Name { set; }
	public ThreadState ThreadState { get; }
	public int ManagedThreadId { get; }

	// Methods

	// RVA: 0x1607800 Offset: 0x1606C00 VA: 0x181607800
	private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	// RVA: 0x1607850 Offset: 0x1606C50 VA: 0x181607850
	private static void AsyncLocalSetCurrentUICulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	// RVA: 0x1608580 Offset: 0x1607980 VA: 0x181608580
	public void .ctor(ThreadStart start) { }

	// RVA: 0x16084F0 Offset: 0x16078F0 VA: 0x1816084F0
	public void .ctor(ParameterizedThreadStart start) { }

	// RVA: 0x1608280 Offset: 0x1607680 VA: 0x181608280
	public void Start() { }

	// RVA: 0x16081C0 Offset: 0x16075C0 VA: 0x1816081C0
	public void Start(object parameter) { }

	// RVA: 0x16082A0 Offset: 0x16076A0 VA: 0x1816082A0
	private void Start(ref StackCrawlMark stackMark) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1607B40 Offset: 0x1606F40 VA: 0x181607B40
	internal ExecutionContext.Reader GetExecutionContextReader() { }

	// RVA: 0x16086C0 Offset: 0x1607AC0 VA: 0x1816086C0
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	// RVA: 0x1608B70 Offset: 0x1607F70 VA: 0x181608B70
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x1607BB0 Offset: 0x1606FB0 VA: 0x181607BB0
	internal ExecutionContext GetMutableExecutionContext() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1607DF0 Offset: 0x16071F0 VA: 0x181607DF0
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1607DF0 Offset: 0x16071F0 VA: 0x181607DF0
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope) { }

	// RVA: 0x1607E40 Offset: 0x1607240 VA: 0x181607E40
	public void set_Priority(ThreadPriority value) { }

	// RVA: 0x1607E40 Offset: 0x1607240 VA: 0x181607E40
	private void SetPriorityNative(int priority) { }

	// RVA: 0x1607D30 Offset: 0x1607130 VA: 0x181607D30
	private bool JoinInternal(int millisecondsTimeout) { }

	// RVA: 0x1607D40 Offset: 0x1607140 VA: 0x181607D40
	public void Join() { }

	// RVA: 0x1607D50 Offset: 0x1607150 VA: 0x181607D50
	public bool Join(int millisecondsTimeout) { }

	// RVA: 0x1608060 Offset: 0x1607460 VA: 0x181608060
	private static void SleepInternal(int millisecondsTimeout) { }

	// RVA: 0x1608070 Offset: 0x1607470 VA: 0x181608070
	public static void Sleep(int millisecondsTimeout) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x16084E0 Offset: 0x16078E0 VA: 0x1816084E0
	private static bool YieldInternal() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x16084E0 Offset: 0x16078E0 VA: 0x1816084E0
	public static bool Yield() { }

	// RVA: 0x1607E50 Offset: 0x1607250 VA: 0x181607E50
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	// RVA: 0x1607A90 Offset: 0x1606E90 VA: 0x181607A90
	public CultureInfo get_CurrentUICulture() { }

	// RVA: 0x16089C0 Offset: 0x1607DC0 VA: 0x1816089C0
	public void set_CurrentUICulture(CultureInfo value) { }

	// RVA: 0x1607A90 Offset: 0x1606E90 VA: 0x181607A90
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	// RVA: 0x16079E0 Offset: 0x1606DE0 VA: 0x1816079E0
	public CultureInfo get_CurrentCulture() { }

	// RVA: 0x1608840 Offset: 0x1607C40 VA: 0x181608840
	public void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x16079E0 Offset: 0x1606DE0 VA: 0x1816079E0
	private CultureInfo GetCurrentCultureNoAppX() { }

	// RVA: 0x16087B0 Offset: 0x1607BB0 VA: 0x1816087B0
	private static void nativeInitCultureAccessors() { }

	// RVA: 0x1607DE0 Offset: 0x16071E0 VA: 0x181607DE0
	public static void MemoryBarrier() { }

	// RVA: 0x1607940 Offset: 0x1606D40 VA: 0x181607940
	private void ConstructInternalThread() { }

	// RVA: 0x16086D0 Offset: 0x1607AD0 VA: 0x1816086D0
	private InternalThread get_Internal() { }

	// RVA: 0x1470670 Offset: 0x146FA70 VA: 0x181470670
	public static Context get_CurrentContext() { }

	// RVA: 0x1607A80 Offset: 0x1606E80 VA: 0x181607A80
	private static Thread GetCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x1608670 Offset: 0x1607A70 VA: 0x181608670
	public static Thread get_CurrentThread() { }

	// RVA: 0x1608610 Offset: 0x1607A10 VA: 0x181608610
	internal static int get_CurrentThreadId() { }

	// RVA: 0x1607B30 Offset: 0x1606F30 VA: 0x181607B30
	public static int GetDomainID() { }

	// RVA: 0x1608450 Offset: 0x1607850 VA: 0x181608450
	private IntPtr Thread_internal(MulticastDelegate start) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1492DC0 Offset: 0x14921C0 VA: 0x181492DC0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1608740 Offset: 0x1607B40 VA: 0x181608740
	public bool get_IsThreadPoolThread() { }

	// RVA: 0x1608740 Offset: 0x1607B40 VA: 0x181608740
	internal bool get_IsThreadPoolThreadInternal() { }

	// RVA: 0x1608700 Offset: 0x1607B00 VA: 0x181608700
	public bool get_IsAlive() { }

	// RVA: 0x1608B80 Offset: 0x1607F80 VA: 0x181608B80
	public void set_IsBackground(bool value) { }

	// RVA: 0x1607E30 Offset: 0x1607230 VA: 0x181607E30
	private static void SetName_internal(InternalThread thread, string name) { }

	// RVA: 0x1608C50 Offset: 0x1608050 VA: 0x181608C50
	public void set_Name(string value) { }

	// RVA: 0x1608780 Offset: 0x1607B80 VA: 0x181608780
	public ThreadState get_ThreadState() { }

	// RVA: 0x16077C0 Offset: 0x1606BC0 VA: 0x1816077C0
	private static void Abort_internal(InternalThread thread, object stateInfo) { }

	// RVA: 0x16077D0 Offset: 0x1606BD0 VA: 0x1816077D0
	public void Abort() { }

	// RVA: 0xD64770 Offset: 0xD63B70 VA: 0x180D64770
	private static void SpinWait_nop() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1608100 Offset: 0x1607500 VA: 0x181608100
	public static void SpinWait(int iterations) { }

	// RVA: 0x1608130 Offset: 0x1607530 VA: 0x181608130
	private void StartInternal(IPrincipal principal, ref StackCrawlMark stackMark) { }

	// RVA: 0x1608050 Offset: 0x1607450 VA: 0x181608050
	private static void SetState(InternalThread thread, ThreadState set) { }

	// RVA: 0x1607930 Offset: 0x1606D30 VA: 0x181607930
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	// RVA: 0x1607D20 Offset: 0x1607120 VA: 0x181607D20
	private static ThreadState GetState(InternalThread thread) { }

	// RVA: 0x1608440 Offset: 0x1607840 VA: 0x181608440
	private static int SystemMaxStackStize() { }

	// RVA: 0x1607C70 Offset: 0x1607070 VA: 0x181607C70
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	// RVA: 0x1608000 Offset: 0x1607400 VA: 0x181608000
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1607B70 Offset: 0x1606F70 VA: 0x181607B70
	public int get_ManagedThreadId() { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x16078A0 Offset: 0x1606CA0 VA: 0x1816078A0
	public static void BeginCriticalRegion() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1607950 Offset: 0x1606D50 VA: 0x181607950
	public static void EndCriticalRegion() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x1607B70 Offset: 0x1606F70 VA: 0x181607B70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1608460 Offset: 0x1607860 VA: 0x181608460
	private ThreadState ValidateThreadState() { }

}

