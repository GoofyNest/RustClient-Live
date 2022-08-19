public class GameTip : SingletonComponent<GameTip> // TypeDefIndex: 10940
{	// Fields
	public CanvasGroup canvasGroup; // 0x18
	public RustIcon icon; // 0x20
	public Image background; // 0x28
	public RustText text; // 0x30
	public GameTip.Theme[] themes; // 0x38
	public static BaseTip[] Tips; // 0x0
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool showgametips; // 0x8

	// Methods

	// RVA: 0x6F9FD0 Offset: 0x6F93D0 VA: 0x1806F9FD0
	public void OnEnable() { }

	// RVA: 0x6F9D60 Offset: 0x6F9160 VA: 0x1806F9D60
	private void ClientConnected() { }

	// RVA: 0x6FA510 Offset: 0x6F9910 VA: 0x1806FA510
	public void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x8C5E0 Offset: 0x8B9E0 VA: 0x18008C5E0
	// RVA: 0x6FA4A0 Offset: 0x6F98A0 VA: 0x1806FA4A0
	private IEnumerator Think() { }

	// RVA: 0x6F9E00 Offset: 0x6F9200 VA: 0x1806F9E00
	private float GetStyleHoldDuration(int style) { }

	// RVA: 0x6F9B50 Offset: 0x6F8F50 VA: 0x1806F9B50
	private void ApplyStyle(int style) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x6FA060 Offset: 0x6F9460 VA: 0x1806FA060
	public static void ShowGameTip(string text) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x6F9EB0 Offset: 0x6F92B0 VA: 0x1806F9EB0
	public static void HideGameTip() { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x6FA210 Offset: 0x6F9610 VA: 0x1806FA210
	public static void ShowToast(int style, string text) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x6FA170 Offset: 0x6F9570 VA: 0x1806FA170
	public static void ShowToast_Translated(int style, string key, string english) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6F9F70 Offset: 0x6F9370 VA: 0x1806F9F70
	public static BaseTip[] ListGameTips() { }

	// RVA: 0x6FBC70 Offset: 0x6FB070 VA: 0x1806FBC70
	public void .ctor() { }

	// RVA: 0x6FA560 Offset: 0x6F9960 VA: 0x1806FA560
	private static void .cctor() { }

}

public struct GameTip.Theme // TypeDefIndex: 10941
{	// Fields
	public Icons Icon; // 0x0
	public Color BackgroundColor; // 0x4
	public Color ForegroundColor; // 0x14
	public float duration; // 0x24

}

private sealed class GameTip.<Think>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10942
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GameTip <>4__this; // 0x20
	private BaseTip[] <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30
	private BaseTip <tip>5__4; // 0x38

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

	// RVA: 0x700A90 Offset: 0x6FFE90 VA: 0x180700A90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x700F90 Offset: 0x700390 VA: 0x180700F90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

