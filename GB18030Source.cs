internal class GB18030Source // TypeDefIndex: 7833
{
	private static readonly byte* gbx2uni; 
	private static readonly byte* uni2gbx; 
	private static readonly int gbx2uniSize; 
	private static readonly int uni2gbxSize; 
	private static readonly long gbxBase; 
	private static readonly long gbxSuppBase; 
	private static readonly GB18030Source.GB18030Map[] ranges; 


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
{
	public readonly int UStart; 
	public readonly int UEnd; 
	public readonly long GStart; 
	public readonly long GEnd; 
	public readonly bool Dummy; 


	public void .ctor(int ustart, int uend, long gstart, long gend, bool dummy) { }

}

