public class BaseArcadeMachine : BaseVehicle // TypeDefIndex: 8316
{	private Option __menuOption_Menu_Play; // 0x3B8
	public BaseArcadeGame arcadeGamePrefab; // 0x410
	public BaseArcadeGame activeGame; // 0x418
	public ArcadeNetworkTrigger networkTrigger; // 0x420
	public float broadcastRadius; // 0x428
	public Transform gameScreen; // 0x430
	public RawImage RTImage; // 0x438
	public Transform leftJoystick; // 0x440
	public Transform rightJoystick; // 0x448
	public SoundPlayer musicPlayer; // 0x450
	public const BaseEntity.Flags Flag_P1 = 32768;
	public const BaseEntity.Flags Flag_P2 = 65536;
	public List<BaseArcadeMachine.ScoreEntry> scores; // 0x458
	private const int inputFrameRate = 60;
	private const int snapshotFrameRate = 15;
	private Vector3 arcadeWorldOffset; // 0x460
	private bool clientScreeenActive; // 0x46C

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public void SpawnGame() { }

	public override void InitShared() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void BeginHosting(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void EndHosting(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void NoHost(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void GetEntityMessage(BaseEntity.RPCMessage msg) { }

	protected override void ClientInit(Entity info) { }

	public void FixedUpdate() { }

	public void GameVisibilityChanged(bool isVisible) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void DestroyEntity(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void GetSnapshotFromServer(BaseEntity.RPCMessage msg) { }

	public void SendSnapshotToServer() { }

	public void DoClientInput() { }

	public override void DestroyShared() { }

	public virtual void PlayerClientInput(InputState inputState) { }

	public void SendDestroyMessage(uint entityID) { }

	public override bool MountMenuVisible(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB4600 Offset: 0xB3A00 VA: 0x1800B4600
	[BaseEntity.Menu.Description] // RVA: 0xB4600 Offset: 0xB3A00 VA: 0x1800B4600
	[BaseEntity.Menu.Icon] // RVA: 0xB4600 Offset: 0xB3A00 VA: 0x1800B4600
	[BaseEntity.Menu.ShowIf] // RVA: 0xB4600 Offset: 0xB3A00 VA: 0x1800B4600
	public void Menu_Play(BasePlayer player) { }

	public bool Menu_PlayGame_ShowIf(BasePlayer player) { }

	protected override bool CanPushNow(BasePlayer pusher) { }

	public void .ctor() { }

}

public class BaseArcadeMachine.ScoreEntry // TypeDefIndex: 8317
{	public ulong playerID; // 0x10
	public int score; // 0x18
	public string displayName; // 0x20


	public void .ctor() { }

}

