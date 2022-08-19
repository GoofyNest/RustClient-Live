public struct ValueTask : IEquatable<ValueTask> // TypeDefIndex: 7085
{	// Fields
	private static readonly Task s_canceledTask; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static readonly Task <CompletedTask>k__BackingField; // 0x8
	internal readonly object _obj; // 0x0
	internal readonly short _token; // 0x8
	internal readonly bool _continueOnCapturedContext; // 0xA

	// Properties
	internal static Task CompletedTask { get; }
	public bool IsCompleted { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x230E120 Offset: 0x230D520 VA: 0x18230E120
	internal static Task get_CompletedTask() { }

	// RVA: 0x2408B0 Offset: 0x23FCB0 VA: 0x1802408B0
	public void .ctor(Task task) { }

	// RVA: 0x120430 Offset: 0x11F830 VA: 0x180120430 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2407D0 Offset: 0x23FBD0 VA: 0x1802407D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x240860 Offset: 0x23FC60 VA: 0x180240860 Slot: 4
	public bool Equals(ValueTask other) { }

	// RVA: 0x2408F0 Offset: 0x23FCF0 VA: 0x1802408F0
	public bool get_IsCompleted() { }

	[StackTraceHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2408A0 Offset: 0x23FCA0 VA: 0x1802408A0
	internal void ThrowIfCompletedUnsuccessfully() { }

	// RVA: 0x240880 Offset: 0x23FC80 VA: 0x180240880
	public ValueTaskAwaiter GetAwaiter() { }

	// RVA: 0x230E070 Offset: 0x230D470 VA: 0x18230E070
	private static void .cctor() { }

}

