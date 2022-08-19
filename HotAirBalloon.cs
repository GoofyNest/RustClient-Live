public class HotAirBalloon : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6344
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float inflationAmount; // 0x14
	public Vector3 velocity; // 0x18

	// Methods

	// RVA: 0x1BF8AD0 Offset: 0x1BF7ED0 VA: 0x181BF8AD0
	public static void ResetToPool(HotAirBalloon instance) { }

	// RVA: 0x1BF8B60 Offset: 0x1BF7F60 VA: 0x181BF8B60
	public void ResetToPool() { }

	// RVA: 0x1BF8980 Offset: 0x1BF7D80 VA: 0x181BF8980 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF7F00 Offset: 0x1BF7300 VA: 0x181BF7F00
	public void CopyTo(HotAirBalloon instance) { }

	// RVA: 0x1BF7F30 Offset: 0x1BF7330 VA: 0x181BF7F30
	public HotAirBalloon Copy() { }

	// RVA: 0x1BF8550 Offset: 0x1BF7950 VA: 0x181BF8550
	public static HotAirBalloon Deserialize(Stream stream) { }

	// RVA: 0x1BF7FB0 Offset: 0x1BF73B0 VA: 0x181BF7FB0
	public static HotAirBalloon DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BF8290 Offset: 0x1BF7690 VA: 0x181BF8290
	public static HotAirBalloon DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BF85D0 Offset: 0x1BF79D0 VA: 0x181BF85D0
	public static HotAirBalloon Deserialize(byte[] buffer) { }

	// RVA: 0x1BF8A90 Offset: 0x1BF7E90 VA: 0x181BF8A90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BF9210 Offset: 0x1BF8610 VA: 0x181BF9210 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BF9230 Offset: 0x1BF8630 VA: 0x181BF9230 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HotAirBalloon previous) { }

	// RVA: 0x1BF8AB0 Offset: 0x1BF7EB0 VA: 0x181BF8AB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BF86F0 Offset: 0x1BF7AF0 VA: 0x181BF86F0
	public static HotAirBalloon Deserialize(byte[] buffer, HotAirBalloon instance, bool isDelta = False) { }

	// RVA: 0x1BF87F0 Offset: 0x1BF7BF0 VA: 0x181BF87F0
	public static HotAirBalloon Deserialize(Stream stream, HotAirBalloon instance, bool isDelta) { }

	// RVA: 0x1BF8030 Offset: 0x1BF7430 VA: 0x181BF8030
	public static HotAirBalloon DeserializeLengthDelimited(Stream stream, HotAirBalloon instance, bool isDelta) { }

	// RVA: 0x1BF8320 Offset: 0x1BF7720 VA: 0x181BF8320
	public static HotAirBalloon DeserializeLength(Stream stream, int length, HotAirBalloon instance, bool isDelta) { }

	// RVA: 0x1BF8BF0 Offset: 0x1BF7FF0 VA: 0x181BF8BF0
	public static void SerializeDelta(Stream stream, HotAirBalloon instance, HotAirBalloon previous) { }

	// RVA: 0x1BF9060 Offset: 0x1BF8460 VA: 0x181BF9060
	public static void Serialize(Stream stream, HotAirBalloon instance) { }

	// RVA: 0x1BF9200 Offset: 0x1BF8600 VA: 0x181BF9200
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BF9210 Offset: 0x1BF8610 VA: 0x181BF9210
	public void ToProto(Stream stream) { }

	// RVA: 0x1BF8F50 Offset: 0x1BF8350 VA: 0x181BF8F50
	public static byte[] SerializeToBytes(HotAirBalloon instance) { }

	// RVA: 0x1BF8EA0 Offset: 0x1BF82A0 VA: 0x181BF8EA0
	public static void SerializeLengthDelimited(Stream stream, HotAirBalloon instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class HotAirBalloon : BaseCombatEntity // TypeDefIndex: 8398
{	// Fields
	private Option __menuOption_Menu_BurnOff; // 0x240
	private Option __menuOption_Menu_BurnOn; // 0x298
	private Option __menuOption_Menu_FuelStorage; // 0x2F0
	protected const BaseEntity.Flags Flag_HasFuel = 16384;
	protected const BaseEntity.Flags Flag_HalfInflated = 128;
	protected const BaseEntity.Flags Flag_FullInflated = 256;
	public Transform centerOfMass; // 0x348
	public Rigidbody myRigidbody; // 0x350
	public Transform buoyancyPoint; // 0x358
	public float liftAmount; // 0x360
	public Transform windSock; // 0x368
	public Transform[] windFlags; // 0x370
	public GameObject staticBalloonDeflated; // 0x378
	public GameObject staticBalloon; // 0x380
	public GameObject animatedBalloon; // 0x388
	public Animator balloonAnimator; // 0x390
	public Transform groundSample; // 0x398
	public float inflationLevel; // 0x3A0
	[HeaderAttribute] // RVA: 0x78380 Offset: 0x77780 VA: 0x180078380
	public GameObjectRef fuelStoragePrefab; // 0x3A8
	public float fuelPerSec; // 0x3B0
	[HeaderAttribute] // RVA: 0x78450 Offset: 0x77850 VA: 0x180078450
	public GameObjectRef storageUnitPrefab; // 0x3B8
	public EntityRef<StorageContainer> storageUnitInstance; // 0x3C0
	[HeaderAttribute] // RVA: 0xCB4E0 Offset: 0xCA8E0 VA: 0x1800CB4E0
	public DamageRenderer damageRenderer; // 0x3D0
	public Transform engineHeight; // 0x3D8
	public GameObject[] killTriggers; // 0x3E0
	private EntityFuelSystem fuelSystem; // 0x3E8
	[ServerVar] // RVA: 0x71DA0 Offset: 0x711A0 VA: 0x180071DA0
	public static float population; // 0x0
	[ServerVar] // RVA: 0xE75D0 Offset: 0xE69D0 VA: 0x1800E75D0
	public static float outsidedecayminutes; // 0x4
	public float windForce; // 0x3F0
	public Vector3 currentWindVec; // 0x3F4
	public Bounds collapsedBounds; // 0x400
	public Bounds raisedBounds; // 0x418
	public GameObject[] balloonColliders; // 0x430
	private float currentClientInflationLevel; // 0x438
	private Vector3 windSockVec; // 0x43C

	// Properties
	public override bool HasMenuOptions { get; }
	public bool IsFullyInflated { get; }

	// Methods

	// RVA: 0x75CDF0 Offset: 0x75C1F0 VA: 0x18075CDF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x75E530 Offset: 0x75D930 VA: 0x18075E530 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x75DBD0 Offset: 0x75CFD0 VA: 0x18075DBD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x75E700 Offset: 0x75DB00 VA: 0x18075E700
	public bool get_IsFullyInflated() { }

	// RVA: 0x75D6E0 Offset: 0x75CAE0 VA: 0x18075D6E0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x75D790 Offset: 0x75CB90 VA: 0x18075D790 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x75E3C0 Offset: 0x75D7C0 VA: 0x18075E3C0
	public bool WaterLogged() { }

	[BaseEntity.Menu] // RVA: 0xE7670 Offset: 0xE6A70 VA: 0x1800E7670
	[BaseEntity.Menu.Description] // RVA: 0xE7670 Offset: 0xE6A70 VA: 0x1800E7670
	[BaseEntity.Menu.Icon] // RVA: 0xE7670 Offset: 0xE6A70 VA: 0x1800E7670
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7670 Offset: 0xE6A70 VA: 0x1800E7670
	// RVA: 0x75DA90 Offset: 0x75CE90 VA: 0x18075DA90
	public void Menu_BurnOn(BasePlayer player) { }

	// RVA: 0x75D960 Offset: 0x75CD60 VA: 0x18075D960
	public bool Menu_BurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE77C0 Offset: 0xE6BC0 VA: 0x1800E77C0
	[BaseEntity.Menu.Description] // RVA: 0xE77C0 Offset: 0xE6BC0 VA: 0x1800E77C0
	[BaseEntity.Menu.Icon] // RVA: 0xE77C0 Offset: 0xE6BC0 VA: 0x1800E77C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE77C0 Offset: 0xE6BC0 VA: 0x1800E77C0
	// RVA: 0x75D910 Offset: 0x75CD10 VA: 0x18075D910
	public void Menu_BurnOff(BasePlayer player) { }

	// RVA: 0x75D850 Offset: 0x75CC50 VA: 0x18075D850
	public bool Menu_BurnOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7960 Offset: 0xE6D60 VA: 0x1800E7960
	[BaseEntity.Menu.Description] // RVA: 0xE7960 Offset: 0xE6D60 VA: 0x1800E7960
	[BaseEntity.Menu.Icon] // RVA: 0xE7960 Offset: 0xE6D60 VA: 0x1800E7960
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7960 Offset: 0xE6D60 VA: 0x1800E7960
	// RVA: 0x75DB90 Offset: 0x75CF90 VA: 0x18075DB90
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x75DAE0 Offset: 0x75CEE0 VA: 0x18075DAE0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x75CCD0 Offset: 0x75C0D0 VA: 0x18075CCD0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x75DF10 Offset: 0x75D310 VA: 0x18075DF10
	public void Update() { }

	// RVA: 0x75DCC0 Offset: 0x75D0C0 VA: 0x18075DCC0
	public void OptimizedEnable(GameObject obj, bool wantsEnabled) { }

	// RVA: 0x75DD10 Offset: 0x75D110 VA: 0x18075DD10
	public void UpdateBalloonMesh(float inf) { }

	// RVA: 0x75CD00 Offset: 0x75C100 VA: 0x18075CD00 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x75D5A0 Offset: 0x75C9A0 VA: 0x18075D5A0
	public Vector3 GetWindAtPos(Vector3 pos) { }

	// RVA: 0x75E470 Offset: 0x75D870 VA: 0x18075E470
	public void .ctor() { }

	// RVA: 0x75E420 Offset: 0x75D820 VA: 0x18075E420
	private static void .cctor() { }

}

