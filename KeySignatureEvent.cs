public sealed class KeySignatureEvent : MetaEvent // TypeDefIndex: 7538
{	// Fields
	private sbyte _key; // 0x20
	private byte _scale; // 0x21

	// Properties
	public sbyte Key { get; set; }
	public byte Scale { get; set; }

	// Methods

	// RVA: 0x1394510 Offset: 0x1393910 VA: 0x181394510
	public void .ctor() { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public sbyte get_Key() { }

	// RVA: 0x1394530 Offset: 0x1393930 VA: 0x181394530
	public void set_Key(sbyte value) { }

	// RVA: 0xB0BB90 Offset: 0xB0AF90 VA: 0x180B0BB90
	public byte get_Scale() { }

	// RVA: 0x13945E0 Offset: 0x13939E0 VA: 0x1813945E0
	public void set_Scale(byte value) { }

	// RVA: 0x1394190 Offset: 0x1393590 VA: 0x181394190
	private int ProcessValue(int value, string property, int min, int max, InvalidMetaEventParameterValuePolicy policy) { }

	// RVA: 0x1394290 Offset: 0x1393690 VA: 0x181394290 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x1394120 Offset: 0x1393520 VA: 0x181394120 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1394490 Offset: 0x1393890 VA: 0x181394490 Slot: 3
	public override string ToString() { }

}

