public class PathInterpolator // TypeDefIndex: 11394
{
	public Vector3[] Points; 
	public Vector3[] Tangents; 
	[CompilerGeneratedAttribute] 
	private int <MinIndex>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <MaxIndex>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <Length>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <StepSize>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <Circular>k__BackingField; 
	protected bool initialized; 

public int MinIndex { get; set; }
public int MaxIndex { get; set; }
public virtual float Length { get; set; }
public virtual float StepSize { get; set; }
public bool Circular { get; set; }
public int DefaultMinIndex { get; }
public int DefaultMaxIndex { get; }
public float StartOffset { get; }
public float EndOffset { get; }


	[CompilerGeneratedAttribute] 
public int get_MinIndex() { }

	[CompilerGeneratedAttribute] 
public void set_MinIndex(int value) { }

	[CompilerGeneratedAttribute] 
public int get_MaxIndex() { }

	[CompilerGeneratedAttribute] 
public void set_MaxIndex(int value) { }

	[CompilerGeneratedAttribute] 
public virtual float get_Length() { }

	[CompilerGeneratedAttribute] 
private void set_Length(float value) { }

	[CompilerGeneratedAttribute] 
public virtual float get_StepSize() { }

	[CompilerGeneratedAttribute] 
private void set_StepSize(float value) { }

	[CompilerGeneratedAttribute] 
public bool get_Circular() { }

	[CompilerGeneratedAttribute] 
private void set_Circular(bool value) { }

public int get_DefaultMinIndex() { }

public int get_DefaultMaxIndex() { }

public float get_StartOffset() { }

public float get_EndOffset() { }

public void .ctor(Vector3[] points) { }

public void .ctor(Vector3[] points, Vector3[] tangents) { }

public void RecalculateTangents() { }

public void RecalculateLength() { }

public void Resample(float distance) { }

public void Smoothen(int iterations, Func<int, float> filter) { }

public void Smoothen(int iterations, Vector3 multipliers, Func<int, float> filter) { }

private void SmoothenIndex(int i, Vector3 multipliers, Func<int, float> filter) { }

public Vector3 GetStartPoint() { }

public Vector3 GetEndPoint() { }

public Vector3 GetStartTangent() { }

public Vector3 GetEndTangent() { }

public Vector3 GetPoint(float distance) { }

public virtual Vector3 GetTangent(float distance) { }

public virtual Vector3 GetPointCubicHermite(float distance) { }

}

