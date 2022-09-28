internal class ScreenSpaceAmbientObscurance : PostEffectsBase // TypeDefIndex: 8175
{
	[RangeAttribute] 
	public float intensity; 
	[RangeAttribute] 
	public float radius; 
	[RangeAttribute] 
	public int blurIterations; 
	[RangeAttribute] 
	public float blurFilterDistance; 
	[RangeAttribute] 
	public int downsample; 
	public Texture2D rand; 
	public Shader aoShader; 
	private Material aoMaterial; 


	public override bool CheckResources() { }

	private void OnDisable() { }

	[ImageEffectOpaque] 
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class ScreenSpaceAmbientOcclusion : MonoBehaviour // TypeDefIndex: 8176
{
	public float m_Radius; 
	public ScreenSpaceAmbientOcclusion.SSAOSamples m_SampleCount; 
	public float m_OcclusionIntensity; 
	public int m_Blur; 
	public int m_Downsampling; 
	public float m_OcclusionAttenuation; 
	public float m_MinZ; 
	public Shader m_SSAOShader; 
	private Material m_SSAOMaterial; 
	public Texture2D m_RandomTexture; 
	private bool m_Supported; 


	private static Material CreateMaterial(Shader shader) { }

	private static void DestroyMaterial(Material mat) { }

	private void OnDisable() { }

	private void Start() { }

	private void OnEnable() { }

	private void CreateMaterials() { }

	[ImageEffectOpaque] 
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum ScreenSpaceAmbientOcclusion.SSAOSamples // TypeDefIndex: 8177
{
	public int value__; 
	public const ScreenSpaceAmbientOcclusion.SSAOSamples Low = 0;
	public const ScreenSpaceAmbientOcclusion.SSAOSamples Medium = 1;
	public const ScreenSpaceAmbientOcclusion.SSAOSamples High = 2;

}

public enum ScreenSpaceReflectionPreset // TypeDefIndex: 13492
{
	public int value__; 
	public const ScreenSpaceReflectionPreset Lower = 0;
	public const ScreenSpaceReflectionPreset Low = 1;
	public const ScreenSpaceReflectionPreset Medium = 2;
	public const ScreenSpaceReflectionPreset High = 3;
	public const ScreenSpaceReflectionPreset Higher = 4;
	public const ScreenSpaceReflectionPreset Ultra = 5;
	public const ScreenSpaceReflectionPreset Overkill = 6;
	public const ScreenSpaceReflectionPreset Custom = 7;

}

public enum ScreenSpaceReflectionResolution // TypeDefIndex: 13493
{
	public int value__; 
	public const ScreenSpaceReflectionResolution Downsampled = 0;
	public const ScreenSpaceReflectionResolution FullSize = 1;
	public const ScreenSpaceReflectionResolution Supersampled = 2;

}

public sealed class ScreenSpaceReflectionPresetParameter : ParameterOverride<ScreenSpaceReflectionPreset> // TypeDefIndex: 13494
{

	public void .ctor() { }

}

public sealed class ScreenSpaceReflectionResolutionParameter : ParameterOverride<ScreenSpaceReflectionResolution> // TypeDefIndex: 13495
{

	public void .ctor() { }

}

public sealed class ScreenSpaceReflections : PostProcessEffectSettings // TypeDefIndex: 13496
{
	[TooltipAttribute] 
	public ScreenSpaceReflectionPresetParameter preset; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public IntParameter maximumIterationCount; 
	[TooltipAttribute] 
	public ScreenSpaceReflectionResolutionParameter resolution; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter thickness; 
	[TooltipAttribute] 
	public FloatParameter maximumMarchDistance; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter distanceFade; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter vignette; 


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections> // TypeDefIndex: 13497
{
	private RenderTexture m_Resolve; 
	private RenderTexture m_History; 
	private int[] m_MipIDs; 
	private readonly ScreenSpaceReflectionsRenderer.QualityPreset[] m_Presets; 


	public override DepthTextureMode GetCameraFlags() { }

	internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap) { }

	public override void Render(PostProcessRenderContext context) { }

	public override void Release() { }

	public void .ctor() { }

}

private class ScreenSpaceReflectionsRenderer.QualityPreset // TypeDefIndex: 13498
{
	public int maximumIterationCount; 
	public float thickness; 
	public ScreenSpaceReflectionResolution downsampling; 


	public void .ctor() { }

}

private enum ScreenSpaceReflectionsRenderer.Pass // TypeDefIndex: 13499
{
	public int value__; 
	public const ScreenSpaceReflectionsRenderer.Pass Test = 0;
	public const ScreenSpaceReflectionsRenderer.Pass Resolve = 1;
	public const ScreenSpaceReflectionsRenderer.Pass Reproject = 2;
	public const ScreenSpaceReflectionsRenderer.Pass Composite = 3;

}

