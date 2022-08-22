public class KeyCodeEntry : UIDialog // TypeDefIndex: 10894
{	public Text textDisplay; // 0x30
	public Action<string> onCodeEntered; // 0x38
	public Text typeDisplay; // 0x40
	public Translate.Phrase masterCodePhrase; // 0x48
	public Translate.Phrase guestCodePhrase; // 0x50
	public GameObject memoryKeycodeButton; // 0x58
	private static string lastCodeEntered; // 0x0
	private string textEntered; // 0x60
	private TimeSince lastKeyDelete; // 0x68
	private bool isEnteringNumber; // 0x6C
	private int lastEnteredFrame; // 0x70


	public void SetUsingGuestCode(bool should) { }

	protected override void OnEnable() { }

	public void Cancel() { }

	public void ClearCode() { }

	private void DeleteCodeCharacter() { }

	public void Update() { }

	public void EnterLastUsedNumber() { }

	[IteratorStateMachineAttribute] // RVA: 0x88170 Offset: 0x87570 VA: 0x180088170
	private IEnumerator ProcessLastNumberInput() { }

	public void EnterNumber(int i) { }

	private void EnterNumberInternal(int i, bool bypassTimeCheck = False) { }

	public void Finished() { }

	public void .ctor() { }

}

private sealed class KeyCodeEntry.<ProcessLastNumberInput>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10895
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public KeyCodeEntry <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

