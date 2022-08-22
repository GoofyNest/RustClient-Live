internal class GB18030Source // TypeDefIndex: 7833
{	private static readonly byte* gbx2uni; // 0x0
	private static readonly byte* uni2gbx; // 0x8
	private static readonly int gbx2uniSize; // 0x10
	private static readonly int uni2gbxSize; // 0x14
	private static readonly long gbxBase; // 0x18
	private static readonly long gbxSuppBase; // 0x20
	private static readonly GB18030Source.GB18030Map[] ranges; // 0x28


	private void .ctor() { }

	private static void .cctor() { }

	public static void Unlinear(byte[] bytes, int start, long gbx) { }

	public static void Unlinear(byte* bytes, long gbx) { }

	public static long FromGBX(byte[] bytes, int start) { }

	public static long FromUCSSurrogate(int cp) { }

	public static long FromUCS(int cp) { }

	private static long FromGBXRaw(byte b1, byte b2, byte b3, byte b4, bool supp) { }

	private static int ToUcsRaw(int idx) { }

	private static long ToGbxRaw(int idx) { }

}

private class GB18030Source.GB18030Map // TypeDefIndex: 7834
{	public readonly int UStart; // 0x10
	public readonly int UEnd; // 0x14
	public readonly long GStart; // 0x18
	public readonly long GEnd; // 0x20
	public readonly bool Dummy; // 0x28


	public void .ctor(int ustart, int uend, long gstart, long gend, bool dummy) { }

}

