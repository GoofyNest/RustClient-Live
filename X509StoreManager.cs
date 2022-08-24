public sealed class X509StoreManager // TypeDefIndex: 1722
{
	private static string _userPath; 
	private static string _localMachinePath; 
	private static X509Stores _userStore; 
	private static X509Stores _machineStore; 

	internal static string CurrentUserPath { get; }
	internal static string LocalMachinePath { get; }
	public static X509Stores CurrentUser { get; }
	public static X509Stores LocalMachine { get; }


	internal static string get_CurrentUserPath() { }

	internal static string get_LocalMachinePath() { }

	public static X509Stores get_CurrentUser() { }

	public static X509Stores get_LocalMachine() { }

}

