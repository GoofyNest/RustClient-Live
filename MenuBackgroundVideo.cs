public class MenuBackgroundVideo : SingletonComponent<MenuBackgroundVideo> // TypeDefIndex: 11121
{	private string[] videos; // 0x18
	private int index; // 0x20
	private bool errored; // 0x24


	protected override void Awake() { }

	private void OnVideoError(VideoPlayer source, string message) { }

	public void LoadVideoList() { }

	public void Update() { }

	private void NextVideo() { }

	[IteratorStateMachineAttribute] // RVA: 0x98330 Offset: 0x97730 VA: 0x180098330
	internal IEnumerator ReadyVideo() { }

	public void .ctor() { }

}

private sealed class MenuBackgroundVideo.<>c // TypeDefIndex: 11122
{	public static readonly MenuBackgroundVideo.<>c <>9; // 0x0
	public static Func<string, bool> <>9__5_0; // 0x8
	public static Func<string, Guid> <>9__5_1; // 0x10
	public static Func<string, bool> <>9__7_0; // 0x18


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <LoadVideoList>b__5_0(string x) { }

	internal Guid <LoadVideoList>b__5_1(string x) { }

	internal bool <NextVideo>b__7_0(string x) { }

}

private sealed class MenuBackgroundVideo.<ReadyVideo>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11123
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MenuBackgroundVideo <>4__this; // 0x20
	private VideoPlayer <player>5__2; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

