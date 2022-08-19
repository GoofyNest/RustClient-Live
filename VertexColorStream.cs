public class VertexColorStream : MonoBehaviour // TypeDefIndex: 11527
{	// Fields
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Mesh originalMesh; // 0x18
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Mesh paintedMesh; // 0x20
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public MeshHolder meshHold; // 0x28
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector3[] _vertices; // 0x30
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector3[] _normals; // 0x38
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int[] _triangles; // 0x40
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int[][] _Subtriangles; // 0x48
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Matrix4x4[] _bindPoses; // 0x50
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public BoneWeight[] _boneWeights; // 0x58
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Bounds _bounds; // 0x60
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int _subMeshCount; // 0x78
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector4[] _tangents; // 0x80
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector2[] _uv; // 0x88
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector2[] _uv2; // 0x90
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector2[] _uv3; // 0x98
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Color[] _colors; // 0xA0
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector2[] _uv4; // 0xA8

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0xAD9320 Offset: 0xAD8720 VA: 0x180AD9320
	public void init(Mesh origMesh, bool destroyOld) { }

	// RVA: 0xADA230 Offset: 0xAD9630 VA: 0x180ADA230
	public void setWholeMesh(Mesh tmpMesh) { }

	// RVA: 0xADA090 Offset: 0xAD9490 VA: 0x180ADA090
	public Vector3[] setVertices(Vector3[] _deformedVertices) { }

	// RVA: 0xAD9300 Offset: 0xAD8700 VA: 0x180AD9300
	public Vector3[] getVertices() { }

	// RVA: 0xAD9260 Offset: 0xAD8660 VA: 0x180AD9260
	public Vector3[] getNormals() { }

	// RVA: 0xAD92A0 Offset: 0xAD86A0 VA: 0x180AD92A0
	public int[] getTriangles() { }

	// RVA: 0xAD9FF0 Offset: 0xAD93F0 VA: 0x180AD9FF0
	public void setTangents(Vector4[] _meshTangents) { }

	// RVA: 0xAD9280 Offset: 0xAD8680 VA: 0x180AD9280
	public Vector4[] getTangents() { }

	// RVA: 0xAD9FA0 Offset: 0xAD93A0 VA: 0x180AD9FA0
	public void setColors(Color[] _vertexColors) { }

	// RVA: 0xAD9240 Offset: 0xAD8640 VA: 0x180AD9240
	public Color[] getColors() { }

	// RVA: 0xAD92E0 Offset: 0xAD86E0 VA: 0x180AD92E0
	public Vector2[] getUVs() { }

	// RVA: 0xADA040 Offset: 0xAD9440 VA: 0x180ADA040
	public void setUV4s(Vector2[] _uv4s) { }

	// RVA: 0xAD92C0 Offset: 0xAD86C0 VA: 0x180AD92C0
	public Vector2[] getUV4s() { }

	// RVA: 0xADA470 Offset: 0xAD9870 VA: 0x180ADA470
	public void unlink() { }

	// RVA: 0xAD98F0 Offset: 0xAD8CF0 VA: 0x180AD98F0
	public void rebuild() { }

	// RVA: 0xAD91C0 Offset: 0xAD85C0 VA: 0x180AD91C0
	private void Start() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

