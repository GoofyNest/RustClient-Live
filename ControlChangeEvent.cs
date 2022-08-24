public sealed class ControlChangeEvent : ChannelEvent // TypeDefIndex: 7523
{
	public SevenBitNumber ControlNumber { get; }
	public SevenBitNumber ControlValue { get; }


	public void .ctor() { }

	public SevenBitNumber get_ControlNumber() { }

	public SevenBitNumber get_ControlValue() { }

	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

}

