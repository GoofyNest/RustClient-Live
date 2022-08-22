public class NVGEffect : PostEffectsBase, IImageEffect // TypeDefIndex: 8678
{	public NVGEffect.ColorCorrectionParams ColorCorrection1; // 0x28
	public NVGEffect.ColorCorrectionParams ColorCorrection2; // 0x48
	public NVGEffect.NoiseAndGrainParams NoiseAndGrain; // 0x68
	private Texture2D rgbChannelTex1; // 0xA0
	private Texture2D rgbChannelTex2; // 0xA8
	private bool updateTexturesOnStartup; // 0xB0
	public Texture2D NoiseTexture; // 0xB8
	private static float NOISE_TILE_AMOUNT; // 0x0
	public Shader Shader; // 0xC0
	private Material material; // 0xC8


	private void Awake() { }

	private void OnDestroy() { }

	private void UpdateColorCorrectionTexture(NVGEffect.ColorCorrectionParams param, ref Texture2D tex) { }

	public void UpdateTextures() { }

	public override bool CheckResources() { }

	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct NVGEffect.ColorCorrectionParams // TypeDefIndex: 8679
{	public float saturation; // 0x0
	public AnimationCurve redChannel; // 0x8
	public AnimationCurve greenChannel; // 0x10
	public AnimationCurve blueChannel; // 0x18

}

public struct NVGEffect.NoiseAndGrainParams // TypeDefIndex: 8680
{	public float intensityMultiplier; // 0x0
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

