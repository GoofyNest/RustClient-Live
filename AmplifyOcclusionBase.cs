public class AmplifyOcclusionBase : MonoBehaviour // TypeDefIndex: 11492
{
	[HeaderAttribute] 
	public AmplifyOcclusionBase.ApplicationMethod ApplyMethod; 
	[TooltipAttribute] 
	public AmplifyOcclusionBase.SampleCountLevel SampleCount; 
	public AmplifyOcclusionBase.PerPixelNormalSource PerPixelNormals; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float Intensity; 
	public Color Tint; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float Radius; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public int PixelRadiusLimit; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float RadiusIntensity; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float PowerExponent; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float Bias; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float Thickness; 
	[TooltipAttribute] 
	public bool Downsample; 
	[HeaderAttribute] 
	[TooltipAttribute] 
	public bool FadeEnabled; 
	[TooltipAttribute] 
	public float FadeStart; 
	[TooltipAttribute] 
	public float FadeLength; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float FadeToIntensity; 
	public Color FadeToTint; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float FadeToRadius; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float FadeToPowerExponent; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float FadeToThickness; 
	[HeaderAttribute] 
	public bool BlurEnabled; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public int BlurRadius; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public int BlurPasses; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float BlurSharpness; 
	[HeaderAttribute] 
	[TooltipAttribute] 
	public bool FilterEnabled; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float FilterBlending; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float FilterResponse; 
	[TooltipAttribute] 
	public bool TemporalDirections; 
	[TooltipAttribute] 
	public bool TemporalOffsets; 
	[TooltipAttribute] 
	public bool TemporalDilation; 
	[TooltipAttribute] 
	public bool UseMotionVectors; 
	private AmplifyOcclusionBase.PerPixelNormalSource m_prevPerPixelNormals; 
	private AmplifyOcclusionBase.ApplicationMethod m_prevApplyMethod; 
	private bool m_prevDeferredReflections; 
	private AmplifyOcclusionBase.SampleCountLevel m_prevSampleCount; 
	private bool m_prevDownsample; 
	private bool m_prevBlurEnabled; 
	private int m_prevBlurRadius; 
	private int m_prevBlurPasses; 
	private Camera m_targetCamera; 
	private RenderTargetIdentifier[] applyDebugTargetsTemporal; 
	private RenderTargetIdentifier[] applyPostEffectTargetsTemporal; 
	private RenderTargetIdentifier[] applyDeferredTargets_Log_Temporal; 
	private RenderTargetIdentifier[] applyDeferredTargetsTemporal; 
	private AmplifyOcclusionBase.CmdBuffer m_commandBuffer_Occlusion; 
	private AmplifyOcclusionBase.CmdBuffer m_commandBuffer_Apply; 
	private static Mesh m_quadMesh; 
	private static Material m_occlusionMat; 
	private static Material m_blurMat; 
	private static Material m_applyOcclusionMat; 
	private RenderTextureFormat m_occlusionRTFormat; 
	private RenderTextureFormat m_accumTemporalRTFormat; 
	private RenderTextureFormat m_temporaryEmissionRTFormat; 
	private bool m_paramsChanged; 
	private RenderTexture m_occlusionDepthRT; 
	private RenderTexture[] m_temporalAccumRT; 
	private uint m_sampleStep; 
	private uint m_curStepIdx; 
	private static readonly uint m_maxSampleSteps; 
	private static readonly int PerPixelNormalSourceCount; 
	private Matrix4x4 m_prevViewProjMatrixLeft; 
	private Matrix4x4 m_prevInvViewProjMatrixLeft; 
	private Matrix4x4 m_prevViewProjMatrixRight; 
	private Matrix4x4 m_prevInvViewProjMatrixRight; 
	private static readonly float[] m_temporalRotations; 
	private static readonly float[] m_spatialOffsets; 
	private readonly RenderTargetIdentifier[] m_applyDeferredTargets; 
	private readonly RenderTargetIdentifier[] m_applyDeferredTargets_Log; 
	private AmplifyOcclusionBase.TargetDesc m_target; 


	private void createCommandBuffer(ref AmplifyOcclusionBase.CmdBuffer aCmdBuffer, string aCmdBufferName, CameraEvent aCameraEvent) { }

	private void cleanupCommandBuffer(ref AmplifyOcclusionBase.CmdBuffer aCmdBuffer) { }

	private void createQuadMesh() { }

	private void PerformBlit(CommandBuffer cb, Material mat, int pass) { }

	private Material createMaterialWithShaderName(string aShaderName, bool aThroughErrorMsg) { }

	private void checkMaterials(bool aThroughErrorMsg) { }

	private bool checkRenderTextureFormats() { }

	private void OnEnable() { }

	private void Reset() { }

	private void OnDisable() { }

	private void releaseRT() { }

	private bool checkParamsChanged() { }

	private void updateParams() { }

	private void Update() { }

	private void OnPreRender() { }

	private void OnPostRender() { }

	private int safeAllocateTemporaryRT(CommandBuffer cb, string propertyName, int width, int height, RenderTextureFormat format = 7, RenderTextureReadWrite readWrite = 0, FilterMode filterMode = 0) { }

	private void safeReleaseTemporaryRT(CommandBuffer cb, int id) { }

	private RenderTexture safeAllocateRT(string name, int width, int height, RenderTextureFormat format, RenderTextureReadWrite readWrite, FilterMode filterMode = 0) { }

	private void safeReleaseRT(ref RenderTexture rt) { }

	private void BeginSample(CommandBuffer cb, string name) { }

	private void EndSample(CommandBuffer cb, string name) { }

	private void commandBuffer_FillComputeOcclusion(CommandBuffer cb) { }

	private void commandBuffer_Blur(CommandBuffer cb, RenderTargetIdentifier aSourceRT, int aSourceWidth, int aSourceHeight) { }

	private int getTemporalPass() { }

	private void commandBuffer_TemporalFilter(CommandBuffer cb) { }

	private void commandBuffer_FillApplyDeferred(CommandBuffer cb, bool logTarget) { }

	private void commandBuffer_FillApplyPostEffect(CommandBuffer cb) { }

	private void commandBuffer_FillApplyDebug(CommandBuffer cb) { }

	private bool isStereoSinglePassEnabled() { }

	private void UpdateGlobalShaderConstants() { }

	private void UpdateGlobalShaderConstants_AmbientOcclusion() { }

	private void UpdateGlobalShaderConstants_Matrices() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum AmplifyOcclusionBase.ApplicationMethod // TypeDefIndex: 11493
{
	public int value__; 
	public const AmplifyOcclusionBase.ApplicationMethod PostEffect = 0;
	public const AmplifyOcclusionBase.ApplicationMethod Deferred = 1;
	public const AmplifyOcclusionBase.ApplicationMethod Debug = 2;

}

public enum AmplifyOcclusionBase.PerPixelNormalSource // TypeDefIndex: 11494
{
	public int value__; 
	public const AmplifyOcclusionBase.PerPixelNormalSource None = 0;
	public const AmplifyOcclusionBase.PerPixelNormalSource Camera = 1;
	public const AmplifyOcclusionBase.PerPixelNormalSource GBuffer = 2;
	public const AmplifyOcclusionBase.PerPixelNormalSource GBufferOctaEncoded = 3;

}

public enum AmplifyOcclusionBase.SampleCountLevel // TypeDefIndex: 11495
{
	public int value__; 
	public const AmplifyOcclusionBase.SampleCountLevel Low = 0;
	public const AmplifyOcclusionBase.SampleCountLevel Medium = 1;
	public const AmplifyOcclusionBase.SampleCountLevel High = 2;
	public const AmplifyOcclusionBase.SampleCountLevel VeryHigh = 3;

}

private struct AmplifyOcclusionBase.CmdBuffer // TypeDefIndex: 11496
{
	public CommandBuffer cmdBuffer; 
	public CameraEvent cmdBufferEvent; 
	public string cmdBufferName; 

}

private struct AmplifyOcclusionBase.TargetDesc // TypeDefIndex: 11497
{
	public int fullWidth; 
	public int fullHeight; 
	public RenderTextureFormat format; 
	public int width; 
	public int height; 
	public float oneOverWidth; 
	public float oneOverHeight; 

}

private static class AmplifyOcclusionBase.ShaderPass // TypeDefIndex: 11498
{
	public const int CombineDownsampledOcclusionDepth = 16;
	public const int CombineEmission = 17;
	public const int CombineEmissionLog = 18;
	public const int BlurHorizontal1 = 0;
	public const int BlurVertical1 = 1;
	public const int BlurHorizontal2 = 2;
	public const int BlurVertical2 = 3;
	public const int BlurHorizontal3 = 4;
	public const int BlurVertical3 = 5;
	public const int BlurHorizontal4 = 6;
	public const int BlurVertical4 = 7;
	public const int ApplyDebug = 0;
	public const int ApplyDebugTemporal = 1;
	public const int ApplyDeferred = 5;
	public const int ApplyDeferredTemporal = 6;
	public const int ApplyDeferredLog = 10;
	public const int ApplyDeferredLogTemporal = 11;
	public const int ApplyPostEffect = 15;
	public const int ApplyPostEffectTemporal = 16;
	public const int ApplyPostEffectTemporalMultiply = 20;
	public const int OcclusionLow_None = 0;
	public const int OcclusionLow_Camera = 1;
	public const int OcclusionLow_GBuffer = 2;
	public const int OcclusionLow_GBufferOctaEncoded = 3;

}

private static class AmplifyOcclusionBase.PropertyID // TypeDefIndex: 11499
{
	public static readonly int _AO_Radius; 
	public static readonly int _AO_PixelRadiusLimit; 
	public static readonly int _AO_RadiusIntensity; 
	public static readonly int _AO_PowExponent; 
	public static readonly int _AO_Bias; 
	public static readonly int _AO_Levels; 
	public static readonly int _AO_ThicknessDecay; 
	public static readonly int _AO_BlurSharpness; 
	public static readonly int _AO_CameraViewLeft; 
	public static readonly int _AO_CameraViewRight; 
	public static readonly int _AO_ProjMatrixLeft; 
	public static readonly int _AO_ProjMatrixRight; 
	public static readonly int _AO_InvViewProjMatrixLeft; 
	public static readonly int _AO_PrevViewProjMatrixLeft; 
	public static readonly int _AO_PrevInvViewProjMatrixLeft; 
	public static readonly int _AO_InvViewProjMatrixRight; 
	public static readonly int _AO_PrevViewProjMatrixRight; 
	public static readonly int _AO_PrevInvViewProjMatrixRight; 
	public static readonly int _AO_GBufferNormals; 
	public static readonly int _AO_Target_TexelSize; 
	public static readonly int _AO_TemporalCurveAdj; 
	public static readonly int _AO_TemporalMotionSensibility; 
	public static readonly int _AO_CurrOcclusionDepth; 
	public static readonly int _AO_TemporalAccumm; 
	public static readonly int _AO_TemporalDirections; 
	public static readonly int _AO_TemporalOffsets; 
	public static readonly int _AO_OcclusionTexture; 
	public static readonly int _AO_GBufferAlbedo; 
	public static readonly int _AO_GBufferEmission; 
	public static readonly int _AO_UVToView; 
	public static readonly int _AO_HalfProjScale; 
	public static readonly int _AO_FadeParams; 
	public static readonly int _AO_FadeValues; 
	public static readonly int _AO_FadeToTint; 
	public static readonly int _AO_Source_TexelSize; 
	public static readonly int _AO_Source; 


	private static void .cctor() { }

}

