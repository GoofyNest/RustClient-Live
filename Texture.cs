public class Texture : Object // TypeDefIndex: 3444
{	// Fields
	public static readonly int GenerateAllMips; // 0x2B0AA90

	// Properties
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

	// Methods

	// RVA: 0x19B5C40 Offset: 0x19B5040 VA: 0x1819B5C40
	protected void .ctor() { }

	[NativeNameAttribute] // RVA: 0x9CCB0 Offset: 0x9C0B0 VA: 0x18009CCB0
	// RVA: 0x19B5D50 Offset: 0x19B5150 VA: 0x1819B5D50
	public int get_mipmapCount() { }

	// RVA: 0x19B6090 Offset: 0x19B5490 VA: 0x1819B6090
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	[NativeNameAttribute] // RVA: 0x9CE60 Offset: 0x9C260 VA: 0x18009CE60
	// RVA: 0x19B5800 Offset: 0x19B4C00 VA: 0x1819B5800
	public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { }

	// RVA: 0x19B5D00 Offset: 0x19B5100 VA: 0x1819B5D00 Slot: 4
	public virtual GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x19B5740 Offset: 0x19B4B40 VA: 0x1819B5740
	private int GetDataWidth() { }

	// RVA: 0x19B5700 Offset: 0x19B4B00 VA: 0x1819B5700
	private int GetDataHeight() { }

	// RVA: 0x19B5780 Offset: 0x19B4B80 VA: 0x1819B5780
	private TextureDimension GetDimension() { }

	// RVA: 0x19B5740 Offset: 0x19B4B40 VA: 0x1819B5740 Slot: 5
	public virtual int get_width() { }

	// RVA: 0x19B6280 Offset: 0x19B5680 VA: 0x1819B6280 Slot: 6
	public virtual void set_width(int value) { }

	// RVA: 0x19B5700 Offset: 0x19B4B00 VA: 0x1819B5700 Slot: 7
	public virtual int get_height() { }

	// RVA: 0x19B6160 Offset: 0x19B5560 VA: 0x1819B6160 Slot: 8
	public virtual void set_height(int value) { }

	// RVA: 0x19B5780 Offset: 0x19B4B80 VA: 0x1819B5780 Slot: 9
	public virtual TextureDimension get_dimension() { }

	// RVA: 0x19B60D0 Offset: 0x19B54D0 VA: 0x1819B60D0 Slot: 10
	public virtual void set_dimension(TextureDimension value) { }

	// RVA: 0x19B5D10 Offset: 0x19B5110 VA: 0x1819B5D10 Slot: 11
	public virtual bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9CF90 Offset: 0x9C390 VA: 0x18009CF90
	// RVA: 0x19B6010 Offset: 0x19B5410 VA: 0x1819B6010
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0x19B62D0 Offset: 0x19B56D0 VA: 0x1819B62D0
	public void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x19B6120 Offset: 0x19B5520 VA: 0x1819B6120
	public void set_filterMode(FilterMode value) { }

	// RVA: 0x19B6050 Offset: 0x19B5450 VA: 0x1819B6050
	public void set_anisoLevel(int value) { }

	// RVA: 0x19B61B0 Offset: 0x19B55B0 VA: 0x1819B61B0
	public void set_mipMapBias(float value) { }

	[NativeNameAttribute] // RVA: 0x9D180 Offset: 0x9C580 VA: 0x18009D180
	// RVA: 0x19B5F90 Offset: 0x19B5390 VA: 0x1819B5F90
	public Vector2 get_texelSize() { }

	// RVA: 0x19B57C0 Offset: 0x19B4BC0 VA: 0x1819B57C0
	public IntPtr GetNativeTexturePtr() { }

	[FreeFunctionAttribute] // RVA: 0x9D230 Offset: 0x9C630 VA: 0x18009D230
	// RVA: 0x19B5FE0 Offset: 0x19B53E0 VA: 0x1819B5FE0
	public static ulong get_totalTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D2A0 Offset: 0x9C6A0 VA: 0x18009D2A0
	// RVA: 0x19B5CD0 Offset: 0x19B50D0 VA: 0x1819B5CD0
	public static ulong get_desiredTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D4A0 Offset: 0x9C8A0 VA: 0x18009D4A0
	// RVA: 0x19B5F10 Offset: 0x19B5310 VA: 0x1819B5F10
	public static ulong get_targetTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D4F0 Offset: 0x9C8F0 VA: 0x18009D4F0
	// RVA: 0x19B5CA0 Offset: 0x19B50A0 VA: 0x1819B5CA0
	public static ulong get_currentTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D740 Offset: 0x9CB40 VA: 0x18009D740
	// RVA: 0x19B5DC0 Offset: 0x19B51C0 VA: 0x1819B5DC0
	public static ulong get_nonStreamingTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DA40 Offset: 0x9CE40 VA: 0x18009DA40
	// RVA: 0x19B5DF0 Offset: 0x19B51F0 VA: 0x1819B5DF0
	public static ulong get_streamingMipmapUploadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DAD0 Offset: 0x9CED0 VA: 0x18009DAD0
	// RVA: 0x19B5E20 Offset: 0x19B5220 VA: 0x1819B5E20
	public static ulong get_streamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DB90 Offset: 0x9CF90 VA: 0x18009DB90
	// RVA: 0x19B5D90 Offset: 0x19B5190 VA: 0x1819B5D90
	public static ulong get_nonStreamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DC00 Offset: 0x9D000 VA: 0x18009DC00
	// RVA: 0x19B5EE0 Offset: 0x19B52E0 VA: 0x1819B5EE0
	public static ulong get_streamingTexturePendingLoadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DD50 Offset: 0x9D150 VA: 0x18009DD50
	// RVA: 0x19B5EB0 Offset: 0x19B52B0 VA: 0x1819B5EB0
	public static ulong get_streamingTextureLoadingCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DDC0 Offset: 0x9D1C0 VA: 0x18009DDC0
	// RVA: 0x19B5E80 Offset: 0x19B5280 VA: 0x1819B5E80
	public static bool get_streamingTextureForceLoadAll() { }

	[FreeFunctionAttribute] // RVA: 0x9DF40 Offset: 0x9D340 VA: 0x18009DF40
	// RVA: 0x19B6240 Offset: 0x19B5640 VA: 0x1819B6240
	public static void set_streamingTextureForceLoadAll(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x9E000 Offset: 0x9D400 VA: 0x18009E000
	// RVA: 0x19B5E50 Offset: 0x19B5250 VA: 0x1819B5E50
	public static bool get_streamingTextureDiscardUnusedMips() { }

	[FreeFunctionAttribute] // RVA: 0x9E0E0 Offset: 0x9D4E0 VA: 0x18009E0E0
	// RVA: 0x19B6200 Offset: 0x19B5600 VA: 0x1819B6200
	public static void set_streamingTextureDiscardUnusedMips(bool value) { }

	// RVA: 0x19B5840 Offset: 0x19B4C40 VA: 0x1819B5840
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x19B5AA0 Offset: 0x19B4EA0 VA: 0x1819B5AA0
	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x19B5680 Offset: 0x19B4A80 VA: 0x1819B5680
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x19B5C00 Offset: 0x19B5000 VA: 0x1819B5C00
	private static void .cctor() { }

	// RVA: 0x19B5F40 Offset: 0x19B5340 VA: 0x1819B5F40
	private void get_texelSize_Injected(out Vector2 ret) { }

}

public static class Texture // TypeDefIndex: 5611
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x199EEE0 Offset: 0x199E2E0 VA: 0x18199EEE0
	public static void CompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x199F200 Offset: 0x199E600 VA: 0x18199F200
	public static void DecompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x199F4C0 Offset: 0x199E8C0 VA: 0x18199F4C0
	public static bool SaveAsPng(Texture texture, string fileName) { }

	// RVA: 0x199EFE0 Offset: 0x199E3E0 VA: 0x18199EFE0
	public static Texture2D CreateReadableCopy(Texture2D texture, int width = 0, int height = 0) { }

	// RVA: 0x199F3A0 Offset: 0x199E7A0 VA: 0x18199F3A0
	public static Texture2D LimitSize(Texture2D tex, int w, int h) { }

	// RVA: 0x199F350 Offset: 0x199E750 VA: 0x18199F350
	public static Texture2D LimitSize(Texture2D tex, object maxTextureSize1, object maxTextureSize2) { }

}

public class Texture : ConsoleSystem // TypeDefIndex: 11964
{	// Fields
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static int streamingBudgetOverride; // 0x1F87B

	// Properties
	[ClientVar] // RVA: 0xC11D0 Offset: 0xC05D0 VA: 0x1800C11D0
	public static bool streaming { get; set; }

	// Methods

	// RVA: 0x36A630 Offset: 0x369A30 VA: 0x18036A630
	public static bool get_streaming() { }

	// RVA: 0x36A640 Offset: 0x369A40 VA: 0x18036A640
	public static void set_streaming(bool value) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x36A650 Offset: 0x369A50 VA: 0x18036A650
	public static void stats(ConsoleSystem.Arg arg) { }

	// RVA: 0x36A5D0 Offset: 0x3699D0 VA: 0x18036A5D0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

