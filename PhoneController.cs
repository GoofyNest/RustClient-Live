public class PhoneController : EntityComponent<BaseEntity> // TypeDefIndex: 9450
{	// Fields
	public int PhoneNumber; // 0x20
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

	// Properties
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

	// Methods

	// RVA: 0x94D7A0 Offset: 0x94CBA0 VA: 0x18094D7A0
	public void PlayVoicemail(uint id) { }

	// RVA: 0x94DFB0 Offset: 0x94D3B0 VA: 0x18094DFB0
	public void StopVoicemail() { }

	// RVA: 0x94C7B0 Offset: 0x94BBB0 VA: 0x18094C7B0
	public void DeleteVoicemail(uint id) { }

	// RVA: 0x94C420 Offset: 0x94B820 VA: 0x18094C420
	public void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	// RVA: 0x94E520 Offset: 0x94D920 VA: 0x18094E520
	public int get_MaxVoicemailSlots() { }

	// RVA: 0x94E6F0 Offset: 0x94DAF0 VA: 0x18094E6F0
	public BasePlayer get_currentPlayer() { }

	// RVA: 0x94E890 Offset: 0x94DC90 VA: 0x18094E890
	public void set_currentPlayer(BasePlayer value) { }

	// RVA: 0x94E770 Offset: 0x94DB70 VA: 0x18094E770
	private bool get_isServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E820 Offset: 0x94DC20 VA: 0x18094E820
	public int get_lastDialedNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E8A0 Offset: 0x94DCA0 VA: 0x18094E8A0
	public void set_lastDialedNumber(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E830 Offset: 0x94DC30 VA: 0x18094E830
	public PhoneDirectory get_savedNumbers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E8B0 Offset: 0x94DCB0 VA: 0x18094E8B0
	public void set_savedNumbers(PhoneDirectory value) { }

	// RVA: 0x94E5C0 Offset: 0x94D9C0 VA: 0x18094E5C0
	public BaseEntity get_ParentEntity() { }

	// RVA: 0x94E600 Offset: 0x94DA00 VA: 0x18094E600
	private Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E6E0 Offset: 0x94DAE0 VA: 0x18094E6E0
	public Telephone.CallState get_clientCallState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E880 Offset: 0x94DC80 VA: 0x18094E880
	private void set_clientCallState(Telephone.CallState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E420 Offset: 0x94D820 VA: 0x18094E420
	public PhoneDialler get_CurrentDialog() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E870 Offset: 0x94DC70 VA: 0x18094E870
	private void set_CurrentDialog(PhoneDialler value) { }

	// RVA: 0x94E3E0 Offset: 0x94D7E0 VA: 0x18094E3E0
	public float get_CallDuration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71AF80 Offset: 0x71A380 VA: 0x18071AF80
	public PhoneDirectory get_currentDirectory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71B010 Offset: 0x71A410 VA: 0x18071B010
	private void set_currentDirectory(PhoneDirectory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E410 Offset: 0x94D810 VA: 0x18094E410
	public int get_ConnectedCallPhoneNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E860 Offset: 0x94DC60 VA: 0x18094E860
	private void set_ConnectedCallPhoneNumber(int value) { }

	// RVA: 0x94D380 Offset: 0x94C780 VA: 0x18094D380
	public void OpenDialler(BasePlayer player) { }

	// RVA: 0x94B8E0 Offset: 0x94ACE0 VA: 0x18094B8E0
	public void AnswerPhone(BasePlayer player) { }

	// RVA: 0x94BA60 Offset: 0x94AE60 VA: 0x18094BA60
	public void AnswerViaUI() { }

	// RVA: 0x94CF60 Offset: 0x94C360 VA: 0x18094CF60
	public void OnClosedDialler(BasePlayer player) { }

	// RVA: 0x94D310 Offset: 0x94C710 VA: 0x18094D310
	public void OnLocalPlayerCancelled() { }

	// RVA: 0x94E320 Offset: 0x94D720 VA: 0x18094E320
	public void UpdatePhoneNumber(BaseEntity.RPCMessage msg) { }

	// RVA: 0x94DAA0 Offset: 0x94CEA0 VA: 0x18094DAA0
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	// RVA: 0x94E0A0 Offset: 0x94D4A0 VA: 0x18094E0A0
	private void ToggleRingingLight() { }

	// RVA: 0x94C710 Offset: 0x94BB10 VA: 0x18094C710
	public void ControllerLateUpdate() { }

	// RVA: 0x94C820 Offset: 0x94BC20 VA: 0x18094C820
	public void DialNumber(int number) { }

	// RVA: 0x94BB90 Offset: 0x94AF90 VA: 0x18094BB90
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x94C180 Offset: 0x94B580 VA: 0x18094C180
	public void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg, Cassette cachedCassette) { }

	// RVA: 0x94BEA0 Offset: 0x94B2A0 VA: 0x18094BEA0
	public void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E3D0 Offset: 0x94D7D0 VA: 0x18094E3D0
	public TimeSince get_AnsweringMessageStartTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E850 Offset: 0x94DC50 VA: 0x18094E850
	private void set_AnsweringMessageStartTime(TimeSince value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E3C0 Offset: 0x94D7C0 VA: 0x18094E3C0
	public float get_AnsweringMachineMessageLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E840 Offset: 0x94DC40 VA: 0x18094E840
	private void set_AnsweringMachineMessageLength(float value) { }

	// RVA: 0x94D500 Offset: 0x94C900 VA: 0x18094D500
	private void PlayAnsweringMessage(AudioClip clip, bool canLeaveVoicemail) { }

	// RVA: 0x94CB20 Offset: 0x94BF20 VA: 0x18094CB20
	public void InitiateVoicemailRecord() { }

	// RVA: 0x94C890 Offset: 0x94BC90 VA: 0x18094C890
	public void FinishVoicemailRecording() { }

	// RVA: 0x94BAC0 Offset: 0x94AEC0 VA: 0x18094BAC0
	public void ClientHangUp() { }

	// RVA: 0x94D2E0 Offset: 0x94C6E0 VA: 0x18094D2E0
	public void OnIncomingCallDuringCall() { }

	// RVA: 0x94D330 Offset: 0x94C730 VA: 0x18094D330
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	// RVA: 0x94E010 Offset: 0x94D410 VA: 0x18094E010
	public void SubmitNewName(string newName) { }

	// RVA: 0x94D9F0 Offset: 0x94CDF0 VA: 0x18094D9F0
	public bool RequestPhoneDirectory(int page) { }

	// RVA: 0x94D810 Offset: 0x94CC10 VA: 0x18094D810
	public void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	// RVA: 0x94C600 Offset: 0x94BA00 VA: 0x18094C600
	public void Client_AddSavedNumber(uint number, string savedPhoneName) { }

	// RVA: 0x94C6A0 Offset: 0x94BAA0 VA: 0x18094C6A0
	public void Client_RemoveSavedNumber(uint number) { }

	// RVA: 0x94CE00 Offset: 0x94C200 VA: 0x18094CE00
	public void OnClientLoaded() { }

	// RVA: 0x94E430 Offset: 0x94D830 VA: 0x18094E430
	public bool get_IsDead() { }

	// RVA: 0x94CCD0 Offset: 0x94C0D0 VA: 0x18094CCD0
	private bool IsPowered() { }

	// RVA: 0x94CDC0 Offset: 0x94C1C0 VA: 0x18094CDC0
	public bool IsSavedContactValid(string contactName, int contactNumber) { }

	// RVA: 0x94D130 Offset: 0x94C530 VA: 0x18094D130
	public void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x94E360 Offset: 0x94D760 VA: 0x18094E360
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E260 Offset: 0x94D660 VA: 0x18094E260
	private void <ClientToggleVoicemail>b__3_0(AudioClip clip, bool success) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E1A0 Offset: 0x94D5A0 VA: 0x18094E1A0
	private void <ClientReceiveAnsweringData>b__93_0(AudioClip clip, bool success) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E0E0 Offset: 0x94D4E0 VA: 0x18094E0E0
	private void <ClientPlayAnsweringMessage>b__94_0(AudioClip clip, bool success) { }

}

