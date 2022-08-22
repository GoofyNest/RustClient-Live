public class CargoShip : BaseEntity // TypeDefIndex: 8287
{	public int targetNodeIndex; // 0x168
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


	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void RefreshActiveLayout() { }

	public void Update() { }

	protected override void ClientInit(Entity info) { }

	public override void PostNetworkUpdate() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void DoHornSound(BaseEntity.RPCMessage msg) { }

	public override bool SupportsChildDeployables() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

