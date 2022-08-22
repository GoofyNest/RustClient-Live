internal sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading> // TypeDefIndex: 11774
{	private Texture2D m_GradingCurves; // 0x20
	private readonly Color[] m_Pixels; // 0x28
	private RenderTexture m_InternalLdrLut; // 0x30
	private RenderTexture m_InternalLogLut; // 0x38
	private const int k_Lut2DSize = 32;
	private const int k_Lut3DSize = 33;
	private readonly HableCurve m_HableCurve; // 0x40


	public override void Render(PostProcessRenderContext context) { }

	private void RenderExternalPipeline3D(PostProcessRenderContext context) { }

	private void RenderHDRPipeline3D(PostProcessRenderContext context) { }

	private void RenderHDRPipeline2D(PostProcessRenderContext context) { }

	private void RenderLDRPipeline2D(PostProcessRenderContext context) { }

	private void CheckInternalLogLut() { }

	private void CheckInternalStripLut() { }

	private Texture2D GetCurveTexture(bool hdr) { }

	private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format) { }

	private static RenderTextureFormat GetLutFormat() { }

	private static TextureFormat GetCurveFormat() { }

	public override void Release() { }

	public void .ctor() { }

}

private enum ColorGradingRenderer.Pass // TypeDefIndex: 11775
{	public int value__; // 0x0
	public const ColorGradingRenderer.Pass LutGenLDRFromScratch = 0;
	public const ColorGradingRenderer.Pass LutGenLDR = 1;
	public const ColorGradingRenderer.Pass LutGenHDR2D = 2;

}

