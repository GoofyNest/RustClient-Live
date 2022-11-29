public class MaterialReferenceManager // TypeDefIndex: 6681
{
	private static MaterialReferenceManager s_Instance; 
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; 
	private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; 
	private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; 

	public static MaterialReferenceManager instance { get; }


	public static MaterialReferenceManager get_instance() { }

	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	private void AddFontAssetInternal(TMP_FontAsset fontAsset) { }

	public static void AddFontMaterial(int hashCode, Material material) { }

	private void AddFontMaterialInternal(int hashCode, Material material) { }

	public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) { }

	private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) { }

	public bool Contains(TMP_FontAsset font) { }

	public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) { }

	private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) { }

	public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) { }

	private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) { }

	public static bool TryGetMaterial(int hashCode, out Material material) { }

	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	public void .ctor() { }

}

