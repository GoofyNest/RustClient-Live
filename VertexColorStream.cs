public class VertexColorStream : MonoBehaviour // TypeDefIndex: 11527
{	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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


	private void OnDidApplyAnimationProperties() { }

	public void init(Mesh origMesh, bool destroyOld) { }

	public void setWholeMesh(Mesh tmpMesh) { }

	public Vector3[] setVertices(Vector3[] _deformedVertices) { }

	public Vector3[] getVertices() { }

	public Vector3[] getNormals() { }

	public int[] getTriangles() { }

	public void setTangents(Vector4[] _meshTangents) { }

	public Vector4[] getTangents() { }

	public void setColors(Color[] _vertexColors) { }

	public Color[] getColors() { }

	public Vector2[] getUVs() { }

	public void setUV4s(Vector2[] _uv4s) { }

	public Vector2[] getUV4s() { }

	public void unlink() { }

	public void rebuild() { }

	private void Start() { }

	public void .ctor() { }

}

