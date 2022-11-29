public class ScreenOverlayEx : PostEffectsBase, IImageEffect // TypeDefIndex: 8084
{
	public ScreenOverlayEx.OverlayBlendMode blendMode; 
	public float intensity; 
	public Texture texture; 
	public Texture normals; 
	public Shader overlayShader; 
	private Material overlayMaterial; 


	public override bool CheckResources() { }

	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum ScreenOverlayEx.OverlayBlendMode // TypeDefIndex: 8085
{
	public int value__; 
	public const ScreenOverlayEx.OverlayBlendMode Additive = 0;
	public const ScreenOverlayEx.OverlayBlendMode ScreenBlend = 1;
	public const ScreenOverlayEx.OverlayBlendMode Multiply = 2;
	public const ScreenOverlayEx.OverlayBlendMode Overlay = 3;
	public const ScreenOverlayEx.OverlayBlendMode AlphaBlend = 4;

}

