public class Antialiasing : PostEffectsBase // TypeDefIndex: 8150
{
	public AAMode mode; 
	public bool showGeneratedNormals; 
	public float offsetScale; 
	public float blurRadius; 
	public float edgeThresholdMin; 
	public float edgeThreshold; 
	public float edgeSharpness; 
	public bool dlaaSharp; 
	public Shader ssaaShader; 
	private Material ssaa; 
	public Shader dlaaShader; 
	private Material dlaa; 
	public Shader nfaaShader; 
	private Material nfaa; 
	public Shader shaderFXAAPreset2; 
	private Material materialFXAAPreset2; 
	public Shader shaderFXAAPreset3; 
	private Material materialFXAAPreset3; 
	public Shader shaderFXAAII; 
	private Material materialFXAAII; 
	public Shader shaderFXAAIII; 
	private Material materialFXAAIII; 


	public Material CurrentAAMaterial() { }

	public override bool CheckResources() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

