internal static class JavaScriptUtils // TypeDefIndex: 5959
{	// Fields
	internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x0
	internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x8
	internal static readonly bool[] HtmlCharEscapeFlags; // 0x10

	// Methods

	// RVA: 0x1802A70 Offset: 0x1801E70 VA: 0x181802A70
	private static void .cctor() { }

	// RVA: 0x1801FF0 Offset: 0x18013F0 VA: 0x181801FF0
	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

	// RVA: 0x18020D0 Offset: 0x18014D0 VA: 0x1818020D0
	public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	// RVA: 0x1802470 Offset: 0x1801870 VA: 0x181802470
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer) { }

	// RVA: 0x1802160 Offset: 0x1801560 VA: 0x181802160
	public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

}

