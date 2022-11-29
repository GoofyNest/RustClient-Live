public struct ValueTask : IEquatable<ValueTask> // TypeDefIndex: 7125
{
	private static readonly Task s_canceledTask; 
	[CompilerGeneratedAttribute] 
	private static readonly Task <CompletedTask>k__BackingField; 
	internal readonly object _obj; 
	internal readonly short _token; 
	internal readonly bool _continueOnCapturedContext; 

	internal static Task CompletedTask { get; }
	public bool IsCompleted { get; }


	[CompilerGeneratedAttribute] 
	internal static Task get_CompletedTask() { }

	public void .ctor(Task task) { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public bool Equals(ValueTask other) { }

	public bool get_IsCompleted() { }

	[StackTraceHiddenAttribute] 
	internal void ThrowIfCompletedUnsuccessfully() { }

	public ValueTaskAwaiter GetAwaiter() { }

	private static void .cctor() { }

}

