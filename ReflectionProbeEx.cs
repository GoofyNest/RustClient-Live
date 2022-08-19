public class ReflectionProbeEx : MonoBehaviour // TypeDefIndex: 10689
{	// Fields
	private static readonly uint[,] qualitySamples; // 0x0
	private static Vector4[] sampleData; // 0x8
	private Mesh blitMesh; // 0x18
	private Mesh skyboxMesh; // 0x20
	private static float[] octaVerts; // 0x10
	private static readonly ReflectionProbeEx.CubemapFaceMatrices[] cubemapFaceMatrices; // 0x18
	private static readonly ReflectionProbeEx.CubemapFaceMatrices[] cubemapFaceMatricesD3D11; // 0x20
	private static readonly ReflectionProbeEx.CubemapFaceMatrices[] shadowCubemapFaceMatrices; // 0x28
	private ReflectionProbeEx.CubemapFaceMatrices[] platformCubemapFaceMatrices; // 0x28
	private static readonly HashSet<string> supportedShaderNames; // 0x30
	private static Dictionary<Shader, Shader> supportedShaders; // 0x38
	private static Dictionary<Material, Material> matchingMaterials; // 0x40
	private RenderTexture probeTempTexture; // 0x30
	private RenderTexture probeShadowTexture; // 0x38
	private RenderTexture arrayTexture; // 0x40
	private RenderTexture arrayTempTexture; // 0x48
	private RenderTexture arrayDepthTexture; // 0x50
	private int mipmapCount; // 0x58
	private Material blitMaterial; // 0x60
	private Material filterMaterial; // 0x68
	private Material shadowMaterial; // 0x70
	private CommandBuffer forwardCB; // 0x78
	private CommandBuffer shadowCB; // 0x80
	private Matrix4x4[] viewProjMatrixArray; // 0x88
	private Matrix4x4[] objectToWorldArray; // 0x90
	private Matrix4x4[] cameraToWorldArray; // 0x98
	private bool useGeometryShader; // 0xA0
	private int PassCount; // 0xA4
	private static readonly int[] tab32; // 0x48
	public ReflectionProbeRefreshMode refreshMode; // 0xA8
	public bool timeSlicing; // 0xAC
	public int resolution; // 0xB0
	[InspectorNameAttribute] // RVA: 0x71790 Offset: 0x70B90 VA: 0x180071790
	public bool hdr; // 0xB4
	public float shadowDistance; // 0xB8
	public ReflectionProbeClearFlags clearFlags; // 0xBC
	public Color background; // 0xC0
	public float nearClip; // 0xD0
	public float farClip; // 0xD4
	public Transform attachToTarget; // 0xD8
	public Light directionalLight; // 0xE0
	public float textureMipBias; // 0xE8
	public bool highPrecision; // 0xEC
	public bool enableShadows; // 0xED
	public ReflectionProbeEx.ConvolutionQuality convolutionQuality; // 0xF0
	public List<ReflectionProbeEx.RenderListEntry> staticRenderList; // 0xF8
	public Cubemap reflectionCubemap; // 0x100
	public float reflectionIntensity; // 0x108
	private List<ReflectionProbeEx.RenderListEntry> dynamicRenderList; // 0x110
	private ReflectionProbe probe; // 0x118
	private RenderTexture probeTexture; // 0x120
	private int probeResolution; // 0x128
	private bool probeHdr; // 0x12C
	private float probeShadowDistance; // 0x130
	private float probeNearClip; // 0x134
	private float probeFarClip; // 0x138
	private const int probeDepth = 24;
	private bool probeHighPrecision; // 0x13C
	private ReflectionProbeEx.TimeSlicingState timeSlicedRenderState; // 0x140
	private bool scriptingRenderQueued; // 0x144
	private Matrix4x4 faceProjMatrix; // 0x148
	private Matrix4x4 faceProjInvMatrix; // 0x188
	private int prevFrame; // 0x1C8
	private ReflectionProbeRefreshMode savedProbeRefresh; // 0x1CC
	private ReflectionProbeMode savedProbeMode; // 0x1D0
	private Texture savedProbeCustomTexture; // 0x1D8

	// Properties
	public RenderTexture Texture { get; }

	// Methods

	// RVA: 0x9228C0 Offset: 0x921CC0 VA: 0x1809228C0
	private Vector2 Hammersley(uint index, uint numSamples) { }

	// RVA: 0x922160 Offset: 0x921560 VA: 0x180922160
	private float D_GGX(float roughness, float NdotH) { }

	// RVA: 0x922990 Offset: 0x921D90 VA: 0x180922990
	private Vector3 ImportanceSampleGGX(Vector2 Xi, float roughness) { }

	// RVA: 0x91EF90 Offset: 0x91E390 VA: 0x18091EF90
	private void ApplyConvolution(Texture target) { }

	// RVA: 0x9210E0 Offset: 0x9204E0 VA: 0x1809210E0
	private void CreateMeshes() { }

	// RVA: 0x922270 Offset: 0x921670 VA: 0x180922270
	private void DestroyMeshes() { }

	// RVA: 0x9209E0 Offset: 0x91FDE0 VA: 0x1809209E0
	private static Mesh CreateBlitMesh() { }

	// RVA: 0x925D90 Offset: 0x925190 VA: 0x180925D90
	private static ReflectionProbeEx.CubemapSkyboxVertex SubDivVert(ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2) { }

	// RVA: 0x926540 Offset: 0x925940 VA: 0x180926540
	private static void Subdivide(List<ReflectionProbeEx.CubemapSkyboxVertex> destArray, ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2, ReflectionProbeEx.CubemapSkyboxVertex v3) { }

	// RVA: 0x925F20 Offset: 0x925320 VA: 0x180925F20
	private static void SubdivideYOnly(List<ReflectionProbeEx.CubemapSkyboxVertex> destArray, ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2, ReflectionProbeEx.CubemapSkyboxVertex v3) { }

	// RVA: 0x9211F0 Offset: 0x9205F0 VA: 0x1809211F0
	private static Mesh CreateSkyboxMesh() { }

	// RVA: 0x922A90 Offset: 0x921E90 VA: 0x180922A90
	private bool InitializeCubemapFaceMatrices() { }

	// RVA: 0x921C60 Offset: 0x921060 VA: 0x180921C60
	private void CreateTextures() { }

	// RVA: 0x9223A0 Offset: 0x9217A0 VA: 0x1809223A0
	private void DestroyTextures() { }

	// RVA: 0x9245A0 Offset: 0x9239A0 VA: 0x1809245A0
	private Material RegisterMaterialReplacement(Material material) { }

	// RVA: 0x9227D0 Offset: 0x921BD0 VA: 0x1809227D0
	private Material FindMaterialReplacement(Material material) { }

	// RVA: 0x920DE0 Offset: 0x9201E0 VA: 0x180920DE0
	private void CreateMaterials() { }

	// RVA: 0x922200 Offset: 0x921600 VA: 0x180922200
	private void DestroyMaterials() { }

	// RVA: 0x920D40 Offset: 0x920140 VA: 0x180920D40
	private void CreateCommandBuffers() { }

	// RVA: 0x9221A0 Offset: 0x9215A0 VA: 0x1809221A0
	private void DestroyCommandBuffers() { }

	// RVA: 0x9208F0 Offset: 0x91FCF0 VA: 0x1809208F0
	private void ClearCommandBuffers() { }

	// RVA: 0x91F730 Offset: 0x91EB30 VA: 0x18091F730
	private void AttachToLight() { }

	// RVA: 0x922450 Offset: 0x921850 VA: 0x180922450
	private void DetachFromLight() { }

	// RVA: 0x922660 Offset: 0x921A60 VA: 0x180922660
	private void FindEnvironmentReflection() { }

	// RVA: 0x9205A0 Offset: 0x91F9A0 VA: 0x1809205A0
	private void BindGlobalProperties() { }

	// RVA: 0x920110 Offset: 0x91F510 VA: 0x180920110
	private void BindGlobalLight() { }

	// RVA: 0x91F850 Offset: 0x91EC50 VA: 0x18091F850
	private void BindGlobalAmbient() { }

	// RVA: 0x9206A0 Offset: 0x91FAA0 VA: 0x1809206A0
	private void BindGlobalReflection() { }

	// RVA: 0x924980 Offset: 0x923D80 VA: 0x180924980
	private void RenderObjects() { }

	// RVA: 0x9252D0 Offset: 0x9246D0 VA: 0x1809252D0
	private void RenderSkybox() { }

	// RVA: 0x923000 Offset: 0x922400 VA: 0x180923000
	private void IssueRender() { }

	// RVA: 0x922F20 Offset: 0x922320 VA: 0x180922F20
	private void IssueGenerateMips() { }

	// RVA: 0x922C00 Offset: 0x922000 VA: 0x180922C00
	private void IssueConvolution() { }

	// RVA: 0x923230 Offset: 0x922630 VA: 0x180923230
	private void IssueShadow() { }

	// RVA: 0x924390 Offset: 0x923790 VA: 0x180924390
	private void PrepareFullRender() { }

	// RVA: 0x924470 Offset: 0x923870 VA: 0x180924470
	private void PrepareTimeSlicedRender(ReflectionProbeEx.TimeSlicingState state) { }

	// RVA: 0x922520 Offset: 0x921920 VA: 0x180922520
	private void ExecuteRender() { }

	// RVA: 0x9225B0 Offset: 0x9219B0 VA: 0x1809225B0
	private int FastLog2(int value) { }

	// RVA: 0x925900 Offset: 0x924D00 VA: 0x180925900
	private uint ReverseBits(uint bits) { }

	// RVA: 0x925CF0 Offset: 0x9250F0 VA: 0x180925CF0
	private void SafeCreateMaterial(ref Material mat, Shader shader) { }

	// RVA: 0x925BF0 Offset: 0x924FF0 VA: 0x180925BF0
	private void SafeCreateMaterial(ref Material mat, string shaderName) { }

	// RVA: 0x925A00 Offset: 0x924E00 VA: 0x180925A00
	private void SafeCreateCubeRT(ref RenderTexture rt, string name, int size, int depth, bool mips, TextureDimension dim, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite = 1) { }

	// RVA: 0x925970 Offset: 0x924D70 VA: 0x180925970
	private void SafeCreateCB(ref CommandBuffer cb, string name) { }

	// RVA: -1 Offset: -1
	private void SafeDestroy<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF9A80 Offset: 0xCF8E80 VA: 0x180CF9A80
	|-ReflectionProbeEx.SafeDestroy<object>
	|-ReflectionProbeEx.SafeDestroy<Material>
	|-ReflectionProbeEx.SafeDestroy<RenderTexture>
	*/

	// RVA: -1 Offset: -1
	private void SafeDispose<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF9B20 Offset: 0xCF8F20 VA: 0x180CF9B20
	|-ReflectionProbeEx.SafeDispose<object>
	|-ReflectionProbeEx.SafeDispose<CommandBuffer>
	*/

	// RVA: 0x7F5E00 Offset: 0x7F5200 VA: 0x1807F5E00
	public RenderTexture get_Texture() { }

	// RVA: 0x920990 Offset: 0x91FD90 VA: 0x180920990
	public void ClearRenderList() { }

	// RVA: 0x91EED0 Offset: 0x91E2D0 VA: 0x18091EED0
	public void AddToRenderList(Renderer renderer, bool alwaysEnabled = False) { }

	// RVA: 0x91F800 Offset: 0x91EC00 VA: 0x18091F800
	private void Awake() { }

	// RVA: 0x923EA0 Offset: 0x9232A0 VA: 0x180923EA0
	private void OnEnable() { }

	// RVA: 0x923B80 Offset: 0x922F80 VA: 0x180923B80
	private void OnDisable() { }

	// RVA: 0x9236D0 Offset: 0x922AD0 VA: 0x1809236D0
	private void OnCameraPreRender(Camera cam) { }

	// RVA: 0x9252B0 Offset: 0x9246B0 VA: 0x1809252B0
	public void RenderProbe() { }

	// RVA: 0x922BE0 Offset: 0x921FE0 VA: 0x180922BE0
	public bool IsFinishedRendering() { }

	// RVA: 0x9235B0 Offset: 0x9229B0 VA: 0x1809235B0
	private void ModifyProbeProperties() { }

	// RVA: 0x925840 Offset: 0x924C40 VA: 0x180925840
	private void RestoreProbeSettings() { }

	// RVA: 0x926940 Offset: 0x925D40 VA: 0x180926940
	private bool UpdateProperties() { }

	// RVA: 0x928C70 Offset: 0x928070 VA: 0x180928C70
	public void .ctor() { }

	// RVA: 0x926C20 Offset: 0x926020 VA: 0x180926C20
	private static void .cctor() { }

}

