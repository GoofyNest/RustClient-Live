internal static class IPv6AddressHelper // TypeDefIndex: 2588
{	// Methods

	// RVA: 0x15622F0 Offset: 0x15616F0 VA: 0x1815622F0
	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	// RVA: 0x15615F0 Offset: 0x15609F0 VA: 0x1815615F0
	internal static string CreateCanonicalName(ushort* numbers) { }

	// RVA: 0x1561F30 Offset: 0x1561330 VA: 0x181561F30
	private static KeyValuePair<int, int> FindCompressionRange(ushort* numbers) { }

	// RVA: 0x15627A0 Offset: 0x1561BA0 VA: 0x1815627A0
	private static bool ShouldHaveIpv4Embedded(ushort* numbers) { }

	// RVA: 0x1561FD0 Offset: 0x15613D0 VA: 0x181561FD0
	private static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress) { }

	// RVA: 0x15622D0 Offset: 0x15616D0 VA: 0x1815622D0
	internal static bool IsValid(char* name, int start, ref int end) { }

	// RVA: 0x15622B0 Offset: 0x15616B0 VA: 0x1815622B0
	internal static bool IsValidStrict(char* name, int start, ref int end) { }

	// RVA: 0x15623A0 Offset: 0x15617A0 VA: 0x1815623A0
	internal static bool Parse(string address, ushort* numbers, int start, ref string scopeId) { }

}

