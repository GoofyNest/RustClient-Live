internal static class StyleSheetCache // TypeDefIndex: 4723
{
	private static StyleSheetCache.SheetHandleKeyComparer s_Comparer; 
	private static Dictionary<StyleSheetCache.SheetHandleKey, int> s_EnumToIntCache; 
	private static Dictionary<StyleSheetCache.SheetHandleKey, StylePropertyID[]> s_RulePropertyIDsCache; 
	private static Dictionary<string, StylePropertyID> s_NameToIDCache; 
	private static StyleValue[] s_InitialStyleValues; 
	private static Dictionary<string, string> s_DeprecatedNames; 


private static void .cctor() { }

internal static StyleValue GetInitialValue(StylePropertyID propertyId) { }

}

private struct StyleSheetCache.SheetHandleKey // TypeDefIndex: 4724
{
	public readonly int sheetInstanceID; 
	public readonly int index; 

}

private class StyleSheetCache.SheetHandleKeyComparer : IEqualityComparer<StyleSheetCache.SheetHandleKey> // TypeDefIndex: 4725
{

public bool Equals(StyleSheetCache.SheetHandleKey x, StyleSheetCache.SheetHandleKey y) { }

public int GetHashCode(StyleSheetCache.SheetHandleKey key) { }

public void .ctor() { }

}

