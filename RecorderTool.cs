public class RecorderTool : ThrownWeapon, ICassettePlayer // TypeDefIndex: 8627
{	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
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

	public Cassette cachedCassette { get; set; }
	public Sprite LoadedCassetteIcon { get; }
	public BaseEntity ToBaseEntity { get; }
	public int StartCountdown { get; set; }
	private bool IsCountingDown { get; }
	public float NormalizedTapeUsed { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_cachedCassette(Cassette value) { }

	public Sprite get_LoadedCassetteIcon() { }

	private bool HasCassette() { }

	public BaseEntity get_ToBaseEntity() { }

	public void OnCensorRecordingsChanged() { }

	public override void OnInput() { }

	internal override void DoNetworkDestroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_StartCountdown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_StartCountdown(int value) { }

	private bool get_IsCountingDown() { }

	public float get_NormalizedTapeUsed() { }

	private void StartRecording() { }

	private void TickDownStart() { }

	public void StopRecording() { }

	public override void OnDeploy() { }

	private void CancelRecording() { }

	private void RequestFileUpdate() { }

	public void UpdateAudioClip(AudioClip clip) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	public void OnLoadedWithCassette(Cassette c) { }

	private void UpdateViewmodelCassette(ViewModel vm) { }

	private void UpdateViewmodelPlay(BasePlayer forPlayer, ViewModel vm) { }

	public override void OnDeployed() { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

