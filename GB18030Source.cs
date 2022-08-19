internal class GB18030Source // TypeDefIndex: 7833
{	// Fields
	private static readonly byte* gbx2uni; // 0x0
	private static readonly byte* uni2gbx; // 0x8
	private static readonly int gbx2uniSize; // 0x10
	private static readonly int uni2gbxSize; // 0x14
	private static readonly long gbxBase; // 0x18
	private static readonly long gbxSuppBase; // 0x20
	private static readonly GB18030Source.GB18030Map[] ranges; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0x224B380 Offset: 0x224A780 VA: 0x18224B380
	private static void .cctor() { }

	// RVA: 0x224B260 Offset: 0x224A660 VA: 0x18224B260
	public static void Unlinear(byte[] bytes, int start, long gbx) { }

	// RVA: 0x224B1B0 Offset: 0x224A5B0 VA: 0x18224B1B0
	public static void Unlinear(byte* bytes, long gbx) { }

	// RVA: 0x224AA00 Offset: 0x2249E00 VA: 0x18224AA00
	public static long FromGBX(byte[] bytes, int start) { }

	// RVA: 0x224AE80 Offset: 0x224A280 VA: 0x18224AE80
	public static long FromUCSSurrogate(int cp) { }

	// RVA: 0x224AEE0 Offset: 0x224A2E0 VA: 0x18224AEE0
	public static long FromUCS(int cp) { }

	// RVA: 0x224A9B0 Offset: 0x2249DB0 VA: 0x18224A9B0
	private static long FromGBXRaw(byte b1, byte b2, byte b3, byte b4, bool supp) { }

	// RVA: 0x224B140 Offset: 0x224A540 VA: 0x18224B140
	private static int ToUcsRaw(int idx) { }

	// RVA: 0x224B080 Offset: 0x224A480 VA: 0x18224B080
	private static long ToGbxRaw(int idx) { }

}

private class GB18030Source.GB18030Map // TypeDefIndex: 7834
{	// Fields
	public readonly int UStart; // 0x10
	public readonly int UEnd; // 0x14
	public readonly long GStart; // 0x18
	public readonly long GEnd; // 0x20
	public readonly bool Dummy; // 0x28

	// Methods

	// RVA: 0x224A950 Offset: 0x2249D50 VA: 0x18224A950
	public void .ctor(int ustart, int uend, long gstart, long gend, bool dummy) { }

}

