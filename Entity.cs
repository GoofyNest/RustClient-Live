public enum EntityHandling // TypeDefIndex: 1838
{	// Fields
	public int value__; // 0x0
	public const EntityHandling ExpandEntities = 1;
	public const EntityHandling ExpandCharEntities = 2;

}

public class EntityTagHeaderValue : ICloneable // TypeDefIndex: 5765
{	// Fields
	private static readonly EntityTagHeaderValue any; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsWeak>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Tag>k__BackingField; // 0x18

	// Properties
	public bool IsWeak { get; set; }
	public string Tag { get; set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_IsWeak() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E50 Offset: 0x497250 VA: 0x180497E50
	internal void set_IsWeak(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Tag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void set_Tag(string value) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1082BF0 Offset: 0x1081FF0 VA: 0x181082BF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1082CB0 Offset: 0x10820B0 VA: 0x181082CB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1083090 Offset: 0x1082490 VA: 0x181083090
	public static bool TryParse(string input, out EntityTagHeaderValue parsedValue) { }

	// RVA: 0x1082D50 Offset: 0x1082150 VA: 0x181082D50
	private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1083000 Offset: 0x1082400 VA: 0x181083000
	internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue> result) { }

	// RVA: 0x1082D00 Offset: 0x1082100 VA: 0x181082D00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1083190 Offset: 0x1082590 VA: 0x181083190
	private static void .cctor() { }

}

public class Entity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6291
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x10A0A10 Offset: 0x109FE10 VA: 0x1810A0A10
	public static void ResetToPool(Entity instance) { }

	// RVA: 0x10A25D0 Offset: 0x10A19D0 VA: 0x1810A25D0
	public void ResetToPool() { }

	// RVA: 0x10A0930 Offset: 0x109FD30 VA: 0x1810A0930 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x10972D0 Offset: 0x10966D0 VA: 0x1810972D0
	public void CopyTo(Entity instance) { }

	// RVA: 0x1099120 Offset: 0x1098520 VA: 0x181099120
	public Entity Copy() { }

	// RVA: 0x10A08B0 Offset: 0x109FCB0 VA: 0x1810A08B0
	public static Entity Deserialize(Stream stream) { }

	// RVA: 0x109B890 Offset: 0x109AC90 VA: 0x18109B890
	public static Entity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x109B910 Offset: 0x109AD10 VA: 0x18109B910
	public static Entity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x10A0690 Offset: 0x109FA90 VA: 0x1810A0690
	public static Entity Deserialize(byte[] buffer) { }

	// RVA: 0x10A09C0 Offset: 0x109FDC0 VA: 0x1810A09C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x10AFE20 Offset: 0x10AF220 VA: 0x1810AFE20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x10AFE40 Offset: 0x10AF240 VA: 0x1810AFE40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Entity previous) { }

	// RVA: 0x10A09F0 Offset: 0x109FDF0 VA: 0x1810A09F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x10A07B0 Offset: 0x109FBB0 VA: 0x1810A07B0
	public static Entity Deserialize(byte[] buffer, Entity instance, bool isDelta = False) { }

	// RVA: 0x109E070 Offset: 0x109D470 VA: 0x18109E070
	public static Entity Deserialize(Stream stream, Entity instance, bool isDelta) { }

	// RVA: 0x10991A0 Offset: 0x10985A0 VA: 0x1810991A0
	public static Entity DeserializeLengthDelimited(Stream stream, Entity instance, bool isDelta) { }

	// RVA: 0x109B9A0 Offset: 0x109ADA0 VA: 0x18109B9A0
	public static Entity DeserializeLength(Stream stream, int length, Entity instance, bool isDelta) { }

	// RVA: 0x10A25E0 Offset: 0x10A19E0 VA: 0x1810A25E0
	public static void SerializeDelta(Stream stream, Entity instance, Entity previous) { }

	// RVA: 0x10A9670 Offset: 0x10A8A70 VA: 0x1810A9670
	public static void Serialize(Stream stream, Entity instance) { }

	// RVA: 0x10AFE10 Offset: 0x10AF210 VA: 0x1810AFE10
	public byte[] ToProtoBytes() { }

	// RVA: 0x10AFE20 Offset: 0x10AF220 VA: 0x1810AFE20
	public void ToProto(Stream stream) { }

	// RVA: 0x10A9560 Offset: 0x10A8960 VA: 0x1810A9560
	public static byte[] SerializeToBytes(Entity instance) { }

