public class BaseNPC : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6302
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int flags; 


	public static void ResetToPool(BaseNPC instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BaseNPC instance) { }

	public BaseNPC Copy() { }

	public static BaseNPC Deserialize(Stream stream) { }

	public static BaseNPC DeserializeLengthDelimited(Stream stream) { }

	public static BaseNPC DeserializeLength(Stream stream, int length) { }

	public static BaseNPC Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BaseNPC previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BaseNPC Deserialize(byte[] buffer, BaseNPC instance, bool isDelta = False) { }

	public static BaseNPC Deserialize(Stream stream, BaseNPC instance, bool isDelta) { }

	public static BaseNPC DeserializeLengthDelimited(Stream stream, BaseNPC instance, bool isDelta) { }

	public static BaseNPC DeserializeLength(Stream stream, int length, BaseNPC instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BaseNPC instance, BaseNPC previous) { }

	public static void Serialize(Stream stream, BaseNPC instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BaseNPC instance) { }

	public static void SerializeLengthDelimited(Stream stream, BaseNPC instance) { }

	public void .ctor() { }

}

public class BaseNpc : BaseCombatEntity // TypeDefIndex: 10245
{
	public int agentTypeIndex; 
	public bool NewAI; 
	[SerializeField] 
	[InspectorFlagsAttribute] 
	public TerrainTopology.Enum topologyPreference; 
	public Quaternion NetworkRotation; 
	private static List<BaseNpc> visibleNpcList; 
	[InspectorFlagsAttribute] 
	public BaseNpc.AiFlags aiFlags; 
	[HeaderAttribute] 
	public int ForgetUnseenEntityTime; 
	public float SensesTickRate; 
	private float nextVisThink; 
	private float lastTimeSeen; 
	private Vector3 lastPosition; 
	[HeaderAttribute] 
	public GameObjectRef CorpsePrefab; 
	public BaseNpc.AiStatistics Stats; 
	public Vector3 AttackOffset; 
	public float AttackDamage; 
	public DamageType AttackDamageType; 
	[TooltipAttribute] 
	public float AttackCost; 
	[TooltipAttribute] 
	public float AttackRate; 
	[TooltipAttribute] 
	public float AttackRange; 
	public NavMeshAgent NavAgent; 
	public LayerMask movementMask; 
	public float stuckDuration; 
	public float lastStuckTime; 
	public float idleDuration; 

