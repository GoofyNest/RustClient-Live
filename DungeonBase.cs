public class DungeonNavmesh : FacepunchBehaviour, IServerComponent // TypeDefIndex: 8956
{	// Fields
	public int NavMeshAgentTypeIndex; // 0x18
	[TooltipAttribute] // RVA: 0xC6D40 Offset: 0xC6140 VA: 0x1800C6D40
	public string DefaultAreaName; // 0x20
	public float NavmeshResolutionModifier; // 0x28
	[TooltipAttribute] // RVA: 0xC6DE0 Offset: 0xC61E0 VA: 0x1800C6DE0
	public Bounds Bounds; // 0x2C
	public NavMeshData NavMeshData; // 0x48
	public NavMeshDataInstance NavMeshDataInstance; // 0x50
	public LayerMask LayerMask; // 0x54
	public NavMeshCollectGeometry NavMeshCollectGeometry; // 0x58
	public static List<DungeonNavmesh> Instances; // 0x0

	// Methods

	// RVA: 0xAB0630 Offset: 0xAAFA30 VA: 0x180AB0630
	public void .ctor() { }

	// RVA: 0xAB05D0 Offset: 0xAAF9D0 VA: 0x180AB05D0
	private static void .cctor() { }

}

public class DungeonBaseInfo : LandmarkInfo // TypeDefIndex: 10335
{	// Fields
	internal List<GameObject> Links; // 0x30
	internal List<DungeonBaseFloor> Floors; // 0x38

	// Methods

	// RVA: 0xAAF090 Offset: 0xAAE490 VA: 0x180AAF090
	public float Distance(Vector3 position) { }

	// RVA: 0xAAF170 Offset: 0xAAE570 VA: 0x180AAF170
	public float SqrDistance(Vector3 position) { }

	// RVA: 0xAAEC60 Offset: 0xAAE060 VA: 0x180AAEC60
	public void Add(DungeonBaseLink link) { }

	// RVA: 0xAAEFA0 Offset: 0xAAE3A0 VA: 0x180AAEFA0 Slot: 5
	protected override void Awake() { }

	// RVA: 0xAAF250 Offset: 0xAAE650 VA: 0x180AAF250
	protected void Start() { }

	// RVA: 0xAAF450 Offset: 0xAAE850 VA: 0x180AAF450
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAAF2B0 Offset: 0xAAE6B0 VA: 0x180AAF2B0
	private int <Add>b__4_0(DungeonBaseFloor l, DungeonBaseFloor r) { }

}

public class DungeonBaseFloor // TypeDefIndex: 10336
{	// Fields
	public List<DungeonBaseLink> Links; // 0x10

	// Methods

	// RVA: 0xAAEA90 Offset: 0xAADE90 VA: 0x180AAEA90
	public float Distance(Vector3 position) { }

	// RVA: 0xAAEB60 Offset: 0xAADF60 VA: 0x180AAEB60
	public float SignedDistance(Vector3 position) { }

	// RVA: 0xAAEBF0 Offset: 0xAADFF0 VA: 0x180AAEBF0
	public void .ctor() { }

}

public class DungeonBaseLandmarkInfo : LandmarkInfo // TypeDefIndex: 10337
{	// Fields
	private DungeonBaseLink baseLink; // 0x30
	private Nullable<MapLayer> layer; // 0x38

	// Properties
	public override MapLayer MapLayer { get; }

	// Methods

	// RVA: 0xAAF4F0 Offset: 0xAAE8F0 VA: 0x180AAF4F0 Slot: 5
	protected override void Awake() { }

