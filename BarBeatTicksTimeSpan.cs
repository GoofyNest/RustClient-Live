public sealed class BarBeatTicksTimeSpan : ITimeSpan, IComparable, IComparable<BarBeatTicksTimeSpan>, IEquatable<BarBeatTicksTimeSpan> // TypeDefIndex: 7498
{
	[CompilerGeneratedAttribute] 
	private readonly long <Bars>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly long <Beats>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly long <Ticks>k__BackingField; 

	public long Bars { get; }
	public long Beats { get; }
	public long Ticks { get; }


	public void .ctor() { }

	public void .ctor(long bars, long beats) { }

	public void .ctor(long bars, long beats, long ticks) { }

	[CompilerGeneratedAttribute] 
	public long get_Bars() { }

	[CompilerGeneratedAttribute] 
	public long get_Beats() { }

	[CompilerGeneratedAttribute] 
	public long get_Ticks() { }

	public static bool op_Equality(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	public static bool op_Inequality(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	public static BarBeatTicksTimeSpan op_Subtraction(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	public static bool op_LessThan(BarBeatTicksTimeSpan timeSpan1, BarBeatTicksTimeSpan timeSpan2) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	public ITimeSpan Clone() { }

	public int CompareTo(object other) { }

	public int CompareTo(BarBeatTicksTimeSpan other) { }

	public bool Equals(BarBeatTicksTimeSpan other) { }

}

