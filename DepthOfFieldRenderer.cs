internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField> // TypeDefIndex: 11779
{	// Fields
	private const int k_NumEyes = 2;
	private const int k_NumCoCHistoryTextures = 2;
	private readonly RenderTexture[][] m_CoCHistoryTextures; // 0x20
	private int[] m_HistoryPingPong; // 0x28
	private const float k_FilmHeight = 0,024;

	// Methods

	// RVA: 0x9DBB70 Offset: 0x9DAF70 VA: 0x1809DBB70
	public void .ctor() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x9DBAD0 Offset: 0x9DAED0 VA: 0x1809DBAD0
	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary) { }

	// RVA: 0x9DA710 Offset: 0x9D9B10 VA: 0x1809DA710
	private float CalculateMaxCoCRadius(int screenHeight) { }

	// RVA: 0x9DA7C0 Offset: 0x9D9BC0 VA: 0x1809DA7C0
	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format) { }

	// RVA: 0x9DAD50 Offset: 0x9DA150 VA: 0x1809DAD50 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9DAC00 Offset: 0x9DA000 VA: 0x1809DAC00 Slot: 7
	public override void Release() { }

}

private enum DepthOfFieldRenderer.Pass // TypeDefIndex: 11780
{	// Fields
	public int value__; // 0x0
	public const DepthOfFieldRenderer.Pass CoCCalculation = 0;
	public const DepthOfFieldRenderer.Pass CoCTemporalFilter = 1;
	public const DepthOfFieldRenderer.Pass DownsampleAndPrefilter = 2;
	public const DepthOfFieldRenderer.Pass BokehSmallKernel = 3;
	public const DepthOfFieldRenderer.Pass BokehMediumKernel = 4;
	public const DepthOfFieldRenderer.Pass BokehLargeKernel = 5;
	public const DepthOfFieldRenderer.Pass BokehVeryLargeKernel = 6;
	public const DepthOfFieldRenderer.Pass PostFilter = 7;
	public const DepthOfFieldRenderer.Pass Combine = 8;
	public const DepthOfFieldRenderer.Pass DebugOverlay = 9;

}

