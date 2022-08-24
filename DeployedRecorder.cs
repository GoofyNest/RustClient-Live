public class DeployedRecorder : StorageContainer, ICassettePlayer // TypeDefIndex: 8379
{
	private Option __menuOption_Play; 
	private Option __menuOption_Stop; 
	public AudioSource SoundSource; 
	public ItemDefinition[] ValidCassettes; 
	public SoundDefinition PlaySfx; 
	public SoundDefinition StopSfx; 
	public SwapKeycard TapeSwapper; 
	private Cassette cachedCassette; 
	private bool initialLoad; 

public override bool HasMenuOptions { get; }
public BaseEntity ToBaseEntity { get; }


public override void GetMenuOptions(List<Option> list) { }

public override bool get_HasMenuOptions() { }

public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

public BaseEntity get_ToBaseEntity() { }

protected override void ClientInit(Entity info) { }

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

private bool HasTape() { }

private void UpdateAudioClip(AudioClip clip) { }

private void UpdateCassetteMesh() { }

	[BaseEntity.RPC_Client] 
public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

public void OnLoadedWithCassette(Cassette c) { }

public void OnCensorRecordingsChanged() { }

public override void ResetState() { }

public void .ctor() { }

}

