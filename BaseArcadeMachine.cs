public class BaseArcadeMachine : BaseVehicle // TypeDefIndex: 8317
{
	private Option __menuOption_Menu_Play; 
	public BaseArcadeGame arcadeGamePrefab; 
	public BaseArcadeGame activeGame; 
	public ArcadeNetworkTrigger networkTrigger; 
	public float broadcastRadius; 
	public Transform gameScreen; 
	public RawImage RTImage; 
	public Transform leftJoystick; 
	public Transform rightJoystick; 
	public SoundPlayer musicPlayer; 
	public const BaseEntity.Flags Flag_P1 = 32768;
	public const BaseEntity.Flags Flag_P2 = 65536;
	public List<BaseArcadeMachine.ScoreEntry> scores; 
	private const int inputFrameRate = 60;
	private const int snapshotFrameRate = 15;
	private Vector3 arcadeWorldOffset; 
	private bool clientScreeenActive; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public void SpawnGame() { }

	public override void InitShared() { }

	[BaseEntity.RPC_Client] 
	public void BeginHosting(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void EndHosting(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void NoHost(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void GetEntityMessage(BaseEntity.RPCMessage msg) { }

	protected override void ClientInit(Entity info) { }

	public void FixedUpdate() { }

	public void GameVisibilityChanged(bool isVisible) { }

	[BaseEntity.RPC_Client] 
	public void DestroyEntity(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void GetSnapshotFromServer(BaseEntity.RPCMessage msg) { }

	public void SendSnapshotToServer() { }

	public void DoClientInput() { }

	public override void DestroyShared() { }

	public virtual void PlayerClientInput(InputState inputState) { }

	public void SendDestroyMessage(uint entityID) { }

	public override bool MountMenuVisible(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Play(BasePlayer player) { }

	public bool Menu_PlayGame_ShowIf(BasePlayer player) { }

	protected override bool CanPushNow(BasePlayer pusher) { }

	public void .ctor() { }

}

public class BaseArcadeMachine.ScoreEntry // TypeDefIndex: 8318
{
	public ulong playerID; 
	public int score; 
	public string displayName; 


	public void .ctor() { }

}

