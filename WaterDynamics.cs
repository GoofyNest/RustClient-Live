public class WaterDynamics : MonoBehaviour // TypeDefIndex: 10602
{	// Fields
	private const int maxRasterSize = 1024;
	private const int subStep = 256;
	private const int subShift = 8;
	private const int subMask = 255;
	private const float oneOverSubStep = 0,00390625;
	private const float interp_subStep = 65536;
	private const int interp_subShift = 16;
	private const int interp_subFracMask = 65535;
	private WaterDynamics.ImageDesc imageDesc; // 0x18
	private byte[] imagePixels; // 0x30
	private WaterDynamics.TargetDesc targetDesc; // 0x38
	private byte[] targetPixels; // 0x70
	private byte[] targetDrawTileTable; // 0x78
	private SimpleList<ushort> targetDrawTileList; // 0x80
	public bool ShowDebug; // 0x88
	private Material material; // 0x90
	private MaterialPropertyBlock block; // 0x98
	private Mesh mesh; // 0xA0
	private static Dictionary<Texture2D, WaterDynamics.InstanceBatch> Batches; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsInitialized>k__BackingField; // 0xA8
	public bool ForceFallback; // 0xA9
	private WaterDynamics.Target target; // 0xB0
	private bool useNativePath; // 0xB8
	private static HashSet<WaterInteraction> interactions; // 0x8

	// Properties
	public bool IsInitialized { get; set; }

	// Methods

	// RVA: 0x7E60C0 Offset: 0x7E54C0 VA: 0x1807E60C0
	private void RasterBindImage(WaterDynamics.Image image) { }

	// RVA: 0x7E61C0 Offset: 0x7E55C0 VA: 0x1807E61C0
	private void RasterBindTarget(WaterDynamics.Target target) { }

	// RVA: 0x7E63C0 Offset: 0x7E57C0 VA: 0x1807E63C0
	private void RasterInteraction(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	// RVA: 0x7E5830 Offset: 0x7E4C30 VA: 0x1807E5830
	private float Frac(float x) { }

	// RVA: 0x7E79F0 Offset: 0x7E6DF0 VA: 0x1807E79F0
	private Vector2 Rotate2D(Vector2 v, float s, float c) { }

	// RVA: 0x7E5B30 Offset: 0x7E4F30 VA: 0x1807E5B30
	private int Min3(int a, int b, int c) { }

	// RVA: 0x7E5AB0 Offset: 0x7E4EB0 VA: 0x1807E5AB0
	private int Max3(int a, int b, int c) { }

	// RVA: 0x7E57F0 Offset: 0x7E4BF0 VA: 0x1807E57F0
	private int EdgeFunction(WaterDynamics.Point2D a, WaterDynamics.Point2D b, WaterDynamics.Point2D c) { }

	// RVA: 0x7E5A90 Offset: 0x7E4E90 VA: 0x1807E5A90
	private bool IsTopLeft(WaterDynamics.Point2D a, WaterDynamics.Point2D b) { }

	// RVA: 0x7E68E0 Offset: 0x7E5CE0 VA: 0x1807E68E0
	private void RasterizeTriangle(WaterDynamics.Point2D p0, WaterDynamics.Point2D p1, WaterDynamics.Point2D p2, Vector2 uv0, Vector2 uv1, Vector2 uv2, byte disp, byte dist) { }

	// RVA: 0x7E6240 Offset: 0x7E5640 VA: 0x1807E6240
	private static extern void RasterClearTile_Native(ref byte pixels, int offset, int stride, int width, int height) { }

	// RVA: 0x7E6030 Offset: 0x7E5430 VA: 0x1807E6030
	private static extern void RasterBindImage_Native(ref WaterDynamics.ImageDesc desc, ref byte pixels) { }

	// RVA: 0x7E6100 Offset: 0x7E5500 VA: 0x1807E6100
	private static extern void RasterBindTarget_Native(ref WaterDynamics.TargetDesc desc, ref byte pixels, ref byte drawTileTable, ref ushort drawTileList, ref int drawTileCount) { }

	// RVA: 0x7E62F0 Offset: 0x7E56F0 VA: 0x1807E62F0
	private static extern void RasterInteraction_Native(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	// RVA: 0x7E5850 Offset: 0x7E4C50 VA: 0x1807E5850
	public void InitializeRender() { }

	// RVA: 0x7E7A40 Offset: 0x7E6E40 VA: 0x1807E7A40
	public void ShutdownRender() { }

	// RVA: 0x7E55D0 Offset: 0x7E49D0 VA: 0x1807E55D0
	private Mesh CreateMesh() { }

	// RVA: 0x7E7680 Offset: 0x7E6A80 VA: 0x1807E7680
	private void RenderIssueBindTarget(WaterDynamics.Target target) { }

	// RVA: 0x7E77B0 Offset: 0x7E6BB0 VA: 0x1807E77B0
	private void RenderIssueInteraction(Texture2D texture, Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	// RVA: 0x7E72D0 Offset: 0x7E66D0 VA: 0x1807E72D0
	private void RenderFlushInteractions() { }

	// RVA: -1 Offset: -1
	public static void SafeDestroy<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F3B20 Offset: 0x5F2F20 VA: 0x1805F3B20
	|-WaterDynamics.SafeDestroy<object>
	|-WaterDynamics.SafeDestroy<Material>
	|-WaterDynamics.SafeDestroy<Mesh>
	|-WaterDynamics.SafeDestroy<RenderTexture>
	*/

	// RVA: -1 Offset: -1
	public static T SafeDestroy<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1580 Offset: 0x14C0980 VA: 0x1814C1580
	|-WaterDynamics.SafeDestroy<object>
	*/

	// RVA: -1 Offset: -1
	public static void SafeRelease<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F3BC0 Offset: 0x5F2FC0 VA: 0x1805F3BC0
	|-WaterDynamics.SafeRelease<object>
	|-WaterDynamics.SafeRelease<CommandBuffer>
	*/

	// RVA: -1 Offset: -1
	public static T SafeRelease<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1610 Offset: 0x14C0A10 VA: 0x1814C1610
	|-WaterDynamics.SafeRelease<object>
	|-WaterDynamics.SafeRelease<ComputeBuffer>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8400 Offset: 0x7E7800 VA: 0x1807E8400
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E83F0 Offset: 0x7E77F0 VA: 0x1807E83F0
	public bool get_IsInitialized() { }

	// RVA: 0x7E7250 Offset: 0x7E6650 VA: 0x1807E7250
	public static void RegisterInteraction(WaterInteraction interaction) { }

	// RVA: 0x7E80E0 Offset: 0x7E74E0 VA: 0x1807E80E0
	public static void UnregisterInteraction(WaterInteraction interaction) { }

	// RVA: 0x7E7D00 Offset: 0x7E7100 VA: 0x1807E7D00
	private bool SupportsNativePath() { }

	// RVA: 0x7E5920 Offset: 0x7E4D20 VA: 0x1807E5920
	public void Initialize(Vector3 areaPosition, Vector3 areaSize) { }

	// RVA: 0x7E7E50 Offset: 0x7E7250 VA: 0x1807E7E50
	public bool TryInitialize() { }

	// RVA: 0x7E5BB0 Offset: 0x7E4FB0 VA: 0x1807E5BB0
	public void Shutdown() { }

	// RVA: 0x7E5D10 Offset: 0x7E5110 VA: 0x1807E5D10
	public void OnEnable() { }

	// RVA: 0x7E5BB0 Offset: 0x7E4FB0 VA: 0x1807E5BB0
	public void OnDisable() { }

	// RVA: 0x7E8160 Offset: 0x7E7560 VA: 0x1807E8160
	public void Update() { }

	// RVA: 0x7E5D20 Offset: 0x7E5120 VA: 0x1807E5D20
	private void ProcessInteractions() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40
	public float SampleHeight(Vector3 pos) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x7E8350 Offset: 0x7E7750 VA: 0x1807E8350
	private static void .cctor() { }

}

public struct WaterDynamics.ImageDesc // TypeDefIndex: 10603
{	// Fields
	public int width; // 0x0
	public int height; // 0x4
	public int maxWidth; // 0x8
	public int maxHeight; // 0xC
	public int widthShift; // 0x10

	// Methods

	// RVA: 0xF8440 Offset: 0xF7840 VA: 0x1800F8440
	public void .ctor(Texture2D tex) { }

	// RVA: 0xF8430 Offset: 0xF7830 VA: 0x1800F8430
	public void Clear() { }

}

public class WaterDynamics.Image // TypeDefIndex: 10604
{	// Fields
	public WaterDynamics.ImageDesc desc; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Texture2D <texture>k__BackingField; // 0x28
	public byte[] pixels; // 0x30

	// Properties
	public Texture2D texture { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public Texture2D get_texture() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	private void set_texture(Texture2D value) { }

	// RVA: 0x7CE120 Offset: 0x7CD520 VA: 0x1807CE120
	public void .ctor(Texture2D tex) { }

	// RVA: 0x7CE030 Offset: 0x7CD430 VA: 0x1807CE030
	public void Destroy() { }

	// RVA: 0x7CE070 Offset: 0x7CD470 VA: 0x1807CE070
	private byte[] GetDisplacementPixelsFromTexture(Texture2D tex) { }

}

private struct WaterDynamics.Point2D // TypeDefIndex: 10605
{	// Fields
	public int x; // 0x0
	public int y; // 0x4

	// Methods

	// RVA: 0xF8460 Offset: 0xF7860 VA: 0x1800F8460
	public void .ctor(int x, int y) { }

	// RVA: 0xF8470 Offset: 0xF7870 VA: 0x1800F8470
	public void .ctor(float x, float y) { }

}

public struct WaterDynamics.InstanceData // TypeDefIndex: 10606
{	// Fields
	public Vector4 PositionScale; // 0x0
	public Vector4 RotationDispDist; // 0x10

	// Methods

	// RVA: 0xF8450 Offset: 0xF7850 VA: 0x1800F8450
	public void .ctor(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

}

private class WaterDynamics.InstanceBatch // TypeDefIndex: 10607
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Texture <Texture>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ComputeBuffer <ArgBuffer>k__BackingField; // 0x20
	private uint[] args; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ComputeBuffer <InstanceBuffer>k__BackingField; // 0x30
	private SimpleList<WaterDynamics.InstanceData> instances; // 0x38

	// Properties
	public Mesh Mesh { get; set; }
	public Texture Texture { get; set; }
	public ComputeBuffer ArgBuffer { get; set; }
	public ComputeBuffer InstanceBuffer { get; set; }
	public int Count { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_Mesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_Texture(Texture value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Texture get_Texture() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	private void set_ArgBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public ComputeBuffer get_ArgBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	private void set_InstanceBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public ComputeBuffer get_InstanceBuffer() { }

	// RVA: 0x7CE7B0 Offset: 0x7CDBB0 VA: 0x1807CE7B0
	public int get_Count() { }

	// RVA: 0x7CE610 Offset: 0x7CDA10 VA: 0x1807CE610
	private ComputeBuffer SafeRelease(ComputeBuffer buffer) { }

	// RVA: 0x7CE310 Offset: 0x7CD710 VA: 0x1807CE310
	public void Initialize(Mesh mesh, Texture texture) { }

	// RVA: 0x7CE530 Offset: 0x7CD930 VA: 0x1807CE530
	public void Release() { }

	// RVA: 0x7CE2C0 Offset: 0x7CD6C0 VA: 0x1807CE2C0
	public void Clear() { }

	// RVA: 0x7CE250 Offset: 0x7CD650 VA: 0x1807CE250
	public void AddInstance(WaterDynamics.InstanceData data) { }

	// RVA: 0x7CE630 Offset: 0x7CDA30 VA: 0x1807CE630
	public void UpdateBuffers() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public struct WaterDynamics.TargetDesc // TypeDefIndex: 10608
{	// Fields
	public int size; // 0x0
	public int maxSize; // 0x4
	public int maxSizeSubStep; // 0x8
	public Vector2 areaOffset; // 0xC
	public Vector2 areaToMapUV; // 0x14
	public Vector2 areaToMapXY; // 0x1C
	public int tileSize; // 0x24
	public int tileSizeShift; // 0x28
	public int tileCount; // 0x2C
	public int tileMaxCount; // 0x30

	// Methods

	// RVA: 0xFE970 Offset: 0xFDD70 VA: 0x1800FE970
	public void .ctor(Vector3 areaPosition, Vector3 areaSize) { }

	// RVA: 0xFE720 Offset: 0xFDB20 VA: 0x1800FE720
	public void Clear() { }

	// RVA: 0xFE820 Offset: 0xFDC20 VA: 0x1800FE820
	public ushort TileOffsetToXYOffset(ushort tileOffset, out int x, out int y, out int offset) { }

	// RVA: 0xFE7E0 Offset: 0xFDBE0 VA: 0x1800FE7E0
	public ushort TileOffsetToTileXYIndex(ushort tileOffset, out int tileX, out int tileY, out ushort tileIndex) { }

	// RVA: 0xFE860 Offset: 0xFDC60 VA: 0x1800FE860
	public Vector2 WorldToRaster(Vector2 pos) { }

	// RVA: 0xFE890 Offset: 0xFDC90 VA: 0x1800FE890
	public Vector3 WorldToRaster(Vector3 pos) { }

}

public class WaterDynamics.Target // TypeDefIndex: 10609
{	// Fields
	public WaterDynamics owner; // 0x10
	public WaterDynamics.TargetDesc desc; // 0x18
	private byte[] pixels; // 0x50
	private RenderTexture interactionTarget; // 0x58
	private RenderTexture combinedTarget; // 0x60
	private Camera commandBufferCamera; // 0x68
	private CommandBuffer commandBuffer; // 0x70
	private Material combineMaterial; // 0x78
	private byte[] clearTileTable; // 0x80
	private SimpleList<ushort> clearTileList; // 0x88
	private byte[] drawTileTable; // 0x90
	private SimpleList<ushort> drawTileList; // 0x98
	private const int MaxInteractionOffset = 100;
	private Vector3 prevCameraWorldPos; // 0xA0
	private Vector2i interactionOffset; // 0xAC

	// Properties
	public WaterDynamics.TargetDesc Desc { get; }
	public byte[] Pixels { get; }
	public RenderTexture InteractionTarget { get; }
	public RenderTexture CombinedTarget { get; }
	public CommandBuffer CommandBuffer { get; }
	public byte[] DrawTileTable { get; }
	public SimpleList<ushort> DrawTileList { get; }

	// Methods

	// RVA: 0x7CFB30 Offset: 0x7CEF30 VA: 0x1807CFB30
	public WaterDynamics.TargetDesc get_Desc() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public byte[] get_Pixels() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public RenderTexture get_InteractionTarget() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public RenderTexture get_CombinedTarget() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public CommandBuffer get_CommandBuffer() { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public byte[] get_DrawTileTable() { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public SimpleList<ushort> get_DrawTileList() { }

	// RVA: 0x7CF8C0 Offset: 0x7CECC0 VA: 0x1807CF8C0
	public void .ctor(WaterDynamics owner, Vector3 areaPosition, Vector3 areaSize) { }

	// RVA: 0x7CEC30 Offset: 0x7CE030 VA: 0x1807CEC30
	public void Destroy() { }

	// RVA: 0x7CEAB0 Offset: 0x7CDEB0 VA: 0x1807CEAB0
	private Texture2D CreateDynamicTexture(int size) { }

	// RVA: 0x7CEB50 Offset: 0x7CDF50 VA: 0x1807CEB50
	private RenderTexture CreateRenderTexture(int size) { }

	// RVA: 0x7CE890 Offset: 0x7CDC90 VA: 0x1807CE890
	public void ClearTiles() { }

	// RVA: 0x7CF1E0 Offset: 0x7CE5E0 VA: 0x1807CF1E0
	public void ProcessTiles() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void UpdateTiles() { }

	// RVA: 0x7CED50 Offset: 0x7CE150 VA: 0x1807CED50
	public void Prepare() { }

	// RVA: 0x7CF480 Offset: 0x7CE880 VA: 0x1807CF480
	public void Update() { }

	// RVA: 0x7CF440 Offset: 0x7CE840 VA: 0x1807CF440
	public void UpdateGlobalShaderProperties() { }

}

