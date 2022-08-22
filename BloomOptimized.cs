public class BloomOptimized : PostEffectsBase // TypeDefIndex: 8162
{	[RangeAttribute] // RVA: 0x97780 Offset: 0x96B80 VA: 0x180097780
	public float threshold; // 0x28
	[RangeAttribute] // RVA: 0x97810 Offset: 0x96C10 VA: 0x180097810
	public float intensity; // 0x2C
	[RangeAttribute] // RVA: 0x97950 Offset: 0x96D50 VA: 0x180097950
	public float blurSize; // 0x30
	private BloomOptimized.Resolution resolution; // 0x34
	[RangeAttribute] // RVA: 0x97AB0 Offset: 0x96EB0 VA: 0x180097AB0
	public int blurIterations; // 0x38
	public BloomOptimized.BlurType blurType; // 0x3C
	public Shader fastBloomShader; // 0x40
	private Material fastBloomMaterial; // 0x48


	public override bool CheckResources() { }

	private void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum BloomOptimized.Resolution // TypeDefIndex: 8163
{	public int value__; // 0x0
	public const BloomOptimized.Resolution Low = 0;
	public const BloomOptimized.Resolution High = 1;

}

public enum BloomOptimized.BlurType // TypeDefIndex: 8164
{	public int value__; // 0x0
	public const BloomOptimized.BlurType Standard = 0;
	public const BloomOptimized.BlurType Sgx = 1;

}

