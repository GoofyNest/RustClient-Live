public sealed class TemporalAntialiasing // TypeDefIndex: 13503
{
	[TooltipAttribute] 
	[RangeAttribute] 
	public float jitterSpread; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float sharpness; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float stationaryBlending; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float motionBlending; 
	public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc; 
	[CompilerGeneratedAttribute] 
	private Vector2 <jitter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector2 <jitterRaw>k__BackingField; 
	private readonly RenderTargetIdentifier[] m_Mrt; 
	private bool m_ResetHistory; 
	[CompilerGeneratedAttribute] 
	private int <sampleIndex>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <sampleCount>k__BackingField; 
	private const int k_NumEyes = 2;
	private const int k_NumHistoryTextures = 2;
	private readonly RenderTexture[][] m_HistoryTextures; 
	private readonly int[] m_HistoryPingPong; 

	public Vector2 jitter { get; set; }
	public Vector2 jitterRaw { get; set; }
	public int sampleIndex { get; set; }
	public int sampleCount { get; set; }


	[CompilerGeneratedAttribute] 
	public Vector2 get_jitter() { }

	[CompilerGeneratedAttribute] 
	private void set_jitter(Vector2 value) { }

	[CompilerGeneratedAttribute] 
	public Vector2 get_jitterRaw() { }

	[CompilerGeneratedAttribute] 
	private void set_jitterRaw(Vector2 value) { }

	[CompilerGeneratedAttribute] 
	public int get_sampleIndex() { }

	[CompilerGeneratedAttribute] 
	private void set_sampleIndex(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_sampleCount() { }

	[CompilerGeneratedAttribute] 
	public void set_sampleCount(int value) { }

	public bool IsSupported() { }

	internal DepthTextureMode GetCameraFlags() { }

	internal void ResetHistory() { }

	private Vector2 GenerateRandomOffset() { }

	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera) { }

	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context) { }

	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context) { }

	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context) { }

	private RenderTexture CheckHistory(int id, PostProcessRenderContext context) { }

	internal void Render(PostProcessRenderContext context) { }

	internal void Release() { }

	public void .ctor() { }

}

private enum TemporalAntialiasing.Pass // TypeDefIndex: 13504
{
	public int value__; 
	public const TemporalAntialiasing.Pass SolverDilate = 0;
	public const TemporalAntialiasing.Pass SolverNoDilate = 1;

}

