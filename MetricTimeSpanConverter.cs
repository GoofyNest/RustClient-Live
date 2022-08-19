internal sealed class MetricTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7475
{	// Methods

	// RVA: 0x1397030 Offset: 0x1396430 VA: 0x181397030 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x1396DE0 Offset: 0x13961E0 VA: 0x181396DE0 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x1397300 Offset: 0x1396700 VA: 0x181397300
	private static MetricTimeSpan TicksToMetricTimeSpan(long timeSpan, TempoMap tempoMap) { }

	// RVA: 0x1397150 Offset: 0x1396550 VA: 0x181397150
	private static long MetricTimeSpanToTicks(MetricTimeSpan timeSpan, TempoMap tempoMap) { }

	// RVA: 0x1397140 Offset: 0x1396540 VA: 0x181397140
	private static double GetMicroseconds(long time, double microsecondsPerTick) { }

	// RVA: 0x1395F90 Offset: 0x1395390 VA: 0x181395F90
	private static long RoundMicroseconds(double microseconds) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class MetricTimeSpanConverter.<>c // TypeDefIndex: 7476
{	// Fields
	public static readonly MetricTimeSpanConverter.<>c <>9; // 0x0
	public static Func<MetricTempoMapValuesCache.AccumulatedMicroseconds, long> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x13A5450 Offset: 0x13A4850 VA: 0x1813A5450
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6C6330 Offset: 0x6C5730 VA: 0x1806C6330
	internal long <TicksToMetricTimeSpan>b__2_0(MetricTempoMapValuesCache.AccumulatedMicroseconds m) { }

}

private sealed class MetricTimeSpanConverter.<>c__DisplayClass3_0 // TypeDefIndex: 7477
{	// Fields
	public long timeMicroseconds; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13A5360 Offset: 0x13A4760 VA: 0x1813A5360
	internal bool <MetricTimeSpanToTicks>b__0(MetricTempoMapValuesCache.AccumulatedMicroseconds m) { }

}

