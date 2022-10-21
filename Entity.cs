public enum EntityHandling // TypeDefIndex: 1838
{
	public int value__; 
	public const EntityHandling ExpandEntities = 1;
	public const EntityHandling ExpandCharEntities = 2;

}

public class EntityTagHeaderValue : ICloneable // TypeDefIndex: 5770
{
	private static readonly EntityTagHeaderValue any; 
	[CompilerGeneratedAttribute] 
	private bool <IsWeak>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Tag>k__BackingField; 

	public bool IsWeak { get; set; }
	public string Tag { get; set; }


	internal void .ctor() { }

	[CompilerGeneratedAttribute] 
	public bool get_IsWeak() { }

	[CompilerGeneratedAttribute] 
	internal void set_IsWeak(bool value) { }

	[CompilerGeneratedAttribute] 
	public string get_Tag() { }

	[CompilerGeneratedAttribute] 
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

public class Entity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6296
{
	public bool ShouldPool; 
	private bool _disposed; 
	public BaseNetworkable baseNetworkable; 
	public BaseEntity baseEntity; 
	public BasePlayer basePlayer; 
	public WorldItem worldItem; 
	public BaseResource resource; 
	public BuildingBlock buildingBlock; 
	public Environment environment; 
	public Corpse corpse; 
	public ParentInfo parent; 
	public KeyLock keyLock; 
	public CodeLock codeLock; 
	public EntitySlots entitySlots; 
	public BuildingPrivilege buildingPrivilege; 
	public StorageBox storageBox; 
	public HeldEntity heldEntity; 
	public BaseProjectile baseProjectile; 
	public BaseNPC baseNPC; 
	public Loot loot; 
	public GenericSpawner genericSpawner; 
	public SleepingBag sleepingBag; 
	public LootableCorpse lootableCorpse; 
	public Sign sign; 
	public BaseCombat baseCombat; 
	public MapEntity mapEntity; 
	public ResearchTable researchTable; 
	public DudExplosive dudExplosive; 
	public MiningQuarry miningQuarry; 
	public BaseVehicle baseVehicle; 
	public Helicopter helicopter; 
	public Landmine landmine; 
	public AutoTurret autoturret; 
	public SphereEntity sphereEntity; 
	public StabilityEntity stabilityEntity; 
	public OwnerInfo ownerInfo; 
	public DecayEntity decayEntity; 
	public Spawnable spawnable; 
	public ServerGib servergib; 
	public VendingMachine vendingMachine; 
	public SpinnerWheel spinnerWheel; 
	public Lift lift; 
	public BradleyAPC bradley; 
	public WaterWell waterwell; 
	public Motorboat motorBoat; 
	public IOEntity ioEntity; 
	public PuzzleReset puzzleReset; 
	public RelationshipManager relationshipManager; 
	public HotAirBalloon hotAirBalloon; 
	public SAMSite samSite; 
	public EggHunt eggHunt; 
	public ArcadeMachine arcadeMachine; 
	public Minicopter miniCopter; 
	public Horse horse; 
	public SmartAlarm smartAlarm; 
	public LightString lightString; 
	public LightDeployer lightDeployer; 
	public RCEntity rcEntity; 
	public ComputerStation computerStation; 
	public GrowableEntity growableEntity; 
	public Composter composter; 
	public ModularVehicle modularVehicle; 
	public ModularCar modularCar; 
	public SimpleUID simpleUID; 
	public VehicleLift vehicleLift; 
	public EngineStorage engineStorage; 
	public VehicleVendor vehicleVendor; 
	public WaterPool WaterPool; 
	public Photo photo; 
	public PhotoFrame photoFrame; 
	public VehicleModule vehicleModule; 
	public MixingTable mixingTable; 
	public ShopKeeper shopKeeper; 
	public Elevator elevator; 
	public SkullTrophy skullTrophy; 
	public Cassette cassette; 
	public Telephone telephone; 
	public BoomBox boomBox; 
	public NeonSign neonSign; 
	public SubEntityList subEntityList; 
	public MarketTerminal marketTerminal; 
	public DeliveryDrone deliveryDrone; 
	public ReclaimTerminal reclaimTerminal; 
	public SlotMachine slotMachine; 
	public TrainEngine trainEngine; 
	public CardTable cardTable; 
	public Crane crane; 
	public ConnectedSpeaker connectedSpeaker; 
	public AudioEntity audioEntity; 
	public MicrophoneStand microphoneStand; 
	public Submarine submarine; 
	public SleepingBagCamper sleepingBagCamper; 
	public CamperModule camperModule; 
	public PaintableSign paintableSign; 
	public Whitelist whitelist; 
	public FrankensteinTable FrankensteinTable; 
	public MLRS mlrs; 
	public ReclaimManager reclaimManager; 
	public GameMode gameMode; 
	public Snowmobile snowmobile; 
	public bool createdThisFrame; 
	public PatternFirework patternFirework; 
	public CargoPlane cargoPlane; 
	public PaintedItem paintedItem; 
	public Spray spray; 
	public BaseTrain baseTrain; 
	public Zipline zipline; 
	public ZiplineMountable ziplineMountable; 
	public ZiplineArrivalPoint ZiplineArrival; 
	public SprayLine sprayLine; 
	public CoalingTower coalingTower; 
	public SimpleFloat simpleFloat; 
	public BaseOven baseOven; 


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

public class EntitySlots : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6301
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint slotLock; 
	public uint slotFireMod; 
	public uint slotUpperModification; 
	public uint centerDecoration; 
	public uint lowerCenterDecoration; 
	public uint storageMonitor; 


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

public class EntityList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6487
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<Entity> entity; 


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

public class EntityIdList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6510
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<uint> entityIds; 


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

public static class Entity // TypeDefIndex: 6634
{
	private static Dictionary<Transform, IEntity> _dict; 


