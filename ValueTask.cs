public struct ValueTask : IEquatable<ValueTask> // TypeDefIndex: 7085
{	private static readonly Task s_canceledTask; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static readonly Task <CompletedTask>k__BackingField; // 0x8
	internal readonly object _obj; // 0x0
	internal readonly short _token; // 0x8
	internal readonly bool _continueOnCapturedContext; // 0xA

	internal static Task CompletedTask { get; }
	public bool IsCompleted { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static Task get_CompletedTask() { }

	public void .ctor(Task task) { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public bool Equals(ValueTask other) { }

	public bool get_IsCompleted() { }

	[StackTraceHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void ThrowIfCompletedUnsuccessfully() { }

	public ValueTaskAwaiter GetAwaiter() { }

	private static void .cctor() { }

}

