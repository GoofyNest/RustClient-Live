public class AdaptMeshToTerrain : MonoBehaviour // TypeDefIndex: 10637
{	// Fields
	public LayerMask LayerMask; // 0x18
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

	// Methods

	// RVA: 0xA97570 Offset: 0xA96970 VA: 0x180A97570
	private void CheckInitialize() { }

	// RVA: 0xA97550 Offset: 0xA96950 VA: 0x180A97550
	private void Awake() { }

	// RVA: 0xA98480 Offset: 0xA97880 VA: 0x180A98480
	private void OnEnable() { }

	// RVA: 0xA98340 Offset: 0xA97740 VA: 0x180A98340
	private void OnDisable() { }

	// RVA: 0xA985C0 Offset: 0xA979C0 VA: 0x180A985C0
	private void SetMaterialPropertyBlock() { }

	// RVA: 0xA98170 Offset: 0xA97570 VA: 0x180A98170
	private void DestroyMeshes() { }

	// RVA: 0xA97600 Offset: 0xA96A00 VA: 0x180A97600
	private void CheckReferenceMeshes() { }

	// RVA: 0xA95CB0 Offset: 0xA950B0 VA: 0x180A95CB0
	public void Adapt() { }

	// RVA: 0xA97BC0 Offset: 0xA96FC0 VA: 0x180A97BC0
	private Mesh CreatePlaneMesh(int resolution) { }

	// RVA: 0xA98750 Offset: 0xA97B50 VA: 0x180A98750
	public void .ctor() { }

	// RVA: 0xA986F0 Offset: 0xA97AF0 VA: 0x180A986F0
	private static void .cctor() { }

}

