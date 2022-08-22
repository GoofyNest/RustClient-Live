internal sealed class LayerIIIDecoder : IFrameDecoder // TypeDefIndex: 7402
{	private const int SSLIMIT = 18;
	private const int SBLIMIT = 32;
	private static readonly int[][] Slen; // 0x0
	internal static readonly int[] Pretab; // 0x8
	internal static readonly float[] TwoToNegativeHalfPow; // 0x10
	internal static readonly float[] PowerTable; // 0x18
	internal static readonly float[][] Io; // 0x20
	internal static readonly float[] Tan12; // 0x28
	private static int[][] _reorderTable; // 0x30
	private static readonly float[] Cs; // 0x38
	private static readonly float[] Ca; // 0x40
	internal static readonly float[][] Win; // 0x48
	internal static readonly int[][][] NrOfSfbBlock; // 0x50
	private readonly ABuffer _Buffer; // 0x10
	private readonly int _Channels; // 0x18
	private readonly SynthesisFilter _Filter1; // 0x20
	private readonly SynthesisFilter _Filter2; // 0x28
	private readonly int _FirstChannel; // 0x30
	private readonly Header _Header; // 0x38
	private readonly int[] _Is1D; // 0x40
	private readonly float[][] _K; // 0x48
	private readonly int _LastChannel; // 0x50
	private readonly float[][][] _Lr; // 0x58
	private readonly int _MaxGr; // 0x60
	private readonly int[] _Nonzero; // 0x68
	private readonly float[] _Out1D; // 0x70
	private readonly float[][] _Prevblck; // 0x78
	private readonly float[][][] _Ro; // 0x80
	private readonly ScaleFactorData[] _Scalefac; // 0x88
	private readonly SBI[] _SfBandIndex; // 0x90
	private readonly int _Sfreq; // 0x98
	private readonly Layer3SideInfo _SideInfo; // 0xA0
	private readonly Bitstream _Stream; // 0xA8
	private readonly int _WhichChannels; // 0xB0
	private BitReserve _BitReserve; // 0xB8
	private int _CheckSumHuff; // 0xC0
	private int _FrameStart; // 0xC4
	internal int[] IsPos; // 0xC8
	internal float[] IsRatio; // 0xD0
	private int[] _NewSlen; // 0xD8
	private int _Part2Start; // 0xE0
	internal float[] Rawout; // 0xE8
	private float[] _Samples1; // 0xF0
	private float[] _Samples2; // 0xF8
	internal int[] ScalefacBuffer; // 0x100
	internal ScaleFactorTable Sftable; // 0x108
	internal float[] TsOutCopy; // 0x110
	internal int[] V; // 0x118
	internal int[] W; // 0x120
	internal int[] X; // 0x128
	internal int[] Y; // 0x130


	private static void .cctor() { }

	internal void .ctor(Bitstream stream, Header header, SynthesisFilter filtera, SynthesisFilter filterb, ABuffer buffer, int whichCh) { }

	public void DecodeFrame() { }

	private void InitBlock() { }

	internal void Decode() { }

	private bool ReadSideInfo() { }

	private void ReadScaleFactors(int ch, int gr) { }

	private void GetLSFScaleData(int ch, int gr) { }

	private void GLSFScaleFactors(int ch, int gr) { }

	private void HuffmanDecode(int ch, int gr) { }

	private void GetKStereoValues(int isPos, int ioType, int i) { }

	private void DequantizeSample(float[][] xr, int ch, int gr) { }

	private void Reorder(float[][] xr, int ch, int gr) { }

	private void Stereo(int gr) { }

	private void Antialias(int ch, int gr) { }

	private void Hybrid(int ch, int gr) { }

	private void DoDownMix() { }

	internal void InverseMdct(float[] inValues, float[] outValues, int blockType) { }

	private static float[] CreatePowerTable() { }

	internal static int[] Reorder(int[] scalefacBand) { }

}

