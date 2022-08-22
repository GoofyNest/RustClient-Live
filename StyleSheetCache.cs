internal static class StyleSheetCache // TypeDefIndex: 4723
{	private static StyleSheetCache.SheetHandleKeyComparer s_Comparer; // 0x0
	private static Dictionary<StyleSheetCache.SheetHandleKey, int> s_EnumToIntCache; // 0x8
	private static Dictionary<StyleSheetCache.SheetHandleKey, StylePropertyID[]> s_RulePropertyIDsCache; // 0x10
	private static Dictionary<string, StylePropertyID> s_NameToIDCache; // 0x18
	private static StyleValue[] s_InitialStyleValues; // 0x20
	private static Dictionary<string, string> s_DeprecatedNames; // 0x28


	private static void .cctor() { }

	internal static StyleValue GetInitialValue(StylePropertyID propertyId) { }

}

private struct StyleSheetCache.SheetHandleKey // TypeDefIndex: 4724
{	public readonly int sheetInstanceID; // 0x0
	public readonly int index; // 0x4

}

private class StyleSheetCache.SheetHandleKeyComparer : IEqualityComparer<StyleSheetCache.SheetHandleKey> // TypeDefIndex: 4725
{
	public bool Equals(StyleSheetCache.SheetHandleKey x, StyleSheetCache.SheetHandleKey y) { }

	public int GetHashCode(StyleSheetCache.SheetHandleKey key) { }

	public void .ctor() { }

}

