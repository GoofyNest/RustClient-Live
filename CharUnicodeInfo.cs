public static class CharUnicodeInfo // TypeDefIndex: 685
{
	private static ushort[] s_pCategoryLevel1Index; 
	private static byte[] s_pCategoriesValue; 
	private static ushort[] s_pNumericLevel1Index; 
	private static byte[] s_pNumericValues; 
	private static ushort[] s_pDigitValues; 


	internal static int InternalConvertToUtf32(string s, int index) { }

	internal static int InternalConvertToUtf32(string s, int index, out int charLength) { }

	internal static bool IsWhiteSpace(string s, int index) { }

	internal static bool IsWhiteSpace(char c) { }

	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	internal static UnicodeCategory InternalGetUnicodeCategory(int ch) { }

	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength) { }

	internal static bool IsCombiningCategory(UnicodeCategory uc) { }

	private static void .cctor() { }

}

internal static class CharUnicodeInfo.Debug // TypeDefIndex: 686
{

	internal static void Assert(bool condition, string message) { }

}

