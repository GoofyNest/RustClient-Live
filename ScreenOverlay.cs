public class ScreenOverlay : PostEffectsBase, IImageEffect // TypeDefIndex: 8207
{
	public ScreenOverlay.OverlayBlendMode blendMode; 
	public float intensity; 
	public Texture texture; 
	public Shader overlayShader; 
	private Material overlayMaterial; 


	public override bool CheckResources() { }

	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum ScreenOverlay.OverlayBlendMode // TypeDefIndex: 8208
{
	public int value__; 
	public const ScreenOverlay.OverlayBlendMode Additive = 0;
	public const ScreenOverlay.OverlayBlendMode ScreenBlend = 1;
	public const ScreenOverlay.OverlayBlendMode Multiply = 2;
	public const ScreenOverlay.OverlayBlendMode Overlay = 3;
	public const ScreenOverlay.OverlayBlendMode AlphaBlend = 4;

}

public class ScreenOverlay : PostProcessEffectSettings // TypeDefIndex: 11983
{
	public OverlayBlendModeParameter blendMode; 
	public FloatParameter intensity; 
	public TextureParameter texture; 
	public TextureParameter normals; 


	public void .ctor() { }

}

