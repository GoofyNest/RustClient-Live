public class ColorCorrectionLookup : PostEffectsBase // TypeDefIndex: 8172
{	// Fields
	public Shader shader; // 0x28
	private Material material; // 0x30
	public Texture3D converted3DLut; // 0x38
	public string basedOnTempTex; // 0x40

	// Methods

	// RVA: 0x12C6230 Offset: 0x12C5630 VA: 0x1812C6230 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12C6750 Offset: 0x12C5B50 VA: 0x1812C6750
	private void OnDisable() { }

	// RVA: 0x12C66A0 Offset: 0x12C5AA0 VA: 0x1812C66A0
	private void OnDestroy() { }

	// RVA: 0x12C6A00 Offset: 0x12C5E00 VA: 0x1812C6A00
	public void SetIdentityLut() { }

	// RVA: 0x12C6C60 Offset: 0x12C6060 VA: 0x1812C6C60
	public bool ValidDimensions(Texture2D tex2d) { }

	// RVA: 0x12C62A0 Offset: 0x12C56A0 VA: 0x1812C62A0
	public void Convert(Texture2D temp2DTex, string path) { }

	// RVA: 0x12C6800 Offset: 0x12C5C00 VA: 0x1812C6800
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12C6D40 Offset: 0x12C6140 VA: 0x1812C6D40
	public void .ctor() { }

}

