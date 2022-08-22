public class AIDesign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6540
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> availableStates; // 0x18
	public List<AIStateContainer> stateContainers; // 0x20
	public int defaultStateContainer; // 0x28
	public string description; // 0x30
	public int scope; // 0x38
	public int intialViewStateID; // 0x3C


	public static void ResetToPool(AIDesign instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AIDesign instance) { }

	public AIDesign Copy() { }

	public static AIDesign Deserialize(Stream stream) { }

	public static AIDesign DeserializeLengthDelimited(Stream stream) { }

	public static AIDesign DeserializeLength(Stream stream, int length) { }

	public static AIDesign Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AIDesign previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AIDesign Deserialize(byte[] buffer, AIDesign instance, bool isDelta = False) { }

	public static AIDesign Deserialize(Stream stream, AIDesign instance, bool isDelta) { }

	public static AIDesign DeserializeLengthDelimited(Stream stream, AIDesign instance, bool isDelta) { }

	public static AIDesign DeserializeLength(Stream stream, int length, AIDesign instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AIDesign instance, AIDesign previous) { }

	public static void Serialize(Stream stream, AIDesign instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AIDesign instance) { }

	public static void SerializeLengthDelimited(Stream stream, AIDesign instance) { }

	public void .ctor() { }

}

public class AIStateContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6541
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int id; // 0x14
	public int state; // 0x18
	public List<AIEventData> events; // 0x20
	public int inputMemorySlot; // 0x28


	public static void ResetToPool(AIStateContainer instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AIStateContainer instance) { }

	public AIStateContainer Copy() { }

	public static AIStateContainer Deserialize(Stream stream) { }

	public static AIStateContainer DeserializeLengthDelimited(Stream stream) { }

	public static AIStateContainer DeserializeLength(Stream stream, int length) { }

	public static AIStateContainer Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AIStateContainer previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AIStateContainer Deserialize(byte[] buffer, AIStateContainer instance, bool isDelta = False) { }

	public static AIStateContainer Deserialize(Stream stream, AIStateContainer instance, bool isDelta) { }

	public static AIStateContainer DeserializeLengthDelimited(Stream stream, AIStateContainer instance, bool isDelta) { }

	public static AIStateContainer DeserializeLength(Stream stream, int length, AIStateContainer instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AIStateContainer instance, AIStateContainer previous) { }

	public static void Serialize(Stream stream, AIStateContainer instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AIStateContainer instance) { }

	public static void SerializeLengthDelimited(Stream stream, AIStateContainer instance) { }

	public void .ctor() { }

}

public class AIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6542
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int eventType; // 0x14
	public int triggerStateContainer; // 0x18
	public bool inverted; // 0x1C
	public int inputMemorySlot; // 0x20
	public int outputMemorySlot; // 0x24
	public int id; // 0x28
	public TimerAIEventData timerData; // 0x30
	public PlayerDetectedAIEventData playerDetectedData; // 0x38
	public HealthBelowAIEventData healthBelowData; // 0x40
	public InRangeAIEventData inRangeData; // 0x48
	public HungerAboveAIEventData hungerAboveData; // 0x50
	public TirednessAboveAIEventData tirednessAboveData; // 0x58
	public ThreatDetectedAIEventData threatDetectedData; // 0x60
	public TargetDetectedAIEventData targetDetectedData; // 0x68
	public AmmoBelowAIEventData ammoBelowData; // 0x70
	public ChanceAIEventData chanceData; // 0x78
	public TimeSinceThreatAIEventData timeSinceThreatData; // 0x80
	public AggressionTimerAIEventData aggressionTimerData; // 0x88
	public InRangeOfHomeAIEventData inRangeOfHomeData; // 0x90


	public static void ResetToPool(AIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AIEventData instance) { }

	public AIEventData Copy() { }

	public static AIEventData Deserialize(Stream stream) { }

	public static AIEventData DeserializeLengthDelimited(Stream stream) { }

	public static AIEventData DeserializeLength(Stream stream, int length) { }

	public static AIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AIEventData Deserialize(byte[] buffer, AIEventData instance, bool isDelta = False) { }

	public static AIEventData Deserialize(Stream stream, AIEventData instance, bool isDelta) { }

	public static AIEventData DeserializeLengthDelimited(Stream stream, AIEventData instance, bool isDelta) { }

	public static AIEventData DeserializeLength(Stream stream, int length, AIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AIEventData instance, AIEventData previous) { }

	public static void Serialize(Stream stream, AIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, AIEventData instance) { }

	public void .ctor() { }

}

public class NPCTalking : NPCShopKeeper, IConversationProvider // TypeDefIndex: 8425
{	private Option __menuOption_Menu_Talk; // 0x7F0
	public ConversationData[] conversations; // 0x848
	public NPCTalking.NPCConversationResultAction[] conversationResultActions; // 0x850

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public int GetConversationIndex(string conversationName) { }

	public virtual string GetConversationStartSpeech(BasePlayer player) { }

	public ConversationData GetConversation(string conversationName) { }

	public ConversationData GetConversation(int index) { }

	public virtual ConversationData GetConversationFor(BasePlayer player) { }

	public bool ProviderBusy() { }

