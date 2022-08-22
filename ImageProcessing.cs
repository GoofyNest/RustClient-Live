public static class ImageProcessing // TypeDefIndex: 10280
{	private static byte[] signaturePNG; // 0x0
	private static byte[] signatureIHDR; // 0x8


	public static void GaussianBlur2D(float[] data, int len1, int len2, int iterations = 1) { }

	public static void GaussianBlur2D(float[] data, int len1, int len2, int len3, int iterations = 1) { }

	public static void Average2D(float[] data, int len1, int len2, int iterations = 1) { }

	public static void Average2D(float[] data, int len1, int len2, int len3, int iterations = 1) { }

	public static void Upsample2D(float[] src, int srclen1, int srclen2, float[] dst, int dstlen1, int dstlen2) { }

	public static void Upsample2D(float[] src, int srclen1, int srclen2, int srclen3, float[] dst, int dstlen1, int dstlen2, int dstlen3) { }

	public static void Dilate2D(int[] src, int len1, int len2, int srcmask, int radius, Action<int, int> action) { }

	public static void FloodFill2D(int x, int y, int[] data, int len1, int len2, int mask_any, int mask_not, Func<int, int> action) { }

	public static bool IsValidPNG(byte[] data, int maxWidth, int maxHeight) { }

	public static bool IsValidJPG(byte[] data, int maxWidth, int maxHeight) { }

	public static bool IsClear(Color32[] data) { }

	private static void .cctor() { }

}

private sealed class ImageProcessing.<>c__DisplayClass1_0 // TypeDefIndex: 10281
{	public int len1; // 0x10
	public int len2; // 0x14
	public float[] src; // 0x18
	public int len3; // 0x20
	public float[] dst; // 0x28
	public Action<int> <>9__0; // 0x30


	public void .ctor() { }

	internal void <GaussianBlur2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass2_0 // TypeDefIndex: 10282
{	public int len1; // 0x10
	public int len2; // 0x14
	public float[] src; // 0x18
	public float[] dst; // 0x20
	public Action<int> <>9__0; // 0x28


	public void .ctor() { }

	internal void <Average2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass3_0 // TypeDefIndex: 10283
{	public int len1; // 0x10
	public int len2; // 0x14
	public float[] src; // 0x18
	public int len3; // 0x20
	public float[] dst; // 0x28
	public Action<int> <>9__0; // 0x30


	public void .ctor() { }

	internal void <Average2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass4_0 // TypeDefIndex: 10284
{	public int srclen1; // 0x10
	public int srclen2; // 0x14
	public float[] src; // 0x18
	public float[] dst; // 0x20
	public int dstlen2; // 0x28


	public void .ctor() { }

	internal void <Upsample2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass5_0 // TypeDefIndex: 10285
{	public int srclen1; // 0x10
	public int srclen2; // 0x14
	public float[] src; // 0x18
	public int srclen3; // 0x20
	public float[] dst; // 0x28
	public int dstlen2; // 0x30
	public int dstlen3; // 0x34


	public void .ctor() { }

	internal void <Upsample2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass6_0 // TypeDefIndex: 10286
{	public int radius; // 0x10
	public int[] src; // 0x18
	public int len2; // 0x20
	public int srcmask; // 0x24
	public Action<int, int> action; // 0x28
	public int len1; // 0x30


	public void .ctor() { }

	internal void <Dilate2D>b__0(int x) { }

	internal void <Dilate2D>b__1(int y) { }

}

