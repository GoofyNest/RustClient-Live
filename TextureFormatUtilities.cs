public static class TextureFormatUtilities // TypeDefIndex: 11869
{	// Fields
	private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap; // 0x0
	private static Dictionary<int, bool> s_SupportedRenderTextureFormats; // 0x8
	private static Dictionary<int, bool> s_SupportedTextureFormats; // 0x10

	// Methods

	// RVA: 0x11DD990 Offset: 0x11DCD90 VA: 0x1811DD990
	private static void .cctor() { }

	// RVA: 0x11DD760 Offset: 0x11DCB60 VA: 0x1811DD760
	private static bool IsObsolete(object value) { }

	// RVA: 0x11DD570 Offset: 0x11DC970 VA: 0x1811DD570
	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11DD870 Offset: 0x11DCC70 VA: 0x1811DD870
	internal static bool IsSupported(RenderTextureFormat format) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11DD900 Offset: 0x11DCD00 VA: 0x1811DD900
	internal static bool IsSupported(TextureFormat format) { }

}

