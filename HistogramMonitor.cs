public sealed class HistogramMonitor : Monitor // TypeDefIndex: 11813
{
	public int width; 
	public int height; 
	public HistogramMonitor.Channel channel; 
	private ComputeBuffer m_Data; 
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
{
	public int value__; 
public const HistogramMonitor.Channel Red = 0;
public const HistogramMonitor.Channel Green = 1;
public const HistogramMonitor.Channel Blue = 2;
public const HistogramMonitor.Channel Master = 3;

}

