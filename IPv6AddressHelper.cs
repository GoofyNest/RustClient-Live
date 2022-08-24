internal static class IPv6AddressHelper // TypeDefIndex: 2588
{

	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	internal static string CreateCanonicalName(ushort* numbers) { }

	private static KeyValuePair<int, int> FindCompressionRange(ushort* numbers) { }

	private static bool ShouldHaveIpv4Embedded(ushort* numbers) { }

	private static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress) { }

	internal static bool IsValid(char* name, int start, ref int end) { }

	internal static bool IsValidStrict(char* name, int start, ref int end) { }

	internal static bool Parse(string address, ushort* numbers, int start, ref string scopeId) { }

}

