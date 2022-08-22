public class ScreenOverlay : PostEffectsBase, IImageEffect // TypeDefIndex: 8199
{	public ScreenOverlay.OverlayBlendMode blendMode; // 0x28
	public float intensity; // 0x2C
	public Texture texture; // 0x30
	public Shader overlayShader; // 0x38
	private Material overlayMaterial; // 0x40


	public override bool CheckResources() { }

	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum ScreenOverlay.OverlayBlendMode // TypeDefIndex: 8200
{	public int value__; // 0x0
	public const ScreenOverlay.OverlayBlendMode Additive = 0;
	public const ScreenOverlay.OverlayBlendMode ScreenBlend = 1;
	public const ScreenOverlay.OverlayBlendMode Multiply = 2;
	public const ScreenOverlay.OverlayBlendMode Overlay = 3;
	public const ScreenOverlay.OverlayBlendMode AlphaBlend = 4;

}

public class ScreenOverlay : PostProcessEffectSettings // TypeDefIndex: 10270
{	public OverlayBlendModeParameter blendMode; // 0x30
	public FloatParameter intensity; // 0x38
	public TextureParameter texture; // 0x40
	public TextureParameter normals; // 0x48


	public void .ctor() { }

}

