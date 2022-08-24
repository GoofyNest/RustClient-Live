public static class Dns // TypeDefIndex: 2995
{

	private static bool GetHostByName_internal(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	private static bool GetHostByAddr_internal(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	private static bool GetHostName_internal(out string h_name) { }

	private static void Error_11001(string hostName) { }

	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	public static IPHostEntry GetHostEntry(IPAddress address) { }

	[ObsoleteAttribute] 
	public static IPHostEntry GetHostByName(string hostName) { }

	public static string GetHostName() { }

}

