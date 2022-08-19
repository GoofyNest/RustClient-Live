public class BradleyAPC : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6342
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float engineThrottle; // 0x14
	public float throttleLeft; // 0x18
	public float throttleRight; // 0x1C
	public Vector3 mainGunVec; // 0x20
	public Vector3 topTurretVec; // 0x2C
	public Vector3 rearGunVec; // 0x38
	public Vector3 leftSideGun1; // 0x44
	public Vector3 leftSideGun2; // 0x50
	public Vector3 rightSideGun1; // 0x5C
	public Vector3 rightSideGun2; // 0x68

	// Methods

	// RVA: 0x1F69850 Offset: 0x1F68C50 VA: 0x181F69850
	public static void ResetToPool(BradleyAPC instance) { }

	// RVA: 0x1F69970 Offset: 0x1F68D70 VA: 0x181F69970
	public void ResetToPool() { }

	// RVA: 0x1F69320 Offset: 0x1F68720 VA: 0x181F69320 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F678C0 Offset: 0x1F66CC0 VA: 0x181F678C0
	public void CopyTo(BradleyAPC instance) { }

	// RVA: 0x1F67960 Offset: 0x1F66D60 VA: 0x181F67960
	public BradleyAPC Copy() { }

	// RVA: 0x1F68C30 Offset: 0x1F68030 VA: 0x181F68C30
	public static BradleyAPC Deserialize(Stream stream) { }

	// RVA: 0x1F67A50 Offset: 0x1F66E50 VA: 0x181F67A50
	public static BradleyAPC DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F68310 Offset: 0x1F67710 VA: 0x181F68310
	public static BradleyAPC DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F687D0 Offset: 0x1F67BD0 VA: 0x181F687D0
	public static BradleyAPC Deserialize(byte[] buffer) { }

	// RVA: 0x1F694D0 Offset: 0x1F688D0 VA: 0x181F694D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F6AE40 Offset: 0x1F6A240 VA: 0x181F6AE40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F6AE60 Offset: 0x1F6A260 VA: 0x181F6AE60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BradleyAPC previous) { }

	// RVA: 0x1F69830 Offset: 0x1F68C30 VA: 0x181F69830 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F683A0 Offset: 0x1F677A0 VA: 0x181F683A0
	public static BradleyAPC Deserialize(byte[] buffer, BradleyAPC instance, bool isDelta = False) { }

	// RVA: 0x1F68FC0 Offset: 0x1F683C0 VA: 0x181F68FC0
	public static BradleyAPC Deserialize(Stream stream, BradleyAPC instance, bool isDelta) { }

	// RVA: 0x1F67AD0 Offset: 0x1F66ED0 VA: 0x181F67AD0
	public static BradleyAPC DeserializeLengthDelimited(Stream stream, BradleyAPC instance, bool isDelta) { }

	// RVA: 0x1F67F00 Offset: 0x1F67300 VA: 0x181F67F00
	public static BradleyAPC DeserializeLength(Stream stream, int length, BradleyAPC instance, bool isDelta) { }

	// RVA: 0x1F69A90 Offset: 0x1F68E90 VA: 0x181F69A90
	public static void SerializeDelta(Stream stream, BradleyAPC instance, BradleyAPC previous) { }

	// RVA: 0x1F6A7B0 Offset: 0x1F69BB0 VA: 0x181F6A7B0
	public static void Serialize(Stream stream, BradleyAPC instance) { }

	// RVA: 0x1F6AE30 Offset: 0x1F6A230 VA: 0x181F6AE30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F6AE40 Offset: 0x1F6A240 VA: 0x181F6AE40
	public void ToProto(Stream stream) { }

	// RVA: 0x1F6A6A0 Offset: 0x1F69AA0 VA: 0x181F6A6A0
	public static byte[] SerializeToBytes(BradleyAPC instance) { }

	// RVA: 0x1F6A5F0 Offset: 0x1F699F0 VA: 0x181F6A5F0
	public static void SerializeLengthDelimited(Stream stream, BradleyAPC instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class BradleyAPC : BaseCombatEntity // TypeDefIndex: 8536
{	// Fields
	[HeaderAttribute] // RVA: 0x8CB00 Offset: 0x8BF00 VA: 0x18008CB00
	public BlendedLoopEngineSound engineSound; // 0x240
	public SoundDefinition treadLoopDef; // 0x248
	public AnimationCurve treadGainCurve; // 0x250
	public AnimationCurve treadPitchCurve; // 0x258
	public AnimationCurve treadFreqCurve; // 0x260
	private Sound treadLoop; // 0x268
	private SoundModulation.Modulator treadGain; // 0x270
	private SoundModulation.Modulator treadPitch; // 0x278
	public SoundDefinition chasisLurchSoundDef; // 0x280
	public float chasisLurchAngleDelta; // 0x288
	public float chasisLurchSpeedDelta; // 0x28C
	private float lastAngle; // 0x290
	private float lastSpeed; // 0x294
	public SoundDefinition turretTurnLoopDef; // 0x298
	public float turretLoopGainSpeed; // 0x2A0
	public float turretLoopPitchSpeed; // 0x2A4
	public float turretLoopMinAngleDelta; // 0x2A8
	public float turretLoopMaxAngleDelta; // 0x2AC
	public float turretLoopPitchMin; // 0x2B0
	public float turretLoopPitchMax; // 0x2B4
	public float turretLoopGainThreshold; // 0x2B8
	private Sound turretTurnLoop; // 0x2C0
	private SoundModulation.Modulator turretTurnLoopGain; // 0x2C8
	private SoundModulation.Modulator turretTurnLoopPitch; // 0x2D0
	public float enginePitch; // 0x2D8
	public float rpmMultiplier; // 0x2DC
	private TreadAnimator treadAnimator; // 0x2E0
	private float lastTurretAngle; // 0x2E8
	[HeaderAttribute] // RVA: 0xA7C50 Offset: 0xA7050 VA: 0x1800A7C50
	public List<Vector3> currentPath; // 0x2F0
	public int currentPathIndex; // 0x2F8
	public bool pathLooping; // 0x2FC
	[HeaderAttribute] // RVA: 0x786D0 Offset: 0x77AD0 VA: 0x1800786D0
	public float viewDistance; // 0x300
	public float searchRange; // 0x304
	public float searchFrequency; // 0x308
	public float memoryDuration; // 0x30C
	public static float sightUpdateRate; // 0x0
	public List<BradleyAPC.TargetInfo> targetList; // 0x310
	[HeaderAttribute] // RVA: 0xA7DB0 Offset: 0xA71B0 VA: 0x1800A7DB0
	public float coaxFireRate; // 0x318
	public int coaxBurstLength; // 0x31C
	public float coaxAimCone; // 0x320
	public float bulletDamage; // 0x324
	[HeaderAttribute] // RVA: 0xA7E20 Offset: 0xA7220 VA: 0x1800A7E20
	public float topTurretFireRate; // 0x328
	public GameObjectRef gun_fire_effect; // 0x330
	public GameObjectRef bulletEffect; // 0x338
	private float lastLateUpdate; // 0x340
	[HeaderAttribute] // RVA: 0x84A80 Offset: 0x83E80 VA: 0x180084A80
	public WheelCollider[] leftWheels; // 0x348
	public WheelCollider[] rightWheels; // 0x350
	[HeaderAttribute] // RVA: 0xA7F60 Offset: 0xA7360 VA: 0x1800A7F60
	public float moveForceMax; // 0x358
	public float brakeForce; // 0x35C
	public float turnForce; // 0x360
	public float sideStiffnessMax; // 0x364
	public float sideStiffnessMin; // 0x368
	public Transform centerOfMass; // 0x370
	public float stoppingDist; // 0x378
	[HeaderAttribute] // RVA: 0xA9360 Offset: 0xA8760 VA: 0x1800A9360
	public float throttle; // 0x37C
	public float turning; // 0x380
	public float rightThrottle; // 0x384
	public float leftThrottle; // 0x388
	public bool brake; // 0x38C
	[HeaderAttribute] // RVA: 0xA9400 Offset: 0xA8800 VA: 0x1800A9400
	public Rigidbody myRigidBody; // 0x390
	public Collider myCollider; // 0x398
	public Vector3 destination; // 0x3A0
	private Vector3 finalDestination; // 0x3AC
	public Transform followTest; // 0x3B8
	public TriggerHurtEx impactDamager; // 0x3C0
	[HeaderAttribute] // RVA: 0x8AB80 Offset: 0x89F80 VA: 0x18008AB80
	public Transform mainTurretEyePos; // 0x3C8
	public Transform mainTurret; // 0x3D0
	public Transform CannonPitch; // 0x3D8
	public Transform CannonMuzzle; // 0x3E0
	public Transform coaxPitch; // 0x3E8
	public Transform coaxMuzzle; // 0x3F0
	public Transform topTurretEyePos; // 0x3F8
	public Transform topTurretYaw; // 0x400
	public Transform topTurretPitch; // 0x408
	public Transform topTurretMuzzle; // 0x410
	private Vector3 turretAimVector; // 0x418
	private Vector3 desiredAimVector; // 0x424
	private Vector3 topTurretAimVector; // 0x430
	private Vector3 desiredTopTurretAimVector; // 0x43C
	[HeaderAttribute] // RVA: 0x785E0 Offset: 0x779E0 VA: 0x1800785E0
	public GameObjectRef explosionEffect; // 0x448
	public GameObjectRef servergibs; // 0x450
	public GameObjectRef fireBall; // 0x458
	public GameObjectRef crateToDrop; // 0x460
	public GameObjectRef debrisFieldMarker; // 0x468
	[HeaderAttribute] // RVA: 0x82EE0 Offset: 0x822E0 VA: 0x180082EE0
	public int maxCratesToSpawn; // 0x470
	public int patrolPathIndex; // 0x474
	public BasePath patrolPath; // 0x478
	public bool DoAI; // 0x480
	public GameObjectRef mainCannonMuzzleFlash; // 0x488
	public GameObjectRef mainCannonProjectile; // 0x490
	public float recoilScale; // 0x498
	public NavMeshPath navMeshPath; // 0x4A0
	public int navMeshPathIndex; // 0x4A8

	// Methods

	// RVA: 0x539010 Offset: 0x538410 VA: 0x180539010 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x538B10 Offset: 0x537F10 VA: 0x180538B10
	public void InitializeClientsideEffects() { }

	// RVA: 0x539460 Offset: 0x538860 VA: 0x180539460
	public void ShutdownClientsideEffects() { }

	// RVA: 0x539600 Offset: 0x538A00 VA: 0x180539600
	public void UpdateSounds() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5383B0 Offset: 0x5377B0 VA: 0x1805383B0
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x538030 Offset: 0x537430 VA: 0x180538030
	public void AimWeaponAt(Transform weaponYaw, Transform weaponPitch, Vector3 direction, float minPitch = -360, float maxPitch = 360, float maxYaw = 360, Transform parentOverride) { }

	// RVA: 0x538C00 Offset: 0x538000 VA: 0x180538C00
	public void LateUpdate() { }

	// RVA: 0x538F30 Offset: 0x538330 VA: 0x180538F30 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x538870 Offset: 0x537C70 VA: 0x180538870 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x538970 Offset: 0x537D70 VA: 0x180538970 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x53A270 Offset: 0x539670 VA: 0x18053A270
	public void .ctor() { }

	// RVA: 0x53A230 Offset: 0x539630 VA: 0x18053A230
	private static void .cctor() { }

}

public class BradleyAPC.TargetInfo : Pool.IPooled // TypeDefIndex: 8537
{	// Fields
	public float damageReceivedFrom; // 0x10
	public BaseEntity entity; // 0x18
	public float lastSeenTime; // 0x20
	public Vector3 lastSeenPosition; // 0x24

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x53C650 Offset: 0x53BA50 VA: 0x18053C650 Slot: 4
	public void EnterPool() { }

	// RVA: 0x53CAF0 Offset: 0x53BEF0 VA: 0x18053CAF0
	public void Setup(BaseEntity ent, float time) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public void LeavePool() { }

	// RVA: 0x53C6D0 Offset: 0x53BAD0 VA: 0x18053C6D0
	public float GetPriorityScore(BradleyAPC apc) { }

	// RVA: 0x53CA40 Offset: 0x53BE40 VA: 0x18053CA40
	public bool IsVisible() { }

	// RVA: 0x53C9E0 Offset: 0x53BDE0 VA: 0x18053C9E0
	public bool IsValid() { }

}

