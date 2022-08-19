private sealed class Task.<>c<TResult> // TypeDefIndex: 843
{	// Fields
	public static readonly Task.<>c<TResult> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD602E0 Offset: 0xD5F6E0 VA: 0x180D602E0
	|-Task.<>c<PublishResult>..cctor
	|-Task.<>c<bool>..cctor
	|-Task.<>c<int>..cctor
	|-Task.<>c<UdpReceiveResult>..cctor
	|-Task.<>c<Nullable<ServerInfo>>..cctor
	|-Task.<>c<Nullable<Image>>..cctor
	|-Task.<>c<Nullable<InventoryPurchaseResult>>..cctor
	|-Task.<>c<Nullable<InventoryResult>>..cctor
	|-Task.<>c<Nullable<Item>>..cctor
	|-Task.<>c<Nullable<ResultPage>>..cctor
	|-Task.<>c<Nullable<int>>..cctor
	|-Task.<>c<Nullable<Int32Enum>>..cctor
	|-Task.<>c<object>..cctor
	|-Task.<>c<VoidTaskResult>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-Task.<>c<PublishResult>..ctor
	|-Task.<>c<bool>..ctor
	|-Task.<>c<int>..ctor
	|-Task.<>c<UdpReceiveResult>..ctor
	|-Task.<>c<Nullable<ServerInfo>>..ctor
	|-Task.<>c<Nullable<Image>>..ctor
	|-Task.<>c<Nullable<InventoryPurchaseResult>>..ctor
	|-Task.<>c<Nullable<InventoryResult>>..ctor
	|-Task.<>c<Nullable<Item>>..ctor
	|-Task.<>c<Nullable<ResultPage>>..ctor
	|-Task.<>c<Nullable<int>>..ctor
	|-Task.<>c<Nullable<Int32Enum>>..ctor
	|-Task.<>c<object>..ctor
	|-Task.<>c<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal Task<TResult> <.cctor>b__64_0(Task<Task> completed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8F000 Offset: 0x1A8E400 VA: 0x181A8F000
	|-Task.<>c<PublishResult>.<.cctor>b__64_0
	|
	|-RVA: 0x1A8ED40 Offset: 0x1A8E140 VA: 0x181A8ED40
	|-Task.<>c<bool>.<.cctor>b__64_0
	|
	|-RVA: 0x1A8F160 Offset: 0x1A8E560 VA: 0x181A8F160
	|-Task.<>c<int>.<.cctor>b__64_0
	|
	|-RVA: 0x1A8EA80 Offset: 0x1A8DE80 VA: 0x181A8EA80
	|-Task.<>c<UdpReceiveResult>.<.cctor>b__64_0
	|
	|-RVA: 0x1A8EDF0 Offset: 0x1A8E1F0 VA: 0x181A8EDF0
	|-Task.<>c<Nullable<ServerInfo>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A8F2C0 Offset: 0x1A8E6C0 VA: 0x181A8F2C0
	|-Task.<>c<Nullable<Image>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A8EC90 Offset: 0x1A8E090 VA: 0x181A8EC90
	|-Task.<>c<Nullable<InventoryPurchaseResult>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A8F370 Offset: 0x1A8E770 VA: 0x181A8F370
	|-Task.<>c<Nullable<InventoryResult>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A8EBE0 Offset: 0x1A8DFE0 VA: 0x181A8EBE0
	|-Task.<>c<Nullable<Item>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A8EB30 Offset: 0x1A8DF30 VA: 0x181A8EB30
	|-Task.<>c<Nullable<ResultPage>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A8EF50 Offset: 0x1A8E350 VA: 0x181A8EF50
	|-Task.<>c<Nullable<int>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A8F210 Offset: 0x1A8E610 VA: 0x181A8F210
	|-Task.<>c<Nullable<Int32Enum>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A8EEA0 Offset: 0x1A8E2A0 VA: 0x181A8EEA0
	|-Task.<>c<object>.<.cctor>b__64_0
	|
	|-RVA: 0x1A8F0B0 Offset: 0x1A8E4B0 VA: 0x181A8F0B0
	|-Task.<>c<VoidTaskResult>.<.cctor>b__64_0
	*/

}

public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 853
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static Task t_currentTask; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static StackGuard t_stackGuard; // 0x80000008
	internal static int s_taskIdCounter; // 0x0
	private static readonly TaskFactory s_factory; // 0x8
	private int m_taskId; // 0x10
	internal object m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private const int OptionsMask = 65535;
	internal const int TASK_STATE_STARTED = 65536;
	internal const int TASK_STATE_DELEGATE_INVOKED = 131072;
	internal const int TASK_STATE_DISPOSED = 262144;
	internal const int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = 524288;
	internal const int TASK_STATE_CANCELLATIONACKNOWLEDGED = 1048576;
	internal const int TASK_STATE_FAULTED = 2097152;
	internal const int TASK_STATE_CANCELED = 4194304;
	internal const int TASK_STATE_WAITING_ON_CHILDREN = 8388608;
	internal const int TASK_STATE_RAN_TO_COMPLETION = 16777216;
	internal const int TASK_STATE_WAITINGFORACTIVATION = 33554432;
	internal const int TASK_STATE_COMPLETION_RESERVED = 67108864;
	internal const int TASK_STATE_THREAD_WAS_ABORTED = 134217728;
	internal const int TASK_STATE_WAIT_COMPLETION_NOTIFICATION = 268435456;
	internal const int TASK_STATE_EXECUTIONCONTEXT_IS_NULL = 536870912;
	internal const int TASK_STATE_TASKSCHEDULED_WAS_FIRED = 1073741824;
	private const int TASK_STATE_COMPLETED_MASK = 23068672;
	private const int CANCELLATION_REQUESTED = 1;
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x10
	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static bool s_asyncDebuggingEnabled; // 0x18
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x20
	private static readonly object s_activeTasksLock; // 0x28
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x30
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x38
	private static Task s_completedTask; // 0x40
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x48
	private static ContextCallback s_ecCallback; // 0x50
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	internal bool IsRanToCompletion { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool IsSelfReplicatingRoot { get; }
	internal bool IsChildReplica { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }
	internal virtual object SavedStateForNextReplica { get; }
	internal virtual object SavedStateFromPreviousReplica { set; }
	internal virtual Task HandedOverChildReplica { get; set; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1497540 Offset: 0x1496940 VA: 0x181497540
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x149BFA0 Offset: 0x149B3A0 VA: 0x18149BFA0
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x149DE30 Offset: 0x149D230 VA: 0x18149DE30
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x149DF00 Offset: 0x149D300 VA: 0x18149DF00
	internal void .ctor() { }

	// RVA: 0x149DD00 Offset: 0x149D100 VA: 0x18149DD00
	internal void .ctor(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	// RVA: 0x149DBF0 Offset: 0x149CFF0 VA: 0x18149DBF0
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x149D040 Offset: 0x149C440 VA: 0x18149D040
	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x14977B0 Offset: 0x1496BB0 VA: 0x1814977B0
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x149CF50 Offset: 0x149C350 VA: 0x18149CF50
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x149B850 Offset: 0x149AC50 VA: 0x18149B850
	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	// RVA: 0x149E9B0 Offset: 0x149DDB0 VA: 0x18149E9B0
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x136B180 Offset: 0x136A580 VA: 0x18136B180
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x1497B40 Offset: 0x1496F40 VA: 0x181497B40
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x1497C70 Offset: 0x1497070 VA: 0x181497C70
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x149C7B0 Offset: 0x149BBB0 VA: 0x18149C7B0
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x149B7C0 Offset: 0x149ABC0 VA: 0x18149B7C0
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x1497710 Offset: 0x1496B10 VA: 0x181497710
	internal static bool AnyTaskRequiresNotifyDebuggerOfWaitCompletion(Task[] tasks) { }

	// RVA: 0x149E960 Offset: 0x149DD60 VA: 0x18149E960
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x149E990 Offset: 0x149DD90 VA: 0x18149E990 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x149E990 Offset: 0x149DD90 VA: 0x18149E990
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x149B820 Offset: 0x149AC20 VA: 0x18149B820
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x149B740 Offset: 0x149AB40 VA: 0x18149B740
	internal bool MarkStarted() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	// RVA: 0x1497020 Offset: 0x1496420 VA: 0x181497020
	internal void AddNewChild() { }

	// RVA: 0x14994E0 Offset: 0x14988E0 VA: 0x1814994E0
	internal void DisregardChild() { }

	// RVA: 0x149B4A0 Offset: 0x149A8A0 VA: 0x18149B4A0
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x149B760 Offset: 0x149AB60 VA: 0x18149B760
	internal static int NewId() { }

	// RVA: 0x149E550 Offset: 0x149D950 VA: 0x18149E550
	public int get_Id() { }

	// RVA: 0x149E630 Offset: 0x149DA30 VA: 0x18149E630
	internal static Task get_InternalCurrent() { }

	// RVA: 0x149B3F0 Offset: 0x149A7F0 VA: 0x18149B3F0
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x149E380 Offset: 0x149D780 VA: 0x18149E380
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x149E4A0 Offset: 0x149D8A0 VA: 0x18149E4A0
	public AggregateException get_Exception() { }

	// RVA: 0x149EA10 Offset: 0x149DE10 VA: 0x18149EA10
	public TaskStatus get_Status() { }

	// RVA: 0x149E6F0 Offset: 0x149DAF0 VA: 0x18149E6F0
	public bool get_IsCanceled() { }

	// RVA: 0x149E740 Offset: 0x149DB40 VA: 0x18149E740
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x1499650 Offset: 0x1498A50 VA: 0x181499650
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x1499590 Offset: 0x1498990 VA: 0x181499590
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x149DF30 Offset: 0x149D330 VA: 0x18149DF30
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x149E720 Offset: 0x149DB20 VA: 0x18149E720
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x149E810 Offset: 0x149DC10 VA: 0x18149E810 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x149B730 Offset: 0x149AB30 VA: 0x18149B730
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x149E8D0 Offset: 0x149DCD0 VA: 0x18149E8D0
	internal bool get_IsRanToCompletion() { }

	// RVA: 0x149E320 Offset: 0x149D720 VA: 0x18149E320
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x149CD90 Offset: 0x149C190 VA: 0x18149CD90 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	// RVA: 0x149E4F0 Offset: 0x149D8F0 VA: 0x18149E4F0
	public static TaskFactory get_Factory() { }

	// RVA: 0x149E230 Offset: 0x149D630 VA: 0x18149E230
	public static Task get_CompletedTask() { }

	// RVA: 0x149E050 Offset: 0x149D450 VA: 0x18149E050
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x149E900 Offset: 0x149DD00 VA: 0x18149E900
	internal bool get_IsSelfReplicatingRoot() { }

	// RVA: 0x149E7B0 Offset: 0x149DBB0 VA: 0x18149E7B0
	internal bool get_IsChildReplica() { }

	// RVA: 0x149E440 Offset: 0x149D840 VA: 0x18149E440
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x149E8B0 Offset: 0x149DCB0 VA: 0x18149E8B0
	public bool get_IsFaulted() { }

	// RVA: 0x149DF60 Offset: 0x149D360 VA: 0x18149DF60
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x149EAA0 Offset: 0x149DEA0 VA: 0x18149EAA0
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x1498910 Offset: 0x1497D10 VA: 0x181498910
	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	// RVA: 0x14992E0 Offset: 0x14986E0 VA: 0x1814992E0 Slot: 10
	public void Dispose() { }

	// RVA: 0x1499350 Offset: 0x1498750 VA: 0x181499350 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x149C350 Offset: 0x149B750 VA: 0x18149C350
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x1496B90 Offset: 0x1495F90 VA: 0x181496B90
	internal void AddException(object exceptionObject) { }

	// RVA: 0x1496BA0 Offset: 0x1495FA0 VA: 0x181496BA0
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x149AE20 Offset: 0x149A220 VA: 0x18149AE20
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x149AD20 Offset: 0x149A120 VA: 0x18149AD20
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x149ACE0 Offset: 0x149A0E0 VA: 0x18149ACE0
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x149D2F0 Offset: 0x149C6F0 VA: 0x18149D2F0
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x149D360 Offset: 0x149C760 VA: 0x18149D360
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x149E890 Offset: 0x149DC90 VA: 0x18149E890
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x149E870 Offset: 0x149DC70 VA: 0x18149E870
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x149A9E0 Offset: 0x1499DE0 VA: 0x18149A9E0
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x149A7E0 Offset: 0x1499BE0 VA: 0x18149A7E0
	internal void FinishStageTwo() { }

	// RVA: 0x149A730 Offset: 0x1499B30 VA: 0x18149A730
	internal void FinishStageThree() { }

	// RVA: 0x149B8C0 Offset: 0x149ACC0 VA: 0x18149B8C0
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x1496DB0 Offset: 0x14961B0 VA: 0x181496DB0
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x149A950 Offset: 0x1499D50 VA: 0x18149A950
	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	// RVA: 0x1499EB0 Offset: 0x14992B0 VA: 0x181499EB0
	private void Execute() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 13
	internal virtual bool ShouldReplicate() { }

	// RVA: 0x1498980 Offset: 0x1497D80 VA: 0x181498980 Slot: 14
	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 15
	internal virtual object get_SavedStateForNextReplica() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 16
	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 17
	internal virtual Task get_HandedOverChildReplica() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	internal virtual void set_HandedOverChildReplica(Task value) { }

	// RVA: 0x14999B0 Offset: 0x1498DB0 VA: 0x1814999B0
	private static void ExecuteSelfReplicating(Task root) { }

	// RVA: 0x149CE60 Offset: 0x149C260 VA: 0x18149CE60 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x149CE70 Offset: 0x149C270 VA: 0x18149CE70 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1499740 Offset: 0x1498B40 VA: 0x181499740
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x1499AF0 Offset: 0x1498EF0 VA: 0x181499AF0
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x149A100 Offset: 0x1499500 VA: 0x18149A100
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x149B110 Offset: 0x149A510 VA: 0x18149B110 Slot: 19
	internal virtual void InnerInvoke() { }

	// RVA: 0x149B0E0 Offset: 0x149A4E0 VA: 0x18149B0E0
	internal void InnerInvokeWithArg(Task childTask) { }

	// RVA: 0x149AFB0 Offset: 0x149A3B0 VA: 0x18149AFB0
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x149ACC0 Offset: 0x149A0C0 VA: 0x18149ACC0
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x1497E90 Offset: 0x1497290 VA: 0x181497E90
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x149C540 Offset: 0x149B940 VA: 0x18149C540
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x149D490 Offset: 0x149C890 VA: 0x18149D490
	public void Wait() { }

	// RVA: 0x149D560 Offset: 0x149C960 VA: 0x18149D560
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x149D890 Offset: 0x149CC90 VA: 0x18149D890
	private bool WrappedTryRunInline() { }

	// RVA: 0x149B5C0 Offset: 0x149A9C0 VA: 0x18149B5C0
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x149C8F0 Offset: 0x149BCF0 VA: 0x18149C8F0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x149CC50 Offset: 0x149C050 VA: 0x18149CC50
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x149B1A0 Offset: 0x149A5A0 VA: 0x18149B1A0
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x149BB80 Offset: 0x149AF80 VA: 0x18149BB80
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x149BC30 Offset: 0x149B030 VA: 0x18149BC30
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x149BAB0 Offset: 0x149AEB0 VA: 0x18149BAB0
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x1497DA0 Offset: 0x14971A0 VA: 0x181497DA0
	internal void CancellationCleanupLogic() { }

	// RVA: 0x149C510 Offset: 0x149B910 VA: 0x18149C510
	private void SetCancellationAcknowledged() { }

	// RVA: 0x149A1B0 Offset: 0x14995B0 VA: 0x18149A1B0
	internal void FinishContinuations() { }

	// RVA: 0x488BC0 Offset: 0x487FC0 VA: 0x180488BC0
	private void LogFinishCompletionNotification() { }

	// RVA: 0x1498770 Offset: 0x1497B70 VA: 0x181498770
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x14985B0 Offset: 0x14979B0 VA: 0x1814985B0
	public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x1498290 Offset: 0x1497690 VA: 0x181498290
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x14980F0 Offset: 0x14974F0 VA: 0x1814980F0
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1498420 Offset: 0x1497820 VA: 0x181498420
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1498AC0 Offset: 0x1497EC0 VA: 0x181498AC0
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x1497EB0 Offset: 0x14972B0 VA: 0x181497EB0
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x1496B20 Offset: 0x1495F20 VA: 0x181496B20
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x1496AA0 Offset: 0x1495EA0 VA: 0x181496AA0
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x1497150 Offset: 0x1496550 VA: 0x181497150
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x1497470 Offset: 0x1496870 VA: 0x181497470
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x149BCD0 Offset: 0x149B0D0 VA: 0x18149BCD0
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x154A050 Offset: 0x1549450 VA: 0x18154A050
	|-Task.FromResult<bool>
	|
	|-RVA: 0x154A110 Offset: 0x1549510 VA: 0x18154A110
	|-Task.FromResult<Stream>
	|-Task.FromResult<Tuple<int, int, int, bool>>
	|-Task.FromResult<object>
	|
	|-RVA: 0x154A0B0 Offset: 0x15494B0 VA: 0x18154A0B0
	|-Task.FromResult<int>
	*/

	// RVA: 0x149AC60 Offset: 0x149A060 VA: 0x18149AC60
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1549DE0 Offset: 0x15491E0 VA: 0x181549DE0
	|-Task.FromException<int>
	|
	|-RVA: 0x1549EB0 Offset: 0x15492B0 VA: 0x181549EB0
	|-Task.FromException<object>
	|
	|-RVA: 0x1549F80 Offset: 0x1549380 VA: 0x181549F80
	|-Task.FromException<VoidTaskResult>
	*/

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x149ABB0 Offset: 0x1499FB0 VA: 0x18149ABB0
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84C40 Offset: 0xE84040 VA: 0x180E84C40
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0x1549A80 Offset: 0x1548E80 VA: 0x181549A80
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x1549C30 Offset: 0x1549030 VA: 0x181549C30
	|-Task.FromCancellation<object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84D10 Offset: 0xE84110 VA: 0x180E84D10
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x1549B50 Offset: 0x1548F50 VA: 0x181549B50
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x1549D00 Offset: 0x1549100 VA: 0x181549D00
	|-Task.FromCancellation<VoidTaskResult>
	*/

	// RVA: 0x149C150 Offset: 0x149B550 VA: 0x18149C150
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x154A7D0 Offset: 0x1549BD0 VA: 0x18154A7D0
	|-Task.Run<Stream>
	|-Task.Run<object>
	|
	|-RVA: 0x154A270 Offset: 0x1549670 VA: 0x18154A270
	|-Task.Run<int>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x154A670 Offset: 0x1549A70 VA: 0x18154A670
	|-Task.Run<MP3Stream>
	|-Task.Run<object>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x154A600 Offset: 0x1549A00 VA: 0x18154A600
	|-Task.Run<Stream>
	|-Task.Run<WebResponse>
	|-Task.Run<object>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x154A3E0 Offset: 0x15497E0 VA: 0x18154A3E0
	|-Task.Run<object>
	*/

	// RVA: 0x1498D30 Offset: 0x1498130 VA: 0x181498D30
	public static Task Delay(TimeSpan delay) { }

	// RVA: 0x1498C60 Offset: 0x1498060 VA: 0x181498C60
	public static Task Delay(TimeSpan delay, CancellationToken cancellationToken) { }

	// RVA: 0x1498C00 Offset: 0x1498000 VA: 0x181498C00
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x1498E30 Offset: 0x1498230 VA: 0x181498E30
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x154A940 Offset: 0x1549D40 VA: 0x18154A940
	|-Task.WhenAll<IPlayerInventory>
	|-Task.WhenAll<object>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult[]> WhenAll<TResult>(Task<TResult>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x154AE70 Offset: 0x154A270 VA: 0x18154AE70
	|-Task.WhenAll<object>
	*/

	// RVA: -1 Offset: -1
	private static Task<TResult[]> InternalWhenAll<TResult>(Task<TResult>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x154A170 Offset: 0x1549570 VA: 0x18154A170
	|-Task.InternalWhenAll<object>
	*/

	// RVA: 0x149D6C0 Offset: 0x149CAC0 VA: 0x18149D6C0
	public static Task<Task> WhenAny(Task[] tasks) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal static Task<TResult> CreateUnwrapPromise<TResult>(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84BD0 Offset: 0xE83FD0 VA: 0x180E84BD0
	|-Task.CreateUnwrapPromise<object>
	*/

	// RVA: 0x149D970 Offset: 0x149CD70 VA: 0x18149D970
	private static void .cctor() { }

}

internal class Task.ContingentProperties // TypeDefIndex: 854
{	// Fields
	internal ExecutionContext m_capturedContext; // 0x10
	internal ManualResetEventSlim m_completionEvent; // 0x18
	internal TaskExceptionHolder m_exceptionsHolder; // 0x20
	internal CancellationToken m_cancellationToken; // 0x28
	internal Shared<CancellationTokenRegistration> m_cancellationRegistration; // 0x30
	internal int m_internalCancellationRequested; // 0x38
	internal int m_completionCountdown; // 0x3C
	internal List<Task> m_exceptionalChildren; // 0x40

	// Methods

	// RVA: 0x1600BE0 Offset: 0x15FFFE0 VA: 0x181600BE0
	internal void SetCompleted() { }

	// RVA: 0x1600B60 Offset: 0x15FFF60 VA: 0x181600B60
	internal void DeregisterCancellationCallback() { }

	// RVA: 0x1600C10 Offset: 0x1600010 VA: 0x181600C10
	public void .ctor() { }

}

private sealed class Task.SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction // TypeDefIndex: 855
{	// Methods

	// RVA: 0x1602190 Offset: 0x1601590 VA: 0x181602190
	internal void .ctor() { }

	// RVA: 0x1602180 Offset: 0x1601580 VA: 0x181602180 Slot: 6
	public void Invoke(Task completingTask) { }

}

private sealed class Task.DelayPromise : Task<VoidTaskResult> // TypeDefIndex: 856
{	// Fields
	internal readonly CancellationToken Token; // 0x58
	internal CancellationTokenRegistration Registration; // 0x60
	internal Timer Timer; // 0x78

	// Methods

	// RVA: 0x1600DD0 Offset: 0x16001D0 VA: 0x181600DD0
	internal void .ctor(CancellationToken token) { }

	// RVA: 0x1600C40 Offset: 0x1600040 VA: 0x181600C40
	internal void Complete() { }

}

private sealed class Task.WhenAllPromise<T> : Task<T[]>, ITaskCompletionAction // TypeDefIndex: 857
{	// Fields
	private readonly Task<T>[] m_tasks; // 0x0
	private int m_count; // 0x0

	// Properties
	internal override bool ShouldNotifyDebuggerOfWaitCompletion { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<T>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1365210 Offset: 0x1364610 VA: 0x181365210
	|-Task.WhenAllPromise<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void Invoke(Task ignored) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1364EA0 Offset: 0x13642A0 VA: 0x181364EA0
	|-Task.WhenAllPromise<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override bool get_ShouldNotifyDebuggerOfWaitCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1365410 Offset: 0x1364810 VA: 0x181365410
	|-Task.WhenAllPromise<object>.get_ShouldNotifyDebuggerOfWaitCompletion
	*/

}

private sealed class Task.<>c__DisplayClass178_0 // TypeDefIndex: 858
{	// Fields
	public Task root; // 0x10
	public bool replicasAreQuitting; // 0x18
	public Action<object> taskReplicaDelegate; // 0x20
	public TaskCreationOptions creationOptionsForReplicas; // 0x28
	public InternalTaskOptions internalOptionsForReplicas; // 0x2C

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1616710 Offset: 0x1615B10 VA: 0x181616710
	internal void <ExecuteSelfReplicating>b__0(object <p0>) { }

}

private sealed class Task.<>c // TypeDefIndex: 859
{	// Fields
	public static readonly Task.<>c <>9; // 0x0
	public static Action<object> <>9__276_0; // 0x8
	public static TimerCallback <>9__276_1; // 0x10

	// Methods

	// RVA: 0x1616BB0 Offset: 0x1615FB0 VA: 0x181616BB0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1616560 Offset: 0x1615960 VA: 0x181616560
	internal void <Delay>b__276_0(object state) { }

	// RVA: 0x16165C0 Offset: 0x16159C0 VA: 0x1816165C0
	internal void <Delay>b__276_1(object state) { }

	// RVA: 0x16166A0 Offset: 0x1615AA0 VA: 0x1816166A0
	internal Task.ContingentProperties <.cctor>b__295_0() { }

	// RVA: 0x16166F0 Offset: 0x1615AF0 VA: 0x1816166F0
	internal bool <.cctor>b__295_1(Task t) { }

	// RVA: 0xDEAFD0 Offset: 0xDEA3D0 VA: 0x180DEAFD0
	internal bool <.cctor>b__295_2(object tc) { }

}

