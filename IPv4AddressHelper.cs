internal static class IPv4AddressHelper // TypeDefIndex: 2587
{	// Methods

	// RVA: 0x1560C90 Offset: 0x1560090 VA: 0x181560C90
	internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) { }

	// RVA: 0x1561100 Offset: 0x1560500 VA: 0x181561100
	internal static int ParseHostNumber(string str, int start, int end) { }

	// RVA: 0x1560AF0 Offset: 0x155FEF0 VA: 0x181560AF0
	internal static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	// RVA: 0x1560990 Offset: 0x155FD90 VA: 0x181560990
	internal static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) { }

	// RVA: 0x15611D0 Offset: 0x15605D0 VA: 0x1815611D0
	internal static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile) { }

	// RVA: 0x1561560 Offset: 0x1560960 VA: 0x181561560
	private static bool Parse(string name, byte* numbers, int start, int end) { }

	// RVA: 0x1561060 Offset: 0x1560460 VA: 0x181561060
	private static bool ParseCanonical(string name, byte* numbers, int start, int end) { }

}

