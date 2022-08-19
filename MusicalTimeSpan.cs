public sealed class MusicalTimeSpan : ITimeSpan, IComparable, IComparable<MusicalTimeSpan>, IEquatable<MusicalTimeSpan> // TypeDefIndex: 7494
{	// Fields
	public static readonly MusicalTimeSpan Whole; // 0x0
	public static readonly MusicalTimeSpan Half; // 0x8
	public static readonly MusicalTimeSpan Quarter; // 0x10
	public static readonly MusicalTimeSpan Eighth; // 0x18
	public static readonly MusicalTimeSpan Sixteenth; // 0x20
	public static readonly MusicalTimeSpan ThirtySecond; // 0x28
	public static readonly MusicalTimeSpan SixtyFourth; // 0x30
	private static readonly int FractionPartMultiplier; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly long <Numerator>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly long <Denominator>k__BackingField; // 0x18

	// Properties
	public long Numerator { get; }
	public long Denominator { get; }

	// Methods

	// RVA: 0x21F9C00 Offset: 0x21F9000 VA: 0x1821F9C00
	public void .ctor() { }

	// RVA: 0x21F9B00 Offset: 0x21F8F00 VA: 0x1821F9B00
	public void .ctor(long fraction) { }

	// RVA: 0x21F9B30 Offset: 0x21F8F30 VA: 0x1821F9B30
	public void .ctor(long numerator, long denominator, bool simplify = True) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public long get_Numerator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public long get_Denominator() { }

	// RVA: 0x21F8E90 Offset: 0x21F8290 VA: 0x1821F8E90
	public MusicalTimeSpan Dotted(int dotsCount) { }

	// RVA: 0x21F94E0 Offset: 0x21F88E0 VA: 0x1821F94E0
	public MusicalTimeSpan Tuplet(int tupletNotesCount, int tupletSpaceSize) { }

	// RVA: 0x21F9160 Offset: 0x21F8560 VA: 0x1821F9160
	private static void ReduceToCommonDenominator(MusicalTimeSpan fraction1, MusicalTimeSpan fraction2, out long numerator1, out long numerator2, out long denominator) { }

	// RVA: 0x21F9C90 Offset: 0x21F9090 VA: 0x1821F9C90
	public static bool op_Equality(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21F9D60 Offset: 0x21F9160 VA: 0x1821F9D60
	public static bool op_Inequality(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21F9E70 Offset: 0x21F9270 VA: 0x1821F9E70
	public static MusicalTimeSpan op_Subtraction(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	// RVA: 0x21F8F50 Offset: 0x21F8350 VA: 0x1821F8F50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21F9110 Offset: 0x21F8510 VA: 0x1821F9110 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21F9460 Offset: 0x21F8860 VA: 0x1821F9460 Slot: 3
	public override string ToString() { }

	// RVA: 0x21F91F0 Offset: 0x21F85F0 VA: 0x1821F91F0 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x21F8C00 Offset: 0x21F8000 VA: 0x1821F8C00 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x21F8C80 Offset: 0x21F8080 VA: 0x1821F8C80 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x21F8DC0 Offset: 0x21F81C0 VA: 0x1821F8DC0 Slot: 7
	public int CompareTo(MusicalTimeSpan other) { }

	// RVA: 0x21F9050 Offset: 0x21F8450 VA: 0x1821F9050 Slot: 8
	public bool Equals(MusicalTimeSpan other) { }

	// RVA: 0x21F95B0 Offset: 0x21F89B0 VA: 0x1821F95B0
	private static void .cctor() { }

}

