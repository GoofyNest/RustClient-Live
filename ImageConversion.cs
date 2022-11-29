public static class ImageConversion // TypeDefIndex: 4073
{

[NativeHeaderAttribute] 
[ExtensionAttribute] 
public static class ImageConversion

	[ExtensionAttribute] 
	[NativeMethodAttribute] 
	public static byte[] EncodeToPNG(Texture2D tex) { }

	[NativeMethodAttribute] 
	[ExtensionAttribute] 
	public static byte[] EncodeToJPG(Texture2D tex, int quality) { }

	[ExtensionAttribute] 
	[NativeMethodAttribute] 
	public static bool LoadImage(Texture2D tex, byte[] data, bool markNonReadable) { }

	[ExtensionAttribute] 
	public static bool LoadImage(Texture2D tex, byte[] data) { }

}

