public class ReflectionProbeEx : MonoBehaviour // TypeDefIndex: 12420
{
	private static readonly uint[,] qualitySamples; 
	private static Vector4[] sampleData; 
	private Mesh blitMesh; 
	private Mesh skyboxMesh; 
	private static float[] octaVerts; 
	private static readonly ReflectionProbeEx.CubemapFaceMatrices[] cubemapFaceMatrices; 
	private static readonly ReflectionProbeEx.CubemapFaceMatrices[] cubemapFaceMatricesD3D11; 
	private static readonly ReflectionProbeEx.CubemapFaceMatrices[] shadowCubemapFaceMatrices; 
	private ReflectionProbeEx.CubemapFaceMatrices[] platformCubemapFaceMatrices; 
	private static readonly HashSet<string> supportedShaderNames; 
	private static Dictionary<Shader, Shader> supportedShaders; 
	private static Dictionary<Material, Material> matchingMaterials; 
	private RenderTexture probeTempTexture; 
	private RenderTexture probeShadowTexture; 
	private RenderTexture arrayTexture; 
	private RenderTexture arrayTempTexture; 
	private RenderTexture arrayDepthTexture; 
	private int mipmapCount; 
	private Material blitMaterial; 
	private Material filterMaterial; 
	private Material shadowMaterial; 
	private CommandBuffer forwardCB; 
	private CommandBuffer shadowCB; 
	private Matrix4x4[] viewProjMatrixArray; 
	private Matrix4x4[] objectToWorldArray; 
	private Matrix4x4[] cameraToWorldArray; 
	private bool useGeometryShader; 
	private int PassCount; 
	private static readonly int[] tab32; 
	public ReflectionProbeRefreshMode refreshMode; 
	public bool timeSlicing; 
	public int resolution; 
	[InspectorNameAttribute] 
	public bool hdr; 
	public float shadowDistance; 
	public ReflectionProbeClearFlags clearFlags; 
	public Color background; 
	public float nearClip; 
	public float farClip; 
	public Transform attachToTarget; 
	public Light directionalLight; 
	public float textureMipBias; 
	public bool highPrecision; 
	public bool enableShadows; 
	public ReflectionProbeEx.ConvolutionQuality convolutionQuality; 
	public List<ReflectionProbeEx.RenderListEntry> staticRenderList; 
	public Cubemap reflectionCubemap; 
	public float reflectionIntensity; 
	private List<ReflectionProbeEx.RenderListEntry> dynamicRenderList; 
	private ReflectionProbe probe; 
	private RenderTexture probeTexture; 
	private int probeResolution; 
	private bool probeHdr; 
	private float probeShadowDistance; 
	private float probeNearClip; 
	private float probeFarClip; 
	private const int probeDepth = 24;
	private bool probeHighPrecision; 
	private ReflectionProbeEx.TimeSlicingState timeSlicedRenderState; 
	private bool scriptingRenderQueued; 
	private Matrix4x4 faceProjMatrix; 
	private Matrix4x4 faceProjInvMatrix; 
	private int prevFrame; 
	private ReflectionProbeRefreshMode savedProbeRefresh; 
	private ReflectionProbeMode savedProbeMode; 
	private Texture savedProbeCustomTexture; 

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

private struct ReflectionProbeEx.CubemapSkyboxVertex // TypeDefIndex: 12421
{
	public float x; 
	public float y; 
	public float z; 
	public Color color; 
	public float tu; 
	public float tv; 
	public float tw; 

}

private struct ReflectionProbeEx.CubemapFaceMatrices // TypeDefIndex: 12422
{
	public Matrix4x4 worldToView; 
	public Matrix4x4 viewToWorld; 


	public void .ctor(Vector3 x, Vector3 y, Vector3 z) { }

}

public enum ReflectionProbeEx.ConvolutionQuality // TypeDefIndex: 12423
{
	public int value__; 
	public const ReflectionProbeEx.ConvolutionQuality Lowest = 0;
	public const ReflectionProbeEx.ConvolutionQuality Low = 1;
	public const ReflectionProbeEx.ConvolutionQuality Medium = 2;
	public const ReflectionProbeEx.ConvolutionQuality High = 3;
	public const ReflectionProbeEx.ConvolutionQuality VeryHigh = 4;

}

public struct ReflectionProbeEx.RenderListEntry // TypeDefIndex: 12424
{
	public Renderer renderer; 
	public bool alwaysEnabled; 


	public void .ctor(Renderer renderer, bool alwaysEnabled) { }

}

private enum ReflectionProbeEx.TimeSlicingState // TypeDefIndex: 12425
{
	public int value__; 
	public const ReflectionProbeEx.TimeSlicingState Shadow = 0;
	public const ReflectionProbeEx.TimeSlicingState Render = 1;
	public const ReflectionProbeEx.TimeSlicingState GenerateMips = 2;
	public const ReflectionProbeEx.TimeSlicingState Convolution = 3;
	public const ReflectionProbeEx.TimeSlicingState Finished = 4;

}

