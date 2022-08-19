internal class DefaultWatcher : IFileWatcher // TypeDefIndex: 2841
{	// Fields
	private static DefaultWatcher instance; // 0x0
	private static Thread thread; // 0x8
	private static Hashtable watches; // 0x10
	private static string[] NoStringsArray; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0x1556740 Offset: 0x1555B40 VA: 0x181556740
	public static bool GetInstance(out IFileWatcher watcher) { }

	// RVA: 0x1557CF0 Offset: 0x15570F0 VA: 0x181557CF0 Slot: 4
	public void StartDispatching(FileSystemWatcher fsw) { }

	// RVA: 0x15584D0 Offset: 0x15578D0 VA: 0x1815584D0 Slot: 5
	public void StopDispatching(FileSystemWatcher fsw) { }

	// RVA: 0x15574C0 Offset: 0x15568C0 VA: 0x1815574C0
	private void Monitor() { }

	// RVA: 0x1558790 Offset: 0x1557B90 VA: 0x181558790
	private bool UpdateDataAndDispatch(DefaultWatcherData data, bool dispatch) { }

	// RVA: 0x15563C0 Offset: 0x15557C0 VA: 0x1815563C0
	private static void DispatchEvents(FileSystemWatcher fsw, FileAction action, string filename) { }

	// RVA: 0x15564C0 Offset: 0x15558C0 VA: 0x1815564C0
	private void DoFiles(DefaultWatcherData data, string directory, bool dispatch) { }

	// RVA: 0x1556850 Offset: 0x1555C50 VA: 0x181556850
	private void IterateAndModifyFilesData(DefaultWatcherData data, string directory, bool dispatch, string[] files) { }

	// RVA: 0x15562F0 Offset: 0x15556F0 VA: 0x1815562F0
	private static FileData CreateFileData(string directory, string filename) { }

	// RVA: 0x15588B0 Offset: 0x1557CB0 VA: 0x1815588B0
	private static void .cctor() { }

}

