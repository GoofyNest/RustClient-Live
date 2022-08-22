public sealed class Thread : CriticalFinalizerObject, _Thread // TypeDefIndex: 801
{	private static LocalDataStoreMgr s_LocalDataStoreMgr; // 0x0
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


	private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	private static void AsyncLocalSetCurrentUICulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	public void .ctor(ThreadStart start) { }

	public void .ctor(ParameterizedThreadStart start) { }

	public void Start() { }

	public void Start(object parameter) { }

	private void Start(ref StackCrawlMark stackMark) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	internal ExecutionContext.Reader GetExecutionContextReader() { }

	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	internal ExecutionContext GetMutableExecutionContext() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope) { }

	public void set_Priority(ThreadPriority value) { }

	private void SetPriorityNative(int priority) { }

	private bool JoinInternal(int millisecondsTimeout) { }

	public void Join() { }

	public bool Join(int millisecondsTimeout) { }

	private static void SleepInternal(int millisecondsTimeout) { }

	public static void Sleep(int millisecondsTimeout) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	private static bool YieldInternal() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static bool Yield() { }

	private void SetStartHelper(Delegate start, int maxStackSize) { }

	public CultureInfo get_CurrentUICulture() { }

	public void set_CurrentUICulture(CultureInfo value) { }

	internal CultureInfo GetCurrentUICultureNoAppX() { }

	public CultureInfo get_CurrentCulture() { }

	public void set_CurrentCulture(CultureInfo value) { }

	private CultureInfo GetCurrentCultureNoAppX() { }

	private static void nativeInitCultureAccessors() { }

	public static void MemoryBarrier() { }

	private void ConstructInternalThread() { }

	private InternalThread get_Internal() { }

	public static Context get_CurrentContext() { }

	private static Thread GetCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public static Thread get_CurrentThread() { }

	internal static int get_CurrentThreadId() { }

	public static int GetDomainID() { }

	private IntPtr Thread_internal(MulticastDelegate start) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	protected override void Finalize() { }

	public bool get_IsThreadPoolThread() { }

	internal bool get_IsThreadPoolThreadInternal() { }

	public bool get_IsAlive() { }

	public void set_IsBackground(bool value) { }

	private static void SetName_internal(InternalThread thread, string name) { }

	public void set_Name(string value) { }

	public ThreadState get_ThreadState() { }

	private static void Abort_internal(InternalThread thread, object stateInfo) { }

	public void Abort() { }

	private static void SpinWait_nop() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static void SpinWait(int iterations) { }

	private void StartInternal(IPrincipal principal, ref StackCrawlMark stackMark) { }

	private static void SetState(InternalThread thread, ThreadState set) { }

	private static void ClrState(InternalThread thread, ThreadState clr) { }

	private static ThreadState GetState(InternalThread thread) { }

	private static int SystemMaxStackStize() { }

	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public int get_ManagedThreadId() { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public static void BeginCriticalRegion() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static void EndCriticalRegion() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override int GetHashCode() { }

	private ThreadState ValidateThreadState() { }

}

