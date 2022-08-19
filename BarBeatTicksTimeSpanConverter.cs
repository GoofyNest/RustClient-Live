internal sealed class BarBeatTicksTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7469
{	// Methods

	// RVA: 0x138EF70 Offset: 0x138E370 VA: 0x18138EF70 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x138E940 Offset: 0x138DD40 VA: 0x18138E940 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x138E860 Offset: 0x138DC60 VA: 0x18138E860
	private static void CalculateComponents(long totalTicks, TimeSignature timeSignature, short ticksPerQuarterNote, out long bars, out long beats, out long ticks) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class BarBeatTicksTimeSpanConverter.<>c__DisplayClass0_0 // TypeDefIndex: 7470
{	// Fields
	public long time; // 0x10
	public long endTime; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13A5010 Offset: 0x13A4410 VA: 0x1813A5010
	internal bool <ConvertTo>b__0(ValueChange<TimeSignature> v) { }

}

private sealed class BarBeatTicksTimeSpanConverter.<>c__DisplayClass1_0 // TypeDefIndex: 7471
{	// Fields
	public long time; // 0x10
	public long totalTicks; // 0x18
	public long lastTime; // 0x20
	public Func<ValueChange<TimeSignature>, bool> <>9__1; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13A5070 Offset: 0x13A4470 VA: 0x1813A5070
	internal bool <ConvertFrom>b__0(ValueChange<TimeSignature> v) { }

	// RVA: 0x13A50E0 Offset: 0x13A44E0 VA: 0x1813A50E0
	internal bool <ConvertFrom>b__1(ValueChange<TimeSignature> v) { }

}

