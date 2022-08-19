internal class CreaseShading : PostEffectsBase // TypeDefIndex: 8176
{	// Fields
	public float intensity; // 0x28
	public int softness; // 0x2C
	public float spread; // 0x30
	public Shader blurShader; // 0x38
	private Material blurMaterial; // 0x40
	public Shader depthFetchShader; // 0x48
	private Material depthFetchMaterial; // 0x50
	public Shader creaseApplyShader; // 0x58
	private Material creaseApplyMaterial; // 0x60

	// Methods

	// RVA: 0x21D4E50 Offset: 0x21D4250 VA: 0x1821D4E50 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21D4F00 Offset: 0x21D4300 VA: 0x1821D4F00
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21D5300 Offset: 0x21D4700 VA: 0x1821D5300
	public void .ctor() { }

}

