public class WaterRendering // TypeDefIndex: 10618
{	// Fields
	private WaterSystem water; // 0x10
	private WaterSimulation simulation; // 0x18
	private Camera camera; // 0x20
	private PostOpaqueDepth postOpaqueDepth; // 0x28
	private int width; // 0x30
	private int height; // 0x34
	private bool initialized; // 0x38
	private WaterRadialMesh radialMesh; // 0x40
	private WaterRendering.RenderState state; // 0x48
	private const int MaxCullingVolumes = 4;
	private const float MaxCullingVolumeDistanceToCamera = 500;
	private const float MaxCullingVolumeSqrDistanceToCamera = 250000;
	private static Vector4[] cullingVolumeArray; // 0x0
	private static Plane[] frustumPlanes; // 0x8
	private Material reflectionMat; // 0x70
	private Material underwaterMat; // 0x78
	private Material multiCopyMat; // 0x80
	private RenderTexture surfaceTex; // 0x88
	private RenderTexture preFogBackgroundTex; // 0x90
	private RenderTexture ssrReflectionTex; // 0x98
	private Mesh overlayMesh; // 0xA0
	private float underwaterScatterCoefficientOverride; // 0xA8
	private MaterialPropertyBlock underwaterBlock; // 0xB0
	private CommandBufferManager commandBufferManager; // 0xB8
	private CommandBufferDesc setGlobalsCBDesc; // 0xC0
	private CommandBufferDesc waterMaskCBDesc; // 0xC8
	private CommandBufferDesc waterDepthCBDesc; // 0xD0
	private CommandBufferDesc preFogCBDesc; // 0xD8
	private CommandBufferDesc postFogCBDesc; // 0xE0
	private RenderTargetIdentifier[] targets; // 0xE8
	private bool initializedMaterials; // 0xF0

	// Properties
	public bool IsInitialized { get; }
	public Material ReflectionMaterial { get; }
	public Material UnderwaterMaterial { get; }
	public MaterialPropertyBlock UnderwaterBlock { get; }

	// Methods

	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120
	public bool get_IsInitialized() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public Material get_ReflectionMaterial() { }

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public Material get_UnderwaterMaterial() { }

	// RVA: 0xC1B5C0 Offset: 0xC1A9C0 VA: 0x180C1B5C0
	public MaterialPropertyBlock get_UnderwaterBlock() { }

	// RVA: 0xC1A7D0 Offset: 0xC19BD0 VA: 0x180C1A7D0
	public void Initialize(WaterSystem water, WaterRuntime runtime, int maxVertexCount) { }

	// RVA: 0xC18570 Offset: 0xC17970 VA: 0x180C18570
	public void Destroy() { }

	// RVA: 0xC18230 Offset: 0xC17630 VA: 0x180C18230
	private void CheckScreenSize() { }

	// RVA: 0xC17580 Offset: 0xC16980 VA: 0x180C17580
	private void CheckCommandBuffer() { }

	// RVA: 0xC182E0 Offset: 0xC176E0 VA: 0x180C182E0
	private void CleanupCommandBuffer() { }

	// RVA: 0xC17B30 Offset: 0xC16F30 VA: 0x180C17B30
	public bool CheckLostData() { }

	// RVA: 0xC17950 Offset: 0xC16D50 VA: 0x180C17950
	private static void CheckCreateRenderTexture(ref RenderTexture rt, string name, int width, int height, RenderTextureFormat format, bool linear, FilterMode filter = 0) { }

	// RVA: 0xC1B1E0 Offset: 0xC1A5E0 VA: 0x180C1B1E0
	private static void SafeDestroyRenderTexture(ref RenderTexture rt) { }

	// RVA: 0xC180C0 Offset: 0xC174C0 VA: 0x180C180C0
	private void CheckRenderTextures() { }

	// RVA: 0xC184D0 Offset: 0xC178D0 VA: 0x180C184D0
	private void CleanupRenderTextures() { }

