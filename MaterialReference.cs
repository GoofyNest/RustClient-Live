public struct MaterialReference // TypeDefIndex: 6742
{	// Fields
	public int index; // 0x0
	public TMP_FontAsset fontAsset; // 0x8
	public Material material; // 0x10
	public bool isDefaultMaterial; // 0x18
	public bool isFallbackMaterial; // 0x19
	public Material fallbackMaterial; // 0x20
	public float padding; // 0x28
	public int referenceCount; // 0x2C

	// Methods

	// RVA: 0x117390 Offset: 0x116790 VA: 0x180117390
	public void .ctor(int index, TMP_FontAsset fontAsset, Material material, float padding) { }

	// RVA: 0xC46490 Offset: 0xC45890 VA: 0x180C46490
	public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) { }

	// RVA: 0xC46280 Offset: 0xC45680 VA: 0x180C46280
	public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	// RVA: 0xC460A0 Offset: 0xC454A0 VA: 0x180C460A0
	public static int AddMaterialReference(Material material, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

}

