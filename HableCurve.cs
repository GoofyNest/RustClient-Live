public class HableCurve // TypeDefIndex: 13608
{
	[CompilerGeneratedAttribute] 
	private float <whitePoint>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <inverseWhitePoint>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <x0>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <x1>k__BackingField; 
	private readonly HableCurve.Segment[] m_Segments; 
	public readonly HableCurve.Uniforms uniforms; 

	public float whitePoint { get; set; }
	public float inverseWhitePoint { get; set; }
	internal float x0 { get; set; }
	internal float x1 { get; set; }


	[CompilerGeneratedAttribute] 
	public float get_whitePoint() { }

	[CompilerGeneratedAttribute] 
	private void set_whitePoint(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_inverseWhitePoint() { }

	[CompilerGeneratedAttribute] 
	private void set_inverseWhitePoint(float value) { }

	[CompilerGeneratedAttribute] 
	internal float get_x0() { }

	[CompilerGeneratedAttribute] 
	private void set_x0(float value) { }

	[CompilerGeneratedAttribute] 
	internal float get_x1() { }

	[CompilerGeneratedAttribute] 
	private void set_x1(float value) { }

	public void .ctor() { }

	public float Eval(float x) { }

	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) { }

	private void InitSegments(HableCurve.DirectParams srcParams) { }

	private void SolveAB(out float lnA, out float B, float x0, float y0, float m) { }

	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) { }

	private float EvalDerivativeLinearGamma(float m, float b, float g, float x) { }

}

private class HableCurve.Segment // TypeDefIndex: 13609
{
	public float offsetX; 
	public float offsetY; 
	public float scaleX; 
	public float scaleY; 
	public float lnA; 
	public float B; 


	public float Eval(float x) { }

	public void .ctor() { }

}

private struct HableCurve.DirectParams // TypeDefIndex: 13610
{
	internal float x0; 
	internal float y0; 
	internal float x1; 
	internal float y1; 
	internal float W; 
	internal float overshootX; 
	internal float overshootY; 
	internal float gamma; 

}

public class HableCurve.Uniforms // TypeDefIndex: 13611
{
	private HableCurve parent; 

	public Vector4 curve { get; }
	public Vector4 toeSegmentA { get; }
	public Vector4 toeSegmentB { get; }
	public Vector4 midSegmentA { get; }
	public Vector4 midSegmentB { get; }
	public Vector4 shoSegmentA { get; }
	public Vector4 shoSegmentB { get; }


	internal void .ctor(HableCurve parent) { }

	public Vector4 get_curve() { }

	public Vector4 get_toeSegmentA() { }

	public Vector4 get_toeSegmentB() { }

	public Vector4 get_midSegmentA() { }

	public Vector4 get_midSegmentB() { }

	public Vector4 get_shoSegmentA() { }

	public Vector4 get_shoSegmentB() { }

}

