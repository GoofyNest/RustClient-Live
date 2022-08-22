public static class StencilMaterial // TypeDefIndex: 5012
{	private static List<StencilMaterial.MatEntry> m_List; // 0x2B0ADA8


	[EditorBrowsableAttribute] // RVA: 0x7D590 Offset: 0x7C990 VA: 0x18007D590
	[ObsoleteAttribute] // RVA: 0x7D590 Offset: 0x7C990 VA: 0x18007D590
	public static Material Add(Material baseMat, int stencilID) { }

	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	public static void Remove(Material customMat) { }

	public static void ClearAll() { }

	private static void .cctor() { }

}

private class StencilMaterial.MatEntry // TypeDefIndex: 5013
{	public Material baseMat; // 0x10
	public Material customMat; // 0x18
	public int count; // 0x20
	public int stencilId; // 0x24
	public StencilOp operation; // 0x28
	public CompareFunction compareFunction; // 0x2C
	public int readMask; // 0x30
	public int writeMask; // 0x34
	public bool useAlphaClip; // 0x38
	public ColorWriteMask colorMask; // 0x3C


	public void .ctor() { }

}

