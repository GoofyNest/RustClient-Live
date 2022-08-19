internal sealed class BloomRenderer : PostProcessEffectRenderer<Bloom> // TypeDefIndex: 11764
{	// Fields
	private BloomRenderer.Level[] m_Pyramid; // 0x20
	private const int k_MaxPyramidSize = 16;

	// Methods

	// RVA: 0x9CDFB0 Offset: 0x9CD3B0 VA: 0x1809CDFB0 Slot: 4
	public override void Init() { }

	// RVA: 0x9CE0B0 Offset: 0x9CD4B0 VA: 0x1809CE0B0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9CF090 Offset: 0x9CE490 VA: 0x1809CF090
	public void .ctor() { }

}

private enum BloomRenderer.Pass // TypeDefIndex: 11765
{	// Fields
	public int value__; // 0x0
	public const BloomRenderer.Pass Prefilter13 = 0;
	public const BloomRenderer.Pass Prefilter4 = 1;
	public const BloomRenderer.Pass Downsample13 = 2;
	public const BloomRenderer.Pass Downsample4 = 3;
	public const BloomRenderer.Pass UpsampleTent = 4;
	public const BloomRenderer.Pass UpsampleBox = 5;
	public const BloomRenderer.Pass DebugOverlayThreshold = 6;
	public const BloomRenderer.Pass DebugOverlayTent = 7;
	public const BloomRenderer.Pass DebugOverlayBox = 8;

}

private struct BloomRenderer.Level // TypeDefIndex: 11766
{	// Fields
	internal int down; // 0x0
	internal int up; // 0x4

}
