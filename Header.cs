public class Header // TypeDefIndex: 1237
{
	public string HeaderNamespace;
	public bool MustUnderstand;
	public string Name;
	public object Value;

}

public class Header // TypeDefIndex: 7408
{
	internal const int MPEG2_LSF = 0;
	internal const int MPEG25_LSF = 2;
	internal const int MPEG1 = 1;
	internal const int STEREO = 0;
	internal const int JOINT_STEREO = 1;
	internal const int DUAL_CHANNEL = 2;
	internal const int SINGLE_CHANNEL = 3;
	internal const int FOURTYFOUR_POINT_ONE = 0;
	internal const int FOURTYEIGHT = 1;
	internal const int THIRTYTWO = 2;
	internal static readonly int[][] Frequencies;
	internal static readonly int[][][] Bitrates;
	internal static readonly string[][][] BitrateStr;
	internal short Checksum;
	internal int NSlots;
	private Crc16 _CRC;
	internal int Framesize;
	private bool _Copyright;
	private bool _Original;
	private int _Headerstring;
	private int _Layer;
	private int _ProtectionBit;
	private int _BitrateIndex;
	private int _PaddingBit;
	private int _ModeExtension;
	private int _Mode;
	private int _NumberOfSubbands;
	private int _IntensityStereoBound;
	private int _SampleFrequency;
	private sbyte _Syncmode;
	private int _Version;


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

