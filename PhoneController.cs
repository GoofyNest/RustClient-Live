public class PhoneController : EntityComponent<BaseEntity> // TypeDefIndex: 9450
{
	public int PhoneNumber; 
	public string PhoneName; 
	public bool CanModifyPhoneName; 
	public bool CanSaveNumbers; 
	public bool RequirePower; 
	public bool RequireParent; 
	public float CallWaitingTime; 
	public bool AppendGridToName; 
	public bool IsMobile; 
	public bool CanSaveVoicemail; 
	public GameObjectRef PhoneDialog; 
	public VoiceProcessor VProcessor; 
	public PreloadedCassetteContent PreloadedContent; 
	public SoundDefinition DialToneSfx; 
	public SoundDefinition RingingSfx; 
	public SoundDefinition ErrorSfx; 
	public SoundDefinition CallIncomingWhileBusySfx; 
	public SoundDefinition PickupHandsetSfx; 
	public SoundDefinition PutDownHandsetSfx; 
	public SoundDefinition FailedWrongNumber; 
	public SoundDefinition FailedNoAnswer; 
	public SoundDefinition FailedNetworkBusy; 
	public SoundDefinition FailedEngaged; 
	public SoundDefinition FailedRemoteHangUp; 
	public SoundDefinition FailedSelfHangUp; 
	public Light RingingLight; 
	public float RingingLightFrequency; 
	public AudioSource answeringMachineSound; 
	public EntityRef currentPlayerRef; 
	[CompilerGeneratedAttribute] 
	private int <lastDialedNumber>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private PhoneDirectory <savedNumbers>k__BackingField; 
	public List<VoicemailEntry> savedVoicemail; 
	private SoundDefinition currentlyLoadedPreloadedContent; 
	private string connectedPlayerId; 
	[CompilerGeneratedAttribute] 
	private Telephone.CallState <clientCallState>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private PhoneDialler <CurrentDialog>k__BackingField; 
	private float callStartTime; 
	private Sound ringingSound; 
	private Sound dialingSound; 
	[CompilerGeneratedAttribute] 
	private PhoneDirectory <currentDirectory>k__BackingField; 
	private TimeSince lastDirectoryUpdate; 
	[CompilerGeneratedAttribute] 
	private int <ConnectedCallPhoneNumber>k__BackingField; 
	private int voicemailTarget; 
	private OggEncoder currentEncoder; 
	private AudioInterceptComponent activeIntercept; 
	private int requestedDialNumber; 
	private bool cachedCanLeaveVoicemail; 
	[CompilerGeneratedAttribute] 
	private TimeSince <AnsweringMessageStartTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <AnsweringMachineMessageLength>k__BackingField; 

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

	[CompilerGeneratedAttribute] 
	public int get_lastDialedNumber() { }

	[CompilerGeneratedAttribute] 
	public void set_lastDialedNumber(int value) { }

	[CompilerGeneratedAttribute] 
	public PhoneDirectory get_savedNumbers() { }

	[CompilerGeneratedAttribute] 
	public void set_savedNumbers(PhoneDirectory value) { }

	public BaseEntity get_ParentEntity() { }

	private Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] 
	public Telephone.CallState get_clientCallState() { }

	[CompilerGeneratedAttribute] 
	private void set_clientCallState(Telephone.CallState value) { }

	[CompilerGeneratedAttribute] 
	public PhoneDialler get_CurrentDialog() { }

	[CompilerGeneratedAttribute] 
	private void set_CurrentDialog(PhoneDialler value) { }

	public float get_CallDuration() { }

	[CompilerGeneratedAttribute] 
	public PhoneDirectory get_currentDirectory() { }

	[CompilerGeneratedAttribute] 
	private void set_currentDirectory(PhoneDirectory value) { }

	[CompilerGeneratedAttribute] 
	public int get_ConnectedCallPhoneNumber() { }

	[CompilerGeneratedAttribute] 
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

	[CompilerGeneratedAttribute] 
	public TimeSince get_AnsweringMessageStartTime() { }

	[CompilerGeneratedAttribute] 
	private void set_AnsweringMessageStartTime(TimeSince value) { }

	[CompilerGeneratedAttribute] 
	public float get_AnsweringMachineMessageLength() { }

	[CompilerGeneratedAttribute] 
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

	[CompilerGeneratedAttribute] 
	private void <ClientToggleVoicemail>b__3_0(AudioClip clip, bool success) { }

	[CompilerGeneratedAttribute] 
	private void <ClientReceiveAnsweringData>b__93_0(AudioClip clip, bool success) { }

	[CompilerGeneratedAttribute] 
	private void <ClientPlayAnsweringMessage>b__94_0(AudioClip clip, bool success) { }

}

