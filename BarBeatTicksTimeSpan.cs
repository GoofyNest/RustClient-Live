public sealed class BarBeatTicksTimeSpan : ITimeSpan, IComparable, IComparable<BarBeatTicksTimeSpan>, IEquatable<BarBeatTicksTimeSpan> // TypeDefIndex: 7490
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly long <Bars>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly long <Beats>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly long <Ticks>k__BackingField; // 0x20

	// Properties
	public long Bars { get; }
	public long Beats { get; }
	public long Ticks { get; }

	// Methods

	// RVA: 0x1390450 Offset: 0x138F850 VA: 0x181390450
	public void .ctor() { }

	// RVA: 0x1390430 Offset: 0x138F830 VA: 0x181390430
	public void .ctor(long bars, long beats) { }

	// RVA: 0x1390470 Offset: 0x138F870 VA: 0x181390470
	public void .ctor(long bars, long beats, long ticks) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public long get_Bars() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public long get_Beats() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public long get_Ticks() { }

	// RVA: 0x1390570 Offset: 0x138F970 VA: 0x181390570
	public static bool op_Equality(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x13905B0 Offset: 0x138F9B0 VA: 0x1813905B0
	public static bool op_Inequality(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x1390750 Offset: 0x138FB50 VA: 0x181390750
	public static BarBeatTicksTimeSpan op_Subtraction(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x13905F0 Offset: 0x138F9F0 VA: 0x1813905F0
	public static bool op_LessThan(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	// RVA: 0x138FFB0 Offset: 0x138F3B0 VA: 0x18138FFB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1390040 Offset: 0x138F440 VA: 0x181390040 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1390390 Offset: 0x138F790 VA: 0x181390390 Slot: 3
	public override string ToString() { }

	// RVA: 0x13900C0 Offset: 0x138F4C0 VA: 0x1813900C0 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x138FD50 Offset: 0x138F150 VA: 0x18138FD50 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x138FE70 Offset: 0x138F270 VA: 0x18138FE70 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x138FDD0 Offset: 0x138F1D0 VA: 0x18138FDD0 Slot: 7
	public int CompareTo(BarBeatTicksTimeSpan other) { }

	// RVA: 0x138FF80 Offset: 0x138F380 VA: 0x18138FF80 Slot: 8
	public bool Equals(BarBeatTicksTimeSpan other) { }

}

