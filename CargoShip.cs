public class CargoShip : BaseEntity // TypeDefIndex: 8287
{	// Fields
	public int targetNodeIndex; // 0x168
	public GameObject wakeParent; // 0x170
	public GameObjectRef scientistTurretPrefab; // 0x178
	public Transform[] scientistSpawnPoints; // 0x180
	public List<Transform> crateSpawns; // 0x188
	public GameObjectRef lockedCratePrefab; // 0x190
	public GameObjectRef militaryCratePrefab; // 0x198
	public GameObjectRef eliteCratePrefab; // 0x1A0
	public GameObjectRef junkCratePrefab; // 0x1A8
	public Transform waterLine; // 0x1B0
	public Transform rudder; // 0x1B8
	public Transform propeller; // 0x1C0
	public GameObjectRef escapeBoatPrefab; // 0x1C8
	public Transform escapeBoatPoint; // 0x1D0
	public GameObjectRef microphonePrefab; // 0x1D8
	public Transform microphonePoint; // 0x1E0
	public GameObjectRef speakerPrefab; // 0x1E8
	public Transform[] speakerPoints; // 0x1F0
	public GameObject radiation; // 0x1F8
	public GameObjectRef mapMarkerEntityPrefab; // 0x200
	public GameObject hornOrigin; // 0x208
	public SoundDefinition hornDef; // 0x210
	public CargoShipSounds cargoShipSounds; // 0x218
	public GameObject[] layouts; // 0x220
	public GameObjectRef playerTest; // 0x228
	private uint layoutChoice; // 0x230
	private TimeSince timeSinceUpdatedSounds; // 0x234
	private const float updateRateDistSq = 10000;

	// Methods

	// RVA: 0x545740 Offset: 0x544B40 VA: 0x180545740 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x545C90 Offset: 0x545090 VA: 0x180545C90
	public void RefreshActiveLayout() { }

	// RVA: 0x545D20 Offset: 0x545120 VA: 0x180545D20
	public void Update() { }

	// RVA: 0x545590 Offset: 0x544990 VA: 0x180545590 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x545C00 Offset: 0x545000 VA: 0x180545C00 Slot: 16
	public override void PostNetworkUpdate() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x545700 Offset: 0x544B00 VA: 0x180545700
	public void DoHornSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 129
	public override bool SupportsChildDeployables() { }

	// RVA: 0x5457A0 Offset: 0x544BA0 VA: 0x1805457A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x545EC0 Offset: 0x5452C0 VA: 0x180545EC0
	public void .ctor() { }

}

