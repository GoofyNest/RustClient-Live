public class BaseArcadeMachine : BaseVehicle // TypeDefIndex: 8316
{	// Fields
	private Option __menuOption_Menu_Play; // 0x3B8
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

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7EBD70 Offset: 0x7EB170 VA: 0x1807EBD70 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7EE2C0 Offset: 0x7ED6C0 VA: 0x1807EE2C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7EC5D0 Offset: 0x7EB9D0 VA: 0x1807EC5D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7EC180 Offset: 0x7EB580 VA: 0x1807EC180 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7EE1F0 Offset: 0x7ED5F0 VA: 0x1807EE1F0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x7EDF60 Offset: 0x7ED360 VA: 0x1807EDF60
	public void SpawnGame() { }

	// RVA: 0x7EC160 Offset: 0x7EB560 VA: 0x1807EC160 Slot: 28
	public override void InitShared() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7EB1A0 Offset: 0x7EA5A0 VA: 0x1807EB1A0
	public void BeginHosting(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7EB770 Offset: 0x7EAB70 VA: 0x1807EB770
	public void EndHosting(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7EC540 Offset: 0x7EB940 VA: 0x1807EC540
	public void NoHost(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7EBC30 Offset: 0x7EB030 VA: 0x1807EBC30
	public void GetEntityMessage(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7EB350 Offset: 0x7EA750 VA: 0x1807EB350 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7EB860 Offset: 0x7EAC60 VA: 0x1807EB860
	public void FixedUpdate() { }

	// RVA: 0x7EBA20 Offset: 0x7EAE20 VA: 0x1807EBA20
	public void GameVisibilityChanged(bool isVisible) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7EB360 Offset: 0x7EA760 VA: 0x1807EB360
	public void DestroyEntity(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7EC080 Offset: 0x7EB480 VA: 0x1807EC080
	public void GetSnapshotFromServer(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7EDEA0 Offset: 0x7ED2A0 VA: 0x1807EDEA0
	public void SendSnapshotToServer() { }

	// RVA: 0x7EB6A0 Offset: 0x7EAAA0 VA: 0x1807EB6A0
	public void DoClientInput() { }

	// RVA: 0x7EB5E0 Offset: 0x7EA9E0 VA: 0x1807EB5E0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x7EDD20 Offset: 0x7ED120 VA: 0x1807EDD20 Slot: 194
	public virtual void PlayerClientInput(InputState inputState) { }

	// RVA: 0x7EDE50 Offset: 0x7ED250 VA: 0x1807EDE50
	public void SendDestroyMessage(uint entityID) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB4600 Offset: 0xB3A00 VA: 0x1800B4600
	[BaseEntity.Menu.Description] // RVA: 0xB4600 Offset: 0xB3A00 VA: 0x1800B4600
	[BaseEntity.Menu.Icon] // RVA: 0xB4600 Offset: 0xB3A00 VA: 0x1800B4600
	[BaseEntity.Menu.ShowIf] // RVA: 0xB4600 Offset: 0xB3A00 VA: 0x1800B4600
	// RVA: 0x7EC500 Offset: 0x7EB900 VA: 0x1807EC500
	public void Menu_Play(BasePlayer player) { }

	// RVA: 0x7EC400 Offset: 0x7EB800 VA: 0x1807EC400
	public bool Menu_PlayGame_ShowIf(BasePlayer player) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x7EE200 Offset: 0x7ED600 VA: 0x1807EE200
	public void .ctor() { }

}

public class BaseArcadeMachine.ScoreEntry // TypeDefIndex: 8317
{	// Fields
	public ulong playerID; // 0x10
	public int score; // 0x18
	public string displayName; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

