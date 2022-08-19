public sealed class ChannelPrefixEvent : MetaEvent // TypeDefIndex: 7532
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private byte <Channel>k__BackingField; // 0x20

	// Properties
	public byte Channel { get; set; }

	// Methods

	// RVA: 0x1391560 Offset: 0x1390960 VA: 0x181391560
	public void .ctor() { }

	// RVA: 0x1391580 Offset: 0x1390980 VA: 0x181391580
	public void .ctor(byte channel) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public byte get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	public void set_Channel(byte value) { }

	// RVA: 0x13914D0 Offset: 0x13908D0 VA: 0x1813914D0 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x1391470 Offset: 0x1390870 VA: 0x181391470 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1391500 Offset: 0x1390900 VA: 0x181391500 Slot: 3
	public override string ToString() { }

}

