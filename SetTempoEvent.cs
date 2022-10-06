public sealed class SetTempoEvent : MetaEvent // TypeDefIndex: 7553
{
	private long _microsecondsPerBeat; 

	public long MicrosecondsPerQuarterNote { get; set; }


	public void .ctor() { }

	public long get_MicrosecondsPerQuarterNote() { }

	public void set_MicrosecondsPerQuarterNote(long value) { }

	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

}