	// RVA: 0xAAF550 Offset: 0xAAE950 VA: 0x180AAF550 Slot: 4
	public override MapLayer get_MapLayer() { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

public class DungeonBaseLink : MonoBehaviour // TypeDefIndex: 10338
{	// Fields
	public DungeonBaseLinkType Type; // 0x18
	public int Cost; // 0x1C
	public int MaxFloor; // 0x20
	public int MaxCountLocal; // 0x24
	public int MaxCountGlobal; // 0x28
	[TooltipAttribute] // RVA: 0xCC280 Offset: 0xCB680 VA: 0x1800CC280
	public int MaxCountIdentifier; // 0x2C
	internal DungeonBaseInfo Dungeon; // 0x30
	public MeshRenderer[] MapRenderers; // 0x38
	private List<DungeonBaseSocket> sockets; // 0x40
	private List<DungeonVolume> volumes; // 0x48

	// Properties
	internal List<DungeonBaseSocket> Sockets { get; }
	internal List<DungeonVolume> Volumes { get; }

	// Methods

	// RVA: 0xAAFA00 Offset: 0xAAEE00 VA: 0x180AAFA00
	internal List<DungeonBaseSocket> get_Sockets() { }

	// RVA: 0xAAFA90 Offset: 0xAAEE90 VA: 0x180AAFA90
	internal List<DungeonVolume> get_Volumes() { }

	// RVA: 0xAAF820 Offset: 0xAAEC20 VA: 0x180AAF820
	protected void Start() { }

	// RVA: 0xAAF9E0 Offset: 0xAAEDE0 VA: 0x180AAF9E0
	public void .ctor() { }

}

public enum DungeonBaseLinkType // TypeDefIndex: 10339
{	// Fields
	public int value__; // 0x0
	public const DungeonBaseLinkType Room = 0;
	public const DungeonBaseLinkType Corridor = 1;
	public const DungeonBaseLinkType End = 2;

}

public class DungeonBaseSocket : MonoBehaviour // TypeDefIndex: 10340
{	// Fields
	public DungeonBaseSocketType Type; // 0x18
	public bool Male; // 0x1C
	public bool Female; // 0x1D

	// Methods

	// RVA: 0xAAFB20 Offset: 0xAAEF20 VA: 0x180AAFB20
	public void .ctor() { }

}

public enum DungeonBaseSocketType // TypeDefIndex: 10341
{	// Fields
	public int value__; // 0x0
	public const DungeonBaseSocketType Horizontal = 0;
	public const DungeonBaseSocketType Vertical = 1;
	public const DungeonBaseSocketType Pillar = 2;

}

public class DungeonBaseTransition : MonoBehaviour // TypeDefIndex: 10342
{	// Fields
	public DungeonBaseSocketType Type; // 0x18
	public DungeonBaseLinkType Neighbour1; // 0x1C
	public DungeonBaseLinkType Neighbour2; // 0x20

	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class DungeonGridCell : MonoBehaviour // TypeDefIndex: 10343
{	// Fields
	public DungeonGridConnectionType North; // 0x18
	public DungeonGridConnectionType South; // 0x1C
	public DungeonGridConnectionType West; // 0x20
	public DungeonGridConnectionType East; // 0x24
	public DungeonGridConnectionVariant NorthVariant; // 0x28
	public DungeonGridConnectionVariant SouthVariant; // 0x2C
	public DungeonGridConnectionVariant WestVariant; // 0x30
	public DungeonGridConnectionVariant EastVariant; // 0x34
	public GameObjectRef[] AvoidNeighbours; // 0x38
	public MeshRenderer[] MapRenderers; // 0x40

	// Methods

	// RVA: 0xAAFC20 Offset: 0xAAF020 VA: 0x180AAFC20
	public bool ShouldAvoid(uint id) { }

	// RVA: 0xAAFB30 Offset: 0xAAEF30 VA: 0x180AAFB30
	protected void Awake() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public enum DungeonGridConnectionType // TypeDefIndex: 10344
{	// Fields
	public int value__; // 0x0
	public const DungeonGridConnectionType None = 0;
	public const DungeonGridConnectionType TrainTunnel = 1;

}

public enum DungeonGridConnectionVariant // TypeDefIndex: 10345
{	// Fields
	public int value__; // 0x0
	public const DungeonGridConnectionVariant A = 0;
	public const DungeonGridConnectionVariant B = 1;

}

public struct DungeonGridConnectionHash // TypeDefIndex: 10346
{	// Fields
	public bool North; // 0x0
	public bool South; // 0x1
	public bool West; // 0x2
	public bool East; // 0x3

	// Properties
	public int Value { get; }

	// Methods

	// RVA: 0xFC460 Offset: 0xFB860 VA: 0x1800FC460
	public int get_Value() { }

}

public class DungeonGridInfo : LandmarkInfo // TypeDefIndex: 10347
{	// Fields
	[HeaderAttribute] // RVA: 0xCC340 Offset: 0xCB740 VA: 0x1800CC340
	public int CellSize; // 0x30
	public float LinkHeight; // 0x34
	public float LinkRadius; // 0x38
	internal List<GameObject> Links; // 0x40

	// Methods

	// RVA: 0xAAFE00 Offset: 0xAAF200 VA: 0x180AAFE00
	public float Distance(Vector3 position) { }

	// RVA: 0xAB0240 Offset: 0xAAF640 VA: 0x180AB0240
	public float SqrDistance(Vector3 position) { }

	// RVA: 0xAAFEE0 Offset: 0xAAF2E0 VA: 0x180AAFEE0
	public bool IsValidSpawnPosition(Vector3 position) { }

	// RVA: 0xAB0120 Offset: 0xAAF520 VA: 0x180AB0120
	public Vector3 SnapPosition(Vector3 pos) { }

	// RVA: 0xAAFD10 Offset: 0xAAF110 VA: 0x180AAFD10 Slot: 5
	protected override void Awake() { }

	// RVA: 0xAB0320 Offset: 0xAAF720 VA: 0x180AB0320
	protected void Start() { }

	// RVA: 0xAB0380 Offset: 0xAAF780 VA: 0x180AB0380
	public void .ctor() { }

}

public class DungeonGridLink : MonoBehaviour // TypeDefIndex: 10348
{	// Fields
	public Transform UpSocket; // 0x18
	public Transform DownSocket; // 0x20
	public DungeonGridLinkType UpType; // 0x28
	public DungeonGridLinkType DownType; // 0x2C
	public int Priority; // 0x30
	public int Rotation; // 0x34

	// Methods

	// RVA: 0xAB0400 Offset: 0xAAF800 VA: 0x180AB0400
	protected void Start() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public enum DungeonGridLinkType // TypeDefIndex: 10349
{	// Fields
	public int value__; // 0x0
	public const DungeonGridLinkType Default = 0;
	public const DungeonGridLinkType Elevator = 1;
	public const DungeonGridLinkType Transition = 2;

}

public class DungeonVolume : MonoBehaviour // TypeDefIndex: 10350
{	// Fields
	public Bounds bounds; // 0x18

	// Methods

	// RVA: 0xAB0680 Offset: 0xAAFA80 VA: 0x180AB0680
	public OBB GetBounds(Vector3 position, Quaternion rotation) { }

	// RVA: 0xAB0920 Offset: 0xAAFD20 VA: 0x180AB0920
	public OBB GetBounds(Vector3 position, Quaternion rotation, Vector3 extrude) { }

	// RVA: 0xAB0BF0 Offset: 0xAAFFF0 VA: 0x180AB0BF0
	public void .ctor() { }

}

