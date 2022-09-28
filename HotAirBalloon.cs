public class HotAirBalloon : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6345
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float inflationAmount; 
	public Vector3 velocity; 


	public static void ResetToPool(HotAirBalloon instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(HotAirBalloon instance) { }

	public HotAirBalloon Copy() { }

	public static HotAirBalloon Deserialize(Stream stream) { }

	public static HotAirBalloon DeserializeLengthDelimited(Stream stream) { }

	public static HotAirBalloon DeserializeLength(Stream stream, int length) { }

	public static HotAirBalloon Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, HotAirBalloon previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static HotAirBalloon Deserialize(byte[] buffer, HotAirBalloon instance, bool isDelta = False) { }

	public static HotAirBalloon Deserialize(Stream stream, HotAirBalloon instance, bool isDelta) { }

	public static HotAirBalloon DeserializeLengthDelimited(Stream stream, HotAirBalloon instance, bool isDelta) { }

	public static HotAirBalloon DeserializeLength(Stream stream, int length, HotAirBalloon instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, HotAirBalloon instance, HotAirBalloon previous) { }

	public static void Serialize(Stream stream, HotAirBalloon instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(HotAirBalloon instance) { }

	public static void SerializeLengthDelimited(Stream stream, HotAirBalloon instance) { }

	public void .ctor() { }

}

public class HotAirBalloon : BaseCombatEntity // TypeDefIndex: 10069
{
	private Option __menuOption_Menu_BurnOff; 
	private Option __menuOption_Menu_BurnOn; 
	private Option __menuOption_Menu_FuelStorage; 
	protected const BaseEntity.Flags Flag_HasFuel = 16384;
	protected const BaseEntity.Flags Flag_HalfInflated = 128;
	protected const BaseEntity.Flags Flag_FullInflated = 256;
	public Transform centerOfMass; 
	public Rigidbody myRigidbody; 
	public Transform buoyancyPoint; 
	public float liftAmount; 
	public Transform windSock; 
	public Transform[] windFlags; 
	public GameObject staticBalloonDeflated; 
	public GameObject staticBalloon; 
	public GameObject animatedBalloon; 
	public Animator balloonAnimator; 
	public Transform groundSample; 
	public float inflationLevel; 
	[HeaderAttribute] 
	public GameObjectRef fuelStoragePrefab; 
	public float fuelPerSec; 
	[HeaderAttribute] 
	public GameObjectRef storageUnitPrefab; 
	public EntityRef<StorageContainer> storageUnitInstance; 
	[HeaderAttribute] 
	public DamageRenderer damageRenderer; 
	public Transform engineHeight; 
	public GameObject[] killTriggers; 
	private EntityFuelSystem fuelSystem; 
	[ServerVar] 
	public static float population; 
	[ServerVar] 
	public static float outsidedecayminutes; 
	public float windForce; 
	public Vector3 currentWindVec; 
	public Bounds collapsedBounds; 
	public Bounds raisedBounds; 
	public GameObject[] balloonColliders; 
	private float currentClientInflationLevel; 
	private Vector3 windSockVec; 

	public override bool HasMenuOptions { get; }
	public bool IsFullyInflated { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool get_IsFullyInflated() { }

	public override void InitShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public bool WaterLogged() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_BurnOn(BasePlayer player) { }

	public bool Menu_BurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_BurnOff(BasePlayer player) { }

	public bool Menu_BurnOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_FuelStorage(BasePlayer player) { }

	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	protected override void ClientInit(Entity info) { }

	public void Update() { }

	public void OptimizedEnable(GameObject obj, bool wantsEnabled) { }

	public void UpdateBalloonMesh(float inf) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public Vector3 GetWindAtPos(Vector3 pos) { }

	public void .ctor() { }

	private static void .cctor() { }

}

