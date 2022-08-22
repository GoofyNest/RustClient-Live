public class DeferredExtension : MonoBehaviour // TypeDefIndex: 10656
{	public ExtendGBufferParams extendGBuffer; // 0x18
	public SubsurfaceScatteringParams subsurfaceScattering; // 0x1C
	public Texture2D blueNoise; // 0x30
	public float depthScale; // 0x38
	public bool debug; // 0x3C
	public bool forceToCameraResolution; // 0x3D
	private Camera _targetCamera; // 0x40
	private CommandBufferManager commandBufferManager; // 0x48
	private CommandBufferDesc extendGBufferCBDesc; // 0x50
	private CommandBufferDesc postSubsurfaceCBDesc; // 0x58
	private Material postSubsurfaceMat; // 0x60
	private int frameIndexMod8; // 0x68
	private PostProcessLayer post; // 0x70
	private int gbufferWidth; // 0x78
	private int gbufferHeight; // 0x7C
	private RenderTexture gbufferTexture4; // 0x80
	private RenderTexture gbufferTexture5; // 0x88
	private RenderTargetIdentifier[] targets; // 0x90
	private static HashSet<DeferredExtensionMesh> registeredMeshes; // 0x0
	private static HashSet<DeferredExtensionMesh> visibleMeshes; // 0x8

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
	|-RVA: 0x15402B0 Offset: 0x153F6B0 VA: 0x1815402B0
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

private enum DeferredExtension.SubsurfacePass // TypeDefIndex: 10657
{	public int value__; // 0x0
	public const DeferredExtension.SubsurfacePass SetupFullRes = 0;
	public const DeferredExtension.SubsurfacePass SetupHalfRes = 1;
	public const DeferredExtension.SubsurfacePass Direction0 = 2;
	public const DeferredExtension.SubsurfacePass Direction1 = 3;
	public const DeferredExtension.SubsurfacePass RecombineFullRes = 4;
	public const DeferredExtension.SubsurfacePass RecombineHalfRes = 5;
	public const DeferredExtension.SubsurfacePass RecombinePassthrough = 6;

}

