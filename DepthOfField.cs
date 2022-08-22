public class DepthOfField : PostEffectsBase // TypeDefIndex: 8178
{	public bool visualizeFocus; // 0x28
	public float focalLength; // 0x2C
	public float focalSize; // 0x30
	public float aperture; // 0x34
	public Transform focalTransform; // 0x38
	public float maxBlurSize; // 0x40
	public bool highResolution; // 0x44
	public DepthOfField.BlurType blurType; // 0x48
	public DepthOfField.BlurSampleCount blurSampleCount; // 0x4C
	public bool nearBlur; // 0x50
	public float foregroundOverlap; // 0x54
	private bool forceOnlyFarBlur; // 0x58
	public Shader dofHdrShader; // 0x60
	private Material dofHdrMaterial; // 0x68
	public Shader dx11BokehShader; // 0x70
	private Material dx11bokehMaterial; // 0x78
	public float dx11BokehThreshold; // 0x80
	public float dx11SpawnHeuristic; // 0x84
	public Texture2D dx11BokehTexture; // 0x88
	public float dx11BokehScale; // 0x90
	public float dx11BokehIntensity; // 0x94
	private float focalDistance01; // 0x98
	private ComputeBuffer cbDrawArgs; // 0xA0
	private ComputeBuffer cbPoints; // 0xA8
	private float internalBlurWidth; // 0xB0

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

public enum DepthOfField.BlurType // TypeDefIndex: 8179
{	public int value__; // 0x0
	public const DepthOfField.BlurType DiscBlur = 0;
	public const DepthOfField.BlurType DX11 = 1;

}

public enum DepthOfField.BlurSampleCount // TypeDefIndex: 8180
{	public int value__; // 0x0
	public const DepthOfField.BlurSampleCount Low = 0;
	public const DepthOfField.BlurSampleCount Medium = 1;
	public const DepthOfField.BlurSampleCount High = 2;

}

public sealed class DepthOfField : PostProcessEffectSettings // TypeDefIndex: 11778
{	[MinAttribute] // RVA: 0x6F5A0 Offset: 0x6E9A0 VA: 0x18006F5A0
	[TooltipAttribute] // RVA: 0x6F5A0 Offset: 0x6E9A0 VA: 0x18006F5A0
	public FloatParameter focusDistance; // 0x30
	[RangeAttribute] // RVA: 0x6FA10 Offset: 0x6EE10 VA: 0x18006FA10
	[TooltipAttribute] // RVA: 0x6FA10 Offset: 0x6EE10 VA: 0x18006FA10
	public FloatParameter aperture; // 0x38
	[RangeAttribute] // RVA: 0x6FCB0 Offset: 0x6F0B0 VA: 0x18006FCB0
	[TooltipAttribute] // RVA: 0x6FCB0 Offset: 0x6F0B0 VA: 0x18006FCB0
	public FloatParameter focalLength; // 0x40
	[DisplayNameAttribute] // RVA: 0x6FEB0 Offset: 0x6F2B0 VA: 0x18006FEB0
	[TooltipAttribute] // RVA: 0x6FEB0 Offset: 0x6F2B0 VA: 0x18006FEB0
	public KernelSizeParameter kernelSize; // 0x48


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

