public sealed class Texture2D : Texture // TypeDefIndex: 3445
{	public TextureFormat format { get; }
	[StaticAccessorAttribute] // RVA: 0x9F730 Offset: 0x9EB30 VA: 0x18009F730
	public static Texture2D whiteTexture { get; }
	[StaticAccessorAttribute] // RVA: 0x9F730 Offset: 0x9EB30 VA: 0x18009F730
	public static Texture2D blackTexture { get; }
	public override bool isReadable { get; }
	public int requestedMipmapLevel { set; }
	public int minimumMipmapLevel { set; }


	[NativeNameAttribute] // RVA: 0x9E6B0 Offset: 0x9DAB0 VA: 0x18009E6B0
	public TextureFormat get_format() { }

	public static Texture2D get_whiteTexture() { }

	public static Texture2D get_blackTexture() { }

	public void Compress(bool highQuality) { }

	[FreeFunctionAttribute] // RVA: 0x9E720 Offset: 0x9DB20 VA: 0x18009E720
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	public override bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9E8E0 Offset: 0x9DCE0 VA: 0x18009E8E0
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeNameAttribute] // RVA: 0x9E9A0 Offset: 0x9DDA0 VA: 0x18009E9A0
	private bool ResizeImpl(int width, int height) { }

	[NativeNameAttribute] // RVA: 0x9EAA0 Offset: 0x9DEA0 VA: 0x18009EAA0
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute] // RVA: 0x9EB10 Offset: 0x9DF10 VA: 0x18009EB10
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute] // RVA: 0x9EB80 Offset: 0x9DF80 VA: 0x18009EB80
	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	[FreeFunctionAttribute] // RVA: 0x9EBF0 Offset: 0x9DFF0 VA: 0x18009EBF0
	private bool ResizeWithFormatImpl(int width, int height, TextureFormat format, bool hasMipMap) { }

	[FreeFunctionAttribute] // RVA: 0x9EC30 Offset: 0x9E030 VA: 0x18009EC30
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunctionAttribute] // RVA: 0x9EC70 Offset: 0x9E070 VA: 0x18009EC70
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunctionAttribute] // RVA: 0x9ED00 Offset: 0x9E100 VA: 0x18009ED00
	private bool LoadRawTextureDataImpl(IntPtr data, int size) { }

	private IntPtr GetWritableImageData(int frame) { }

	private long GetRawImageDataSize() { }

	[FreeFunctionAttribute] // RVA: 0x9EDC0 Offset: 0x9E1C0 VA: 0x18009EDC0
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9EEA0 Offset: 0x9E2A0 VA: 0x18009EEA0
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9EF50 Offset: 0x9E350 VA: 0x18009EF50
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F000 Offset: 0x9E400 VA: 0x18009F000
	public void ClearMinimumMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F070 Offset: 0x9E470 VA: 0x18009F070
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F0E0 Offset: 0x9E4E0 VA: 0x18009F0E0
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F150 Offset: 0x9E550 VA: 0x18009F150
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F230 Offset: 0x9E630 VA: 0x18009F230
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
	|-RVA: 0x1AA2E80 Offset: 0x1AA2280 VA: 0x181AA2E80
	|-Texture2D.GetRawTextureData<half2>
	|
	|-RVA: 0x1AA2D60 Offset: 0x1AA2160 VA: 0x181AA2D60
	|-Texture2D.GetRawTextureData<Color32>
	*/

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	public void Apply(bool updateMipmaps) { }

	public void Apply() { }

	public bool Resize(int width, int height) { }

	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