	[BaseEntity.Menu] // RVA: 0x7BAD0 Offset: 0x7AED0 VA: 0x18007BAD0
	[BaseEntity.Menu.Description] // RVA: 0x7BAD0 Offset: 0x7AED0 VA: 0x18007BAD0
	[BaseEntity.Menu.Icon] // RVA: 0x7BAD0 Offset: 0x7AED0 VA: 0x18007BAD0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7BAD0 Offset: 0x7AED0 VA: 0x18007BAD0
	public void Menu_Talk(BasePlayer player) { }

	public bool Menu_Talk_ShowIf(BasePlayer player) { }

	public void DoAction(string action) { }

	public Vector3 GetConversationWorldOrigin() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_StartConversation(BaseEntity.RPCMessage msg) { }

	public void EndConversation(bool fromServer) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_ForceSpeechNode(BaseEntity.RPCMessage msg) { }

	public void ResponsePressed(int index) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_EndConversation(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

}

public class NPCTalking.NPCConversationResultAction // TypeDefIndex: 8426
{	public string action; // 0x10
	public int scrapCost; // 0x18
	public string broadcastMessage; // 0x20
	public float broadcastRange; // 0x28


	public void .ctor() { }

}

public class NPCVendingOrder : ScriptableObject // TypeDefIndex: 8722
{	public NPCVendingOrder.Entry[] orders; // 0x18


	public void .ctor() { }

}

public class NPCVendingOrder.Entry // TypeDefIndex: 8723
{	public ItemDefinition sellItem; // 0x10
	public int sellItemAmount; // 0x18
	public bool sellItemAsBP; // 0x1C
	public ItemDefinition currencyItem; // 0x20
	public int currencyAmount; // 0x28
	public bool currencyAsBP; // 0x2C
	[TooltipAttribute] // RVA: 0x77710 Offset: 0x76B10 VA: 0x180077710
	public int weight; // 0x30
	public int refillAmount; // 0x34
	public float refillDelay; // 0x38


	public void .ctor() { }

}

public class NPCVendingOrderManifest : ScriptableObject // TypeDefIndex: 8724
{	public NPCVendingOrder[] orderList; // 0x18


	public int GetIndex(NPCVendingOrder sample) { }

	public NPCVendingOrder GetFromIndex(int index) { }

	public void .ctor() { }

}

public class NPCVendingMachine : VendingMachine // TypeDefIndex: 8725
{	public NPCVendingOrder vendingOrders; // 0x5C8


	public override bool ShouldShowLootMenus() { }

	public override bool ShouldShowAdminPanel() { }

	protected override bool CanRotate() { }

	public override bool CanPlayerAdmin(BasePlayer player) { }

	public void .ctor() { }

}

public class NPCDwelling : BaseEntity // TypeDefIndex: 8821
{	public NPCSpawner npcSpawner; // 0x168
	public float NPCSpawnChance; // 0x170
	public SpawnGroup[] spawnGroups; // 0x178
	public AIMovePoint[] movePoints; // 0x180
	public AICoverPoint[] coverPoints; // 0x188


	public void .ctor() { }

}

public class NPCMissionProvider : NPCTalking, IMissionProvider // TypeDefIndex: 8849
{	public MissionManifest manifest; // 0x858


	public uint ProviderID() { }

	public Vector3 ProviderPosition() { }

	public BaseEntity Entity() { }

	public void .ctor() { }

}

public class NPCShopKeeper : NPCPlayer // TypeDefIndex: 8850
{	public EntityRef invisibleVendingMachineRef; // 0x7D8
	public InvisibleVendingMachine machine; // 0x7E8


	public InvisibleVendingMachine GetVendingMachine() { }

	public void OnDrawGizmos() { }

	public override void UpdateProtectionFromClothing() { }

	public void .ctor() { }

}

public class NPCPlayerCorpse : PlayerCorpse // TypeDefIndex: 8867
{
	public void .ctor() { }

}

public class AICoverPoint : AIPoint // TypeDefIndex: 8903
{	public float coverDot; // 0x20


	public void OnDrawGizmos() { }

	public void .ctor() { }

}

public class AICoverPointTool : MonoBehaviour // TypeDefIndex: 8904
{
	[ContextMenu] // RVA: 0xC1E00 Offset: 0xC1200 VA: 0x1800C1E00
	public void PlaceCoverPoints() { }

	private AICoverPointTool.TestResult TestPoint(Vector3 pos) { }

	private void PlacePoint(AICoverPointTool.TestResult result) { }

	private void PlacePoint(Vector3 pos, Vector3 dir) { }

	public bool HitsCover(Ray ray, int layerMask, float maxDistance) { }

	public void .ctor() { }

}

private struct AICoverPointTool.TestResult // TypeDefIndex: 8905
{	public Vector3 Position; // 0x0
	public bool Valid; // 0xC
	public bool Forward; // 0xD
	public bool Right; // 0xE
	public bool Backward; // 0xF
	public bool Left; // 0x10

}

public class AIInformationCell // TypeDefIndex: 8906
{	public Bounds BoundingBox; // 0x10
	public List<AIInformationCell> NeighbourCells; // 0x28
	public AIInformationCellContents<AIMovePoint> MovePoints; // 0x30
	public AIInformationCellContents<AICoverPoint> CoverPoints; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <X>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <Z>k__BackingField; // 0x44

