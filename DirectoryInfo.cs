public sealed class DirectoryInfo : FileSystemInfo // TypeDefIndex: 661
{	private string current; // 0x60
	private string parent; // 0x68

	public override bool Exists { get; }
	public override string Name { get; }
	public DirectoryInfo Parent { get; }


	public void .ctor(string path) { }

	internal void .ctor(string path, bool simpleOriginalPath) { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	private void Initialize() { }

	public override bool get_Exists() { }

	public override string get_Name() { }

	public DirectoryInfo get_Parent() { }

	public void Create() { }

	public DirectoryInfo CreateSubdirectory(string path) { }

	public FileInfo[] GetFiles() { }

	public FileInfo[] GetFiles(string searchPattern) { }

	public DirectoryInfo[] GetDirectories() { }

	public DirectoryInfo[] GetDirectories(string searchPattern) { }

	public override void Delete() { }

	public void Delete(bool recursive) { }

	public void MoveTo(string destDirName) { }

	public override string ToString() { }

	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption) { }

	[IteratorStateMachineAttribute] // RVA: 0xA57E0 Offset: 0xA4BE0 VA: 0x1800A57E0
	private IEnumerable<FileInfo> CreateEnumerateFilesIterator(string searchPattern, SearchOption searchOption) { }

	internal void CheckPath(string path) { }

}

private sealed class DirectoryInfo.<CreateEnumerateFilesIterator>d__43 : IEnumerable<FileInfo>, IEnumerable, IEnumerator<FileInfo>, IDisposable, IEnumerator // TypeDefIndex: 662
{	private int <>1__state; // 0x10
	private FileInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public DirectoryInfo <>4__this; // 0x28
	private string searchPattern; // 0x30
	public string <>3__searchPattern; // 0x38
	private SearchOption searchOption; // 0x40
	public SearchOption <>3__searchOption; // 0x44
	private IEnumerator<string> <>7__wrap1; // 0x48

	private FileInfo System.Collections.Generic.IEnumerator<System.IO.FileInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private FileInfo System.Collections.Generic.IEnumerator<System.IO.FileInfo>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator<FileInfo> System.Collections.Generic.IEnumerable<System.IO.FileInfo>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

