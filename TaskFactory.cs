private sealed class TaskFactory.FromAsyncTrimPromise<TResult, TInstance> : Task<TResult> // TypeDefIndex: 846
{
	internal static readonly AsyncCallback s_completeFromAsyncResult; 
	private TInstance m_thisRef; 
	private Func<TInstance, IAsyncResult, TResult> m_endMethod; 


	internal void .ctor(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-TaskFactory.FromAsyncTrimPromise<int, object>..ctor
	|-TaskFactory.FromAsyncTrimPromise<object, object>..ctor
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..ctor
	*/

	internal static void CompleteFromAsyncResult(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-TaskFactory.FromAsyncTrimPromise<int, object>.CompleteFromAsyncResult
	|
	|-TaskFactory.FromAsyncTrimPromise<object, object>.CompleteFromAsyncResult
	|
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.CompleteFromAsyncResult
	*/

	internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-TaskFactory.FromAsyncTrimPromise<int, object>.Complete
	|
	|-TaskFactory.FromAsyncTrimPromise<object, object>.Complete
	|
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.Complete
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-TaskFactory.FromAsyncTrimPromise<int, object>..cctor
	|
	|-TaskFactory.FromAsyncTrimPromise<object, object>..cctor
	|
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..cctor
	*/

}

private sealed class TaskFactory.<>c__DisplayClass35_0<TResult> // TypeDefIndex: 847
{
	public Func<IAsyncResult, TResult> endFunction; 
	public Action<IAsyncResult> endAction; 
	public Task<TResult> promise; 


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	*/

	internal void <FromAsyncImpl>
	/* GenericInstMethod :
	|
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	*/

}

private sealed class TaskFactory.<>c__DisplayClass35_1<TResult> // TypeDefIndex: 848
{
	public AtomicBoolean invoked; 
	public TaskFactory.<>c


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	*/

	internal void <FromAsyncImpl>
	/* GenericInstMethod :
	|
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	*/

}

private sealed class TaskFactory.<>c__DisplayClass41_0<TResult, TArg1, TArg2> // TypeDefIndex: 849
{
	public Func<IAsyncResult, TResult> endFunction; 
	public Action<IAsyncResult> endAction; 
	public Task<TResult> promise; 


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	*/

	internal void <FromAsyncImpl>
	/* GenericInstMethod :
	|
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	*/

}

private sealed class TaskFactory.<>c__DisplayClass41_1<TResult, TArg1, TArg2> // TypeDefIndex: 850
{
	public AtomicBoolean invoked; 
	public TaskFactory.<>c


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	*/

	internal void <FromAsyncImpl>
	/* GenericInstMethod :
	|
	|-TaskFactory.<>c
	|-TaskFactory.<>c
	*/

}

public class TaskFactory // TypeDefIndex: 884
{
	private CancellationToken m_defaultCancellationToken; 
	private TaskScheduler m_defaultScheduler; 
	private TaskCreationOptions m_defaultCreationOptions; 
	private TaskContinuationOptions m_defaultContinuationOptions; 


	public void .ctor() { }

	public void .ctor(CancellationToken cancellationToken) { }

	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state) { }

	public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state, TaskCreationOptions creationOptions) { }

	public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
	|-TaskFactory.FromAsync<ISocket>
	|-TaskFactory.FromAsync<object>
	*/

	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }

}

internal sealed class TaskFactory.CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction // TypeDefIndex: 885
{
	private IList<Task> _tasks; 
	private int m_firstTaskAlreadyCompleted; 


	public void .ctor(IList<Task> tasks) { }

	public void Invoke(Task completingTask) { }

}

