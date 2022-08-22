public class Texture : Object // TypeDefIndex: 3444
{	public static readonly int GenerateAllMips; // 0x2B0AA90

	public int mipmapCount { get; }
	[NativePropertyAttribute] // RVA: 0x9E3F0 Offset: 0x9D7F0 VA: 0x18009E3F0
	public static AnisotropicFiltering anisotropicFiltering { set; }
	public virtual GraphicsFormat graphicsFormat { get; }
	public virtual int width { get; set; }
	public virtual int height { get; set; }
	public virtual TextureDimension dimension { get; set; }
	public virtual bool isReadable { get; }
	public TextureWrapMode wrapMode { get; set; }
	public FilterMode filterMode { set; }
	public int anisoLevel { set; }
	public float mipMapBias { set; }
	public Vector2 texelSize { get; }
	public static ulong totalTextureMemory { get; }
	public static ulong desiredTextureMemory { get; }
	public static ulong targetTextureMemory { get; }
	public static ulong currentTextureMemory { get; }
	public static ulong nonStreamingTextureMemory { get; }
	public static ulong streamingMipmapUploadCount { get; }
	public static ulong streamingTextureCount { get; }
	public static ulong nonStreamingTextureCount { get; }
	public static ulong streamingTexturePendingLoadCount { get; }
	public static ulong streamingTextureLoadingCount { get; }
	public static bool streamingTextureForceLoadAll { get; set; }
	public static bool streamingTextureDiscardUnusedMips { get; set; }


	protected void .ctor() { }

	[NativeNameAttribute] // RVA: 0x9CCB0 Offset: 0x9C0B0 VA: 0x18009CCB0
	public int get_mipmapCount() { }

	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	[NativeNameAttribute] // RVA: 0x9CE60 Offset: 0x9C260 VA: 0x18009CE60
	public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { }

	public virtual GraphicsFormat get_graphicsFormat() { }

	private int GetDataWidth() { }

	private int GetDataHeight() { }

	private TextureDimension GetDimension() { }

	public virtual int get_width() { }

	public virtual void set_width(int value) { }

	public virtual int get_height() { }

	public virtual void set_height(int value) { }

	public virtual TextureDimension get_dimension() { }

	public virtual void set_dimension(TextureDimension value) { }

	public virtual bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9CF90 Offset: 0x9C390 VA: 0x18009CF90
	public TextureWrapMode get_wrapMode() { }

	public void set_wrapMode(TextureWrapMode value) { }

	public void set_filterMode(FilterMode value) { }

	public void set_anisoLevel(int value) { }

	public void set_mipMapBias(float value) { }

	[NativeNameAttribute] // RVA: 0x9D180 Offset: 0x9C580 VA: 0x18009D180
	public Vector2 get_texelSize() { }

	public IntPtr GetNativeTexturePtr() { }

	[FreeFunctionAttribute] // RVA: 0x9D230 Offset: 0x9C630 VA: 0x18009D230
	public static ulong get_totalTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D2A0 Offset: 0x9C6A0 VA: 0x18009D2A0
	public static ulong get_desiredTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D4A0 Offset: 0x9C8A0 VA: 0x18009D4A0
	public static ulong get_targetTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D4F0 Offset: 0x9C8F0 VA: 0x18009D4F0
	public static ulong get_currentTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D740 Offset: 0x9CB40 VA: 0x18009D740
	public static ulong get_nonStreamingTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DA40 Offset: 0x9CE40 VA: 0x18009DA40
	public static ulong get_streamingMipmapUploadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DAD0 Offset: 0x9CED0 VA: 0x18009DAD0
	public static ulong get_streamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DB90 Offset: 0x9CF90 VA: 0x18009DB90
	public static ulong get_nonStreamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DC00 Offset: 0x9D000 VA: 0x18009DC00
	public static ulong get_streamingTexturePendingLoadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DD50 Offset: 0x9D150 VA: 0x18009DD50
	public static ulong get_streamingTextureLoadingCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DDC0 Offset: 0x9D1C0 VA: 0x18009DDC0
	public static bool get_streamingTextureForceLoadAll() { }

	[FreeFunctionAttribute] // RVA: 0x9DF40 Offset: 0x9D340 VA: 0x18009DF40
	public static void set_streamingTextureForceLoadAll(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x9E000 Offset: 0x9D400 VA: 0x18009E000
	public static bool get_streamingTextureDiscardUnusedMips() { }

	[FreeFunctionAttribute] // RVA: 0x9E0E0 Offset: 0x9D4E0 VA: 0x18009E0E0
	public static void set_streamingTextureDiscardUnusedMips(bool value) { }

	internal bool ValidateFormat(TextureFormat format) { }

	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	internal UnityException CreateNonReadableException(Texture t) { }

	private static void .cctor() { }

	private void get_texelSize_Injected(out Vector2 ret) { }

}

public static class Texture // TypeDefIndex: 5611
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void CompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void DecompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool SaveAsPng(Texture texture, string fileName) { }

	public static Texture2D CreateReadableCopy(Texture2D texture, int width = 0, int height = 0) { }

	public static Texture2D LimitSize(Texture2D tex, int w, int h) { }

	public static Texture2D LimitSize(Texture2D tex, object maxTextureSize1, object maxTextureSize2) { }

}

public class Texture : ConsoleSystem // TypeDefIndex: 11964
{	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static int streamingBudgetOverride; // 0x1F87B

	[ClientVar] // RVA: 0xC11D0 Offset: 0xC05D0 VA: 0x1800C11D0
	public static bool streaming { get; set; }


	public static bool get_streaming() { }

	public static void set_streaming(bool value) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void stats(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

