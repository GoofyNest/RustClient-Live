public class PhoneDialler : UIDialog // TypeDefIndex: 10896
{	public GameObject DialingRoot; // 0x30
	public GameObject CallInProcessRoot; // 0x38
	public GameObject IncomingCallRoot; // 0x40
	public RustText ThisPhoneNumber; // 0x48
	public RustInput PhoneNameInput; // 0x50
	public RustText textDisplay; // 0x58
	public RustText CallTimeText; // 0x60
	public RustButton DefaultDialViewButton; // 0x68
	public RustText[] IncomingCallNumber; // 0x70
	public GameObject NumberDialRoot; // 0x78
	public GameObject PromptVoicemailRoot; // 0x80
	public RustButton ContactsButton; // 0x88
	public RustText FailText; // 0x90
	public NeedsCursor CursorController; // 0x98
	public NeedsKeyboard KeyboardController; // 0xA0
	public Translate.Phrase WrongNumberPhrase; // 0xA8
	public Translate.Phrase NetworkBusy; // 0xB0
	public Translate.Phrase Engaged; // 0xB8
	public GameObjectRef DirectoryEntryPrefab; // 0xC0
	public Transform DirectoryRoot; // 0xC8
	public GameObject NoDirectoryRoot; // 0xD0
	public RustButton DirectoryPageUp; // 0xD8
	public RustButton DirectoryPageDown; // 0xE0
	public Transform ContactsRoot; // 0xE8
	public RustInput ContactsNameInput; // 0xF0
	public RustInput ContactsNumberInput; // 0xF8
	public GameObject NoContactsRoot; // 0x100
	public RustButton AddContactButton; // 0x108
	public SoundDefinition DialToneSfx; // 0x110
	public Button[] NumberButtons; // 0x118
	public Translate.Phrase AnsweringMachine; // 0x120
	public VoicemailDialog Voicemail; // 0x128
	public GameObject VoicemailRoot; // 0x130
	private PhoneController attachedPhone; // 0x138
	private Telephone.CallState lastState; // 0x140
	private List<GameObject> spawnedDirectoryEntries; // 0x148
	private int directoryPage; // 0x150
	private TimeSince lastKeyDelete; // 0x154
	private Sound dialTone; // 0x158
	private string textEntered; // 0x160
	private int lastEnteredFrame; // 0x168
	private bool inputtingNumber; // 0x16C

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

	[IteratorStateMachineAttribute] // RVA: 0x88BA0 Offset: 0x87FA0 VA: 0x180088BA0
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

private sealed class PhoneDialler.<PlayInputBeepsForPhoneNumber>d__68 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10897
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PhoneDialler <>4__this; // 0x20
	public string number; // 0x28
	private int <i>5__2; // 0x30

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

