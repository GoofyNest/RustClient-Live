internal sealed class ScalableAO : IAmbientOcclusionMethod // TypeDefIndex: 11794
{	// Fields
	private RenderTexture m_Result; // 0x10
	private PropertySheet m_PropertySheet; // 0x18
	private AmbientOcclusion m_Settings; // 0x20
	private readonly RenderTargetIdentifier[] m_MRT; // 0x28
	private readonly int[] m_SampleCount; // 0x30

	// Methods

	// RVA: 0x11D7410 Offset: 0x11D6810 VA: 0x1811D7410
	public void .ctor(AmbientOcclusion settings) { }

	// RVA: 0xABD0E0 Offset: 0xABC4E0 VA: 0x180ABD0E0 Slot: 4
	public DepthTextureMode GetCameraFlags() { }

	// RVA: 0x11D6200 Offset: 0x11D5600 VA: 0x1811D6200
	private void DoLazyInitialization(PostProcessRenderContext context) { }

	// RVA: 0x11D68B0 Offset: 0x11D5CB0 VA: 0x1811D68B0
	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource) { }

	// RVA: 0x11D65C0 Offset: 0x11D59C0 VA: 0x1811D65C0 Slot: 5
	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	// RVA: 0x11D6810 Offset: 0x11D5C10 VA: 0x1811D6810 Slot: 6
	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x11D5E80 Offset: 0x11D5280 VA: 0x1811D5E80 Slot: 7
	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x11D6540 Offset: 0x11D5940 VA: 0x1811D6540 Slot: 8
	public void Release() { }

}

private enum ScalableAO.Pass // TypeDefIndex: 11795
{	// Fields
	public int value__; // 0x0
	public const ScalableAO.Pass OcclusionEstimationForward = 0;
	public const ScalableAO.Pass OcclusionEstimationDeferred = 1;
	public const ScalableAO.Pass HorizontalBlurForward = 2;
	public const ScalableAO.Pass HorizontalBlurDeferred = 3;
	public const ScalableAO.Pass VerticalBlur = 4;
	public const ScalableAO.Pass CompositionForward = 5;
	public const ScalableAO.Pass CompositionDeferred = 6;
	public const ScalableAO.Pass DebugOverlay = 7;

}

