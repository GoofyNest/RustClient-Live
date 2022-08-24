internal class DomainNameHelper // TypeDefIndex: 2586
{

	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	internal static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	internal static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) { }

	private static bool IsIdnAce(string input, int index) { }

	private static bool IsIdnAce(char* input, int index) { }

	internal static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end) { }

	internal static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) { }

	private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) { }

}

