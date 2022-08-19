public abstract class ChannelEvent : MidiEvent // TypeDefIndex: 7515
{	// Fields
	internal byte _dataByte1; // 0x20
	internal byte _dataByte2; // 0x21
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private FourBitNumber <Channel>k__BackingField; // 0x22

	// Properties
	public FourBitNumber Channel { get; set; }

	// Methods

	// RVA: 0x1390B10 Offset: 0x138FF10 VA: 0x181390B10
	protected void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BBA0 Offset: 0xB0AFA0 VA: 0x180B0BBA0
	public FourBitNumber get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE2ADA0 Offset: 0xE2A1A0 VA: 0x180E2ADA0
	public void set_Channel(FourBitNumber value) { }

	// RVA: 0x1391310 Offset: 0x1390710 VA: 0x181391310
	protected byte ReadDataByte(MidiReader reader, ReadingSettings settings) { }

}

