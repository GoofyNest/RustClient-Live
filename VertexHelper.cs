public class VertexHelper : IDisposable // TypeDefIndex: 5029
{	private List<Vector3> m_Positions; // 0x10
	private List<Color32> m_Colors; // 0x18
	private List<Vector2> m_Uv0S; // 0x20
	private List<Vector2> m_Uv1S; // 0x28
	private List<Vector2> m_Uv2S; // 0x30
	private List<Vector2> m_Uv3S; // 0x38
	private List<Vector3> m_Normals; // 0x40
	private List<Vector4> m_Tangents; // 0x48
	private List<int> m_Indices; // 0x50
	private static readonly Vector4 s_DefaultTangent; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x10
	private bool m_ListsInitalized; // 0x58

	public int currentVertCount { get; }
	public int currentIndexCount { get; }


	public void .ctor() { }

	public void .ctor(Mesh m) { }

	private void InitializeListIfRequired() { }

	public void Dispose() { }

	public void Clear() { }

	public int get_currentVertCount() { }

	public int get_currentIndexCount() { }

	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	public void SetUIVertex(UIVertex vertex, int i) { }

	public void FillMesh(Mesh mesh) { }

	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector3 normal, Vector4 tangent) { }

	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector3 normal, Vector4 tangent) { }

	public void AddVert(Vector3 position, Color32 color, Vector2 uv0) { }

	public void AddVert(UIVertex v) { }

	public void AddTriangle(int idx0, int idx1, int idx2) { }

	public void AddUIVertexQuad(UIVertex[] verts) { }

	public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) { }

	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	public void GetUIVertexStream(List<UIVertex> stream) { }

	private static void .cctor() { }

}

