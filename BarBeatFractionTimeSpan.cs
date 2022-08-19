public sealed class BarBeatFractionTimeSpan : ITimeSpan, IComparable, IComparable<BarBeatFractionTimeSpan>, IEquatable<BarBeatFractionTimeSpan> // TypeDefIndex: 7489
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly long <Bars>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly double <Beats>k__BackingField; // 0x18

	// Properties
	public long Bars { get; }
	public double Beats { get; }

	// Methods

	// RVA: 0x138E470 Offset: 0x138D870 VA: 0x18138E470
	public void .ctor() { }

	// RVA: 0x138E340 Offset: 0x138D740 VA: 0x18138E340
	public void .ctor(long bars, double beats) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public long get_Bars() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB37030 Offset: 0xB36430 VA: 0x180B37030
	public double get_Beats() { }

	// RVA: 0x138E480 Offset: 0x138D880 VA: 0x18138E480
	public static bool op_Equality(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x138E4A0 Offset: 0x138D8A0 VA: 0x18138E4A0
	public static bool op_Inequality(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x138E630 Offset: 0x138DA30 VA: 0x18138E630
	public static BarBeatFractionTimeSpan op_Subtraction(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x138E4D0 Offset: 0x138D8D0 VA: 0x18138E4D0
	public static bool op_LessThan(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

	// RVA: 0x138DEF0 Offset: 0x138D2F0 VA: 0x18138DEF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x138DF50 Offset: 0x138D350 VA: 0x18138DF50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x138E290 Offset: 0x138D690 VA: 0x18138E290 Slot: 3
	public override string ToString() { }

	// RVA: 0x138DFB0 Offset: 0x138D3B0 VA: 0x18138DFB0 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x138DC00 Offset: 0x138D000 VA: 0x18138DC00 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x138DD10 Offset: 0x138D110 VA: 0x18138DD10 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x138DC70 Offset: 0x138D070 VA: 0x18138DC70 Slot: 7
	public int CompareTo(BarBeatFractionTimeSpan other) { }

	// RVA: 0x138DE30 Offset: 0x138D230 VA: 0x18138DE30 Slot: 8
	public bool Equals(BarBeatFractionTimeSpan other) { }

}

