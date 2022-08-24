public sealed class BarBeatFractionTimeSpan : ITimeSpan, IComparable, IComparable<BarBeatFractionTimeSpan>, IEquatable<BarBeatFractionTimeSpan> // TypeDefIndex: 7489
{
	[CompilerGeneratedAttribute] 
	private readonly long <Bars>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly double <Beats>k__BackingField; 

public long Bars { get; }
public double Beats { get; }


public void .ctor() { }

public void .ctor(long bars, double beats) { }

	[CompilerGeneratedAttribute] 
public long get_Bars() { }

	[CompilerGeneratedAttribute] 
public double get_Beats() { }

public static bool op_Equality(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

public static bool op_Inequality(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

public static BarBeatFractionTimeSpan op_Subtraction(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

public static bool op_LessThan(BarBeatFractionTimeSpan timeSpan1, BarBeatFractionTimeSpan timeSpan2) { }

public override bool Equals(object obj) { }

public override int GetHashCode() { }

public override string ToString() { }

public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

public ITimeSpan Clone() { }

public int CompareTo(object other) { }

public int CompareTo(BarBeatFractionTimeSpan other) { }

public bool Equals(BarBeatFractionTimeSpan other) { }

}

