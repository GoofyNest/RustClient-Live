public sealed class Texture3D : Texture // TypeDefIndex: 3447
{	public int depth { get; }
	public override bool isReadable { get; }


	[NativeNameAttribute] // RVA: 0xA22E0 Offset: 0xA16E0 VA: 0x1800A22E0
	public int get_depth() { }

	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2310 Offset: 0xA1710 VA: 0x1800A2310
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0xA2460 Offset: 0xA1860 VA: 0x1800A2460
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0xA24A0 Offset: 0xA18A0 VA: 0x1800A24A0
	public void SetPixels(Color[] colors, int miplevel) { }

	public void SetPixels(Color[] colors) { }

	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	public void Apply() { }

}

