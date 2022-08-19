internal class ContrastEnhance : PostEffectsBase // TypeDefIndex: 8174
{	// Fields
	public float intensity; // 0x28
	public float threshold; // 0x2C
	private Material separableBlurMaterial; // 0x30
	private Material contrastCompositeMaterial; // 0x38
	public float blurSpread; // 0x40
	public Shader separableBlurShader; // 0x48
	public Shader contrastCompositeShader; // 0x50

	// Methods

	// RVA: 0x21D3C50 Offset: 0x21D3050 VA: 0x1821D3C50 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21D3D30 Offset: 0x21D3130 VA: 0x1821D3D30
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21D40E0 Offset: 0x21D34E0 VA: 0x1821D40E0
	public void .ctor() { }

}

