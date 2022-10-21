public static class DirectoryEx // TypeDefIndex: 13095
{

	public static void Backup(DirectoryInfo parent, string[] names) { }

	[ExtensionAttribute] 
	public static bool MoveToSafe(DirectoryInfo parent, string target, int retries = 10) { }

	public static void Backup(string[] names) { }

	public static void CopyAll(string sourceDirectory, string targetDirectory) { }

	public static void CopyAll(DirectoryInfo source, DirectoryInfo target) { }

}

