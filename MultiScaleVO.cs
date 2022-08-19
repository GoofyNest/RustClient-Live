internal sealed class MultiScaleVO : IAmbientOcclusionMethod // TypeDefIndex: 11791
{	// Fields
	private readonly float[] m_SampleThickness; // 0x10
	private readonly float[] m_InvThicknessTable; // 0x18
	private readonly float[] m_SampleWeightTable; // 0x20
	private readonly int[] m_Widths; // 0x28
	private readonly int[] m_Heights; // 0x30
	private AmbientOcclusion m_Settings; // 0x38
	private PropertySheet m_PropertySheet; // 0x40
	private PostProcessResources m_Resources; // 0x48
	private RenderTexture m_AmbientOnlyAO; // 0x50
	private readonly RenderTargetIdentifier[] m_MRT; // 0x58

	// Methods

	// RVA: 0x1019670 Offset: 0x1018A70 VA: 0x181019670
	public void .ctor(AmbientOcclusion settings) { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 4
	public DepthTextureMode GetCameraFlags() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	public void SetResources(PostProcessResources resources) { }

	// RVA: 0x1015530 Offset: 0x1014930 VA: 0x181015530
	private void Alloc(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav) { }

	// RVA: 0x10153C0 Offset: 0x10147C0 VA: 0x1810153C0
	private void AllocArray(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav) { }

	// RVA: 0x825E80 Offset: 0x825280 VA: 0x180825E80
	private void Release(CommandBuffer cmd, int id) { }

	// RVA: 0x1015710 Offset: 0x1014B10 VA: 0x181015710
	private Vector4 CalculateZBufferParams(Camera camera) { }

	// RVA: 0x10156A0 Offset: 0x1014AA0 VA: 0x1810156A0
	private float CalculateTanHalfFovHeight(Camera camera) { }

	// RVA: 0x1016C50 Offset: 0x1016050 VA: 0x181016C50
	private Vector2 GetSize(MultiScaleVO.MipLevel mip) { }

	// RVA: 0x1016BC0 Offset: 0x1015FC0 VA: 0x181016BC0
	private Vector3 GetSizeArray(MultiScaleVO.MipLevel mip) { }

	// RVA: 0x1015BC0 Offset: 0x1014FC0 VA: 0x181015BC0
	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA) { }

	// RVA: 0x1016E60 Offset: 0x1016260 VA: 0x181016E60
	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA) { }

	// RVA: 0x10174A0 Offset: 0x10168A0 VA: 0x1810174A0
	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, Nullable<RenderTargetIdentifier> depthMap, bool isMSAA) { }

	// RVA: 0x1018010 Offset: 0x1017410 VA: 0x181018010
	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA) { }

	// RVA: 0x1018A20 Offset: 0x1017E20 VA: 0x181018A20
	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, Nullable<int> highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = False) { }

	// RVA: 0x1017DF0 Offset: 0x10171F0 VA: 0x181017DF0
	private void PushReleaseCommands(CommandBuffer cmd) { }

	// RVA: 0x1016CE0 Offset: 0x10160E0 VA: 0x181016CE0
	private void PreparePropertySheet(PostProcessRenderContext context) { }

	// RVA: 0x10157B0 Offset: 0x1014BB0 VA: 0x1810157B0
	private void CheckAOTexture(PostProcessRenderContext context) { }

	// RVA: 0x10173F0 Offset: 0x10167F0 VA: 0x1810173F0
	private void PushDebug(PostProcessRenderContext context) { }

	// RVA: 0x1019010 Offset: 0x1018410 VA: 0x181019010 Slot: 5
	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	// RVA: 0x10194B0 Offset: 0x10188B0 VA: 0x1810194B0 Slot: 6
	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x1015970 Offset: 0x1014D70 VA: 0x181015970 Slot: 7
	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x1018F90 Offset: 0x1018390 VA: 0x181018F90 Slot: 8
	public void Release() { }

}

internal enum MultiScaleVO.MipLevel // TypeDefIndex: 11792
{	// Fields
	public int value__; // 0x0
	public const MultiScaleVO.MipLevel Original = 0;
	public const MultiScaleVO.MipLevel L1 = 1;
	public const MultiScaleVO.MipLevel L2 = 2;
	public const MultiScaleVO.MipLevel L3 = 3;
	public const MultiScaleVO.MipLevel L4 = 4;
	public const MultiScaleVO.MipLevel L5 = 5;
	public const MultiScaleVO.MipLevel L6 = 6;

}

private enum MultiScaleVO.Pass // TypeDefIndex: 11793
{	// Fields
	public int value__; // 0x0
	public const MultiScaleVO.Pass DepthCopy = 0;
	public const MultiScaleVO.Pass CompositionDeferred = 1;
	public const MultiScaleVO.Pass CompositionForward = 2;
	public const MultiScaleVO.Pass DebugOverlay = 3;

}

