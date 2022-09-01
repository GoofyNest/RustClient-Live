public class AdaptMeshToTerrain : MonoBehaviour // TypeDefIndex: 10648
{
	public LayerMask LayerMask; 
	public float RayHeight; 
	public float RayMaxDistance; 
	public float MinDisplacement; 
	public float MaxDisplacement; 
	[RangeAttribute] 
	public int PlaneResolution; 
	private const int LODCount = 3;
	private MeshFilter meshFilter; 
	private MeshRenderer meshRenderer; 
	private MeshCollider meshCollider; 
	private MeshLOD meshLOD; 
	private Mesh[] meshes; 
	private Mesh colliderMesh; 
	private static Dictionary<int, Mesh> referenceMeshes; 
	private MaterialPropertyBlock block; 


	private void CheckInitialize() { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void SetMaterialPropertyBlock() { }

	private void DestroyMeshes() { }

	private void CheckReferenceMeshes() { }

	public void Adapt() { }

	private Mesh CreatePlaneMesh(int resolution) { }

	public void .ctor() { }

	private static void .cctor() { }

}

