public class DepthOfField : PostEffectsBase // TypeDefIndex: 8178
{	// Fields
	public bool visualizeFocus; // 0x28
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

	// Properties
	public bool ForceOnlyFarBlur { get; set; }

	// Methods

	// RVA: 0x5ABE90 Offset: 0x5AB290 VA: 0x1805ABE90
	public bool get_ForceOnlyFarBlur() { }

	// RVA: 0x5ABEA0 Offset: 0x5AB2A0 VA: 0x1805ABEA0
	public void set_ForceOnlyFarBlur(bool value) { }

	// RVA: 0x21D7BF0 Offset: 0x21D6FF0 VA: 0x1821D7BF0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21D8330 Offset: 0x21D7730 VA: 0x1821D8330
	private void OnEnable() { }

	// RVA: 0x21D81C0 Offset: 0x21D75C0 VA: 0x1821D81C0
	private void OnDisable() { }

	// RVA: 0x21D9E80 Offset: 0x21D9280 VA: 0x1821D9E80
	private void ReleaseComputeResources() { }

	// RVA: 0x21D7E00 Offset: 0x21D7200 VA: 0x1821D7E00
	private void CreateComputeResources() { }

	// RVA: 0x21D7F90 Offset: 0x21D7390 VA: 0x1821D7F90
	private float FocalDistance01(float worldDist) { }

	// RVA: 0x21D9EF0 Offset: 0x21D92F0 VA: 0x1821D9EF0
	private void WriteCoc(RenderTexture fromTo, bool fgDilate) { }

	// RVA: 0x21D8390 Offset: 0x21D7790 VA: 0x1821D8390
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DA250 Offset: 0x21D9650 VA: 0x1821DA250
	public void .ctor() { }

}

public enum DepthOfField.BlurType // TypeDefIndex: 8179
{	// Fields
	public int value__; // 0x0
	public const DepthOfField.BlurType DiscBlur = 0;
	public const DepthOfField.BlurType DX11 = 1;

}

public enum DepthOfField.BlurSampleCount // TypeDefIndex: 8180
{	// Fields
	public int value__; // 0x0
	public const DepthOfField.BlurSampleCount Low = 0;
	public const DepthOfField.BlurSampleCount Medium = 1;
	public const DepthOfField.BlurSampleCount High = 2;

}

public sealed class DepthOfField : PostProcessEffectSettings // TypeDefIndex: 11778
{	// Fields
	[MinAttribute] // RVA: 0x6F5A0 Offset: 0x6E9A0 VA: 0x18006F5A0
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

	// Methods

	// RVA: 0x9DBCD0 Offset: 0x9DB0D0 VA: 0x1809DBCD0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9DBD10 Offset: 0x9DB110 VA: 0x1809DBD10
	public void .ctor() { }

}

