public static class TimeSpanUtilities // TypeDefIndex: 7499
{	// Fields
	private static readonly Dictionary<TimeSpanType, Parsing<ITimeSpan>> Parsers; // 0x0
	private static readonly Dictionary<TimeSpanType, ITimeSpan> MaximumTimeSpans; // 0x8
	private static readonly Dictionary<TimeSpanType, ITimeSpan> ZeroTimeSpans; // 0x10

	// Methods

	// RVA: 0x21FD800 Offset: 0x21FCC00 VA: 0x1821FD800
	internal static ITimeSpan Subtract(ITimeSpan timeSpan1, ITimeSpan timeSpan2, TimeSpanMode mode) { }

	// RVA: -1 Offset: -1
	private static Parsing<ITimeSpan> GetParsing<TTimeSpan>(Parsing<TTimeSpan> parsing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1259C30 Offset: 0x1259030 VA: 0x181259C30
	|-TimeSpanUtilities.GetParsing<BarBeatFractionTimeSpan>
	|-TimeSpanUtilities.GetParsing<BarBeatTicksTimeSpan>
	|-TimeSpanUtilities.GetParsing<MetricTimeSpan>
	|-TimeSpanUtilities.GetParsing<MidiTimeSpan>
	|-TimeSpanUtilities.GetParsing<MusicalTimeSpan>
	|-TimeSpanUtilities.GetParsing<object>
	*/

	// RVA: 0x21FD8A0 Offset: 0x21FCCA0 VA: 0x1821FD8A0
	private static void .cctor() { }

}

private sealed class TimeSpanUtilities.<>c__DisplayClass12_0<TTimeSpan> // TypeDefIndex: 7500
{	// Fields
	public Parsing<TTimeSpan> parsing; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-TimeSpanUtilities.<>c__DisplayClass12_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal ParsingResult <GetParsing>b__0(string input, out ITimeSpan timeSpan) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F7660 Offset: 0x17F6A60 VA: 0x1817F7660
	|-TimeSpanUtilities.<>c__DisplayClass12_0<object>.<GetParsing>b__0
	*/

}

