public class DepthOfField : PostEffectsBase // TypeDefIndex: 8200
{
	public bool visualizeFocus;
	public float focalLength;
	public float focalSize;
	public float aperture;
	public Transform focalTransform;
	public float maxBlurSize;
	public bool highResolution;
	public DepthOfField.BlurType blurType;
	public DepthOfField.BlurSampleCount blurSampleCount;
	public bool nearBlur;
	public float foregroundOverlap;
	private bool forceOnlyFarBlur;
	public Shader dofHdrShader;
	private Material dofHdrMaterial;
	public Shader dx11BokehShader;
	private Material dx11bokehMaterial;
	public float dx11BokehThreshold;
	public float dx11SpawnHeuristic;
	public Texture2D dx11BokehTexture;
	public float dx11BokehScale;
	public float dx11BokehIntensity;
	private float focalDistance01;
	private ComputeBuffer cbDrawArgs;
	private ComputeBuffer cbPoints;
	private float internalBlurWidth;

	public bool ForceOnlyFarBlur { get; set; }


	public bool get_ForceOnlyFarBlur() { }

	public void set_ForceOnlyFarBlur(bool value) { }

	public override bool CheckResources() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void ReleaseComputeResources() { }

	private void CreateComputeResources() { }

	private float FocalDistance01(float worldDist) { }

	private void WriteCoc(RenderTexture fromTo, bool fgDilate) { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum DepthOfField.BlurType // TypeDefIndex: 8201
{
	public int value__;
	public const DepthOfField.BlurType DiscBlur = 0;
	public const DepthOfField.BlurType DX11 = 1;

}

public enum DepthOfField.BlurSampleCount // TypeDefIndex: 8202
{
	public int value__;
	public const DepthOfField.BlurSampleCount Low = 0;
	public const DepthOfField.BlurSampleCount Medium = 1;
	public const DepthOfField.BlurSampleCount High = 2;

}

public sealed class DepthOfField : PostProcessEffectSettings // TypeDefIndex: 13597
{
	[MinAttribute]
	[TooltipAttribute]
	public FloatParameter focusDistance;
	[RangeAttribute]
	[TooltipAttribute]
	public FloatParameter aperture;
	[RangeAttribute]
	[TooltipAttribute]
	public FloatParameter focalLength;
	[DisplayNameAttribute]
	[TooltipAttribute]
	public KernelSizeParameter kernelSize;


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

