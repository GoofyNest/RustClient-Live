public sealed class TimeSignatureEvent : MetaEvent // TypeDefIndex: 7568
{
	private byte _denominator;
	[CompilerGeneratedAttribute]
	private byte <Numerator>k__BackingField;
	[CompilerGeneratedAttribute]
	private byte <ClocksPerClick>k__BackingField;
	[CompilerGeneratedAttribute]
	private byte <ThirtySecondNotesPerBeat>k__BackingField;

	public byte Numerator { get; set; }
	public byte Denominator { get; set; }
	public byte ClocksPerClick { get; set; }
	public byte ThirtySecondNotesPerBeat { get; set; }


	public void .ctor() { }

	[CompilerGeneratedAttribute]
	public byte get_Numerator() { }

	[CompilerGeneratedAttribute]
	public void set_Numerator(byte value) { }

	public byte get_Denominator() { }

	public void set_Denominator(byte value) { }

	[CompilerGeneratedAttribute]
	public byte get_ClocksPerClick() { }

	[CompilerGeneratedAttribute]
	public void set_ClocksPerClick(byte value) { }

	[CompilerGeneratedAttribute]
	public byte get_ThirtySecondNotesPerBeat() { }

	[CompilerGeneratedAttribute]
	public void set_ThirtySecondNotesPerBeat(byte value) { }

	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

}

