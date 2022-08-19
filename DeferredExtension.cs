public class DeferredExtension : MonoBehaviour // TypeDefIndex: 10656
{	// Fields
	public ExtendGBufferParams extendGBuffer; // 0x18
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

	// Properties
	private Camera targetCamera { get; }
	private int TargetWidth { get; }
	private int TargetHeight { get; }

	// Methods

	// RVA: 0x8F05F0 Offset: 0x8EF9F0 VA: 0x1808F05F0
	private Camera get_targetCamera() { }

	// RVA: 0x8F0540 Offset: 0x8EF940 VA: 0x1808F0540
	private int get_TargetWidth() { }

	// RVA: 0x8F0490 Offset: 0x8EF890 VA: 0x1808F0490
	private int get_TargetHeight() { }

	// RVA: 0x8EFC50 Offset: 0x8EF050 VA: 0x1808EFC50
	public static void Register(DeferredExtensionMesh mesh) { }

	// RVA: 0x8F0190 Offset: 0x8EF590 VA: 0x1808F0190
	public static void Unregister(DeferredExtensionMesh mesh) { }

	// RVA: 0x8EFB20 Offset: 0x8EEF20 VA: 0x1808EFB20
	private void OnEnable() { }

	// RVA: 0x8EF990 Offset: 0x8EED90 VA: 0x1808EF990
	private void OnDisable() { }

	// RVA: 0x8EE670 Offset: 0x8EDA70 VA: 0x1808EE670
	private void CheckCommandBuffers() { }

	// RVA: 0x8EEC10 Offset: 0x8EE010 VA: 0x1808EEC10
	private void CleanupCommandBuffers() { }

	// RVA: 0x8EEDF0 Offset: 0x8EE1F0 VA: 0x1808EEDF0
	private void CreateMaterials() { }

	// RVA: 0x8EECE0 Offset: 0x8EE0E0 VA: 0x1808EECE0
	private void CleanupMaterials() { }

	// RVA: 0x8EE580 Offset: 0x8ED980 VA: 0x1808EE580
	private void BindSystemTextures() { }

	// RVA: -1 Offset: -1
	private void SafeCleanupTexture<T>(ref T tex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15402B0 Offset: 0x153F6B0 VA: 0x1815402B0
	|-DeferredExtension.SafeCleanupTexture<object>
	|-DeferredExtension.SafeCleanupTexture<RenderTexture>
	*/

	// RVA: 0x8EED90 Offset: 0x8EE190 VA: 0x1808EED90
	private void CleanupSystemTextures() { }

	// RVA: 0x8EE980 Offset: 0x8EDD80 VA: 0x1808EE980
	private void CheckSystemTextures() { }

	// RVA: 0x8EE500 Offset: 0x8ED900 VA: 0x1808EE500
	public static void BecameVisible(DeferredExtensionMesh mesh) { }

	// RVA: 0x8EE480 Offset: 0x8ED880 VA: 0x1808EE480
	public static void BecameInvisible(DeferredExtensionMesh mesh) { }

	// RVA: 0x8EEE90 Offset: 0x8EE290 VA: 0x1808EEE90
	public void FillCommandBuffer_ExtendGBuffer(CommandBuffer cb) { }

	// RVA: 0x8EF150 Offset: 0x8EE550 VA: 0x1808EF150
	public void FillCommandBuffer_PostSubsurface(CommandBuffer cb) { }

	// RVA: 0x8EE860 Offset: 0x8EDC60 VA: 0x1808EE860
	private void CheckConsoleVars() { }

	// RVA: 0x8EE900 Offset: 0x8EDD00 VA: 0x1808EE900
	private void CheckShaderKeywords() { }

	// RVA: 0x8EFCD0 Offset: 0x8EF0D0 VA: 0x1808EFCD0
	private void SetShaderGlobals() { }

	// RVA: 0x8F0210 Offset: 0x8EF610 VA: 0x1808F0210
	private void Update() { }

	// RVA: 0x8EFC40 Offset: 0x8EF040 VA: 0x1808EFC40
	private void OnPreRender() { }

	// RVA: 0x8EF920 Offset: 0x8EED20 VA: 0x1808EF920
	public static float LightIntensityScale(float intensity) { }

	// RVA: 0x8F03C0 Offset: 0x8EF7C0 VA: 0x1808F03C0
	public void .ctor() { }

	// RVA: 0x8F0320 Offset: 0x8EF720 VA: 0x1808F0320
	private static void .cctor() { }

}

private enum DeferredExtension.SubsurfacePass // TypeDefIndex: 10657
{	// Fields
	public int value__; // 0x0
	public const DeferredExtension.SubsurfacePass SetupFullRes = 0;
	public const DeferredExtension.SubsurfacePass SetupHalfRes = 1;
	public const DeferredExtension.SubsurfacePass Direction0 = 2;
	public const DeferredExtension.SubsurfacePass Direction1 = 3;
	public const DeferredExtension.SubsurfacePass RecombineFullRes = 4;
	public const DeferredExtension.SubsurfacePass RecombineHalfRes = 5;
	public const DeferredExtension.SubsurfacePass RecombinePassthrough = 6;

}

