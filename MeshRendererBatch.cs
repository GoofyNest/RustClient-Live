public class MeshRendererBatch : MeshBatch // TypeDefIndex: 11386
{	// Fields
	private Vector3 position; // 0x28
	private Mesh meshBatch; // 0x38
	private MeshFilter meshFilter; // 0x40
	private MeshRenderer meshRenderer; // 0x48
	private MeshRendererData meshData; // 0x50
	private MeshRendererGroup meshGroup; // 0x58
	private MeshRendererLookup meshLookup; // 0x60

	// Properties
	public override int VertexCapacity { get; }
	public override int VertexCutoff { get; }

	// Methods

	// RVA: 0x963A90 Offset: 0x962E90 VA: 0x180963A90 Slot: 10
	public override int get_VertexCapacity() { }

	// RVA: 0x963AF0 Offset: 0x962EF0 VA: 0x180963AF0 Slot: 11
	public override int get_VertexCutoff() { }

	// RVA: 0x9632F0 Offset: 0x9626F0 VA: 0x1809632F0
	protected void Awake() { }

	// RVA: 0x6E88F0 Offset: 0x6E7CF0 VA: 0x1806E88F0
	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0x962FC0 Offset: 0x9623C0 VA: 0x180962FC0
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x963140 Offset: 0x962540 VA: 0x180963140 Slot: 4
	protected override void AllocMemory() { }

	// RVA: 0x963510 Offset: 0x962910 VA: 0x180963510 Slot: 5
	protected override void FreeMemory() { }

	// RVA: 0x963710 Offset: 0x962B10 VA: 0x180963710 Slot: 6
	protected override void RefreshMesh() { }

	// RVA: 0x9631A0 Offset: 0x9625A0 VA: 0x1809631A0 Slot: 7
	protected override void ApplyMesh() { }

	// RVA: 0x963870 Offset: 0x962C70 VA: 0x180963870 Slot: 8
	protected override void ToggleMesh(bool state) { }

	// RVA: 0x963570 Offset: 0x962970 VA: 0x180963570 Slot: 9
	protected override void OnPooled() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

