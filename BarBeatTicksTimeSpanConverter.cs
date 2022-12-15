internal sealed class BarBeatTicksTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7487
{

	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	private static void CalculateComponents(long totalTicks, TimeSignature timeSignature, short ticksPerQuarterNote, out long bars, out long beats, out long ticks) { }

	public void .ctor() { }

}

private sealed class BarBeatTicksTimeSpanConverter.<>c__DisplayClass0_0 // TypeDefIndex: 7488
{
	public long time;
	public long endTime;


	public void .ctor() { }

	internal bool <ConvertTo>

}

private sealed class BarBeatTicksTimeSpanConverter.<>c__DisplayClass1_0 // TypeDefIndex: 7489
{
	public long time;
	public long totalTicks;
	public long lastTime;
	public Func<ValueChange<TimeSignature>, bool> <>9__1;


	public void .ctor() { }

	internal bool <ConvertFrom>

	internal bool <ConvertFrom>

}

