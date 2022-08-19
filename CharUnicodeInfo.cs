public static class CharUnicodeInfo // TypeDefIndex: 685
{	// Fields
	private static ushort[] s_pCategoryLevel1Index; // 0x0
	private static byte[] s_pCategoriesValue; // 0x8
	private static ushort[] s_pNumericLevel1Index; // 0x10
	private static byte[] s_pNumericValues; // 0x18
	private static ushort[] s_pDigitValues; // 0x20

	// Methods

	// RVA: 0x10CDED0 Offset: 0x10CD2D0 VA: 0x1810CDED0
	internal static int InternalConvertToUtf32(string s, int index) { }

	// RVA: 0x10CDE00 Offset: 0x10CD200 VA: 0x1810CDE00
	internal static int InternalConvertToUtf32(string s, int index, out int charLength) { }

	// RVA: 0x10CE420 Offset: 0x10CD820 VA: 0x1810CE420
	internal static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x10CE610 Offset: 0x10CDA10 VA: 0x1810CE610
	internal static bool IsWhiteSpace(char c) { }

	// RVA: 0x10CDDB0 Offset: 0x10CD1B0 VA: 0x1810CDDB0
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	// RVA: 0x10CDC10 Offset: 0x10CD010 VA: 0x1810CDC10
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x10CE0A0 Offset: 0x10CD4A0 VA: 0x1810CE0A0
	internal static UnicodeCategory InternalGetUnicodeCategory(int ch) { }

	// RVA: 0x10CDF90 Offset: 0x10CD390 VA: 0x1810CDF90
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	// RVA: 0x10CE1E0 Offset: 0x10CD5E0 VA: 0x1810CE1E0
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	// RVA: 0x10CE2D0 Offset: 0x10CD6D0 VA: 0x1810CE2D0
	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength) { }

	// RVA: 0x10CE3E0 Offset: 0x10CD7E0 VA: 0x1810CE3E0
	internal static bool IsCombiningCategory(UnicodeCategory uc) { }

	// RVA: 0x10CE6B0 Offset: 0x10CDAB0 VA: 0x1810CE6B0
	private static void .cctor() { }

}

internal static class CharUnicodeInfo.Debug // TypeDefIndex: 686
{	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal static void Assert(bool condition, string message) { }

}

