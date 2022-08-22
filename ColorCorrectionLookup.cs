public class ColorCorrectionLookup : PostEffectsBase // TypeDefIndex: 8172
{	public Shader shader; // 0x28
	private Material material; // 0x30
	public Texture3D converted3DLut; // 0x38
	public string basedOnTempTex; // 0x40


	public override bool CheckResources() { }

	private void OnDisable() { }

	private void OnDestroy() { }

	public void SetIdentityLut() { }

	public bool ValidDimensions(Texture2D tex2d) { }

	public void Convert(Texture2D temp2DTex, string path) { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

