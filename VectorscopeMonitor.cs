public sealed class VectorscopeMonitor : Monitor // TypeDefIndex: 11818
{	// Fields
	public int size; // 0x20
	public float exposure; // 0x24
	private ComputeBuffer m_Data; // 0x28
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x11E50B0 Offset: 0x11E44B0 VA: 0x1811E50B0 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x11E5750 Offset: 0x11E4B50 VA: 0x1811E5750 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x11E50F0 Offset: 0x11E44F0 VA: 0x1811E50F0 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x11E57D0 Offset: 0x11E4BD0 VA: 0x1811E57D0
	public void .ctor() { }

}

