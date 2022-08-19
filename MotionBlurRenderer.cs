internal sealed class MotionBlurRenderer : PostProcessEffectRenderer<MotionBlur> // TypeDefIndex: 11789
{	// Methods

	// RVA: 0x70CC90 Offset: 0x70C090 VA: 0x18070CC90 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x1014610 Offset: 0x1013A10 VA: 0x181014610 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x10151C0 Offset: 0x10145C0 VA: 0x1810151C0
	public void .ctor() { }

}

private enum MotionBlurRenderer.Pass // TypeDefIndex: 11790
{	// Fields
	public int value__; // 0x0
	public const MotionBlurRenderer.Pass VelocitySetup = 0;
	public const MotionBlurRenderer.Pass TileMax1 = 1;
	public const MotionBlurRenderer.Pass TileMax2 = 2;
	public const MotionBlurRenderer.Pass TileMaxV = 3;
	public const MotionBlurRenderer.Pass NeighborMax = 4;
	public const MotionBlurRenderer.Pass Reconstruction = 5;

}

