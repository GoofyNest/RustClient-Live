public class ImpostorBatch // TypeDefIndex: 10680
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material <Material>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ComputeBuffer <PositionBuffer>k__BackingField; // 0x20
	public NativeList<Vector4> Positions; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ComputeBuffer <ArgsBuffer>k__BackingField; // 0x30
	private NativeList<uint> args; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsDirty>k__BackingField; // 0x40
	private Queue<int> recycle; // 0x48

	// Properties
	public Mesh Mesh { get; set; }
	public Material Material { get; set; }
	public ComputeBuffer PositionBuffer { get; set; }
	public ComputeBuffer ArgsBuffer { get; set; }
	public bool IsDirty { get; set; }
	public int Count { get; }
	public bool Visible { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_Mesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_Material(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Material get_Material() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	private void set_PositionBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public ComputeBuffer get_PositionBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	private void set_ArgsBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public ComputeBuffer get_ArgsBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E53F0 Offset: 0x7E47F0 VA: 0x1807E53F0
	public bool get_IsDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x80DB50 Offset: 0x80CF50 VA: 0x18080DB50
	public void set_IsDirty(bool value) { }

	// RVA: 0x80DAC0 Offset: 0x80CEC0 VA: 0x18080DAC0
	public int get_Count() { }

	// RVA: 0x80DB00 Offset: 0x80CF00 VA: 0x18080DB00
	public bool get_Visible() { }

	// RVA: 0x7CE610 Offset: 0x7CDA10 VA: 0x1807CE610
	private ComputeBuffer SafeRelease(ComputeBuffer buffer) { }

	// RVA: 0x80D4C0 Offset: 0x80C8C0 VA: 0x18080D4C0
	public void Initialize(Mesh mesh, Material material) { }

	// RVA: 0x80D6D0 Offset: 0x80CAD0 VA: 0x18080D6D0
	public void Release() { }

	// RVA: 0x80D3A0 Offset: 0x80C7A0 VA: 0x18080D3A0
	public void AddInstance(ImpostorInstanceData data) { }

	// RVA: 0x80D7B0 Offset: 0x80CBB0 VA: 0x18080D7B0
	public void RemoveInstance(ImpostorInstanceData data) { }

	// RVA: 0x80D8A0 Offset: 0x80CCA0 VA: 0x18080D8A0
	public void UpdateBuffers() { }

	// RVA: 0x80DA50 Offset: 0x80CE50 VA: 0x18080DA50
	public void .ctor() { }

}

