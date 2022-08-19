public sealed class WaveformMonitor : Monitor // TypeDefIndex: 11819
{	// Fields
	public float exposure; // 0x20
	public int height; // 0x24
	private ComputeBuffer m_Data; // 0x28
	private const int k_ThreadGroupSize = 256;
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x11E50B0 Offset: 0x11E44B0 VA: 0x1811E50B0 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x11E6830 Offset: 0x11E5C30 VA: 0x1811E6830 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x11E6050 Offset: 0x11E5450 VA: 0x1811E6050 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x11E68B0 Offset: 0x11E5CB0 VA: 0x1811E68B0
	public void .ctor() { }

}