	// RVA: 0x10A94B0 Offset: 0x10A88B0 VA: 0x1810A94B0
	public static void SerializeLengthDelimited(Stream stream, Entity instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class EntitySlots : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6296
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint slotLock; // 0x14
	public uint slotFireMod; // 0x18
	public uint slotUpperModification; // 0x1C
	public uint centerDecoration; // 0x20
	public uint lowerCenterDecoration; // 0x24
	public uint storageMonitor; // 0x28

	// Methods

	// RVA: 0x1D50770 Offset: 0x1D4FB70 VA: 0x181D50770
	public static void ResetToPool(EntitySlots instance) { }

	// RVA: 0x1D50830 Offset: 0x1D4FC30 VA: 0x181D50830
	public void ResetToPool() { }

	// RVA: 0x1D50060 Offset: 0x1D4F460 VA: 0x181D50060 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF5DF0 Offset: 0x1BF51F0 VA: 0x181BF5DF0
	public void CopyTo(EntitySlots instance) { }

	// RVA: 0x1D4E8D0 Offset: 0x1D4DCD0 VA: 0x181D4E8D0
	public EntitySlots Copy() { }

	// RVA: 0x1D4F400 Offset: 0x1D4E800 VA: 0x181D4F400
	public static EntitySlots Deserialize(Stream stream) { }

	// RVA: 0x1D4ECC0 Offset: 0x1D4E0C0 VA: 0x181D4ECC0
	public static EntitySlots DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D4F080 Offset: 0x1D4E480 VA: 0x181D4F080
	public static EntitySlots DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D4F960 Offset: 0x1D4ED60 VA: 0x181D4F960
	public static EntitySlots Deserialize(byte[] buffer) { }

	// RVA: 0x1D501A0 Offset: 0x1D4F5A0 VA: 0x181D501A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D50F10 Offset: 0x1D50310 VA: 0x181D50F10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D50F30 Offset: 0x1D50330 VA: 0x181D50F30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EntitySlots previous) { }

	// RVA: 0x1D50430 Offset: 0x1D4F830 VA: 0x181D50430 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D4FCF0 Offset: 0x1D4F0F0 VA: 0x181D4FCF0
	public static EntitySlots Deserialize(byte[] buffer, EntitySlots instance, bool isDelta = False) { }

	// RVA: 0x1D4F6D0 Offset: 0x1D4EAD0 VA: 0x181D4F6D0
	public static EntitySlots Deserialize(Stream stream, EntitySlots instance, bool isDelta) { }

	// RVA: 0x1D4E960 Offset: 0x1D4DD60 VA: 0x181D4E960
	public static EntitySlots DeserializeLengthDelimited(Stream stream, EntitySlots instance, bool isDelta) { }

	// RVA: 0x1D4ED40 Offset: 0x1D4E140 VA: 0x181D4ED40
	public static EntitySlots DeserializeLength(Stream stream, int length, EntitySlots instance, bool isDelta) { }

	// RVA: 0x1D508F0 Offset: 0x1D4FCF0 VA: 0x181D508F0
	public static void SerializeDelta(Stream stream, EntitySlots instance, EntitySlots previous) { }

	// RVA: 0x1D50D70 Offset: 0x1D50170 VA: 0x181D50D70
	public static void Serialize(Stream stream, EntitySlots instance) { }

	// RVA: 0x1D50F00 Offset: 0x1D50300 VA: 0x181D50F00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D50F10 Offset: 0x1D50310 VA: 0x181D50F10
	public void ToProto(Stream stream) { }

	// RVA: 0x1D50C60 Offset: 0x1D50060 VA: 0x181D50C60
	public static byte[] SerializeToBytes(EntitySlots instance) { }

	// RVA: 0x1D50BB0 Offset: 0x1D4FFB0 VA: 0x181D50BB0
	public static void SerializeLengthDelimited(Stream stream, EntitySlots instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class EntityList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6481
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Entity> entity; // 0x18

	// Methods

	// RVA: 0x1D4E150 Offset: 0x1D4D550 VA: 0x181D4E150
	public static void ResetToPool(EntityList instance) { }

	// RVA: 0x1D4DFA0 Offset: 0x1D4D3A0 VA: 0x181D4DFA0
	public void ResetToPool() { }

	// RVA: 0x1D4DD20 Offset: 0x1D4D120 VA: 0x181D4DD20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D4D080 Offset: 0x1D4C480 VA: 0x181D4D080
	public void CopyTo(EntityList instance) { }

	// RVA: 0x1D4D1B0 Offset: 0x1D4C5B0 VA: 0x181D4D1B0
	public EntityList Copy() { }

	// RVA: 0x1D4DB80 Offset: 0x1D4CF80 VA: 0x181D4DB80
	public static EntityList Deserialize(Stream stream) { }

	// RVA: 0x1D4D590 Offset: 0x1D4C990 VA: 0x181D4D590
	public static EntityList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D4D860 Offset: 0x1D4CC60 VA: 0x181D4D860
	public static EntityList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D4DC00 Offset: 0x1D4D000 VA: 0x181D4DC00
	public static EntityList Deserialize(byte[] buffer) { }

	// RVA: 0x1D4DF60 Offset: 0x1D4D360 VA: 0x181D4DF60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D4E890 Offset: 0x1D4DC90 VA: 0x181D4E890 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D4E8B0 Offset: 0x1D4DCB0 VA: 0x181D4E8B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EntityList previous) { }

	// RVA: 0x1D4DF80 Offset: 0x1D4D380 VA: 0x181D4DF80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D4D8F0 Offset: 0x1D4CCF0 VA: 0x181D4D8F0
	public static EntityList Deserialize(byte[] buffer, EntityList instance, bool isDelta = False) { }

	// RVA: 0x1D4D9F0 Offset: 0x1D4CDF0 VA: 0x181D4D9F0
	public static EntityList Deserialize(Stream stream, EntityList instance, bool isDelta) { }

	// RVA: 0x1D4D320 Offset: 0x1D4C720 VA: 0x181D4D320
	public static EntityList DeserializeLengthDelimited(Stream stream, EntityList instance, bool isDelta) { }

	// RVA: 0x1D4D610 Offset: 0x1D4CA10 VA: 0x181D4D610
	public static EntityList DeserializeLength(Stream stream, int length, EntityList instance, bool isDelta) { }

	// RVA: 0x1D4E300 Offset: 0x1D4D700 VA: 0x181D4E300
	public static void SerializeDelta(Stream stream, EntityList instance, EntityList previous) { }

	// RVA: 0x1D4E6A0 Offset: 0x1D4DAA0 VA: 0x181D4E6A0
	public static void Serialize(Stream stream, EntityList instance) { }

	// RVA: 0x1D4E880 Offset: 0x1D4DC80 VA: 0x181D4E880
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D4E890 Offset: 0x1D4DC90 VA: 0x181D4E890
	public void ToProto(Stream stream) { }

	// RVA: 0x1D4E590 Offset: 0x1D4D990 VA: 0x181D4E590
	public static byte[] SerializeToBytes(EntityList instance) { }

	// RVA: 0x1D4E4E0 Offset: 0x1D4D8E0 VA: 0x181D4E4E0
	public static void SerializeLengthDelimited(Stream stream, EntityList instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class EntityIdList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6504
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> entityIds; // 0x18

	// Methods

	// RVA: 0x1D4C9D0 Offset: 0x1D4BDD0 VA: 0x181D4C9D0
	public static void ResetToPool(EntityIdList instance) { }

	// RVA: 0x1D4C8F0 Offset: 0x1D4BCF0 VA: 0x181D4C8F0
	public void ResetToPool() { }

	// RVA: 0x1D4C760 Offset: 0x1D4BB60 VA: 0x181D4C760 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D4BA70 Offset: 0x1D4AE70 VA: 0x181D4BA70
	public void CopyTo(EntityIdList instance) { }

	// RVA: 0x1D4BB90 Offset: 0x1D4AF90 VA: 0x181D4BB90
	public EntityIdList Copy() { }

	// RVA: 0x1D4C6E0 Offset: 0x1D4BAE0 VA: 0x181D4C6E0
	public static EntityIdList Deserialize(Stream stream) { }

	// RVA: 0x1D4BF80 Offset: 0x1D4B380 VA: 0x181D4BF80
	public static EntityIdList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D4C000 Offset: 0x1D4B400 VA: 0x181D4C000
	public static EntityIdList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D4C300 Offset: 0x1D4B700 VA: 0x181D4C300
	public static EntityIdList Deserialize(byte[] buffer) { }

	// RVA: 0x1D4C8B0 Offset: 0x1D4BCB0 VA: 0x181D4C8B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D4CF00 Offset: 0x1D4C300 VA: 0x181D4CF00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D4CF20 Offset: 0x1D4C320 VA: 0x181D4CF20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EntityIdList previous) { }

	// RVA: 0x1D4C8D0 Offset: 0x1D4BCD0 VA: 0x181D4C8D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D4C5E0 Offset: 0x1D4B9E0 VA: 0x181D4C5E0
	public static EntityIdList Deserialize(byte[] buffer, EntityIdList instance, bool isDelta = False) { }

	// RVA: 0x1D4C420 Offset: 0x1D4B820 VA: 0x181D4C420
	public static EntityIdList Deserialize(Stream stream, EntityIdList instance, bool isDelta) { }

	// RVA: 0x1D4BCF0 Offset: 0x1D4B0F0 VA: 0x181D4BCF0
	public static EntityIdList DeserializeLengthDelimited(Stream stream, EntityIdList instance, bool isDelta) { }

	// RVA: 0x1D4C090 Offset: 0x1D4B490 VA: 0x181D4C090
	public static EntityIdList DeserializeLength(Stream stream, int length, EntityIdList instance, bool isDelta) { }

	// RVA: 0x1D4CAB0 Offset: 0x1D4BEB0 VA: 0x181D4CAB0
	public static void SerializeDelta(Stream stream, EntityIdList instance, EntityIdList previous) { }

	// RVA: 0x1D4CDB0 Offset: 0x1D4C1B0 VA: 0x181D4CDB0
	public static void Serialize(Stream stream, EntityIdList instance) { }

	// RVA: 0x1D4CEF0 Offset: 0x1D4C2F0 VA: 0x181D4CEF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D4CF00 Offset: 0x1D4C300 VA: 0x181D4CF00
	public void ToProto(Stream stream) { }

	// RVA: 0x1D4CCA0 Offset: 0x1D4C0A0 VA: 0x181D4CCA0
	public static byte[] SerializeToBytes(EntityIdList instance) { }

	// RVA: 0x1D4CBF0 Offset: 0x1D4BFF0 VA: 0x181D4CBF0
	public static void SerializeLengthDelimited(Stream stream, EntityIdList instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public static class Entity // TypeDefIndex: 6628
{	// Fields
	private static Dictionary<Transform, IEntity> _dict; // 0x2B0AAA0

	// Methods

	// RVA: 0x1B9D810 Offset: 0x1B9CC10 VA: 0x181B9D810
	public static void Register(Transform t, IEntity entity) { }

	// RVA: 0x1B9D780 Offset: 0x1B9CB80 VA: 0x181B9D780
	public static IEntity Get(Transform t) { }

	// RVA: 0x1B9DA50 Offset: 0x1B9CE50 VA: 0x181B9DA50
	public static void Unregister(Transform t) { }

	// RVA: 0x1B9D8A0 Offset: 0x1B9CCA0 VA: 0x181B9D8A0
	public static void Register(GameObject obj, IEntity entity) { }

	// RVA: 0x1B9D690 Offset: 0x1B9CA90 VA: 0x181B9D690
	public static IEntity Get(GameObject obj) { }

	// RVA: 0x1B9D980 Offset: 0x1B9CD80 VA: 0x181B9D980
	public static void Unregister(GameObject obj) { }

	// RVA: 0x1B9DAD0 Offset: 0x1B9CED0 VA: 0x181B9DAD0
	private static void .cctor() { }

}

public enum EntityType // TypeDefIndex: 9425
{	// Fields
	public int value__; // 0x0
	public const EntityType Player = 1;
	public const EntityType NPC = 2;
	public const EntityType WorldItem = 4;
	public const EntityType Corpse = 8;
	public const EntityType TimedExplosive = 16;
	public const EntityType Chair = 32;
	public const EntityType BasePlayerNPC = 64;

}

public class EntityCollisionMessage : EntityComponent<BaseEntity> // TypeDefIndex: 9486
{	// Methods

	// RVA: 0x8B3990 Offset: 0x8B2D90 VA: 0x1808B3990
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x8B3B40 Offset: 0x8B2F40 VA: 0x1808B3B40
	public void .ctor() { }

}

public class EntityComponent<T> : EntityComponentBase // TypeDefIndex: 9487
{	// Fields
	private T _baseEntity; // 0x0

	// Properties
	protected T baseEntity { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected T get_baseEntity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E1840 Offset: 0x15E0C40 VA: 0x1815E1840
	|-EntityComponent<BaseEntity>.get_baseEntity
	|-EntityComponent<BasePlayer>.get_baseEntity
	|-EntityComponent<object>.get_baseEntity
	*/

	// RVA: -1 Offset: -1
	protected void UpdateBaseEntity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E16C0 Offset: 0x15E0AC0 VA: 0x1815E16C0
	|-EntityComponent<object>.UpdateBaseEntity
	*/

	// RVA: -1 Offset: -1 Slot: 6
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

	// RVA: -1 Offset: -1
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
{	// Properties
	public virtual bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	protected virtual BaseEntity GetBaseEntity() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	public virtual void GetMenuOptions(List<Option> list) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public virtual bool get_HasMenuOptions() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	public virtual bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

}

public class EntityDebug : EntityComponent<BaseEntity> // TypeDefIndex: 9489
{	// Fields
	internal Stopwatch stopwatch; // 0x20

	// Methods

	// RVA: 0x8B3B80 Offset: 0x8B2F80 VA: 0x1808B3B80
	private void Update() { }

	// RVA: 0x8B3D30 Offset: 0x8B3130 VA: 0x1808B3D30
	public void .ctor() { }

}

public class EntityFlag_Animator : EntityFlag_Toggle // TypeDefIndex: 9490
{	// Fields
	public Animator TargetAnimator; // 0x40
	public string ParamName; // 0x48
	public EntityFlag_Animator.AnimatorMode AnimationMode; // 0x50
	public float FloatOnState; // 0x54
	public float FloatOffState; // 0x58
	public int IntegerOnState; // 0x5C
	public int IntegerOffState; // 0x60
	private int cachedHash; // 0x64
	private bool cachedState; // 0x68

	// Properties
	private int ParamHash { get; }

	// Methods

	// RVA: 0x8B3FA0 Offset: 0x8B33A0 VA: 0x1808B3FA0
	private int get_ParamHash() { }

	// RVA: 0x8B3DA0 Offset: 0x8B31A0 VA: 0x1808B3DA0 Slot: 13
	protected override void OnStateToggled(bool state) { }

	// RVA: 0x8B3F50 Offset: 0x8B3350 VA: 0x1808B3F50
	public void .ctor() { }

}

public enum EntityFlag_Animator.AnimatorMode // TypeDefIndex: 9491
{	// Fields
	public int value__; // 0x0
	public const EntityFlag_Animator.AnimatorMode Bool = 0;
	public const EntityFlag_Animator.AnimatorMode Float = 1;
	public const EntityFlag_Animator.AnimatorMode Trigger = 2;
	public const EntityFlag_Animator.AnimatorMode Integer = 3;

}

public class EntityFlag_TOD : EntityComponent<BaseEntity> // TypeDefIndex: 9492
{	// Fields
	public BaseEntity.Flags desiredFlag; // 0x20
	public bool onAtNight; // 0x24

	// Methods

	// RVA: 0x8B3FD0 Offset: 0x8B33D0 VA: 0x1808B3FD0
	public void .ctor() { }

}

public class EntityFlag_Toggle : EntityComponent<BaseEntity>, IOnPostNetworkUpdate, IOnSendNetworkUpdate, IPrefabPreProcess // TypeDefIndex: 9493
{	// Fields
	public bool runClientside; // 0x20
	public bool runServerside; // 0x21
	public BaseEntity.Flags flag; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UnityEvent onFlagEnabled; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UnityEvent onFlagDisabled; // 0x30
	internal bool hasRunOnce; // 0x38
	internal bool lastHasFlag; // 0x39

	// Methods

	// RVA: 0x8B4260 Offset: 0x8B3660 VA: 0x1808B4260
	protected void OnDisable() { }

	// RVA: 0x8B41E0 Offset: 0x8B35E0 VA: 0x1808B41E0
	public void DoUpdate(BaseEntity entity) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 13
	protected virtual void OnStateToggled(bool state) { }

	// RVA: 0x8B4270 Offset: 0x8B3670 VA: 0x1808B4270 Slot: 10
	public void OnPostNetworkUpdate(BaseEntity entity) { }

	// RVA: 0x8B4360 Offset: 0x8B3760 VA: 0x1808B4360 Slot: 11
	public void OnSendNetworkUpdate(BaseEntity entity) { }

	// RVA: 0x8B43F0 Offset: 0x8B37F0 VA: 0x1808B43F0 Slot: 12
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x8B44C0 Offset: 0x8B38C0 VA: 0x1808B44C0
	public void .ctor() { }

}

public class EntityFlag_ToggleNotify : EntityFlag_Toggle // TypeDefIndex: 9494
{	// Fields
	public bool UseEntityParent; // 0x40

	// Methods

	// RVA: 0x8B4010 Offset: 0x8B3410 VA: 0x1808B4010 Slot: 13
	protected override void OnStateToggled(bool state) { }

	// RVA: 0x8B41D0 Offset: 0x8B35D0 VA: 0x1808B41D0
	public void .ctor() { }

}

public class EntityItem_RotateWhenOn : EntityComponent<BaseEntity>, IOnPostNetworkUpdate // TypeDefIndex: 9496
{	// Fields
	public EntityItem_RotateWhenOn.State on; // 0x20
	public EntityItem_RotateWhenOn.State off; // 0x28
	internal bool currentlyOn; // 0x30
	internal bool stateInitialized; // 0x31
	public BaseEntity.Flags targetFlag; // 0x34
	private Sound movementLoop; // 0x38

	// Methods

	// RVA: 0x8B4B80 Offset: 0x8B3F80 VA: 0x1808B4B80
	private void OnEnable() { }

	// RVA: 0x8B4990 Offset: 0x8B3D90 VA: 0x1808B4990
	private void DoInitialize(BaseEntity entity) { }

	// RVA: 0x8B4C20 Offset: 0x8B4020 VA: 0x1808B4C20 Slot: 10
	public void OnPostNetworkUpdate(BaseEntity entity) { }

	// RVA: 0x8B4AA0 Offset: 0x8B3EA0 VA: 0x1808B4AA0
	public void DoOpen() { }

	// RVA: 0x8B48B0 Offset: 0x8B3CB0 VA: 0x1808B48B0
	public void DoClose() { }

	[IteratorStateMachineAttribute] // RVA: 0x755E0 Offset: 0x749E0 VA: 0x1800755E0
	// RVA: 0x8B4FD0 Offset: 0x8B43D0 VA: 0x1808B4FD0
	private IEnumerator RotateTo(EntityItem_RotateWhenOn.State state) { }

	// RVA: 0x8B5060 Offset: 0x8B4460 VA: 0x1808B5060
	public void .ctor() { }

}

public class EntityItem_RotateWhenOn.State // TypeDefIndex: 9497
{	// Fields
	public Vector3 rotation; // 0x10
	public float initialDelay; // 0x1C
	public float timeToTake; // 0x20
	public AnimationCurve animationCurve; // 0x28
	public string effectOnStart; // 0x30
	public string effectOnFinish; // 0x38
	public SoundDefinition movementLoop; // 0x40
	public float movementLoopFadeOutTime; // 0x48
	public SoundDefinition startSound; // 0x50
	public SoundDefinition stopSound; // 0x58

	// Methods

	// RVA: 0x8C6B80 Offset: 0x8C5F80 VA: 0x1808C6B80
	public void .ctor() { }

}

private sealed class EntityItem_RotateWhenOn.<RotateTo>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9498
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EntityItem_RotateWhenOn <>4__this; // 0x20
	public EntityItem_RotateWhenOn.State state; // 0x28
	private Quaternion <start>5__2; // 0x30
	private Quaternion <target>5__3; // 0x40
	private bool <effectsStarted>5__4; // 0x50
	private float <TimeTaken>5__5; // 0x54

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x8C8BD0 Offset: 0x8C7FD0 VA: 0x1808C8BD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C9330 Offset: 0x8C8730 VA: 0x1808C9330 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class EntityTimedDestroy : EntityComponent<BaseEntity> // TypeDefIndex: 9499
{	// Fields
	public float secondsTillDestroy; // 0x20

	// Methods

	// RVA: 0x8B5C30 Offset: 0x8B5030 VA: 0x1808B5C30
	public void .ctor() { }

}

public class EntityFuelSystem // TypeDefIndex: 9532
{	// Fields
	private readonly bool isServer; // 0x10
	private readonly bool editorGiveFreeFuel; // 0x11
	private readonly uint fuelStorageID; // 0x14
	public EntityRef<StorageContainer> fuelStorageInstance; // 0x18

	// Methods

	// RVA: 0x8B46F0 Offset: 0x8B3AF0 VA: 0x1808B46F0
	public void .ctor(bool isServer, GameObjectRef fuelStoragePrefab, List<BaseEntity> children, bool editorGiveFreeFuel = True) { }

	// RVA: 0x8B45C0 Offset: 0x8B39C0 VA: 0x1808B45C0
	public bool IsInFuelInteractionRange(BasePlayer player) { }

	// RVA: 0x8B4560 Offset: 0x8B3960 VA: 0x1808B4560
	private StorageContainer GetFuelContainer() { }

}

public class EntityLink : Pool.IPooled // TypeDefIndex: 9533
{	// Fields
	public BaseEntity owner; // 0x10
	public Socket_Base socket; // 0x18
	public List<EntityLink> connections; // 0x20
	public int capacity; // 0x28

	// Properties
	public string name { get; }

	// Methods

	// RVA: 0x8B5970 Offset: 0x8B4D70 VA: 0x1808B5970
	public string get_name() { }

	// RVA: 0x8B5890 Offset: 0x8B4C90 VA: 0x1808B5890
	public void Setup(BaseEntity owner, Socket_Base socket) { }

	// RVA: 0x8B5720 Offset: 0x8B4B20 VA: 0x1808B5720 Slot: 4
	public void EnterPool() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public void LeavePool() { }

	// RVA: 0x8B56C0 Offset: 0x8B4AC0 VA: 0x1808B56C0
	public bool Contains(EntityLink entity) { }

	// RVA: 0x8B5330 Offset: 0x8B4730 VA: 0x1808B5330
	public void Add(EntityLink entity) { }

	// RVA: 0x8B5830 Offset: 0x8B4C30 VA: 0x1808B5830
	public void Remove(EntityLink entity) { }

	// RVA: 0x8B55D0 Offset: 0x8B49D0 VA: 0x1808B55D0
	public void Clear() { }

	// RVA: 0x8B5760 Offset: 0x8B4B60 VA: 0x1808B5760
	public bool IsEmpty() { }

	// RVA: 0x8B57E0 Offset: 0x8B4BE0 VA: 0x1808B57E0
	public bool IsOccupied() { }

	// RVA: 0x8B57C0 Offset: 0x8B4BC0 VA: 0x1808B57C0
	public bool IsMale() { }

	// RVA: 0x8B57A0 Offset: 0x8B4BA0 VA: 0x1808B57A0
	public bool IsFemale() { }

	// RVA: 0x8B5390 Offset: 0x8B4790 VA: 0x1808B5390
	public bool CanConnect(EntityLink link) { }

	// RVA: 0x8B58F0 Offset: 0x8B4CF0 VA: 0x1808B58F0
	public void .ctor() { }

}

public static class EntityLinkEx // TypeDefIndex: 9534
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B5260 Offset: 0x8B4660 VA: 0x1808B5260
	public static void FreeLinks(List<EntityLink> links) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B51D0 Offset: 0x8B45D0 VA: 0x1808B51D0
	public static void ClearLinks(List<EntityLink> links) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B50A0 Offset: 0x8B44A0 VA: 0x1808B50A0
	public static void AddLinks(List<EntityLink> links, BaseEntity entity, Socket_Base[] sockets) { }

}

public struct EntityRef // TypeDefIndex: 9535
{	// Fields
	internal BaseEntity ent_cached; // 0x0
	internal uint id_cached; // 0x8

	// Properties
	public uint uid { get; set; }

	// Methods

	// RVA: 0xF9930 Offset: 0xF8D30 VA: 0x1800F9930
	public bool IsSet() { }

	// RVA: 0xF9940 Offset: 0xF8D40 VA: 0x1800F9940
	public bool IsValid(bool serverside) { }

	// RVA: 0xF9960 Offset: 0xF8D60 VA: 0x1800F9960
	public void Set(BaseEntity ent) { }

	// RVA: 0xF9920 Offset: 0xF8D20 VA: 0x1800F9920
	public BaseEntity Get(bool serverside) { }

	// RVA: 0xF99B0 Offset: 0xF8DB0 VA: 0x1800F99B0
	public uint get_uid() { }

	// RVA: 0xF99F0 Offset: 0xF8DF0 VA: 0x1800F99F0
	public void set_uid(uint value) { }

}

public struct EntityRef<T> // TypeDefIndex: 9536
{	// Fields
	private EntityRef entityRef; // 0x0

	// Properties
	public bool IsSet { get; }
	public uint uid { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(uint uid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4D30 Offset: 0x1F4130 VA: 0x1801F4D30
	|-EntityRef<LootContainer>..ctor
	|-EntityRef<Marketplace>..ctor
	|-EntityRef<object>..ctor
	|-EntityRef<VendingMachine>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsSet() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4D70 Offset: 0x1F4170 VA: 0x1801F4D70
	|-EntityRef<FishingBobber>.get_IsSet
	|-EntityRef<IOEntity>.get_IsSet
	|-EntityRef<object>.get_IsSet
	*/

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
	public bool TryGet(bool serverside, out T entity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4CB0 Offset: 0x1F40B0 VA: 0x1801F4CB0
	|-EntityRef<object>.TryGet
	*/

	// RVA: -1 Offset: -1
	public uint get_uid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4D80 Offset: 0x1F4180 VA: 0x1801F4D80
	|-EntityRef<object>.get_uid
	|-EntityRef<TrainCar>.get_uid
	*/

	// RVA: -1 Offset: -1
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
{	// Fields
	internal BaseEntity cachedEntity; // 0x18

	// Methods

	// RVA: 0x8B4750 Offset: 0x8B3B50 VA: 0x1808B4750
	private void OnWillRenderObject() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class Entity : ConsoleSystem // TypeDefIndex: 11908
{	// Methods

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x6DC2A0 Offset: 0x6DB6A0 VA: 0x1806DC2A0
	public static void debug_lookat(ConsoleSystem.Arg args) { }

	// RVA: 0x6DA700 Offset: 0x6D9B00 VA: 0x1806DA700
	private static TextTable GetEntityTable(Func<Entity.EntityInfo, bool> filter) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DC5B0 Offset: 0x6DB9B0 VA: 0x1806DC5B0
	public static void find_entity(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DC9E0 Offset: 0x6DBDE0 VA: 0x1806DC9E0
	public static void find_id(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DC7D0 Offset: 0x6DBBD0 VA: 0x1806DC7D0
	public static void find_group(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DCBF0 Offset: 0x6DBFF0 VA: 0x1806DCBF0
	public static void find_parent(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DD2F0 Offset: 0x6DC6F0 VA: 0x1806DD2F0
	public static void find_status(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DCE00 Offset: 0x6DC200 VA: 0x1806DCE00
	public static void find_radius(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DD080 Offset: 0x6DC480 VA: 0x1806DD080
	public static void find_self(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x98E50 Offset: 0x98250 VA: 0x180098E50
	// RVA: 0x6DB960 Offset: 0x6DAD60 VA: 0x1806DB960
	public static void clspawn(string name) { }

	[ClientVar] // RVA: 0x99080 Offset: 0x98480 VA: 0x180099080
	// RVA: 0x6DBB90 Offset: 0x6DAF90 VA: 0x1806DBB90
	public static void clspawnat(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x99290 Offset: 0x98690 VA: 0x180099290
	// RVA: 0x6DBDE0 Offset: 0x6DB1E0 VA: 0x1806DBDE0
	public static void clspawnhere(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x994F0 Offset: 0x988F0 VA: 0x1800994F0
	// RVA: 0x6DC180 Offset: 0x6DB580 VA: 0x1806DC180
	public static void clspawnitem(string name) { }

	[ClientVar] // RVA: 0x99720 Offset: 0x98B20 VA: 0x180099720
	// RVA: 0x6DB360 Offset: 0x6DA760 VA: 0x1806DB360
	public static void UploadSign(ConsoleSystem.Arg arg) { }

	// RVA: 0x6DAFC0 Offset: 0x6DA3C0 VA: 0x1806DAFC0
	private static bool IsLookingAtSign(ConsoleSystem.Arg arg, out ISignage signage) { }

	[ClientVar] // RVA: 0x99A60 Offset: 0x98E60 VA: 0x180099A60
	// RVA: 0x6DA3B0 Offset: 0x6D97B0 VA: 0x1806DA3B0
	public static void DownloadSign(ConsoleSystem.Arg arg) { }

	// RVA: 0x6DB900 Offset: 0x6DAD00 VA: 0x1806DB900
	public void .ctor() { }

}

private struct Entity.EntityInfo // TypeDefIndex: 11909
{	// Fields
	public BaseNetworkable entity; // 0x0
	public uint entityID; // 0x8
	public uint groupID; // 0xC
	public uint parentID; // 0x10
	public string status; // 0x18

	// Methods

	// RVA: 0xF3F40 Offset: 0xF3340 VA: 0x1800F3F40
	public void .ctor(BaseNetworkable src) { }

}

private sealed class Entity.<>c__DisplayClass3_0 // TypeDefIndex: 11910
{	// Fields
	public string filter; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6E5C70 Offset: 0x6E5070 VA: 0x1806E5C70
	internal bool <find_entity>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass4_0 // TypeDefIndex: 11911
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6E5DC0 Offset: 0x6E51C0 VA: 0x1806E5DC0
	internal bool <find_id>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass5_0 // TypeDefIndex: 11912
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6E5DE0 Offset: 0x6E51E0 VA: 0x1806E5DE0
	internal bool <find_group>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass6_0 // TypeDefIndex: 11913
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6E5E00 Offset: 0x6E5200 VA: 0x1806E5E00
	internal bool <find_parent>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass7_0 // TypeDefIndex: 11914
{	// Fields
	public string filter; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6E5E20 Offset: 0x6E5220 VA: 0x1806E5E20
	internal bool <find_status>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass8_0 // TypeDefIndex: 11915
{	// Fields
	public BasePlayer player; // 0x10
	public uint filter; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6E5E80 Offset: 0x6E5280 VA: 0x1806E5E80
	internal bool <find_radius>b__0(Entity.EntityInfo info) { }

}

private sealed class Entity.<>c__DisplayClass9_0 // TypeDefIndex: 11916
{	// Fields
	public uint filter; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6E5DC0 Offset: 0x6E51C0 VA: 0x1806E5DC0
	internal bool <find_self>b__0(Entity.EntityInfo info) { }

}

