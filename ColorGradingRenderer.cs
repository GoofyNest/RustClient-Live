internal sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading> // TypeDefIndex: 11774
{	// Fields
	private Texture2D m_GradingCurves; // 0x20
	private readonly Color[] m_Pixels; // 0x28
	private RenderTexture m_InternalLdrLut; // 0x30
	private RenderTexture m_InternalLogLut; // 0x38
	private const int k_Lut2DSize = 32;
	private const int k_Lut3DSize = 33;
	private readonly HableCurve m_HableCurve; // 0x40

	// Methods

	// RVA: 0x9D4C30 Offset: 0x9D4030 VA: 0x1809D4C30 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9D1930 Offset: 0x9D0D30 VA: 0x1809D1930
	private void RenderExternalPipeline3D(PostProcessRenderContext context) { }

	// RVA: 0x9D2D90 Offset: 0x9D2190 VA: 0x1809D2D90
	private void RenderHDRPipeline3D(PostProcessRenderContext context) { }

	// RVA: 0x9D1BE0 Offset: 0x9D0FE0 VA: 0x1809D1BE0
	private void RenderHDRPipeline2D(PostProcessRenderContext context) { }

	// RVA: 0x9D3C70 Offset: 0x9D3070 VA: 0x1809D3C70
	private void RenderLDRPipeline2D(PostProcessRenderContext context) { }

	// RVA: 0x9D0F50 Offset: 0x9D0350 VA: 0x1809D0F50
	private void CheckInternalLogLut() { }

	// RVA: 0x9D1120 Offset: 0x9D0520 VA: 0x1809D1120
	private void CheckInternalStripLut() { }

	// RVA: 0x9D12E0 Offset: 0x9D06E0 VA: 0x1809D12E0
	private Texture2D GetCurveTexture(bool hdr) { }

	// RVA: 0x9D1850 Offset: 0x9D0C50 VA: 0x1809D1850
	private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format) { }

	// RVA: 0x9D17E0 Offset: 0x9D0BE0 VA: 0x1809D17E0
	private static RenderTextureFormat GetLutFormat() { }

	// RVA: 0x9D12B0 Offset: 0x9D06B0 VA: 0x1809D12B0
	private static TextureFormat GetCurveFormat() { }

	// RVA: 0x9D1880 Offset: 0x9D0C80 VA: 0x1809D1880 Slot: 7
	public override void Release() { }

	// RVA: 0x9D4DA0 Offset: 0x9D41A0 VA: 0x1809D4DA0
	public void .ctor() { }

}

private enum ColorGradingRenderer.Pass // TypeDefIndex: 11775
{	// Fields
	public int value__; // 0x0
	public const ColorGradingRenderer.Pass LutGenLDRFromScratch = 0;
	public const ColorGradingRenderer.Pass LutGenLDR = 1;
	public const ColorGradingRenderer.Pass LutGenHDR2D = 2;

}