	public int X { get; }
	public int Z { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_X() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_Z() { }

	public void .ctor(Bounds bounds, GameObject root, int x, int z) { }

	public void DebugDraw(Color color, bool points, float scale = 1) { }

}

public class AIInformationCellContents<T> // TypeDefIndex: 8907
{	public HashSet<T> Items; // 0x0

	public int Count { get; }
	public bool Empty { get; }


	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55390 Offset: 0xD54790 VA: 0x180D55390
	|-AIInformationCellContents<object>.get_Count
	*/

	public bool get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3850 Offset: 0x15D2C50 VA: 0x1815D3850
	|-AIInformationCellContents<object>.get_Empty
	*/

	public void Init(Bounds cellBounds, GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3650 Offset: 0x15D2A50 VA: 0x1815D3650
	|-AIInformationCellContents<AICoverPoint>.Init
	|-AIInformationCellContents<AIMovePoint>.Init
	|-AIInformationCellContents<object>.Init
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3620 Offset: 0x15D2A20 VA: 0x1815D3620
	|-AIInformationCellContents<object>.Clear
	*/

	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D35F0 Offset: 0x15D29F0 VA: 0x1815D35F0
	|-AIInformationCellContents<object>.Add
	*/

	public void Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D37A0 Offset: 0x15D2BA0 VA: 0x1815D37A0
	|-AIInformationCellContents<object>.Remove
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D37D0 Offset: 0x15D2BD0 VA: 0x1815D37D0
	|-AIInformationCellContents<AICoverPoint>..ctor
	|-AIInformationCellContents<AIMovePoint>..ctor
	|-AIInformationCellContents<object>..ctor
	*/

}

public class AIInformationGrid : MonoBehaviour // TypeDefIndex: 8908
{	public int CellSize; // 0x18
	public Bounds BoundingBox; // 0x1C
	public AIInformationCell[] Cells; // 0x38
	private Vector3 origin; // 0x40
	private int xCellCount; // 0x4C
	private int zCellCount; // 0x50
	private const int maxPointResults = 2048;
	private AIMovePoint[] movePointResults; // 0x58
	private AICoverPoint[] coverPointResults; // 0x60
	private const int maxCellResults = 512;
	private AIInformationCell[] resultCells; // 0x68


	[ContextMenu] // RVA: 0xC35F0 Offset: 0xC29F0 VA: 0x1800C35F0
	public void Init() { }

	private int GetIndex(int x, int z) { }

	public AIInformationCell CellAt(int x, int z) { }

	public AIMovePoint[] GetMovePointsInRange(Vector3 position, float maxRange, out int pointCount) { }

	public AICoverPoint[] GetCoverPointsInRange(Vector3 position, float maxRange, out int pointCount) { }

	public AIInformationCell[] GetCellsInRange(Vector3 position, float maxRange, out int cellCount) { }

	public AIInformationCell GetCell(Vector3 position) { }

	public void OnDrawGizmos() { }

	public void DebugDraw() { }

	public void .ctor() { }

}

public class AIInformationGridTester : MonoBehaviour // TypeDefIndex: 8909
{	public AIInformationGrid Grid; // 0x18
	public float Range; // 0x20


	public void OnDrawGizmos() { }

	public void .ctor() { }

}

public class AIInformationZone : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 8910
{	public bool ShouldSleepAI; // 0x18
	public bool Virtual; // 0x19
	public bool UseCalculatedCoverDistances; // 0x1A
	public static List<AIInformationZone> zones; // 0x0
	public List<AICoverPoint> coverPoints; // 0x20
	public List<AIMovePoint> movePoints; // 0x28
	private AICoverPoint[] coverPointArray; // 0x30
	private AIMovePoint[] movePointArray; // 0x38
	public List<NavMeshLink> navMeshLinks; // 0x40
	public List<AIMovePointPath> paths; // 0x48
	public Bounds bounds; // 0x50
	private AIInformationGrid grid; // 0x68


	public void .ctor() { }

	private static void .cctor() { }

}

public class AIMovePoint : AIPoint // TypeDefIndex: 8911
{	public ListDictionary<AIMovePoint, float> distances; // 0x20
	public ListDictionary<AICoverPoint, float> distancesToCover; // 0x28
	public float radius; // 0x30
	public float WaitTime; // 0x34
	public List<Transform> LookAtPoints; // 0x38


	public void OnDrawGizmos() { }

	public void DrawLookAtPoints() { }

	public void Clear() { }

	public void AddLookAtPoint(Transform transform) { }

	public bool HasLookAtPoints() { }

	public Transform GetRandomLookAtPoint() { }

	public void .ctor() { }

}

public class AIMovePoint.DistTo // TypeDefIndex: 8912
{	public float distance; // 0x10
	public AIMovePoint target; // 0x18


	public void .ctor() { }

}

public class AIMovePointPath : MonoBehaviour // TypeDefIndex: 8913
{	public Color DebugPathColor; // 0x18
	public AIMovePointPath.Mode LoopMode; // 0x28
	public List<AIMovePoint> Points; // 0x30


	public void Clear() { }

	public void AddPoint(AIMovePoint point) { }

