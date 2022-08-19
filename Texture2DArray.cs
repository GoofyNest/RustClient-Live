public sealed class Texture2DArray : Texture // TypeDefIndex: 3448
{	// Properties
	public static int allSlices { get; }
	public int depth { get; }
	public TextureFormat format { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xA27B0 Offset: 0xA1BB0 VA: 0x1800A27B0
	// RVA: 0x2174FF0 Offset: 0x21743F0 VA: 0x182174FF0
	public static int get_allSlices() { }

	[NativeNameAttribute] // RVA: 0xA22E0 Offset: 0xA16E0 VA: 0x1800A22E0
	// RVA: 0x2175020 Offset: 0x2174420 VA: 0x182175020
	public int get_depth() { }

	[NativeNameAttribute] // RVA: 0x9E6B0 Offset: 0x9DAB0 VA: 0x18009E6B0
	// RVA: 0x2175060 Offset: 0x2174460 VA: 0x182175060
	public TextureFormat get_format() { }

	// RVA: 0x21750A0 Offset: 0x21744A0 VA: 0x1821750A0 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2890 Offset: 0xA1C90 VA: 0x1800A2890
	// RVA: 0x2174A00 Offset: 0x2173E00 VA: 0x182174A00
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2174A60 Offset: 0x2173E60 VA: 0x182174A60
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2174B30 Offset: 0x2173F30 VA: 0x182174B30
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2174D60 Offset: 0x2174160 VA: 0x182174D60
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2174F20 Offset: 0x2174320 VA: 0x182174F20
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2174C50 Offset: 0x2174050 VA: 0x182174C50
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2174ED0 Offset: 0x21742D0 VA: 0x182174ED0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x2174E80 Offset: 0x2174280 VA: 0x182174E80
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

}

