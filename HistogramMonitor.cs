public sealed class HistogramMonitor : Monitor // TypeDefIndex: 11813
{	public int width; // 0x20
	public int height; // 0x24
	public HistogramMonitor.Channel channel; // 0x28
	private ComputeBuffer m_Data; // 0x30
	private const int k_NumBins = 256;
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;


	internal override void OnDisable() { }

	internal override bool NeedsHalfRes() { }

	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	internal override void Render(PostProcessRenderContext context) { }

	public void .ctor() { }

}

public enum HistogramMonitor.Channel // TypeDefIndex: 11814
{	public int value__; // 0x0
	public const HistogramMonitor.Channel Red = 0;
	public const HistogramMonitor.Channel Green = 1;
	public const HistogramMonitor.Channel Blue = 2;
	public const HistogramMonitor.Channel Master = 3;

}

