public static class StencilMaterial // TypeDefIndex: 5012
{	// Fields
	private static List<StencilMaterial.MatEntry> m_List; // 0x2B0ADA8

	// Methods

	[EditorBrowsableAttribute] // RVA: 0x7D590 Offset: 0x7C990 VA: 0x18007D590
	[ObsoleteAttribute] // RVA: 0x7D590 Offset: 0x7C990 VA: 0x18007D590
	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x223FA10 Offset: 0x223EE10 VA: 0x18223FA10
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x223F0D0 Offset: 0x223E4D0 VA: 0x18223F0D0
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x223FBE0 Offset: 0x223EFE0 VA: 0x18223FBE0
	public static void Remove(Material customMat) { }

	// RVA: 0x223FAB0 Offset: 0x223EEB0 VA: 0x18223FAB0
	public static void ClearAll() { }

	// RVA: 0x223FDA0 Offset: 0x223F1A0 VA: 0x18223FDA0
	private static void .cctor() { }

}

private class StencilMaterial.MatEntry // TypeDefIndex: 5013
{	// Fields
	public Material baseMat; // 0x10
	public Material customMat; // 0x18
	public int count; // 0x20
	public int stencilId; // 0x24
	public StencilOp operation; // 0x28
	public CompareFunction compareFunction; // 0x2C
	public int readMask; // 0x30
	public int writeMask; // 0x34
	public bool useAlphaClip; // 0x38
	public ColorWriteMask colorMask; // 0x3C

	// Methods

	// RVA: 0x223EF50 Offset: 0x223E350 VA: 0x18223EF50
	public void .ctor() { }

}

