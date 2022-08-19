internal static class IriHelper // TypeDefIndex: 2567
{	// Methods

	// RVA: 0x1562ED0 Offset: 0x15622D0 VA: 0x181562ED0
	internal static bool CheckIriUnicodeRange(char unicode, bool isQuery) { }

	// RVA: 0x1562AC0 Offset: 0x1561EC0 VA: 0x181562AC0
	internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery) { }

	// RVA: 0x1562F40 Offset: 0x1562340 VA: 0x181562F40
	internal static bool CheckIsReserved(char ch, UriComponents component) { }

	// RVA: 0x1563060 Offset: 0x1562460 VA: 0x181563060
	internal static string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component) { }

}

