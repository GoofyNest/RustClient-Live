public class ColorCorrectionCurves : PostEffectsBase, IImageEffect // TypeDefIndex: 8179
{
	public AnimationCurve redChannel; 
	public AnimationCurve greenChannel; 
	public AnimationCurve blueChannel; 
	public bool useDepthCorrection; 
	public AnimationCurve zCurve; 
	public AnimationCurve depthRedChannel; 
	public AnimationCurve depthGreenChannel; 
	public AnimationCurve depthBlueChannel; 
	private Material ccMaterial; 
	private Material ccDepthMaterial; 
	private Material selectiveCcMaterial; 
	private Texture2D rgbChannelTex; 
	private Texture2D rgbDepthChannelTex; 
	private Texture2D zCurveTex; 
	public float saturation; 
	public bool selectiveCc; 
	public Color selectiveFromColor; 
	public Color selectiveToColor; 
	public ColorCorrectionCurves.ColorCorrectionMode mode; 
	public bool updateTextures; 
	public Shader colorCorrectionCurvesShader; 
	public Shader simpleColorCorrectionCurvesShader; 
	public Shader colorCorrectionSelectiveShader; 
	private bool updateTexturesOnStartup; 


	private void Start() { }

	private void Awake() { }

	public override bool CheckResources() { }

	public void UpdateParameters() { }

	private void UpdateTextures() { }

	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum ColorCorrectionCurves.ColorCorrectionMode // TypeDefIndex: 8180
{
	public int value__; 
	public const ColorCorrectionCurves.ColorCorrectionMode Simple = 0;
	public const ColorCorrectionCurves.ColorCorrectionMode Advanced = 1;

}

