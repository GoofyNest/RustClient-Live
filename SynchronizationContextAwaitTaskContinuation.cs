internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 877
{
	private static readonly SendOrPostCallback s_postCallback;
	private static ContextCallback s_postActionCallback;
	private readonly SynchronizationContext m_syncContext;


	internal void .ctor(SynchronizationContext context, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	internal sealed override void Run(Task task, bool canInlineContinuationTask) { }

	private static void PostAction(object state) { }

	private static ContextCallback GetPostActionCallback() { }

	private static void .cctor() { }

}

private sealed class SynchronizationContextAwaitTaskContinuation.<>c // TypeDefIndex: 878
{
	public static readonly SynchronizationContextAwaitTaskContinuation.<>c <>9;


	private static void .cctor() { }

	public void .ctor() { }

	internal void <.cctor>

}

