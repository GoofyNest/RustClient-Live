public enum EntityHandling // TypeDefIndex: 1838
{	public int value__; // 0x0
	public const EntityHandling ExpandEntities = 1;
	public const EntityHandling ExpandCharEntities = 2;

}

public class EntityTagHeaderValue : ICloneable // TypeDefIndex: 5765
{	private static readonly EntityTagHeaderValue any; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsWeak>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Tag>k__BackingField; // 0x18

	public bool IsWeak { get; set; }
	public string Tag { get; set; }


	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsWeak() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_IsWeak(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Tag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_Tag(string value) { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool TryParse(string input, out EntityTagHeaderValue parsedValue) { }

	private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out Token t) { }

	internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue> result) { }

	public override string ToString() { }

	private static void .cctor() { }

}

public class Entity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6291
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public BaseNetworkable baseNetworkable; // 0x18
	public BaseEntity baseEntity; // 0x20
	public BasePlayer basePlayer; // 0x28
	public WorldItem worldItem; // 0x30
	public BaseResource resource; // 0x38
	public BuildingBlock buildingBlock; // 0x40
	public Environment environment; // 0x48
	public Corpse corpse; // 0x50
	public ParentInfo parent; // 0x58
	public KeyLock keyLock; // 0x60
	public CodeLock codeLock; // 0x68
	public EntitySlots entitySlots; // 0x70
	public BuildingPrivilege buildingPrivilege; // 0x78
	public StorageBox storageBox; // 0x80
	public HeldEntity heldEntity; // 0x88
	public BaseProjectile baseProjectile; // 0x90
	public BaseNPC baseNPC; // 0x98
	public Loot loot; // 0xA0
	public GenericSpawner genericSpawner; // 0xA8
	public SleepingBag sleepingBag; // 0xB0
	public LootableCorpse lootableCorpse; // 0xB8
	public Sign sign; // 0xC0
	public BaseCombat baseCombat; // 0xC8
	public MapEntity mapEntity; // 0xD0
	public ResearchTable researchTable; // 0xD8
	public DudExplosive dudExplosive; // 0xE0
	public MiningQuarry miningQuarry; // 0xE8
	public BaseVehicle baseVehicle; // 0xF0
	public Helicopter helicopter; // 0xF8
	public Landmine landmine; // 0x100
	public AutoTurret autoturret; // 0x108
	public SphereEntity sphereEntity; // 0x110
	public StabilityEntity stabilityEntity; // 0x118
	public OwnerInfo ownerInfo; // 0x120
	public DecayEntity decayEntity; // 0x128
	public Spawnable spawnable; // 0x130
	public ServerGib servergib; // 0x138
	public VendingMachine vendingMachine; // 0x140
	public SpinnerWheel spinnerWheel; // 0x148
	public Lift lift; // 0x150
	public BradleyAPC bradley; // 0x158
	public WaterWell waterwell; // 0x160
	public Motorboat motorBoat; // 0x168
	public IOEntity ioEntity; // 0x170
	public PuzzleReset puzzleReset; // 0x178
	public RelationshipManager relationshipManager; // 0x180
	public HotAirBalloon hotAirBalloon; // 0x188
	public SAMSite samSite; // 0x190
	public EggHunt eggHunt; // 0x198
	public ArcadeMachine arcadeMachine; // 0x1A0
	public Minicopter miniCopter; // 0x1A8
	public Horse horse; // 0x1B0
	public SmartAlarm smartAlarm; // 0x1B8
	public LightString lightString; // 0x1C0
	public LightDeployer lightDeployer; // 0x1C8
	public RCEntity rcEntity; // 0x1D0
	public ComputerStation computerStation; // 0x1D8
	public GrowableEntity growableEntity; // 0x1E0
	public Composter composter; // 0x1E8
	public ModularVehicle modularVehicle; // 0x1F0
	public ModularCar modularCar; // 0x1F8
	public SimpleUID simpleUID; // 0x200
	public VehicleLift vehicleLift; // 0x208
	public EngineStorage engineStorage; // 0x210
	public VehicleVendor vehicleVendor; // 0x218
	public WaterPool WaterPool; // 0x220
	public Photo photo; // 0x228
	public PhotoFrame photoFrame; // 0x230
	public VehicleModule vehicleModule; // 0x238
	public MixingTable mixingTable; // 0x240
	public ShopKeeper shopKeeper; // 0x248
	public Elevator elevator; // 0x250
	public SkullTrophy skullTrophy; // 0x258
	public Cassette cassette; // 0x260
	public Telephone telephone; // 0x268
	public BoomBox boomBox; // 0x270
	public NeonSign neonSign; // 0x278
	public SubEntityList subEntityList; // 0x280
	public MarketTerminal marketTerminal; // 0x288
	public DeliveryDrone deliveryDrone; // 0x290
	public ReclaimTerminal reclaimTerminal; // 0x298
	public SlotMachine slotMachine; // 0x2A0
	public TrainEngine trainEngine; // 0x2A8
	public CardTable cardTable; // 0x2B0
	public Crane crane; // 0x2B8
	public ConnectedSpeaker connectedSpeaker; // 0x2C0
	public AudioEntity audioEntity; // 0x2C8
	public MicrophoneStand microphoneStand; // 0x2D0
	public Submarine submarine; // 0x2D8
	public SleepingBagCamper sleepingBagCamper; // 0x2E0
	public CamperModule camperModule; // 0x2E8
	public PaintableSign paintableSign; // 0x2F0
	public Whitelist whitelist; // 0x2F8
	public FrankensteinTable FrankensteinTable; // 0x300
	public MLRS mlrs; // 0x308
	public ReclaimManager reclaimManager; // 0x310
	public GameMode gameMode; // 0x318
	public Snowmobile snowmobile; // 0x320
	public bool createdThisFrame; // 0x328
	public PatternFirework patternFirework; // 0x330
	public CargoPlane cargoPlane; // 0x338
	public PaintedItem paintedItem; // 0x340
	public Spray spray; // 0x348
	public BaseTrain baseTrain; // 0x350
	public Zipline zipline; // 0x358
	public ZiplineMountable ziplineMountable; // 0x360
	public ZiplineArrivalPoint ZiplineArrival; // 0x368
	public SprayLine sprayLine; // 0x370
	public CoalingTower coalingTower; // 0x378
	public SimpleFloat simpleFloat; // 0x380


	public static void ResetToPool(Entity instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Entity instance) { }

	public Entity Copy() { }

	public static Entity Deserialize(Stream stream) { }

	public static Entity DeserializeLengthDelimited(Stream stream) { }

	public static Entity DeserializeLength(Stream stream, int length) { }

	public static Entity Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Entity previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Entity Deserialize(byte[] buffer, Entity instance, bool isDelta = False) { }

	public static Entity Deserialize(Stream stream, Entity instance, bool isDelta) { }

	public static Entity DeserializeLengthDelimited(Stream stream, Entity instance, bool isDelta) { }

	public static Entity DeserializeLength(Stream stream, int length, Entity instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Entity instance, Entity previous) { }

	public static void Serialize(Stream stream, Entity instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Entity instance) { }

	public static void SerializeLengthDelimited(Stream stream, Entity instance) { }

	public void .ctor() { }

}

