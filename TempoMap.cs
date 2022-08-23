public sealed class TempoMap // TypeDefIndex: 7452
{	public static readonly TempoMap Default; // 0x0
	private ValueLine<TimeSignature> _timeSignatureLine; // 0x10
	private ValueLine<Tempo> _tempoLine; // 0x18
	private readonly List<ITempoMapValuesCache> _valuesCaches; // 0x20
	private bool _isTempoMapReady; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TimeDivision <TimeDivision>k__BackingField; // 0x30

	public TimeDivision TimeDivision { get; set; }
	internal ValueLine<TimeSignature> TimeSignatureLine { get; set; }
	internal ValueLine<Tempo> TempoLine { get; set; }
	internal bool IsTempoMapReady { get; }


	internal void .ctor(TimeDivision timeDivision) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

private sealed class TempoMap.<>c__DisplayClass35_0 // TypeDefIndex: 7453
{	public TempoMapLine tempoMapLine; // 0x10
	public Func<ITempoMapValuesCache, bool> <>9__0; // 0x18


	public void .ctor() { }

	internal bool <InvalidateCaches>b__0(ITempoMapValuesCache c) { }

}

