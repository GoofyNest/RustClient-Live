public sealed class Texture3D : Texture // TypeDefIndex: 3447
{	// Properties
	public int depth { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xA22E0 Offset: 0xA16E0 VA: 0x1800A22E0
	// RVA: 0x2177490 Offset: 0x2176890 VA: 0x182177490
	public int get_depth() { }

	// RVA: 0x21774D0 Offset: 0x21768D0 VA: 0x1821774D0 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2310 Offset: 0xA1710 VA: 0x1800A2310
	// RVA: 0x2176D70 Offset: 0x2176170 VA: 0x182176D70
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2176DD0 Offset: 0x21761D0 VA: 0x182176DD0
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0xA2460 Offset: 0xA1860 VA: 0x1800A2460
	// RVA: 0x2176BD0 Offset: 0x2175FD0 VA: 0x182176BD0
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0xA24A0 Offset: 0xA18A0 VA: 0x1800A24A0
	// RVA: 0x2176EA0 Offset: 0x21762A0 VA: 0x182176EA0
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x2176F00 Offset: 0x2176300 VA: 0x182176F00
	public void SetPixels(Color[] colors) { }

	// RVA: 0x2177180 Offset: 0x2176580 VA: 0x182177180
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2176F50 Offset: 0x2176350 VA: 0x182176F50
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x21773C0 Offset: 0x21767C0 VA: 0x1821773C0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2177070 Offset: 0x2176470 VA: 0x182177070
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x21772A0 Offset: 0x21766A0 VA: 0x1821772A0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2176C30 Offset: 0x2176030 VA: 0x182176C30
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x2176CE0 Offset: 0x21760E0 VA: 0x182176CE0
	public void Apply() { }

}

