public sealed class VectorscopeMonitor : Monitor // TypeDefIndex: 13557
{
	public int size; 
	public float exposure; 
	private ComputeBuffer m_Data; 
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;


	internal override void OnDisable() { }

	internal override bool NeedsHalfRes() { }

	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	internal override void Render(PostProcessRenderContext context) { }

	public void .ctor() { }

}

