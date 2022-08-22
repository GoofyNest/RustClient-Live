internal static class Platform // TypeDefIndex: 2597
{	private static bool checkedOS; // 0x0
	private static bool isMacOS; // 0x1
	private static bool isFreeBSD; // 0x2

	public static bool IsMacOS { get; }


	private static extern int uname(IntPtr buf) { }

	private static void CheckOS() { }

	public static bool get_IsMacOS() { }

}

