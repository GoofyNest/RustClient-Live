public sealed class VectorscopeMonitor : Monitor // TypeDefIndex: 11818
{	public int size; // 0x20
	public float exposure; // 0x24
	private ComputeBuffer m_Data; // 0x28
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;


	internal override void OnDisable() { }

	internal override bool NeedsHalfRes() { }

	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	internal override void Render(PostProcessRenderContext context) { }

	public void .ctor() { }

}

