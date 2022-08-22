public sealed class X509StoreManager // TypeDefIndex: 1722
{	private static string _userPath; // 0x0
	private static string _localMachinePath; // 0x8
	private static X509Stores _userStore; // 0x10
	private static X509Stores _machineStore; // 0x18

	internal static string CurrentUserPath { get; }
	internal static string LocalMachinePath { get; }
	public static X509Stores CurrentUser { get; }
	public static X509Stores LocalMachine { get; }


	internal static string get_CurrentUserPath() { }

	internal static string get_LocalMachinePath() { }

	public static X509Stores get_CurrentUser() { }

	public static X509Stores get_LocalMachine() { }

}

