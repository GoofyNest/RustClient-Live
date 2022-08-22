public class MeshRendererBatch : MeshBatch // TypeDefIndex: 11386
{	private Vector3 position; // 0x28
	private Mesh meshBatch; // 0x38
	private MeshFilter meshFilter; // 0x40
	private MeshRenderer meshRenderer; // 0x48
	private MeshRendererData meshData; // 0x50
	private MeshRendererGroup meshGroup; // 0x58
	private MeshRendererLookup meshLookup; // 0x60

	public override int VertexCapacity { get; }
	public override int VertexCutoff { get; }


	public override int get_VertexCapacity() { }

	public override int get_VertexCutoff() { }

	protected void Awake() { }

	public void Setup(Vector3 position, Material material, ShadowCastingMode shadows, int layer) { }

	public void Add(MeshRendererInstance instance) { }

	protected override void AllocMemory() { }

	protected override void FreeMemory() { }

	protected override void RefreshMesh() { }

	protected override void ApplyMesh() { }

	protected override void ToggleMesh(bool state) { }

	protected override void OnPooled() { }

	public void .ctor() { }

}

