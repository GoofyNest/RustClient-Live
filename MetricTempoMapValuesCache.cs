internal sealed class MetricTempoMapValuesCache : ITempoMapValuesCache // TypeDefIndex: 7495
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MetricTempoMapValuesCache.AccumulatedMicroseconds[] <Microseconds>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private double <DefaultMicrosecondsPerTick>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private double <DefaultTicksPerMicrosecond>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IEnumerable<TempoMapLine> <InvalidateOnLines>k__BackingField; // 0x28

	// Properties
	public MetricTempoMapValuesCache.AccumulatedMicroseconds[] Microseconds { get; set; }
	public double DefaultMicrosecondsPerTick { get; set; }
	public double DefaultTicksPerMicrosecond { get; set; }
	public IEnumerable<TempoMapLine> InvalidateOnLines { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public MetricTempoMapValuesCache.AccumulatedMicroseconds[] get_Microseconds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_Microseconds(MetricTempoMapValuesCache.AccumulatedMicroseconds[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB37030 Offset: 0xB36430 VA: 0x180B37030
	public double get_DefaultMicrosecondsPerTick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB37050 Offset: 0xB36450 VA: 0x180B37050
	private void set_DefaultMicrosecondsPerTick(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1075DB0 Offset: 0x10751B0 VA: 0x181075DB0
	public double get_DefaultTicksPerMicrosecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1075FE0 Offset: 0x10753E0 VA: 0x181075FE0
	private void set_DefaultTicksPerMicrosecond(double value) { }

	// RVA: 0x1396900 Offset: 0x1395D00 VA: 0x181396900
	private static double GetMicroseconds(long time, Tempo tempo, short ticksPerQuarterNote) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 4
	public IEnumerable<TempoMapLine> get_InvalidateOnLines() { }

	// RVA: 0x1396940 Offset: 0x1395D40 VA: 0x181396940 Slot: 5
	public void Invalidate(TempoMap tempoMap) { }

	// RVA: 0x1396D80 Offset: 0x1396180 VA: 0x181396D80
	public void .ctor() { }

}

internal sealed class MetricTempoMapValuesCache.AccumulatedMicroseconds // TypeDefIndex: 7496
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly long <Time>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly double <Microseconds>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly double <MicrosecondsPerTick>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly double <TicksPerMicrosecond>k__BackingField; // 0x28

	// Properties
	public long Time { get; }
	public double Microseconds { get; }
	public double MicrosecondsPerTick { get; }
	public double TicksPerMicrosecond { get; }

	// Methods

	// RVA: 0x138C600 Offset: 0x138BA00 VA: 0x18138C600
	public void .ctor(long time, double microseconds, double microsecondsPerTick) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public long get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB37030 Offset: 0xB36430 VA: 0x180B37030
	public double get_Microseconds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1075DB0 Offset: 0x10751B0 VA: 0x181075DB0
	public double get_MicrosecondsPerTick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E10 Offset: 0x497210 VA: 0x180497E10
	public double get_TicksPerMicrosecond() { }

}

