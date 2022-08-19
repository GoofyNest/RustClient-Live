public sealed class Cubemap : Texture // TypeDefIndex: 3446
{	// Properties
	public TextureFormat format { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0x9E6B0 Offset: 0x9DAB0 VA: 0x18009E6B0
	// RVA: 0x1822470 Offset: 0x1821870 VA: 0x181822470
	public TextureFormat get_format() { }

	[FreeFunctionAttribute] // RVA: 0x9F990 Offset: 0x9ED90 VA: 0x18009F990
	// RVA: 0x1821E70 Offset: 0x1821270 VA: 0x181821E70
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x1821ED0 Offset: 0x18212D0 VA: 0x181821ED0
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x18224B0 Offset: 0x18218B0 VA: 0x1818224B0 Slot: 11
	public override bool get_isReadable() { }

	// RVA: 0x1822050 Offset: 0x1821450 VA: 0x181822050
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18221D0 Offset: 0x18215D0 VA: 0x1818221D0
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1821FE0 Offset: 0x18213E0 VA: 0x181821FE0
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x18222B0 Offset: 0x18216B0 VA: 0x1818222B0
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x1822360 Offset: 0x1821760 VA: 0x181822360
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x1821FA0 Offset: 0x18213A0 VA: 0x181821FA0
	internal void .ctor(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x1822140 Offset: 0x1821540 VA: 0x181822140
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

}