	public AIMovePoint FindNearestPoint(Vector3 position) { }

	public int FindNearestPointIndex(Vector3 position) { }

	public AIMovePoint GetPointAtIndex(int index) { }

	public int GetNextPointIndex(int currentPointIndex, ref AIMovePointPath.PathDirection pathDirection) { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	[ContextMenu] // RVA: 0xC3690 Offset: 0xC2A90 VA: 0x1800C3690
	public void AddChildPoints() { }

	public void .ctor() { }

}

public enum AIMovePointPath.Mode // TypeDefIndex: 8914
{	public int value__; // 0x0
	public const AIMovePointPath.Mode Loop = 0;
	public const AIMovePointPath.Mode Reverse = 1;

}

public enum AIMovePointPath.PathDirection // TypeDefIndex: 8915
{	public int value__; // 0x0
	public const AIMovePointPath.PathDirection Forwards = 0;
	public const AIMovePointPath.PathDirection Backwards = 1;

}

public class AIPoint : BaseMonoBehaviour // TypeDefIndex: 8916
{	private BaseEntity currentUser; // 0x18


	public bool InUse() { }

	public bool IsUsedBy(BaseEntity user) { }

	public bool CanBeUsedBy(BaseEntity user) { }

	public void SetUsedBy(BaseEntity user, float duration = 5) { }

	public void SetUsedBy(BaseEntity user) { }

	public void ClearUsed() { }

	public void ClearIfUsedBy(BaseEntity user) { }

	public void .ctor() { }

}

public class AITraversalArea : TriggerBase // TypeDefIndex: 8917
{	public Transform entryPoint1; // 0x30
	public Transform entryPoint2; // 0x38
	public AITraversalWaitPoint[] waitPoints; // 0x40
	public Bounds movementArea; // 0x48
	public Transform activeEntryPoint; // 0x60
	public float nextFreeTime; // 0x68


	public void OnValidate() { }

	internal override GameObject InterestedInObject(GameObject obj) { }

	public bool CanTraverse(BaseEntity ent) { }

	public Transform GetClosestEntry(Vector3 position) { }

	public Transform GetFarthestEntry(Vector3 position) { }

	public void SetBusyFor(float dur = 1) { }

	public bool CanUse(Vector3 dirFrom) { }

	internal override void OnEntityEnter(BaseEntity ent) { }

	public AITraversalWaitPoint GetEntryPointNear(Vector3 pos) { }

	public bool EntityFilter(BaseEntity ent) { }

	internal override void OnEntityLeave(BaseEntity ent) { }

	public void OnDrawGizmos() { }

	public void .ctor() { }

}

public class AITraversalWaitPoint : MonoBehaviour // TypeDefIndex: 8918
{	public float nextFreeTime; // 0x18


	public bool Occupied() { }

	public void Occupy(float dur = 1) { }

	public void .ctor() { }

}

public class AnimalBrain : BaseAIBrain<BaseAnimalNPC> // TypeDefIndex: 8919
{
	public void .ctor() { }

}

public class AnimalRagdoll : Ragdoll // TypeDefIndex: 8926
{	public SkinnedMeshRenderer[] bodyRenderers; // 0x98
	public SkinnedMeshRenderer[] hairRenderers; // 0xA0


	public void .ctor() { }

}

public class AIThinkManager : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 8929
{
	public void .ctor() { }

}

public class ScientistBrain : BaseAIBrain<HumanNPC> // TypeDefIndex: 8933
{
	public void .ctor() { }

}

public class ScientistNPC : HumanNPC, IAIMounted // TypeDefIndex: 8934
{	public GameObjectRef[] RadioChatterEffects; // 0x850
	public GameObjectRef[] DeathEffects; // 0x858
	public string deathStatName; // 0x860
	public Vector2 IdleChatterRepeatRange; // 0x868
	public ScientistNPC.RadioChatterType radioChatterType; // 0x870


	public void .ctor() { }

}

public enum ScientistNPC.RadioChatterType // TypeDefIndex: 8935
{	public int value__; // 0x0
	public const ScientistNPC.RadioChatterType NONE = 0;
	public const ScientistNPC.RadioChatterType Idle = 1;
	public const ScientistNPC.RadioChatterType Alert = 2;

}

public class NPCPlayer : BasePlayer // TypeDefIndex: 8938
{	public AIInformationZone VirtualInfoZone; // 0x788
	public Vector3 finalDestination; // 0x790
	private float randomOffset; // 0x79C
	private Vector3 spawnPos; // 0x7A0
	public PlayerInventoryProperties[] loadouts; // 0x7B0
	public LayerMask movementMask; // 0x7B8
	public bool LegacyNavigation; // 0x7BC
	public NavMeshAgent NavAgent; // 0x7C0
	public float damageScale; // 0x7C8
	public float shortRange; // 0x7CC
	public float attackLengthMaxShortRangeScale; // 0x7D0

	public override bool IsNpc { get; }


	public override bool get_IsNpc() { }

