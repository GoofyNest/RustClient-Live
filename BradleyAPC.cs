public class BradleyAPC : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6342
{	public bool ShouldPool; // 0x10
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


	public static void ResetToPool(BradleyAPC instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BradleyAPC instance) { }

	public BradleyAPC Copy() { }

	public static BradleyAPC Deserialize(Stream stream) { }

	public static BradleyAPC DeserializeLengthDelimited(Stream stream) { }

	public static BradleyAPC DeserializeLength(Stream stream, int length) { }

	public static BradleyAPC Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BradleyAPC previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BradleyAPC Deserialize(byte[] buffer, BradleyAPC instance, bool isDelta = False) { }

	public static BradleyAPC Deserialize(Stream stream, BradleyAPC instance, bool isDelta) { }

	public static BradleyAPC DeserializeLengthDelimited(Stream stream, BradleyAPC instance, bool isDelta) { }

	public static BradleyAPC DeserializeLength(Stream stream, int length, BradleyAPC instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BradleyAPC instance, BradleyAPC previous) { }

	public static void Serialize(Stream stream, BradleyAPC instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BradleyAPC instance) { }

	public static void SerializeLengthDelimited(Stream stream, BradleyAPC instance) { }

	public void .ctor() { }

}

public class BradleyAPC : BaseCombatEntity // TypeDefIndex: 8536
{	[HeaderAttribute] // RVA: 0x8CB00 Offset: 0x8BF00 VA: 0x18008CB00
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


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void InitializeClientsideEffects() { }

	public void ShutdownClientsideEffects() { }

	public void UpdateSounds() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	public void AimWeaponAt(Transform weaponYaw, Transform weaponPitch, Vector3 direction, float minPitch = -360, float maxPitch = 360, float maxYaw = 360, Transform parentOverride) { }

	public void LateUpdate() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override void ClientInit(Entity info) { }

	protected override void DoClientDestroy() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class BradleyAPC.TargetInfo : Pool.IPooled // TypeDefIndex: 8537
{	public float damageReceivedFrom; // 0x10
	public BaseEntity entity; // 0x18
	public float lastSeenTime; // 0x20
	public Vector3 lastSeenPosition; // 0x24


	public void .ctor() { }

	public void EnterPool() { }

	public void Setup(BaseEntity ent, float time) { }

	public void LeavePool() { }

	public float GetPriorityScore(BradleyAPC apc) { }

	public bool IsVisible() { }

	public bool IsValid() { }

}

