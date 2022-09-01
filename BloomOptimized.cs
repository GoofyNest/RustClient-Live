public class BloomOptimized : PostEffectsBase // TypeDefIndex: 8163
{
	[RangeAttribute] 
	public float threshold; 
	[RangeAttribute] 
	public float intensity; 
	[RangeAttribute] 
	public float blurSize; 
	private BloomOptimized.Resolution resolution; 
	[RangeAttribute] 
	public int blurIterations; 
	public BloomOptimized.BlurType blurType; 
	public Shader fastBloomShader; 
	private Material fastBloomMaterial; 


	public override bool CheckResources() { }

	private void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum BloomOptimized.Resolution // TypeDefIndex: 8164
{
	public int value__; 
	public const BloomOptimized.Resolution Low = 0;
	public const BloomOptimized.Resolution High = 1;

}

public enum BloomOptimized.BlurType // TypeDefIndex: 8165
{
	public int value__; 
	public const BloomOptimized.BlurType Standard = 0;
	public const BloomOptimized.BlurType Sgx = 1;

}

