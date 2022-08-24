internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem // TypeDefIndex: 881
{
	private readonly ExecutionContext m_capturedContext; 
	protected readonly Action m_action; 
	private static ContextCallback s_invokeActionCallback; 

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
{
	public static readonly AwaitTaskContinuation.<>c <>9; 
	public static WaitCallback <>9__17_0; 


private static void .cctor() { }

public void .ctor() { }

internal void <ThrowAsyncIfNecessary>b__17_0(object s) { }

}

