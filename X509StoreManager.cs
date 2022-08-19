public sealed class X509StoreManager // TypeDefIndex: 1722
{	// Fields
	private static string _userPath; // 0x0
	private static string _localMachinePath; // 0x8
	private static X509Stores _userStore; // 0x10
	private static X509Stores _machineStore; // 0x18

	// Properties
	internal static string CurrentUserPath { get; }
	internal static string LocalMachinePath { get; }
	public static X509Stores CurrentUser { get; }
	public static X509Stores LocalMachine { get; }

	// Methods

	// RVA: 0x227CC40 Offset: 0x227C040 VA: 0x18227CC40
	internal static string get_CurrentUserPath() { }

	// RVA: 0x227CEB0 Offset: 0x227C2B0 VA: 0x18227CEB0
	internal static string get_LocalMachinePath() { }

	// RVA: 0x227CD30 Offset: 0x227C130 VA: 0x18227CD30
	public static X509Stores get_CurrentUser() { }

	// RVA: 0x227CFB0 Offset: 0x227C3B0 VA: 0x18227CFB0
	public static X509Stores get_LocalMachine() { }

}

