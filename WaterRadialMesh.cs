public class WaterRadialMesh // TypeDefIndex: 10617
{	// Fields
	private const float AlignmentGranularity = 1;
	private const float MaxHorizontalDisplacement = 1;
	private Mesh[] meshes; // 0x10
	private bool initialized; // 0x18

	// Properties
	public Mesh[] Meshes { get; }
	public bool IsInitialized { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Mesh[] get_Meshes() { }

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_IsInitialized() { }

	// RVA: 0xC170D0 Offset: 0xC164D0 VA: 0x180C170D0
	public void Initialize(int vertexCount) { }

	// RVA: 0xC162E0 Offset: 0xC156E0 VA: 0x180C162E0
	public void Destroy() { }

	// RVA: 0xC16200 Offset: 0xC15600 VA: 0x180C16200
	private Mesh CreateMesh(string name, Vector3[] vertices, int[] indices) { }

	// RVA: 0xC163C0 Offset: 0xC157C0 VA: 0x180C163C0
	private Mesh[] GenerateMeshes(int vertexCount, bool volume = False) { }

	// RVA: 0xC17100 Offset: 0xC16500 VA: 0x180C17100
	private Vector3 RaycastPlane(Camera camera, float planeHeight, Vector3 pos) { }

	// RVA: 0xC15A10 Offset: 0xC14E10 VA: 0x180C15A10
	public Matrix4x4 ComputeLocalToWorldMatrix(Camera camera, float oceanWaterLevel) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

