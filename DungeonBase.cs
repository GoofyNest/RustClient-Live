public class DungeonNavmesh : FacepunchBehaviour, IServerComponent // TypeDefIndex: 8956
{
	public int NavMeshAgentTypeIndex; 
	[TooltipAttribute] 
	public string DefaultAreaName; 
	public float NavmeshResolutionModifier; 
	[TooltipAttribute] 
	public Bounds Bounds; 
	public NavMeshData NavMeshData; 
	public NavMeshDataInstance NavMeshDataInstance; 
	public LayerMask LayerMask; 
	public NavMeshCollectGeometry NavMeshCollectGeometry; 
	public static List<DungeonNavmesh> Instances; 


public void .ctor() { }

private static void .cctor() { }

}

public class DungeonBaseInfo : LandmarkInfo // TypeDefIndex: 10335
{
	internal List<GameObject> Links; 
	internal List<DungeonBaseFloor> Floors; 


public float Distance(Vector3 position) { }

public float SqrDistance(Vector3 position) { }

public void Add(DungeonBaseLink link) { }

protected override void Awake() { }

protected void Start() { }

public void .ctor() { }

	[CompilerGeneratedAttribute] 
private int <Add>b__4_0(DungeonBaseFloor l, DungeonBaseFloor r) { }

}

public class DungeonBaseFloor // TypeDefIndex: 10336
{
	public List<DungeonBaseLink> Links; 


public float Distance(Vector3 position) { }

public float SignedDistance(Vector3 position) { }

public void .ctor() { }

}

public class DungeonBaseLandmarkInfo : LandmarkInfo // TypeDefIndex: 10337
{
	private DungeonBaseLink baseLink; 
	private Nullable<MapLayer> layer; 

public override MapLayer MapLayer { get; }


protected override void Awake() { }

public override MapLayer get_MapLayer() { }

public void .ctor() { }

}

public class DungeonBaseLink : MonoBehaviour // TypeDefIndex: 10338
{
	public DungeonBaseLinkType Type; 
	public int Cost; 
	public int MaxFloor; 
	public int MaxCountLocal; 
	public int MaxCountGlobal; 
	[TooltipAttribute] 
	public int MaxCountIdentifier; 
	internal DungeonBaseInfo Dungeon; 
	public MeshRenderer[] MapRenderers; 
	private List<DungeonBaseSocket> sockets; 
	private List<DungeonVolume> volumes; 

internal List<DungeonBaseSocket> Sockets { get; }
internal List<DungeonVolume> Volumes { get; }


internal List<DungeonBaseSocket> get_Sockets() { }

internal List<DungeonVolume> get_Volumes() { }

protected void Start() { }

public void .ctor() { }

}

public enum DungeonBaseLinkType // TypeDefIndex: 10339
{
	public int value__; 
public const DungeonBaseLinkType Room = 0;
public const DungeonBaseLinkType Corridor = 1;
public const DungeonBaseLinkType End = 2;

}

public class DungeonBaseSocket : MonoBehaviour // TypeDefIndex: 10340
{
	public DungeonBaseSocketType Type; 
	public bool Male; 
	public bool Female; 


public void .ctor() { }

}

public enum DungeonBaseSocketType // TypeDefIndex: 10341
{
	public int value__; 
public const DungeonBaseSocketType Horizontal = 0;
public const DungeonBaseSocketType Vertical = 1;
public const DungeonBaseSocketType Pillar = 2;

}

public class DungeonBaseTransition : MonoBehaviour // TypeDefIndex: 10342
{
	public DungeonBaseSocketType Type; 
	public DungeonBaseLinkType Neighbour1; 
	public DungeonBaseLinkType Neighbour2; 


public void .ctor() { }

}

public class DungeonGridCell : MonoBehaviour // TypeDefIndex: 10343
{
	public DungeonGridConnectionType North; 
	public DungeonGridConnectionType South; 
	public DungeonGridConnectionType West; 
	public DungeonGridConnectionType East; 
	public DungeonGridConnectionVariant NorthVariant; 
	public DungeonGridConnectionVariant SouthVariant; 
	public DungeonGridConnectionVariant WestVariant; 
	public DungeonGridConnectionVariant EastVariant; 
	public GameObjectRef[] AvoidNeighbours; 
	public MeshRenderer[] MapRenderers; 


public bool ShouldAvoid(uint id) { }

protected void Awake() { }

public void .ctor() { }

}

public enum DungeonGridConnectionType // TypeDefIndex: 10344
{
	public int value__; 
public const DungeonGridConnectionType None = 0;
public const DungeonGridConnectionType TrainTunnel = 1;

}

public enum DungeonGridConnectionVariant // TypeDefIndex: 10345
{
	public int value__; 
public const DungeonGridConnectionVariant A = 0;
public const DungeonGridConnectionVariant B = 1;

}

public struct DungeonGridConnectionHash // TypeDefIndex: 10346
{
	public bool North; 
	public bool South; 
	public bool West; 
	public bool East; 

public int Value { get; }


public int get_Value() { }

}

public class DungeonGridInfo : LandmarkInfo // TypeDefIndex: 10347
{
	[HeaderAttribute] 
	public int CellSize; 
	public float LinkHeight; 
	public float LinkRadius; 
	internal List<GameObject> Links; 


public float Distance(Vector3 position) { }

public float SqrDistance(Vector3 position) { }

public bool IsValidSpawnPosition(Vector3 position) { }

public Vector3 SnapPosition(Vector3 pos) { }

protected override void Awake() { }

protected void Start() { }

public void .ctor() { }

}

public class DungeonGridLink : MonoBehaviour // TypeDefIndex: 10348
{
	public Transform UpSocket; 
	public Transform DownSocket; 
	public DungeonGridLinkType UpType; 
	public DungeonGridLinkType DownType; 
	public int Priority; 
	public int Rotation; 


protected void Start() { }

public void .ctor() { }

}

public enum DungeonGridLinkType // TypeDefIndex: 10349
{
	public int value__; 
public const DungeonGridLinkType Default = 0;
public const DungeonGridLinkType Elevator = 1;
public const DungeonGridLinkType Transition = 2;

}

public class DungeonVolume : MonoBehaviour // TypeDefIndex: 10350
{
	public Bounds bounds; 


public OBB GetBounds(Vector3 position, Quaternion rotation) { }

public OBB GetBounds(Vector3 position, Quaternion rotation, Vector3 extrude) { }

public void .ctor() { }

}

