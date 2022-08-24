public class NVGEffect : PostEffectsBase, IImageEffect // TypeDefIndex: 8678
{
	public NVGEffect.ColorCorrectionParams ColorCorrection1; 
	public NVGEffect.ColorCorrectionParams ColorCorrection2; 
	public NVGEffect.NoiseAndGrainParams NoiseAndGrain; 
	private Texture2D rgbChannelTex1; 
	private Texture2D rgbChannelTex2; 
	private bool updateTexturesOnStartup; 
	public Texture2D NoiseTexture; 
	private static float NOISE_TILE_AMOUNT; 
	public Shader Shader; 
	private Material material; 


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
{
	public float saturation; 
	public AnimationCurve redChannel; 
	public AnimationCurve greenChannel; 
	public AnimationCurve blueChannel; 

}

public struct NVGEffect.NoiseAndGrainParams // TypeDefIndex: 8680
{
	public float intensityMultiplier; 
	public float generalIntensity; 
	public float blackIntensity; 
	public float whiteIntensity; 
	public float midGrey; 
	public bool monochrome; 
	public Vector3 intensities; 
	public Vector3 tiling; 
	public float monochromeTiling; 
	public FilterMode filterMode; 

}

