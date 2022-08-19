public sealed class Mesh : Object // TypeDefIndex: 3442
{	// Properties
	public int blendShapeCount { get; }
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

	// Methods

	[FreeFunctionAttribute] // RVA: 0x97570 Offset: 0x96970 VA: 0x180097570
	// RVA: 0x18EF2B0 Offset: 0x18EE6B0 VA: 0x1818EF2B0
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18F11E0 Offset: 0x18F05E0 VA: 0x1818F11E0
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x977D0 Offset: 0x96BD0 VA: 0x1800977D0
	// RVA: 0x18F0FD0 Offset: 0x18F03D0 VA: 0x1818F0FD0
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunctionAttribute] // RVA: 0x97AD0 Offset: 0x96ED0 VA: 0x180097AD0
	// RVA: 0x18EF250 Offset: 0x18EE650 VA: 0x1818EF250
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x97C60 Offset: 0x97060 VA: 0x180097C60
	// RVA: 0x18EEC50 Offset: 0x18EE050 VA: 0x1818EEC50
	private uint GetIndexStartImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x97D30 Offset: 0x97130 VA: 0x180097D30
	// RVA: 0x18EEB50 Offset: 0x18EDF50 VA: 0x1818EEB50
	private uint GetIndexCountImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x97F50 Offset: 0x97350 VA: 0x180097F50
	// RVA: 0x18EEA10 Offset: 0x18EDE10 VA: 0x1818EEA10
	private uint GetBaseVertexImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x98090 Offset: 0x97490 VA: 0x180098090
	// RVA: 0x18EF010 Offset: 0x18EE410 VA: 0x1818EF010
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x980F0 Offset: 0x974F0 VA: 0x1800980F0
	// RVA: 0x18EED50 Offset: 0x18EE150 VA: 0x1818EED50
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x982A0 Offset: 0x976A0 VA: 0x1800982A0
	// RVA: 0x18EFC00 Offset: 0x18EF000 VA: 0x1818EFC00
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x982F0 Offset: 0x976F0 VA: 0x1800982F0
	// RVA: 0x18EF3A0 Offset: 0x18EE7A0 VA: 0x1818EF3A0
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunctionAttribute] // RVA: 0x983B0 Offset: 0x977B0 VA: 0x1800983B0
	// RVA: 0x18EF210 Offset: 0x18EE610 VA: 0x1818EF210
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunctionAttribute] // RVA: 0x984D0 Offset: 0x978D0 VA: 0x1800984D0
	// RVA: 0x18EF7E0 Offset: 0x18EEBE0 VA: 0x1818EF7E0
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount) { }

	[FreeFunctionAttribute] // RVA: 0x98800 Offset: 0x97C00 VA: 0x180098800
	// RVA: 0x18EE9B0 Offset: 0x18EDDB0 VA: 0x1818EE9B0
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[NativeMethodAttribute] // RVA: 0x98960 Offset: 0x97D60 VA: 0x180098960
	// RVA: 0x18F12A0 Offset: 0x18F06A0 VA: 0x1818F12A0
	public int get_blendShapeCount() { }

	[FreeFunctionAttribute] // RVA: 0x989D0 Offset: 0x97DD0 VA: 0x1800989D0
	// RVA: 0x18EEB10 Offset: 0x18EDF10 VA: 0x1818EEB10
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunctionAttribute] // RVA: 0x98AA0 Offset: 0x97EA0 VA: 0x180098AA0
	// RVA: 0x18EF840 Offset: 0x18EEC40 VA: 0x1818EF840
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0x18F1260 Offset: 0x18F0660 VA: 0x1818F1260
	public Matrix4x4[] get_bindposes() { }

	// RVA: 0x18F1780 Offset: 0x18F0B80 VA: 0x1818F1780
	public void set_bindposes(Matrix4x4[] value) { }

	[NativeMethodAttribute] // RVA: 0x98BC0 Offset: 0x97FC0 VA: 0x180098BC0
	// RVA: 0x18F1460 Offset: 0x18F0860 VA: 0x1818F1460
	public bool get_isReadable() { }

	[NativeMethodAttribute] // RVA: 0x98D60 Offset: 0x98160 VA: 0x180098D60
	// RVA: 0x18F1390 Offset: 0x18F0790 VA: 0x1818F1390
	internal bool get_canAccess() { }

	[NativeMethodAttribute] // RVA: 0x98EC0 Offset: 0x982C0 VA: 0x180098EC0
	// RVA: 0x18F1700 Offset: 0x18F0B00 VA: 0x1818F1700
	public int get_vertexCount() { }

	[NativeMethodAttribute] // RVA: 0x99160 Offset: 0x98560 VA: 0x180099160
	// RVA: 0x18F14E0 Offset: 0x18F08E0 VA: 0x1818F14E0
	public int get_subMeshCount() { }

	[FreeFunctionAttribute] // RVA: 0x992F0 Offset: 0x986F0 VA: 0x1800992F0
	// RVA: 0x18F1970 Offset: 0x18F0D70 VA: 0x1818F1970
	public void set_subMeshCount(int value) { }

	// RVA: 0x18F1330 Offset: 0x18F0730 VA: 0x1818F1330
	public Bounds get_bounds() { }

	// RVA: 0x18F1820 Offset: 0x18F0C20 VA: 0x1818F1820
	public void set_bounds(Bounds value) { }

	[NativeMethodAttribute] // RVA: 0x99490 Offset: 0x98890 VA: 0x180099490
	// RVA: 0x18EE880 Offset: 0x18EDC80 VA: 0x1818EE880
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethodAttribute] // RVA: 0x996F0 Offset: 0x98AF0 VA: 0x1800996F0
	// RVA: 0x18EF4B0 Offset: 0x18EE8B0 VA: 0x1818EF4B0
	private void RecalculateBoundsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99A30 Offset: 0x98E30 VA: 0x180099A30
	// RVA: 0x18EF5C0 Offset: 0x18EE9C0 VA: 0x1818EF5C0
	private void RecalculateNormalsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99B90 Offset: 0x98F90 VA: 0x180099B90
	// RVA: 0x18EF6D0 Offset: 0x18EEAD0 VA: 0x1818EF6D0
	private void RecalculateTangentsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99DB0 Offset: 0x991B0 VA: 0x180099DB0
	// RVA: 0x18EF2F0 Offset: 0x18EE6F0 VA: 0x1818EF2F0
	private void MarkDynamicImpl() { }

	[NativeMethodAttribute] // RVA: 0x99E30 Offset: 0x99230 VA: 0x180099E30
	// RVA: 0x18F1120 Offset: 0x18F0520 VA: 0x1818F1120
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0x9A000 Offset: 0x99400 VA: 0x18009A000
	// RVA: 0x18EEEE0 Offset: 0x18EE2E0 VA: 0x1818EEEE0
	private MeshTopology GetTopologyImpl(int submesh) { }

	// RVA: 0x18EF1A0 Offset: 0x18EE5A0 VA: 0x1818EF1A0
	internal VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x18EE910 Offset: 0x18EDD10 VA: 0x1818EE910
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA2770 Offset: 0x1AA1B70 VA: 0x181AA2770
	|-Mesh.GetAllocArrayFromChannel<object>
	|-Mesh.GetAllocArrayFromChannel<Color32>
	|-Mesh.GetAllocArrayFromChannel<Color>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA2870 Offset: 0x1AA1C70 VA: 0x181AA2870
	|-Mesh.GetAllocArrayFromChannel<object>
	|-Mesh.GetAllocArrayFromChannel<Color>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	*/

	// RVA: 0x18F03B0 Offset: 0x18EF7B0 VA: 0x1818F03B0
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount) { }

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EB370 Offset: 0x5EA770 VA: 0x1805EB370
	|-Mesh.SetArrayForChannel<object>
	|-Mesh.SetArrayForChannel<Color32>
	*/

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, T[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EB400 Offset: 0x5EA800 VA: 0x1805EB400
	|-Mesh.SetArrayForChannel<object>
	|-Mesh.SetArrayForChannel<Color>
	|-Mesh.SetArrayForChannel<Vector2>
	|-Mesh.SetArrayForChannel<Vector3>
	|-Mesh.SetArrayForChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EB480 Offset: 0x5EA880 VA: 0x1805EB480
	|-Mesh.SetListForChannel<object>
	|-Mesh.SetListForChannel<Color32>
	|-Mesh.SetListForChannel<Vector2>
	|-Mesh.SetListForChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EB540 Offset: 0x5EA940 VA: 0x1805EB540
	|-Mesh.SetListForChannel<object>
	|-Mesh.SetListForChannel<Color>
	|-Mesh.SetListForChannel<Vector3>
	|-Mesh.SetListForChannel<Vector4>
	*/

	// RVA: 0x18F1740 Offset: 0x18F0B40 VA: 0x1818F1740
	public Vector3[] get_vertices() { }

	// RVA: 0x18F1C40 Offset: 0x18F1040 VA: 0x1818F1C40
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x18F14A0 Offset: 0x18F08A0 VA: 0x1818F14A0
	public Vector3[] get_normals() { }

	// RVA: 0x18F1920 Offset: 0x18F0D20 VA: 0x1818F1920
	public void set_normals(Vector3[] value) { }

	// RVA: 0x18F1520 Offset: 0x18F0920 VA: 0x1818F1520
	public Vector4[] get_tangents() { }

	// RVA: 0x18F19B0 Offset: 0x18F0DB0 VA: 0x1818F19B0
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x18F16C0 Offset: 0x18F0AC0 VA: 0x1818F16C0
	public Vector2[] get_uv() { }

	// RVA: 0x18F1BF0 Offset: 0x18F0FF0 VA: 0x1818F1BF0
	public void set_uv(Vector2[] value) { }

	// RVA: 0x18F1600 Offset: 0x18F0A00 VA: 0x1818F1600
	public Vector2[] get_uv2() { }

	// RVA: 0x18F1B00 Offset: 0x18F0F00 VA: 0x1818F1B00
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x18F1640 Offset: 0x18F0A40 VA: 0x1818F1640
	public Vector2[] get_uv3() { }

	// RVA: 0x18F1B50 Offset: 0x18F0F50 VA: 0x1818F1B50
	public void set_uv3(Vector2[] value) { }

	// RVA: 0x18F1680 Offset: 0x18F0A80 VA: 0x1818F1680
	public Vector2[] get_uv4() { }

	// RVA: 0x18F1BA0 Offset: 0x18F0FA0 VA: 0x1818F1BA0
	public void set_uv4(Vector2[] value) { }

	// RVA: 0x18F1420 Offset: 0x18F0820 VA: 0x1818F1420
	public Color[] get_colors() { }

	// RVA: 0x18F18D0 Offset: 0x18F0CD0 VA: 0x1818F18D0
	public void set_colors(Color[] value) { }

	// RVA: 0x18F13D0 Offset: 0x18F07D0 VA: 0x1818F13D0
	public Color32[] get_colors32() { }

	// RVA: 0x18F1870 Offset: 0x18F0C70 VA: 0x1818F1870
	public void set_colors32(Color32[] value) { }

	// RVA: 0x18F1020 Offset: 0x18F0420 VA: 0x1818F1020
	public void SetVertices(List<Vector3> inVertices) { }

	// RVA: 0x18F10B0 Offset: 0x18F04B0 VA: 0x1818F10B0
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	// RVA: 0x18F0320 Offset: 0x18EF720 VA: 0x1818F0320
	public void SetNormals(List<Vector3> inNormals) { }

	// RVA: 0x18F02A0 Offset: 0x18EF6A0 VA: 0x1818F02A0
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	// RVA: 0x18F06F0 Offset: 0x18EFAF0 VA: 0x1818F06F0
	public void SetTangents(List<Vector4> inTangents) { }

	// RVA: 0x18F0670 Offset: 0x18EFA70 VA: 0x1818F0670
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	// RVA: 0x18EFB70 Offset: 0x18EEF70 VA: 0x1818EFB70
	public void SetColors(List<Color> inColors) { }

	// RVA: 0x18EF930 Offset: 0x18EED30 VA: 0x1818EF930
	public void SetColors(List<Color> inColors, int start, int length) { }

	// RVA: 0x18EF9B0 Offset: 0x18EEDB0 VA: 0x1818EF9B0
	public void SetColors(Color[] inColors) { }

	// RVA: 0x18EFA50 Offset: 0x18EEE50 VA: 0x1818EFA50
	public void SetColors(Color[] inColors, int start, int length) { }

	// RVA: 0x18EF890 Offset: 0x18EEC90 VA: 0x1818EF890
	public void SetColors(List<Color32> inColors) { }

	// RVA: 0x18EFAF0 Offset: 0x18EEEF0 VA: 0x1818EFAF0
	public void SetColors(List<Color32> inColors, int start, int length) { }

	// RVA: -1 Offset: -1
	private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EB5F0 Offset: 0x5EA9F0 VA: 0x1805EB5F0
	|-Mesh.SetUvsImpl<object>
	|
	|-RVA: 0x5EB6D0 Offset: 0x5EAAD0 VA: 0x1805EB6D0
	|-Mesh.SetUvsImpl<Vector2>
	|
	|-RVA: 0x5EB7B0 Offset: 0x5EABB0 VA: 0x1805EB7B0
	|-Mesh.SetUvsImpl<Vector4>
	*/

	// RVA: 0x18F0D70 Offset: 0x18F0170 VA: 0x1818F0D70
	public void SetUVs(int channel, List<Vector2> uvs) { }

	// RVA: 0x18F0F20 Offset: 0x18F0320 VA: 0x1818F0F20
	public void SetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x18F0EA0 Offset: 0x18F02A0 VA: 0x1818F0EA0
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	// RVA: 0x18F0E20 Offset: 0x18F0220 VA: 0x1818F0E20
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EB890 Offset: 0x5EAC90 VA: 0x1805EB890
	|-Mesh.SetVertexBufferData<FoliageGridMeshData.FoliageVertex>
	*/

	// RVA: 0x18EF3E0 Offset: 0x18EE7E0 VA: 0x1818EF3E0
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x18EE590 Offset: 0x18ED990 VA: 0x1818EE590
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x18EE580 Offset: 0x18ED980 VA: 0x1818EE580
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x18EE570 Offset: 0x18ED970 VA: 0x1818EE570
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x18F1560 Offset: 0x18F0960 VA: 0x1818F1560
	public int[] get_triangles() { }

	// RVA: 0x18F1A00 Offset: 0x18F0E00 VA: 0x1818F1A00
	public void set_triangles(int[] value) { }

	// RVA: 0x18EF070 Offset: 0x18EE470 VA: 0x1818EF070
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x18EF100 Offset: 0x18EE500 VA: 0x1818EF100
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18EEDB0 Offset: 0x18EE1B0 VA: 0x1818EEDB0
	public int[] GetIndices(int submesh) { }

	// RVA: 0x18EEE40 Offset: 0x18EE240 VA: 0x1818EEE40
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	// RVA: 0x18EEC90 Offset: 0x18EE090 VA: 0x1818EEC90
	public uint GetIndexStart(int submesh) { }

	// RVA: 0x18EEB90 Offset: 0x18EDF90 VA: 0x1818EEB90
	public uint GetIndexCount(int submesh) { }

	// RVA: 0x18EEA50 Offset: 0x18EDE50 VA: 0x1818EEA50
	public uint GetBaseVertex(int submesh) { }

	// RVA: 0x18EE6B0 Offset: 0x18EDAB0 VA: 0x1818EE6B0
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x18F0780 Offset: 0x18EFB80 VA: 0x1818F0780
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18F0CC0 Offset: 0x18F00C0 VA: 0x1818F0CC0
	public void SetTriangles(int[] triangles, int submesh) { }

	// RVA: 0x18F0840 Offset: 0x18EFC40 VA: 0x1818F0840
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F0A10 Offset: 0x18EFE10 VA: 0x1818F0A10
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18F0AC0 Offset: 0x18EFEC0 VA: 0x1818F0AC0
	public void SetTriangles(List<int> triangles, int submesh) { }

	// RVA: 0x18F0900 Offset: 0x18EFD00 VA: 0x1818F0900
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F0BC0 Offset: 0x18EFFC0 VA: 0x1818F0BC0
	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18EFC70 Offset: 0x18EF070 VA: 0x1818EFC70
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18F00B0 Offset: 0x18EF4B0 VA: 0x1818F00B0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x18F01A0 Offset: 0x18EF5A0 VA: 0x1818F01A0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18EFEA0 Offset: 0x18EF2A0 VA: 0x1818EFEA0
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18EFD60 Offset: 0x18EF160 VA: 0x1818EFD60
	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18EFF80 Offset: 0x18EF380 VA: 0x1818EFF80
	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18EEB10 Offset: 0x18EDF10 VA: 0x1818EEB10
	public BoneWeight[] get_boneWeights() { }

	// RVA: 0x18EF840 Offset: 0x18EEC40 VA: 0x1818EF840
	public void set_boneWeights(BoneWeight[] value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18EE8D0 Offset: 0x18EDCD0 VA: 0x1818EE8D0
	public void Clear() { }

	// RVA: 0x18EF4F0 Offset: 0x18EE8F0 VA: 0x1818EF4F0
	public void RecalculateBounds() { }

	// RVA: 0x18EF600 Offset: 0x18EEA00 VA: 0x1818EF600
	public void RecalculateNormals() { }

	// RVA: 0x18EF710 Offset: 0x18EEB10 VA: 0x1818EF710
	public void RecalculateTangents() { }

	// RVA: 0x18EF330 Offset: 0x18EE730 VA: 0x1818EF330
	public void MarkDynamic() { }

	// RVA: 0x18F1170 Offset: 0x18F0570 VA: 0x1818F1170
	public void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x18EEF20 Offset: 0x18EE320 VA: 0x1818EEF20
	public MeshTopology GetTopology(int submesh) { }

	// RVA: 0x18F12E0 Offset: 0x18F06E0 VA: 0x1818F12E0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x18F17D0 Offset: 0x18F0BD0 VA: 0x1818F17D0
	private void set_bounds_Injected(ref Bounds value) { }

}

public static class Mesh // TypeDefIndex: 5606
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x199D520 Offset: 0x199C920 VA: 0x18199D520
	public static void Export(Mesh mesh, string filename) { }

}