	public static void Register(Transform t, IEntity entity) { }

	public static IEntity Get(Transform t) { }

	public static void Unregister(Transform t) { }

	public static void Register(GameObject obj, IEntity entity) { }

	public static IEntity Get(GameObject obj) { }

	public static void Unregister(GameObject obj) { }

	private static void .cctor() { }

}

public enum EntityType // TypeDefIndex: 11146
{
	public int value__; 
	public const EntityType Player = 1;
	public const EntityType NPC = 2;
	public const EntityType WorldItem = 4;
	public const EntityType Corpse = 8;
	public const EntityType TimedExplosive = 16;
	public const EntityType Chair = 32;
	public const EntityType BasePlayerNPC = 64;

}

public class EntityCollisionMessage : EntityComponent<BaseEntity> // TypeDefIndex: 11207
{

	private void OnCollisionEnter(Collision collision) { }

	public void .ctor() { }

}

public class EntityComponent<T> : EntityComponentBase // TypeDefIndex: 11208
{
	private T _baseEntity; 

	protected T baseEntity { get; }


	protected T get_baseEntity() { }
	/* GenericInstMethod :
	|
	|-EntityComponent<BaseEntity>.get_baseEntity
	|-EntityComponent<BasePlayer>.get_baseEntity
	|-EntityComponent<object>.get_baseEntity
	*/

	protected void UpdateBaseEntity() { }
	/* GenericInstMethod :
	|
	|-EntityComponent<object>.UpdateBaseEntity
	*/

	protected override BaseEntity GetBaseEntity() { }
	/* GenericInstMethod :
	|
	|-EntityComponent<BaseEntity>.GetBaseEntity
	|-EntityComponent<BasePlayer>.GetBaseEntity
	|-EntityComponent<object>.GetBaseEntity
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-EntityComponent<BaseEntity>..ctor
	|-EntityComponent<BasePlayer>..ctor
	|-EntityComponent<object>..ctor
	*/

}

public class EntityComponentBase : BaseMonoBehaviour // TypeDefIndex: 11209
{
	public virtual bool HasMenuOptions { get; }


	protected virtual BaseEntity GetBaseEntity() { }

	public virtual void GetMenuOptions(List<Option> list) { }

	public virtual bool get_HasMenuOptions() { }

	public virtual bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

public class EntityDebug : EntityComponent<BaseEntity> // TypeDefIndex: 11210
{
	internal Stopwatch stopwatch; 


	private void Update() { }

	public void .ctor() { }

}

public class EntityFlag_Animator : EntityFlag_Toggle // TypeDefIndex: 11211
{
	public Animator TargetAnimator; 
	public string ParamName; 
	public EntityFlag_Animator.AnimatorMode AnimationMode; 
	public float FloatOnState; 
	public float FloatOffState; 
	public int IntegerOnState; 
	public int IntegerOffState; 
	private int cachedHash; 
	private bool cachedState; 

	private int ParamHash { get; }


	private int get_ParamHash() { }

	protected override void OnStateToggled(bool state) { }

	public void .ctor() { }

}

public enum EntityFlag_Animator.AnimatorMode // TypeDefIndex: 11212
{
	public int value__; 
	public const EntityFlag_Animator.AnimatorMode Bool = 0;
	public const EntityFlag_Animator.AnimatorMode Float = 1;
	public const EntityFlag_Animator.AnimatorMode Trigger = 2;
	public const EntityFlag_Animator.AnimatorMode Integer = 3;

}

public class EntityFlag_TOD : EntityComponent<BaseEntity> // TypeDefIndex: 11213
{
	public BaseEntity.Flags desiredFlag; 
	public bool onAtNight; 


