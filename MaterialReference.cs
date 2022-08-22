public struct MaterialReference // TypeDefIndex: 6742
{	public int index; // 0x0
	public TMP_FontAsset fontAsset; // 0x8
	public Material material; // 0x10
	public bool isDefaultMaterial; // 0x18
	public bool isFallbackMaterial; // 0x19
	public Material fallbackMaterial; // 0x20
	public float padding; // 0x28
	public int referenceCount; // 0x2C


	public void .ctor(int index, TMP_FontAsset fontAsset, Material material, float padding) { }

	public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) { }

	public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	public static int AddMaterialReference(Material material, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

}

