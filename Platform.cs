internal static class Platform // TypeDefIndex: 2597
{	// Fields
	private static bool checkedOS; // 0x0
	private static bool isMacOS; // 0x1
	private static bool isFreeBSD; // 0x2

	// Properties
	public static bool IsMacOS { get; }

	// Methods

	// RVA: 0x1177340 Offset: 0x1176740 VA: 0x181177340
	private static extern int uname(IntPtr buf) { }

	// RVA: 0x1177090 Offset: 0x1176490 VA: 0x181177090
	private static void CheckOS() { }

	// RVA: 0x11772C0 Offset: 0x11766C0 VA: 0x1811772C0
	public static bool get_IsMacOS() { }

}

