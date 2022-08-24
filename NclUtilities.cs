internal static class NclUtilities // TypeDefIndex: 2887
{
	private static IPAddress[] _LocalAddresses; 
	private static object _LocalAddressesLock; 
	internal static string _LocalDomainName; 

internal static IPAddress[] LocalAddresses { get; }
private static object LocalAddressesLock { get; }


internal static bool IsAddressLocal(IPAddress ipAddress) { }

private static IPHostEntry GetLocalHost() { }

internal static IPAddress[] get_LocalAddresses() { }

private static object get_LocalAddressesLock() { }

}

