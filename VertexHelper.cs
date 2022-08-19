public class VertexHelper : IDisposable // TypeDefIndex: 5029
{	// Fields
	private List<Vector3> m_Positions; // 0x10
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

	// Properties
	public int currentVertCount { get; }
	public int currentIndexCount { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22445C0 Offset: 0x22439C0 VA: 0x1822445C0
	public void .ctor(Mesh m) { }

	// RVA: 0x2243E90 Offset: 0x2243290 VA: 0x182243E90
	private void InitializeListIfRequired() { }

	// RVA: 0x2243A80 Offset: 0x2242E80 VA: 0x182243A80 Slot: 4
	public void Dispose() { }

	// RVA: 0x2243970 Offset: 0x2242D70 VA: 0x182243970
	public void Clear() { }

	// RVA: 0x22447D0 Offset: 0x2243BD0 VA: 0x1822447D0
	public int get_currentVertCount() { }

	// RVA: 0x2244790 Offset: 0x2243B90 VA: 0x182244790
	public int get_currentIndexCount() { }

	// RVA: 0x2244060 Offset: 0x2243460 VA: 0x182244060
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	// RVA: 0x2244250 Offset: 0x2243650 VA: 0x182244250
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x2243CC0 Offset: 0x22430C0 VA: 0x182243CC0
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x22436C0 Offset: 0x2242AC0 VA: 0x1822436C0
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x2243850 Offset: 0x2242C50 VA: 0x182243850
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x2243510 Offset: 0x2242910 VA: 0x182243510
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0) { }

	// RVA: 0x22433A0 Offset: 0x22427A0 VA: 0x1822433A0
	public void AddVert(UIVertex v) { }

	// RVA: 0x2242DD0 Offset: 0x22421D0 VA: 0x182242DD0
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x2242E80 Offset: 0x2242280 VA: 0x182242E80
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x2243260 Offset: 0x2242660 VA: 0x182243260
	public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) { }

	// RVA: 0x2243320 Offset: 0x2242720 VA: 0x182243320
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	// RVA: 0x2243E10 Offset: 0x2243210 VA: 0x182243E10
	public void GetUIVertexStream(List<UIVertex> stream) { }

	// RVA: 0x2244500 Offset: 0x2243900 VA: 0x182244500
	private static void .cctor() { }

}

