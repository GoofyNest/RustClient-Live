public class DeployedRecorder : StorageContainer, ICassettePlayer // TypeDefIndex: 8379
{	// Fields
	private Option __menuOption_Play; // 0x3D0
	private Option __menuOption_Stop; // 0x428
	public AudioSource SoundSource; // 0x480
	public ItemDefinition[] ValidCassettes; // 0x488
	public SoundDefinition PlaySfx; // 0x490
	public SoundDefinition StopSfx; // 0x498
	public SwapKeycard TapeSwapper; // 0x4A0
	private Cassette cachedCassette; // 0x4A8
	private bool initialLoad; // 0x4B0

	// Properties
	public override bool HasMenuOptions { get; }
	public BaseEntity ToBaseEntity { get; }

	// Methods

	// RVA: 0x9B7C00 Offset: 0x9B7000 VA: 0x1809B7C00 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9B9140 Offset: 0x9B8540 VA: 0x1809B9140 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9B84C0 Offset: 0x9B78C0 VA: 0x1809B84C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 155
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x9B79E0 Offset: 0x9B6DE0 VA: 0x1809B79E0 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.Menu] // RVA: 0xD68B0 Offset: 0xD5CB0 VA: 0x1800D68B0
	[BaseEntity.Menu.Description] // RVA: 0xD68B0 Offset: 0xD5CB0 VA: 0x1800D68B0
	[BaseEntity.Menu.Icon] // RVA: 0xD68B0 Offset: 0xD5CB0 VA: 0x1800D68B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD68B0 Offset: 0xD5CB0 VA: 0x1800D68B0
	// RVA: 0x9B8DD0 Offset: 0x9B81D0 VA: 0x1809B8DD0
	public void Play(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6B10 Offset: 0xD5F10 VA: 0x1800D6B10
	[BaseEntity.Menu.Description] // RVA: 0xD6B10 Offset: 0xD5F10 VA: 0x1800D6B10
	[BaseEntity.Menu.Icon] // RVA: 0xD6B10 Offset: 0xD5F10 VA: 0x1800D6B10
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6B10 Offset: 0xD5F10 VA: 0x1800D6B10
	// RVA: 0x9B8EE0 Offset: 0x9B82E0 VA: 0x1809B8EE0
	public void Stop(BasePlayer forPlayer) { }

	// RVA: 0x9B7950 Offset: 0x9B6D50 VA: 0x1809B7950
	private bool CanStop(BasePlayer forPlayer) { }

	// RVA: 0x9B78C0 Offset: 0x9B6CC0 VA: 0x1809B78C0
	private bool CanStart(BasePlayer forPlayer) { }

	// RVA: 0x9B8160 Offset: 0x9B7560 VA: 0x1809B8160
	private bool HasTape() { }

	// RVA: 0x9B8F90 Offset: 0x9B8390 VA: 0x1809B8F90
	private void UpdateAudioClip(AudioClip clip) { }

	// RVA: 0x9B9000 Offset: 0x9B8400 VA: 0x1809B9000
	private void UpdateCassetteMesh() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9B7A00 Offset: 0x9B6E00 VA: 0x1809B7A00
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9B7BA0 Offset: 0x9B6FA0 VA: 0x1809B7BA0
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9B8280 Offset: 0x9B7680 VA: 0x1809B8280 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x9B8420 Offset: 0x9B7820 VA: 0x1809B8420 Slot: 156
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x9B81C0 Offset: 0x9B75C0 VA: 0x1809B81C0 Slot: 157
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x9B8E80 Offset: 0x9B8280 VA: 0x1809B8E80 Slot: 27
	public override void ResetState() { }

	// RVA: 0x9B90E0 Offset: 0x9B84E0 VA: 0x1809B90E0
	public void .ctor() { }

}

