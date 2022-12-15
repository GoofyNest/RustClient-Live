internal class ContrastEnhance : PostEffectsBase // TypeDefIndex: 8196
{
	public float intensity;
	public float threshold;
	private Material separableBlurMaterial;
	private Material contrastCompositeMaterial;
	public float blurSpread;
	public Shader separableBlurShader;
	public Shader contrastCompositeShader;


	public override bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

