public class AIDesign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6540
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<int> availableStates; 
	public List<AIStateContainer> stateContainers; 
	public int defaultStateContainer; 
	public string description; 
	public int scope; 
	public int intialViewStateID; 


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
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int id; 
	public int state; 
	public List<AIEventData> events; 
	public int inputMemorySlot; 


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
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int eventType; 
	public int triggerStateContainer; 
	public bool inverted; 
	public int inputMemorySlot; 
	public int outputMemorySlot; 
	public int id; 
	public TimerAIEventData timerData; 
	public PlayerDetectedAIEventData playerDetectedData; 
	public HealthBelowAIEventData healthBelowData; 
	public InRangeAIEventData inRangeData; 
	public HungerAboveAIEventData hungerAboveData; 
	public TirednessAboveAIEventData tirednessAboveData; 
	public ThreatDetectedAIEventData threatDetectedData; 
	public TargetDetectedAIEventData targetDetectedData; 
	public AmmoBelowAIEventData ammoBelowData; 
	public ChanceAIEventData chanceData; 
	public TimeSinceThreatAIEventData timeSinceThreatData; 
	public AggressionTimerAIEventData aggressionTimerData; 
	public InRangeOfHomeAIEventData inRangeOfHomeData; 


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
{
	private Option __menuOption_Menu_Talk; 
	public ConversationData[] conversations; 
	public NPCTalking.NPCConversationResultAction[] conversationResultActions; 

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

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Talk(BasePlayer player) { }

	public bool Menu_Talk_ShowIf(BasePlayer player) { }

	public void DoAction(string action) { }

	public Vector3 GetConversationWorldOrigin() { }

	[BaseEntity.RPC_Client] 
	public void Client_StartConversation(BaseEntity.RPCMessage msg) { }

	public void EndConversation(bool fromServer) { }

	[BaseEntity.RPC_Client] 
	public void Client_ForceSpeechNode(BaseEntity.RPCMessage msg) { }

	public void ResponsePressed(int index) { }

	[BaseEntity.RPC_Client] 
	public void Client_EndConversation(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

}

public class NPCTalking.NPCConversationResultAction // TypeDefIndex: 8426
{
	public string action; 
	public int scrapCost; 
	public string broadcastMessage; 
	public float broadcastRange; 


	public void .ctor() { }

}

public class NPCVendingOrder : ScriptableObject // TypeDefIndex: 8722
{
	public NPCVendingOrder.Entry[] orders; 


	public void .ctor() { }

}

public class NPCVendingOrder.Entry // TypeDefIndex: 8723
{
	public ItemDefinition sellItem; 
	public int sellItemAmount; 
	public bool sellItemAsBP; 
	public ItemDefinition currencyItem; 
	public int currencyAmount; 
	public bool currencyAsBP; 
	[TooltipAttribute] 
	public int weight; 
	public int refillAmount; 
	public float refillDelay; 


	public void .ctor() { }

}

public class NPCVendingOrderManifest : ScriptableObject // TypeDefIndex: 8724
{
	public NPCVendingOrder[] orderList; 


	public int GetIndex(NPCVendingOrder sample) { }

	public NPCVendingOrder GetFromIndex(int index) { }

	public void .ctor() { }

}

public class NPCVendingMachine : VendingMachine // TypeDefIndex: 8725
{
	public NPCVendingOrder vendingOrders; 


	public override bool ShouldShowLootMenus() { }

	public override bool ShouldShowAdminPanel() { }

	protected override bool CanRotate() { }

	public override bool CanPlayerAdmin(BasePlayer player) { }

	public void .ctor() { }

}

public class NPCDwelling : BaseEntity // TypeDefIndex: 8821
{
	public NPCSpawner npcSpawner; 
	public float NPCSpawnChance; 
	public SpawnGroup[] spawnGroups; 
	public AIMovePoint[] movePoints; 
	public AICoverPoint[] coverPoints; 


	public void .ctor() { }

}

public class NPCMissionProvider : NPCTalking, IMissionProvider // TypeDefIndex: 8849
{
	public MissionManifest manifest; 


	public uint ProviderID() { }

	public Vector3 ProviderPosition() { }

	public BaseEntity Entity() { }

	public void .ctor() { }

}

public class NPCShopKeeper : NPCPlayer // TypeDefIndex: 8850
{
	public EntityRef invisibleVendingMachineRef; 
	public InvisibleVendingMachine machine; 


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
{
	public float coverDot; 


	public void OnDrawGizmos() { }

	public void .ctor() { }

}

public class AICoverPointTool : MonoBehaviour // TypeDefIndex: 8904
{

	[ContextMenu] 
	public void PlaceCoverPoints() { }

	private AICoverPointTool.TestResult TestPoint(Vector3 pos) { }

	private void PlacePoint(AICoverPointTool.TestResult result) { }

	private void PlacePoint(Vector3 pos, Vector3 dir) { }

	public bool HitsCover(Ray ray, int layerMask, float maxDistance) { }

	public void .ctor() { }

}

private struct AICoverPointTool.TestResult // TypeDefIndex: 8905
{
	public Vector3 Position; 
	public bool Valid; 
	public bool Forward; 
	public bool Right; 
	public bool Backward; 
	public bool Left; 

}

public class AIInformationCell // TypeDefIndex: 8906
{
	public Bounds BoundingBox; 
	public List<AIInformationCell> NeighbourCells; 
	public AIInformationCellContents<AIMovePoint> MovePoints; 
	public AIInformationCellContents<AICoverPoint> CoverPoints; 
	[CompilerGeneratedAttribute] 
	private readonly int <X>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly int <Z>k__BackingField; 

	public int X { get; }
	public int Z { get; }


	[CompilerGeneratedAttribute] 
	public int get_X() { }

	[CompilerGeneratedAttribute] 
	public int get_Z() { }

	public void .ctor(Bounds bounds, GameObject root, int x, int z) { }

	public void DebugDraw(Color color, bool points, float scale = 1) { }

}

public class AIInformationCellContents<T> // TypeDefIndex: 8907
{
	public HashSet<T> Items; 

	public int Count { get; }
	public bool Empty { get; }


	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-AIInformationCellContents<object>.get_Count
	*/

	public bool get_Empty() { }
	/* GenericInstMethod :
	|
	|-AIInformationCellContents<object>.get_Empty
	*/

	public void Init(Bounds cellBounds, GameObject root) { }
	/* GenericInstMethod :
	|
	|-AIInformationCellContents<AICoverPoint>.Init
	|-AIInformationCellContents<AIMovePoint>.Init
	|-AIInformationCellContents<object>.Init
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-AIInformationCellContents<object>.Clear
	*/

	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-AIInformationCellContents<object>.Add
	*/

	public void Remove(T item) { }
	/* GenericInstMethod :
	|
	|-AIInformationCellContents<object>.Remove
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-AIInformationCellContents<AICoverPoint>..ctor
	|-AIInformationCellContents<AIMovePoint>..ctor
	|-AIInformationCellContents<object>..ctor
	*/

}

public class AIInformationGrid : MonoBehaviour // TypeDefIndex: 8908
{
	public int CellSize; 
	public Bounds BoundingBox; 
	public AIInformationCell[] Cells; 
	private Vector3 origin; 
	private int xCellCount; 
	private int zCellCount; 
	private const int maxPointResults = 2048;
	private AIMovePoint[] movePointResults; 
	private AICoverPoint[] coverPointResults; 
	private const int maxCellResults = 512;
	private AIInformationCell[] resultCells; 


	[ContextMenu] 
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
{
	public AIInformationGrid Grid; 
	public float Range; 


	public void OnDrawGizmos() { }

	public void .ctor() { }

}

public class AIInformationZone : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 8910
{
	public bool ShouldSleepAI; 
	public bool Virtual; 
	public bool UseCalculatedCoverDistances; 
	public static List<AIInformationZone> zones; 
	public List<AICoverPoint> coverPoints; 
	public List<AIMovePoint> movePoints; 
	private AICoverPoint[] coverPointArray; 
	private AIMovePoint[] movePointArray; 
	public List<NavMeshLink> navMeshLinks; 
	public List<AIMovePointPath> paths; 
	public Bounds bounds; 
	private AIInformationGrid grid; 


	public void .ctor() { }

	private static void .cctor() { }

}

public class AIMovePoint : AIPoint // TypeDefIndex: 8911
{
	public ListDictionary<AIMovePoint, float> distances; 
	public ListDictionary<AICoverPoint, float> distancesToCover; 
	public float radius; 
	public float WaitTime; 
	public List<Transform> LookAtPoints; 


	public void OnDrawGizmos() { }

	public void DrawLookAtPoints() { }

	public void Clear() { }

	public void AddLookAtPoint(Transform transform) { }

	public bool HasLookAtPoints() { }

	public Transform GetRandomLookAtPoint() { }

	public void .ctor() { }

}

public class AIMovePoint.DistTo // TypeDefIndex: 8912
{
	public float distance; 
	public AIMovePoint target; 


	public void .ctor() { }

}

public class AIMovePointPath : MonoBehaviour // TypeDefIndex: 8913
{
	public Color DebugPathColor; 
	public AIMovePointPath.Mode LoopMode; 
	public List<AIMovePoint> Points; 


	public void Clear() { }

	public void AddPoint(AIMovePoint point) { }

	public AIMovePoint FindNearestPoint(Vector3 position) { }

	public int FindNearestPointIndex(Vector3 position) { }

	public AIMovePoint GetPointAtIndex(int index) { }

	public int GetNextPointIndex(int currentPointIndex, ref AIMovePointPath.PathDirection pathDirection) { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	[ContextMenu] 
	public void AddChildPoints() { }

	public void .ctor() { }

}

public enum AIMovePointPath.Mode // TypeDefIndex: 8914
{
	public int value__; 
	public const AIMovePointPath.Mode Loop = 0;
	public const AIMovePointPath.Mode Reverse = 1;

}

public enum AIMovePointPath.PathDirection // TypeDefIndex: 8915
{
	public int value__; 
	public const AIMovePointPath.PathDirection Forwards = 0;
	public const AIMovePointPath.PathDirection Backwards = 1;

}

public class AIPoint : BaseMonoBehaviour // TypeDefIndex: 8916
{
	private BaseEntity currentUser; 


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
{
	public Transform entryPoint1; 
	public Transform entryPoint2; 
	public AITraversalWaitPoint[] waitPoints; 
	public Bounds movementArea; 
	public Transform activeEntryPoint; 
	public float nextFreeTime; 


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
{
	public float nextFreeTime; 


	public bool Occupied() { }

	public void Occupy(float dur = 1) { }

	public void .ctor() { }

}

public class AnimalBrain : BaseAIBrain<BaseAnimalNPC> // TypeDefIndex: 8919
{

	public void .ctor() { }

}

public class AnimalRagdoll : Ragdoll // TypeDefIndex: 8926
{
	public SkinnedMeshRenderer[] bodyRenderers; 
	public SkinnedMeshRenderer[] hairRenderers; 


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
{
	public GameObjectRef[] RadioChatterEffects; 
	public GameObjectRef[] DeathEffects; 
	public string deathStatName; 
	public Vector2 IdleChatterRepeatRange; 
	public ScientistNPC.RadioChatterType radioChatterType; 


	public void .ctor() { }

}

public enum ScientistNPC.RadioChatterType // TypeDefIndex: 8935
{
	public int value__; 
	public const ScientistNPC.RadioChatterType NONE = 0;
	public const ScientistNPC.RadioChatterType Idle = 1;
	public const ScientistNPC.RadioChatterType Alert = 2;

}

public class NPCPlayer : BasePlayer // TypeDefIndex: 8938
{
	public AIInformationZone VirtualInfoZone; 
	public Vector3 finalDestination; 
	private float randomOffset; 
	private Vector3 spawnPos; 
	public PlayerInventoryProperties[] loadouts; 
	public LayerMask movementMask; 
	public bool LegacyNavigation; 
	public NavMeshAgent NavAgent; 
	public float damageScale; 
	public float shortRange; 
	public float attackLengthMaxShortRangeScale; 

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
{
	public BasePathNode TargetNode; 
	private BasePathNode currentNode; 


	public void .ctor() { }

}

public enum AIState // TypeDefIndex: 8964
{
	public int value__; 
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
{
	public int value__; 
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
{
	public SkinnedMeshRenderer[] animalMesh; 
	public AnimalMultiSkin[] animalSkins; 
	private Model model; 
	public bool dontRandomizeOnStart; 


	private void Start() { }

	public void ChangeSkin(int iSkin) { }

	public void .ctor() { }

}

public class AnimalMultiSkin // TypeDefIndex: 9112
{
	public Material[] multiSkin; 


	public void .ctor() { }

}

public class AnimalAnimation : MonoBehaviour, IClientComponent // TypeDefIndex: 9113
{
	public BaseEntity Entity; 
	public BaseNpc Target; 
	public Animator Animator; 
	public MaterialEffect FootstepEffects; 
	public Transform[] Feet; 
	public SoundDefinition saddleMovementSoundDef; 
	public SoundDefinition saddleMovementSoundDefWood; 
	public SoundDefinition saddleMovementSoundDefRoadsign; 
	public AnimationCurve saddleMovementGainCurve; 
	[ReadOnlyAttribute] 
	public string BaseFolder; 
	public const BaseEntity.Flags Flag_WoodArmor = 2048;
	public const BaseEntity.Flags Flag_RoadsignArmor = 16384;
	private float lastThinkTime; 
	private Vector3 previousPosition; 
	private float previousRotationYaw; 
	private bool wasSleeping; 


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
{
	public Transform[] Feet; 
	public Animator animator; 
	public float maxWeightDistance; 
	public float minWeightDistance; 
	public float actualFootOffset; 


	public bool GroundSample(Vector3 origin, out RaycastHit hit) { }

	public void Start() { }

	public AvatarIKGoal GoalFromIndex(int index) { }

	private void OnAnimatorIK(int layerIndex) { }

	public void .ctor() { }

}

public class NPCFootstepEffects : BaseFootstepEffect // TypeDefIndex: 9354
{
	public string impactEffectDirectory; 
	public Transform frontLeftFoot; 
	public Transform frontRightFoot; 
	public Transform backLeftFoot; 
	public Transform backRightFoot; 


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
{
	public string Filename; 


	public void .ctor() { }

}

public class AIDesign // TypeDefIndex: 9378
{
	[CompilerGeneratedAttribute] 
	private AIDesignScope <Scope>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Description>k__BackingField; 
	public List<AIState> AvailableStates; 
	public int DefaultStateContainerID; 
	private Dictionary<int, AIStateContainer> stateContainers; 

	public AIDesignScope Scope { get; set; }
	public string Description { get; set; }


	[CompilerGeneratedAttribute] 
	public AIDesignScope get_Scope() { }

	[CompilerGeneratedAttribute] 
	private void set_Scope(AIDesignScope value) { }

	[CompilerGeneratedAttribute] 
	public string get_Description() { }

	[CompilerGeneratedAttribute] 
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
{
	public const string DesignFolderPath = "cfg/ai/";
	private static Dictionary<string, AIDesign> designs; 


	public static AIDesign GetByNameOrInstance(string designName, AIDesign entityDesign) { }

	public static void RefreshCache(string designName, AIDesign design) { }

	private static AIDesign GetByName(string designName) { }

	private static void .cctor() { }

}

public enum AIEventType // TypeDefIndex: 9380
{
	public int value__; 
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
{
	public AIMemory Memory; 
	[CompilerGeneratedAttribute] 
	private int <CurrentInputMemorySlot>k__BackingField; 
	private List<BaseAIEvent> events; 
	private IAIEventListener eventListener; 
	private AIBrainSenses senses; 
	private int currentEventIndex; 
	private bool inBlock; 

	public int CurrentInputMemorySlot { get; set; }


	[CompilerGeneratedAttribute] 
	public int get_CurrentInputMemorySlot() { }

	[CompilerGeneratedAttribute] 
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
{
	public AIMemoryBank<BaseEntity> Entity; 
	public AIMemoryBank<Vector3> Position; 
	public AIMemoryBank<AIPoint> AIPoint; 


	public void .ctor() { }

}

public class AIMemoryBank<T> // TypeDefIndex: 9387
{
	private MemoryBankType type; 
	private T[] slots; 
	private float[] slotSetTimestamps; 
	private int slotCount; 


	public void .ctor(MemoryBankType type, int slots) { }
	/* GenericInstMethod :
	|
	|-AIMemoryBank<AIPoint>..ctor
	|-AIMemoryBank<BaseEntity>..ctor
	|-AIMemoryBank<object>..ctor
	|-AIMemoryBank<Vector3>..ctor
	*/

	public void Init(MemoryBankType type, int slots) { }
	/* GenericInstMethod :
	|
	|-AIMemoryBank<object>.Init
	|
	|-AIMemoryBank<Vector3>.Init
	*/

	public void Set(T item, int index) { }
	/* GenericInstMethod :
	|
	|-AIMemoryBank<BaseEntity>.Set
	|-AIMemoryBank<object>.Set
	|
	|-AIMemoryBank<Vector3>.Set
	*/

	public T Get(int index) { }
	/* GenericInstMethod :
	|
	|-AIMemoryBank<BaseEntity>.Get
	|-AIMemoryBank<object>.Get
	|
	|-AIMemoryBank<Vector3>.Get
	*/

	public float GetTimeSinceSet(int index) { }
	/* GenericInstMethod :
	|
	|-AIMemoryBank<object>.GetTimeSinceSet
	|-AIMemoryBank<Vector3>.GetTimeSinceSet
	*/

	public void Remove(int index) { }
	/* GenericInstMethod :
	|
	|-AIMemoryBank<object>.Remove
	|
	|-AIMemoryBank<Vector3>.Remove
	*/

}

public class AIStateContainer // TypeDefIndex: 9421
{
	[CompilerGeneratedAttribute] 
	private int <ID>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AIState <State>k__BackingField; 
	public List<BaseAIEvent> Events; 
	[CompilerGeneratedAttribute] 
	private int <InputMemorySlot>k__BackingField; 

	public int ID { get; set; }
	public AIState State { get; set; }
	public int InputMemorySlot { get; set; }


	[CompilerGeneratedAttribute] 
	public int get_ID() { }

	[CompilerGeneratedAttribute] 
	private void set_ID(int value) { }

	[CompilerGeneratedAttribute] 
	public AIState get_State() { }

	[CompilerGeneratedAttribute] 
	private void set_State(AIState value) { }

	[CompilerGeneratedAttribute] 
	public int get_InputMemorySlot() { }

	[CompilerGeneratedAttribute] 
	private void set_InputMemorySlot(int value) { }

	public void Init(AIStateContainer container, BaseEntity owner) { }

	public AIStateContainer ToProto() { }

	public void .ctor() { }

}

public enum AIDesignScope // TypeDefIndex: 9424
{
	public int value__; 
	public const AIDesignScope Default = 0;
	public const AIDesignScope EntityServerWide = 1;
	public const AIDesignScope EntityInstance = 2;

}

public class NPCAutoTurret : AutoTurret // TypeDefIndex: 9576
{
	public Transform centerMuzzle; 
	public Transform muzzleLeft; 
	public Transform muzzleRight; 
	private bool useLeftMuzzle; 


	public void .ctor() { }

}

public class AIHelicopterAnimation : MonoBehaviour // TypeDefIndex: 9597
{
	public PatrolHelicopterAI _ai; 
	public float swayAmount; 
	public float lastStrafeScalar; 
	public float lastForwardBackScalar; 
	public float degreeMax; 
	public Vector3 lastPosition; 
	public float oldMoveSpeed; 
	public float smoothRateOfChange; 
	public float flareAmount; 


	public void .ctor() { }

}

public class NPCSpawner : SpawnGroup // TypeDefIndex: 10003
{
	public int AdditionalLOSBlockingLayer; 
	public MonumentNavMesh monumentNavMesh; 
	public bool shouldFillOnSpawn; 
	[HeaderAttribute] 
	public AIInformationZone VirtualInfoZone; 
	[HeaderAttribute] 
	public AIMovePointPath Path; 
	public BasePath AStarGraph; 
	[HeaderAttribute] 
	public bool UseStatModifiers; 
	public float SenseRange; 
	public float TargetLostRange; 
	public float AttackRangeMultiplier; 
	public float ListenRange; 
	public float CanUseHealingItemsChance; 
	[HeaderAttribute] 
	public PlayerInventoryProperties[] Loadouts; 


	public void .ctor() { }

}

public class AI : ConsoleSystem // TypeDefIndex: 11876
{
	[ReplicatedVar] 
	public static bool allowdesigning; 
	[ClientVar] 
	public static bool designing; 
	[ClientVar] 
	public static bool groundAlign; 
	[ClientVar] 
	public static float maxGroundAlignDist; 
	[ClientVar] 
	public static bool debugVis; 
	[ClientVar] 
	public static bool npc_no_foot_ik; 
	private static HitTest lookingAtNpcCache; 


	[ClientVar] 
	public static void aiDebug_lookat(ConsoleSystem.Arg args) { }

	[ClientVar] 
	public static void aiDebug_LoadBalanceOverdueReport(ConsoleSystem.Arg args) { }

	[ClientVar] 
	public static void selectNPCLookat(ConsoleSystem.Arg args) { }

	private static bool CheckLookingAtVisible(HitTest test, TraceInfo trace) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class AiManagedAgent : FacepunchBehaviour, IServerComponent // TypeDefIndex: 12129
{
	[TooltipAttribute] 
	public int AgentTypeIndex; 


	public void .ctor() { }

}

public class AiManager : SingletonComponent<AiManager>, IServerComponent // TypeDefIndex: 12130
{
	[HeaderAttribute] 
	[SerializeField] 
	public bool UseCover; 
	public float CoverPointVolumeCellSize; 
	public float CoverPointVolumeCellHeight; 
	public float CoverPointRayLength; 
	public CoverPointVolume cpvPrefab; 
	[SerializeField] 
	public LayerMask DynamicCoverPointVolumeLayerMask; 
	private WorldSpaceGrid<CoverPointVolume> coverPointVolumeGrid; 


	internal void OnEnableCover() { }

	internal void OnDisableCover() { }

	public CoverPointVolume GetCoverVolumeContaining(Vector3 point) { }

	public void .ctor() { }

}

public class ScientistSpawner : SpawnGroup // TypeDefIndex: 12132
{
	[HeaderAttribute] 
	public bool Mobile; 
	public bool NeverMove; 
	public bool SpawnHostile; 
	public bool OnlyAggroMarkedTargets; 
	public bool IsPeacekeeper; 
	public bool IsBandit; 
	public bool IsMilitaryTunnelLab; 
	public WaypointSet Waypoints; 
	public Transform[] LookAtInterestPointsStationary; 
	public Vector2 RadioEffectRepeatRange; 
	public Model Model; 
	[SerializeField] 
	private AiLocationManager _mgr; 


	public void .ctor() { }

}

public class AiLocationManager : FacepunchBehaviour, IServerComponent // TypeDefIndex: 12133
{
	public static List<AiLocationManager> Managers; 
	[SerializeField] 
	public AiLocationSpawner MainSpawner; 
	[SerializeField] 
	public AiLocationSpawner.SquadSpawnerLocation LocationWhenMainSpawnerIsNull; 
	public Transform CoverPointGroup; 
	public Transform PatrolPointGroup; 
	public CoverPointVolume DynamicCoverPointVolume; 
	public bool SnapCoverPointsToGround; 

	public AiLocationSpawner.SquadSpawnerLocation LocationType { get; }


	public AiLocationSpawner.SquadSpawnerLocation get_LocationType() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class AiLocationSpawner : SpawnGroup // TypeDefIndex: 12134
{
	public AiLocationSpawner.SquadSpawnerLocation Location; 
	public AiLocationManager Manager; 
	public JunkPile Junkpile; 
	public bool IsMainSpawner; 
	public float chance; 
	private int defaultMaxPopulation; 
	private int defaultNumToSpawnPerTickMax; 
	private int defaultNumToSpawnPerTickMin; 


	public void .ctor() { }

}

public enum AiLocationSpawner.SquadSpawnerLocation // TypeDefIndex: 12135
{
	public int value__; 
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
{
	public GameObjectRef ScientistPrefab; 
	public List<BaseCombatEntity> Spawned; 
	public BaseSpawnPoint[] SpawnPoints; 
	public int MaxPopulation; 
	public bool InitialSpawn; 
	public float MinRespawnTimeMinutes; 
	public float MaxRespawnTimeMinutes; 
	public float MovementRadius; 
	public bool ReducedLongRangeAccuracy; 
	public ScientistJunkpileSpawner.JunkpileType SpawnType; 
	[RangeAttribute] 
	public float SpawnBaseChance; 


	public void .ctor() { }

}

public enum ScientistJunkpileSpawner.JunkpileType // TypeDefIndex: 12140
{
	public int value__; 
	public const ScientistJunkpileSpawner.JunkpileType A = 0;
	public const ScientistJunkpileSpawner.JunkpileType B = 1;
	public const ScientistJunkpileSpawner.JunkpileType C = 2;
	public const ScientistJunkpileSpawner.JunkpileType D = 3;
	public const ScientistJunkpileSpawner.JunkpileType E = 4;
	public const ScientistJunkpileSpawner.JunkpileType F = 5;
	public const ScientistJunkpileSpawner.JunkpileType G = 6;

}

