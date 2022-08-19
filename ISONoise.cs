public class ISONoise : PostEffectsBase // TypeDefIndex: 8028
{	// Fields
	public float monochromeTiling; // 0x28
	public FilterMode filterMode; // 0x2C
	public Texture2D noiseTexture; // 0x30
	public Shader noiseShader; // 0x38
	private Material noiseMaterial; // 0x40

	// Methods

	// RVA: 0x10679C0 Offset: 0x1066DC0 VA: 0x1810679C0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1067D70 Offset: 0x1067170 VA: 0x181067D70
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1067A20 Offset: 0x1066E20 VA: 0x181067A20
	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr) { }

	// RVA: 0x1068030 Offset: 0x1067430 VA: 0x181068030
	public void .ctor() { }

}

