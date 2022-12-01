public static class StencilMaterial // TypeDefIndex: 5018
{
	private static List<StencilMaterial.MatEntry> m_List;


	[EditorBrowsableAttribute]
	[ObsoleteAttribute]
	public static Material Add(Material baseMat, int stencilID) { }

	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	public static void Remove(Material customMat) { }

	public static void ClearAll() { }

	private static void .cctor() { }

}

private class StencilMaterial.MatEntry // TypeDefIndex: 5019
{
	public Material baseMat;
	public Material customMat;
	public int count;
	public int stencilId;
	public StencilOp operation;
	public CompareFunction compareFunction;
	public int readMask;
	public int writeMask;
	public bool useAlphaClip;
	public ColorWriteMask colorMask;


	public void .ctor() { }

}

