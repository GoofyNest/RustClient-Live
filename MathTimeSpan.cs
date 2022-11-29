public sealed class MathTimeSpan : ITimeSpan, IComparable // TypeDefIndex: 7505
{
	private static readonly Dictionary<TimeSpanMode, Tuple<string, string>> ModeStrings; 
	[CompilerGeneratedAttribute] 
	private readonly ITimeSpan <TimeSpan1>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly ITimeSpan <TimeSpan2>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly MathOperation <Operation>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly TimeSpanMode <Mode>k__BackingField; 

	public ITimeSpan TimeSpan1 { get; }
	public ITimeSpan TimeSpan2 { get; }
	public MathOperation Operation { get; }
	public TimeSpanMode Mode { get; }


	internal void .ctor(ITimeSpan timeSpan1, ITimeSpan timeSpan2, MathOperation operation, TimeSpanMode mode) { }

	[CompilerGeneratedAttribute] 
	public ITimeSpan get_TimeSpan1() { }

	[CompilerGeneratedAttribute] 
	public ITimeSpan get_TimeSpan2() { }

	[CompilerGeneratedAttribute] 
	public MathOperation get_Operation() { }

	[CompilerGeneratedAttribute] 
	public TimeSpanMode get_Mode() { }

	public static bool op_Equality(MathTimeSpan timeSpan1, MathTimeSpan timeSpan2) { }

	public static bool op_Inequality(MathTimeSpan timeSpan1, MathTimeSpan timeSpan2) { }

	public override string ToString() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	public ITimeSpan Clone() { }

	public int CompareTo(object other) { }

	private static void .cctor() { }

}

