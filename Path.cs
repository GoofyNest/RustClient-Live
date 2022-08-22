public static class Path // TypeDefIndex: 678
{	[ObsoleteAttribute] // RVA: 0xA7E50 Offset: 0xA7250 VA: 0x1800A7E50
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

	internal static string DirectorySeparatorCharAsString { get; }
	internal static char[] TrimEndChars { get; }


	public static string ChangeExtension(string path, string extension) { }

	public static string Combine(string path1, string path2) { }

	internal static string CleanPath(string s) { }

	public static string GetDirectoryName(string path) { }

	public static string GetExtension(string path) { }

	public static string GetFileName(string path) { }

	public static string GetFileNameWithoutExtension(string path) { }

	public static string GetFullPath(string path) { }

	internal static string GetFullPathInternal(string path) { }

	private static extern int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull) { }

	internal static string GetFullPathName(string path) { }

	internal static string WindowsDriveAdjustment(string path) { }

	internal static string InsecureGetFullPath(string path) { }

	internal static bool IsDirectorySeparator(char c) { }

	public static string GetPathRoot(string path) { }

	public static string GetTempFileName() { }

	public static string GetTempPath() { }

	private static string get_temp_path() { }

	public static bool IsPathRooted(string path) { }

	public static char[] GetInvalidFileNameChars() { }

	public static char[] GetInvalidPathChars() { }

	private static int findExtension(string path) { }

	private static void .cctor() { }

	private static string GetServerAndShare(string path) { }

	private static bool SameRoot(string root, string path) { }

	private static string CanonicalizePath(string path) { }

	public static string Combine(string[] paths) { }

	public static string Combine(string path1, string path2, string path3) { }

	internal static void Validate(string path) { }

	internal static void Validate(string path, string parameterName) { }

	internal static string get_DirectorySeparatorCharAsString() { }

	internal static char[] get_TrimEndChars() { }

	internal static void CheckSearchPattern(string searchPattern) { }

	internal static void CheckInvalidPathChars(string path, bool checkAdditional = False) { }

	internal static string InternalCombine(string path1, string path2) { }

}

