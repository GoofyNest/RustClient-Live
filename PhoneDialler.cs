public class PhoneDialler : UIDialog // TypeDefIndex: 12615
{
	public GameObject DialingRoot; 
	public GameObject CallInProcessRoot; 
	public GameObject IncomingCallRoot; 
	public RustText ThisPhoneNumber; 
	public RustInput PhoneNameInput; 
	public RustText textDisplay; 
	public RustText CallTimeText; 
	public RustButton DefaultDialViewButton; 
	public RustText[] IncomingCallNumber; 
	public GameObject NumberDialRoot; 
	public GameObject PromptVoicemailRoot; 
	public RustButton ContactsButton; 
	public RustText FailText; 
	public NeedsCursor CursorController; 
	public NeedsKeyboard KeyboardController; 
	public Translate.Phrase WrongNumberPhrase; 
	public Translate.Phrase NetworkBusy; 
	public Translate.Phrase Engaged; 
	public GameObjectRef DirectoryEntryPrefab; 
	public Transform DirectoryRoot; 
	public GameObject NoDirectoryRoot; 
	public RustButton DirectoryPageUp; 
	public RustButton DirectoryPageDown; 
	public Transform ContactsRoot; 
	public RustInput ContactsNameInput; 
	public RustInput ContactsNumberInput; 
	public GameObject NoContactsRoot; 
	public RustButton AddContactButton; 
	public SoundDefinition DialToneSfx; 
	public Button[] NumberButtons; 
	public Translate.Phrase AnsweringMachine; 
	public VoicemailDialog Voicemail; 
	public GameObject VoicemailRoot; 
	private PhoneController attachedPhone; 
	private Telephone.CallState lastState; 
	private List<GameObject> spawnedDirectoryEntries; 
	private int directoryPage; 
	private TimeSince lastKeyDelete; 
	private Sound dialTone; 
	private string textEntered; 
	private int lastEnteredFrame; 
	private bool inputtingNumber; 

	public bool IsContactsActive { get; }
	public float NormalisedAnsweringMessagePlayTime { get; }
	public bool IsPlayingAnsweringMessage { get; }


	public bool get_IsContactsActive() { }

	public void SetPhone(PhoneController t) { }

	public void Update() { }

	public void EnterNumber(int i) { }

	public void SetNumber(string number) { }

	public void ClearCode() { }

	public void Dial() { }

	public void OnFail(Telephone.DialFailReason reason) { }

	public void OnPhoneStateChanged(PhoneController c) { }

	public void Answer() { }

	public void HangUp() { }

	public override void CloseDialog() { }

	public void ForceClose() { }

	public static string FormatPhoneNumber(string number) { }

	public void OnClickedDirectory() { }

	public void OnReceivedDirectory() { }

	public void OnClickedContacts() { }

	public void PopulateDirectory(PhoneDirectory directory, Transform forRoot, bool showDeleteOption) { }

	public void OnClickedCallDirectoryEntry(string number) { }

	public void OnClickedDeletePhoneNumber(string phoneNumber) { }

	public void OnNameInput(string newName) { }

	public void OnClickedSaveNumber() { }

	public void UpdateAddContactButton() { }

	public void LoadDirectory(int direction) { }

	private void UpdateIncomingCallText(PhoneController c) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator PlayInputBeepsForPhoneNumber(string number) { }

	public void OnReceivedAnsweringMessage(float length, bool canLeaveVoicemail) { }

	public void OnStartedRecordingVoicemail(float duration) { }

	public void FinishVoicemailRecording() { }

	public void PlayVoicemail(uint id) { }

	public void StopVoicemail() { }

	public void DeleteVoicemail(uint id) { }

	public float get_NormalisedAnsweringMessagePlayTime() { }

	public bool get_IsPlayingAnsweringMessage() { }

	public void OnClickedVoicemail() { }

	public void CopyCurrentNumberToClipboard() { }

	public void .ctor() { }

}

private sealed class PhoneDialler.<PlayInputBeepsForPhoneNumber>d__68 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12616
{
	private int <>1__state; 
	private object <>2__current; 
	public PhoneDialler <>4__this; 
	public string number; 
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

