internal sealed class MultiScaleVO : IAmbientOcclusionMethod // TypeDefIndex: 11791
{
	private readonly float[] m_SampleThickness; 
	private readonly float[] m_InvThicknessTable; 
	private readonly float[] m_SampleWeightTable; 
	private readonly int[] m_Widths; 
	private readonly int[] m_Heights; 
	private AmbientOcclusion m_Settings; 
	private PropertySheet m_PropertySheet; 
	private PostProcessResources m_Resources; 
	private RenderTexture m_AmbientOnlyAO; 
	private readonly RenderTargetIdentifier[] m_MRT; 


public void .ctor(AmbientOcclusion settings) { }

public DepthTextureMode GetCameraFlags() { }

public void SetResources(PostProcessResources resources) { }

private void Alloc(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav) { }

private void AllocArray(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav) { }

private void Release(CommandBuffer cmd, int id) { }

private Vector4 CalculateZBufferParams(Camera camera) { }

private float CalculateTanHalfFovHeight(Camera camera) { }

private Vector2 GetSize(MultiScaleVO.MipLevel mip) { }

private Vector3 GetSizeArray(MultiScaleVO.MipLevel mip) { }

public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA) { }

private void PushAllocCommands(CommandBuffer cmd, bool isMSAA) { }

private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, Nullable<RenderTargetIdentifier> depthMap, bool isMSAA) { }

private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA) { }

private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, Nullable<int> highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = False) { }

private void PushReleaseCommands(CommandBuffer cmd) { }

private void PreparePropertySheet(PostProcessRenderContext context) { }

private void CheckAOTexture(PostProcessRenderContext context) { }

private void PushDebug(PostProcessRenderContext context) { }

public void RenderAfterOpaque(PostProcessRenderContext context) { }

public void RenderAmbientOnly(PostProcessRenderContext context) { }

public void CompositeAmbientOnly(PostProcessRenderContext context) { }

public void Release() { }

}

internal enum MultiScaleVO.MipLevel // TypeDefIndex: 11792
{
	public int value__; 
public const MultiScaleVO.MipLevel Original = 0;
public const MultiScaleVO.MipLevel L1 = 1;
public const MultiScaleVO.MipLevel L2 = 2;
public const MultiScaleVO.MipLevel L3 = 3;
public const MultiScaleVO.MipLevel L4 = 4;
public const MultiScaleVO.MipLevel L5 = 5;
public const MultiScaleVO.MipLevel L6 = 6;

}

private enum MultiScaleVO.Pass // TypeDefIndex: 11793
{
	public int value__; 
public const MultiScaleVO.Pass DepthCopy = 0;
public const MultiScaleVO.Pass CompositionDeferred = 1;
public const MultiScaleVO.Pass CompositionForward = 2;
public const MultiScaleVO.Pass DebugOverlay = 3;

}