	// RVA: 0xC17C70 Offset: 0xC17070 VA: 0x180C17C70
	private void CheckOverlayMesh() { }

	// RVA: 0xC18410 Offset: 0xC17810 VA: 0x180C18410
	private void CleanupOverlayMesh() { }

	// RVA: 0xC1A9D0 Offset: 0xC19DD0 VA: 0x180C1A9D0
	private bool IsVisibleToCamera() { }

	// RVA: 0xC196A0 Offset: 0xC18AA0 VA: 0x180C196A0
	private void FillCommandBuffer_SetGlobals(CommandBuffer cb) { }

	// RVA: 0xC19010 Offset: 0xC18410 VA: 0x180C19010
	private void FillCommandBuffer_Mask(CommandBuffer cb) { }

	// RVA: 0xC188F0 Offset: 0xC17CF0 VA: 0x180C188F0
	private void FillCommandBuffer_Depth(CommandBuffer cb) { }

	// RVA: 0xC19590 Offset: 0xC18990 VA: 0x180C19590
	private void FillCommandBuffer_PreFog(CommandBuffer cb) { }

	// RVA: 0xC19340 Offset: 0xC18740 VA: 0x180C19340
	private void FillCommandBuffer_PostFog(CommandBuffer cb) { }

	// RVA: 0xC174F0 Offset: 0xC168F0 VA: 0x180C174F0
	private void CheckAndClearUnderwaterBlock() { }

	// RVA: 0xC18560 Offset: 0xC17960 VA: 0x180C18560
	public void ClearUnderwaterScatterCoefficientOverride() { }

	// RVA: 0xC1B2A0 Offset: 0xC1A6A0 VA: 0x180C1B2A0
	public void SetUnderwaterScatterCoefficientOverride(float scatterCoefficient) { }

	// RVA: 0xC1B480 Offset: 0xC1A880 VA: 0x180C1B480
	public void UpdateUnderwaterMaterial(Material reference) { }

	// RVA: 0xC1A320 Offset: 0xC19720 VA: 0x180C1A320
	public static List<WaterCullingVolume> FindAndSortVisibleCullingVolumes(Camera camera, List<WaterCullingVolume> list) { }

	// RVA: 0xC1AF50 Offset: 0xC1A350 VA: 0x180C1AF50
	public void PrepareRender(int visibilityMask) { }

	// RVA: 0xC1AA80 Offset: 0xC19E80 VA: 0x180C1AA80
	private bool IssueRender(bool debug, bool depthOnly) { }

	// RVA: 0xC1AA70 Offset: 0xC19E70 VA: 0x180C1AA70
	public bool IssueRender(bool debug) { }

	// RVA: 0xC1B2B0 Offset: 0xC1A6B0 VA: 0x180C1B2B0
	public void ShowDebug() { }

	// RVA: 0xC1B520 Offset: 0xC1A920 VA: 0x180C1B520
	public void .ctor() { }

	// RVA: 0xC1B4A0 Offset: 0xC1A8A0 VA: 0x180C1B4A0
	private static void .cctor() { }

}

private struct WaterRendering.RenderState // TypeDefIndex: 10619
{	// Fields
	public Camera camera; // 0x0
	public int layer; // 0x8
	public bool simulation; // 0xC
	public bool displacement; // 0xD
	public int reflections; // 0x10
	public bool caustics; // 0x14
	public int visibilityMask; // 0x18
	public List<WaterCullingVolume> cullingVolumes; // 0x20

}

private sealed class WaterRendering.<>c // TypeDefIndex: 10620
{	// Fields
	public static readonly WaterRendering.<>c <>9; // 0x0
	public static Comparison<WaterCullingVolume> <>9__62_0; // 0x8

	// Methods

	// RVA: 0xC0BA70 Offset: 0xC0AE70 VA: 0x180C0BA70
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xC0BA30 Offset: 0xC0AE30 VA: 0x180C0BA30
	internal int <FindAndSortVisibleCullingVolumes>b__62_0(WaterCullingVolume x, WaterCullingVolume y) { }

}

