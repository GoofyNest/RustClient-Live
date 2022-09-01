public class Bloom : PostEffectsBase // TypeDefIndex: 8152
{
	public Bloom.TweakMode tweakMode; 
	public Bloom.BloomScreenBlendMode screenBlendMode; 
	public Bloom.HDRBloomMode hdr; 
	private bool doHdr; 
	public float sepBlurSpread; 
	public Bloom.BloomQuality quality; 
	public float bloomIntensity; 
	public float bloomThreshold; 
	public Color bloomThresholdColor; 
	public int bloomBlurIterations; 
	public int hollywoodFlareBlurIterations; 
	public float flareRotation; 
	public Bloom.LensFlareStyle lensflareMode; 
	public float hollyStretchWidth; 
	public float lensflareIntensity; 
	public float lensflareThreshold; 
	public float lensFlareSaturation; 
	public Color flareColorA; 
	public Color flareColorB; 
	public Color flareColorC; 
	public Color flareColorD; 
	public Texture2D lensFlareVignetteMask; 
	public Shader lensFlareShader; 
	private Material lensFlareMaterial; 
	public Shader screenBlendShader; 
	private Material screenBlend; 
	public Shader blurAndFlaresShader; 
	private Material blurAndFlaresMaterial; 
	public Shader brightPassFilterShader; 
	private Material brightPassFilterMaterial; 


	public override bool CheckResources() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void AddTo(float intensity_, RenderTexture from, RenderTexture to) { }

	private void BlendFlares(RenderTexture from, RenderTexture to) { }

	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to) { }

	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to) { }

	private void Vignette(float amount, RenderTexture from, RenderTexture to) { }

	public void .ctor() { }

}

public enum Bloom.LensFlareStyle // TypeDefIndex: 8153
{
	public int value__; 
	public const Bloom.LensFlareStyle Ghosting = 0;
	public const Bloom.LensFlareStyle Anamorphic = 1;
	public const Bloom.LensFlareStyle Combined = 2;

}

public enum Bloom.TweakMode // TypeDefIndex: 8154
{
	public int value__; 
	public const Bloom.TweakMode Basic = 0;
	public const Bloom.TweakMode Complex = 1;

}

public enum Bloom.HDRBloomMode // TypeDefIndex: 8155
{
	public int value__; 
	public const Bloom.HDRBloomMode Auto = 0;
	public const Bloom.HDRBloomMode On = 1;
	public const Bloom.HDRBloomMode Off = 2;

}

public enum Bloom.BloomScreenBlendMode // TypeDefIndex: 8156
{
	public int value__; 
	public const Bloom.BloomScreenBlendMode Screen = 0;
	public const Bloom.BloomScreenBlendMode Add = 1;

}

public enum Bloom.BloomQuality // TypeDefIndex: 8157
{
	public int value__; 
	public const Bloom.BloomQuality Cheap = 0;
	public const Bloom.BloomQuality High = 1;

}

public sealed class Bloom : PostProcessEffectSettings // TypeDefIndex: 11791
{
	[MinAttribute] 
	[TooltipAttribute] 
	public FloatParameter intensity; 
	[MinAttribute] 
	[TooltipAttribute] 
	public FloatParameter threshold; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter softKnee; 
	[TooltipAttribute] 
	public FloatParameter clamp; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter diffusion; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter anamorphicRatio; 
	[ColorUsageAttribute] 
	[TooltipAttribute] 
	public ColorParameter color; 
	[FormerlySerializedAsAttribute] 
	[TooltipAttribute] 
	public BoolParameter fastMode; 
	[TooltipAttribute] 
	[DisplayNameAttribute] 
	public TextureParameter dirtTexture; 
	[MinAttribute] 
	[TooltipAttribute] 
	[DisplayNameAttribute] 
	public FloatParameter dirtIntensity; 


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

