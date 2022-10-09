internal class TextureLerper // TypeDefIndex: 13611
{
	private static TextureLerper m_Instance; 
	private CommandBuffer m_Command; 
	private PropertySheetFactory m_PropertySheets; 
	private PostProcessResources m_Resources; 
	private List<RenderTexture> m_Recycled; 
	private List<RenderTexture> m_Actives; 

	internal static TextureLerper instance { get; }


	internal static TextureLerper get_instance() { }

	private void .ctor() { }

	internal void BeginFrame(PostProcessRenderContext context) { }

	internal void EndFrame() { }

	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = False, bool force3D = False) { }

	internal Texture Lerp(Texture from, Texture to, float t) { }

	internal Texture Lerp(Texture from, Color to, float t) { }

	internal void Clear() { }

}

