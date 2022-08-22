internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem // TypeDefIndex: 881
{	private readonly ExecutionContext m_capturedContext; // 0x10
	protected readonly Action m_action; // 0x18
	private static ContextCallback s_invokeActionCallback; // 0x0

	internal static bool IsValidLocationForInlining { get; }


	internal void .ctor(Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	internal void .ctor(Action action, bool flowExecutionContext) { }

	protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler) { }

	internal override void Run(Task task, bool canInlineContinuationTask) { }

	internal static bool get_IsValidLocationForInlining() { }

	private void ExecuteWorkItemHelper() { }

	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	private static void InvokeAction(object state) { }

	protected static ContextCallback GetInvokeActionCallback() { }

	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	internal static void UnsafeScheduleAction(Action action, Task task) { }

	protected static void ThrowAsyncIfNecessary(Exception exc) { }

}

private sealed class AwaitTaskContinuation.<>c // TypeDefIndex: 882
{	public static readonly AwaitTaskContinuation.<>c <>9; // 0x0
	public static WaitCallback <>9__17_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal void <ThrowAsyncIfNecessary>b__17_0(object s) { }

}