public class EntitySlots : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6296
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint slotLock; // 0x14
	public uint slotFireMod; // 0x18
	public uint slotUpperModification; // 0x1C
	public uint centerDecoration; // 0x20
	public uint lowerCenterDecoration; // 0x24
	public uint storageMonitor; // 0x28


	public static void ResetToPool(EntitySlots instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(EntitySlots instance) { }

	public EntitySlots Copy() { }

	public static EntitySlots Deserialize(Stream stream) { }

	public static EntitySlots DeserializeLengthDelimited(Stream stream) { }

	public static EntitySlots DeserializeLength(Stream stream, int length) { }

	public static EntitySlots Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, EntitySlots previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static EntitySlots Deserialize(byte[] buffer, EntitySlots instance, bool isDelta = False) { }

	public static EntitySlots Deserialize(Stream stream, EntitySlots instance, bool isDelta) { }

	public static EntitySlots DeserializeLengthDelimited(Stream stream, EntitySlots instance, bool isDelta) { }

	public static EntitySlots DeserializeLength(Stream stream, int length, EntitySlots instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, EntitySlots instance, EntitySlots previous) { }

	public static void Serialize(Stream stream, EntitySlots instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(EntitySlots instance) { }

	public static void SerializeLengthDelimited(Stream stream, EntitySlots instance) { }

	public void .ctor() { }

}

public class EntityList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6481
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Entity> entity; // 0x18


	public static void ResetToPool(EntityList instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(EntityList instance) { }

	public EntityList Copy() { }

	public static EntityList Deserialize(Stream stream) { }

	public static EntityList DeserializeLengthDelimited(Stream stream) { }

	public static EntityList DeserializeLength(Stream stream, int length) { }

	public static EntityList Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, EntityList previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static EntityList Deserialize(byte[] buffer, EntityList instance, bool isDelta = False) { }

	public static EntityList Deserialize(Stream stream, EntityList instance, bool isDelta) { }

	public static EntityList DeserializeLengthDelimited(Stream stream, EntityList instance, bool isDelta) { }

	public static EntityList DeserializeLength(Stream stream, int length, EntityList instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, EntityList instance, EntityList previous) { }

	public static void Serialize(Stream stream, EntityList instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(EntityList instance) { }

	public static void SerializeLengthDelimited(Stream stream, EntityList instance) { }

	public void .ctor() { }

}

public class EntityIdList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6504
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> entityIds; // 0x18


	public static void ResetToPool(EntityIdList instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(EntityIdList instance) { }

	public EntityIdList Copy() { }

	public static EntityIdList Deserialize(Stream stream) { }

	public static EntityIdList DeserializeLengthDelimited(Stream stream) { }

	public static EntityIdList DeserializeLength(Stream stream, int length) { }

	public static EntityIdList Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, EntityIdList previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static EntityIdList Deserialize(byte[] buffer, EntityIdList instance, bool isDelta = False) { }

	public static EntityIdList Deserialize(Stream stream, EntityIdList instance, bool isDelta) { }

	public static EntityIdList DeserializeLengthDelimited(Stream stream, EntityIdList instance, bool isDelta) { }

	public static EntityIdList DeserializeLength(Stream stream, int length, EntityIdList instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, EntityIdList instance, EntityIdList previous) { }

	public static void Serialize(Stream stream, EntityIdList instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(EntityIdList instance) { }

	public static void SerializeLengthDelimited(Stream stream, EntityIdList instance) { }

	public void .ctor() { }

}

public static class Entity // TypeDefIndex: 6628
{	private static Dictionary<Transform, IEntity> _dict; // 0x2B0AAA0


	public static void Register(Transform t, IEntity entity) { }

	public static IEntity Get(Transform t) { }

	public static void Unregister(Transform t) { }

	public static void Register(GameObject obj, IEntity entity) { }

	public static IEntity Get(GameObject obj) { }

	public static void Unregister(GameObject obj) { }

	private static void .cctor() { }

}

public enum EntityType // TypeDefIndex: 9425
{	public int value__; // 0x0
	public const EntityType Player = 1;
	public const EntityType NPC = 2;
	public const EntityType WorldItem = 4;
	public const EntityType Corpse = 8;
	public const EntityType TimedExplosive = 16;
	public const EntityType Chair = 32;
	public const EntityType BasePlayerNPC = 64;

}

public class EntityCollisionMessage : EntityComponent<BaseEntity> // TypeDefIndex: 9486
{
	private void OnCollisionEnter(Collision collision) { }

	public void .ctor() { }

}

public class EntityComponent<T> : EntityComponentBase // TypeDefIndex: 9487
{	private T _baseEntity; // 0x0

	protected T baseEntity { get; }


	protected T get_baseEntity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E1840 Offset: 0x15E0C40 VA: 0x1815E1840
	|-EntityComponent<BaseEntity>.get_baseEntity
	|-EntityComponent<BasePlayer>.get_baseEntity
	|-EntityComponent<object>.get_baseEntity
	*/

	protected void UpdateBaseEntity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E16C0 Offset: 0x15E0AC0 VA: 0x1815E16C0
	|-EntityComponent<object>.UpdateBaseEntity
	*/

	protected override BaseEntity GetBaseEntity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13508E0 Offset: 0x134FCE0 VA: 0x1813508E0
	|-EntityComponent<BaseAnimalNPC>.GetBaseEntity
	|-EntityComponent<BaseEntity>.GetBaseEntity
	|-EntityComponent<BaseFishNPC>.GetBaseEntity
	|-EntityComponent<BasePet>.GetBaseEntity
	|-EntityComponent<BasePlayer>.GetBaseEntity
	|-EntityComponent<CH47HelicopterAIController>.GetBaseEntity
	|-EntityComponent<HumanNPC>.GetBaseEntity
	|-EntityComponent<ScarecrowNPC>.GetBaseEntity
	|-EntityComponent<object>.GetBaseEntity
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E1820 Offset: 0x15E0C20 VA: 0x1815E1820
	|-EntityComponent<BaseEntity>..ctor
	|-EntityComponent<BasePlayer>..ctor
	|-EntityComponent<object>..ctor
	*/

}

public class EntityComponentBase : BaseMonoBehaviour // TypeDefIndex: 9488
{	public virtual bool HasMenuOptions { get; }


	protected virtual BaseEntity GetBaseEntity() { }

	public virtual void GetMenuOptions(List<Option> list) { }

	public virtual bool get_HasMenuOptions() { }

	public virtual bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

public class EntityDebug : EntityComponent<BaseEntity> // TypeDefIndex: 9489
{	internal Stopwatch stopwatch; // 0x20


	private void Update() { }

	public void .ctor() { }

}

public class EntityFlag_Animator : EntityFlag_Toggle // TypeDefIndex: 9490
{	public Animator TargetAnimator; // 0x40
	public string ParamName; // 0x48
	public EntityFlag_Animator.AnimatorMode AnimationMode; // 0x50
	public float FloatOnState; // 0x54
	public float FloatOffState; // 0x58
	public int IntegerOnState; // 0x5C
	public int IntegerOffState; // 0x60
	private int cachedHash; // 0x64
	private bool cachedState; // 0x68

	private int ParamHash { get; }


	private int get_ParamHash() { }

	protected override void OnStateToggled(bool state) { }

	public void .ctor() { }

}

public enum EntityFlag_Animator.AnimatorMode // TypeDefIndex: 9491
{	public int value__; // 0x0
	public const EntityFlag_Animator.AnimatorMode Bool = 0;
	public const EntityFlag_Animator.AnimatorMode Float = 1;
	public const EntityFlag_Animator.AnimatorMode Trigger = 2;
	public const EntityFlag_Animator.AnimatorMode Integer = 3;

}

public class EntityFlag_TOD : EntityComponent<BaseEntity> // TypeDefIndex: 9492
{	public BaseEntity.Flags desiredFlag; // 0x20
	public bool onAtNight; // 0x24


	public void .ctor() { }

}

public class EntityFlag_Toggle : EntityComponent<BaseEntity>, IOnPostNetworkUpdate, IOnSendNetworkUpdate, IPrefabPreProcess // TypeDefIndex: 9493
{	public bool runClientside; // 0x20
	public bool runServerside; // 0x21
	public BaseEntity.Flags flag; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UnityEvent onFlagEnabled; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UnityEvent onFlagDisabled; // 0x30
	internal bool hasRunOnce; // 0x38
	internal bool lastHasFlag; // 0x39


	protected void OnDisable() { }

	public void DoUpdate(BaseEntity entity) { }

	protected virtual void OnStateToggled(bool state) { }

	public void OnPostNetworkUpdate(BaseEntity entity) { }

	public void OnSendNetworkUpdate(BaseEntity entity) { }

	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

public class EntityFlag_ToggleNotify : EntityFlag_Toggle // TypeDefIndex: 9494
{	public bool UseEntityParent; // 0x40


	protected override void OnStateToggled(bool state) { }

	public void .ctor() { }

}

public class EntityItem_RotateWhenOn : EntityComponent<BaseEntity>, IOnPostNetworkUpdate // TypeDefIndex: 9496
{	public EntityItem_RotateWhenOn.State on; // 0x20
	public EntityItem_RotateWhenOn.State off; // 0x28
	internal bool currentlyOn; // 0x30
	internal bool stateInitialized; // 0x31
	public BaseEntity.Flags targetFlag; // 0x34
	private Sound movementLoop; // 0x38


	private void OnEnable() { }

	private void DoInitialize(BaseEntity entity) { }

	public void OnPostNetworkUpdate(BaseEntity entity) { }

	public void DoOpen() { }

	public void DoClose() { }

	[IteratorStateMachineAttribute] // RVA: 0x755E0 Offset: 0x749E0 VA: 0x1800755E0
	private IEnumerator RotateTo(EntityItem_RotateWhenOn.State state) { }

	public void .ctor() { }

}

public class EntityItem_RotateWhenOn.State // TypeDefIndex: 9497
{	public Vector3 rotation; // 0x10
	public float initialDelay; // 0x1C
	public float timeToTake; // 0x20
	public AnimationCurve animationCurve; // 0x28
	public string effectOnStart; // 0x30
	public string effectOnFinish; // 0x38
	public SoundDefinition movementLoop; // 0x40
	public float movementLoopFadeOutTime; // 0x48
	public SoundDefinition startSound; // 0x50
	public SoundDefinition stopSound; // 0x58


	public void .ctor() { }

}

private sealed class EntityItem_RotateWhenOn.<RotateTo>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9498
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EntityItem_RotateWhenOn <>4__this; // 0x20
	public EntityItem_RotateWhenOn.State state; // 0x28
	private Quaternion <start>5__2; // 0x30
	private Quaternion <target>5__3; // 0x40
	private bool <effectsStarted>5__4; // 0x50
	private float <TimeTaken>5__5; // 0x54

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

public class EntityTimedDestroy : EntityComponent<BaseEntity> // TypeDefIndex: 9499
{	public float secondsTillDestroy; // 0x20


	public void .ctor() { }

}

public class EntityFuelSystem // TypeDefIndex: 9532
{	private readonly bool isServer; // 0x10
	private readonly bool editorGiveFreeFuel; // 0x11
	private readonly uint fuelStorageID; // 0x14
	public EntityRef<StorageContainer> fuelStorageInstance; // 0x18


	public void .ctor(bool isServer, GameObjectRef fuelStoragePrefab, List<BaseEntity> children, bool editorGiveFreeFuel = True) { }

	public bool IsInFuelInteractionRange(BasePlayer player) { }

	private StorageContainer GetFuelContainer() { }

}

public class EntityLink : Pool.IPooled // TypeDefIndex: 9533
{	public BaseEntity owner; // 0x10
	public Socket_Base socket; // 0x18
	public List<EntityLink> connections; // 0x20
	public int capacity; // 0x28

	public string name { get; }


	public string get_name() { }

	public void Setup(BaseEntity owner, Socket_Base socket) { }

	public void EnterPool() { }

	public void LeavePool() { }

	public bool Contains(EntityLink entity) { }

	public void Add(EntityLink entity) { }

	public void Remove(EntityLink entity) { }

	public void Clear() { }

	public bool IsEmpty() { }

	public bool IsOccupied() { }

	public bool IsMale() { }

	public bool IsFemale() { }

	public bool CanConnect(EntityLink link) { }

	public void .ctor() { }

}

public static class EntityLinkEx // TypeDefIndex: 9534
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void FreeLinks(List<EntityLink> links) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void ClearLinks(List<EntityLink> links) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void AddLinks(List<EntityLink> links, BaseEntity entity, Socket_Base[] sockets) { }

}

public struct EntityRef // TypeDefIndex: 9535
{	internal BaseEntity ent_cached; // 0x0
	internal uint id_cached; // 0x8

	public uint uid { get; set; }


	public bool IsSet() { }

	public bool IsValid(bool serverside) { }

	public void Set(BaseEntity ent) { }

	public BaseEntity Get(bool serverside) { }

	public uint get_uid() { }

	public void set_uid(uint value) { }

}

public struct EntityRef<T> // TypeDefIndex: 9536
{	private EntityRef entityRef; // 0x0

	public bool IsSet { get; }
	public uint uid { get; set; }


	public void .ctor(uint uid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4D30 Offset: 0x1F4130 VA: 0x1801F4D30
	|-EntityRef<LootContainer>..ctor
	|-EntityRef<Marketplace>..ctor
	|-EntityRef<object>..ctor
	|-EntityRef<VendingMachine>..ctor
	*/

	public bool get_IsSet() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4D70 Offset: 0x1F4170 VA: 0x1801F4D70
	|-EntityRef<FishingBobber>.get_IsSet
	|-EntityRef<IOEntity>.get_IsSet
	|-EntityRef<object>.get_IsSet
	*/

	public bool IsValid(bool serverside) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4C40 Offset: 0x1F4040 VA: 0x1801F4C40
	|-EntityRef<BaseEntity>.IsValid
	|-EntityRef<FishingBobber>.IsValid
	|-EntityRef<StorageContainer>.IsValid
	|-EntityRef<object>.IsValid
	|-EntityRef<TrainCar>.IsValid
	|-EntityRef<TrainCarUnloadable>.IsValid
	*/

	public void Set(T entity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4CA0 Offset: 0x1F40A0 VA: 0x1801F4CA0
	|-EntityRef<BaseEntity>.Set
	|-EntityRef<BasePlayer>.Set
	|-EntityRef<FishingBobber>.Set
	|-EntityRef<IOEntity>.Set
	|-EntityRef<PaintedItemStorageEntity>.Set
	|-EntityRef<object>.Set
	*/

	public T Get(bool serverside) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4C30 Offset: 0x1F4030 VA: 0x1801F4C30
	|-EntityRef<BaseEntity>.Get
	|-EntityRef<BasePlayer>.Get
	|-EntityRef<BaseVehicleSeat>.Get
	|-EntityRef<FishingBobber>.Get
	|-EntityRef<IOEntity>.Get
	|-EntityRef<LootContainer>.Get
	|-EntityRef<OreHopper>.Get
	|-EntityRef<PaintedItemStorageEntity>.Get
	|-EntityRef<PercentFullStorageContainer>.Get
	|-EntityRef<StorageContainer>.Get
	|-EntityRef<object>.Get
	|-EntityRef<TrainCar>.Get
	|-EntityRef<TrainCarUnloadable>.Get
	*/

	public bool TryGet(bool serverside, out T entity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4CB0 Offset: 0x1F40B0 VA: 0x1801F4CB0
	|-EntityRef<object>.TryGet
	*/

	public uint get_uid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4D80 Offset: 0x1F4180 VA: 0x1801F4D80
	|-EntityRef<object>.get_uid
	|-EntityRef<TrainCar>.get_uid
	*/

	public void set_uid(uint value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4D90 Offset: 0x1F4190 VA: 0x1801F4D90
	|-EntityRef<BaseEntity>.set_uid
	|-EntityRef<BaseOven>.set_uid
	|-EntityRef<BasePlayer>.set_uid
	|-EntityRef<BaseVehicleSeat>.set_uid
	|-EntityRef<FishingBobber>.set_uid
	|-EntityRef<IOEntity>.set_uid
	|-EntityRef<Locker>.set_uid
	|-EntityRef<OreHopper>.set_uid
	|-EntityRef<PercentFullStorageContainer>.set_uid
	|-EntityRef<StorageContainer>.set_uid
	|-EntityRef<object>.set_uid
	|-EntityRef<TrainCar>.set_uid
	|-EntityRef<TrainCarUnloadable>.set_uid
	*/

}

public class EntityHUDRender : MonoBehaviour // TypeDefIndex: 10921
{	internal BaseEntity cachedEntity; // 0x18


	private void OnWillRenderObject() { }

	public void .ctor() { }

}

public class Entity : ConsoleSystem // TypeDefIndex: 11908
{
	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	public static void debug_lookat(ConsoleSystem.Arg args) { }

	private static TextTable GetEntityTable(Func<Entity.EntityInfo, bool> filter) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static void find_entity(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static void find_id(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static void find_group(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static void find_parent(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static void find_status(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static void find_radius(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static void find_self(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x98E50 Offset: 0x98250 VA: 0x180098E50
	public static void clspawn(string name) { }

	[ClientVar] // RVA: 0x99080 Offset: 0x98480 VA: 0x180099080
	public static void clspawnat(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x99290 Offset: 0x98690 VA: 0x180099290
	public static void clspawnhere(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x994F0 Offset: 0x988F0 VA: 0x1800994F0
	public static void clspawnitem(string name) { }

	[ClientVar] // RVA: 0x99720 Offset: 0x98B20 VA: 0x180099720
	public static void UploadSign(ConsoleSystem.Arg arg) { }

	private static bool IsLookingAtSign(ConsoleSystem.Arg arg, out ISignage signage) { }

	[ClientVar] // RVA: 0x99A60 Offset: 0x98E60 VA: 0x180099A60
	public static void DownloadSign(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

}

private struct Entity.EntityInfo // TypeDefIndex: 11909
{	public BaseNetworkable entity; // 0x0
	public uint entityID; // 0x8
	public uint groupID; // 0xC
	public uint parentID; // 0x10
	public string status; // 0x18


	public void .ctor(BaseNetworkable src) { }

}

private sealed class Entity.<>c__DisplayClass3_0 // TypeDefIndex: 11910
{	public string filter; // 0x10


	public void .ctor() { }

	internal bool <find_entity>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass4_0 // TypeDefIndex: 11911
{	public uint filter; // 0x10


	public void .ctor() { }

	internal bool <find_id>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass5_0 // TypeDefIndex: 11912
{	public uint filter; // 0x10


	public void .ctor() { }

	internal bool <find_group>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass6_0 // TypeDefIndex: 11913
{	public uint filter; // 0x10


	public void .ctor() { }

	internal bool <find_parent>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass7_0 // TypeDefIndex: 11914
{	public string filter; // 0x10


	public void .ctor() { }

	internal bool <find_status>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass8_0 // TypeDefIndex: 11915
{	public BasePlayer player; // 0x10
	public uint filter; // 0x18


	public void .ctor() { }

	internal bool <find_radius>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass9_0 // TypeDefIndex: 11916
{	public uint filter; // 0x10


	public void .ctor() { }

	internal bool <find_self>b__0(Entity.EntityInfo info) { }

}

