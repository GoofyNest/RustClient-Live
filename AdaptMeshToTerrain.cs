public class AdaptMeshToTerrain : MonoBehaviour // TypeDefIndex: 10637
{	public LayerMask LayerMask; // 0x18
	public float RayHeight; // 0x1C
	public float RayMaxDistance; // 0x20
	public float MinDisplacement; // 0x24
	public float MaxDisplacement; // 0x28
	[RangeAttribute] // RVA: 0xED3D0 Offset: 0xEC7D0 VA: 0x1800ED3D0
	public int PlaneResolution; // 0x2C
	private const int LODCount = 3;
	private MeshFilter meshFilter; // 0x30
	private MeshRenderer meshRenderer; // 0x38
	private MeshCollider meshCollider; // 0x40
	private MeshLOD meshLOD; // 0x48
	private Mesh[] meshes; // 0x50
	private Mesh colliderMesh; // 0x58
	private static Dictionary<int, Mesh> referenceMeshes; // 0x0
	private MaterialPropertyBlock block; // 0x60


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

