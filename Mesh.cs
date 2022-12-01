public sealed class Mesh : Object // TypeDefIndex: 3443
{
	public int blendShapeCount { get; }
	[NativeNameAttribute]
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


	[FreeFunctionAttribute]
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCodeAttribute]
	public void .ctor() { }

	[FreeFunctionAttribute]
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunctionAttribute]
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute]
	private uint GetIndexStartImpl(int submesh) { }

	[FreeFunctionAttribute]
	private uint GetIndexCountImpl(int submesh) { }

	[FreeFunctionAttribute]
	private uint GetBaseVertexImpl(int submesh) { }

	[FreeFunctionAttribute]
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute]
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute]
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunctionAttribute]
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunctionAttribute]
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunctionAttribute]
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount) { }

	[FreeFunctionAttribute]
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[NativeMethodAttribute]
	public int get_blendShapeCount() { }

	[FreeFunctionAttribute]
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunctionAttribute]
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	public Matrix4x4[] get_bindposes() { }

	public void set_bindposes(Matrix4x4[] value) { }

	[NativeMethodAttribute]
	public bool get_isReadable() { }

	[NativeMethodAttribute]
	internal bool get_canAccess() { }

	[NativeMethodAttribute]
	public int get_vertexCount() { }

	[NativeMethodAttribute]
	public int get_subMeshCount() { }

	[FreeFunctionAttribute]
	public void set_subMeshCount(int value) { }

	public Bounds get_bounds() { }

	public void set_bounds(Bounds value) { }

	[NativeMethodAttribute]
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethodAttribute]
	private void RecalculateBoundsImpl() { }

	[NativeMethodAttribute]
	private void RecalculateNormalsImpl() { }

	[NativeMethodAttribute]
	private void RecalculateTangentsImpl() { }

	[NativeMethodAttribute]
	private void MarkDynamicImpl() { }

	[NativeMethodAttribute]
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[FreeFunctionAttribute]
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

	[ExcludeFromDocsAttribute]
	public int[] GetIndices(int submesh) { }

	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	public uint GetIndexStart(int submesh) { }

	public uint GetIndexCount(int submesh) { }

	public uint GetBaseVertex(int submesh) { }

	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocsAttribute]
	public void SetTriangles(int[] triangles, int submesh) { }

	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute]
	public void SetTriangles(List<int> triangles, int submesh) { }

	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute]
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocsAttribute]
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	public BoneWeight[] get_boneWeights() { }

	public void set_boneWeights(BoneWeight[] value) { }

	[ExcludeFromDocsAttribute]
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

public static class Mesh // TypeDefIndex: 5615
{

	[ExtensionAttribute]
	public static void Export(Mesh mesh, string filename) { }

}

public struct Mesh_Extents // TypeDefIndex: 6804
{
	public Vector2 min;
	public Vector2 max;


	public void .ctor(Vector2 min, Vector2 max) { }

	public override string ToString() { }

}

public class Mesh : ConsoleSystem // TypeDefIndex: 13749
{
	private static float m_quality;

	[ClientVar]
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

