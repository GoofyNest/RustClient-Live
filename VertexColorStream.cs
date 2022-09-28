public class VertexColorStream : MonoBehaviour // TypeDefIndex: 13223
{
	[HideInInspector] 
	public Mesh originalMesh; 
	[HideInInspector] 
	public Mesh paintedMesh; 
	[HideInInspector] 
	public MeshHolder meshHold; 
	[HideInInspector] 
	public Vector3[] _vertices; 
	[HideInInspector] 
	public Vector3[] _normals; 
	[HideInInspector] 
	public int[] _triangles; 
	[HideInInspector] 
	public int[][] _Subtriangles; 
	[HideInInspector] 
	public Matrix4x4[] _bindPoses; 
	[HideInInspector] 
	public BoneWeight[] _boneWeights; 
	[HideInInspector] 
	public Bounds _bounds; 
	[HideInInspector] 
	public int _subMeshCount; 
	[HideInInspector] 
	public Vector4[] _tangents; 
	[HideInInspector] 
	public Vector2[] _uv; 
	[HideInInspector] 
	public Vector2[] _uv2; 
	[HideInInspector] 
	public Vector2[] _uv3; 
	[HideInInspector] 
	public Color[] _colors; 
	[HideInInspector] 
	public Vector2[] _uv4; 


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

