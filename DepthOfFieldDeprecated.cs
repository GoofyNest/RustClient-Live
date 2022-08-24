public class DepthOfFieldDeprecated : PostEffectsBase // TypeDefIndex: 8181
{
	private static int SMOOTH_DOWNSAMPLE_PASS; 
	private static float BOKEH_EXTRA_BLUR; 
	public DepthOfFieldDeprecated.Dof34QualitySetting quality; 
	public DepthOfFieldDeprecated.DofResolution resolution; 
	public bool simpleTweakMode; 
	public float focalPoint; 
	public float smoothness; 
	public float focalZDistance; 
	public float focalZStartCurve; 
	public float focalZEndCurve; 
	private float focalStartCurve; 
	private float focalEndCurve; 
	private float focalDistance01; 
	public Transform objectFocus; 
	public float focalSize; 
	public DepthOfFieldDeprecated.DofBlurriness bluriness; 
	public float maxBlurSpread; 
	public float foregroundBlurExtrude; 
	public Shader dofBlurShader; 
	private Material dofBlurMaterial; 
	public Shader dofShader; 
	private Material dofMaterial; 
	public bool visualize; 
	public DepthOfFieldDeprecated.BokehDestination bokehDestination; 
	private float widthOverHeight; 
	private float oneOverBaseSize; 
	public bool bokeh; 
	public bool bokehSupport; 
	public Shader bokehShader; 
	public Texture2D bokehTexture; 
	public float bokehScale; 
	public float bokehIntensity; 
	public float bokehThresholdContrast; 
	public float bokehThresholdLuminance; 
	public int bokehDownsample; 
	private Material bokehMaterial; 
	private Camera _camera; 
	private RenderTexture foregroundTexture; 
	private RenderTexture mediumRezWorkTexture; 
	private RenderTexture finalDefocus; 
	private RenderTexture lowRezWorkTexture; 
	private RenderTexture bokehSource; 
	private RenderTexture bokehSource2; 


	private void CreateMaterials() { }

	public override bool CheckResources() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private float FocalDistance01(float worldDist) { }

	private int GetDividerBasedOnQuality() { }

	private int GetLowResolutionDividerBasedOnQuality(int baseDivider) { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Blur(RenderTexture from, RenderTexture to, DepthOfFieldDeprecated.DofBlurriness iterations, int blurPass, float spread) { }

	private void BlurFg(RenderTexture from, RenderTexture to, DepthOfFieldDeprecated.DofBlurriness iterations, int blurPass, float spread) { }

	private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp) { }

	private void Downsample(RenderTexture from, RenderTexture to) { }

	private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget) { }

	private void ReleaseTextures() { }

	private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum DepthOfFieldDeprecated.Dof34QualitySetting // TypeDefIndex: 8182
{
	public int value__; 
	public const DepthOfFieldDeprecated.Dof34QualitySetting OnlyBackground = 1;
	public const DepthOfFieldDeprecated.Dof34QualitySetting BackgroundAndForeground = 2;

}

public enum DepthOfFieldDeprecated.DofResolution // TypeDefIndex: 8183
{
	public int value__; 
	public const DepthOfFieldDeprecated.DofResolution High = 2;
	public const DepthOfFieldDeprecated.DofResolution Medium = 3;
	public const DepthOfFieldDeprecated.DofResolution Low = 4;

}

public enum DepthOfFieldDeprecated.DofBlurriness // TypeDefIndex: 8184
{
	public int value__; 
	public const DepthOfFieldDeprecated.DofBlurriness Low = 1;
	public const DepthOfFieldDeprecated.DofBlurriness High = 2;
	public const DepthOfFieldDeprecated.DofBlurriness VeryHigh = 4;

}

public enum DepthOfFieldDeprecated.BokehDestination // TypeDefIndex: 8185
{
	public int value__; 
	public const DepthOfFieldDeprecated.BokehDestination Background = 1;
	public const DepthOfFieldDeprecated.BokehDestination Foreground = 2;
	public const DepthOfFieldDeprecated.BokehDestination BackgroundAndForeground = 3;

}

