internal sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading> // TypeDefIndex: 13470
{
	private Texture2D m_GradingCurves; 
	private readonly Color[] m_Pixels; 
	private RenderTexture m_InternalLdrLut; 
	private RenderTexture m_InternalLogLut; 
	private const int k_Lut2DSize = 32;
	private const int k_Lut3DSize = 33;
	private readonly HableCurve m_HableCurve; 


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

private enum ColorGradingRenderer.Pass // TypeDefIndex: 13471
{
	public int value__; 
	public const ColorGradingRenderer.Pass LutGenLDRFromScratch = 0;
	public const ColorGradingRenderer.Pass LutGenLDR = 1;
	public const ColorGradingRenderer.Pass LutGenHDR2D = 2;

}

