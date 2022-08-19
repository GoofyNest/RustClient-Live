public sealed class UnknownMetaEvent : MetaEvent // TypeDefIndex: 7551
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly byte <StatusByte>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private byte[] <Data>k__BackingField; // 0x28

	// Properties
	public byte StatusByte { get; }
	public byte[] Data { get; set; }

	// Methods

	// RVA: 0x13A61F0 Offset: 0x13A55F0 VA: 0x1813A61F0
	internal void .ctor(byte statusByte) { }

	// RVA: 0x13A6230 Offset: 0x13A5630 VA: 0x1813A6230
	internal void .ctor(byte statusByte, byte[] data) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public byte get_StatusByte() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	private void set_Data(byte[] value) { }

	// RVA: 0x13A60B0 Offset: 0x13A54B0 VA: 0x1813A60B0 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A6010 Offset: 0x13A5410 VA: 0x1813A6010 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A6190 Offset: 0x13A5590 VA: 0x1813A6190 Slot: 3
	public override string ToString() { }

}

