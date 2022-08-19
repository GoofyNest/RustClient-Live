public sealed class MidiTimeSpan : ITimeSpan, IComparable, IComparable<MidiTimeSpan>, IEquatable<MidiTimeSpan> // TypeDefIndex: 7493
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly long <TimeSpan>k__BackingField; // 0x10

	// Properties
	public long TimeSpan { get; }

	// Methods

	// RVA: 0x21F76A0 Offset: 0x21F6AA0 VA: 0x1821F76A0
	public void .ctor() { }

	// RVA: 0x21F7610 Offset: 0x21F6A10 VA: 0x1821F7610
	public void .ctor(long timeSpan) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public long get_TimeSpan() { }

	// RVA: 0x21F76E0 Offset: 0x21F6AE0 VA: 0x1821F76E0
	public static MidiTimeSpan op_Explicit(long timeSpan) { }

	// RVA: 0x21F76B0 Offset: 0x21F6AB0 VA: 0x1821F76B0
	public static bool op_Equality(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21F7740 Offset: 0x21F6B40 VA: 0x1821F7740
	public static bool op_Inequality(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21F7770 Offset: 0x21F6B70 VA: 0x1821F7770
	public static MidiTimeSpan op_Subtraction(MidiTimeSpan timeSpan1, MidiTimeSpan timeSpan2) { }

	// RVA: 0x21F75F0 Offset: 0x21F69F0 VA: 0x1821F75F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21F73D0 Offset: 0x21F67D0 VA: 0x1821F73D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21F7450 Offset: 0x21F6850 VA: 0x1821F7450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21F7470 Offset: 0x21F6870 VA: 0x1821F7470 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x21F71E0 Offset: 0x21F65E0 VA: 0x1821F71E0 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x21F72C0 Offset: 0x21F66C0 VA: 0x1821F72C0 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x21F7240 Offset: 0x21F6640 VA: 0x1821F7240 Slot: 7
	public int CompareTo(MidiTimeSpan other) { }

	// RVA: 0x21F73B0 Offset: 0x21F67B0 VA: 0x1821F73B0 Slot: 8
	public bool Equals(MidiTimeSpan other) { }

}

