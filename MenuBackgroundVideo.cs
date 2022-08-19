public class MenuBackgroundVideo : SingletonComponent<MenuBackgroundVideo> // TypeDefIndex: 11121
{	// Fields
	private string[] videos; // 0x18
	private int index; // 0x20
	private bool errored; // 0x24

	// Methods

	// RVA: 0x959520 Offset: 0x958920 VA: 0x180959520 Slot: 6
	protected override void Awake() { }

	// RVA: 0x959A30 Offset: 0x958E30 VA: 0x180959A30
	private void OnVideoError(VideoPlayer source, string message) { }

	// RVA: 0x9595D0 Offset: 0x9589D0 VA: 0x1809595D0
	public void LoadVideoList() { }

	// RVA: 0x959AB0 Offset: 0x958EB0 VA: 0x180959AB0
	public void Update() { }

	// RVA: 0x9597E0 Offset: 0x958BE0 VA: 0x1809597E0
	private void NextVideo() { }

	[IteratorStateMachineAttribute] // RVA: 0x98330 Offset: 0x97730 VA: 0x180098330
	// RVA: 0x959A40 Offset: 0x958E40 VA: 0x180959A40
	internal IEnumerator ReadyVideo() { }

	// RVA: 0x959B00 Offset: 0x958F00 VA: 0x180959B00
	public void .ctor() { }

}

private sealed class MenuBackgroundVideo.<>c // TypeDefIndex: 11122
{	// Fields
	public static readonly MenuBackgroundVideo.<>c <>9; // 0x0
	public static Func<string, bool> <>9__5_0; // 0x8
	public static Func<string, Guid> <>9__5_1; // 0x10
	public static Func<string, bool> <>9__7_0; // 0x18

	// Methods

	// RVA: 0x96C3F0 Offset: 0x96B7F0 VA: 0x18096C3F0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x96C270 Offset: 0x96B670 VA: 0x18096C270
	internal bool <LoadVideoList>b__5_0(string x) { }

	// RVA: 0x96C2E0 Offset: 0x96B6E0 VA: 0x18096C2E0
	internal Guid <LoadVideoList>b__5_1(string x) { }

	// RVA: 0x96C340 Offset: 0x96B740 VA: 0x18096C340
	internal bool <NextVideo>b__7_0(string x) { }

}

private sealed class MenuBackgroundVideo.<ReadyVideo>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11123
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MenuBackgroundVideo <>4__this; // 0x20
	private VideoPlayer <player>5__2; // 0x28

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

	// RVA: 0x96C130 Offset: 0x96B530 VA: 0x18096C130 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x96C200 Offset: 0x96B600 VA: 0x18096C200 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

