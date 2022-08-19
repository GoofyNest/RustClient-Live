public static class Directory // TypeDefIndex: 618
{	// Methods

	// RVA: 0x1375CC0 Offset: 0x13750C0 VA: 0x181375CC0
	public static string[] GetFiles(string path) { }

	// RVA: 0x1375AC0 Offset: 0x1374EC0 VA: 0x181375AC0
	public static string[] GetFiles(string path, string searchPattern) { }

	// RVA: 0x1375B90 Offset: 0x1374F90 VA: 0x181375B90
	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1375F60 Offset: 0x1375360 VA: 0x181375F60
	private static string[] InternalGetFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1375960 Offset: 0x1374D60 VA: 0x181375960
	public static string[] GetDirectories(string path) { }

	// RVA: 0x1375890 Offset: 0x1374C90 VA: 0x181375890
	public static string[] GetDirectories(string path, string searchPattern) { }

	// RVA: 0x1375E30 Offset: 0x1375230 VA: 0x181375E30
	private static string[] InternalGetDirectories(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x13759F0 Offset: 0x1374DF0 VA: 0x1813759F0
	public static string[] GetFileSystemEntries(string path, string searchPattern) { }

	// RVA: 0x1375F30 Offset: 0x1375330 VA: 0x181375F30
	private static string[] InternalGetFileSystemEntries(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1375E60 Offset: 0x1375260 VA: 0x181375E60
	internal static string[] InternalGetFileDirectoryNames(string path, string userPathOriginal, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost) { }

	// RVA: 0x13754A0 Offset: 0x13748A0 VA: 0x1813754A0
	public static IEnumerable<string> EnumerateFiles(string path) { }

	// RVA: 0x1375370 Offset: 0x1374770 VA: 0x181375370
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1375E00 Offset: 0x1375200 VA: 0x181375E00
	private static IEnumerable<string> InternalEnumerateFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1375340 Offset: 0x1374740 VA: 0x181375340
	private static IEnumerable<string> EnumerateFileSystemNames(string path, string searchPattern, SearchOption searchOption, bool includeFiles, bool includeDirs) { }

	// RVA: 0x1374E70 Offset: 0x1374270 VA: 0x181374E70
	public static DirectoryInfo CreateDirectory(string path) { }

	// RVA: 0x1374CC0 Offset: 0x13740C0 VA: 0x181374CC0
	private static DirectoryInfo CreateDirectoriesInternal(string path) { }

	// RVA: 0x13750A0 Offset: 0x13744A0 VA: 0x1813750A0
	public static void Delete(string path) { }

	// RVA: 0x1376310 Offset: 0x1375710 VA: 0x181376310
	private static void RecursiveDelete(string path) { }

	// RVA: 0x13752B0 Offset: 0x13746B0 VA: 0x1813752B0
	public static void Delete(string path, bool recursive) { }

	// RVA: 0x1375530 Offset: 0x1374930 VA: 0x181375530
	public static bool Exists(string path) { }

	// RVA: 0x13755F0 Offset: 0x13749F0 VA: 0x1813755F0
	public static string GetCurrentDirectory() { }

	// RVA: 0x1375D60 Offset: 0x1375160 VA: 0x181375D60
	internal static string InsecureGetCurrentDirectory() { }

	// RVA: 0x1375D50 Offset: 0x1375150 VA: 0x181375D50
	public static string[] GetLogicalDrives() { }

	// RVA: 0x1375F90 Offset: 0x1375390 VA: 0x181375F90
	public static void Move(string sourceDirName, string destDirName) { }

	// RVA: 0x1376560 Offset: 0x1375960 VA: 0x181376560
	public static void SetCreationTime(string path, DateTime creationTime) { }

	// RVA: 0x1376530 Offset: 0x1375930 VA: 0x181376530
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc) { }

	// RVA: 0x13765A0 Offset: 0x13759A0 VA: 0x1813765A0
	public static void SetLastAccessTime(string path, DateTime lastAccessTime) { }

	// RVA: 0x1376570 Offset: 0x1375970 VA: 0x181376570
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) { }

	// RVA: 0x13765E0 Offset: 0x13759E0 VA: 0x1813765E0
	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	// RVA: 0x13765B0 Offset: 0x13759B0 VA: 0x1813765B0
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) { }

	// RVA: 0x1375690 Offset: 0x1374A90 VA: 0x181375690
	internal static string GetDemandDir(string fullPath, bool thisDirOnly) { }

}

internal sealed class Directory.SearchData // TypeDefIndex: 619
{	// Fields
	public readonly string fullPath; // 0x10
	public readonly string userPath; // 0x18
	public readonly SearchOption searchOption; // 0x20

	// Methods

	// RVA: 0x1380A40 Offset: 0x137FE40 VA: 0x181380A40
	public void .ctor(string fullPath, string userPath, SearchOption searchOption) { }

}

