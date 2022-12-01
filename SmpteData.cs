internal sealed class SmpteData // TypeDefIndex: 7634
{
	private static readonly Dictionary<SmpteFormat, byte> MaxFrames;
	private static readonly SmpteFormat[] Formats;
	private SmpteFormat _format;
	private byte _hours;
	private byte _minutes;
	private byte _seconds;
	private byte _frames;
	private byte _subFrames;

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

	public static SmpteData Read(Func<byte> byteReader, Func<byte, string, byte, byte> valueProcessor) { }

	internal static SmpteFormat GetFormat(byte formatAndHours) { }

	internal static byte GetHours(byte formatAndHours) { }

	private static void .cctor() { }

}

