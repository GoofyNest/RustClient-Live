public abstract class ChannelEvent : MidiEvent // TypeDefIndex: 7515
{
	internal byte _dataByte1; 
	internal byte _dataByte2; 
	[CompilerGeneratedAttribute] 
	private FourBitNumber <Channel>k__BackingField; 

	public FourBitNumber Channel { get; set; }


	protected void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] 
	public FourBitNumber get_Channel() { }

	[CompilerGeneratedAttribute] 
	public void set_Channel(FourBitNumber value) { }

	protected byte ReadDataByte(MidiReader reader, ReadingSettings settings) { }

}

