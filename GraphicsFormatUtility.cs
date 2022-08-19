public class GraphicsFormatUtility // TypeDefIndex: 3903
{	// Methods

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x1827680 Offset: 0x1826A80 VA: 0x181827680
	internal static GraphicsFormat GetFormat(Texture texture) { }

	// RVA: 0x1827700 Offset: 0x1826B00 VA: 0x181827700
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x85470 Offset: 0x84870 VA: 0x180085470
	// RVA: 0x1827700 Offset: 0x1826B00 VA: 0x181827700
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x18276C0 Offset: 0x1826AC0 VA: 0x1818276C0
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x18276C0 Offset: 0x1826AC0 VA: 0x1818276C0
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x1827740 Offset: 0x1826B40 VA: 0x181827740
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunctionAttribute] // RVA: 0x85470 Offset: 0x84870 VA: 0x180085470
	// RVA: 0x1827840 Offset: 0x1826C40 VA: 0x181827840
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x85470 Offset: 0x84870 VA: 0x180085470
	// RVA: 0x18277A0 Offset: 0x1826BA0 VA: 0x1818277A0
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x857C0 Offset: 0x84BC0 VA: 0x1800857C0
	// RVA: 0x18277E0 Offset: 0x1826BE0 VA: 0x1818277E0
	internal static bool IsCompressedTextureFormat(TextureFormat format) { }

	// RVA: 0x1827820 Offset: 0x1826C20 VA: 0x181827820
	public static bool IsCrunchFormat(TextureFormat format) { }

}