	public void .ctor() { }

}

public class EntityFlag_Toggle : EntityComponent<BaseEntity>, IOnPostNetworkUpdate, IOnSendNetworkUpdate, IPrefabPreProcess // TypeDefIndex: 11214
{
	public bool runClientside; 
	public bool runServerside; 
	public BaseEntity.Flags flag; 
	[SerializeField] 
	private UnityEvent onFlagEnabled; 
	[SerializeField] 
	private UnityEvent onFlagDisabled; 
	internal bool hasRunOnce; 
	internal bool lastHasFlag; 


	protected void OnDisable() { }

	public void DoUpdate(BaseEntity entity) { }

	protected virtual void OnStateToggled(bool state) { }

	public void OnPostNetworkUpdate(BaseEntity entity) { }

	public void OnSendNetworkUpdate(BaseEntity entity) { }

	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

public class EntityFlag_ToggleNotify : EntityFlag_Toggle // TypeDefIndex: 11215
{
	public bool UseEntityParent; 


	protected override void OnStateToggled(bool state) { }

	public void .ctor() { }

}

public class EntityItem_RotateWhenOn : EntityComponent<BaseEntity>, IOnPostNetworkUpdate // TypeDefIndex: 11217
{
	public EntityItem_RotateWhenOn.State on; 
	public EntityItem_RotateWhenOn.State off; 
	internal bool currentlyOn; 
	internal bool stateInitialized; 
	public BaseEntity.Flags targetFlag; 
	private Sound movementLoop; 


	private void OnEnable() { }

	private void DoInitialize(BaseEntity entity) { }

	public void OnPostNetworkUpdate(BaseEntity entity) { }

	public void DoOpen() { }

	public void DoClose() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator RotateTo(EntityItem_RotateWhenOn.State state) { }

	public void .ctor() { }

}

public class EntityItem_RotateWhenOn.State // TypeDefIndex: 11218
{
	public Vector3 rotation; 
	public float initialDelay; 
	public float timeToTake; 
	public AnimationCurve animationCurve; 
	public string effectOnStart; 
	public string effectOnFinish; 
	public SoundDefinition movementLoop; 
	public float movementLoopFadeOutTime; 
	public SoundDefinition startSound; 
	public SoundDefinition stopSound; 


	public void .ctor() { }

}

private sealed class EntityItem_RotateWhenOn.<RotateTo>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11219
{
	private int <>1__state; 
	private object <>2__current; 
	public EntityItem_RotateWhenOn <>4__this; 
	public EntityItem_RotateWhenOn.State state; 
	private Quaternion <start>5__2; 
	private Quaternion <target>5__3; 
	private bool <effectsStarted>5__4; 
	private float <TimeTaken>5__5; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

public class EntityTimedDestroy : EntityComponent<BaseEntity> // TypeDefIndex: 11220
{
	public float secondsTillDestroy; 


	public void .ctor() { }

}

public class EntityFuelSystem // TypeDefIndex: 11253
{
	private readonly bool isServer; 
	private readonly bool editorGiveFreeFuel; 
	private readonly uint fuelStorageID; 
	public EntityRef<StorageContainer> fuelStorageInstance; 


	public void .ctor(bool isServer, GameObjectRef fuelStoragePrefab, List<BaseEntity> children, bool editorGiveFreeFuel = True) { }

	public bool IsInFuelInteractionRange(BasePlayer player) { }

	private StorageContainer GetFuelContainer() { }

}

public class EntityLink : Pool.IPooled // TypeDefIndex: 11254
{
	public BaseEntity owner; 
	public Socket_Base socket; 
	public List<EntityLink> connections; 
	public int capacity; 

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

public static class EntityLinkEx // TypeDefIndex: 11255
{

	[ExtensionAttribute] 
	public static void FreeLinks(List<EntityLink> links) { }

	[ExtensionAttribute] 
	public static void ClearLinks(List<EntityLink> links) { }

	[ExtensionAttribute] 
	public static void AddLinks(List<EntityLink> links, BaseEntity entity, Socket_Base[] sockets) { }

}

public struct EntityRef // TypeDefIndex: 11256
{
	internal BaseEntity ent_cached; 
	internal uint id_cached; 

	public uint uid { get; set; }


	public bool IsSet() { }

	public bool IsValid(bool serverside) { }

	public void Set(BaseEntity ent) { }

	public BaseEntity Get(bool serverside) { }

	public uint get_uid() { }

	public void set_uid(uint value) { }

}

public struct EntityRef<T> // TypeDefIndex: 11257
{
	private EntityRef entityRef; 

	public bool IsSet { get; }
	public uint uid { get; set; }


	public void .ctor(uint uid) { }
	/* GenericInstMethod :
	|
	|-EntityRef<LootContainer>..ctor
	|-EntityRef<Marketplace>..ctor
	|-EntityRef<object>..ctor
	|-EntityRef<VendingMachine>..ctor
	*/

