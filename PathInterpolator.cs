public class PathInterpolator // TypeDefIndex: 11394
{	public Vector3[] Points; // 0x10
	public Vector3[] Tangents; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <MinIndex>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <MaxIndex>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Length>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <StepSize>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Circular>k__BackingField; // 0x30
	protected bool initialized; // 0x31

	public int MinIndex { get; set; }
	public int MaxIndex { get; set; }
	public virtual float Length { get; set; }
	public virtual float StepSize { get; set; }
	public bool Circular { get; set; }
	public int DefaultMinIndex { get; }
	public int DefaultMaxIndex { get; }
	public float StartOffset { get; }
	public float EndOffset { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_MinIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_MinIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_MaxIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_MaxIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public virtual float get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Length(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public virtual float get_StepSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_StepSize(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_Circular() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

