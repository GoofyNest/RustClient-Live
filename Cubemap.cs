public sealed class Cubemap : Texture // TypeDefIndex: 3447
{
	public TextureFormat format { get; }
	public override bool isReadable { get; }


	[NativeNameAttribute] 
	public TextureFormat get_format() { }

	[FreeFunctionAttribute] 
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	public override bool get_isReadable() { }

	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] 
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	public void .ctor(int width, TextureFormat format, int mipCount) { }

	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	internal void .ctor(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

}

