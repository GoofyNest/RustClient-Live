internal static class UriHelper // TypeDefIndex: 2581
{	// Fields
	private static readonly char[] HexUpperChars; // 0x13666

	// Methods

	// RVA: 0x22B20A0 Offset: 0x22B14A0 VA: 0x1822B20A0
	internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) { }

	// RVA: 0x22B1E20 Offset: 0x22B1220 VA: 0x1822B1E20
	private static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) { }

	// RVA: 0x22B3090 Offset: 0x22B2490 VA: 0x1822B3090
	internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x22B3170 Offset: 0x22B2570 VA: 0x1822B3170
	internal static char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x22B2B70 Offset: 0x22B1F70 VA: 0x1822B2B70
	internal static void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x22B1F30 Offset: 0x22B1330 VA: 0x1822B1F30
	internal static void EscapeAsciiChar(char ch, char[] to, ref int pos) { }

	// RVA: 0x22B27A0 Offset: 0x22B1BA0 VA: 0x1822B27A0
	internal static char EscapedAscii(char digit, char next) { }

	// RVA: 0x22B28C0 Offset: 0x22B1CC0 VA: 0x1822B28C0
	internal static bool IsNotSafeForUnescape(char ch) { }

	// RVA: 0x22B2910 Offset: 0x22B1D10 VA: 0x1822B2910
	private static bool IsReservedUnreservedOrHash(char c) { }

	// RVA: 0x22B2A40 Offset: 0x22B1E40 VA: 0x1822B2A40
	internal static bool IsUnreserved(char c) { }

	// RVA: 0x22B2840 Offset: 0x22B1C40 VA: 0x1822B2840
	internal static bool Is3986Unreserved(char c) { }

	// RVA: 0x22B3B40 Offset: 0x22B2F40 VA: 0x1822B3B40
	private static void .cctor() { }

}

