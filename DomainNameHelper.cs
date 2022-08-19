internal class DomainNameHelper // TypeDefIndex: 2586
{	// Methods

	// RVA: 0x17266E0 Offset: 0x1725AE0 VA: 0x1817266E0
	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	// RVA: 0x1726560 Offset: 0x1725960 VA: 0x181726560
	internal static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x1726350 Offset: 0x1725750 VA: 0x181726350
	internal static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x1725EC0 Offset: 0x17252C0 VA: 0x181725EC0
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x17260F0 Offset: 0x17254F0 VA: 0x1817260F0
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) { }

	// RVA: 0x17262A0 Offset: 0x17256A0 VA: 0x1817262A0
	private static bool IsIdnAce(string input, int index) { }

	// RVA: 0x1726320 Offset: 0x1725720 VA: 0x181726320
	private static bool IsIdnAce(char* input, int index) { }

	// RVA: 0x1726850 Offset: 0x1725C50 VA: 0x181726850
	internal static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end) { }

	// RVA: 0x1726910 Offset: 0x1725D10 VA: 0x181726910
	internal static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x1726270 Offset: 0x1725670 VA: 0x181726270
	private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) { }

	// RVA: 0x1726520 Offset: 0x1725920 VA: 0x181726520
	private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) { }

}

