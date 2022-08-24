public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1290
{
	private readonly Task m_task; 

public bool IsCompleted { get; }


internal void .ctor(Task task) { }

public bool get_IsCompleted() { }

public void OnCompleted(Action continuation) { }

public void UnsafeOnCompleted(Action continuation) { }

public void GetResult() { }

internal static void ValidateEnd(Task task) { }

private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

private static void ThrowForNonSuccess(Task task) { }

internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

}

