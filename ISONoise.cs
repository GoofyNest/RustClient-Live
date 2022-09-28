public class ISONoise : PostEffectsBase // TypeDefIndex: 8002
{
	public float monochromeTiling; 
	public FilterMode filterMode; 
	public Texture2D noiseTexture; 
	public Shader noiseShader; 
	private Material noiseMaterial; 


	public override bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr) { }

	public void .ctor() { }

}

