public class DeployableBoomBox : ContainerIOEntity, ICassettePlayer, IAudioConnectionSource // TypeDefIndex: 10085
{
	private Option __menuOption_ChangeRadioSettings; 
	private Option __menuOption_Play; 
	private Option __menuOption_Stop; 
	public BoomBox BoxController; 
	public int PowerUsageWhilePlaying; 
	public const int MaxBacktrackHopsClient = 30;
	public bool IsStatic; 
	private List<Vector3> connectedPositions; 
	private int lastConnectCount; 

	public override bool HasMenuOptions { get; }
	public BaseEntity ToBaseEntity { get; }
	public float VolumeVisualisationMultiplier { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public BaseEntity get_ToBaseEntity() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Play(BasePlayer forPlayer) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Stop(BasePlayer forPlayer) { }

	private bool CanStop(BasePlayer forPlayer) { }

	private bool CanStart(BasePlayer forPlayer) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void ChangeRadioSettings(BasePlayer player) { }

	private bool CanChangeRadioSettings(BasePlayer player) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] 
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	public void WaitForShoutcastLoad() { }

	public void ClearConnectedPositions() { }

	public void SetAudioClipOnAttachedSpeakers(IOEntity entity, AudioClip clip, float time, int depth, ShoutcastStreamer streamer) { }

	private bool IsPositionValidForSpeaker(Vector3 pos) { }

	public void SpeakerConnected(ConnectedSpeaker speaker) { }

	public void SpeakerDisconnected(ConnectedSpeaker repeater) { }

	public AudioSource GetSource() { }

	public float get_VolumeVisualisationMultiplier() { }

	public void OnLoadedWithCassette(Cassette c) { }

	public void OnCensorRecordingsChanged() { }

	public float GetClosestDistance(Vector3 position) { }

	public float GetFakeInput() { }

	public void OnStreamChangedByCensorSetting(bool connectingToStream) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public void StartPlayProximityCheck() { }

	public void EndPlayProximityCheck() { }

	private void ProximityCheck() { }

	public IOEntity ToEntity() { }

	public override int ConsumptionAmount() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

