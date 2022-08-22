public class ISONoise : PostEffectsBase // TypeDefIndex: 8028
{	public float monochromeTiling; // 0x28
	public FilterMode filterMode; // 0x2C
	public Texture2D noiseTexture; // 0x30
	public Shader noiseShader; // 0x38
	private Material noiseMaterial; // 0x40


	public override bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr) { }

	public void .ctor() { }

}

