public sealed class Texture2D : Texture // TypeDefIndex: 3445
{	// Properties
	public TextureFormat format { get; }
	[StaticAccessorAttribute] // RVA: 0x9F730 Offset: 0x9EB30 VA: 0x18009F730
	public static Texture2D whiteTexture { get; }
	[StaticAccessorAttribute] // RVA: 0x9F730 Offset: 0x9EB30 VA: 0x18009F730
	public static Texture2D blackTexture { get; }
	public override bool isReadable { get; }
	public int requestedMipmapLevel { set; }
	public int minimumMipmapLevel { set; }

	// Methods

	[NativeNameAttribute] // RVA: 0x9E6B0 Offset: 0x9DAB0 VA: 0x18009E6B0
	// RVA: 0x2176AA0 Offset: 0x2175EA0 VA: 0x182176AA0
	public TextureFormat get_format() { }

	// RVA: 0x2176B20 Offset: 0x2175F20 VA: 0x182176B20
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x2176A70 Offset: 0x2175E70 VA: 0x182176A70
	public static Texture2D get_blackTexture() { }

	// RVA: 0x2175290 Offset: 0x2174690 VA: 0x182175290
	public void Compress(bool highQuality) { }

	[FreeFunctionAttribute] // RVA: 0x9E720 Offset: 0x9DB20 VA: 0x18009E720
	// RVA: 0x2175920 Offset: 0x2174D20 VA: 0x182175920
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x2175980 Offset: 0x2174D80 VA: 0x182175980
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x2176AE0 Offset: 0x2175EE0 VA: 0x182176AE0 Slot: 11
	public override bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9E8E0 Offset: 0x9DCE0 VA: 0x18009E8E0
	// RVA: 0x21750E0 Offset: 0x21744E0 VA: 0x1821750E0
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeNameAttribute] // RVA: 0x9E9A0 Offset: 0x9DDA0 VA: 0x18009E9A0
	// RVA: 0x2175E50 Offset: 0x2175250 VA: 0x182175E50
	private bool ResizeImpl(int width, int height) { }

	[NativeNameAttribute] // RVA: 0x9EAA0 Offset: 0x9DEA0 VA: 0x18009EAA0
	// RVA: 0x2176190 Offset: 0x2175590 VA: 0x182176190
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute] // RVA: 0x9EB10 Offset: 0x9DF10 VA: 0x18009EB10
	// RVA: 0x2175500 Offset: 0x2174900 VA: 0x182175500
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute] // RVA: 0x9EB80 Offset: 0x9DF80 VA: 0x18009EB80
	// RVA: 0x2175340 Offset: 0x2174740 VA: 0x182175340
	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	[FreeFunctionAttribute] // RVA: 0x9EBF0 Offset: 0x9DFF0 VA: 0x18009EBF0
	// RVA: 0x2175EA0 Offset: 0x21752A0 VA: 0x182175EA0
	private bool ResizeWithFormatImpl(int width, int height, TextureFormat format, bool hasMipMap) { }

	[FreeFunctionAttribute] // RVA: 0x9EC30 Offset: 0x9E030 VA: 0x18009EC30
	// RVA: 0x2175C40 Offset: 0x2175040 VA: 0x182175C40
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunctionAttribute] // RVA: 0x9EC70 Offset: 0x9E070 VA: 0x18009EC70
	// RVA: 0x2176390 Offset: 0x2175790 VA: 0x182176390
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunctionAttribute] // RVA: 0x9ED00 Offset: 0x9E100 VA: 0x18009ED00
	// RVA: 0x2175A50 Offset: 0x2174E50 VA: 0x182175A50
	private bool LoadRawTextureDataImpl(IntPtr data, int size) { }

	// RVA: 0x21758E0 Offset: 0x2174CE0 VA: 0x1821758E0
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x21758A0 Offset: 0x2174CA0 VA: 0x1821758A0
	private long GetRawImageDataSize() { }

	[FreeFunctionAttribute] // RVA: 0x9EDC0 Offset: 0x9E1C0 VA: 0x18009EDC0
	// RVA: 0x2176B90 Offset: 0x2175F90 VA: 0x182176B90
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9EEA0 Offset: 0x9E2A0 VA: 0x18009EEA0
	// RVA: 0x2176B50 Offset: 0x2175F50 VA: 0x182176B50
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9EF50 Offset: 0x9E350 VA: 0x18009EF50
	// RVA: 0x2175250 Offset: 0x2174650 VA: 0x182175250
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F000 Offset: 0x9E400 VA: 0x18009F000
	// RVA: 0x2175210 Offset: 0x2174610 VA: 0x182175210
	public void ClearMinimumMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F070 Offset: 0x9E470 VA: 0x18009F070
	// RVA: 0x2176070 Offset: 0x2175470 VA: 0x182176070
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F0E0 Offset: 0x9E4E0 VA: 0x18009F0E0
	// RVA: 0x21760D0 Offset: 0x21754D0 VA: 0x1821760D0
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F150 Offset: 0x9E550 VA: 0x18009F150
	// RVA: 0x21757A0 Offset: 0x2174BA0 VA: 0x1821757A0
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F230 Offset: 0x9E630 VA: 0x18009F230
	// RVA: 0x21756A0 Offset: 0x2174AA0 VA: 0x1821756A0
	public Color32[] GetPixels32(int miplevel) { }

	// RVA: 0x2175660 Offset: 0x2174A60 VA: 0x182175660
	public Color32[] GetPixels32() { }

	// RVA: 0x21768B0 Offset: 0x2175CB0 VA: 0x1821768B0
	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x2176710 Offset: 0x2175B10 VA: 0x182176710
	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2176970 Offset: 0x2175D70 VA: 0x182176970
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex) { }

	// RVA: 0x21765D0 Offset: 0x21759D0 VA: 0x1821765D0
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x2176820 Offset: 0x2175C20 VA: 0x182176820
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2176670 Offset: 0x2175A70 VA: 0x182176670
	public void .ctor(int width, int height) { }

	// RVA: 0x2176200 Offset: 0x2175600 VA: 0x182176200
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x21763F0 Offset: 0x21757F0 VA: 0x1821763F0
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	// RVA: 0x2176520 Offset: 0x2175920 VA: 0x182176520
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x21764B0 Offset: 0x21758B0 VA: 0x1821764B0
	public void SetPixels(Color[] colors) { }

	// RVA: 0x2175580 Offset: 0x2174980 VA: 0x182175580
	public Color GetPixel(int x, int y) { }

	// RVA: 0x21753C0 Offset: 0x21747C0 VA: 0x1821753C0
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x2175AB0 Offset: 0x2174EB0 VA: 0x182175AB0
	public void LoadRawTextureData(IntPtr data, int size) { }

	// RVA: -1 Offset: -1
	public NativeArray<T> GetRawTextureData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA2E80 Offset: 0x1AA2280 VA: 0x181AA2E80
	|-Texture2D.GetRawTextureData<half2>
	|
	|-RVA: 0x1AA2D60 Offset: 0x1AA2160 VA: 0x181AA2D60
	|-Texture2D.GetRawTextureData<Color32>
	*/

	// RVA: 0x2175160 Offset: 0x2174560 VA: 0x182175160
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x2175150 Offset: 0x2174550 VA: 0x182175150
	public void Apply(bool updateMipmaps) { }

	// RVA: 0x2175140 Offset: 0x2174540 VA: 0x182175140
	public void Apply() { }

	// RVA: 0x2175FD0 Offset: 0x21753D0 VA: 0x182175FD0
	public bool Resize(int width, int height) { }

	// RVA: 0x2175F10 Offset: 0x2175310 VA: 0x182175F10
	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x2175D80 Offset: 0x2175180 VA: 0x182175D80
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2175CB0 Offset: 0x21750B0 VA: 0x182175CB0
	public void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x2176070 Offset: 0x2175470 VA: 0x182176070
	public void SetPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x2176340 Offset: 0x2175740 VA: 0x182176340
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x21760D0 Offset: 0x21754D0 VA: 0x1821760D0
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	// RVA: 0x21762D0 Offset: 0x21756D0 VA: 0x1821762D0
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	// RVA: 0x21756E0 Offset: 0x2174AE0 VA: 0x1821756E0
	public Color[] GetPixels(int miplevel) { }

	// RVA: 0x2175800 Offset: 0x2174C00 VA: 0x182175800
	public Color[] GetPixels() { }

	// RVA: 0x2176130 Offset: 0x2175530 VA: 0x182176130
	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	// RVA: 0x21754A0 Offset: 0x21748A0 VA: 0x1821754A0
	private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) { }

	// RVA: 0x21752E0 Offset: 0x21746E0 VA: 0x1821752E0
	private void GetPixelBilinearImpl_Injected(int image, float u, float v, out Color ret) { }

	// RVA: 0x2175BD0 Offset: 0x2174FD0 VA: 0x182175BD0
	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }

}

