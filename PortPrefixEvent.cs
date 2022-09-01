public sealed class PortPrefixEvent : MetaEvent // TypeDefIndex: 7542
{
	[CompilerGeneratedAttribute] 
	private byte <Port>k__BackingField; 

	public byte Port { get; set; }


	public void .ctor() { }

	public void .ctor(byte port) { }

	[CompilerGeneratedAttribute] 
	public byte get_Port() { }

	[CompilerGeneratedAttribute] 
	public void set_Port(byte value) { }

	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

}

