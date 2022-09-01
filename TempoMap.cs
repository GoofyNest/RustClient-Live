public sealed class TempoMap // TypeDefIndex: 7453
{
	public static readonly TempoMap Default; 
	private ValueLine<TimeSignature> _timeSignatureLine; 
	private ValueLine<Tempo> _tempoLine; 
	private readonly List<ITempoMapValuesCache> _valuesCaches; 
	private bool _isTempoMapReady; 
	[CompilerGeneratedAttribute] 
	private TimeDivision <TimeDivision>k__BackingField; 

	public TimeDivision TimeDivision { get; set; }
	internal ValueLine<TimeSignature> TimeSignatureLine { get; set; }
	internal ValueLine<Tempo> TempoLine { get; set; }
	internal bool IsTempoMapReady { get; }


	internal void .ctor(TimeDivision timeDivision) { }

	[CompilerGeneratedAttribute] 
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] 
	internal void set_TimeDivision(TimeDivision value) { }

	internal ValueLine<TimeSignature> get_TimeSignatureLine() { }

	internal void set_TimeSignatureLine(ValueLine<TimeSignature> value) { }

	internal ValueLine<Tempo> get_TempoLine() { }

	internal void set_TempoLine(ValueLine<Tempo> value) { }

	internal bool get_IsTempoMapReady() { }

	internal TempoMap Flip(long centerTime) { }

	internal TCache GetValuesCache<TCache>() { }
	/* GenericInstMethod :
	|
	|-TempoMap.GetValuesCache<MetricTempoMapValuesCache>
	|-TempoMap.GetValuesCache<object>
	*/

	private void InvalidateCaches(TempoMapLine tempoMapLine) { }

	private void OnTimeSignatureChanged(object sender, EventArgs args) { }

	private void OnTempoChanged(object sender, EventArgs args) { }

	private static void .cctor() { }

}

private sealed class TempoMap.<>c__DisplayClass35_0 // TypeDefIndex: 7454
{
	public TempoMapLine tempoMapLine; 
	public Func<ITempoMapValuesCache, bool> <>9__0; 


	public void .ctor() { }

	internal bool <InvalidateCaches>b__0(ITempoMapValuesCache c) { }

}

