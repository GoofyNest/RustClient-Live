public class HableCurve // TypeDefIndex: 11854
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <whitePoint>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <inverseWhitePoint>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <x0>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <x1>k__BackingField; // 0x1C
	private readonly HableCurve.Segment[] m_Segments; // 0x20
	public readonly HableCurve.Uniforms uniforms; // 0x28

	// Properties
	public float whitePoint { get; set; }
	public float inverseWhitePoint { get; set; }
	internal float x0 { get; set; }
	internal float x1 { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9EF9F0 Offset: 0x9EEDF0 VA: 0x1809EF9F0
	public float get_whitePoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9EFA10 Offset: 0x9EEE10 VA: 0x1809EFA10
	private void set_whitePoint(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE866A0 Offset: 0xE85AA0 VA: 0x180E866A0
	public float get_inverseWhitePoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE866B0 Offset: 0xE85AB0 VA: 0x180E866B0
	private void set_inverseWhitePoint(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772410 Offset: 0x771810 VA: 0x180772410
	internal float get_x0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772450 Offset: 0x771850 VA: 0x180772450
	private void set_x0(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7723E0 Offset: 0x7717E0 VA: 0x1807723E0
	internal float get_x1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772420 Offset: 0x771820 VA: 0x180772420
	private void set_x1(float value) { }

	// RVA: 0x1012190 Offset: 0x1011590 VA: 0x181012190
	public void .ctor() { }

	// RVA: 0x1011810 Offset: 0x1010C10 VA: 0x181011810
	public float Eval(float x) { }

	// RVA: 0x1011EA0 Offset: 0x10112A0 VA: 0x181011EA0
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) { }

	// RVA: 0x1011880 Offset: 0x1010C80 VA: 0x181011880
	private void InitSegments(HableCurve.DirectParams srcParams) { }

	// RVA: 0x10120D0 Offset: 0x10114D0 VA: 0x1810120D0
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m) { }

	// RVA: 0x1011710 Offset: 0x1010B10 VA: 0x181011710
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) { }

	// RVA: 0x1011770 Offset: 0x1010B70 VA: 0x181011770
	private float EvalDerivativeLinearGamma(float m, float b, float g, float x) { }

}

private class HableCurve.Segment // TypeDefIndex: 11855
{	// Fields
	public float offsetX; // 0x10
	public float offsetY; // 0x14
	public float scaleX; // 0x18
	public float scaleY; // 0x1C
	public float lnA; // 0x20
	public float B; // 0x24

	// Methods

	// RVA: 0x1027C20 Offset: 0x1027020 VA: 0x181027C20
	public float Eval(float x) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private struct HableCurve.DirectParams // TypeDefIndex: 11856
{	// Fields
	internal float x0; // 0x0
	internal float y0; // 0x4
	internal float x1; // 0x8
	internal float y1; // 0xC
	internal float W; // 0x10
	internal float overshootX; // 0x14
	internal float overshootY; // 0x18
	internal float gamma; // 0x1C

}

public class HableCurve.Uniforms // TypeDefIndex: 11857
{	// Fields
	private HableCurve parent; // 0x10

	// Properties
	public Vector4 curve { get; }
	public Vector4 toeSegmentA { get; }
	public Vector4 toeSegmentB { get; }
	public Vector4 midSegmentA { get; }
	public Vector4 midSegmentB { get; }
	public Vector4 shoSegmentA { get; }
	public Vector4 shoSegmentB { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(HableCurve parent) { }

	// RVA: 0x10284B0 Offset: 0x10278B0 VA: 0x1810284B0
	public Vector4 get_curve() { }

	// RVA: 0x1028700 Offset: 0x1027B00 VA: 0x181028700
	public Vector4 get_toeSegmentA() { }

	// RVA: 0x1028780 Offset: 0x1027B80 VA: 0x181028780
	public Vector4 get_toeSegmentB() { }

	// RVA: 0x1028500 Offset: 0x1027900 VA: 0x181028500
	public Vector4 get_midSegmentA() { }

	// RVA: 0x1028580 Offset: 0x1027980 VA: 0x181028580
	public Vector4 get_midSegmentB() { }

	// RVA: 0x1028600 Offset: 0x1027A00 VA: 0x181028600
	public Vector4 get_shoSegmentA() { }

	// RVA: 0x1028680 Offset: 0x1027A80 VA: 0x181028680
	public Vector4 get_shoSegmentB() { }

}

