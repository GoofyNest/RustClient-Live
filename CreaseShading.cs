internal class CreaseShading : PostEffectsBase // TypeDefIndex: 8177
{
	public float intensity; 
	public int softness; 
	public float spread; 
	public Shader blurShader; 
	private Material blurMaterial; 
	public Shader depthFetchShader; 
	private Material depthFetchMaterial; 
	public Shader creaseApplyShader; 
	private Material creaseApplyMaterial; 


	public override bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

