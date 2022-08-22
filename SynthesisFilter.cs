public class SynthesisFilter // TypeDefIndex: 7397
{	private const double MY_PI = 3,14159265358979;
	private static readonly float Cos164; // 0x0
	private static readonly float Cos364; // 0x4
	private static readonly float Cos564; // 0x8
	private static readonly float Cos764; // 0xC
	private static readonly float Cos964; // 0x10
	private static readonly float Cos1164; // 0x14
	private static readonly float Cos1364; // 0x18
	private static readonly float Cos1564; // 0x1C
	private static readonly float Cos1764; // 0x20
	private static readonly float Cos1964; // 0x24
	private static readonly float Cos2164; // 0x28
	private static readonly float Cos2364; // 0x2C
	private static readonly float Cos2564; // 0x30
	private static readonly float Cos2764; // 0x34
	private static readonly float Cos2964; // 0x38
	private static readonly float Cos3164; // 0x3C
	private static readonly float Cos132; // 0x40
	private static readonly float Cos332; // 0x44
	private static readonly float Cos532; // 0x48
	private static readonly float Cos732; // 0x4C
	private static readonly float Cos932; // 0x50
	private static readonly float Cos1132; // 0x54
	private static readonly float Cos1332; // 0x58
	private static readonly float Cos1532; // 0x5C
	private static readonly float Cos116; // 0x60
	private static readonly float Cos316; // 0x64
	private static readonly float Cos516; // 0x68
	private static readonly float Cos716; // 0x6C
	private static readonly float Cos18; // 0x70
	private static readonly float Cos38; // 0x74
	private static readonly float Cos14; // 0x78
	private static float[] _d; // 0x80
	private static float[][] _d16; // 0x88
	private static readonly float[] DData; // 0x90
	private readonly int _Channel; // 0x10
	private readonly float[] _Samples; // 0x18
	private readonly float _Scalefactor; // 0x20
	private readonly float[] _V1; // 0x28
	private readonly float[] _V2; // 0x30
	private float[] _TmpOut; // 0x38
	private float[] _ActualV; // 0x40
	private int _ActualWritePos; // 0x48
	private float[] _Eq; // 0x50

	internal float[] Eq { set; }


	internal void .ctor(int channelnumber, float factor, float[] eq0) { }

	internal void set_Eq(float[] value) { }

	private void InitBlock() { }

	internal void Reset() { }

	internal void AddSample(float sample, int subbandnumber) { }

	internal void AddSamples(float[] s) { }

	private void ComputeNewValues() { }

	private void compute_pc_samples0(ABuffer buffer) { }

	private void compute_pc_samples1(ABuffer buffer) { }

	private void compute_pc_samples2(ABuffer buffer) { }

	private void compute_pc_samples3(ABuffer buffer) { }

	private void compute_pc_samples4(ABuffer buffer) { }

	private void compute_pc_samples5(ABuffer buffer) { }

	private void compute_pc_samples6(ABuffer buffer) { }

	private void compute_pc_samples7(ABuffer buffer) { }

	private void compute_pc_samples8(ABuffer buffer) { }

	private void compute_pc_samples9(ABuffer buffer) { }

	private void compute_pc_samples10(ABuffer buffer) { }

	private void compute_pc_samples11(ABuffer buffer) { }

	private void compute_pc_samples12(ABuffer buffer) { }

	private void compute_pc_samples13(ABuffer buffer) { }

	private void compute_pc_samples14(ABuffer buffer) { }

	private void Compute_pc_samples15(ABuffer buffer) { }

	private void compute_pc_samples(ABuffer buffer) { }

	internal void calculate_pc_samples(ABuffer buffer) { }

	private static float[][] SplitArray(float[] array, int blockSize) { }

	private static float[] SubArray(float[] array, int offs, int len) { }

	private static void .cctor() { }

}