private struct ReflectionProbeEx.CubemapSkyboxVertex // TypeDefIndex: 10690
{	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public Color color; // 0xC
	public float tu; // 0x1C
	public float tv; // 0x20
	public float tw; // 0x24

}

private struct ReflectionProbeEx.CubemapFaceMatrices // TypeDefIndex: 10691
{	// Fields
	public Matrix4x4 worldToView; // 0x0
	public Matrix4x4 viewToWorld; // 0x40

	// Methods

	// RVA: 0xF9F20 Offset: 0xF9320 VA: 0x1800F9F20
	public void .ctor(Vector3 x, Vector3 y, Vector3 z) { }

}

public enum ReflectionProbeEx.ConvolutionQuality // TypeDefIndex: 10692
{	// Fields
	public int value__; // 0x0
	public const ReflectionProbeEx.ConvolutionQuality Lowest = 0;
	public const ReflectionProbeEx.ConvolutionQuality Low = 1;
	public const ReflectionProbeEx.ConvolutionQuality Medium = 2;
	public const ReflectionProbeEx.ConvolutionQuality High = 3;
	public const ReflectionProbeEx.ConvolutionQuality VeryHigh = 4;

}

public struct ReflectionProbeEx.RenderListEntry // TypeDefIndex: 10693
{	// Fields
	public Renderer renderer; // 0x0
	public bool alwaysEnabled; // 0x8

	// Methods

	// RVA: 0xF9F90 Offset: 0xF9390 VA: 0x1800F9F90
	public void .ctor(Renderer renderer, bool alwaysEnabled) { }

}

private enum ReflectionProbeEx.TimeSlicingState // TypeDefIndex: 10694
{	// Fields
	public int value__; // 0x0
	public const ReflectionProbeEx.TimeSlicingState Shadow = 0;
	public const ReflectionProbeEx.TimeSlicingState Render = 1;
	public const ReflectionProbeEx.TimeSlicingState GenerateMips = 2;
	public const ReflectionProbeEx.TimeSlicingState Convolution = 3;
	public const ReflectionProbeEx.TimeSlicingState Finished = 4;

}

