internal class TextureLerper // TypeDefIndex: 11870
{	private static TextureLerper m_Instance; // 0x0
	private CommandBuffer m_Command; // 0x10
	private PropertySheetFactory m_PropertySheets; // 0x18
	private PostProcessResources m_Resources; // 0x20
	private List<RenderTexture> m_Recycled; // 0x28
	private List<RenderTexture> m_Actives; // 0x30

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

