public class MenuBackgroundVideo : SingletonComponent<MenuBackgroundVideo> // TypeDefIndex: 12857
{
	private string[] videos; 
	private int index; 
	private bool errored; 


	protected override void Awake() { }

	private void OnVideoError(VideoPlayer source, string message) { }

	public void LoadVideoList() { }

	public void Update() { }

	private void NextVideo() { }

	[IteratorStateMachineAttribute] 
	internal IEnumerator ReadyVideo() { }

	public void .ctor() { }

}

private sealed class MenuBackgroundVideo.<>c // TypeDefIndex: 12858
{
	public static readonly MenuBackgroundVideo.<>c <>9; 
	public static Func<string, bool> <>9__5_0; 
	public static Func<string, Guid> <>9__5_1; 
	public static Func<string, bool> <>9__7_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <LoadVideoList>b__5_0(string x) { }

	internal Guid <LoadVideoList>b__5_1(string x) { }

	internal bool <NextVideo>b__7_0(string x) { }

}

private sealed class MenuBackgroundVideo.<ReadyVideo>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12859
{
	private int <>1__state; 
	private object <>2__current; 
	public MenuBackgroundVideo <>4__this; 
	private VideoPlayer <player>5__2; 

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

