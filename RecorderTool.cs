public class RecorderTool : ThrownWeapon, ICassettePlayer // TypeDefIndex: 8627
{	// Fields
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool debugRecording; // 0x0
	public AudioSource RecorderAudioSource; // 0x2A0
	public SoundDefinition RecordStartSfx; // 0x2A8
	public SoundDefinition RewindSfx; // 0x2B0
	public SoundDefinition RecordFinishedSfx; // 0x2B8
	public SoundDefinition PlayTapeSfx; // 0x2C0
	public SoundDefinition StopTapeSfx; // 0x2C8
	public float ThrowScale; // 0x2D0
	private bool recording; // 0x2D4
	public static bool IsRecording; // 0x1
	private AudioInterceptComponent activeIntercept; // 0x2D8
	private float recordStartTime; // 0x2E0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Cassette <cachedCassette>k__BackingField; // 0x2E8
	private OggEncoder currentEncoder; // 0x2F0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <StartCountdown>k__BackingField; // 0x2F8
	private Sound rewindingSound; // 0x300
	private uint cassetteToLoad; // 0x308
	private static readonly int PlayAnimBool; // 0x4

	// Properties
	public Cassette cachedCassette { get; set; }
	public Sprite LoadedCassetteIcon { get; }
	public BaseEntity ToBaseEntity { get; }
	public int StartCountdown { get; set; }
	private bool IsCountingDown { get; }
	public float NormalizedTapeUsed { get; }

	// Methods

	// RVA: 0x91C550 Offset: 0x91B950 VA: 0x18091C550 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x91DC50 Offset: 0x91D050 VA: 0x18091DC50
	public Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x91DC60 Offset: 0x91D060 VA: 0x18091DC60
	private void set_cachedCassette(Cassette value) { }

	// RVA: 0x91DB80 Offset: 0x91CF80 VA: 0x18091DB80
	public Sprite get_LoadedCassetteIcon() { }

	// RVA: 0x91BB10 Offset: 0x91AF10 VA: 0x18091BB10
	private bool HasCassette() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 160
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x91BB70 Offset: 0x91AF70 VA: 0x18091BB70 Slot: 162
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x91BE00 Offset: 0x91B200 VA: 0x18091BE00 Slot: 138
	public override void OnInput() { }

	// RVA: 0x91BA90 Offset: 0x91AE90 VA: 0x18091BA90 Slot: 20
	internal override void DoNetworkDestroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x835FF0 Offset: 0x8353F0 VA: 0x180835FF0
	public int get_StartCountdown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x836030 Offset: 0x835430 VA: 0x180836030
	private void set_StartCountdown(int value) { }

	// RVA: 0x91DB00 Offset: 0x91CF00 VA: 0x18091DB00
	private bool get_IsCountingDown() { }

	// RVA: 0x91DC10 Offset: 0x91D010 VA: 0x18091DC10
	public float get_NormalizedTapeUsed() { }

	// RVA: 0x91CE60 Offset: 0x91C260 VA: 0x18091CE60
	private void StartRecording() { }

	// RVA: 0x91D510 Offset: 0x91C910 VA: 0x18091D510
	private void TickDownStart() { }

	// RVA: 0x91D090 Offset: 0x91C490 VA: 0x18091D090
	public void StopRecording() { }

	// RVA: 0x91BB80 Offset: 0x91AF80 VA: 0x18091BB80 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x91B5C0 Offset: 0x91A9C0 VA: 0x18091B5C0
	private void CancelRecording() { }

	// RVA: 0x91CDA0 Offset: 0x91C1A0 VA: 0x18091CDA0
	private void RequestFileUpdate() { }

	// RVA: 0x91D640 Offset: 0x91CA40 VA: 0x18091D640
	public void UpdateAudioClip(AudioClip clip) { }

	// RVA: 0x91BBF0 Offset: 0x91AFF0 VA: 0x18091BBF0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x91B810 Offset: 0x91AC10 VA: 0x18091B810
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x91B9D0 Offset: 0x91ADD0 VA: 0x18091B9D0
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	// RVA: 0x91C4B0 Offset: 0x91B8B0 VA: 0x18091C4B0 Slot: 161
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x91D710 Offset: 0x91CB10 VA: 0x18091D710
	private void UpdateViewmodelCassette(ViewModel vm) { }

	// RVA: 0x91D8E0 Offset: 0x91CCE0 VA: 0x18091D8E0
	private void UpdateViewmodelPlay(BasePlayer forPlayer, ViewModel vm) { }

	// RVA: 0x91BBA0 Offset: 0x91AFA0 VA: 0x18091BBA0 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x91CD50 Offset: 0x91C150 VA: 0x18091CD50 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x91DAE0 Offset: 0x91CEE0 VA: 0x18091DAE0
	public void .ctor() { }

	// RVA: 0x91DA70 Offset: 0x91CE70 VA: 0x18091DA70
	private static void .cctor() { }

}

