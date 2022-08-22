public class FoliageGridBatch : MeshBatch // TypeDefIndex: 11370
{	private Vector3 position; // 0x28
	private Mesh meshBatch; // 0x38
	private MeshFilter meshFilter; // 0x40
	private MeshRenderer meshRenderer; // 0x48
	private FoliageGridMeshData meshData; // 0x50
	private MeshGroup meshGroup; // 0x58

	public override int VertexCapacity { get; }
	public override int VertexCutoff { get; }


	public override int get_VertexCapacity() { }

	public override int get_VertexCutoff() { }

	protected void Awake() { }

	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	public void Add(MeshInstance instance) { }

	protected override void AllocMemory() { }

	protected override void FreeMemory() { }

	protected override void RefreshMesh() { }

	protected override void ApplyMesh() { }

	protected override void ToggleMesh(bool state) { }

	protected override void OnPooled() { }

	public void .ctor() { }

}