	public static List<BaseNpc> VisibleNpcList { get; }
	public bool IsSitting { get; set; }
	public bool IsChasing { get; set; }
	public bool IsSleeping { get; set; }
	public override bool IsNpc { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public int TopologyPreference() { }

	public override float GetExtrapolationTime() { }

	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	protected override void ClientInit(Entity info) { }

	protected override void DoClientDestroy() { }

	public static void ClientCycle(float deltaTime) { }

	public override void MakeVisible() { }

	protected void ClientUpdate() { }

	public static List<BaseNpc> get_VisibleNpcList() { }

	public static void ClearVisibility() { }

	public static void RegisterForVisibility(BaseNpc npc) { }

	public static void UnregisterFromVisibility(BaseNpc npc) { }

	public override void SetNetworkRotation(Quaternion rot) { }

	public override Quaternion GetNetworkRotation() { }

	[BaseEntity.RPC_Client] 
	public virtual void Eat(Vector3 position) { }

	[BaseEntity.RPC_Client] 
	public virtual void Attack(Vector3 position) { }

	[BaseEntity.RPC_Client] 
	public virtual void Startled(Vector3 position) { }

	public bool HasAiFlag(BaseNpc.AiFlags f) { }

	public void SetAiFlag(BaseNpc.AiFlags f, bool set) { }

	public bool get_IsSitting() { }

	public void set_IsSitting(bool value) { }

	public bool get_IsChasing() { }

	public void set_IsChasing(bool value) { }

	public bool get_IsSleeping() { }

	public void set_IsSleeping(bool value) { }

	public static void UpdateNpcVisibilities() { }

	private float TimeSinceSeen() { }

	private void SetNextVisThink(float addTime) { }

	private bool WantsVisUpdate() { }

	protected override void UpdateCullingSpheres() { }

	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	protected override void OnVisibilityChanged(bool visible) { }

	private void VisUpdate() { }

	public override bool get_IsNpc() { }

	public override float MaxVelocity() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum BaseNpc.AiFlags // TypeDefIndex: 10246
{
	public int value__; 
	public const BaseNpc.AiFlags Sitting = 2;
	public const BaseNpc.AiFlags Chasing = 4;
	public const BaseNpc.AiFlags Sleeping = 8;

}

public struct BaseNpc.AiStatistics // TypeDefIndex: 10247
{
	[TooltipAttribute] 
	[RangeAttribute] 
	public float Size; 
	[TooltipAttribute] 
	public float Speed; 
	[TooltipAttribute] 
	public float Acceleration; 
	[TooltipAttribute] 
	public float TurnSpeed; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float Tolerance; 
	[TooltipAttribute] 
	public float VisionRange; 
	[TooltipAttribute] 
	public float VisionCone; 
	[TooltipAttribute] 
	public AnimationCurve DistanceVisibility; 
	[TooltipAttribute] 
	public float Hostility; 
	[TooltipAttribute] 
	public float Defensiveness; 
	[TooltipAttribute] 
	public float AggressionRange; 
	[TooltipAttribute] 
	public float DeaggroRange; 
	[TooltipAttribute] 
	public float DeaggroChaseTime; 
	[TooltipAttribute] 
	public float DeaggroCooldown; 
	[TooltipAttribute] 
	public float HealthThresholdForFleeing; 
	[TooltipAttribute] 
	public float HealthThresholdFleeChance; 
	[TooltipAttribute] 
	public float MinFleeRange; 
	[TooltipAttribute] 
	public float MaxFleeRange; 
	[TooltipAttribute] 
	public float MaxFleeTime; 
	[TooltipAttribute] 
	public float AfraidRange; 
	[TooltipAttribute] 
	public BaseNpc.AiStatistics.FamilyEnum Family; 
	[TooltipAttribute] 
	public BaseNpc.AiStatistics.FamilyEnum[] IsAfraidOf; 
	[TooltipAttribute] 
	public float MinRoamRange; 
	[TooltipAttribute] 
	public float MaxRoamRange; 
	[TooltipAttribute] 
	public float MinRoamDelay; 
	[TooltipAttribute] 
	public float MaxRoamDelay; 
	[TooltipAttribute] 
	public bool IsMobile; 
	[TooltipAttribute] 
	public AnimationCurve RoamDelayDistribution; 
	[TooltipAttribute] 
	public float AttackedMemoryTime; 
	[TooltipAttribute] 
	public float WakeupBlockMoveTime; 
	[TooltipAttribute] 
	public float MaxWaterDepth; 
	[TooltipAttribute] 
	public float WaterLevelNeck; 
	public float WaterLevelNeckOffset; 
	[TooltipAttribute] 
	public float CloseRange; 
	[TooltipAttribute] 
	public float MediumRange; 
	[TooltipAttribute] 
	public float LongRange; 
	[TooltipAttribute] 
	public float OutOfRangeOfSpawnPointTimeout; 
	[TooltipAttribute] 
	public bool OnlyAggroMarkedTargets; 

}

public enum BaseNpc.AiStatistics.FamilyEnum // TypeDefIndex: 10248
{
	public int value__; 
	public const BaseNpc.AiStatistics.FamilyEnum Bear = 0;
	public const BaseNpc.AiStatistics.FamilyEnum Wolf = 1;
	public const BaseNpc.AiStatistics.FamilyEnum Deer = 2;
	public const BaseNpc.AiStatistics.FamilyEnum Boar = 3;
	public const BaseNpc.AiStatistics.FamilyEnum Chicken = 4;
	public const BaseNpc.AiStatistics.FamilyEnum Horse = 5;
	public const BaseNpc.AiStatistics.FamilyEnum Zombie = 6;
	public const BaseNpc.AiStatistics.FamilyEnum Scientist = 7;
	public const BaseNpc.AiStatistics.FamilyEnum Murderer = 8;
	public const BaseNpc.AiStatistics.FamilyEnum Player = 9;

}

