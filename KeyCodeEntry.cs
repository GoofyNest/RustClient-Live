public class KeyCodeEntry : UIDialog // TypeDefIndex: 10894
{	// Fields
	public Text textDisplay; // 0x30
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

	// Methods

	// RVA: 0x6B5780 Offset: 0x6B4B80 VA: 0x1806B5780
	public void SetUsingGuestCode(bool should) { }

	// RVA: 0x6B5660 Offset: 0x6B4A60 VA: 0x1806B5660 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x4BF560 Offset: 0x4BE960 VA: 0x1804BF560
	public void Cancel() { }

	// RVA: 0x6B5260 Offset: 0x6B4660 VA: 0x1806B5260
	public void ClearCode() { }

	// RVA: 0x6B52D0 Offset: 0x6B46D0 VA: 0x1806B52D0
	private void DeleteCodeCharacter() { }

	// RVA: 0x6B57E0 Offset: 0x6B4BE0 VA: 0x1806B57E0
	public void Update() { }

	// RVA: 0x6B53B0 Offset: 0x6B47B0 VA: 0x1806B53B0
	public void EnterLastUsedNumber() { }

	[IteratorStateMachineAttribute] // RVA: 0x88170 Offset: 0x87570 VA: 0x180088170
	// RVA: 0x6B5710 Offset: 0x6B4B10 VA: 0x1806B5710
	private IEnumerator ProcessLastNumberInput() { }

	// RVA: 0x6B55E0 Offset: 0x6B49E0 VA: 0x1806B55E0
	public void EnterNumber(int i) { }

	// RVA: 0x6B5490 Offset: 0x6B4890 VA: 0x1806B5490
	private void EnterNumberInternal(int i, bool bypassTimeCheck = False) { }

	// RVA: 0x6B55F0 Offset: 0x6B49F0 VA: 0x1806B55F0
	public void Finished() { }

	// RVA: 0x4BE840 Offset: 0x4BDC40 VA: 0x1804BE840
	public void .ctor() { }

}

private sealed class KeyCodeEntry.<ProcessLastNumberInput>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10895
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public KeyCodeEntry <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

	// RVA: 0x6C5BA0 Offset: 0x6C4FA0 VA: 0x1806C5BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6C5D60 Offset: 0x6C5160 VA: 0x1806C5D60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

