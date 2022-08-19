public sealed class CubemapArray : Texture // TypeDefIndex: 3449
{	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x1821E30 Offset: 0x1821230 VA: 0x181821E30 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2CC0 Offset: 0xA20C0 VA: 0x1800A2CC0
	// RVA: 0x1821880 Offset: 0x1820C80 VA: 0x181821880
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x18218E0 Offset: 0x1820CE0 VA: 0x1818218E0
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1821BD0 Offset: 0x1820FD0 VA: 0x181821BD0
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1821AC0 Offset: 0x1820EC0 VA: 0x181821AC0
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1821CE0 Offset: 0x18210E0 VA: 0x181821CE0
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x18219A0 Offset: 0x1820DA0 VA: 0x1818219A0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x1821DE0 Offset: 0x18211E0 VA: 0x181821DE0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x1821DA0 Offset: 0x18211A0 VA: 0x181821DA0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

}

