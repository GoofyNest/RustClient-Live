public class ScreenOverlay : PostEffectsBase, IImageEffect // TypeDefIndex: 8199
{	// Fields
	public ScreenOverlay.OverlayBlendMode blendMode; // 0x28
	public float intensity; // 0x2C
	public Texture texture; // 0x30
	public Shader overlayShader; // 0x38
	private Material overlayMaterial; // 0x40

	// Methods

	// RVA: 0x21E04B0 Offset: 0x21DF8B0 VA: 0x1821E04B0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x106ED30 Offset: 0x106E130 VA: 0x18106ED30 Slot: 5
	public bool IsActive() { }

	// RVA: 0x21E0570 Offset: 0x21DF970 VA: 0x1821E0570 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E0700 Offset: 0x21DFB00 VA: 0x1821E0700
	public void .ctor() { }

}

public enum ScreenOverlay.OverlayBlendMode // TypeDefIndex: 8200
{	// Fields
	public int value__; // 0x0
	public const ScreenOverlay.OverlayBlendMode Additive = 0;
	public const ScreenOverlay.OverlayBlendMode ScreenBlend = 1;
	public const ScreenOverlay.OverlayBlendMode Multiply = 2;
	public const ScreenOverlay.OverlayBlendMode Overlay = 3;
	public const ScreenOverlay.OverlayBlendMode AlphaBlend = 4;

}

public class ScreenOverlay : PostProcessEffectSettings // TypeDefIndex: 10270
{	// Fields
	public OverlayBlendModeParameter blendMode; // 0x30
	public FloatParameter intensity; // 0x38
	public TextureParameter texture; // 0x40
	public TextureParameter normals; // 0x48

	// Methods

	// RVA: 0x4A1830 Offset: 0x4A0C30 VA: 0x1804A1830
	public void .ctor() { }

}

