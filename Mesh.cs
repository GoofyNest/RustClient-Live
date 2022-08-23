public sealed class Mesh : Object // TypeDefIndex: 3442
{	public int blendShapeCount { get; }
	[NativeNameAttribute] // RVA: 0x9AFB0 Offset: 0x9A3B0 VA: 0x18009AFB0
	public Matrix4x4[] bindposes { get; set; }
	public bool isReadable { get; }
	internal bool canAccess { get; }
	public int vertexCount { get; }
	public int subMeshCount { get; set; }
	public Bounds bounds { get; set; }
	public Vector3[] vertices { get; set; }
	public Vector3[] normals { get; set; }
	public Vector4[] tangents { get; set; }
	public Vector2[] uv { get; set; }
	public Vector2[] uv2 { get; set; }
	public Vector2[] uv3 { get; set; }
	public Vector2[] uv4 { get; set; }
	public Color[] colors { get; set; }
	public Color32[] colors32 { get; set; }
	public int[] triangles { get; set; }
	public BoneWeight[] boneWeights { get; set; }


	[FreeFunctionAttribute] // RVA: 0x97570 Offset: 0x96970 VA: 0x180097570
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x977D0 Offset: 0x96BD0 VA: 0x1800977D0
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunctionAttribute] // RVA: 0x97AD0 Offset: 0x96ED0 VA: 0x180097AD0
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x97C60 Offset: 0x97060 VA: 0x180097C60
	private uint GetIndexStartImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x97D30 Offset: 0x97130 VA: 0x180097D30
	private uint GetIndexCountImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x97F50 Offset: 0x97350 VA: 0x180097F50
	private uint GetBaseVertexImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x98090 Offset: 0x97490 VA: 0x180098090
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x980F0 Offset: 0x974F0 VA: 0x1800980F0
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x982A0 Offset: 0x976A0 VA: 0x1800982A0
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x982F0 Offset: 0x976F0 VA: 0x1800982F0
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunctionAttribute] // RVA: 0x983B0 Offset: 0x977B0 VA: 0x1800983B0
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunctionAttribute] // RVA: 0x984D0 Offset: 0x978D0 VA: 0x1800984D0
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount) { }

	[FreeFunctionAttribute] // RVA: 0x98800 Offset: 0x97C00 VA: 0x180098800
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[NativeMethodAttribute] // RVA: 0x98960 Offset: 0x97D60 VA: 0x180098960
	public int get_blendShapeCount() { }

	[FreeFunctionAttribute] // RVA: 0x989D0 Offset: 0x97DD0 VA: 0x1800989D0
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunctionAttribute] // RVA: 0x98AA0 Offset: 0x97EA0 VA: 0x180098AA0
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	public Matrix4x4[] get_bindposes() { }

	public void set_bindposes(Matrix4x4[] value) { }

	[NativeMethodAttribute] // RVA: 0x98BC0 Offset: 0x97FC0 VA: 0x180098BC0
	public bool get_isReadable() { }

	[NativeMethodAttribute] // RVA: 0x98D60 Offset: 0x98160 VA: 0x180098D60
	internal bool get_canAccess() { }

	[NativeMethodAttribute] // RVA: 0x98EC0 Offset: 0x982C0 VA: 0x180098EC0
	public int get_vertexCount() { }

	[NativeMethodAttribute] // RVA: 0x99160 Offset: 0x98560 VA: 0x180099160
	public int get_subMeshCount() { }

	[FreeFunctionAttribute] // RVA: 0x992F0 Offset: 0x986F0 VA: 0x1800992F0
	public void set_subMeshCount(int value) { }

	public Bounds get_bounds() { }

	public void set_bounds(Bounds value) { }

	[NativeMethodAttribute] // RVA: 0x99490 Offset: 0x98890 VA: 0x180099490
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethodAttribute] // RVA: 0x996F0 Offset: 0x98AF0 VA: 0x1800996F0
	private void RecalculateBoundsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99A30 Offset: 0x98E30 VA: 0x180099A30
	private void RecalculateNormalsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99B90 Offset: 0x98F90 VA: 0x180099B90
	private void RecalculateTangentsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99DB0 Offset: 0x991B0 VA: 0x180099DB0
	private void MarkDynamicImpl() { }

	[NativeMethodAttribute] // RVA: 0x99E30 Offset: 0x99230 VA: 0x180099E30
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0x9A000 Offset: 0x99400 VA: 0x18009A000
	private MeshTopology GetTopologyImpl(int submesh) { }

	internal VertexAttribute GetUVChannel(int uvIndex) { }

	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) { }
	/* GenericInstMethod :
	|
	|-Mesh.GetAllocArrayFromChannel<object>
	|-Mesh.GetAllocArrayFromChannel<Color32>
	|-Mesh.GetAllocArrayFromChannel<Color>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	*/

	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-Mesh.GetAllocArrayFromChannel<object>
	|-Mesh.GetAllocArrayFromChannel<Color>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	*/

	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount) { }

	private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values) { }
	/* GenericInstMethod :
	|
	|-Mesh.SetArrayForChannel<object>
	|-Mesh.SetArrayForChannel<Color32>
	*/

	private void SetArrayForChannel<T>(VertexAttribute channel, T[] values) { }
	/* GenericInstMethod :
	|
	|-Mesh.SetArrayForChannel<object>
	|-Mesh.SetArrayForChannel<Color>
	|-Mesh.SetArrayForChannel<Vector2>
	|-Mesh.SetArrayForChannel<Vector3>
	|-Mesh.SetArrayForChannel<Vector4>
	*/

	private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length) { }
	/* GenericInstMethod :
	|
	|-Mesh.SetListForChannel<object>
	|-Mesh.SetListForChannel<Color32>
	|-Mesh.SetListForChannel<Vector2>
	|-Mesh.SetListForChannel<Vector4>
	*/

	private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length) { }
	/* GenericInstMethod :
	|
	|-Mesh.SetListForChannel<object>
	|-Mesh.SetListForChannel<Color>
	|-Mesh.SetListForChannel<Vector3>
	|-Mesh.SetListForChannel<Vector4>
	*/

	public Vector3[] get_vertices() { }

	public void set_vertices(Vector3[] value) { }

	public Vector3[] get_normals() { }

	public void set_normals(Vector3[] value) { }

	public Vector4[] get_tangents() { }

	public void set_tangents(Vector4[] value) { }

	public Vector2[] get_uv() { }

	public void set_uv(Vector2[] value) { }

	public Vector2[] get_uv2() { }

	public void set_uv2(Vector2[] value) { }

	public Vector2[] get_uv3() { }

	public void set_uv3(Vector2[] value) { }

	public Vector2[] get_uv4() { }

	public void set_uv4(Vector2[] value) { }

	public Color[] get_colors() { }

	public void set_colors(Color[] value) { }

	public Color32[] get_colors32() { }

	public void set_colors32(Color32[] value) { }

	public void SetVertices(List<Vector3> inVertices) { }

	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	public void SetNormals(List<Vector3> inNormals) { }

	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	public void SetTangents(List<Vector4> inTangents) { }

	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	public void SetColors(List<Color> inColors) { }

	public void SetColors(List<Color> inColors, int start, int length) { }

	public void SetColors(Color[] inColors) { }

	public void SetColors(Color[] inColors, int start, int length) { }

	public void SetColors(List<Color32> inColors) { }

	public void SetColors(List<Color32> inColors, int start, int length) { }

	private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length) { }
	/* GenericInstMethod :
	|
	|-Mesh.SetUvsImpl<object>
	|
	|-Mesh.SetUvsImpl<Vector2>
	|
	|-Mesh.SetUvsImpl<Vector4>
	*/

	public void SetUVs(int channel, List<Vector2> uvs) { }

	public void SetUVs(int channel, List<Vector4> uvs) { }

	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-Mesh.SetVertexBufferData<FoliageGridMeshData.FoliageVertex>
	*/

	private void PrintErrorCantAccessIndices() { }

	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	public int[] get_triangles() { }

	public void set_triangles(int[] value) { }

	public int[] GetTriangles(int submesh) { }

	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int[] GetIndices(int submesh) { }

	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	public uint GetIndexStart(int submesh) { }

	public uint GetIndexCount(int submesh) { }

	public uint GetBaseVertex(int submesh) { }

	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void SetTriangles(int[] triangles, int submesh) { }

	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void SetTriangles(List<int> triangles, int submesh) { }

	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	public BoneWeight[] get_boneWeights() { }

	public void set_boneWeights(BoneWeight[] value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Clear() { }

	public void RecalculateBounds() { }

	public void RecalculateNormals() { }

	public void RecalculateTangents() { }

	public void MarkDynamic() { }

	public void UploadMeshData(bool markNoLongerReadable) { }

	public MeshTopology GetTopology(int submesh) { }

	private void get_bounds_Injected(out Bounds ret) { }

	private void set_bounds_Injected(ref Bounds value) { }

}

public static class Mesh // TypeDefIndex: 5606
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void Export(Mesh mesh, string filename) { }

}

public struct Mesh_Extents // TypeDefIndex: 6862
{	public Vector2 min; // 0x0
	public Vector2 max; // 0x8


	public void .ctor(Vector2 min, Vector2 max) { }

	public override string ToString() { }

}

public class Mesh : ConsoleSystem // TypeDefIndex: 11941
{	private static float m_quality; // 0x2B0ACA8

	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float quality { get; set; }
	public static float lod { get; }
	public static float cull { get; }


	public static float get_quality() { }

	public static void set_quality(float value) { }

	public static float get_lod() { }

	public static float get_cull() { }

	public void .ctor() { }

	private static void .cctor() { }

}

