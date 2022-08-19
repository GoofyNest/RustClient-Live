internal sealed class MathTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7474
{	// Fields
	private static readonly Dictionary<TimeSpanMode, Func<MathTimeSpan, long, TempoMap, long>> Converters; // 0x1880

	// Methods

	// RVA: 0x1395340 Offset: 0x1394740 VA: 0x181395340 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x13951C0 Offset: 0x13945C0 VA: 0x1813951C0 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x1394A10 Offset: 0x1393E10 VA: 0x181394A10
	private static long ConvertFromLengthLength(MathTimeSpan mathTimeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x1394D00 Offset: 0x1394100 VA: 0x181394D00
	private static long ConvertFromTimeLength(MathTimeSpan mathTimeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x1394F40 Offset: 0x1394340 VA: 0x181394F40
	private static long ConvertFromTimeTime(MathTimeSpan mathTimeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13953A0 Offset: 0x13947A0 VA: 0x1813953A0
	private static void .cctor() { }

}

