public class FoliageGridBatch : MeshBatch // TypeDefIndex: 13122
{
	private Vector3 position; 
	private Mesh meshBatch; 
	private MeshFilter meshFilter; 
	private MeshRenderer meshRenderer; 
	private FoliageGridMeshData meshData; 
	private MeshGroup meshGroup; 

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

