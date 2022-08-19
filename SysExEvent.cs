public abstract class SysExEvent : MidiEvent // TypeDefIndex: 7519
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private byte[] <Data>k__BackingField; // 0x20

	// Properties
	public byte[] Data { get; set; }

	// Methods

	// RVA: 0x1390B10 Offset: 0x138FF10 VA: 0x181390B10
	protected void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_Data(byte[] value) { }

	// RVA: 0x13A31D0 Offset: 0x13A25D0 VA: 0x1813A31D0 Slot: 4
	internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size) { }

}

