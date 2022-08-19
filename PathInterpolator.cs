public class PathInterpolator // TypeDefIndex: 11394
{	// Fields
	public Vector3[] Points; // 0x10
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

	// Properties
	public int MinIndex { get; set; }
	public int MaxIndex { get; set; }
	public virtual float Length { get; set; }
	public virtual float StepSize { get; set; }
	public bool Circular { get; set; }
	public int DefaultMinIndex { get; }
	public int DefaultMaxIndex { get; }
	public float StartOffset { get; }
	public float EndOffset { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public int get_MinIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	public void set_MinIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public int get_MaxIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E00 Offset: 0x7E8200 VA: 0x1807E8E00
	public void set_MaxIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x93F110 Offset: 0x93E510 VA: 0x18093F110 Slot: 4
	public virtual float get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x93F180 Offset: 0x93E580 VA: 0x18093F180
	private void set_Length(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x93F170 Offset: 0x93E570 VA: 0x18093F170 Slot: 5
	public virtual float get_StepSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x93F190 Offset: 0x93E590 VA: 0x18093F190
	private void set_StepSize(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0
	public bool get_Circular() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x829920 Offset: 0x828D20 VA: 0x180829920
	private void set_Circular(bool value) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	public int get_DefaultMinIndex() { }

	// RVA: 0x93F090 Offset: 0x93E490 VA: 0x18093F090
	public int get_DefaultMaxIndex() { }

	// RVA: 0x93F120 Offset: 0x93E520 VA: 0x18093F120
	public float get_StartOffset() { }

	// RVA: 0x93F0B0 Offset: 0x93E4B0 VA: 0x18093F0B0
	public float get_EndOffset() { }

	// RVA: 0x93ED60 Offset: 0x93E160 VA: 0x18093ED60
	public void .ctor(Vector3[] points) { }

	// RVA: 0x93EEE0 Offset: 0x93E2E0 VA: 0x18093EEE0
	public void .ctor(Vector3[] points, Vector3[] tangents) { }

	// RVA: 0x93E250 Offset: 0x93D650 VA: 0x18093E250
	public void RecalculateTangents() { }

	// RVA: 0x93E090 Offset: 0x93D490 VA: 0x18093E090
	public void RecalculateLength() { }

	// RVA: 0x93E500 Offset: 0x93D900 VA: 0x18093E500
	public void Resample(float distance) { }

	// RVA: 0x93EBE0 Offset: 0x93DFE0 VA: 0x18093EBE0
	public void Smoothen(int iterations, Func<int, float> filter) { }

	// RVA: 0x93EAC0 Offset: 0x93DEC0 VA: 0x18093EAC0
	public void Smoothen(int iterations, Vector3 multipliers, Func<int, float> filter) { }

	// RVA: 0x93E670 Offset: 0x93DA70 VA: 0x18093E670
	private void SmoothenIndex(int i, Vector3 multipliers, Func<int, float> filter) { }

	// RVA: 0x93DC30 Offset: 0x93D030 VA: 0x18093DC30
	public Vector3 GetStartPoint() { }

	// RVA: 0x93D380 Offset: 0x93C780 VA: 0x18093D380
	public Vector3 GetEndPoint() { }

	// RVA: 0x93DC90 Offset: 0x93D090 VA: 0x18093DC90
	public Vector3 GetStartTangent() { }

	// RVA: 0x93D3E0 Offset: 0x93C7E0 VA: 0x18093D3E0
	public Vector3 GetEndTangent() { }

	// RVA: 0x93D9D0 Offset: 0x93CDD0 VA: 0x18093D9D0
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x93DD40 Offset: 0x93D140 VA: 0x18093DD40 Slot: 6
	public virtual Vector3 GetTangent(float distance) { }

	// RVA: 0x93D490 Offset: 0x93C890 VA: 0x18093D490 Slot: 7
	public virtual Vector3 GetPointCubicHermite(float distance) { }

}

