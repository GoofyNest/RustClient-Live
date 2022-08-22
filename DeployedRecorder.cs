public class DeployedRecorder : StorageContainer, ICassettePlayer // TypeDefIndex: 8379
{	private Option __menuOption_Play; // 0x3D0
	private Option __menuOption_Stop; // 0x428
	public AudioSource SoundSource; // 0x480
	public ItemDefinition[] ValidCassettes; // 0x488
	public SoundDefinition PlaySfx; // 0x490
	public SoundDefinition StopSfx; // 0x498
	public SwapKeycard TapeSwapper; // 0x4A0
	private Cassette cachedCassette; // 0x4A8
	private bool initialLoad; // 0x4B0

	public override bool HasMenuOptions { get; }
	public BaseEntity ToBaseEntity { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public BaseEntity get_ToBaseEntity() { }

	protected override void ClientInit(Entity info) { }

	[BaseEntity.Menu] // RVA: 0xD68B0 Offset: 0xD5CB0 VA: 0x1800D68B0
	[BaseEntity.Menu.Description] // RVA: 0xD68B0 Offset: 0xD5CB0 VA: 0x1800D68B0
	[BaseEntity.Menu.Icon] // RVA: 0xD68B0 Offset: 0xD5CB0 VA: 0x1800D68B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD68B0 Offset: 0xD5CB0 VA: 0x1800D68B0
	public void Play(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6B10 Offset: 0xD5F10 VA: 0x1800D6B10
	[BaseEntity.Menu.Description] // RVA: 0xD6B10 Offset: 0xD5F10 VA: 0x1800D6B10
	[BaseEntity.Menu.Icon] // RVA: 0xD6B10 Offset: 0xD5F10 VA: 0x1800D6B10
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6B10 Offset: 0xD5F10 VA: 0x1800D6B10
	public void Stop(BasePlayer forPlayer) { }

	private bool CanStop(BasePlayer forPlayer) { }

	private bool CanStart(BasePlayer forPlayer) { }

	private bool HasTape() { }

	private void UpdateAudioClip(AudioClip clip) { }

	private void UpdateCassetteMesh() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void OnLoadedWithCassette(Cassette c) { }

	public void OnCensorRecordingsChanged() { }

	public override void ResetState() { }

	public void .ctor() { }

}

