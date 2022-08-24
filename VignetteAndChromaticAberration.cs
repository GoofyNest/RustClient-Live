public class VignetteAndChromaticAberration : PostEffectsBase, IImageEffect // TypeDefIndex: 8216
{
	public VignetteAndChromaticAberration.AberrationMode mode; 
	public float intensity; 
	public float chromaticAberration; 
	public float axialAberration; 
	public float blur; 
	public float blurSpread; 
	public float luminanceDependency; 
	public float blurDistance; 
	public Shader vignetteShader; 
	public Shader separableBlurShader; 
	public Shader chromAberrationShader; 
	private Material m_VignetteMaterial; 
	private Material m_SeparableBlurMaterial; 
	private Material m_ChromAberrationMaterial; 


public override bool CheckResources() { }

public bool IsActive() { }

public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

public void .ctor() { }

}

public enum VignetteAndChromaticAberration.AberrationMode // TypeDefIndex: 8217
{
	public int value__; 
public const VignetteAndChromaticAberration.AberrationMode Simple = 0;
public const VignetteAndChromaticAberration.AberrationMode Advanced = 1;

}

