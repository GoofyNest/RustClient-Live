public class Header // TypeDefIndex: 1237
{	// Fields
	public string HeaderNamespace; // 0x10
	public bool MustUnderstand; // 0x18
	public string Name; // 0x20
	public object Value; // 0x28

}

public class Header // TypeDefIndex: 7392
{	// Fields
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

	// Methods

	// RVA: 0x5FC750 Offset: 0x5FBB50 VA: 0x1805FC750
	internal void .ctor() { }

	// RVA: 0x5F7B10 Offset: 0x5F6F10 VA: 0x1805F7B10
	private void InitBlock() { }

	// RVA: 0x5F7D70 Offset: 0x5F7170 VA: 0x1805F7D70 Slot: 3
	public override string ToString() { }

	// RVA: 0x5FC7A0 Offset: 0x5FBBA0 VA: 0x1805FC7A0
	internal void read_header(Bitstream stream, Crc16[] crcp) { }

	// RVA: 0x5F8160 Offset: 0x5F7560 VA: 0x1805F8160
	internal int Version() { }

	// RVA: 0x5F7BF0 Offset: 0x5F6FF0 VA: 0x1805F7BF0
	internal int Layer() { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780
	internal int bitrate_index() { }

	// RVA: 0x5B35A0 Offset: 0x5B29A0 VA: 0x1805B35A0
	internal int sample_frequency() { }

	// RVA: 0x5F7A60 Offset: 0x5F6E60 VA: 0x1805F7A60
	internal int Frequency() { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	internal int Mode() { }

	// RVA: 0x5F7B70 Offset: 0x5F6F70 VA: 0x1805F7B70
	internal bool IsProtection() { }

	// RVA: 0x5F7B20 Offset: 0x5F6F20 VA: 0x1805F7B20
	internal bool IsChecksumOK() { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	internal int Slots() { }

	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790
	internal int mode_extension() { }

	// RVA: 0x5F7750 Offset: 0x5F6B50 VA: 0x1805F7750
	internal int CalculateFrameSize() { }

	// RVA: 0x5F7B80 Offset: 0x5F6F80 VA: 0x1805F7B80
	internal string LayerAsString() { }

	// RVA: 0x5F7680 Offset: 0x5F6A80 VA: 0x1805F7680
	internal string BitrateAsString() { }

	// RVA: 0x5F7CA0 Offset: 0x5F70A0 VA: 0x1805F7CA0
	internal string SampleFrequencyAsString() { }

	// RVA: 0x5F7C00 Offset: 0x5F7000 VA: 0x1805F7C00
	internal string ModeAsString() { }

	// RVA: 0x5F80F0 Offset: 0x5F74F0 VA: 0x1805F80F0
	internal string VersionAsString() { }

	// RVA: 0x5F7C90 Offset: 0x5F7090 VA: 0x1805F7C90
	internal int NumberSubbands() { }

	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	internal int IntensityStereoBound() { }

	// RVA: 0x5F8170 Offset: 0x5F7570 VA: 0x1805F8170
	private static void .cctor() { }

}

