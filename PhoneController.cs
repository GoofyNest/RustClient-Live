public class PhoneController : EntityComponent<BaseEntity> // TypeDefIndex: 9450
{	public int PhoneNumber; // 0x20
	public string PhoneName; // 0x28
	public bool CanModifyPhoneName; // 0x30
	public bool CanSaveNumbers; // 0x31
	public bool RequirePower; // 0x32
	public bool RequireParent; // 0x33
	public float CallWaitingTime; // 0x34
	public bool AppendGridToName; // 0x38
	public bool IsMobile; // 0x39
	public bool CanSaveVoicemail; // 0x3A
	public GameObjectRef PhoneDialog; // 0x40
	public VoiceProcessor VProcessor; // 0x48
	public PreloadedCassetteContent PreloadedContent; // 0x50
	public SoundDefinition DialToneSfx; // 0x58
	public SoundDefinition RingingSfx; // 0x60
	public SoundDefinition ErrorSfx; // 0x68
	public SoundDefinition CallIncomingWhileBusySfx; // 0x70
	public SoundDefinition PickupHandsetSfx; // 0x78
	public SoundDefinition PutDownHandsetSfx; // 0x80
	public SoundDefinition FailedWrongNumber; // 0x88
	public SoundDefinition FailedNoAnswer; // 0x90
	public SoundDefinition FailedNetworkBusy; // 0x98
	public SoundDefinition FailedEngaged; // 0xA0
	public SoundDefinition FailedRemoteHangUp; // 0xA8
	public SoundDefinition FailedSelfHangUp; // 0xB0
	public Light RingingLight; // 0xB8
	public float RingingLightFrequency; // 0xC0
	public AudioSource answeringMachineSound; // 0xC8
	public EntityRef currentPlayerRef; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <lastDialedNumber>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PhoneDirectory <savedNumbers>k__BackingField; // 0xE8
	public List<VoicemailEntry> savedVoicemail; // 0xF0
	private SoundDefinition currentlyLoadedPreloadedContent; // 0xF8
	private string connectedPlayerId; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Telephone.CallState <clientCallState>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PhoneDialler <CurrentDialog>k__BackingField; // 0x110
	private float callStartTime; // 0x118
	private Sound ringingSound; // 0x120
	private Sound dialingSound; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PhoneDirectory <currentDirectory>k__BackingField; // 0x130
	private TimeSince lastDirectoryUpdate; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ConnectedCallPhoneNumber>k__BackingField; // 0x13C
	private int voicemailTarget; // 0x140
	private OggEncoder currentEncoder; // 0x148
	private AudioInterceptComponent activeIntercept; // 0x150
	private int requestedDialNumber; // 0x158
	private bool cachedCanLeaveVoicemail; // 0x15C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TimeSince <AnsweringMessageStartTime>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <AnsweringMachineMessageLength>k__BackingField; // 0x164

	public int MaxVoicemailSlots { get; }
	public BasePlayer currentPlayer { get; set; }
	private bool isServer { get; }
	public int lastDialedNumber { get; set; }
	public PhoneDirectory savedNumbers { get; set; }
	public BaseEntity ParentEntity { get; }
	private Cassette cachedCassette { get; }
	public Telephone.CallState clientCallState { get; set; }
	public PhoneDialler CurrentDialog { get; set; }
	public float CallDuration { get; }
	public PhoneDirectory currentDirectory { get; set; }
	public int ConnectedCallPhoneNumber { get; set; }
	public TimeSince AnsweringMessageStartTime { get; set; }
	public float AnsweringMachineMessageLength { get; set; }
	public bool IsDead { get; }


	public void PlayVoicemail(uint id) { }

	public void StopVoicemail() { }

	public void DeleteVoicemail(uint id) { }

	public void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	public int get_MaxVoicemailSlots() { }

	public BasePlayer get_currentPlayer() { }

	public void set_currentPlayer(BasePlayer value) { }

	private bool get_isServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_lastDialedNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_lastDialedNumber(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PhoneDirectory get_savedNumbers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_savedNumbers(PhoneDirectory value) { }

	public BaseEntity get_ParentEntity() { }

	private Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Telephone.CallState get_clientCallState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_clientCallState(Telephone.CallState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PhoneDialler get_CurrentDialog() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_CurrentDialog(PhoneDialler value) { }

	public float get_CallDuration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PhoneDirectory get_currentDirectory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_currentDirectory(PhoneDirectory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_ConnectedCallPhoneNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_ConnectedCallPhoneNumber(int value) { }

	public void OpenDialler(BasePlayer player) { }

	public void AnswerPhone(BasePlayer player) { }

	public void AnswerViaUI() { }

	public void OnClosedDialler(BasePlayer player) { }

	public void OnLocalPlayerCancelled() { }

	public void UpdatePhoneNumber(BaseEntity.RPCMessage msg) { }

	public void SetClientState(BaseEntity.RPCMessage msg) { }

	private void ToggleRingingLight() { }

	public void ControllerLateUpdate() { }

	public void DialNumber(int number) { }

	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	public void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg, Cassette cachedCassette) { }

	public void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public TimeSince get_AnsweringMessageStartTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_AnsweringMessageStartTime(TimeSince value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_AnsweringMachineMessageLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_AnsweringMachineMessageLength(float value) { }

	private void PlayAnsweringMessage(AudioClip clip, bool canLeaveVoicemail) { }

	public void InitiateVoicemailRecord() { }

	public void FinishVoicemailRecording() { }

	public void ClientHangUp() { }

	public void OnIncomingCallDuringCall() { }

	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	public void SubmitNewName(string newName) { }

	public bool RequestPhoneDirectory(int page) { }

	public void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	public void Client_AddSavedNumber(uint number, string savedPhoneName) { }

	public void Client_RemoveSavedNumber(uint number) { }

	public void OnClientLoaded() { }

	public bool get_IsDead() { }

	private bool IsPowered() { }

	public bool IsSavedContactValid(string contactName, int contactNumber) { }

	public void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <ClientToggleVoicemail>b__3_0(AudioClip clip, bool success) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <ClientReceiveAnsweringData>b__93_0(AudioClip clip, bool success) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <ClientPlayAnsweringMessage>b__94_0(AudioClip clip, bool success) { }

}

