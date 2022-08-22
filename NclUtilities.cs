internal static class NclUtilities // TypeDefIndex: 2887
{	private static IPAddress[] _LocalAddresses; // 0x0
	private static object _LocalAddressesLock; // 0x8
	internal static string _LocalDomainName; // 0x10

	internal static IPAddress[] LocalAddresses { get; }
	private static object LocalAddressesLock { get; }


	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	private static IPHostEntry GetLocalHost() { }

	internal static IPAddress[] get_LocalAddresses() { }

	private static object get_LocalAddressesLock() { }

}

