public class Bloom : PostEffectsBase // TypeDefIndex: 8151
{	// Fields
	public Bloom.TweakMode tweakMode; // 0x28
	public Bloom.BloomScreenBlendMode screenBlendMode; // 0x2C
	public Bloom.HDRBloomMode hdr; // 0x30
	private bool doHdr; // 0x34
	public float sepBlurSpread; // 0x38
	public Bloom.BloomQuality quality; // 0x3C
	public float bloomIntensity; // 0x40
	public float bloomThreshold; // 0x44
	public Color bloomThresholdColor; // 0x48
	public int bloomBlurIterations; // 0x58
	public int hollywoodFlareBlurIterations; // 0x5C
	public float flareRotation; // 0x60
	public Bloom.LensFlareStyle lensflareMode; // 0x64
	public float hollyStretchWidth; // 0x68
	public float lensflareIntensity; // 0x6C
	public float lensflareThreshold; // 0x70
	public float lensFlareSaturation; // 0x74
	public Color flareColorA; // 0x78
	public Color flareColorB; // 0x88
	public Color flareColorC; // 0x98
	public Color flareColorD; // 0xA8
	public Texture2D lensFlareVignetteMask; // 0xB8
	public Shader lensFlareShader; // 0xC0
	private Material lensFlareMaterial; // 0xC8
	public Shader screenBlendShader; // 0xD0
	private Material screenBlend; // 0xD8
	public Shader blurAndFlaresShader; // 0xE0
	private Material blurAndFlaresMaterial; // 0xE8
	public Shader brightPassFilterShader; // 0xF0
	private Material brightPassFilterMaterial; // 0xF8

	// Methods

	// RVA: 0x12C02B0 Offset: 0x12BF6B0 VA: 0x1812C02B0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12C03B0 Offset: 0x12BF7B0 VA: 0x1812C03B0
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12BFD00 Offset: 0x12BF100 VA: 0x1812BFD00
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to) { }

	// RVA: 0x12BFDD0 Offset: 0x12BF1D0 VA: 0x1812BFDD0
	private void BlendFlares(RenderTexture from, RenderTexture to) { }

	// RVA: 0x12C01B0 Offset: 0x12BF5B0 VA: 0x1812C01B0
	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to) { }

	// RVA: 0x12C00C0 Offset: 0x12BF4C0 VA: 0x1812C00C0
	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to) { }

	// RVA: 0x12C15A0 Offset: 0x12C09A0 VA: 0x1812C15A0
	private void Vignette(float amount, RenderTexture from, RenderTexture to) { }

	// RVA: 0x12C17B0 Offset: 0x12C0BB0 VA: 0x1812C17B0
	public void .ctor() { }

}

public enum Bloom.LensFlareStyle // TypeDefIndex: 8152
{	// Fields
	public int value__; // 0x0
	public const Bloom.LensFlareStyle Ghosting = 0;
	public const Bloom.LensFlareStyle Anamorphic = 1;
	public const Bloom.LensFlareStyle Combined = 2;

}

public enum Bloom.TweakMode // TypeDefIndex: 8153
{	// Fields
	public int value__; // 0x0
	public const Bloom.TweakMode Basic = 0;
	public const Bloom.TweakMode Complex = 1;

}

public enum Bloom.HDRBloomMode // TypeDefIndex: 8154
{	// Fields
	public int value__; // 0x0
	public const Bloom.HDRBloomMode Auto = 0;
	public const Bloom.HDRBloomMode On = 1;
	public const Bloom.HDRBloomMode Off = 2;

}

public enum Bloom.BloomScreenBlendMode // TypeDefIndex: 8155
{	// Fields
	public int value__; // 0x0
	public const Bloom.BloomScreenBlendMode Screen = 0;
	public const Bloom.BloomScreenBlendMode Add = 1;

}

public enum Bloom.BloomQuality // TypeDefIndex: 8156
{	// Fields
	public int value__; // 0x0
	public const Bloom.BloomQuality Cheap = 0;
	public const Bloom.BloomQuality High = 1;

}

public sealed class Bloom : PostProcessEffectSettings // TypeDefIndex: 11763
{	// Fields
	[MinAttribute] // RVA: 0xEBF40 Offset: 0xEB340 VA: 0x1800EBF40
	[TooltipAttribute] // RVA: 0xEBF40 Offset: 0xEB340 VA: 0x1800EBF40
	public FloatParameter intensity; // 0x30
	[MinAttribute] // RVA: 0xEBFE0 Offset: 0xEB3E0 VA: 0x1800EBFE0
	[TooltipAttribute] // RVA: 0xEBFE0 Offset: 0xEB3E0 VA: 0x1800EBFE0
	public FloatParameter threshold; // 0x38
	[RangeAttribute] // RVA: 0xEC110 Offset: 0xEB510 VA: 0x1800EC110
	[TooltipAttribute] // RVA: 0xEC110 Offset: 0xEB510 VA: 0x1800EC110
	public FloatParameter softKnee; // 0x40
	[TooltipAttribute] // RVA: 0xEC1A0 Offset: 0xEB5A0 VA: 0x1800EC1A0
	public FloatParameter clamp; // 0x48
	[RangeAttribute] // RVA: 0xEC1D0 Offset: 0xEB5D0 VA: 0x1800EC1D0
	[TooltipAttribute] // RVA: 0xEC1D0 Offset: 0xEB5D0 VA: 0x1800EC1D0
	public FloatParameter diffusion; // 0x50
	[RangeAttribute] // RVA: 0xEC2A0 Offset: 0xEB6A0 VA: 0x1800EC2A0
	[TooltipAttribute] // RVA: 0xEC2A0 Offset: 0xEB6A0 VA: 0x1800EC2A0
	public FloatParameter anamorphicRatio; // 0x58
	[ColorUsageAttribute] // RVA: 0xEC320 Offset: 0xEB720 VA: 0x1800EC320
	[TooltipAttribute] // RVA: 0xEC320 Offset: 0xEB720 VA: 0x1800EC320
	public ColorParameter color; // 0x60
	[FormerlySerializedAsAttribute] // RVA: 0xEC440 Offset: 0xEB840 VA: 0x1800EC440
	[TooltipAttribute] // RVA: 0xEC440 Offset: 0xEB840 VA: 0x1800EC440
	public BoolParameter fastMode; // 0x68
	[TooltipAttribute] // RVA: 0xEC5D0 Offset: 0xEB9D0 VA: 0x1800EC5D0
	[DisplayNameAttribute] // RVA: 0xEC5D0 Offset: 0xEB9D0 VA: 0x1800EC5D0
	public TextureParameter dirtTexture; // 0x70
	[MinAttribute] // RVA: 0xEC710 Offset: 0xEBB10 VA: 0x1800EC710
	[TooltipAttribute] // RVA: 0xEC710 Offset: 0xEBB10 VA: 0x1800EC710
	[DisplayNameAttribute] // RVA: 0xEC710 Offset: 0xEBB10 VA: 0x1800EC710
	public FloatParameter dirtIntensity; // 0x78

	// Methods

	// RVA: 0x9CF0D0 Offset: 0x9CE4D0 VA: 0x1809CF0D0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9CF110 Offset: 0x9CE510 VA: 0x1809CF110
	public void .ctor() { }

}

