internal class TextureLerper // TypeDefIndex: 11870
{	// Fields
	private static TextureLerper m_Instance; // 0x0
	private CommandBuffer m_Command; // 0x10
	private PropertySheetFactory m_PropertySheets; // 0x18
	private PostProcessResources m_Resources; // 0x20
	private List<RenderTexture> m_Recycled; // 0x28
	private List<RenderTexture> m_Actives; // 0x30

	// Properties
	internal static TextureLerper instance { get; }

	// Methods

	// RVA: 0x11DFE30 Offset: 0x11DF230 VA: 0x1811DFE30
	internal static TextureLerper get_instance() { }

	// RVA: 0x11DFD90 Offset: 0x11DF190 VA: 0x1811DFD90
	private void .ctor() { }

	// RVA: 0x11DE330 Offset: 0x11DD730 VA: 0x1811DE330
	internal void BeginFrame(PostProcessRenderContext context) { }

	// RVA: 0x11DE5F0 Offset: 0x11DD9F0 VA: 0x1811DE5F0
	internal void EndFrame() { }

	// RVA: 0x11DE880 Offset: 0x11DDC80 VA: 0x1811DE880
	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = False, bool force3D = False) { }

	// RVA: 0x11DF3F0 Offset: 0x11DE7F0 VA: 0x1811DF3F0
	internal Texture Lerp(Texture from, Texture to, float t) { }

	// RVA: 0x11DEB30 Offset: 0x11DDF30 VA: 0x1811DEB30
	internal Texture Lerp(Texture from, Color to, float t) { }

	// RVA: 0x11DE390 Offset: 0x11DD790 VA: 0x1811DE390
	internal void Clear() { }

}

