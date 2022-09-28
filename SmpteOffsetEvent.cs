public sealed class SmpteOffsetEvent : MetaEvent // TypeDefIndex: 7520
{
	private SmpteData _smpteData; 

	public SmpteFormat Format { get; set; }
	public byte Hours { get; set; }
	public byte Minutes { get; set; }
	public byte Seconds { get; set; }
	public byte Frames { get; set; }
	public byte SubFrames { get; set; }


	public void .ctor() { }

	public void .ctor(SmpteFormat format, byte hours, byte minutes, byte seconds, byte frames, byte subFrames) { }

	public SmpteFormat get_Format() { }

	public void set_Format(SmpteFormat value) { }

	public byte get_Hours() { }

	public void set_Hours(byte value) { }

	public byte get_Minutes() { }

	public void set_Minutes(byte value) { }

	public byte get_Seconds() { }

	public void set_Seconds(byte value) { }

	public byte get_Frames() { }

	public void set_Frames(byte value) { }

	public byte get_SubFrames() { }

	public void set_SubFrames(byte value) { }

	private byte ProcessValue(byte value, string property, byte max, InvalidMetaEventParameterValuePolicy policy) { }

	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

}

private sealed class SmpteOffsetEvent.<>c__DisplayClass22_0 // TypeDefIndex: 7521
{
	public SmpteOffsetEvent <>4__this; 
	public ReadingSettings settings; 


	public void .ctor() { }

	internal byte <ReadContent>b__0(byte value, string propertyName, byte max) { }

}

