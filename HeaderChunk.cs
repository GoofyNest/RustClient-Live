internal sealed class HeaderChunk : MidiChunk // TypeDefIndex: 7508
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ushort <FileFormat>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TimeDivision <TimeDivision>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ushort <TracksNumber>k__BackingField; // 0x28

	// Properties
	public ushort FileFormat { get; set; }
	public TimeDivision TimeDivision { get; set; }
	public ushort TracksNumber { get; set; }

	// Methods

	// RVA: 0x1393AB0 Offset: 0x1392EB0 VA: 0x181393AB0
	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1393AF0 Offset: 0x1392EF0 VA: 0x181393AF0
	public ushort get_FileFormat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1393B10 Offset: 0x1392F10 VA: 0x181393B10
	public void set_FileFormat(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_TimeDivision(TimeDivision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1393B00 Offset: 0x1392F00 VA: 0x181393B00
	public ushort get_TracksNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1393B20 Offset: 0x1392F20 VA: 0x181393B20
	public void set_TracksNumber(ushort value) { }

	// RVA: 0x1393A10 Offset: 0x1392E10 VA: 0x181393A10 Slot: 3
	public override string ToString() { }

	// RVA: 0x1393700 Offset: 0x1392B00 VA: 0x181393700 Slot: 4
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size) { }

}

