public class LensDirtiness : MonoBehaviour, IImageEffect // TypeDefIndex: 8063
{	// Fields
	private Shader Shader_Dirtiness; // 0x18
	private Material Material_Dirtiness; // 0x20
	private RenderTexture RTT_BloomThreshold; // 0x28
	private RenderTexture RTT_1; // 0x30
	private RenderTexture RTT_2; // 0x38
	private RenderTexture RTT_3; // 0x40
	private RenderTexture RTT_4; // 0x48
	private RenderTexture RTT_Bloom_1; // 0x50
	private RenderTexture RTT_Bloom_2; // 0x58
	private int ScreenX; // 0x60
	private int ScreenY; // 0x64
	public bool ShowScreenControls; // 0x68
	public bool SceneTintsBloom; // 0x69
	public Texture2D DirtinessTexture; // 0x70
	public float gain; // 0x78
	public float threshold; // 0x7C
	public float BloomSize; // 0x80
	public float Dirtiness; // 0x84
	public Color BloomColor; // 0x88

	// Methods

	// RVA: 0x1069EB0 Offset: 0x10692B0 VA: 0x181069EB0
	private void OnEnable() { }

	// RVA: 0x106A7F0 Offset: 0x1069BF0 VA: 0x18106A7F0
	private void SetKeyword() { }

	// RVA: 0x8C5D70 Offset: 0x8C5170 VA: 0x1808C5D70 Slot: 4
	public bool IsActive() { }

	// RVA: 0x106A0C0 Offset: 0x10694C0 VA: 0x18106A0C0 Slot: 5
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106A920 Offset: 0x1069D20 VA: 0x18106A920
	public void .ctor() { }

}

private enum LensDirtiness.Pass // TypeDefIndex: 8064
{	// Fields
	public int value__; // 0x0
	public const LensDirtiness.Pass Threshold = 0;
	public const LensDirtiness.Pass Kawase = 1;
	public const LensDirtiness.Pass Compose = 2;

}