public struct Mesh_Extents // TypeDefIndex: 6862
{	// Fields
	public Vector2 min; // 0x0
	public Vector2 max; // 0x8

	// Methods

	// RVA: 0x116DC0 Offset: 0x1161C0 VA: 0x180116DC0
	public void .ctor(Vector2 min, Vector2 max) { }

	// RVA: 0x1174B0 Offset: 0x1168B0 VA: 0x1801174B0 Slot: 3
	public override string ToString() { }

}

public class Mesh : ConsoleSystem // TypeDefIndex: 11941
{	// Fields
	private static float m_quality; // 0x2B0ACA8

	// Properties
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float quality { get; set; }
	public static float lod { get; }
	public static float cull { get; }

	// Methods

	// RVA: 0x365340 Offset: 0x364740 VA: 0x180365340
	public static float get_quality() { }

	// RVA: 0x3653A0 Offset: 0x3647A0 VA: 0x1803653A0
	public static void set_quality(float value) { }

	// RVA: 0x365290 Offset: 0x364690 VA: 0x180365290
	public static float get_lod() { }

	// RVA: 0x3651B0 Offset: 0x3645B0 VA: 0x1803651B0
	public static float get_cull() { }

	// RVA: 0x365150 Offset: 0x364550 VA: 0x180365150
	public void .ctor() { }

	// RVA: 0x365110 Offset: 0x364510 VA: 0x180365110
	private static void .cctor() { }

}

