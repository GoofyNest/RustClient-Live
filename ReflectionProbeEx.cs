public class ReflectionProbeEx : MonoBehaviour // TypeDefIndex: 10689
{	private static readonly uint[,] qualitySamples; // 0x0
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

	public RenderTexture Texture { get; }


	private Vector2 Hammersley(uint index, uint numSamples) { }

	private float D_GGX(float roughness, float NdotH) { }

	private Vector3 ImportanceSampleGGX(Vector2 Xi, float roughness) { }

	private void ApplyConvolution(Texture target) { }

	private void CreateMeshes() { }

	private void DestroyMeshes() { }

	private static Mesh CreateBlitMesh() { }

	private static ReflectionProbeEx.CubemapSkyboxVertex SubDivVert(ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2) { }

	private static void Subdivide(List<ReflectionProbeEx.CubemapSkyboxVertex> destArray, ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2, ReflectionProbeEx.CubemapSkyboxVertex v3) { }

	private static void SubdivideYOnly(List<ReflectionProbeEx.CubemapSkyboxVertex> destArray, ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2, ReflectionProbeEx.CubemapSkyboxVertex v3) { }

	private static Mesh CreateSkyboxMesh() { }

	private bool InitializeCubemapFaceMatrices() { }

	private void CreateTextures() { }

	private void DestroyTextures() { }

	private Material RegisterMaterialReplacement(Material material) { }

	private Material FindMaterialReplacement(Material material) { }

	private void CreateMaterials() { }

	private void DestroyMaterials() { }

	private void CreateCommandBuffers() { }

	private void DestroyCommandBuffers() { }

	private void ClearCommandBuffers() { }

	private void AttachToLight() { }

	private void DetachFromLight() { }

	private void FindEnvironmentReflection() { }

	private void BindGlobalProperties() { }

	private void BindGlobalLight() { }

	private void BindGlobalAmbient() { }

	private void BindGlobalReflection() { }

	private void RenderObjects() { }

	private void RenderSkybox() { }

	private void IssueRender() { }

	private void IssueGenerateMips() { }

	private void IssueConvolution() { }

	private void IssueShadow() { }

	private void PrepareFullRender() { }

	private void PrepareTimeSlicedRender(ReflectionProbeEx.TimeSlicingState state) { }

	private void ExecuteRender() { }

	private int FastLog2(int value) { }

	private uint ReverseBits(uint bits) { }

	private void SafeCreateMaterial(ref Material mat, Shader shader) { }

	private void SafeCreateMaterial(ref Material mat, string shaderName) { }

	private void SafeCreateCubeRT(ref RenderTexture rt, string name, int size, int depth, bool mips, TextureDimension dim, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite = 1) { }

	private void SafeCreateCB(ref CommandBuffer cb, string name) { }

	private void SafeDestroy<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-ReflectionProbeEx.SafeDestroy<object>
	|-ReflectionProbeEx.SafeDestroy<Material>
	|-ReflectionProbeEx.SafeDestroy<RenderTexture>
	*/

	private void SafeDispose<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-ReflectionProbeEx.SafeDispose<object>
	|-ReflectionProbeEx.SafeDispose<CommandBuffer>
	*/

	public RenderTexture get_Texture() { }

	public void ClearRenderList() { }

	public void AddToRenderList(Renderer renderer, bool alwaysEnabled = False) { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void OnCameraPreRender(Camera cam) { }

	public void RenderProbe() { }

	public bool IsFinishedRendering() { }

	private void ModifyProbeProperties() { }

	private void RestoreProbeSettings() { }

	private bool UpdateProperties() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct ReflectionProbeEx.CubemapSkyboxVertex // TypeDefIndex: 10690
{	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public Color color; // 0xC
	public float tu; // 0x1C
	public float tv; // 0x20
	public float tw; // 0x24

}

private struct ReflectionProbeEx.CubemapFaceMatrices // TypeDefIndex: 10691
{	public Matrix4x4 worldToView; // 0x0
	public Matrix4x4 viewToWorld; // 0x40


	public void .ctor(Vector3 x, Vector3 y, Vector3 z) { }

}

public enum ReflectionProbeEx.ConvolutionQuality // TypeDefIndex: 10692
{	public int value__; // 0x0
	public const ReflectionProbeEx.ConvolutionQuality Lowest = 0;
	public const ReflectionProbeEx.ConvolutionQuality Low = 1;
	public const ReflectionProbeEx.ConvolutionQuality Medium = 2;
	public const ReflectionProbeEx.ConvolutionQuality High = 3;
	public const ReflectionProbeEx.ConvolutionQuality VeryHigh = 4;

}

public struct ReflectionProbeEx.RenderListEntry // TypeDefIndex: 10693
{	public Renderer renderer; // 0x0
	public bool alwaysEnabled; // 0x8


	public void .ctor(Renderer renderer, bool alwaysEnabled) { }

}

private enum ReflectionProbeEx.TimeSlicingState // TypeDefIndex: 10694
{	public int value__; // 0x0
	public const ReflectionProbeEx.TimeSlicingState Shadow = 0;
	public const ReflectionProbeEx.TimeSlicingState Render = 1;
	public const ReflectionProbeEx.TimeSlicingState GenerateMips = 2;
	public const ReflectionProbeEx.TimeSlicingState Convolution = 3;
	public const ReflectionProbeEx.TimeSlicingState Finished = 4;

}

