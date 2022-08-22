public sealed class Texture2DArray : Texture // TypeDefIndex: 3448
{	public static int allSlices { get; }
	public int depth { get; }
	public TextureFormat format { get; }
	public override bool isReadable { get; }


	[NativeNameAttribute] // RVA: 0xA27B0 Offset: 0xA1BB0 VA: 0x1800A27B0
	public static int get_allSlices() { }

	[NativeNameAttribute] // RVA: 0xA22E0 Offset: 0xA16E0 VA: 0x1800A22E0
	public int get_depth() { }

	[NativeNameAttribute] // RVA: 0x9E6B0 Offset: 0x9DAB0 VA: 0x18009E6B0
	public TextureFormat get_format() { }

	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2890 Offset: 0xA1C90 VA: 0x1800A2890
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

}

