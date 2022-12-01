internal class CancellationCallbackInfo // TypeDefIndex: 753
{
	internal readonly Action<object> Callback;
	internal readonly object StateForCallback;
	internal readonly SynchronizationContext TargetSyncContext;
	internal readonly ExecutionContext TargetExecutionContext;
	internal readonly CancellationTokenSource CancellationTokenSource;
	private static ContextCallback s_executionContextCallback;


	internal void .ctor(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	internal void ExecuteCallback() { }

	private static void ExecutionContextCallback(object obj) { }

}

