public class TextureRow : MaterialRow // TypeDefIndex: 7759
{
	private string Filename; 
	public bool IsNormalMap; 
	public RawImage TargetImage; 
	public Text FilenameLabel; 
	public Button Reset; 
	public Button Clear; 
	public bool HasChanges; 
	private Texture Default; 
	private FileSystemWatcher watcher; 

	public bool IsDefault { get; }
	public bool IsClear { get; }


	public void Update() { }

	public void SetFilenameText(string filename) { }

	public void OnDisable() { }

	public void OpenFileBrowser() { }

	[IteratorStateMachineAttribute] 
	public IEnumerator BrowseForTexture() { }

	public void Load(string fullname) { }

	public void SetTexture(Texture tex) { }

	public bool get_IsDefault() { }

	public bool get_IsClear() { }

	public override void Read(Material source, Material def) { }

	public void OpenFileLocation() { }

	public void SaveFile() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator DoSaveFile() { }

	public void ResetToDefault() { }

	public void ResetToClear() { }

	public void StartWatching() { }

	public void FileChanged(string name) { }

	public void StopWatching() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private void <StartWatching>b__26_0(object a, FileSystemEventArgs e) { }

}

private sealed class TextureRow.<BrowseForTexture>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7760
{
	private int <>1__state; 
	private object <>2__current; 
	public TextureRow <>4__this; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class TextureRow.<DoSaveFile>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7761
{
	private int <>1__state; 
	private object <>2__current; 
	public TextureRow <>4__this; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

