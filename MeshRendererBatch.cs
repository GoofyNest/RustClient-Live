public class MeshRendererBatch : MeshBatch // TypeDefIndex: 13127
{
	private Vector3 position; 
	private Mesh meshBatch; 
	private MeshFilter meshFilter; 
	private MeshRenderer meshRenderer; 
	private MeshRendererData meshData; 
	private MeshRendererGroup meshGroup; 
	private MeshRendererLookup meshLookup; 

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

