public class BaseNPC : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6295
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int flags; // 0x14

	// Methods

	// RVA: 0x1FFA6A0 Offset: 0x1FF9AA0 VA: 0x181FFA6A0
	public static void ResetToPool(BaseNPC instance) { }

	// RVA: 0x1FFA720 Offset: 0x1FF9B20 VA: 0x181FFA720
	public void ResetToPool() { }

	// RVA: 0x1FFA570 Offset: 0x1FF9970 VA: 0x181FFA570 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(BaseNPC instance) { }

	// RVA: 0x1FF9BF0 Offset: 0x1FF8FF0 VA: 0x181FF9BF0
	public BaseNPC Copy() { }

	// RVA: 0x1FFA4F0 Offset: 0x1FF98F0 VA: 0x181FFA4F0
	public static BaseNPC Deserialize(Stream stream) { }

	// RVA: 0x1FF9C60 Offset: 0x1FF9060 VA: 0x181FF9C60
	public static BaseNPC DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF9F00 Offset: 0x1FF9300 VA: 0x181FF9F00
	public static BaseNPC DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFA190 Offset: 0x1FF9590 VA: 0x181FFA190
	public static BaseNPC Deserialize(byte[] buffer) { }

	// RVA: 0x1FFA660 Offset: 0x1FF9A60 VA: 0x181FFA660
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FFABF0 Offset: 0x1FF9FF0 VA: 0x181FFABF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FFACC0 Offset: 0x1FFA0C0 VA: 0x181FFACC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseNPC previous) { }

	// RVA: 0x1FFA680 Offset: 0x1FF9A80 VA: 0x181FFA680 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FFA2B0 Offset: 0x1FF96B0 VA: 0x181FFA2B0
	public static BaseNPC Deserialize(byte[] buffer, BaseNPC instance, bool isDelta = False) { }

	// RVA: 0x1FFA3B0 Offset: 0x1FF97B0 VA: 0x181FFA3B0
	public static BaseNPC Deserialize(Stream stream, BaseNPC instance, bool isDelta) { }

	// RVA: 0x1FF9CE0 Offset: 0x1FF90E0 VA: 0x181FF9CE0
	public static BaseNPC DeserializeLengthDelimited(Stream stream, BaseNPC instance, bool isDelta) { }

	// RVA: 0x1FF9F90 Offset: 0x1FF9390 VA: 0x181FF9F90
	public static BaseNPC DeserializeLength(Stream stream, int length, BaseNPC instance, bool isDelta) { }

	// RVA: 0x1FFA7A0 Offset: 0x1FF9BA0 VA: 0x181FFA7A0
	public static void SerializeDelta(Stream stream, BaseNPC instance, BaseNPC previous) { }

	// RVA: 0x1FFAB10 Offset: 0x1FF9F10 VA: 0x181FFAB10
	public static void Serialize(Stream stream, BaseNPC instance) { }

	// RVA: 0x1FFABE0 Offset: 0x1FF9FE0 VA: 0x181FFABE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FFABF0 Offset: 0x1FF9FF0 VA: 0x181FFABF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFA960 Offset: 0x1FF9D60 VA: 0x181FFA960
	public static byte[] SerializeToBytes(BaseNPC instance) { }

	// RVA: 0x1FFA8B0 Offset: 0x1FF9CB0 VA: 0x181FFA8B0
	public static void SerializeLengthDelimited(Stream stream, BaseNPC instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class BaseNpc : BaseCombatEntity // TypeDefIndex: 8525
{	// Fields
	public int agentTypeIndex; // 0x240
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

	// Properties
	public static List<BaseNpc> VisibleNpcList { get; }
	public bool IsSitting { get; set; }
	public bool IsChasing { get; set; }
	public bool IsSleeping { get; set; }
	public override bool IsNpc { get; }

	// Methods

	// RVA: 0xA2E580 Offset: 0xA2D980 VA: 0x180A2E580 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA2F4F0 Offset: 0xA2E8F0 VA: 0x180A2F4F0
	public int TopologyPreference() { }

	// RVA: 0xA2E3E0 Offset: 0xA2D7E0 VA: 0x180A2E3E0 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0xA2EF90 Offset: 0xA2E390 VA: 0x180A2EF90 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA2E120 Offset: 0xA2D520 VA: 0x180A2E120 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA2E2B0 Offset: 0xA2D6B0 VA: 0x180A2E2B0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0xA2DF30 Offset: 0xA2D330 VA: 0x180A2DF30
	public static void ClientCycle(float deltaTime) { }

	// RVA: 0xA2E4D0 Offset: 0xA2D8D0 VA: 0x180A2E4D0 Slot: 89
	public override void MakeVisible() { }

	// RVA: 0xA2E210 Offset: 0xA2D610 VA: 0x180A2E210
	protected void ClientUpdate() { }

	// RVA: 0xA30090 Offset: 0xA2F490 VA: 0x180A30090
	public static List<BaseNpc> get_VisibleNpcList() { }

	// RVA: 0xA2DE10 Offset: 0xA2D210 VA: 0x180A2DE10
	public static void ClearVisibility() { }

	// RVA: 0xA2F380 Offset: 0xA2E780 VA: 0x180A2F380
	public static void RegisterForVisibility(BaseNpc npc) { }

	// RVA: 0xA2F500 Offset: 0xA2E900 VA: 0x180A2F500
	public static void UnregisterFromVisibility(BaseNpc npc) { }

	// RVA: 0xA2F430 Offset: 0xA2E830 VA: 0x180A2F430 Slot: 60
	public override void SetNetworkRotation(Quaternion rot) { }

	// RVA: 0xA2E470 Offset: 0xA2D870 VA: 0x180A2E470 Slot: 25
	public override Quaternion GetNetworkRotation() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2E380 Offset: 0xA2D780 VA: 0x180A2E380 Slot: 145
	public virtual void Eat(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2DDB0 Offset: 0xA2D1B0 VA: 0x180A2DDB0 Slot: 146
	public virtual void Attack(Vector3 position) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2F470 Offset: 0xA2E870 VA: 0x180A2F470 Slot: 147
	public virtual void Startled(Vector3 position) { }

	// RVA: 0xA2E4C0 Offset: 0xA2D8C0 VA: 0x180A2E4C0
	public bool HasAiFlag(BaseNpc.AiFlags f) { }

	// RVA: 0xA2F410 Offset: 0xA2E810 VA: 0x180A2F410
	public void SetAiFlag(BaseNpc.AiFlags f, bool set) { }

	// RVA: 0xA30070 Offset: 0xA2F470 VA: 0x180A30070
	public bool get_IsSitting() { }

	// RVA: 0xA30110 Offset: 0xA2F510 VA: 0x180A30110
	public void set_IsSitting(bool value) { }

	// RVA: 0xA30060 Offset: 0xA2F460 VA: 0x180A30060
	public bool get_IsChasing() { }

	// RVA: 0xA300F0 Offset: 0xA2F4F0 VA: 0x180A300F0
	public void set_IsChasing(bool value) { }

	// RVA: 0xA30080 Offset: 0xA2F480 VA: 0x180A30080
	public bool get_IsSleeping() { }

	// RVA: 0xA30130 Offset: 0xA2F530 VA: 0x180A30130
	public void set_IsSleeping(bool value) { }

	// RVA: 0xA2F950 Offset: 0xA2ED50 VA: 0x180A2F950
	public static void UpdateNpcVisibilities() { }

	// RVA: 0xA2F4D0 Offset: 0xA2E8D0 VA: 0x180A2F4D0
	private float TimeSinceSeen() { }

	// RVA: 0xA2F440 Offset: 0xA2E840 VA: 0x180A2F440
	private void SetNextVisThink(float addTime) { }

	// RVA: 0xA2FF60 Offset: 0xA2F360 VA: 0x180A2FF60
	private bool WantsVisUpdate() { }

	// RVA: 0xA2F590 Offset: 0xA2E990 VA: 0x180A2F590 Slot: 90
	protected override void UpdateCullingSpheres() { }

	// RVA: 0xA2FA70 Offset: 0xA2EE70 VA: 0x180A2FA70
	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	// RVA: 0xA2F090 Offset: 0xA2E490 VA: 0x180A2F090 Slot: 92
	protected override void OnVisibilityChanged(bool visible) { }

	// RVA: 0xA2FB70 Offset: 0xA2EF70 VA: 0x180A2FB70
	private void VisUpdate() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 98
	public override bool get_IsNpc() { }

	// RVA: 0x903900 Offset: 0x902D00 VA: 0x180903900 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0xA2FFE0 Offset: 0xA2F3E0 VA: 0x180A2FFE0
	public void .ctor() { }

	// RVA: 0xA2FF80 Offset: 0xA2F380 VA: 0x180A2FF80
	private static void .cctor() { }

}

public enum BaseNpc.AiFlags // TypeDefIndex: 8526
{	// Fields
	public int value__; // 0x0
	public const BaseNpc.AiFlags Sitting = 2;
	public const BaseNpc.AiFlags Chasing = 4;
	public const BaseNpc.AiFlags Sleeping = 8;

}

public struct BaseNpc.AiStatistics // TypeDefIndex: 8527
{	// Fields
	[TooltipAttribute] // RVA: 0xA3400 Offset: 0xA2800 VA: 0x1800A3400
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
{	// Fields
	public int value__; // 0x0
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

