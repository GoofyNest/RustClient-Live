public class GameTip : SingletonComponent<GameTip> // TypeDefIndex: 12716
{
	public CanvasGroup canvasGroup;
	public RustIcon icon;
	public Image background;
	public RustText text;
	public GameTip.Theme[] themes;
	[ClientVar]
	public static bool Server_Event_Tips;
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

public enum GameTip.Styles // TypeDefIndex: 12717
{
	public int value__;
	public const GameTip.Styles Blue_Normal = 0;
	public const GameTip.Styles Red_Normal = 1;
	public const GameTip.Styles Blue_Long = 2;
	public const GameTip.Styles Blue_Short = 3;
	public const GameTip.Styles Server_Event = 4;

}

public struct GameTip.Theme // TypeDefIndex: 12718
{
	public Icons Icon;
	public Color BackgroundColor;
	public Color ForegroundColor;
	public float duration;

}

private sealed class GameTip.<Think>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12719
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

