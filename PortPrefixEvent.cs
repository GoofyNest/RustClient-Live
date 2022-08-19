public sealed class PortPrefixEvent : MetaEvent // TypeDefIndex: 7541
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private byte <Port>k__BackingField; // 0x20

	// Properties
	public byte Port { get; set; }

	// Methods

	// RVA: 0x139F9B0 Offset: 0x139EDB0 VA: 0x18139F9B0
	public void .ctor() { }

	// RVA: 0x139F980 Offset: 0x139ED80 VA: 0x18139F980
	public void .ctor(byte port) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public byte get_Port() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	public void set_Port(byte value) { }

	// RVA: 0x139F8F0 Offset: 0x139ECF0 VA: 0x18139F8F0 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x139F890 Offset: 0x139EC90 VA: 0x18139F890 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x139F920 Offset: 0x139ED20 VA: 0x18139F920 Slot: 3
	public override string ToString() { }

}

