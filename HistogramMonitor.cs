public sealed class HistogramMonitor : Monitor // TypeDefIndex: 11813
{	// Fields
	public int width; // 0x20
	public int height; // 0x24
	public HistogramMonitor.Channel channel; // 0x28
	private ComputeBuffer m_Data; // 0x30
	private const int k_NumBins = 256;
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x1012320 Offset: 0x1011720 VA: 0x181012320 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x1012980 Offset: 0x1011D80 VA: 0x181012980 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x10123B0 Offset: 0x10117B0 VA: 0x1810123B0 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x1012A00 Offset: 0x1011E00 VA: 0x181012A00
	public void .ctor() { }

}

public enum HistogramMonitor.Channel // TypeDefIndex: 11814
{	// Fields
	public int value__; // 0x0
	public const HistogramMonitor.Channel Red = 0;
	public const HistogramMonitor.Channel Green = 1;
	public const HistogramMonitor.Channel Blue = 2;
	public const HistogramMonitor.Channel Master = 3;

}

