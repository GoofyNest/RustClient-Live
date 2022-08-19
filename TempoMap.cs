public sealed class TempoMap // TypeDefIndex: 7452
{	// Fields
	public static readonly TempoMap Default; // 0x0
	private ValueLine<TimeSignature> _timeSignatureLine; // 0x10
	private ValueLine<Tempo> _tempoLine; // 0x18
	private readonly List<ITempoMapValuesCache> _valuesCaches; // 0x20
	private bool _isTempoMapReady; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TimeDivision <TimeDivision>k__BackingField; // 0x30

	// Properties
	public TimeDivision TimeDivision { get; set; }
	internal ValueLine<TimeSignature> TimeSignatureLine { get; set; }
	internal ValueLine<Tempo> TempoLine { get; set; }
	internal bool IsTempoMapReady { get; }

	// Methods

	// RVA: 0x21FC5B0 Offset: 0x21FB9B0 VA: 0x1821FC5B0
	internal void .ctor(TimeDivision timeDivision) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	internal void set_TimeDivision(TimeDivision value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal ValueLine<TimeSignature> get_TimeSignatureLine() { }

	// RVA: 0x21FC800 Offset: 0x21FBC00 VA: 0x1821FC800
	internal void set_TimeSignatureLine(ValueLine<TimeSignature> value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal ValueLine<Tempo> get_TempoLine() { }

	// RVA: 0x21FC710 Offset: 0x21FBB10 VA: 0x1821FC710
	internal void set_TempoLine(ValueLine<Tempo> value) { }

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0
	internal bool get_IsTempoMapReady() { }

	// RVA: 0x21FC1A0 Offset: 0x21FB5A0 VA: 0x1821FC1A0
	internal TempoMap Flip(long centerTime) { }

	// RVA: -1 Offset: -1
	internal TCache GetValuesCache<TCache>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C09B0 Offset: 0x14BFDB0 VA: 0x1814C09B0
	|-TempoMap.GetValuesCache<MetricTempoMapValuesCache>
	|-TempoMap.GetValuesCache<object>
	*/

	// RVA: 0x21FC270 Offset: 0x21FB670 VA: 0x1821FC270
	private void InvalidateCaches(TempoMapLine tempoMapLine) { }

	// RVA: 0x21FC520 Offset: 0x21FB920 VA: 0x1821FC520
	private void OnTimeSignatureChanged(object sender, EventArgs args) { }

	// RVA: 0x21FC510 Offset: 0x21FB910 VA: 0x1821FC510
	private void OnTempoChanged(object sender, EventArgs args) { }

	// RVA: 0x21FC530 Offset: 0x21FB930 VA: 0x1821FC530
	private static void .cctor() { }

}

private sealed class TempoMap.<>c__DisplayClass35_0 // TypeDefIndex: 7453
{	// Fields
	public TempoMapLine tempoMapLine; // 0x10
	public Func<ITempoMapValuesCache, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x21FFF00 Offset: 0x21FF300 VA: 0x1821FFF00
	internal bool <InvalidateCaches>b__0(ITempoMapValuesCache c) { }

}

