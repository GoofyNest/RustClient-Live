public sealed class Thread : CriticalFinalizerObject, _Thread // TypeDefIndex: 801
{
	private static LocalDataStoreMgr s_LocalDataStoreMgr; 
	[ThreadStaticAttribute] 
	private static LocalDataStoreHolder s_LocalDataStore; 
	[ThreadStaticAttribute] 
	internal static CultureInfo m_CurrentCulture; 
	[ThreadStaticAttribute] 
	internal static CultureInfo m_CurrentUICulture; 
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; 
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; 
	private InternalThread internal_thread; 
	private object m_ThreadStartArg; 
	private object pending_exception; 
	private IPrincipal principal; 
	private int principal_version; 
	[ThreadStaticAttribute] 
	private static Thread current_thread; 
	private MulticastDelegate m_Delegate; 
	private ExecutionContext m_ExecutionContext; 
	private bool m_ExecutionContextBelongsToOuterScope; 

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

	[ReliabilityContractAttribute] 
	internal ExecutionContext.Reader GetExecutionContextReader() { }

	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[ReliabilityContractAttribute] 
	internal ExecutionContext GetMutableExecutionContext() { }

	[ReliabilityContractAttribute] 
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContractAttribute] 
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope) { }

	public void set_Priority(ThreadPriority value) { }

	private void SetPriorityNative(int priority) { }

	private bool JoinInternal(int millisecondsTimeout) { }

	public void Join() { }

	public bool Join(int millisecondsTimeout) { }

	private static void SleepInternal(int millisecondsTimeout) { }

	public static void Sleep(int millisecondsTimeout) { }

	[ReliabilityContractAttribute] 
	private static bool YieldInternal() { }

	[ReliabilityContractAttribute] 
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

	[ReliabilityContractAttribute] 
	public static Thread get_CurrentThread() { }

	internal static int get_CurrentThreadId() { }

	public static int GetDomainID() { }

	private IntPtr Thread_internal(MulticastDelegate start) { }

	[ReliabilityContractAttribute] 
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

	[ReliabilityContractAttribute] 
	public static void SpinWait(int iterations) { }

	private void StartInternal(IPrincipal principal, ref StackCrawlMark stackMark) { }

	private static void SetState(InternalThread thread, ThreadState set) { }

	private static void ClrState(InternalThread thread, ThreadState clr) { }

	private static ThreadState GetState(InternalThread thread) { }

	private static int SystemMaxStackStize() { }

	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[ReliabilityContractAttribute] 
	public int get_ManagedThreadId() { }

	[ReliabilityContractAttribute] 
	public static void BeginCriticalRegion() { }

	[ReliabilityContractAttribute] 
	public static void EndCriticalRegion() { }

	[ComVisibleAttribute] 
	public override int GetHashCode() { }

	private ThreadState ValidateThreadState() { }

}

