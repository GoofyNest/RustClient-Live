public sealed class KeySignatureEvent : MetaEvent // TypeDefIndex: 7538
{	private sbyte _key; // 0x20
	private byte _scale; // 0x21

	public sbyte Key { get; set; }
	public byte Scale { get; set; }


	public void .ctor() { }

	public sbyte get_Key() { }

	public void set_Key(sbyte value) { }

	public byte get_Scale() { }

	public void set_Scale(byte value) { }

	private int ProcessValue(int value, string property, int min, int max, InvalidMetaEventParameterValuePolicy policy) { }

	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

}

