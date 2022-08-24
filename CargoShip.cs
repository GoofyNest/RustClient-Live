public class CargoShip : BaseEntity // TypeDefIndex: 8287
{
	public int targetNodeIndex; 
	public GameObject wakeParent; 
	public GameObjectRef scientistTurretPrefab; 
	public Transform[] scientistSpawnPoints; 
	public List<Transform> crateSpawns; 
	public GameObjectRef lockedCratePrefab; 
	public GameObjectRef militaryCratePrefab; 
	public GameObjectRef eliteCratePrefab; 
	public GameObjectRef junkCratePrefab; 
	public Transform waterLine; 
	public Transform rudder; 
	public Transform propeller; 
	public GameObjectRef escapeBoatPrefab; 
	public Transform escapeBoatPoint; 
	public GameObjectRef microphonePrefab; 
	public Transform microphonePoint; 
	public GameObjectRef speakerPrefab; 
	public Transform[] speakerPoints; 
	public GameObject radiation; 
	public GameObjectRef mapMarkerEntityPrefab; 
	public GameObject hornOrigin; 
	public SoundDefinition hornDef; 
	public CargoShipSounds cargoShipSounds; 
	public GameObject[] layouts; 
	public GameObjectRef playerTest; 
	private uint layoutChoice; 
	private TimeSince timeSinceUpdatedSounds; 
	private const float updateRateDistSq = 10000;


	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void RefreshActiveLayout() { }

	public void Update() { }

	protected override void ClientInit(Entity info) { }

	public override void PostNetworkUpdate() { }

	[BaseEntity.RPC_Client] 
	public void DoHornSound(BaseEntity.RPCMessage msg) { }

	public override bool SupportsChildDeployables() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

