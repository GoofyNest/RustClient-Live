public sealed class MidiTimeCodeEvent : SystemCommonEvent // TypeDefIndex: 7562
{	// Fields
	private static readonly Dictionary<MidiTimeCodeComponent, byte> ComponentValueMasks; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MidiTimeCodeComponent <Component>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private FourBitNumber <ComponentValue>k__BackingField; // 0x21

	// Properties
	public MidiTimeCodeComponent Component { get; set; }
	public FourBitNumber ComponentValue { get; set; }

	// Methods

	// RVA: 0x139E060 Offset: 0x139D460 VA: 0x18139E060
	public void .ctor() { }

	// RVA: 0x139E080 Offset: 0x139D480 VA: 0x18139E080
	public void .ctor(MidiTimeCodeComponent component, FourBitNumber componentValue) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public MidiTimeCodeComponent get_Component() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	public void set_Component(MidiTimeCodeComponent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BB90 Offset: 0xB0AF90 VA: 0x180B0BB90
	public FourBitNumber get_ComponentValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x139E1C0 Offset: 0x139D5C0 VA: 0x18139E1C0
	public void set_ComponentValue(FourBitNumber value) { }

	// RVA: 0x139DBB0 Offset: 0x139CFB0 VA: 0x18139DBB0 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x139DA40 Offset: 0x139CE40 VA: 0x18139DA40 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x139DEC0 Offset: 0x139D2C0 VA: 0x18139DEC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x139DF40 Offset: 0x139D340 VA: 0x18139DF40
	private static void .cctor() { }

}

