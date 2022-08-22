public class BaseNPC : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6295
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int flags; // 0x14


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

public class BaseNpc : BaseCombatEntity // TypeDefIndex: 8525
{	public int agentTypeIndex; // 0x240
	public bool NewAI; // 0x244
	[SerializeField] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	[InspectorFlagsAttribute] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	public TerrainTopology.Enum topologyPreference; // 0x248
	public Quaternion NetworkRotation; // 0x24C
	private static List<BaseNpc> visibleNpcList; // 0x0
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public BaseNpc.AiFlags aiFlags; // 0x25C
	[HeaderAttribute] // RVA: 0xA2D80 Offset: 0xA2180 VA: 0x1800A2D80
	public int ForgetUnseenEntityTime; // 0x260
	public float SensesTickRate; // 0x264
	private float nextVisThink; // 0x268
	private float lastTimeSeen; // 0x26C
	private Vector3 lastPosition; // 0x270
	[HeaderAttribute] // RVA: 0xA2E00 Offset: 0xA2200 VA: 0x1800A2E00
	public GameObjectRef CorpsePrefab; // 0x280
	public BaseNpc.AiStatistics Stats; // 0x288
	public Vector3 AttackOffset; // 0x338
	public float AttackDamage; // 0x344
	public DamageType AttackDamageType; // 0x348
	[TooltipAttribute] // RVA: 0xA2EC0 Offset: 0xA22C0 VA: 0x1800A2EC0
	public float AttackCost; // 0x34C
	[TooltipAttribute] // RVA: 0xA3040 Offset: 0xA2440 VA: 0x1800A3040
	public float AttackRate; // 0x350
	[TooltipAttribute] // RVA: 0xA3160 Offset: 0xA2560 VA: 0x1800A3160
	public float AttackRange; // 0x354
	public NavMeshAgent NavAgent; // 0x358
	public LayerMask movementMask; // 0x360
	public float stuckDuration; // 0x364
	public float lastStuckTime; // 0x368
	public float idleDuration; // 0x36C

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

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public virtual void Eat(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public virtual void Attack(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

public enum BaseNpc.AiFlags // TypeDefIndex: 8526
{	public int value__; // 0x0
	public const BaseNpc.AiFlags Sitting = 2;
	public const BaseNpc.AiFlags Chasing = 4;
	public const BaseNpc.AiFlags Sleeping = 8;

}

public struct BaseNpc.AiStatistics // TypeDefIndex: 8527
{	[TooltipAttribute] // RVA: 0xA3400 Offset: 0xA2800 VA: 0x1800A3400
	[RangeAttribute] // RVA: 0xA3400 Offset: 0xA2800 VA: 0x1800A3400
	public float Size; // 0x0
	[TooltipAttribute] // RVA: 0xA3490 Offset: 0xA2890 VA: 0x1800A3490
	public float Speed; // 0x4
	[TooltipAttribute] // RVA: 0xA3510 Offset: 0xA2910 VA: 0x1800A3510
	public float Acceleration; // 0x8
	[TooltipAttribute] // RVA: 0xA35C0 Offset: 0xA29C0 VA: 0x1800A35C0
	public float TurnSpeed; // 0xC
	[TooltipAttribute] // RVA: 0xA3670 Offset: 0xA2A70 VA: 0x1800A3670
	[RangeAttribute] // RVA: 0xA3670 Offset: 0xA2A70 VA: 0x1800A3670
	public float Tolerance; // 0x10
	[TooltipAttribute] // RVA: 0xA37E0 Offset: 0xA2BE0 VA: 0x1800A37E0
	public float VisionRange; // 0x14
	[TooltipAttribute] // RVA: 0xA38C0 Offset: 0xA2CC0 VA: 0x1800A38C0
	public float VisionCone; // 0x18
	[TooltipAttribute] // RVA: 0xA39C0 Offset: 0xA2DC0 VA: 0x1800A39C0
	public AnimationCurve DistanceVisibility; // 0x20
	[TooltipAttribute] // RVA: 0xA3A50 Offset: 0xA2E50 VA: 0x1800A3A50
	public float Hostility; // 0x28
	[TooltipAttribute] // RVA: 0xA3B60 Offset: 0xA2F60 VA: 0x1800A3B60
	public float Defensiveness; // 0x2C
	[TooltipAttribute] // RVA: 0xA3C40 Offset: 0xA3040 VA: 0x1800A3C40
	public float AggressionRange; // 0x30
	[TooltipAttribute] // RVA: 0xA3D00 Offset: 0xA3100 VA: 0x1800A3D00
	public float DeaggroRange; // 0x34
	[TooltipAttribute] // RVA: 0xA3E40 Offset: 0xA3240 VA: 0x1800A3E40
	public float DeaggroChaseTime; // 0x38
	[TooltipAttribute] // RVA: 0xA4000 Offset: 0xA3400 VA: 0x1800A4000
	public float DeaggroCooldown; // 0x3C
	[TooltipAttribute] // RVA: 0xA4110 Offset: 0xA3510 VA: 0x1800A4110
	public float HealthThresholdForFleeing; // 0x40
	[TooltipAttribute] // RVA: 0xA42F0 Offset: 0xA36F0 VA: 0x1800A42F0
	public float HealthThresholdFleeChance; // 0x44
	[TooltipAttribute] // RVA: 0xA4470 Offset: 0xA3870 VA: 0x1800A4470
	public float MinFleeRange; // 0x48
	[TooltipAttribute] // RVA: 0xA4540 Offset: 0xA3940 VA: 0x1800A4540
	public float MaxFleeRange; // 0x4C
	[TooltipAttribute] // RVA: 0xA4700 Offset: 0xA3B00 VA: 0x1800A4700
	public float MaxFleeTime; // 0x50
	[TooltipAttribute] // RVA: 0xA4760 Offset: 0xA3B60 VA: 0x1800A4760
	public float AfraidRange; // 0x54
	[TooltipAttribute] // RVA: 0xA4870 Offset: 0xA3C70 VA: 0x1800A4870
	public BaseNpc.AiStatistics.FamilyEnum Family; // 0x58
	[TooltipAttribute] // RVA: 0xA4A50 Offset: 0xA3E50 VA: 0x1800A4A50
	public BaseNpc.AiStatistics.FamilyEnum[] IsAfraidOf; // 0x60
	[TooltipAttribute] // RVA: 0xA4A80 Offset: 0xA3E80 VA: 0x1800A4A80
	public float MinRoamRange; // 0x68
	[TooltipAttribute] // RVA: 0xA4B50 Offset: 0xA3F50 VA: 0x1800A4B50
	public float MaxRoamRange; // 0x6C
	[TooltipAttribute] // RVA: 0xA4DF0 Offset: 0xA41F0 VA: 0x1800A4DF0
	public float MinRoamDelay; // 0x70
	[TooltipAttribute] // RVA: 0xA4EC0 Offset: 0xA42C0 VA: 0x1800A4EC0
	public float MaxRoamDelay; // 0x74
	[TooltipAttribute] // RVA: 0xA5030 Offset: 0xA4430 VA: 0x1800A5030
	public bool IsMobile; // 0x78
	[TooltipAttribute] // RVA: 0xA5120 Offset: 0xA4520 VA: 0x1800A5120
	public AnimationCurve RoamDelayDistribution; // 0x80
	[TooltipAttribute] // RVA: 0xA5240 Offset: 0xA4640 VA: 0x1800A5240
	public float AttackedMemoryTime; // 0x88
	[TooltipAttribute] // RVA: 0xA53D0 Offset: 0xA47D0 VA: 0x1800A53D0
	public float WakeupBlockMoveTime; // 0x8C
	[TooltipAttribute] // RVA: 0xA5460 Offset: 0xA4860 VA: 0x1800A5460
	public float MaxWaterDepth; // 0x90
	[TooltipAttribute] // RVA: 0xA5490 Offset: 0xA4890 VA: 0x1800A5490
	public float WaterLevelNeck; // 0x94
	public float WaterLevelNeckOffset; // 0x98
	[TooltipAttribute] // RVA: 0xA5830 Offset: 0xA4C30 VA: 0x1800A5830
	public float CloseRange; // 0x9C
	[TooltipAttribute] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	public float MediumRange; // 0xA0
	[TooltipAttribute] // RVA: 0xA59A0 Offset: 0xA4DA0 VA: 0x1800A59A0
	public float LongRange; // 0xA4
	[TooltipAttribute] // RVA: 0xA5AE0 Offset: 0xA4EE0 VA: 0x1800A5AE0
	public float OutOfRangeOfSpawnPointTimeout; // 0xA8
	[TooltipAttribute] // RVA: 0xA5B80 Offset: 0xA4F80 VA: 0x1800A5B80
	public bool OnlyAggroMarkedTargets; // 0xAC

}

public enum BaseNpc.AiStatistics.FamilyEnum // TypeDefIndex: 8528
{	public int value__; // 0x0
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

