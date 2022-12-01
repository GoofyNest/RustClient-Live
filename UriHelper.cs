internal static class UriHelper // TypeDefIndex: 2581
{
	private static readonly char[] HexUpperChars;


	internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) { }

	private static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) { }

	internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	internal static char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	internal static void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	internal static void EscapeAsciiChar(char ch, char[] to, ref int pos) { }

	internal static char EscapedAscii(char digit, char next) { }

	internal static bool IsNotSafeForUnescape(char ch) { }

	private static bool IsReservedUnreservedOrHash(char c) { }

	internal static bool IsUnreserved(char c) { }

	internal static bool Is3986Unreserved(char c) { }

	private static void .cctor() { }

}

