public static class TimeSpanUtilities // TypeDefIndex: 7507
{
	private static readonly Dictionary<TimeSpanType, Parsing<ITimeSpan>> Parsers; 
	private static readonly Dictionary<TimeSpanType, ITimeSpan> MaximumTimeSpans; 
	private static readonly Dictionary<TimeSpanType, ITimeSpan> ZeroTimeSpans; 


	internal static ITimeSpan Subtract(ITimeSpan timeSpan1, ITimeSpan timeSpan2, TimeSpanMode mode) { }

	private static Parsing<ITimeSpan> GetParsing<TTimeSpan>(Parsing<TTimeSpan> parsing) { }
	/* GenericInstMethod :
	|
	|-TimeSpanUtilities.GetParsing<BarBeatFractionTimeSpan>
	|-TimeSpanUtilities.GetParsing<BarBeatTicksTimeSpan>
	|-TimeSpanUtilities.GetParsing<MetricTimeSpan>
	|-TimeSpanUtilities.GetParsing<MidiTimeSpan>
	|-TimeSpanUtilities.GetParsing<MusicalTimeSpan>
	|-TimeSpanUtilities.GetParsing<object>
	*/

	private static void .cctor() { }

}

private sealed class TimeSpanUtilities.<>c__DisplayClass12_0<TTimeSpan> // TypeDefIndex: 7508
{
	public Parsing<TTimeSpan> parsing; 


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-TimeSpanUtilities.<>c__DisplayClass12_0<object>..ctor
	*/

	internal ParsingResult <GetParsing>b__0(string input, out ITimeSpan timeSpan) { }
	/* GenericInstMethod :
	|
	|-TimeSpanUtilities.<>c__DisplayClass12_0<object>.<GetParsing>b__0
	*/

}