	public void .ctor() { }

}

public class NPCNavigator : BaseNavigator // TypeDefIndex: 8953
{
	public void .ctor() { }

}

public class NPCPlayerNavigator : BaseNavigator // TypeDefIndex: 8954
{
	public void .ctor() { }

}

public class NPCPlayerNavigatorTester : BaseMonoBehaviour // TypeDefIndex: 8955
{	public BasePathNode TargetNode; // 0x18
	private BasePathNode currentNode; // 0x20


	public void .ctor() { }

}

public enum AIState // TypeDefIndex: 8964
{	public int value__; // 0x0
	public const AIState None = 0;
	public const AIState Idle = 1;
	public const AIState Roam = 2;
	public const AIState Chase = 3;
	public const AIState Cover = 4;
	public const AIState Combat = 5;
	public const AIState Mounted = 6;
	public const AIState Exfil = 7;
	public const AIState Patrol = 8;
	public const AIState Orbit = 9;
	public const AIState Egress = 10;
	public const AIState Land = 11;
	public const AIState DropCrate = 12;
	public const AIState MoveTowards = 13;
	public const AIState Flee = 14;
	public const AIState Attack = 15;
	public const AIState Sleep = 16;
	public const AIState Reload = 17;
	public const AIState TakeCover = 18;
	public const AIState Dismounted = 19;
	public const AIState FollowPath = 20;
	public const AIState NavigateHome = 21;
	public const AIState CombatStationary = 22;
	public const AIState Cooldown = 23;
	public const AIState MoveToPoint = 24;

}

public enum AIThinkMode // TypeDefIndex: 8965
{	public int value__; // 0x0
	public const AIThinkMode FixedUpdate = 0;
	public const AIThinkMode Interval = 1;

}

public class AimConeUtil // TypeDefIndex: 8968
{
	public static Vector3 GetModifiedAimConeDirection(float aimCone, Vector3 inputVec, bool anywhereInside = True) { }

	public static Quaternion GetAimConeQuat(float aimCone) { }

	public void .ctor() { }

}

public class AnimalSkin : MonoBehaviour, IClientComponent // TypeDefIndex: 9111
{	public SkinnedMeshRenderer[] animalMesh; // 0x18
	public AnimalMultiSkin[] animalSkins; // 0x20
	private Model model; // 0x28
	public bool dontRandomizeOnStart; // 0x30


	private void Start() { }

	public void ChangeSkin(int iSkin) { }

	public void .ctor() { }

}

public class AnimalMultiSkin // TypeDefIndex: 9112
{	public Material[] multiSkin; // 0x10


	public void .ctor() { }

}

public class AnimalAnimation : MonoBehaviour, IClientComponent // TypeDefIndex: 9113
{	public BaseEntity Entity; // 0x18
	public BaseNpc Target; // 0x20
	public Animator Animator; // 0x28
	public MaterialEffect FootstepEffects; // 0x30
	public Transform[] Feet; // 0x38
	public SoundDefinition saddleMovementSoundDef; // 0x40
	public SoundDefinition saddleMovementSoundDefWood; // 0x48
	public SoundDefinition saddleMovementSoundDefRoadsign; // 0x50
	public AnimationCurve saddleMovementGainCurve; // 0x58
	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public string BaseFolder; // 0x60
	public const BaseEntity.Flags Flag_WoodArmor = 2048;
	public const BaseEntity.Flags Flag_RoadsignArmor = 16384;
	private float lastThinkTime; // 0x68
	private Vector3 previousPosition; // 0x6C
	private float previousRotationYaw; // 0x78
	private bool wasSleeping; // 0x7C


	private void Update() { }

	public bool ShouldPlayFootstep(AnimationEvent evt) { }

	private void FrontLeftFootstep(AnimationEvent evt) { }

	private void FrontRightFootstep(AnimationEvent evt) { }

	private void BackLeftFootstep(AnimationEvent evt) { }

	private void BackRightFootstep(AnimationEvent evt) { }

	private void Footstep(Transform tx) { }

	private void DoEffect(string effect) { }

	private void PlayEffect(string effect) { }

	public void PlaySound(string soundName) { }

	public void PlaySoundDef(SoundDefinition def) { }

	private void PlaySaddleMovementSound() { }

	public void .ctor() { }

}

public class AnimalFootIK : MonoBehaviour // TypeDefIndex: 9115
{	public Transform[] Feet; // 0x18
	public Animator animator; // 0x20
	public float maxWeightDistance; // 0x28
	public float minWeightDistance; // 0x2C
	public float actualFootOffset; // 0x30


	public bool GroundSample(Vector3 origin, out RaycastHit hit) { }

	public void Start() { }

	public AvatarIKGoal GoalFromIndex(int index) { }

	private void OnAnimatorIK(int layerIndex) { }

	public void .ctor() { }

}

public class NPCFootstepEffects : BaseFootstepEffect // TypeDefIndex: 9354
{	public string impactEffectDirectory; // 0x30
	public Transform frontLeftFoot; // 0x38
	public Transform frontRightFoot; // 0x40
	public Transform backLeftFoot; // 0x48
	public Transform backRightFoot; // 0x50


	private void FrontLeftFootstep() { }

	private void FrontRightFootstep() { }

	private void BackLeftFootstep() { }

	private void BackRightFootstep() { }

	private void Footstep(Vector3 vFootPos) { }

	private void SetupFootstep(GameObject effect) { }

