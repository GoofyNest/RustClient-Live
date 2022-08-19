public class SynthesisFilter // TypeDefIndex: 7397
{	// Fields
	private const double MY_PI = 3,14159265358979;
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

	// Properties
	internal float[] Eq { set; }

	// Methods

	// RVA: 0x2260C00 Offset: 0x2260000 VA: 0x182260C00
	internal void .ctor(int channelnumber, float factor, float[] eq0) { }

	// RVA: 0x2266CF0 Offset: 0x22660F0 VA: 0x182266CF0
	internal void set_Eq(float[] value) { }

	// RVA: 0x22602A0 Offset: 0x225F6A0 VA: 0x1822602A0
	private void InitBlock() { }

	// RVA: 0x22602F0 Offset: 0x225F6F0 VA: 0x1822602F0
	internal void Reset() { }

	// RVA: 0x225DDA0 Offset: 0x225D1A0 VA: 0x18225DDA0
	internal void AddSample(float sample, int subbandnumber) { }

	// RVA: 0x225DE00 Offset: 0x225D200 VA: 0x18225DE00
	internal void AddSamples(float[] s) { }

	// RVA: 0x225DE90 Offset: 0x225D290 VA: 0x18225DE90
	private void ComputeNewValues() { }

	// RVA: 0x2261260 Offset: 0x2260660 VA: 0x182261260
	private void compute_pc_samples0(ABuffer buffer) { }

	// RVA: 0x2263600 Offset: 0x2262A00 VA: 0x182263600
	private void compute_pc_samples1(ABuffer buffer) { }

	// RVA: 0x2263BF0 Offset: 0x2262FF0 VA: 0x182263BF0
	private void compute_pc_samples2(ABuffer buffer) { }

	// RVA: 0x22641E0 Offset: 0x22635E0 VA: 0x1822641E0
	private void compute_pc_samples3(ABuffer buffer) { }

	// RVA: 0x22647D0 Offset: 0x2263BD0 VA: 0x1822647D0
	private void compute_pc_samples4(ABuffer buffer) { }

	// RVA: 0x2264DC0 Offset: 0x22641C0 VA: 0x182264DC0
	private void compute_pc_samples5(ABuffer buffer) { }

	// RVA: 0x22653B0 Offset: 0x22647B0 VA: 0x1822653B0
	private void compute_pc_samples6(ABuffer buffer) { }

	// RVA: 0x22659A0 Offset: 0x2264DA0 VA: 0x1822659A0
	private void compute_pc_samples7(ABuffer buffer) { }

	// RVA: 0x2265F90 Offset: 0x2265390 VA: 0x182265F90
	private void compute_pc_samples8(ABuffer buffer) { }

	// RVA: 0x2266580 Offset: 0x2265980 VA: 0x182266580
	private void compute_pc_samples9(ABuffer buffer) { }

	// RVA: 0x2261850 Offset: 0x2260C50 VA: 0x182261850
	private void compute_pc_samples10(ABuffer buffer) { }

	// RVA: 0x2261E40 Offset: 0x2261240 VA: 0x182261E40
	private void compute_pc_samples11(ABuffer buffer) { }

	// RVA: 0x2262430 Offset: 0x2261830 VA: 0x182262430
	private void compute_pc_samples12(ABuffer buffer) { }

	// RVA: 0x2262A20 Offset: 0x2261E20 VA: 0x182262A20
	private void compute_pc_samples13(ABuffer buffer) { }

	// RVA: 0x2263010 Offset: 0x2262410 VA: 0x182263010
	private void compute_pc_samples14(ABuffer buffer) { }

	// RVA: 0x225FCB0 Offset: 0x225F0B0 VA: 0x18225FCB0
	private void Compute_pc_samples15(ABuffer buffer) { }

	// RVA: 0x2266B70 Offset: 0x2265F70 VA: 0x182266B70
	private void compute_pc_samples(ABuffer buffer) { }

	// RVA: 0x2261040 Offset: 0x2260440 VA: 0x182261040
	internal void calculate_pc_samples(ABuffer buffer) { }

	// RVA: 0x22603B0 Offset: 0x225F7B0 VA: 0x1822603B0
	private static float[][] SplitArray(float[] array, int blockSize) { }

	// RVA: 0x22604D0 Offset: 0x225F8D0 VA: 0x1822604D0
	private static float[] SubArray(float[] array, int offs, int len) { }

	// RVA: 0x22605B0 Offset: 0x225F9B0 VA: 0x1822605B0
	private static void .cctor() { }

}

