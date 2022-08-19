public class NoiseAndGrain : PostEffectsBase, IImageEffect // TypeDefIndex: 8194
{	// Fields
	public float intensityMultiplier; // 0x28
	public float generalIntensity; // 0x2C
	public float blackIntensity; // 0x30
	public float whiteIntensity; // 0x34
	public float midGrey; // 0x38
	public bool dx11Grain; // 0x3C
	public float softness; // 0x40
	public bool monochrome; // 0x44
	public Vector3 intensities; // 0x48
	public Vector3 tiling; // 0x54
	public float monochromeTiling; // 0x60
	public FilterMode filterMode; // 0x64
	public Texture2D noiseTexture; // 0x68
	public Shader noiseShader; // 0x70
	private Material noiseMaterial; // 0x78
	public Shader dx11NoiseShader; // 0x80
	private Material dx11NoiseMaterial; // 0x88
	private static float TILE_AMOUNT; // 0x0

	// Methods

	// RVA: 0x21DC410 Offset: 0x21DB810 VA: 0x1821DC410 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21DC910 Offset: 0x21DBD10 VA: 0x1821DC910 Slot: 5
	public bool IsActive() { }

	// RVA: 0x21DC9A0 Offset: 0x21DBDA0 VA: 0x1821DC9A0 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DC500 Offset: 0x21DB900 VA: 0x1821DC500
	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr) { }

	// RVA: 0x21DD480 Offset: 0x21DC880 VA: 0x1821DD480
	public void .ctor() { }

	// RVA: 0x21DD440 Offset: 0x21DC840 VA: 0x1821DD440
	private static void .cctor() { }

}

