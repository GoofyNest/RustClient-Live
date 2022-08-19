public sealed class CanvasRenderer : Component // TypeDefIndex: 4732
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private bool <isMask>k__BackingField; // 0x18

	// Properties
	public bool hasPopInstruction { set; }
	public int materialCount { get; set; }
	public int popMaterialCount { set; }
	public int absoluteDepth { get; }
	public bool hasMoved { get; }
	[NativePropertyAttribute] // RVA: 0xA4B10 Offset: 0xA3F10 VA: 0x1800A4B10
	public bool cull { get; set; }

	// Methods

	// RVA: 0x2303640 Offset: 0x2302A40 VA: 0x182303640
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x23035B0 Offset: 0x23029B0 VA: 0x1823035B0
	public int get_materialCount() { }

	// RVA: 0x2303690 Offset: 0x2302A90 VA: 0x182303690
	public void set_materialCount(int value) { }

	// RVA: 0x23036D0 Offset: 0x2302AD0 VA: 0x1823036D0
	public void set_popMaterialCount(int value) { }

	// RVA: 0x23034F0 Offset: 0x23028F0 VA: 0x1823034F0
	public int get_absoluteDepth() { }

	// RVA: 0x2303570 Offset: 0x2302970 VA: 0x182303570
	public bool get_hasMoved() { }

	// RVA: 0x2303530 Offset: 0x2302930 VA: 0x182303530
	public bool get_cull() { }

	// RVA: 0x23035F0 Offset: 0x23029F0 VA: 0x1823035F0
	public void set_cull(bool value) { }

	// RVA: 0x2303100 Offset: 0x2302500 VA: 0x182303100
	public void SetColor(Color color) { }

	// RVA: 0x2302EF0 Offset: 0x23022F0 VA: 0x182302EF0
	public Color GetColor() { }

	// RVA: 0x2302E50 Offset: 0x2302250 VA: 0x182302E50
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x2302DC0 Offset: 0x23021C0 VA: 0x182302DC0
	public void DisableRectClipping() { }

	// RVA: 0x2303150 Offset: 0x2302550 VA: 0x182303150
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x2302F80 Offset: 0x2302380 VA: 0x182302F80
	public Material GetMaterial(int index) { }

	// RVA: 0x2303320 Offset: 0x2302720 VA: 0x182303320
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x2303380 Offset: 0x2302780 VA: 0x182303380
	public void SetTexture(Texture texture) { }

	// RVA: 0x2302FC0 Offset: 0x23023C0 VA: 0x182302FC0
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x23032D0 Offset: 0x23026D0 VA: 0x1823032D0
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x2302D10 Offset: 0x2302110 VA: 0x182302D10
	public void Clear() { }

	// RVA: 0x2303010 Offset: 0x2302410 VA: 0x182303010
	public void SetAlpha(float alpha) { }

	// RVA: 0x23031B0 Offset: 0x23025B0 VA: 0x1823031B0
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x2302F40 Offset: 0x2302340 VA: 0x182302F40
	public Material GetMaterial() { }

	// RVA: 0x2303420 Offset: 0x2302820 VA: 0x182303420
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x2302D50 Offset: 0x2302150 VA: 0x182302D50
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x2302CA0 Offset: 0x23020A0 VA: 0x182302CA0
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[StaticAccessorAttribute] // RVA: 0xA4970 Offset: 0xA3D70 VA: 0x1800A4970
	// RVA: 0x23033D0 Offset: 0x23027D0 VA: 0x1823033D0
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessorAttribute] // RVA: 0xA4970 Offset: 0xA3D70 VA: 0x1800A4970
	// RVA: 0x2302CA0 Offset: 0x23020A0 VA: 0x182302CA0
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessorAttribute] // RVA: 0xA4970 Offset: 0xA3D70 VA: 0x1800A4970
	// RVA: 0x2302D50 Offset: 0x2302150 VA: 0x182302D50
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x23030B0 Offset: 0x23024B0 VA: 0x1823030B0
	private void SetColor_Injected(ref Color color) { }

	// RVA: 0x2302EA0 Offset: 0x23022A0 VA: 0x182302EA0
	private void GetColor_Injected(out Color ret) { }

	// RVA: 0x2302E00 Offset: 0x2302200 VA: 0x182302E00
	private void EnableRectClipping_Injected(ref Rect rect) { }

}

