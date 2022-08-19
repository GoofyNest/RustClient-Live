public sealed class DirectoryInfo : FileSystemInfo // TypeDefIndex: 661
{	// Fields
	private string current; // 0x60
	private string parent; // 0x68

	// Properties
	public override bool Exists { get; }
	public override string Name { get; }
	public DirectoryInfo Parent { get; }

	// Methods

	// RVA: 0x1374A40 Offset: 0x1373E40 VA: 0x181374A40
	public void .ctor(string path) { }

	// RVA: 0x1374A80 Offset: 0x1373E80 VA: 0x181374A80
	internal void .ctor(string path, bool simpleOriginalPath) { }

	// RVA: 0x1374A50 Offset: 0x1373E50 VA: 0x181374A50
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1374660 Offset: 0x1373A60 VA: 0x181374660
	private void Initialize() { }

	// RVA: 0x1374B80 Offset: 0x1373F80 VA: 0x181374B80 Slot: 9
	public override bool get_Exists() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1374BC0 Offset: 0x1373FC0 VA: 0x181374BC0
	public DirectoryInfo get_Parent() { }

	// RVA: 0x1373F40 Offset: 0x1373340 VA: 0x181373F40
	public void Create() { }

	// RVA: 0x1373E90 Offset: 0x1373290 VA: 0x181373E90
	public DirectoryInfo CreateSubdirectory(string path) { }

	// RVA: 0x1374410 Offset: 0x1373810 VA: 0x181374410
	public FileInfo[] GetFiles() { }

	// RVA: 0x1374450 Offset: 0x1373850 VA: 0x181374450
	public FileInfo[] GetFiles(string searchPattern) { }

	// RVA: 0x1374140 Offset: 0x1373540 VA: 0x181374140
	public DirectoryInfo[] GetDirectories() { }

	// RVA: 0x1374180 Offset: 0x1373580 VA: 0x181374180
	public DirectoryInfo[] GetDirectories(string searchPattern) { }

	// RVA: 0x1373FE0 Offset: 0x13733E0 VA: 0x181373FE0 Slot: 10
	public override void Delete() { }

	// RVA: 0x1373F50 Offset: 0x1373350 VA: 0x181373F50
	public void Delete(bool recursive) { }

	// RVA: 0x1374910 Offset: 0x1373D10 VA: 0x181374910
	public void MoveTo(string destDirName) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 3
	public override string ToString() { }

	// RVA: 0x1374050 Offset: 0x1373450 VA: 0x181374050
	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption) { }

	[IteratorStateMachineAttribute] // RVA: 0xA57E0 Offset: 0xA4BE0 VA: 0x1800A57E0
	// RVA: 0x1373DF0 Offset: 0x13731F0 VA: 0x181373DF0
	private IEnumerable<FileInfo> CreateEnumerateFilesIterator(string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1373C80 Offset: 0x1373080 VA: 0x181373C80
	internal void CheckPath(string path) { }

}

private sealed class DirectoryInfo.<CreateEnumerateFilesIterator>d__43 : IEnumerable<FileInfo>, IEnumerable, IEnumerator<FileInfo>, IDisposable, IEnumerator // TypeDefIndex: 662
{	// Fields
	private int <>1__state; // 0x10
	private FileInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public DirectoryInfo <>4__this; // 0x28
	private string searchPattern; // 0x30
	public string <>3__searchPattern; // 0x38
	private SearchOption searchOption; // 0x40
	public SearchOption <>3__searchOption; // 0x44
	private IEnumerator<string> <>7__wrap1; // 0x48

	// Properties
	private FileInfo System.Collections.Generic.IEnumerator<System.IO.FileInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x138C500 Offset: 0x138B900 VA: 0x18138C500 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x138C000 Offset: 0x138B400 VA: 0x18138C000 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x138C5B0 Offset: 0x138B9B0 VA: 0x18138C5B0
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private FileInfo System.Collections.Generic.IEnumerator<System.IO.FileInfo>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x138C4B0 Offset: 0x138B8B0 VA: 0x18138C4B0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x138C3F0 Offset: 0x138B7F0 VA: 0x18138C3F0 Slot: 4
	private IEnumerator<FileInfo> System.Collections.Generic.IEnumerable<System.IO.FileInfo>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x138C3F0 Offset: 0x138B7F0 VA: 0x18138C3F0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

