public class TextureRow : MaterialRow // TypeDefIndex: 7759
{	// Fields
	private string Filename; // 0x20
	public bool IsNormalMap; // 0x28
	public RawImage TargetImage; // 0x30
	public Text FilenameLabel; // 0x38
	public Button Reset; // 0x40
	public Button Clear; // 0x48
	public bool HasChanges; // 0x50
	private Texture Default; // 0x58
	private FileSystemWatcher watcher; // 0x60

	// Properties
	public bool IsDefault { get; }
	public bool IsClear { get; }

	// Methods

	// RVA: 0xE8A000 Offset: 0xE89400 VA: 0x180E8A000
	public void Update() { }

	// RVA: 0xE89BE0 Offset: 0xE88FE0 VA: 0x180E89BE0
	public void SetFilenameText(string filename) { }

	// RVA: 0xE897F0 Offset: 0xE88BF0 VA: 0x180E897F0
	public void OnDisable() { }

	// RVA: 0xE89880 Offset: 0xE88C80 VA: 0x180E89880
	public void OpenFileBrowser() { }

	[IteratorStateMachineAttribute] // RVA: 0xD6250 Offset: 0xD5650 VA: 0x1800D6250
	// RVA: 0xE894F0 Offset: 0xE888F0 VA: 0x180E894F0
	public IEnumerator BrowseForTexture() { }

	// RVA: 0xE89680 Offset: 0xE88A80 VA: 0x180E89680
	public void Load(string fullname) { }

	// RVA: 0xE89C70 Offset: 0xE89070 VA: 0x180E89C70
	public void SetTexture(Texture tex) { }

	// RVA: 0xE8A250 Offset: 0xE89650 VA: 0x180E8A250
	public bool get_IsDefault() { }

	// RVA: 0xE8A1E0 Offset: 0xE895E0 VA: 0x180E8A1E0
	public bool get_IsClear() { }

	// RVA: 0xE89920 Offset: 0xE88D20 VA: 0x180E89920 Slot: 4
	public override void Read(Material source, Material def) { }

	// RVA: 0xE898F0 Offset: 0xE88CF0 VA: 0x180E898F0
	public void OpenFileLocation() { }

	// RVA: 0xE89B00 Offset: 0xE88F00 VA: 0x180E89B00
	public void SaveFile() { }

	[IteratorStateMachineAttribute] // RVA: 0xD6310 Offset: 0xD5710 VA: 0x1800D6310
	// RVA: 0xE89560 Offset: 0xE88960 VA: 0x180E89560
	private IEnumerator DoSaveFile() { }

	// RVA: 0xE89A60 Offset: 0xE88E60 VA: 0x180E89A60
	public void ResetToDefault() { }

	// RVA: 0xE899D0 Offset: 0xE88DD0 VA: 0x180E899D0
	public void ResetToClear() { }

	// RVA: 0xE89DC0 Offset: 0xE891C0 VA: 0x180E89DC0
	public void StartWatching() { }

	// RVA: 0xE895D0 Offset: 0xE889D0 VA: 0x180E895D0
	public void FileChanged(string name) { }

	// RVA: 0xE89F80 Offset: 0xE89380 VA: 0x180E89F80
	public void StopWatching() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE89FC0 Offset: 0xE893C0 VA: 0x180E89FC0
	private void <StartWatching>b__26_0(object a, FileSystemEventArgs e) { }

}

private sealed class TextureRow.<BrowseForTexture>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7760
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TextureRow <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE8A2D0 Offset: 0xE896D0 VA: 0x180E8A2D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE8A5E0 Offset: 0xE899E0 VA: 0x180E8A5E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class TextureRow.<DoSaveFile>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7761
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TextureRow <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE8C010 Offset: 0xE8B410 VA: 0x180E8C010 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE8C3A0 Offset: 0xE8B7A0 VA: 0x180E8C3A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

