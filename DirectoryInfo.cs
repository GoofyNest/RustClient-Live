public sealed class DirectoryInfo : FileSystemInfo // TypeDefIndex: 661
{
	private string current; 
	private string parent; 

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

	[IteratorStateMachineAttribute] 
private IEnumerable<FileInfo> CreateEnumerateFilesIterator(string searchPattern, SearchOption searchOption) { }

internal void CheckPath(string path) { }

}

private sealed class DirectoryInfo.<CreateEnumerateFilesIterator>d__43 : IEnumerable<FileInfo>, IEnumerable, IEnumerator<FileInfo>, IDisposable, IEnumerator // TypeDefIndex: 662
{
	private int <>1__state; 
	private FileInfo <>2__current; 
	private int <>l__initialThreadId; 
	public DirectoryInfo <>4__this; 
	private string searchPattern; 
	public string <>3__searchPattern; 
	private SearchOption searchOption; 
	public SearchOption <>3__searchOption; 
	private IEnumerator<string> <>7__wrap1; 

private FileInfo System.Collections.Generic.IEnumerator<System.IO.FileInfo>.Current { get; }
private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
private void System.IDisposable.Dispose() { }

private bool MoveNext() { }

private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] 
private FileInfo System.Collections.Generic.IEnumerator<System.IO.FileInfo>.get_Current() { }

	[DebuggerHiddenAttribute] 
private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] 
private IEnumerator<FileInfo> System.Collections.Generic.IEnumerable<System.IO.FileInfo>.GetEnumerator() { }

	[DebuggerHiddenAttribute] 
private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

