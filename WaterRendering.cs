public class WaterRendering // TypeDefIndex: 10618
{	private WaterSystem water; // 0x10
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

	public bool IsInitialized { get; }
	public Material ReflectionMaterial { get; }
	public Material UnderwaterMaterial { get; }
	public MaterialPropertyBlock UnderwaterBlock { get; }


	public bool get_IsInitialized() { }

	public Material get_ReflectionMaterial() { }

	public Material get_UnderwaterMaterial() { }

	public MaterialPropertyBlock get_UnderwaterBlock() { }

	public void Initialize(WaterSystem water, WaterRuntime runtime, int maxVertexCount) { }

	public void Destroy() { }

	private void CheckScreenSize() { }

	private void CheckCommandBuffer() { }

	private void CleanupCommandBuffer() { }

	public bool CheckLostData() { }

	private static void CheckCreateRenderTexture(ref RenderTexture rt, string name, int width, int height, RenderTextureFormat format, bool linear, FilterMode filter = 0) { }

	private static void SafeDestroyRenderTexture(ref RenderTexture rt) { }

	private void CheckRenderTextures() { }

	private void CleanupRenderTextures() { }

	private void CheckOverlayMesh() { }

	private void CleanupOverlayMesh() { }

	private bool IsVisibleToCamera() { }

	private void FillCommandBuffer_SetGlobals(CommandBuffer cb) { }

	private void FillCommandBuffer_Mask(CommandBuffer cb) { }

	private void FillCommandBuffer_Depth(CommandBuffer cb) { }

	private void FillCommandBuffer_PreFog(CommandBuffer cb) { }

	private void FillCommandBuffer_PostFog(CommandBuffer cb) { }

	private void CheckAndClearUnderwaterBlock() { }

	public void ClearUnderwaterScatterCoefficientOverride() { }

	public void SetUnderwaterScatterCoefficientOverride(float scatterCoefficient) { }

	public void UpdateUnderwaterMaterial(Material reference) { }

	public static List<WaterCullingVolume> FindAndSortVisibleCullingVolumes(Camera camera, List<WaterCullingVolume> list) { }

	public void PrepareRender(int visibilityMask) { }

	private bool IssueRender(bool debug, bool depthOnly) { }

	public bool IssueRender(bool debug) { }

	public void ShowDebug() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct WaterRendering.RenderState // TypeDefIndex: 10619
{	public Camera camera; // 0x0
	public int layer; // 0x8
	public bool simulation; // 0xC
	public bool displacement; // 0xD
	public int reflections; // 0x10
	public bool caustics; // 0x14
	public int visibilityMask; // 0x18
	public List<WaterCullingVolume> cullingVolumes; // 0x20

}

private sealed class WaterRendering.<>c // TypeDefIndex: 10620
{	public static readonly WaterRendering.<>c <>9; // 0x0
	public static Comparison<WaterCullingVolume> <>9__62_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <FindAndSortVisibleCullingVolumes>b__62_0(WaterCullingVolume x, WaterCullingVolume y) { }

}

