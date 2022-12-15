public class WaterRendering // TypeDefIndex: 12388
{
	private WaterSystem water;
	private WaterSimulation simulation;
	private Camera camera;
	private PostOpaqueDepth postOpaqueDepth;
	private int width;
	private int height;
	private bool initialized;
	private WaterRadialMesh radialMesh;
	private WaterRendering.RenderState state;
	private const int MaxCullingVolumes = 4;
	private const float MaxCullingVolumeDistanceToCamera = 500;
	private const float MaxCullingVolumeSqrDistanceToCamera = 250000;
	private static Vector4[] cullingVolumeArray;
	private static Plane[] frustumPlanes;
	private Material reflectionMat;
	private Material underwaterMat;
	private Material multiCopyMat;
	private RenderTexture surfaceTex;
	private RenderTexture preFogBackgroundTex;
	private RenderTexture ssrReflectionTex;
	private Mesh overlayMesh;
	private float underwaterScatterCoefficientOverride;
	private MaterialPropertyBlock underwaterBlock;
	private CommandBufferManager commandBufferManager;
	private CommandBufferDesc setGlobalsCBDesc;
	private CommandBufferDesc waterMaskCBDesc;
	private CommandBufferDesc waterDepthCBDesc;
	private CommandBufferDesc preFogCBDesc;
	private CommandBufferDesc postFogCBDesc;
	private RenderTargetIdentifier[] targets;
	private bool initializedMaterials;

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

private struct WaterRendering.RenderState // TypeDefIndex: 12389
{
	public Camera camera;
	public int layer;
	public bool simulation;
	public bool displacement;
	public int reflections;
	public bool caustics;
	public int visibilityMask;
	public List<WaterCullingVolume> cullingVolumes;

}

private sealed class WaterRendering.<>c // TypeDefIndex: 12390
{
	public static readonly WaterRendering.<>c <>9;
	public static Comparison<WaterCullingVolume> <>9__62_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal int <FindAndSortVisibleCullingVolumes>

}