	public bool get_IsSet() { }
	/* GenericInstMethod :
	|
	|-EntityRef<FishingBobber>.get_IsSet
	|-EntityRef<IOEntity>.get_IsSet
	|-EntityRef<object>.get_IsSet
	*/

	public bool IsValid(bool serverside) { }
	/* GenericInstMethod :
	|
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
	|-EntityRef<object>.TryGet
	*/

	public uint get_uid() { }
	/* GenericInstMethod :
	|
	|-EntityRef<object>.get_uid
	|-EntityRef<TrainCar>.get_uid
	*/

	public void set_uid(uint value) { }
	/* GenericInstMethod :
	|
	|-EntityRef<BaseEntity>.set_uid
	|-EntityRef<BaseOven>.set_uid
	|-EntityRef<BasePlayer>.set_uid
	|-EntityRef<BasePortal>.set_uid
	|-EntityRef<BaseVehicleSeat>.set_uid
	|-EntityRef<FishingBobber>.set_uid
	|-EntityRef<IOEntity>.set_uid
	|-EntityRef<Locker>.set_uid
	|-EntityRef<OreHopper>.set_uid
	|-EntityRef<PercentFullStorageContainer>.set_uid
	|-EntityRef<ProceduralDynamicDungeon>.set_uid
	|-EntityRef<StorageContainer>.set_uid
	|-EntityRef<object>.set_uid
	|-EntityRef<TrainCar>.set_uid
	|-EntityRef<TrainCarUnloadable>.set_uid
	*/

}

public class EntityHUDRender : MonoBehaviour // TypeDefIndex: 12654
{
	internal BaseEntity cachedEntity; 


	private void OnWillRenderObject() { }

	public void .ctor() { }

}

public class Entity : ConsoleSystem // TypeDefIndex: 13662
{

	[ClientVar] 
	public static void debug_lookat(ConsoleSystem.Arg args) { }

	private static TextTable GetEntityTable(Func<Entity.EntityInfo, bool> filter) { }

	[ServerVar] 
	[ClientVar] 
	public static void find_entity(ConsoleSystem.Arg args) { }

	[ServerVar] 
	[ClientVar] 
	public static void find_id(ConsoleSystem.Arg args) { }

	[ServerVar] 
	[ClientVar] 
	public static void find_group(ConsoleSystem.Arg args) { }

	[ServerVar] 
	[ClientVar] 
	public static void find_parent(ConsoleSystem.Arg args) { }

	[ServerVar] 
	[ClientVar] 
	public static void find_status(ConsoleSystem.Arg args) { }

	[ServerVar] 
	[ClientVar] 
	public static void find_radius(ConsoleSystem.Arg args) { }

	[ServerVar] 
	[ClientVar] 
	public static void find_self(ConsoleSystem.Arg args) { }

	[ClientVar] 
	public static void clspawn(string name) { }

	[ClientVar] 
	public static void clspawnat(ConsoleSystem.Arg args) { }

	[ClientVar] 
	public static void clspawnhere(ConsoleSystem.Arg args) { }

	[ClientVar] 
	public static void clspawnitem(string name) { }

	[ClientVar] 
	public static void UploadSign(ConsoleSystem.Arg arg) { }

	private static bool IsLookingAtSign(ConsoleSystem.Arg arg, out ISignage signage) { }

	[ClientVar] 
	public static void DownloadSign(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

}

private struct Entity.EntityInfo // TypeDefIndex: 13663
{
	public BaseNetworkable entity; 
	public uint entityID; 
	public uint groupID; 
	public uint parentID; 
	public string status; 


	public void .ctor(BaseNetworkable src) { }

}

private sealed class Entity.<>c__DisplayClass3_0 // TypeDefIndex: 13664
{
	public string filter; 


	public void .ctor() { }

	internal bool <find_entity>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass4_0 // TypeDefIndex: 13665
{
	public uint filter; 


	public void .ctor() { }

	internal bool <find_id>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass5_0 // TypeDefIndex: 13666
{
	public uint filter; 


	public void .ctor() { }

	internal bool <find_group>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass6_0 // TypeDefIndex: 13667
{
	public uint filter; 


	public void .ctor() { }

	internal bool <find_parent>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass7_0 // TypeDefIndex: 13668
{
	public string filter; 


	public void .ctor() { }

	internal bool <find_status>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass8_0 // TypeDefIndex: 13669
{
	public BasePlayer player; 
	public uint filter; 


	public void .ctor() { }

	internal bool <find_radius>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass9_0 // TypeDefIndex: 13670
{
	public uint filter; 


	public void .ctor() { }

	internal bool <find_self>b__0(Entity.EntityInfo info) { }

}

