public sealed class Texture3D : Texture // TypeDefIndex: 3447
{
public int depth { get; }
public override bool isReadable { get; }


	[NativeNameAttribute] 
public int get_depth() { }

public override bool get_isReadable() { }

	[FreeFunctionAttribute] 
private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunctionAttribute] 
private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] 
public void SetPixels(Color[] colors, int miplevel) { }

public void SetPixels(Color[] colors) { }

public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] 
public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

public void Apply() { }

}

