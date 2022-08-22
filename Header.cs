public class Header // TypeDefIndex: 1237
{	public string HeaderNamespace; // 0x10
	public bool MustUnderstand; // 0x18
	public string Name; // 0x20
	public object Value; // 0x28

}

public class Header // TypeDefIndex: 7392
{	internal const int MPEG2_LSF = 0;
	internal const int MPEG25_LSF = 2;
	internal const int MPEG1 = 1;
	internal const int STEREO = 0;
	internal const int JOINT_STEREO = 1;
	internal const int DUAL_CHANNEL = 2;
	internal const int SINGLE_CHANNEL = 3;
	internal const int FOURTYFOUR_POINT_ONE = 0;
	internal const int FOURTYEIGHT = 1;
	internal const int THIRTYTWO = 2;
	internal static readonly int[][] Frequencies; // 0x0
	internal static readonly int[][][] Bitrates; // 0x8
	internal static readonly string[][][] BitrateStr; // 0x10
	internal short Checksum; // 0x10
	internal int NSlots; // 0x14
	private Crc16 _CRC; // 0x18
	internal int Framesize; // 0x20
	private bool _Copyright; // 0x24
	private bool _Original; // 0x25
	private int _Headerstring; // 0x28
	private int _Layer; // 0x2C
	private int _ProtectionBit; // 0x30
	private int _BitrateIndex; // 0x34
	private int _PaddingBit; // 0x38
	private int _ModeExtension; // 0x3C
	private int _Mode; // 0x40
	private int _NumberOfSubbands; // 0x44
	private int _IntensityStereoBound; // 0x48
	private int _SampleFrequency; // 0x4C
	private sbyte _Syncmode; // 0x50
	private int _Version; // 0x54


	internal void .ctor() { }

	private void InitBlock() { }

	public override string ToString() { }

	internal void read_header(Bitstream stream, Crc16[] crcp) { }

	internal int Version() { }

	internal int Layer() { }

	internal int bitrate_index() { }

	internal int sample_frequency() { }

	internal int Frequency() { }

	internal int Mode() { }

	internal bool IsProtection() { }

	internal bool IsChecksumOK() { }

	internal int Slots() { }

	internal int mode_extension() { }

	internal int CalculateFrameSize() { }

	internal string LayerAsString() { }

	internal string BitrateAsString() { }

	internal string SampleFrequencyAsString() { }

	internal string ModeAsString() { }

	internal string VersionAsString() { }

	internal int NumberSubbands() { }

	internal int IntensityStereoBound() { }

	private static void .cctor() { }

}

