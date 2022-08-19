public class ColorCorrectionCurves : PostEffectsBase, IImageEffect // TypeDefIndex: 8170
{	// Fields
	public AnimationCurve redChannel; // 0x28
	public AnimationCurve greenChannel; // 0x30
	public AnimationCurve blueChannel; // 0x38
	public bool useDepthCorrection; // 0x40
	public AnimationCurve zCurve; // 0x48
	public AnimationCurve depthRedChannel; // 0x50
	public AnimationCurve depthGreenChannel; // 0x58
	public AnimationCurve depthBlueChannel; // 0x60
	private Material ccMaterial; // 0x68
	private Material ccDepthMaterial; // 0x70
	private Material selectiveCcMaterial; // 0x78
	private Texture2D rgbChannelTex; // 0x80
	private Texture2D rgbDepthChannelTex; // 0x88
	private Texture2D zCurveTex; // 0x90
	public float saturation; // 0x98
	public bool selectiveCc; // 0x9C
	public Color selectiveFromColor; // 0xA0
	public Color selectiveToColor; // 0xB0
	public ColorCorrectionCurves.ColorCorrectionMode mode; // 0xC0
	public bool updateTextures; // 0xC4
	public Shader colorCorrectionCurvesShader; // 0xC8
	public Shader simpleColorCorrectionCurvesShader; // 0xD0
	public Shader colorCorrectionSelectiveShader; // 0xD8
	private bool updateTexturesOnStartup; // 0xE0

	// Methods

	// RVA: 0x12C54F0 Offset: 0x12C48F0 VA: 0x1812C54F0
	private void Start() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void Awake() { }

	// RVA: 0x12C4EC0 Offset: 0x12C42C0 VA: 0x1812C4EC0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12C5510 Offset: 0x12C4910 VA: 0x1812C5510
	public void UpdateParameters() { }

	// RVA: 0x12C5A60 Offset: 0x12C4E60 VA: 0x1812C5A60
	private void UpdateTextures() { }

	// RVA: 0x106ED30 Offset: 0x106E130 VA: 0x18106ED30 Slot: 5
	public bool IsActive() { }

	// RVA: 0x12C51E0 Offset: 0x12C45E0 VA: 0x1812C51E0 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12C5A70 Offset: 0x12C4E70 VA: 0x1812C5A70
	public void .ctor() { }

}

public enum ColorCorrectionCurves.ColorCorrectionMode // TypeDefIndex: 8171
{	// Fields
	public int value__; // 0x0
	public const ColorCorrectionCurves.ColorCorrectionMode Simple = 0;
	public const ColorCorrectionCurves.ColorCorrectionMode Advanced = 1;

}

