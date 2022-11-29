public class Texture : Object // TypeDefIndex: 3445
{
	public static readonly int GenerateAllMips; 

	public int mipmapCount { get; }
	[NativePropertyAttribute] 
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

	[NativeNameAttribute] 
	public int get_mipmapCount() { }

	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	[NativeNameAttribute] 
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

	[NativeNameAttribute] 
	public TextureWrapMode get_wrapMode() { }

	public void set_wrapMode(TextureWrapMode value) { }

	public void set_filterMode(FilterMode value) { }

	public void set_anisoLevel(int value) { }

	public void set_mipMapBias(float value) { }

	[NativeNameAttribute] 
	public Vector2 get_texelSize() { }

	public IntPtr GetNativeTexturePtr() { }

	[FreeFunctionAttribute] 
	public static ulong get_totalTextureMemory() { }

	[FreeFunctionAttribute] 
	public static ulong get_desiredTextureMemory() { }

	[FreeFunctionAttribute] 
	public static ulong get_targetTextureMemory() { }

	[FreeFunctionAttribute] 
	public static ulong get_currentTextureMemory() { }

	[FreeFunctionAttribute] 
	public static ulong get_nonStreamingTextureMemory() { }

	[FreeFunctionAttribute] 
	public static ulong get_streamingMipmapUploadCount() { }

	[FreeFunctionAttribute] 
	public static ulong get_streamingTextureCount() { }

	[FreeFunctionAttribute] 
	public static ulong get_nonStreamingTextureCount() { }

	[FreeFunctionAttribute] 
	public static ulong get_streamingTexturePendingLoadCount() { }

	[FreeFunctionAttribute] 
	public static ulong get_streamingTextureLoadingCount() { }

	[FreeFunctionAttribute] 
	public static bool get_streamingTextureForceLoadAll() { }

	[FreeFunctionAttribute] 
	public static void set_streamingTextureForceLoadAll(bool value) { }

	[FreeFunctionAttribute] 
	public static bool get_streamingTextureDiscardUnusedMips() { }

	[FreeFunctionAttribute] 
	public static void set_streamingTextureDiscardUnusedMips(bool value) { }

	internal bool ValidateFormat(TextureFormat format) { }

	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	internal UnityException CreateNonReadableException(Texture t) { }

	private static void .cctor() { }

	private void get_texelSize_Injected(out Vector2 ret) { }

}

public static class Texture // TypeDefIndex: 5618
{

	[ExtensionAttribute] 
	public static void CompressNormals(Texture2D tex) { }

	[ExtensionAttribute] 
	public static void DecompressNormals(Texture2D tex) { }

	[ExtensionAttribute] 
	public static bool SaveAsPng(Texture texture, string fileName) { }

	public static Texture2D CreateReadableCopy(Texture2D texture, int width = 0, int height = 0) { }

	public static Texture2D LimitSize(Texture2D tex, int w, int h) { }

	public static Texture2D LimitSize(Texture2D tex, object maxTextureSize1, object maxTextureSize2) { }

}

public class Texture : ConsoleSystem // TypeDefIndex: 13756
{
	[ClientVar] 
	public static int streamingBudgetOverride; 

	[ClientVar] 
	public static bool streaming { get; set; }


	public static bool get_streaming() { }

	public static void set_streaming(bool value) { }

	[ClientVar] 
	public static void stats(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

