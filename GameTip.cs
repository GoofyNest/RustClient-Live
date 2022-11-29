public class GameTip : SingletonComponent<GameTip> // TypeDefIndex: 12702
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
	public static void ShowToast_Translated(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static BaseTip[] ListGameTips() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum GameTip.Styles // TypeDefIndex: 12703
{
	public int value__; 
	public const GameTip.Styles Blue_Normal = 0;
	public const GameTip.Styles Red_Normal = 1;
	public const GameTip.Styles Blue_Long = 2;

}

public struct GameTip.Theme // TypeDefIndex: 12704
{
	public Icons Icon; 
	public Color BackgroundColor; 
	public Color ForegroundColor; 
	public float duration; 

}

private sealed class GameTip.<Think>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12705
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

