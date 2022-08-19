internal static class NclUtilities // TypeDefIndex: 2887
{	// Fields
	private static IPAddress[] _LocalAddresses; // 0x0
	private static object _LocalAddressesLock; // 0x8
	internal static string _LocalDomainName; // 0x10

	// Properties
	internal static IPAddress[] LocalAddresses { get; }
	private static object LocalAddressesLock { get; }

	// Methods

	// RVA: 0x13425A0 Offset: 0x13419A0 VA: 0x1813425A0
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x1342580 Offset: 0x1341980 VA: 0x181342580
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x13426C0 Offset: 0x1341AC0 VA: 0x1813426C0
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x1342630 Offset: 0x1341A30 VA: 0x181342630
	private static object get_LocalAddressesLock() { }

}

