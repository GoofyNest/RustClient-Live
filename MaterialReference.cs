public struct MaterialReference // TypeDefIndex: 6684
{
	public int index;
	public TMP_FontAsset fontAsset;
	public Material material;
	public bool isDefaultMaterial;
	public bool isFallbackMaterial;
	public Material fallbackMaterial;
	public float padding;
	public int referenceCount;


	public void .ctor(int index, TMP_FontAsset fontAsset, Material material, float padding) { }

	public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) { }

	public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	public static int AddMaterialReference(Material material, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

}

