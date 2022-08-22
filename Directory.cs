public static class Directory // TypeDefIndex: 618
{
	public static string[] GetFiles(string path) { }

	public static string[] GetFiles(string path, string searchPattern) { }

	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption) { }

	private static string[] InternalGetFiles(string path, string searchPattern, SearchOption searchOption) { }

	public static string[] GetDirectories(string path) { }

	public static string[] GetDirectories(string path, string searchPattern) { }

	private static string[] InternalGetDirectories(string path, string searchPattern, SearchOption searchOption) { }

	public static string[] GetFileSystemEntries(string path, string searchPattern) { }

	private static string[] InternalGetFileSystemEntries(string path, string searchPattern, SearchOption searchOption) { }

	internal static string[] InternalGetFileDirectoryNames(string path, string userPathOriginal, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost) { }

	public static IEnumerable<string> EnumerateFiles(string path) { }

	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption) { }

	private static IEnumerable<string> InternalEnumerateFiles(string path, string searchPattern, SearchOption searchOption) { }

	private static IEnumerable<string> EnumerateFileSystemNames(string path, string searchPattern, SearchOption searchOption, bool includeFiles, bool includeDirs) { }

	public static DirectoryInfo CreateDirectory(string path) { }

	private static DirectoryInfo CreateDirectoriesInternal(string path) { }

	public static void Delete(string path) { }

	private static void RecursiveDelete(string path) { }

	public static void Delete(string path, bool recursive) { }

	public static bool Exists(string path) { }

	public static string GetCurrentDirectory() { }

	internal static string InsecureGetCurrentDirectory() { }

	public static string[] GetLogicalDrives() { }

	public static void Move(string sourceDirName, string destDirName) { }

	public static void SetCreationTime(string path, DateTime creationTime) { }

	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc) { }

	public static void SetLastAccessTime(string path, DateTime lastAccessTime) { }

	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) { }

	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) { }

	internal static string GetDemandDir(string fullPath, bool thisDirOnly) { }

}

internal sealed class Directory.SearchData // TypeDefIndex: 619
{	public readonly string fullPath; // 0x10
	public readonly string userPath; // 0x18
	public readonly SearchOption searchOption; // 0x20


	public void .ctor(string fullPath, string userPath, SearchOption searchOption) { }

}

