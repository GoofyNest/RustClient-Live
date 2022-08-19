public class MaterialReferenceManager // TypeDefIndex: 6741
{	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x20

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0xC45F70 Offset: 0xC45370 VA: 0x180C45F70
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0xC45990 Offset: 0xC44D90 VA: 0x180C45990
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0xC458F0 Offset: 0xC44CF0 VA: 0x180C458F0
	private void AddFontAssetInternal(TMP_FontAsset fontAsset) { }

	// RVA: 0xC45AA0 Offset: 0xC44EA0 VA: 0x180C45AA0
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0xC45A30 Offset: 0xC44E30 VA: 0x180C45A30
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0xC45860 Offset: 0xC44C60 VA: 0x180C45860
	public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0xC457E0 Offset: 0xC44BE0 VA: 0x180C457E0
	private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0xC45B10 Offset: 0xC44F10 VA: 0x180C45B10
	public bool Contains(TMP_FontAsset font) { }

	// RVA: 0xC45D00 Offset: 0xC45100 VA: 0x180C45D00
	public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC45C80 Offset: 0xC45080 VA: 0x180C45C80
	private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC45BF0 Offset: 0xC44FF0 VA: 0x180C45BF0
	public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0xC45B70 Offset: 0xC44F70 VA: 0x180C45B70
	private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0xC45E10 Offset: 0xC45210 VA: 0x180C45E10
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0xC45D90 Offset: 0xC45190 VA: 0x180C45D90
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0xC45EA0 Offset: 0xC452A0 VA: 0x180C45EA0
	public void .ctor() { }

}

