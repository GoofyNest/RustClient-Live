public class RecorderTool : ThrownWeapon, ICassettePlayer // TypeDefIndex: 8627
{
	[ClientVar] 
	public static bool debugRecording; 
	public AudioSource RecorderAudioSource; 
	public SoundDefinition RecordStartSfx; 
	public SoundDefinition RewindSfx; 
	public SoundDefinition RecordFinishedSfx; 
	public SoundDefinition PlayTapeSfx; 
	public SoundDefinition StopTapeSfx; 
	public float ThrowScale; 
	private bool recording; 
	public static bool IsRecording; 
	private AudioInterceptComponent activeIntercept; 
	private float recordStartTime; 
	[CompilerGeneratedAttribute] 
	private Cassette <cachedCassette>k__BackingField; 
	private OggEncoder currentEncoder; 
	[CompilerGeneratedAttribute] 
	private int <StartCountdown>k__BackingField; 
	private Sound rewindingSound; 
	private uint cassetteToLoad; 
	private static readonly int PlayAnimBool; 

	public Cassette cachedCassette { get; set; }
	public Sprite LoadedCassetteIcon { get; }
	public BaseEntity ToBaseEntity { get; }
	public int StartCountdown { get; set; }
	private bool IsCountingDown { get; }
	public float NormalizedTapeUsed { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] 
	public Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] 
	private void set_cachedCassette(Cassette value) { }

	public Sprite get_LoadedCassetteIcon() { }

	private bool HasCassette() { }

	public BaseEntity get_ToBaseEntity() { }

	public void OnCensorRecordingsChanged() { }

	public override void OnInput() { }

	internal override void DoNetworkDestroy() { }

	[CompilerGeneratedAttribute] 
	public int get_StartCountdown() { }

	[CompilerGeneratedAttribute] 
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

	[BaseEntity.RPC_Client] 
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
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

