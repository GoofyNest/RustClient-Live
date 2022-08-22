public class BlurOptimized : PostEffectsBase, IImageEffect // TypeDefIndex: 8166
{	[RangeAttribute] // RVA: 0x710E0 Offset: 0x704E0 VA: 0x1800710E0
	public int downsample; // 0x28
	[RangeAttribute] // RVA: 0x980D0 Offset: 0x974D0 VA: 0x1800980D0
	public float blurSize; // 0x2C
	[RangeAttribute] // RVA: 0x97AB0 Offset: 0x96EB0 VA: 0x180097AB0
	public int blurIterations; // 0x30
	public float fadeToBlurDistance; // 0x34
	public BlurOptimized.BlurType blurType; // 0x38
	public Shader blurShader; // 0x40
	private Material blurMaterial; // 0x48


	public override bool CheckResources() { }

	public void OnDisable() { }

	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum BlurOptimized.BlurType // TypeDefIndex: 8167
{	public int value__; // 0x0
	public const BlurOptimized.BlurType StandardGauss = 0;
	public const BlurOptimized.BlurType SgxGauss = 1;

}

public class BlurOptimized : PostProcessEffectSettings // TypeDefIndex: 10242
{	[RangeAttribute] // RVA: 0x710E0 Offset: 0x704E0 VA: 0x1800710E0
	public FixedIntParameter downsample; // 0x30
	[RangeAttribute] // RVA: 0x97AB0 Offset: 0x96EB0 VA: 0x180097AB0
	public FixedIntParameter blurIterations; // 0x38
	[RangeAttribute] // RVA: 0x980D0 Offset: 0x974D0 VA: 0x1800980D0
	public FloatParameter blurSize; // 0x40
	public FloatParameter fadeToBlurDistance; // 0x48
	public BlurTypeParameter blurType; // 0x50


	public void .ctor() { }

}

