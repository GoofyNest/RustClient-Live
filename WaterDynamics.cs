public class WaterDynamics : MonoBehaviour // TypeDefIndex: 10602
{	private const int maxRasterSize = 1024;
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

	public bool IsInitialized { get; set; }


	private void RasterBindImage(WaterDynamics.Image image) { }

	private void RasterBindTarget(WaterDynamics.Target target) { }

	private void RasterInteraction(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	private float Frac(float x) { }

	private Vector2 Rotate2D(Vector2 v, float s, float c) { }

	private int Min3(int a, int b, int c) { }

	private int Max3(int a, int b, int c) { }

	private int EdgeFunction(WaterDynamics.Point2D a, WaterDynamics.Point2D b, WaterDynamics.Point2D c) { }

	private bool IsTopLeft(WaterDynamics.Point2D a, WaterDynamics.Point2D b) { }

	private void RasterizeTriangle(WaterDynamics.Point2D p0, WaterDynamics.Point2D p1, WaterDynamics.Point2D p2, Vector2 uv0, Vector2 uv1, Vector2 uv2, byte disp, byte dist) { }

	private static extern void RasterClearTile_Native(ref byte pixels, int offset, int stride, int width, int height) { }

	private static extern void RasterBindImage_Native(ref WaterDynamics.ImageDesc desc, ref byte pixels) { }

	private static extern void RasterBindTarget_Native(ref WaterDynamics.TargetDesc desc, ref byte pixels, ref byte drawTileTable, ref ushort drawTileList, ref int drawTileCount) { }

	private static extern void RasterInteraction_Native(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	public void InitializeRender() { }

	public void ShutdownRender() { }

	private Mesh CreateMesh() { }

	private void RenderIssueBindTarget(WaterDynamics.Target target) { }

	private void RenderIssueInteraction(Texture2D texture, Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	private void RenderFlushInteractions() { }

	public static void SafeDestroy<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-WaterDynamics.SafeDestroy<object>
	|-WaterDynamics.SafeDestroy<Material>
	|-WaterDynamics.SafeDestroy<Mesh>
	|-WaterDynamics.SafeDestroy<RenderTexture>
	*/

	public static T SafeDestroy<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-WaterDynamics.SafeDestroy<object>
	*/

	public static void SafeRelease<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-WaterDynamics.SafeRelease<object>
	|-WaterDynamics.SafeRelease<CommandBuffer>
	*/

	public static T SafeRelease<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-WaterDynamics.SafeRelease<object>
	|-WaterDynamics.SafeRelease<ComputeBuffer>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsInitialized() { }

	public static void RegisterInteraction(WaterInteraction interaction) { }

	public static void UnregisterInteraction(WaterInteraction interaction) { }

	private bool SupportsNativePath() { }

	public void Initialize(Vector3 areaPosition, Vector3 areaSize) { }

	public bool TryInitialize() { }

	public void Shutdown() { }

	public void OnEnable() { }

	public void OnDisable() { }

	public void Update() { }

	private void ProcessInteractions() { }

	public float SampleHeight(Vector3 pos) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct WaterDynamics.ImageDesc // TypeDefIndex: 10603
{	public int width; // 0x0
	public int height; // 0x4
	public int maxWidth; // 0x8
	public int maxHeight; // 0xC
	public int widthShift; // 0x10


	public void .ctor(Texture2D tex) { }

	public void Clear() { }

}

public class WaterDynamics.Image // TypeDefIndex: 10604
{	public WaterDynamics.ImageDesc desc; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Texture2D <texture>k__BackingField; // 0x28
	public byte[] pixels; // 0x30

	public Texture2D texture { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Texture2D get_texture() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_texture(Texture2D value) { }

	public void .ctor(Texture2D tex) { }

	public void Destroy() { }

	private byte[] GetDisplacementPixelsFromTexture(Texture2D tex) { }

}

private struct WaterDynamics.Point2D // TypeDefIndex: 10605
{	public int x; // 0x0
	public int y; // 0x4


	public void .ctor(int x, int y) { }

	public void .ctor(float x, float y) { }

}

public struct WaterDynamics.InstanceData // TypeDefIndex: 10606
{	public Vector4 PositionScale; // 0x0
	public Vector4 RotationDispDist; // 0x10


	public void .ctor(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

}

private class WaterDynamics.InstanceBatch // TypeDefIndex: 10607
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Texture <Texture>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ComputeBuffer <ArgBuffer>k__BackingField; // 0x20
	private uint[] args; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ComputeBuffer <InstanceBuffer>k__BackingField; // 0x30
	private SimpleList<WaterDynamics.InstanceData> instances; // 0x38

	public Mesh Mesh { get; set; }
	public Texture Texture { get; set; }
	public ComputeBuffer ArgBuffer { get; set; }
	public ComputeBuffer InstanceBuffer { get; set; }
	public int Count { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Mesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Texture(Texture value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Texture get_Texture() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_ArgBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ComputeBuffer get_ArgBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_InstanceBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ComputeBuffer get_InstanceBuffer() { }

	public int get_Count() { }

	private ComputeBuffer SafeRelease(ComputeBuffer buffer) { }

	public void Initialize(Mesh mesh, Texture texture) { }

	public void Release() { }

	public void Clear() { }

	public void AddInstance(WaterDynamics.InstanceData data) { }

	public void UpdateBuffers() { }

	public void .ctor() { }

}

public struct WaterDynamics.TargetDesc // TypeDefIndex: 10608
{	public int size; // 0x0
	public int maxSize; // 0x4
	public int maxSizeSubStep; // 0x8
	public Vector2 areaOffset; // 0xC
	public Vector2 areaToMapUV; // 0x14
	public Vector2 areaToMapXY; // 0x1C
	public int tileSize; // 0x24
	public int tileSizeShift; // 0x28
	public int tileCount; // 0x2C
	public int tileMaxCount; // 0x30


	public void .ctor(Vector3 areaPosition, Vector3 areaSize) { }

	public void Clear() { }

	public ushort TileOffsetToXYOffset(ushort tileOffset, out int x, out int y, out int offset) { }

	public ushort TileOffsetToTileXYIndex(ushort tileOffset, out int tileX, out int tileY, out ushort tileIndex) { }

	public Vector2 WorldToRaster(Vector2 pos) { }

	public Vector3 WorldToRaster(Vector3 pos) { }

}

public class WaterDynamics.Target // TypeDefIndex: 10609
{	public WaterDynamics owner; // 0x10
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

	public WaterDynamics.TargetDesc Desc { get; }
	public byte[] Pixels { get; }
	public RenderTexture InteractionTarget { get; }
	public RenderTexture CombinedTarget { get; }
	public CommandBuffer CommandBuffer { get; }
	public byte[] DrawTileTable { get; }
	public SimpleList<ushort> DrawTileList { get; }


	public WaterDynamics.TargetDesc get_Desc() { }

	public byte[] get_Pixels() { }

	public RenderTexture get_InteractionTarget() { }

	public RenderTexture get_CombinedTarget() { }

	public CommandBuffer get_CommandBuffer() { }

	public byte[] get_DrawTileTable() { }

	public SimpleList<ushort> get_DrawTileList() { }

	public void .ctor(WaterDynamics owner, Vector3 areaPosition, Vector3 areaSize) { }

	public void Destroy() { }

	private Texture2D CreateDynamicTexture(int size) { }

	private RenderTexture CreateRenderTexture(int size) { }

	public void ClearTiles() { }

	public void ProcessTiles() { }

	public void UpdateTiles() { }

	public void Prepare() { }

	public void Update() { }

	public void UpdateGlobalShaderProperties() { }

}

