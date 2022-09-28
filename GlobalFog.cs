internal class GlobalFog : PostEffectsBase // TypeDefIndex: 8163
{
	[TooltipAttribute] 
	public bool distanceFog; 
	[TooltipAttribute] 
	public bool useRadialDistance; 
	[TooltipAttribute] 
	public bool heightFog; 
	[TooltipAttribute] 
	public float height; 
	[RangeAttribute] 
	public float heightDensity; 
	[TooltipAttribute] 
	public float startDistance; 
	public Shader fogShader; 
	private Material fogMaterial; 


	public override bool CheckResources() { }

	[ImageEffectOpaque] 
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr) { }

	public void .ctor() { }

}

