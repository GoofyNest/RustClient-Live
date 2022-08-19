public sealed class MetricTimeSpan : ITimeSpan, IComparable, IComparable<MetricTimeSpan>, IEquatable<MetricTimeSpan> // TypeDefIndex: 7492
{	// Fields
	private readonly TimeSpan _timeSpan; // 0x10

	// Properties
	public long TotalMicroseconds { get; }
	public int Hours { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public int Milliseconds { get; }

	// Methods

	// RVA: 0x139A760 Offset: 0x1399B60 VA: 0x18139A760
	public void .ctor() { }

	// RVA: 0x139A5A0 Offset: 0x13999A0 VA: 0x18139A5A0
	public void .ctor(long totalMicroseconds) { }

	// RVA: 0x139A570 Offset: 0x1399970 VA: 0x18139A570
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x139A620 Offset: 0x1399A20 VA: 0x18139A620
	public void .ctor(int hours, int minutes, int seconds, int milliseconds) { }

	// RVA: 0x139A7F0 Offset: 0x1399BF0 VA: 0x18139A7F0
	public long get_TotalMicroseconds() { }

	// RVA: 0x139A770 Offset: 0x1399B70 VA: 0x18139A770
	public int get_Hours() { }

	// RVA: 0x139A7B0 Offset: 0x1399BB0 VA: 0x18139A7B0
	public int get_Minutes() { }

	// RVA: 0x139A7D0 Offset: 0x1399BD0 VA: 0x18139A7D0
	public int get_Seconds() { }

	// RVA: 0x139A790 Offset: 0x1399B90 VA: 0x18139A790
	public int get_Milliseconds() { }

	// RVA: 0x691430 Offset: 0x690830 VA: 0x180691430
	public static TimeSpan op_Implicit(MetricTimeSpan timeSpan) { }

	// RVA: 0x139A960 Offset: 0x1399D60 VA: 0x18139A960
	public static bool op_Equality(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x139AA10 Offset: 0x1399E10 VA: 0x18139AA10
	public static bool op_Inequality(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x139A810 Offset: 0x1399C10 VA: 0x18139A810
	public static MetricTimeSpan op_Addition(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x139ABD0 Offset: 0x1399FD0 VA: 0x18139ABD0
	public static MetricTimeSpan op_Subtraction(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x139AAC0 Offset: 0x1399EC0 VA: 0x18139AAC0
	public static bool op_LessThan(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

	// RVA: 0x1399EB0 Offset: 0x13992B0 VA: 0x181399EB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x139A020 Offset: 0x1399420 VA: 0x18139A020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x139A300 Offset: 0x1399700 VA: 0x18139A300 Slot: 3
	public override string ToString() { }

	// RVA: 0x139A060 Offset: 0x1399460 VA: 0x18139A060 Slot: 4
	public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

	// RVA: 0x1399D50 Offset: 0x1399150 VA: 0x181399D50 Slot: 5
	public ITimeSpan Clone() { }

	// RVA: 0x1399DF0 Offset: 0x13991F0 VA: 0x181399DF0 Slot: 6
	public int CompareTo(object other) { }

	// RVA: 0x1399DB0 Offset: 0x13991B0 VA: 0x181399DB0 Slot: 7
	public int CompareTo(MetricTimeSpan other) { }

	// RVA: 0x1399F90 Offset: 0x1399390 VA: 0x181399F90 Slot: 8
	public bool Equals(MetricTimeSpan other) { }

}

