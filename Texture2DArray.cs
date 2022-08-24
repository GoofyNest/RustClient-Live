public sealed class Texture2DArray : Texture // TypeDefIndex: 3448
{
public static int allSlices { get; }
public int depth { get; }
public TextureFormat format { get; }
public override bool isReadable { get; }


	[NativeNameAttribute] 
public static int get_allSlices() { }

	[NativeNameAttribute] 
public int get_depth() { }

	[NativeNameAttribute] 
public TextureFormat get_format() { }

public override bool get_isReadable() { }

	[FreeFunctionAttribute] 
private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] 
public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

}

