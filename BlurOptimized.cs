public class BlurOptimized : PostEffectsBase, IImageEffect // TypeDefIndex: 8175
{
	[RangeAttribute] 
	public int downsample; 
	[RangeAttribute] 
	public float blurSize; 
	[RangeAttribute] 
	public int blurIterations; 
	public float fadeToBlurDistance; 
	public BlurOptimized.BlurType blurType; 
	public Shader blurShader; 
	private Material blurMaterial; 


	public override bool CheckResources() { }

	public void OnDisable() { }

	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum BlurOptimized.BlurType // TypeDefIndex: 8176
{
	public int value__; 
	public const BlurOptimized.BlurType StandardGauss = 0;
	public const BlurOptimized.BlurType SgxGauss = 1;

}

public class BlurOptimized : PostProcessEffectSettings // TypeDefIndex: 11969
{
	[RangeAttribute] 
	public FixedIntParameter downsample; 
	[RangeAttribute] 
	public FixedIntParameter blurIterations; 
	[RangeAttribute] 
	public FloatParameter blurSize; 
	public FloatParameter fadeToBlurDistance; 
	public BlurTypeParameter blurType; 


	public void .ctor() { }

}

