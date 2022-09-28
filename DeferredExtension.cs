public class DeferredExtension : MonoBehaviour // TypeDefIndex: 12335
{
	public ExtendGBufferParams extendGBuffer; 
	public SubsurfaceScatteringParams subsurfaceScattering; 
	public Texture2D blueNoise; 
	public float depthScale; 
	public bool debug; 
	public bool forceToCameraResolution; 
	private Camera _targetCamera; 
	private CommandBufferManager commandBufferManager; 
	private CommandBufferDesc extendGBufferCBDesc; 
	private CommandBufferDesc postSubsurfaceCBDesc; 
	private Material postSubsurfaceMat; 
	private int frameIndexMod8; 
	private PostProcessLayer post; 
	private int gbufferWidth; 
	private int gbufferHeight; 
	private RenderTexture gbufferTexture4; 
	private RenderTexture gbufferTexture5; 
	private RenderTargetIdentifier[] targets; 
	private static HashSet<DeferredExtensionMesh> registeredMeshes; 
	private static HashSet<DeferredExtensionMesh> visibleMeshes; 

	private Camera targetCamera { get; }
	private int TargetWidth { get; }
	private int TargetHeight { get; }


	private Camera get_targetCamera() { }

	private int get_TargetWidth() { }

	private int get_TargetHeight() { }

	public static void Register(DeferredExtensionMesh mesh) { }

	public static void Unregister(DeferredExtensionMesh mesh) { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void CheckCommandBuffers() { }

	private void CleanupCommandBuffers() { }

	private void CreateMaterials() { }

	private void CleanupMaterials() { }

	private void BindSystemTextures() { }

	private void SafeCleanupTexture<T>(ref T tex) { }
	/* GenericInstMethod :
	|
	|-DeferredExtension.SafeCleanupTexture<object>
	|-DeferredExtension.SafeCleanupTexture<RenderTexture>
	*/

	private void CleanupSystemTextures() { }

	private void CheckSystemTextures() { }

	public static void BecameVisible(DeferredExtensionMesh mesh) { }

	public static void BecameInvisible(DeferredExtensionMesh mesh) { }

	public void FillCommandBuffer_ExtendGBuffer(CommandBuffer cb) { }

	public void FillCommandBuffer_PostSubsurface(CommandBuffer cb) { }

	private void CheckConsoleVars() { }

	private void CheckShaderKeywords() { }

	private void SetShaderGlobals() { }

	private void Update() { }

	private void OnPreRender() { }

	public static float LightIntensityScale(float intensity) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private enum DeferredExtension.SubsurfacePass // TypeDefIndex: 12336
{
	public int value__; 
	public const DeferredExtension.SubsurfacePass SetupFullRes = 0;
	public const DeferredExtension.SubsurfacePass SetupHalfRes = 1;
	public const DeferredExtension.SubsurfacePass Direction0 = 2;
	public const DeferredExtension.SubsurfacePass Direction1 = 3;
	public const DeferredExtension.SubsurfacePass RecombineFullRes = 4;
	public const DeferredExtension.SubsurfacePass RecombineHalfRes = 5;
	public const DeferredExtension.SubsurfacePass RecombinePassthrough = 6;

}

