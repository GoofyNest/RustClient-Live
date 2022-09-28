internal sealed class ScalableAO : IAmbientOcclusionMethod // TypeDefIndex: 13490
{
	private RenderTexture m_Result; 
	private PropertySheet m_PropertySheet; 
	private AmbientOcclusion m_Settings; 
	private readonly RenderTargetIdentifier[] m_MRT; 
	private readonly int[] m_SampleCount; 


	public void .ctor(AmbientOcclusion settings) { }

	public DepthTextureMode GetCameraFlags() { }

	private void DoLazyInitialization(PostProcessRenderContext context) { }

	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource) { }

	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	public void Release() { }

}

private enum ScalableAO.Pass // TypeDefIndex: 13491
{
	public int value__; 
	public const ScalableAO.Pass OcclusionEstimationForward = 0;
	public const ScalableAO.Pass OcclusionEstimationDeferred = 1;
	public const ScalableAO.Pass HorizontalBlurForward = 2;
	public const ScalableAO.Pass HorizontalBlurDeferred = 3;
	public const ScalableAO.Pass VerticalBlur = 4;
	public const ScalableAO.Pass CompositionForward = 5;
	public const ScalableAO.Pass CompositionDeferred = 6;
	public const ScalableAO.Pass DebugOverlay = 7;

}

