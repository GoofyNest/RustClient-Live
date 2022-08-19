public class NVGEffect : PostEffectsBase, IImageEffect // TypeDefIndex: 8678
{	// Fields
	public NVGEffect.ColorCorrectionParams ColorCorrection1; // 0x28
	public NVGEffect.ColorCorrectionParams ColorCorrection2; // 0x48
	public NVGEffect.NoiseAndGrainParams NoiseAndGrain; // 0x68
	private Texture2D rgbChannelTex1; // 0xA0
	private Texture2D rgbChannelTex2; // 0xA8
	private bool updateTexturesOnStartup; // 0xB0
	public Texture2D NoiseTexture; // 0xB8
	private static float NOISE_TILE_AMOUNT; // 0x0
	public Shader Shader; // 0xC0
	private Material material; // 0xC8

	// Methods

	// RVA: 0x7C42A0 Offset: 0x7C36A0 VA: 0x1807C42A0
	private void Awake() { }

	// RVA: 0x7C4530 Offset: 0x7C3930 VA: 0x1807C4530
	private void OnDestroy() { }

	// RVA: 0x7C50A0 Offset: 0x7C44A0 VA: 0x1807C50A0
	private void UpdateColorCorrectionTexture(NVGEffect.ColorCorrectionParams param, ref Texture2D tex) { }

	// RVA: 0x7C5410 Offset: 0x7C4810 VA: 0x1807C5410
	public void UpdateTextures() { }

	// RVA: 0x7C42B0 Offset: 0x7C36B0 VA: 0x1807C42B0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x7C44A0 Offset: 0x7C38A0 VA: 0x1807C44A0 Slot: 5
	public bool IsActive() { }

	// RVA: 0x7C46E0 Offset: 0x7C3AE0 VA: 0x1807C46E0 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x7C54D0 Offset: 0x7C48D0 VA: 0x1807C54D0
	public void .ctor() { }

	// RVA: 0x7C5490 Offset: 0x7C4890 VA: 0x1807C5490
	private static void .cctor() { }

}

public struct NVGEffect.ColorCorrectionParams // TypeDefIndex: 8679
{	// Fields
	public float saturation; // 0x0
	public AnimationCurve redChannel; // 0x8
	public AnimationCurve greenChannel; // 0x10
	public AnimationCurve blueChannel; // 0x18

}

public struct NVGEffect.NoiseAndGrainParams // TypeDefIndex: 8680
{	// Fields
	public float intensityMultiplier; // 0x0
	public float generalIntensity; // 0x4
	public float blackIntensity; // 0x8
	public float whiteIntensity; // 0xC
	public float midGrey; // 0x10
	public bool monochrome; // 0x14
	public Vector3 intensities; // 0x18
	public Vector3 tiling; // 0x24
	public float monochromeTiling; // 0x30
	public FilterMode filterMode; // 0x34

}

