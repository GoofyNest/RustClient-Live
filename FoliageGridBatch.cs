public class FoliageGridBatch : MeshBatch // TypeDefIndex: 11370
{	// Fields
	private Vector3 position; // 0x28
	private Mesh meshBatch; // 0x38
	private MeshFilter meshFilter; // 0x40
	private MeshRenderer meshRenderer; // 0x48
	private FoliageGridMeshData meshData; // 0x50
	private MeshGroup meshGroup; // 0x58

	// Properties
	public override int VertexCapacity { get; }
	public override int VertexCutoff { get; }

	// Methods

	// RVA: 0x6E8BC0 Offset: 0x6E7FC0 VA: 0x1806E8BC0 Slot: 10
	public override int get_VertexCapacity() { }

	// RVA: 0x6E8C20 Offset: 0x6E8020 VA: 0x1806E8C20 Slot: 11
	public override int get_VertexCutoff() { }

	// RVA: 0x6E8640 Offset: 0x6E7A40 VA: 0x1806E8640
	protected void Awake() { }

	// RVA: 0x6E88F0 Offset: 0x6E7CF0 VA: 0x1806E88F0
	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0x6E8210 Offset: 0x6E7610 VA: 0x1806E8210
	public void Add(MeshInstance instance) { }

	// RVA: 0x6E8350 Offset: 0x6E7750 VA: 0x1806E8350 Slot: 4
	protected override void AllocMemory() { }

	// RVA: 0x6E8700 Offset: 0x6E7B00 VA: 0x1806E8700 Slot: 5
	protected override void FreeMemory() { }

	// RVA: 0x6E8870 Offset: 0x6E7C70 VA: 0x1806E8870 Slot: 6
	protected override void RefreshMesh() { }

	// RVA: 0x6E8460 Offset: 0x6E7860 VA: 0x1806E8460 Slot: 7
	protected override void ApplyMesh() { }

	// RVA: 0x6E8A60 Offset: 0x6E7E60 VA: 0x1806E8A60 Slot: 8
	protected override void ToggleMesh(bool state) { }

	// RVA: 0x6E8760 Offset: 0x6E7B60 VA: 0x1806E8760 Slot: 9
	protected override void OnPooled() { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

