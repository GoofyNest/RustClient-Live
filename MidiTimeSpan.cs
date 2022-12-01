public sealed class MidiTimeSpan : ITimeSpan, IComparable, IComparable<MidiTimeSpan>, IEquatable<MidiTimeSpan> // TypeDefIndex: 7509
{
	[CompilerGeneratedAttribute]
	private readonly long <TimeSpan>k__BackingField;

	public long TimeSpan { get; }


	public void .ctor() { }

	public void .ctor(long timeSpan) { }

	[CompilerGeneratedAttribute]
	public long get_TimeSpan() { }

	public static MidiTimeSpan op_Explicit(long timeSpan) { }

	public static bool op_Equality(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	public static bool op_Inequality(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	public static MidiTimeSpan op_Subtraction(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	public override string ToString() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	public ITimeSpan Clone() { }

	public int CompareTo(object other) { }

	public int CompareTo(MidiTimeSpan other) { }

	public bool Equals(MidiTimeSpan other) { }

}

