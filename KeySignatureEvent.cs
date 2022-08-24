public sealed class KeySignatureEvent : MetaEvent // TypeDefIndex: 7538
{
	private sbyte _key; 
	private byte _scale; 

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

