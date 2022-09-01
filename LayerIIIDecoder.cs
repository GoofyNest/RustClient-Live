internal sealed class LayerIIIDecoder : IFrameDecoder // TypeDefIndex: 7403
{
	private const int SSLIMIT = 18;
	private const int SBLIMIT = 32;
	private static readonly int[][] Slen; 
	internal static readonly int[] Pretab; 
	internal static readonly float[] TwoToNegativeHalfPow; 
	internal static readonly float[] PowerTable; 
	internal static readonly float[][] Io; 
	internal static readonly float[] Tan12; 
	private static int[][] _reorderTable; 
	private static readonly float[] Cs; 
	private static readonly float[] Ca; 
	internal static readonly float[][] Win; 
	internal static readonly int[][][] NrOfSfbBlock; 
	private readonly ABuffer _Buffer; 
	private readonly int _Channels; 
	private readonly SynthesisFilter _Filter1; 
	private readonly SynthesisFilter _Filter2; 
	private readonly int _FirstChannel; 
	private readonly Header _Header; 
	private readonly int[] _Is1D; 
	private readonly float[][] _K; 
	private readonly int _LastChannel; 
	private readonly float[][][] _Lr; 
	private readonly int _MaxGr; 
	private readonly int[] _Nonzero; 
	private readonly float[] _Out1D; 
	private readonly float[][] _Prevblck; 
	private readonly float[][][] _Ro; 
	private readonly ScaleFactorData[] _Scalefac; 
	private readonly SBI[] _SfBandIndex; 
	private readonly int _Sfreq; 
	private readonly Layer3SideInfo _SideInfo; 
	private readonly Bitstream _Stream; 
	private readonly int _WhichChannels; 
	private BitReserve _BitReserve; 
	private int _CheckSumHuff; 
	private int _FrameStart; 
	internal int[] IsPos; 
	internal float[] IsRatio; 
	private int[] _NewSlen; 
	private int _Part2Start; 
	internal float[] Rawout; 
	private float[] _Samples1; 
	private float[] _Samples2; 
	internal int[] ScalefacBuffer; 
	internal ScaleFactorTable Sftable; 
	internal float[] TsOutCopy; 
	internal int[] V; 
	internal int[] W; 
	internal int[] X; 
	internal int[] Y; 


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

