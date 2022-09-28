public class KeyCodeEntry : UIDialog // TypeDefIndex: 12573
{
	public Text textDisplay; 
	public Action<string> onCodeEntered; 
	public Text typeDisplay; 
	public Translate.Phrase masterCodePhrase; 
	public Translate.Phrase guestCodePhrase; 
	public GameObject memoryKeycodeButton; 
	private static string lastCodeEntered; 
	private string textEntered; 
	private TimeSince lastKeyDelete; 
	private bool isEnteringNumber; 
	private int lastEnteredFrame; 


	public void SetUsingGuestCode(bool should) { }

	protected override void OnEnable() { }

	public void Cancel() { }

	public void ClearCode() { }

	private void DeleteCodeCharacter() { }

	public void Update() { }

	public void EnterLastUsedNumber() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator ProcessLastNumberInput() { }

	public void EnterNumber(int i) { }

	private void EnterNumberInternal(int i, bool bypassTimeCheck = False) { }

	public void Finished() { }

	public void .ctor() { }

}

private sealed class KeyCodeEntry.<ProcessLastNumberInput>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12574
{
	private int <>1__state; 
	private object <>2__current; 
	public KeyCodeEntry <>4__this; 
	private int <i>5__2; 

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

