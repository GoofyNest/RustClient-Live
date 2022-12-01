public sealed class Texture2D : Texture // TypeDefIndex: 3446
{
	public TextureFormat format { get; }
	[StaticAccessorAttribute]
	public static Texture2D whiteTexture { get; }
	[StaticAccessorAttribute]
	public static Texture2D blackTexture { get; }
	public override bool isReadable { get; }
	public int requestedMipmapLevel { set; }
	public int minimumMipmapLevel { set; }


	[NativeNameAttribute]
	public TextureFormat get_format() { }

	public static Texture2D get_whiteTexture() { }

	public static Texture2D get_blackTexture() { }

	public void Compress(bool highQuality) { }

	[FreeFunctionAttribute]
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	public override bool get_isReadable() { }

	[NativeNameAttribute]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeNameAttribute]
	private bool ResizeImpl(int width, int height) { }

	[NativeNameAttribute]
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute]
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute]
	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	[FreeFunctionAttribute]
	private bool ResizeWithFormatImpl(int width, int height, TextureFormat format, bool hasMipMap) { }

	[FreeFunctionAttribute]
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunctionAttribute]
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunctionAttribute]
	private bool LoadRawTextureDataImpl(IntPtr data, int size) { }

	private IntPtr GetWritableImageData(int frame) { }

	private long GetRawImageDataSize() { }

	[FreeFunctionAttribute]
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute]
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunctionAttribute]
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute]
	public void ClearMinimumMipmapLevel() { }

	[FreeFunctionAttribute]
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute]
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[FreeFunctionAttribute]
	public Color32[] GetPixels32(int miplevel) { }

	public Color32[] GetPixels32() { }

	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex) { }

	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex) { }

	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	public void .ctor(int width, int height) { }

	public void SetPixel(int x, int y, Color color) { }

	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	public void SetPixels(Color[] colors, int miplevel) { }

	public void SetPixels(Color[] colors) { }

	public Color GetPixel(int x, int y) { }

	public Color GetPixelBilinear(float u, float v) { }

	public void LoadRawTextureData(IntPtr data, int size) { }

	public NativeArray<T> GetRawTextureData<T>() { }
	/* GenericInstMethod :
	|
	|-Texture2D.GetRawTextureData<half2>
	|
	|-Texture2D.GetRawTextureData<Color32>
	*/

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	public void Apply(bool updateMipmaps) { }

	public void Apply() { }

	public bool Resize(int width, int height) { }

	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocsAttribute]
	public void ReadPixels(Rect source, int destX, int destY) { }

	public void SetPixels32(Color32[] colors, int miplevel) { }

	public void SetPixels32(Color32[] colors) { }

	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	public Color[] GetPixels(int miplevel) { }

	public Color[] GetPixels() { }

	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) { }

	private void GetPixelBilinearImpl_Injected(int image, float u, float v, out Color ret) { }

	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }

}

