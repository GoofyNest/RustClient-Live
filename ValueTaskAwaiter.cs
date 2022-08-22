public struct ValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 7094
{	internal static readonly Action<object> s_invokeActionDelegate; // 0x0
	private readonly ValueTask _value; // 0x0

	public bool IsCompleted { get; }


	internal void .ctor(ValueTask value) { }

	public bool get_IsCompleted() { }

	[StackTraceHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void GetResult() { }

	public void OnCompleted(Action continuation) { }

	public void UnsafeOnCompleted(Action continuation) { }

	private static void .cctor() { }

}

private sealed class ValueTaskAwaiter.<>c // TypeDefIndex: 7095
{	public static readonly ValueTaskAwaiter.<>c <>9; // 0x11BBB


	private static void .cctor() { }

	public void .ctor() { }

	internal void <.cctor>b__9_0(object state) { }

}

