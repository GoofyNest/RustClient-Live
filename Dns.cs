public static class Dns // TypeDefIndex: 2995
{	// Methods

	// RVA: 0x155C000 Offset: 0x155B400 VA: 0x18155C000
	private static bool GetHostByName_internal(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x155BED0 Offset: 0x155B2D0 VA: 0x18155BED0
	private static bool GetHostByAddr_internal(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x155C520 Offset: 0x155B920 VA: 0x18155C520
	private static bool GetHostName_internal(out string h_name) { }

	// RVA: 0x155BE60 Offset: 0x155B260 VA: 0x18155BE60
	private static void Error_11001(string hostName) { }

	// RVA: 0x155C570 Offset: 0x155B970 VA: 0x18155C570
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x155BEE0 Offset: 0x155B2E0 VA: 0x18155BEE0
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x155C100 Offset: 0x155B500 VA: 0x18155C100
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x155C3D0 Offset: 0x155B7D0 VA: 0x18155C3D0
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	[ObsoleteAttribute] // RVA: 0xB6640 Offset: 0xB5A40 VA: 0x1800B6640
	// RVA: 0x155C010 Offset: 0x155B410 VA: 0x18155C010
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x155C530 Offset: 0x155B930 VA: 0x18155C530
	public static string GetHostName() { }

}

