internal static class JavaScriptUtils // TypeDefIndex: 5959
{
	internal static readonly bool[] SingleQuoteCharEscapeFlags; 
	internal static readonly bool[] DoubleQuoteCharEscapeFlags; 
	internal static readonly bool[] HtmlCharEscapeFlags; 


private static void .cctor() { }

public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer) { }

public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

}

