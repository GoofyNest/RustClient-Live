internal static class TaskToApm // TypeDefIndex: 890
{

	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	public static void End(IAsyncResult asyncResult) { }

	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-TaskToApm.End<int>
	|
	|-TaskToApm.End<object>
	*/

	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }

}

private sealed class TaskToApm.TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 891
{
	internal readonly Task Task; 
	private readonly object m_state; 
	private readonly bool m_completedSynchronously; 

	private object System.IAsyncResult.AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	private bool System.IAsyncResult.IsCompleted { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }


	internal void .ctor(Task task, object state, bool completedSynchronously) { }

	private object System.IAsyncResult.get_AsyncState() { }

	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	private bool System.IAsyncResult.get_IsCompleted() { }

	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

}

private sealed class TaskToApm.<>c__DisplayClass3_0 // TypeDefIndex: 892
{
	public AsyncCallback callback; 
	public IAsyncResult asyncResult; 


	public void .ctor() { }

	internal void <InvokeCallbackWhenTaskCompletes>b__0() { }

}

