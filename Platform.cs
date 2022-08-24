internal static class Platform // TypeDefIndex: 2597
{
	private static bool checkedOS; 
	private static bool isMacOS; 
	private static bool isFreeBSD; 

	public static bool IsMacOS { get; }


	private static extern int uname(IntPtr buf) { }

	private static void CheckOS() { }

	public static bool get_IsMacOS() { }

}

