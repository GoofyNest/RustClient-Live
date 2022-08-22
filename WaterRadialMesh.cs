public class WaterRadialMesh // TypeDefIndex: 10617
{	private const float AlignmentGranularity = 1;
	private const float MaxHorizontalDisplacement = 1;
	private Mesh[] meshes; // 0x10
	private bool initialized; // 0x18

	public Mesh[] Meshes { get; }
	public bool IsInitialized { get; }


	public Mesh[] get_Meshes() { }

	public bool get_IsInitialized() { }

	public void Initialize(int vertexCount) { }

	public void Destroy() { }

	private Mesh CreateMesh(string name, Vector3[] vertices, int[] indices) { }

	private Mesh[] GenerateMeshes(int vertexCount, bool volume = False) { }

	private Vector3 RaycastPlane(Camera camera, float planeHeight, Vector3 pos) { }

	public Matrix4x4 ComputeLocalToWorldMatrix(Camera camera, float oceanWaterLevel) { }

	public void .ctor() { }

}

