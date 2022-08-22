internal class DefaultWatcher : IFileWatcher // TypeDefIndex: 2841
{	private static DefaultWatcher instance; // 0x0
	private static Thread thread; // 0x8
	private static Hashtable watches; // 0x10
	private static string[] NoStringsArray; // 0x18


	private void .ctor() { }

	public static bool GetInstance(out IFileWatcher watcher) { }

	public void StartDispatching(FileSystemWatcher fsw) { }

	public void StopDispatching(FileSystemWatcher fsw) { }

	private void Monitor() { }

	private bool UpdateDataAndDispatch(DefaultWatcherData data, bool dispatch) { }

	private static void DispatchEvents(FileSystemWatcher fsw, FileAction action, string filename) { }

	private void DoFiles(DefaultWatcherData data, string directory, bool dispatch) { }

	private void IterateAndModifyFilesData(DefaultWatcherData data, string directory, bool dispatch, string[] files) { }

	private static FileData CreateFileData(string directory, string filename) { }

	private static void .cctor() { }

}

