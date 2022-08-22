public abstract class ChannelEvent : MidiEvent // TypeDefIndex: 7515
{	internal byte _dataByte1; // 0x20
	internal byte _dataByte2; // 0x21
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private FourBitNumber <Channel>k__BackingField; // 0x22

	public FourBitNumber Channel { get; set; }


	protected void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public FourBitNumber get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Channel(FourBitNumber value) { }

	protected byte ReadDataByte(MidiReader reader, ReadingSettings settings) { }

}

