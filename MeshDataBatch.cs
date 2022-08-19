public class MeshDataBatch : MeshBatch // TypeDefIndex: 11385
{	// Fields
	private Vector3 position; // 0x28
	private Mesh meshBatch; // 0x38
	private MeshFilter meshFilter; // 0x40
	private MeshRenderer meshRenderer; // 0x48
	private MeshData meshData; // 0x50
	private MeshGroup meshGroup; // 0x58

	// Properties
	public override int VertexCapacity { get; }
	public override int VertexCutoff { get; }

	// Methods

	// RVA: 0x95D080 Offset: 0x95C480 VA: 0x18095D080 Slot: 10
	public override int get_VertexCapacity() { }

	// RVA: 0x95D0E0 Offset: 0x95C4E0 VA: 0x18095D0E0 Slot: 11
	public override int get_VertexCutoff() { }

	// RVA: 0x95CBC0 Offset: 0x95BFC0 VA: 0x18095CBC0
	protected void Awake() { }

	// RVA: 0x6E88F0 Offset: 0x6E7CF0 VA: 0x1806E88F0
	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0x95C950 Offset: 0x95BD50 VA: 0x18095C950
	public void Add(MeshInstance instance) { }

	// RVA: 0x95CA80 Offset: 0x95BE80 VA: 0x18095CA80 Slot: 4
	protected override void AllocMemory() { }

	// RVA: 0x95CCA0 Offset: 0x95C0A0 VA: 0x18095CCA0 Slot: 5
	protected override void FreeMemory() { }

	// RVA: 0x95CE10 Offset: 0x95C210 VA: 0x18095CE10 Slot: 6
	protected override void RefreshMesh() { }

	// RVA: 0x95CAE0 Offset: 0x95BEE0 VA: 0x18095CAE0 Slot: 7
	protected override void ApplyMesh() { }

	// RVA: 0x95CF20 Offset: 0x95C320 VA: 0x18095CF20 Slot: 8
	protected override void ToggleMesh(bool state) { }

	// RVA: 0x95CD00 Offset: 0x95C100 VA: 0x18095CD00 Slot: 9
	protected override void OnPooled() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

