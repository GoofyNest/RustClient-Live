public sealed class SongSelectEvent : SystemCommonEvent // TypeDefIndex: 7571
{
	[CompilerGeneratedAttribute] 
	private SevenBitNumber <Number>k__BackingField; 

	public SevenBitNumber Number { get; set; }


	public void .ctor() { }

	public void .ctor(SevenBitNumber number) { }

	[CompilerGeneratedAttribute] 
	public SevenBitNumber get_Number() { }

	[CompilerGeneratedAttribute] 
	public void set_Number(SevenBitNumber value) { }

	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

}

