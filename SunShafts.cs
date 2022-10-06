public class SunShafts : PostEffectsBase // TypeDefIndex: 8213
{
	public SunShafts.SunShaftsResolution resolution; 
	public SunShafts.ShaftsScreenBlendMode screenBlendMode; 
	public Transform sunTransform; 
	public int radialBlurIterations; 
	public Color sunColor; 
	public Color sunThreshold; 
	public float sunShaftBlurRadius; 
	public float sunShaftIntensity; 
	public float maxRadius; 
	public bool useDepthTexture; 
	public Shader sunShaftsShader; 
	private Material sunShaftsMaterial; 
	public Shader simpleClearShader; 
	private Material simpleClearMaterial; 


	public override bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum SunShafts.SunShaftsResolution // TypeDefIndex: 8214
{
	public int value__; 
	public const SunShafts.SunShaftsResolution Low = 0;
	public const SunShafts.SunShaftsResolution Normal = 1;
	public const SunShafts.SunShaftsResolution High = 2;

}

public enum SunShafts.ShaftsScreenBlendMode // TypeDefIndex: 8215
{
	public int value__; 
	public const SunShafts.ShaftsScreenBlendMode Screen = 0;
	public const SunShafts.ShaftsScreenBlendMode Add = 1;

}

