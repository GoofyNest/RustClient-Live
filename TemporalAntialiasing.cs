public sealed class TemporalAntialiasing // TypeDefIndex: 11807
{	// Fields
	[TooltipAttribute] // RVA: 0x76270 Offset: 0x75670 VA: 0x180076270
	[RangeAttribute] // RVA: 0x76270 Offset: 0x75670 VA: 0x180076270
	public float jitterSpread; // 0x10
	[TooltipAttribute] // RVA: 0x763D0 Offset: 0x757D0 VA: 0x1800763D0
	[RangeAttribute] // RVA: 0x763D0 Offset: 0x757D0 VA: 0x1800763D0
	public float sharpness; // 0x14
	[TooltipAttribute] // RVA: 0x765C0 Offset: 0x759C0 VA: 0x1800765C0
	[RangeAttribute] // RVA: 0x765C0 Offset: 0x759C0 VA: 0x1800765C0
	public float stationaryBlending; // 0x18
	[TooltipAttribute] // RVA: 0x767F0 Offset: 0x75BF0 VA: 0x1800767F0
	[RangeAttribute] // RVA: 0x767F0 Offset: 0x75BF0 VA: 0x1800767F0
	public float motionBlending; // 0x1C
	public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 <jitter>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 <jitterRaw>k__BackingField; // 0x30
	private readonly RenderTargetIdentifier[] m_Mrt; // 0x38
	private bool m_ResetHistory; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <sampleIndex>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <sampleCount>k__BackingField; // 0x48
	private const int k_NumEyes = 2;
	private const int k_NumHistoryTextures = 2;
	private readonly RenderTexture[][] m_HistoryTextures; // 0x50
	private readonly int[] m_HistoryPingPong; // 0x58

	// Properties
	public Vector2 jitter { get; set; }
	public Vector2 jitterRaw { get; set; }
	public int sampleIndex { get; set; }
	public int sampleCount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11DD550 Offset: 0x11DC950 VA: 0x1811DD550
	public Vector2 get_jitter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE86650 Offset: 0xE85A50 VA: 0x180E86650
	private void set_jitter(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC10780 Offset: 0xC0FB80 VA: 0x180C10780
	public Vector2 get_jitterRaw() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC107C0 Offset: 0xC0FBC0 VA: 0x180C107C0
	private void set_jitterRaw(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5F7C90 Offset: 0x5F7090 VA: 0x1805F7C90
	public int get_sampleIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B0DE0 Offset: 0x8B01E0 VA: 0x1808B0DE0
	private void set_sampleIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	public int get_sampleCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B1C90 Offset: 0x5B1090 VA: 0x1805B1C90
	public void set_sampleCount(int value) { }

	// RVA: 0x11DCC40 Offset: 0x11DC040 VA: 0x1811DCC40
	public bool IsSupported() { }

	// RVA: 0x70CC90 Offset: 0x70C090 VA: 0x18070CC90
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x52E560 Offset: 0x52D960 VA: 0x18052E560
	internal void ResetHistory() { }

	// RVA: 0x11DC750 Offset: 0x11DBB50 VA: 0x1811DC750
	private Vector2 GenerateRandomOffset() { }

	// RVA: 0x11DC7E0 Offset: 0x11DBBE0 VA: 0x1811DC7E0
	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera) { }

	// RVA: 0x11DC2D0 Offset: 0x11DB6D0 VA: 0x1811DC2D0
	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context) { }

	// RVA: 0x11DC3B0 Offset: 0x11DB7B0 VA: 0x1811DC3B0
	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context) { }

	// RVA: 0x11DC670 Offset: 0x11DBA70 VA: 0x1811DC670
	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context) { }

	// RVA: 0x11DBA60 Offset: 0x11DAE60 VA: 0x1811DBA60
	private RenderTexture CheckHistory(int id, PostProcessRenderContext context) { }

	// RVA: 0x11DCE70 Offset: 0x11DC270 VA: 0x1811DCE70
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x11DCC80 Offset: 0x11DC080 VA: 0x1811DCC80
	internal void Release() { }

	// RVA: 0x11DD490 Offset: 0x11DC890 VA: 0x1811DD490
	public void .ctor() { }

}

private enum TemporalAntialiasing.Pass // TypeDefIndex: 11808
{	// Fields
	public int value__; // 0x0
	public const TemporalAntialiasing.Pass SolverDilate = 0;
	public const TemporalAntialiasing.Pass SolverNoDilate = 1;

}

