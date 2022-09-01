public sealed class ChannelPrefixEvent : MetaEvent // TypeDefIndex: 7533
{
	[CompilerGeneratedAttribute] 
	private byte <Channel>k__BackingField; 

	public byte Channel { get; set; }


	public void .ctor() { }

	public void .ctor(byte channel) { }

	[CompilerGeneratedAttribute] 
	public byte get_Channel() { }

	[CompilerGeneratedAttribute] 
	public void set_Channel(byte value) { }

	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

}

