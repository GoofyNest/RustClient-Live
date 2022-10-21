public struct ValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 7130
{
	internal static readonly Action<object> s_invokeActionDelegate; 
	private readonly ValueTask _value; 

	public bool IsCompleted { get; }


	internal void .ctor(ValueTask value) { }

	public bool get_IsCompleted() { }

	[StackTraceHiddenAttribute] 
	public void GetResult() { }

	public void OnCompleted(Action continuation) { }

	public void UnsafeOnCompleted(Action continuation) { }

	private static void .cctor() { }

}

private sealed class ValueTaskAwaiter.<>c // TypeDefIndex: 7131
{
	public static readonly ValueTaskAwaiter.<>c <>9; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <.cctor>b__9_0(object state) { }

}

