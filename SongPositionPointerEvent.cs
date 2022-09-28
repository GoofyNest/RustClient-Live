public sealed class SongPositionPointerEvent : SystemCommonEvent // TypeDefIndex: 7536
{
	private SevenBitNumber _lsb; 
	private SevenBitNumber _msb; 

	public ushort PointerValue { get; set; }


	public void .ctor() { }

	public void .ctor(ushort pointerValue) { }

	public ushort get_PointerValue() { }

	public void set_PointerValue(ushort value) { }

	private SevenBitNumber ProcessValue(byte value, string property, InvalidSystemCommonEventParameterValuePolicy policy) { }

	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

}

