public static class ImageProcessing // TypeDefIndex: 12011
{
	private static byte[] signaturePNG; 
	private static byte[] signatureIHDR; 


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

private sealed class ImageProcessing.<>c__DisplayClass1_0 // TypeDefIndex: 12012
{
	public int len1; 
	public int len2; 
	public float[] src; 
	public int len3; 
	public float[] dst; 
	public Action<int> <>9__0; 


	public void .ctor() { }

	internal void <GaussianBlur2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass2_0 // TypeDefIndex: 12013
{
	public int len1; 
	public int len2; 
	public float[] src; 
	public float[] dst; 
	public Action<int> <>9__0; 


	public void .ctor() { }

	internal void <Average2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass3_0 // TypeDefIndex: 12014
{
	public int len1; 
	public int len2; 
	public float[] src; 
	public int len3; 
	public float[] dst; 
	public Action<int> <>9__0; 


	public void .ctor() { }

	internal void <Average2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass4_0 // TypeDefIndex: 12015
{
	public int srclen1; 
	public int srclen2; 
	public float[] src; 
	public float[] dst; 
	public int dstlen2; 


	public void .ctor() { }

	internal void <Upsample2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass5_0 // TypeDefIndex: 12016
{
	public int srclen1; 
	public int srclen2; 
	public float[] src; 
	public int srclen3; 
	public float[] dst; 
	public int dstlen2; 
	public int dstlen3; 


	public void .ctor() { }

	internal void <Upsample2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass6_0 // TypeDefIndex: 12017
{
	public int radius; 
	public int[] src; 
	public int len2; 
	public int srcmask; 
	public Action<int, int> action; 
	public int len1; 


	public void .ctor() { }

	internal void <Dilate2D>b__0(int x) { }

	internal void <Dilate2D>b__1(int y) { }

}

