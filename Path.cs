public static class Path // TypeDefIndex: 678
{	// Fields
	[ObsoleteAttribute] // RVA: 0xA7E50 Offset: 0xA7250 VA: 0x1800A7E50
	public static readonly char[] InvalidPathChars; // 0x0
	public static readonly char AltDirectorySeparatorChar; // 0x8
	public static readonly char DirectorySeparatorChar; // 0xA
	public static readonly char PathSeparator; // 0xC
	internal static readonly string DirectorySeparatorStr; // 0x10
	public static readonly char VolumeSeparatorChar; // 0x18
	internal static readonly char[] PathSeparatorChars; // 0x20
	private static readonly bool dirEqualsVolume; // 0x28
	internal static readonly char[] trimEndCharsWindows; // 0x30
	internal static readonly char[] trimEndCharsUnix; // 0x38

	// Properties
	internal static string DirectorySeparatorCharAsString { get; }
	internal static char[] TrimEndChars { get; }

	// Methods

	// RVA: 0x1624CF0 Offset: 0x16240F0 VA: 0x181624CF0
	public static string ChangeExtension(string path, string extension) { }

	// RVA: 0x16256B0 Offset: 0x1624AB0 VA: 0x1816256B0
	public static string Combine(string path1, string path2) { }

	// RVA: 0x16251C0 Offset: 0x16245C0 VA: 0x1816251C0
	internal static string CleanPath(string s) { }

	// RVA: 0x1625F40 Offset: 0x1625340 VA: 0x181625F40
	public static string GetDirectoryName(string path) { }

	// RVA: 0x1626350 Offset: 0x1625750 VA: 0x181626350
	public static string GetExtension(string path) { }

	// RVA: 0x16264C0 Offset: 0x16258C0 VA: 0x1816264C0
	public static string GetFileName(string path) { }

	// RVA: 0x1626460 Offset: 0x1625860 VA: 0x181626460
	public static string GetFileNameWithoutExtension(string path) { }

	// RVA: 0x16269D0 Offset: 0x1625DD0 VA: 0x1816269D0
	public static string GetFullPath(string path) { }

	// RVA: 0x16265D0 Offset: 0x16259D0 VA: 0x1816265D0
	internal static string GetFullPathInternal(string path) { }

	// RVA: 0x1626630 Offset: 0x1625A30 VA: 0x181626630
	private static extern int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull) { }

	// RVA: 0x1626710 Offset: 0x1625B10 VA: 0x181626710
	internal static string GetFullPathName(string path) { }

	// RVA: 0x1628A70 Offset: 0x1627E70 VA: 0x181628A70
	internal static string WindowsDriveAdjustment(string path) { }

	// RVA: 0x1627750 Offset: 0x1626B50 VA: 0x181627750
	internal static string InsecureGetFullPath(string path) { }

	// RVA: 0x1628180 Offset: 0x1627580 VA: 0x181628180
	internal static bool IsDirectorySeparator(char c) { }

	// RVA: 0x1626B40 Offset: 0x1625F40 VA: 0x181626B40
	public static string GetPathRoot(string path) { }

	// RVA: 0x16272B0 Offset: 0x16266B0 VA: 0x1816272B0
	public static string GetTempFileName() { }

	// RVA: 0x1627630 Offset: 0x1626A30 VA: 0x181627630
	public static string GetTempPath() { }

	// RVA: 0x1629160 Offset: 0x1628560 VA: 0x181629160
	private static string get_temp_path() { }

	// RVA: 0x1628210 Offset: 0x1627610 VA: 0x181628210
	public static bool IsPathRooted(string path) { }

	// RVA: 0x1626A30 Offset: 0x1625E30 VA: 0x181626A30
	public static char[] GetInvalidFileNameChars() { }

	// RVA: 0x1626AD0 Offset: 0x1625ED0 VA: 0x181626AD0
	public static char[] GetInvalidPathChars() { }

	// RVA: 0x1628FC0 Offset: 0x16283C0 VA: 0x181628FC0
	private static int findExtension(string path) { }

	// RVA: 0x1628D20 Offset: 0x1628120 VA: 0x181628D20
	private static void .cctor() { }

	// RVA: 0x1627070 Offset: 0x1626470 VA: 0x181627070
	private static string GetServerAndShare(string path) { }

	// RVA: 0x16283E0 Offset: 0x16277E0 VA: 0x1816283E0
	private static bool SameRoot(string root, string path) { }

	// RVA: 0x16244C0 Offset: 0x16238C0 VA: 0x1816244C0
	private static string CanonicalizePath(string path) { }

	// RVA: 0x1625BF0 Offset: 0x1624FF0 VA: 0x181625BF0
	public static string Combine(string[] paths) { }

	// RVA: 0x16259B0 Offset: 0x1624DB0 VA: 0x1816259B0
	public static string Combine(string path1, string path2, string path3) { }

	// RVA: 0x1628710 Offset: 0x1627B10 VA: 0x181628710
	internal static void Validate(string path) { }

	// RVA: 0x16288E0 Offset: 0x1627CE0 VA: 0x1816288E0
	internal static void Validate(string path, string parameterName) { }

	// RVA: 0x1629060 Offset: 0x1628460 VA: 0x181629060
	internal static string get_DirectorySeparatorCharAsString() { }

	// RVA: 0x16290C0 Offset: 0x16284C0 VA: 0x1816290C0
	internal static char[] get_TrimEndChars() { }

	// RVA: 0x1625010 Offset: 0x1624410 VA: 0x181625010
	internal static void CheckSearchPattern(string searchPattern) { }

	// RVA: 0x1624F00 Offset: 0x1624300 VA: 0x181624F00
	internal static void CheckInvalidPathChars(string path, bool checkAdditional = False) { }

	// RVA: 0x1627E90 Offset: 0x1627290 VA: 0x181627E90
	internal static string InternalCombine(string path1, string path2) { }

}

