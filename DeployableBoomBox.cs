public class DeployableBoomBox : ContainerIOEntity, ICassettePlayer, IAudioConnectionSource // TypeDefIndex: 8378
{	// Fields
	private Option __menuOption_ChangeRadioSettings; // 0x378
	private Option __menuOption_Play; // 0x3D0
	private Option __menuOption_Stop; // 0x428
	public BoomBox BoxController; // 0x480
	public int PowerUsageWhilePlaying; // 0x488
	public const int MaxBacktrackHopsClient = 30;
	public bool IsStatic; // 0x48C
	private List<Vector3> connectedPositions; // 0x490
	private int lastConnectCount; // 0x498

	// Properties
	public override bool HasMenuOptions { get; }
	public BaseEntity ToBaseEntity { get; }
	public float VolumeVisualisationMultiplier { get; }

	// Methods

	// RVA: 0x9B50E0 Offset: 0x9B44E0 VA: 0x1809B50E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9B7530 Offset: 0x9B6930 VA: 0x1809B7530 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9B5B50 Offset: 0x9B4F50 VA: 0x1809B5B50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 167
	public BaseEntity get_ToBaseEntity() { }

	[BaseEntity.Menu] // RVA: 0xD68B0 Offset: 0xD5CB0 VA: 0x1800D68B0
	[BaseEntity.Menu.Description] // RVA: 0xD68B0 Offset: 0xD5CB0 VA: 0x1800D68B0
	[BaseEntity.Menu.Icon] // RVA: 0xD68B0 Offset: 0xD5CB0 VA: 0x1800D68B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD68B0 Offset: 0xD5CB0 VA: 0x1800D68B0
	// RVA: 0x9B66E0 Offset: 0x9B5AE0 VA: 0x1809B66E0
	public void Play(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6B10 Offset: 0xD5F10 VA: 0x1800D6B10
	[BaseEntity.Menu.Description] // RVA: 0xD6B10 Offset: 0xD5F10 VA: 0x1800D6B10
	[BaseEntity.Menu.Icon] // RVA: 0xD6B10 Offset: 0xD5F10 VA: 0x1800D6B10
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6B10 Offset: 0xD5F10 VA: 0x1800D6B10
	// RVA: 0x9B72C0 Offset: 0x9B66C0 VA: 0x1809B72C0
	public void Stop(BasePlayer forPlayer) { }

	// RVA: 0x9B4D70 Offset: 0x9B4170 VA: 0x1809B4D70
	private bool CanStop(BasePlayer forPlayer) { }

	// RVA: 0x9B4D40 Offset: 0x9B4140 VA: 0x1809B4D40
	private bool CanStart(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6E30 Offset: 0xD6230 VA: 0x1800D6E30
	[BaseEntity.Menu.Description] // RVA: 0xD6E30 Offset: 0xD6230 VA: 0x1800D6E30
	[BaseEntity.Menu.Icon] // RVA: 0xD6E30 Offset: 0xD6230 VA: 0x1800D6E30
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6E30 Offset: 0xD6230 VA: 0x1800D6E30
	// RVA: 0x9B4DA0 Offset: 0x9B41A0 VA: 0x1809B4DA0
	public void ChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x9B4D10 Offset: 0x9B4110 VA: 0x1809B4D10
	private bool CanChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x9B5A80 Offset: 0x9B4E80 VA: 0x1809B5A80 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9B4E20 Offset: 0x9B4220 VA: 0x1809B4E20
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9B4E60 Offset: 0x9B4260 VA: 0x1809B4E60
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9B5B10 Offset: 0x9B4F10 VA: 0x1809B5B10
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9B72F0 Offset: 0x9B66F0 VA: 0x1809B72F0
	public void WaitForShoutcastLoad() { }

	// RVA: 0x9B4DD0 Offset: 0x9B41D0 VA: 0x1809B4DD0
	public void ClearConnectedPositions() { }

	// RVA: 0x9B6B80 Offset: 0x9B5F80 VA: 0x1809B6B80
	public void SetAudioClipOnAttachedSpeakers(IOEntity entity, AudioClip clip, float time, int depth, ShoutcastStreamer streamer) { }

	// RVA: 0x9B58E0 Offset: 0x9B4CE0 VA: 0x1809B58E0
	private bool IsPositionValidForSpeaker(Vector3 pos) { }

	// RVA: 0x9B6FC0 Offset: 0x9B63C0 VA: 0x1809B6FC0 Slot: 170
	public void SpeakerConnected(ConnectedSpeaker speaker) { }

	// RVA: 0x9B7160 Offset: 0x9B6560 VA: 0x1809B7160 Slot: 171
	public void SpeakerDisconnected(ConnectedSpeaker repeater) { }

	// RVA: 0x9B58C0 Offset: 0x9B4CC0 VA: 0x1809B58C0 Slot: 172
	public AudioSource GetSource() { }

	// RVA: 0x4C0690 Offset: 0x4BFA90 VA: 0x1804C0690 Slot: 173
	public float get_VolumeVisualisationMultiplier() { }

	// RVA: 0x9B5AE0 Offset: 0x9B4EE0 VA: 0x1809B5AE0 Slot: 168
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x9B5A50 Offset: 0x9B4E50 VA: 0x1809B5A50 Slot: 169
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x9B4F20 Offset: 0x9B4320 VA: 0x1809B4F20
	public float GetClosestDistance(Vector3 position) { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 174
	public float GetFakeInput() { }

	// RVA: 0x9B6610 Offset: 0x9B5A10 VA: 0x1809B6610
	public void OnStreamChangedByCensorSetting(bool connectingToStream) { }

	// RVA: 0x2F99A0 Offset: 0x2F8DA0 VA: 0x1802F99A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x9B7240 Offset: 0x9B6640 VA: 0x1809B7240
	public void StartPlayProximityCheck() { }

	// RVA: 0x9B4EB0 Offset: 0x9B42B0 VA: 0x1809B4EB0
	public void EndPlayProximityCheck() { }

	// RVA: 0x9B6710 Offset: 0x9B5B10 VA: 0x1809B6710
	private void ProximityCheck() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 175
	public IOEntity ToEntity() { }

	// RVA: 0x9B4EA0 Offset: 0x9B42A0 VA: 0x1809B4EA0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x9B59F0 Offset: 0x9B4DF0 VA: 0x1809B59F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9B74B0 Offset: 0x9B68B0 VA: 0x1809B74B0
	public void .ctor() { }

}

