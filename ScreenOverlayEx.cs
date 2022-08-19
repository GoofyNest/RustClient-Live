public class ScreenOverlayEx : PostEffectsBase, IImageEffect // TypeDefIndex: 8066
{	// Fields
	public ScreenOverlayEx.OverlayBlendMode blendMode; // 0x28
	public float intensity; // 0x2C
	public Texture texture; // 0x30
	public Texture normals; // 0x38
	public Shader overlayShader; // 0x40
	private Material overlayMaterial; // 0x48

	// Methods

	// RVA: 0x106ECD0 Offset: 0x106E0D0 VA: 0x18106ECD0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x106ED30 Offset: 0x106E130 VA: 0x18106ED30 Slot: 5
	public bool IsActive() { }

	// RVA: 0x106ED70 Offset: 0x106E170 VA: 0x18106ED70 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106F160 Offset: 0x106E560 VA: 0x18106F160
	public void .ctor() { }

}

public enum ScreenOverlayEx.OverlayBlendMode // TypeDefIndex: 8067
{	// Fields
	public int value__; // 0x0
	public const ScreenOverlayEx.OverlayBlendMode Additive = 0;
	public const ScreenOverlayEx.OverlayBlendMode ScreenBlend = 1;
	public const ScreenOverlayEx.OverlayBlendMode Multiply = 2;
	public const ScreenOverlayEx.OverlayBlendMode Overlay = 3;
	public const ScreenOverlayEx.OverlayBlendMode AlphaBlend = 4;

}

