public class SynthesisFilter // TypeDefIndex: 7413
{
	private const double MY_PI = 3,14159265358979;
	private static readonly float Cos164;
	private static readonly float Cos364;
	private static readonly float Cos564;
	private static readonly float Cos764;
	private static readonly float Cos964;
	private static readonly float Cos1164;
	private static readonly float Cos1364;
	private static readonly float Cos1564;
	private static readonly float Cos1764;
	private static readonly float Cos1964;
	private static readonly float Cos2164;
	private static readonly float Cos2364;
	private static readonly float Cos2564;
	private static readonly float Cos2764;
	private static readonly float Cos2964;
	private static readonly float Cos3164;
	private static readonly float Cos132;
	private static readonly float Cos332;
	private static readonly float Cos532;
	private static readonly float Cos732;
	private static readonly float Cos932;
	private static readonly float Cos1132;
	private static readonly float Cos1332;
	private static readonly float Cos1532;
	private static readonly float Cos116;
	private static readonly float Cos316;
	private static readonly float Cos516;
	private static readonly float Cos716;
	private static readonly float Cos18;
	private static readonly float Cos38;
	private static readonly float Cos14;
	private static float[] _d;
	private static float[][] _d16;
	private static readonly float[] DData;
	private readonly int _Channel;
	private readonly float[] _Samples;
	private readonly float _Scalefactor;
	private readonly float[] _V1;
	private readonly float[] _V2;
	private float[] _TmpOut;
	private float[] _ActualV;
	private int _ActualWritePos;
	private float[] _Eq;

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

