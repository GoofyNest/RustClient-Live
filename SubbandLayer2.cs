public class SubbandLayer2 : ASubband // TypeDefIndex: 7422
{
	internal static readonly float[] Grouping5Bits;
	internal static readonly float[] Grouping7Bits;
	internal static readonly float[] Grouping10Bits;
	internal static readonly int[] TableAb1Codelength;
	internal static readonly float[][] TableAb1Groupingtables;
	internal static readonly float[] TableAb1Factor;
	internal static readonly float[] TableAb1C;
	internal static readonly float[] TableAb1D;
	internal static readonly float[][] TableAb234Groupingtables;
	internal static readonly int[] TableAb2Codelength;
	internal static readonly float[] TableAb2Factor;
	internal static readonly float[] TableAb2C;
	internal static readonly float[] TableAb2D;
	internal static readonly int[] TableAb3Codelength;
	internal static readonly float[] TableAb3Factor;
	internal static readonly float[] TableAb3C;
	internal static readonly float[] TableAb3D;
	internal static readonly int[] TableAb4Codelength;
	internal static readonly float[] TableAb4Factor;
	internal static readonly float[] TableAb4C;
	internal static readonly float[] TableAb4D;
	internal static readonly int[] TableCdCodelength;
	internal static readonly float[][] TableCdGroupingtables;
	internal static readonly float[] TableCdFactor;
	internal static readonly float[] TableCdC;
	internal static readonly float[] TableCdD;
	protected int Allocation;
	protected readonly float[] CFactor;
	protected readonly int[] Codelength;
	protected float[] D;
	protected readonly float[] Factor;
	protected float[][] Groupingtable;
	protected int Groupnumber;
	protected int Samplenumber;
	protected float[] Samples;
	protected float Scalefactor1;
	protected float Scalefactor2;
	protected float Scalefactor3;
	protected int Scfsi;
	protected readonly int Subbandnumber;


	internal void .ctor(int subbandnumber) { }

	protected virtual int GetAllocationLength(Header header) { }

	protected virtual void PrepareForSampleRead(Header header, int allocation, int channel, float[] factor, int[] codelength, float[] c, float[] d) { }

	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	internal virtual void ReadScaleFactorSelection(Bitstream stream, Crc16 crc) { }

	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	internal override bool ReadSampleData(Bitstream stream) { }

	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

	private static void .cctor() { }

}

