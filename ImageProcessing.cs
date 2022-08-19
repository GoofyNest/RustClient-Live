public static class ImageProcessing // TypeDefIndex: 10280
{	// Fields
	private static byte[] signaturePNG; // 0x0
	private static byte[] signatureIHDR; // 0x8

	// Methods

	// RVA: 0x80AB30 Offset: 0x809F30 VA: 0x18080AB30
	public static void GaussianBlur2D(float[] data, int len1, int len2, int iterations = 1) { }

	// RVA: 0x80A990 Offset: 0x809D90 VA: 0x18080A990
	public static void GaussianBlur2D(float[] data, int len1, int len2, int len3, int iterations = 1) { }

	// RVA: 0x80A1A0 Offset: 0x8095A0 VA: 0x18080A1A0
	public static void Average2D(float[] data, int len1, int len2, int iterations = 1) { }

	// RVA: 0x80A330 Offset: 0x809730 VA: 0x18080A330
	public static void Average2D(float[] data, int len1, int len2, int len3, int iterations = 1) { }

	// RVA: 0x80B7C0 Offset: 0x80ABC0 VA: 0x18080B7C0
	public static void Upsample2D(float[] src, int srclen1, int srclen2, float[] dst, int dstlen1, int dstlen2) { }

	// RVA: 0x80B690 Offset: 0x80AA90 VA: 0x18080B690
	public static void Upsample2D(float[] src, int srclen1, int srclen2, int srclen3, float[] dst, int dstlen1, int dstlen2, int dstlen3) { }

	// RVA: 0x80A4D0 Offset: 0x8098D0 VA: 0x18080A4D0
	public static void Dilate2D(int[] src, int len1, int len2, int srcmask, int radius, Action<int, int> action) { }

	// RVA: 0x80A620 Offset: 0x809A20 VA: 0x18080A620
	public static void FloodFill2D(int x, int y, int[] data, int len1, int len2, int mask_any, int mask_not, Func<int, int> action) { }

	// RVA: 0x80B2A0 Offset: 0x80A6A0 VA: 0x18080B2A0
	public static bool IsValidPNG(byte[] data, int maxWidth, int maxHeight) { }

	// RVA: 0x80AEE0 Offset: 0x80A2E0 VA: 0x18080AEE0
	public static bool IsValidJPG(byte[] data, int maxWidth, int maxHeight) { }

	// RVA: 0x80AE80 Offset: 0x80A280 VA: 0x18080AE80
	public static bool IsClear(Color32[] data) { }

	// RVA: 0x80B8E0 Offset: 0x80ACE0 VA: 0x18080B8E0
	private static void .cctor() { }

}

private sealed class ImageProcessing.<>c__DisplayClass1_0 // TypeDefIndex: 10281
{	// Fields
	public int len1; // 0x10
	public int len2; // 0x14
	public float[] src; // 0x18
	public int len3; // 0x20
	public float[] dst; // 0x28
	public Action<int> <>9__0; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x81E4C0 Offset: 0x81D8C0 VA: 0x18081E4C0
	internal void <GaussianBlur2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass2_0 // TypeDefIndex: 10282
{	// Fields
	public int len1; // 0x10
	public int len2; // 0x14
	public float[] src; // 0x18
	public float[] dst; // 0x20
	public Action<int> <>9__0; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x81E780 Offset: 0x81DB80 VA: 0x18081E780
	internal void <Average2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass3_0 // TypeDefIndex: 10283
{	// Fields
	public int len1; // 0x10
	public int len2; // 0x14
	public float[] src; // 0x18
	public int len3; // 0x20
	public float[] dst; // 0x28
	public Action<int> <>9__0; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x81E9A0 Offset: 0x81DDA0 VA: 0x18081E9A0
	internal void <Average2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass4_0 // TypeDefIndex: 10284
{	// Fields
	public int srclen1; // 0x10
	public int srclen2; // 0x14
	public float[] src; // 0x18
	public float[] dst; // 0x20
	public int dstlen2; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x81EC50 Offset: 0x81E050 VA: 0x18081EC50
	internal void <Upsample2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass5_0 // TypeDefIndex: 10285
{	// Fields
	public int srclen1; // 0x10
	public int srclen2; // 0x14
	public float[] src; // 0x18
	public int srclen3; // 0x20
	public float[] dst; // 0x28
	public int dstlen2; // 0x30
	public int dstlen3; // 0x34

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x81F090 Offset: 0x81E490 VA: 0x18081F090
	internal void <Upsample2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass6_0 // TypeDefIndex: 10286
{	// Fields
	public int radius; // 0x10
	public int[] src; // 0x18
	public int len2; // 0x20
	public int srcmask; // 0x24
	public Action<int, int> action; // 0x28
	public int len1; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x81F560 Offset: 0x81E960 VA: 0x18081F560
	internal void <Dilate2D>b__0(int x) { }

	// RVA: 0x81F700 Offset: 0x81EB00 VA: 0x18081F700
	internal void <Dilate2D>b__1(int y) { }

}

