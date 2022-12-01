public sealed class MusicalTimeSpan : ITimeSpan, IComparable, IComparable<MusicalTimeSpan>, IEquatable<MusicalTimeSpan> // TypeDefIndex: 7510
{
	public static readonly MusicalTimeSpan Whole;
	public static readonly MusicalTimeSpan Half;
	public static readonly MusicalTimeSpan Quarter;
	public static readonly MusicalTimeSpan Eighth;
	public static readonly MusicalTimeSpan Sixteenth;
	public static readonly MusicalTimeSpan ThirtySecond;
	public static readonly MusicalTimeSpan SixtyFourth;
	private static readonly int FractionPartMultiplier;
	[CompilerGeneratedAttribute]
	private readonly long <Numerator>k__BackingField;
	[CompilerGeneratedAttribute]
	private readonly long <Denominator>k__BackingField;

	public long Numerator { get; }
	public long Denominator { get; }


	public void .ctor() { }

	public void .ctor(long fraction) { }

	public void .ctor(long numerator, long denominator, bool simplify = True) { }

	[CompilerGeneratedAttribute]
	public long get_Numerator() { }

	[CompilerGeneratedAttribute]
	public long get_Denominator() { }

	public MusicalTimeSpan Dotted(int dotsCount) { }

	public MusicalTimeSpan Tuplet(int tupletNotesCount, int tupletSpaceSize) { }

	private static void ReduceToCommonDenominator(MusicalTimeSpan fraction1, MusicalTimeSpan fraction2, out long numerator1, out long numerator2, out long denominator) { }

	public static bool op_Equality(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	public static bool op_Inequality(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	public static MusicalTimeSpan op_Subtraction(MusicalTimeSpan timeSpan1, MusicalTimeSpan timeSpan2) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	public ITimeSpan Clone() { }

	public int CompareTo(object other) { }

	public int CompareTo(MusicalTimeSpan other) { }

	public bool Equals(MusicalTimeSpan other) { }

	private static void .cctor() { }

}

