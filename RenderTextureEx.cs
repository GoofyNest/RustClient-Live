public static class RenderTextureEx // TypeDefIndex: 5614
{
	private static Material _alphaBlending; 

	public static Material AlphaBlending { get; }


	public static Material get_AlphaBlending() { }

	[ExtensionAttribute] 
	public static void Blit(RenderTexture t, Texture tex) { }

	[ExtensionAttribute] 
	public static void BlitWithAlphaBlending(RenderTexture t, Texture tex) { }

	[ExtensionAttribute] 
	public static void ToTexture(RenderTexture t, Texture texture) { }

}

