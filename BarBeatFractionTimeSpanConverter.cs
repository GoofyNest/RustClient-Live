internal sealed class BarBeatFractionTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7466
{	// Methods

	// RVA: 0x138CFC0 Offset: 0x138C3C0 VA: 0x18138CFC0 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x138C860 Offset: 0x138BC60 VA: 0x18138C860 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x138C700 Offset: 0x138BB00 VA: 0x18138C700
	private static void CalculateComponents(long totalTicks, TimeSignature timeSignature, short ticksPerQuarterNote, out long bars, out long beats, out double fraction) { }

	// RVA: 0x138C7F0 Offset: 0x138BBF0 VA: 0x18138C7F0
	private static long ConvertFractionToTicks(double fraction, long beatLength) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class BarBeatFractionTimeSpanConverter.<>c__DisplayClass1_0 // TypeDefIndex: 7467
{	// Fields
	public long time; // 0x10
	public long endTime; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13A5130 Offset: 0x13A4530 VA: 0x1813A5130
	internal bool <ConvertTo>b__0(ValueChange<TimeSignature> v) { }

}

private sealed class BarBeatFractionTimeSpanConverter.<>c__DisplayClass2_0 // TypeDefIndex: 7468
{	// Fields
	public long time; // 0x10
	public long totalTicks; // 0x18
	public long lastTime; // 0x20
	public Func<ValueChange<TimeSignature>, bool> <>9__1; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13A52A0 Offset: 0x13A46A0 VA: 0x1813A52A0
	internal bool <ConvertFrom>b__0(ValueChange<TimeSignature> v) { }

	// RVA: 0x13A5310 Offset: 0x13A4710 VA: 0x1813A5310
	internal bool <ConvertFrom>b__1(ValueChange<TimeSignature> v) { }

}

