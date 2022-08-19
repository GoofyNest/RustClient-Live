public class PhoneDialler : UIDialog // TypeDefIndex: 10896
{	// Fields
	public GameObject DialingRoot; // 0x30
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

	// Properties
	public bool IsContactsActive { get; }
	public float NormalisedAnsweringMessagePlayTime { get; }
	public bool IsPlayingAnsweringMessage { get; }

	// Methods

	// RVA: 0x951720 Offset: 0x950B20 VA: 0x180951720
	public bool get_IsContactsActive() { }

	// RVA: 0x9503C0 Offset: 0x94F7C0 VA: 0x1809503C0
	public void SetPhone(PhoneController t) { }

	// RVA: 0x950900 Offset: 0x94FD00 VA: 0x180950900
	public void Update() { }

	// RVA: 0x94ED10 Offset: 0x94E110 VA: 0x18094ED10
	public void EnterNumber(int i) { }

	// RVA: 0x9502C0 Offset: 0x94F6C0 VA: 0x1809502C0
	public void SetNumber(string number) { }

	// RVA: 0x94E920 Offset: 0x94DD20 VA: 0x18094E920
	public void ClearCode() { }

	// RVA: 0x94EC00 Offset: 0x94E000 VA: 0x18094EC00
	public void Dial() { }

	// RVA: 0x94F780 Offset: 0x94EB80 VA: 0x18094F780
	public void OnFail(Telephone.DialFailReason reason) { }

	// RVA: 0x94F8D0 Offset: 0x94ECD0 VA: 0x18094F8D0
	public void OnPhoneStateChanged(PhoneController c) { }

	// RVA: 0x94E8C0 Offset: 0x94DCC0 VA: 0x18094E8C0
	public void Answer() { }

	// RVA: 0x94F000 Offset: 0x94E400 VA: 0x18094F000
	public void HangUp() { }

	// RVA: 0x94E9D0 Offset: 0x94DDD0 VA: 0x18094E9D0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x94EE30 Offset: 0x94E230 VA: 0x18094EE30
	public void ForceClose() { }

	// RVA: 0x94EFA0 Offset: 0x94E3A0 VA: 0x18094EFA0
	public static string FormatPhoneNumber(string number) { }

	// RVA: 0x94F3B0 Offset: 0x94E7B0 VA: 0x18094F3B0
	public void OnClickedDirectory() { }

	// RVA: 0x94FCF0 Offset: 0x94F0F0 VA: 0x18094FCF0
	public void OnReceivedDirectory() { }

	// RVA: 0x94F250 Offset: 0x94E650 VA: 0x18094F250
	public void OnClickedContacts() { }

	// RVA: 0x94FF40 Offset: 0x94F340 VA: 0x18094FF40
	public void PopulateDirectory(PhoneDirectory directory, Transform forRoot, bool showDeleteOption) { }

	// RVA: 0x94F1B0 Offset: 0x94E5B0 VA: 0x18094F1B0
	public void OnClickedCallDirectoryEntry(string number) { }

	// RVA: 0x94F310 Offset: 0x94E710 VA: 0x18094F310
	public void OnClickedDeletePhoneNumber(string phoneNumber) { }

	// RVA: 0x94F840 Offset: 0x94EC40 VA: 0x18094F840
	public void OnNameInput(string newName) { }

	// RVA: 0x94F520 Offset: 0x94E920 VA: 0x18094F520
	public void OnClickedSaveNumber() { }

	// RVA: 0x9506C0 Offset: 0x94FAC0 VA: 0x1809506C0
	public void UpdateAddContactButton() { }

	// RVA: 0x94F030 Offset: 0x94E430 VA: 0x18094F030
	public void LoadDirectory(int direction) { }

	// RVA: 0x950780 Offset: 0x94FB80 VA: 0x180950780
	private void UpdateIncomingCallText(PhoneController c) { }

	[IteratorStateMachineAttribute] // RVA: 0x88BA0 Offset: 0x87FA0 VA: 0x180088BA0
	// RVA: 0x94FE40 Offset: 0x94F240 VA: 0x18094FE40
	private IEnumerator PlayInputBeepsForPhoneNumber(string number) { }

	// RVA: 0x94FBD0 Offset: 0x94EFD0 VA: 0x18094FBD0
	public void OnReceivedAnsweringMessage(float length, bool canLeaveVoicemail) { }

	// RVA: 0x94FE10 Offset: 0x94F210 VA: 0x18094FE10
	public void OnStartedRecordingVoicemail(float duration) { }

	// RVA: 0x94EE00 Offset: 0x94E200 VA: 0x18094EE00
	public void FinishVoicemailRecording() { }

	// RVA: 0x94FED0 Offset: 0x94F2D0 VA: 0x18094FED0
	public void PlayVoicemail(uint id) { }

	// RVA: 0x950660 Offset: 0x94FA60 VA: 0x180950660
	public void StopVoicemail() { }

	// RVA: 0x94EB90 Offset: 0x94DF90 VA: 0x18094EB90
	public void DeleteVoicemail(uint id) { }

	// RVA: 0x9517F0 Offset: 0x950BF0 VA: 0x1809517F0
	public float get_NormalisedAnsweringMessagePlayTime() { }

	// RVA: 0x951750 Offset: 0x950B50 VA: 0x180951750
	public bool get_IsPlayingAnsweringMessage() { }

	// RVA: 0x94F6A0 Offset: 0x94EAA0 VA: 0x18094F6A0
	public void OnClickedVoicemail() { }

	// RVA: 0x94EB60 Offset: 0x94DF60 VA: 0x18094EB60
	public void CopyCurrentNumberToClipboard() { }

	// RVA: 0x9516B0 Offset: 0x950AB0 VA: 0x1809516B0
	public void .ctor() { }

}

private sealed class PhoneDialler.<PlayInputBeepsForPhoneNumber>d__68 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10897
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PhoneDialler <>4__this; // 0x20
	public string number; // 0x28
	private int <i>5__2; // 0x30

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

	// RVA: 0x8E47F0 Offset: 0x8E3BF0 VA: 0x1808E47F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8E4A00 Offset: 0x8E3E00 VA: 0x1808E4A00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

