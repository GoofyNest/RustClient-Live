public class GameTip : SingletonComponent<GameTip> // TypeDefIndex: 10940
{
	public CanvasGroup canvasGroup; 
	public RustIcon icon; 
	public Image background; 
	public RustText text; 
	public GameTip.Theme[] themes; 
	public static BaseTip[] Tips; 
	[ClientVar] 
	public static bool showgametips; 


	public void OnEnable() { }

	private void ClientConnected() { }

	public void Update() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator Think() { }

	private float GetStyleHoldDuration(int style) { }

	private void ApplyStyle(int style) { }

	[ClientVar] 
	public static void ShowGameTip(string text) { }

	[ClientVar] 
	public static void HideGameTip() { }

	[ClientVar] 
	public static void ShowToast(int style, string text) { }

	[ClientVar] 
	public static void ShowToast_Translated(int style, string key, string english) { }

	[ClientVar] 
	public static BaseTip[] ListGameTips() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct GameTip.Theme // TypeDefIndex: 10941
{
	public Icons Icon; 
	public Color BackgroundColor; 
	public Color ForegroundColor; 
	public float duration; 

}

private sealed class GameTip.<Think>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10942
{
	private int <>1__state; 
	private object <>2__current; 
	public GameTip <>4__this; 
	private BaseTip[] <>7__wrap1; 
	private int <>7__wrap2; 
	private BaseTip <tip>5__4; 

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

