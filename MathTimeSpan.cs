public sealed class MathTimeSpan : ITimeSpan, IComparable // TypeDefIndex: 7491
{	// Fields
	private static readonly Dictionary<TimeSpanMode, Tuple<string, string>> ModeStrings; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly ITimeSpan <TimeSpan1>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly ITimeSpan <TimeSpan2>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly MathOperation <Operation>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly TimeSpanMode <Mode>k__BackingField; // 0x24

	// Properties
	public ITimeSpan TimeSpan1 { get; }
	public ITimeSpan TimeSpan2 { get; }
	public MathOperation Operation { get; }
	public TimeSpanMode Mode { get; }

	// Methods

	// RVA: 0x1395C70 Offset: 0x1395070 VA: 0x181395C70
	internal void .ctor(ITimeSpan timeSpan1, ITimeSpan timeSpan2, MathOperation operation, TimeSpanMode mode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public ITimeSpan get_TimeSpan1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public ITimeSpan get_TimeSpan2() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public MathOperation get_Operation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public TimeSpanMode get_Mode() { }

	// RVA: 0x1395CE0 Offset: 0x13950E0 VA: 0x181395CE0
	public static bool op_Equality(MathTimeSpan timeSpan1, MathTimeSpan timeSpan2) { }

	// RVA: 0x1395D80 Offset: 0x1395180 VA: 0x181395D80
	public static bool op_Inequality(MathTimeSpan timeSpan1, MathTimeSpan timeSpan2) { }

	// RVA: 0x13958C0 Offset: 0x1394CC0 VA: 0x1813958C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1395610 Offset: 0x1394A10 VA: 0x181395610 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1395720 Offset: 0x1394B20 VA: 0x181395720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13957D0 Offset: 0x1394BD0 VA: 0x1813957D0 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x13954D0 Offset: 0x13948D0 VA: 0x1813954D0 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x13955B0 Offset: 0x13949B0 VA: 0x1813955B0 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x1395B70 Offset: 0x1394F70 VA: 0x181395B70
	private static void .cctor() { }

}

