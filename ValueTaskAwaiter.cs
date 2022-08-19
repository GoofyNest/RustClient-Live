public struct ValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 7094
{	// Fields
	internal static readonly Action<object> s_invokeActionDelegate; // 0x0
	private readonly ValueTask _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x1E3BC0 Offset: 0x1E2FC0 VA: 0x1801E3BC0
	internal void .ctor(ValueTask value) { }

	// RVA: 0x2407A0 Offset: 0x23FBA0 VA: 0x1802407A0
	public bool get_IsCompleted() { }

	[StackTraceHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2404F0 Offset: 0x23F8F0 VA: 0x1802404F0
	public void GetResult() { }

	// RVA: 0x240500 Offset: 0x23F900 VA: 0x180240500 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x240650 Offset: 0x23FA50 VA: 0x180240650 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x230DFA0 Offset: 0x230D3A0 VA: 0x18230DFA0
	private static void .cctor() { }

}

private sealed class ValueTaskAwaiter.<>c // TypeDefIndex: 7095
{	// Fields
	public static readonly ValueTaskAwaiter.<>c <>9; // 0x11BBB

	// Methods

	// RVA: 0x230DDF0 Offset: 0x230D1F0 VA: 0x18230DDF0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x230DD90 Offset: 0x230D190 VA: 0x18230DD90
	internal void <.cctor>b__9_0(object state) { }

}