	public void .ctor() { }

}

public class AIBrainSenses // TypeDefIndex: 9376
{
	public void .ctor() { }

}

public class AIDesignSO : BaseScriptableObject // TypeDefIndex: 9377
{	public string Filename; // 0x20


	public void .ctor() { }

}

public class AIDesign // TypeDefIndex: 9378
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AIDesignScope <Scope>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Description>k__BackingField; // 0x18
	public List<AIState> AvailableStates; // 0x20
	public int DefaultStateContainerID; // 0x28
	private Dictionary<int, AIStateContainer> stateContainers; // 0x30

	public AIDesignScope Scope { get; set; }
	public string Description { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public AIDesignScope get_Scope() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Scope(AIDesignScope value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Description(string value) { }

	public void SetAvailableStates(List<AIState> states) { }

	public void Load(AIDesign design, BaseEntity owner) { }

	private void InitStateContainers(AIDesign design, BaseEntity owner) { }

	public AIStateContainer GetDefaultStateContainer() { }

	public AIStateContainer GetStateContainerByID(int id) { }

	public AIDesign ToProto(int currentStateID) { }

	public void .ctor() { }

}

public static class AIDesigns // TypeDefIndex: 9379
{	public const string DesignFolderPath = "cfg/ai/";
	private static Dictionary<string, AIDesign> designs; // 0x2B0AA98


	public static AIDesign GetByNameOrInstance(string designName, AIDesign entityDesign) { }

	public static void RefreshCache(string designName, AIDesign design) { }

	private static AIDesign GetByName(string designName) { }

	private static void .cctor() { }

}

public enum AIEventType // TypeDefIndex: 9380
{	public int value__; // 0x0
	public const AIEventType Timer = 0;
	public const AIEventType PlayerDetected = 1;
	public const AIEventType StateError = 2;
	public const AIEventType Attacked = 3;
	public const AIEventType StateFinished = 4;
	public const AIEventType InAttackRange = 5;
	public const AIEventType HealthBelow = 6;
	public const AIEventType InRange = 7;
	public const AIEventType PerformedAttack = 8;
	public const AIEventType TirednessAbove = 9;
	public const AIEventType HungerAbove = 10;
	public const AIEventType ThreatDetected = 11;
	public const AIEventType TargetDetected = 12;
	public const AIEventType AmmoBelow = 13;
	public const AIEventType BestTargetDetected = 14;
	public const AIEventType IsVisible = 15;
	public const AIEventType AttackTick = 16;
	public const AIEventType IsMounted = 17;
	public const AIEventType And = 18;
	public const AIEventType Chance = 19;
	public const AIEventType TargetLost = 20;
	public const AIEventType TimeSinceThreat = 21;
	public const AIEventType OnPositionMemorySet = 22;
	public const AIEventType AggressionTimer = 23;
	public const AIEventType Reloading = 24;
	public const AIEventType InRangeOfHome = 25;

}

public class AIEvents // TypeDefIndex: 9381
{	public AIMemory Memory; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <CurrentInputMemorySlot>k__BackingField; // 0x18
	private List<BaseAIEvent> events; // 0x20
	private IAIEventListener eventListener; // 0x28
	private AIBrainSenses senses; // 0x30
	private int currentEventIndex; // 0x38
	private bool inBlock; // 0x3C

	public int CurrentInputMemorySlot { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_CurrentInputMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_CurrentInputMemorySlot(int value) { }

	public void Init(IAIEventListener listener, AIStateContainer stateContainer, BaseEntity owner, AIBrainSenses senses) { }

	private void RemoveAll() { }

	private void AddStateEvents(List<BaseAIEvent> events, BaseEntity owner) { }

	private void Add(BaseAIEvent aiEvent) { }

	public void Tick(float deltaTime, StateStatus stateStatus) { }

	private int FindNextEventBlock() { }

	public void .ctor() { }

}

public class AIMemory // TypeDefIndex: 9382
{	public AIMemoryBank<BaseEntity> Entity; // 0x10
	public AIMemoryBank<Vector3> Position; // 0x18
	public AIMemoryBank<AIPoint> AIPoint; // 0x20


	public void .ctor() { }

}

public class AIMemoryBank<T> // TypeDefIndex: 9387
{	private MemoryBankType type; // 0x0
	private T[] slots; // 0x0
	private float[] slotSetTimestamps; // 0x0
	private int slotCount; // 0x0


	public void .ctor(MemoryBankType type, int slots) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3D10 Offset: 0x15D3110 VA: 0x1815D3D10
	|-AIMemoryBank<AIPoint>..ctor
	|-AIMemoryBank<BaseEntity>..ctor
	|-AIMemoryBank<object>..ctor
	|-AIMemoryBank<Vector3>..ctor
	*/

	public void Init(MemoryBankType type, int slots) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D39C0 Offset: 0x15D2DC0 VA: 0x1815D39C0
	|-AIMemoryBank<object>.Init
	|
	|-RVA: 0x15D3A70 Offset: 0x15D2E70 VA: 0x1815D3A70
	|-AIMemoryBank<Vector3>.Init
	*/

	public void Set(T item, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3BE0 Offset: 0x15D2FE0 VA: 0x1815D3BE0
	|-AIMemoryBank<BaseEntity>.Set
	|-AIMemoryBank<object>.Set
	|
	|-RVA: 0x15D3C70 Offset: 0x15D3070 VA: 0x1815D3C70
	|-AIMemoryBank<Vector3>.Set
	*/

	public T Get(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D38F0 Offset: 0x15D2CF0 VA: 0x1815D38F0
	|-AIMemoryBank<BaseEntity>.Get
	|-AIMemoryBank<object>.Get
	|
	|-RVA: 0x15D3940 Offset: 0x15D2D40 VA: 0x1815D3940
	|-AIMemoryBank<Vector3>.Get
	*/

	public float GetTimeSinceSet(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3880 Offset: 0x15D2C80 VA: 0x1815D3880
	|-AIMemoryBank<object>.GetTimeSinceSet
	|-AIMemoryBank<Vector3>.GetTimeSinceSet
	*/

	public void Remove(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D3B20 Offset: 0x15D2F20 VA: 0x1815D3B20
	|-AIMemoryBank<object>.Remove
	|
	|-RVA: 0x15D3B80 Offset: 0x15D2F80 VA: 0x1815D3B80
	|-AIMemoryBank<Vector3>.Remove
	*/

}

public class AIStateContainer // TypeDefIndex: 9421
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AIState <State>k__BackingField; // 0x14
	public List<BaseAIEvent> Events; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <InputMemorySlot>k__BackingField; // 0x20

	public int ID { get; set; }
	public AIState State { get; set; }
	public int InputMemorySlot { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_ID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public AIState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_State(AIState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_InputMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_InputMemorySlot(int value) { }

	public void Init(AIStateContainer container, BaseEntity owner) { }

	public AIStateContainer ToProto() { }

	public void .ctor() { }

}

public enum AIDesignScope // TypeDefIndex: 9424
{	public int value__; // 0x0
	public const AIDesignScope Default = 0;
	public const AIDesignScope EntityServerWide = 1;
	public const AIDesignScope EntityInstance = 2;

}

public class NPCAutoTurret : AutoTurret // TypeDefIndex: 9576
{	public Transform centerMuzzle; // 0x768
	public Transform muzzleLeft; // 0x770
	public Transform muzzleRight; // 0x778
	private bool useLeftMuzzle; // 0x780


	public void .ctor() { }

}

public class AIHelicopterAnimation : MonoBehaviour // TypeDefIndex: 9597
{	public PatrolHelicopterAI _ai; // 0x18
	public float swayAmount; // 0x20
	public float lastStrafeScalar; // 0x24
	public float lastForwardBackScalar; // 0x28
	public float degreeMax; // 0x2C
	public Vector3 lastPosition; // 0x30
	public float oldMoveSpeed; // 0x3C
	public float smoothRateOfChange; // 0x40
	public float flareAmount; // 0x44


	public void .ctor() { }

}

public class NPCSpawner : SpawnGroup // TypeDefIndex: 10003
{	public int AdditionalLOSBlockingLayer; // 0x48
	public MonumentNavMesh monumentNavMesh; // 0x50
	public bool shouldFillOnSpawn; // 0x58
	[HeaderAttribute] // RVA: 0xACFD0 Offset: 0xAC3D0 VA: 0x1800ACFD0
	public AIInformationZone VirtualInfoZone; // 0x60
	[HeaderAttribute] // RVA: 0xAE350 Offset: 0xAD750 VA: 0x1800AE350
	public AIMovePointPath Path; // 0x68
	public BasePath AStarGraph; // 0x70
	[HeaderAttribute] // RVA: 0xAE7A0 Offset: 0xADBA0 VA: 0x1800AE7A0
	public bool UseStatModifiers; // 0x78
	public float SenseRange; // 0x7C
	public float TargetLostRange; // 0x80
	public float AttackRangeMultiplier; // 0x84
	public float ListenRange; // 0x88
	public float CanUseHealingItemsChance; // 0x8C
	[HeaderAttribute] // RVA: 0xAFC00 Offset: 0xAF000 VA: 0x1800AFC00
	public PlayerInventoryProperties[] Loadouts; // 0x90


	public void .ctor() { }

}

public class AI : ConsoleSystem // TypeDefIndex: 11876
{	[ReplicatedVar] // RVA: 0x856E0 Offset: 0x84AE0 VA: 0x1800856E0
	public static bool allowdesigning; // 0x0
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool designing; // 0x1
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool groundAlign; // 0x2
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float maxGroundAlignDist; // 0x4
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool debugVis; // 0x8
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool npc_no_foot_ik; // 0x9
	private static HitTest lookingAtNpcCache; // 0x10


	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	public static void aiDebug_lookat(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	public static void aiDebug_LoadBalanceOverdueReport(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	public static void selectNPCLookat(ConsoleSystem.Arg args) { }

	private static bool CheckLookingAtVisible(HitTest test, TraceInfo trace) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class AiManagedAgent : FacepunchBehaviour, IServerComponent // TypeDefIndex: 12129
{	[TooltipAttribute] // RVA: 0xDFF10 Offset: 0xDF310 VA: 0x1800DFF10
	public int AgentTypeIndex; // 0x18


	public void .ctor() { }

}

public class AiManager : SingletonComponent<AiManager>, IServerComponent // TypeDefIndex: 12130
{	[HeaderAttribute] // RVA: 0xE0140 Offset: 0xDF540 VA: 0x1800E0140
	[SerializeField] // RVA: 0xE0140 Offset: 0xDF540 VA: 0x1800E0140
	public bool UseCover; // 0x18
	public float CoverPointVolumeCellSize; // 0x1C
	public float CoverPointVolumeCellHeight; // 0x20
	public float CoverPointRayLength; // 0x24
	public CoverPointVolume cpvPrefab; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public LayerMask DynamicCoverPointVolumeLayerMask; // 0x30
	private WorldSpaceGrid<CoverPointVolume> coverPointVolumeGrid; // 0x38


	internal void OnEnableCover() { }

	internal void OnDisableCover() { }

	public CoverPointVolume GetCoverVolumeContaining(Vector3 point) { }

	public void .ctor() { }

}

public class ScientistSpawner : SpawnGroup // TypeDefIndex: 12132
{	[HeaderAttribute] // RVA: 0xE0350 Offset: 0xDF750 VA: 0x1800E0350
	public bool Mobile; // 0x48
	public bool NeverMove; // 0x49
	public bool SpawnHostile; // 0x4A
	public bool OnlyAggroMarkedTargets; // 0x4B
	public bool IsPeacekeeper; // 0x4C
	public bool IsBandit; // 0x4D
	public bool IsMilitaryTunnelLab; // 0x4E
	public WaypointSet Waypoints; // 0x50
	public Transform[] LookAtInterestPointsStationary; // 0x58
	public Vector2 RadioEffectRepeatRange; // 0x60
	public Model Model; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AiLocationManager _mgr; // 0x70


	public void .ctor() { }

}

public class AiLocationManager : FacepunchBehaviour, IServerComponent // TypeDefIndex: 12133
{	public static List<AiLocationManager> Managers; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public AiLocationSpawner MainSpawner; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public AiLocationSpawner.SquadSpawnerLocation LocationWhenMainSpawnerIsNull; // 0x20
	public Transform CoverPointGroup; // 0x28
	public Transform PatrolPointGroup; // 0x30
	public CoverPointVolume DynamicCoverPointVolume; // 0x38
	public bool SnapCoverPointsToGround; // 0x40

	public AiLocationSpawner.SquadSpawnerLocation LocationType { get; }


	public AiLocationSpawner.SquadSpawnerLocation get_LocationType() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class AiLocationSpawner : SpawnGroup // TypeDefIndex: 12134
{	public AiLocationSpawner.SquadSpawnerLocation Location; // 0x48
	public AiLocationManager Manager; // 0x50
	public JunkPile Junkpile; // 0x58
	public bool IsMainSpawner; // 0x60
	public float chance; // 0x64
	private int defaultMaxPopulation; // 0x68
	private int defaultNumToSpawnPerTickMax; // 0x6C
	private int defaultNumToSpawnPerTickMin; // 0x70


	public void .ctor() { }

}

public enum AiLocationSpawner.SquadSpawnerLocation // TypeDefIndex: 12135
{	public int value__; // 0x0
	public const AiLocationSpawner.SquadSpawnerLocation MilitaryTunnels = 0;
	public const AiLocationSpawner.SquadSpawnerLocation JunkpileA = 1;
	public const AiLocationSpawner.SquadSpawnerLocation JunkpileG = 2;
	public const AiLocationSpawner.SquadSpawnerLocation CH47 = 3;
	public const AiLocationSpawner.SquadSpawnerLocation None = 4;
	public const AiLocationSpawner.SquadSpawnerLocation Compound = 5;
	public const AiLocationSpawner.SquadSpawnerLocation BanditTown = 6;
	public const AiLocationSpawner.SquadSpawnerLocation CargoShip = 7;

}

public class ScientistJunkpileSpawner : MonoBehaviour, IServerComponent // TypeDefIndex: 12139
{	public GameObjectRef ScientistPrefab; // 0x18
	public List<BaseCombatEntity> Spawned; // 0x20
	public BaseSpawnPoint[] SpawnPoints; // 0x28
	public int MaxPopulation; // 0x30
	public bool InitialSpawn; // 0x34
	public float MinRespawnTimeMinutes; // 0x38
	public float MaxRespawnTimeMinutes; // 0x3C
	public float MovementRadius; // 0x40
	public bool ReducedLongRangeAccuracy; // 0x44
	public ScientistJunkpileSpawner.JunkpileType SpawnType; // 0x48
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float SpawnBaseChance; // 0x4C


	public void .ctor() { }

}

public enum ScientistJunkpileSpawner.JunkpileType // TypeDefIndex: 12140
{	public int value__; // 0x0
	public const ScientistJunkpileSpawner.JunkpileType A = 0;
	public const ScientistJunkpileSpawner.JunkpileType B = 1;
	public const ScientistJunkpileSpawner.JunkpileType C = 2;
	public const ScientistJunkpileSpawner.JunkpileType D = 3;
	public const ScientistJunkpileSpawner.JunkpileType E = 4;
	public const ScientistJunkpileSpawner.JunkpileType F = 5;
	public const ScientistJunkpileSpawner.JunkpileType G = 6;

}

