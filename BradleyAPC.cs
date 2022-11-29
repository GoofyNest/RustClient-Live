public class BradleyAPC : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6349
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float engineThrottle; 
	public float throttleLeft; 
	public float throttleRight; 
	public Vector3 mainGunVec; 
	public Vector3 topTurretVec; 
	public Vector3 rearGunVec; 
	public Vector3 leftSideGun1; 
	public Vector3 leftSideGun2; 
	public Vector3 rightSideGun1; 
	public Vector3 rightSideGun2; 


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

public class BradleyAPC : BaseCombatEntity // TypeDefIndex: 10256
{
	[HeaderAttribute] 
	public BlendedLoopEngineSound engineSound; 
	public SoundDefinition treadLoopDef; 
	public AnimationCurve treadGainCurve; 
	public AnimationCurve treadPitchCurve; 
	public AnimationCurve treadFreqCurve; 
	private Sound treadLoop; 
	private SoundModulation.Modulator treadGain; 
	private SoundModulation.Modulator treadPitch; 
	public SoundDefinition chasisLurchSoundDef; 
	public float chasisLurchAngleDelta; 
	public float chasisLurchSpeedDelta; 
	private float lastAngle; 
	private float lastSpeed; 
	public SoundDefinition turretTurnLoopDef; 
	public float turretLoopGainSpeed; 
	public float turretLoopPitchSpeed; 
	public float turretLoopMinAngleDelta; 
	public float turretLoopMaxAngleDelta; 
	public float turretLoopPitchMin; 
	public float turretLoopPitchMax; 
	public float turretLoopGainThreshold; 
	private Sound turretTurnLoop; 
	private SoundModulation.Modulator turretTurnLoopGain; 
	private SoundModulation.Modulator turretTurnLoopPitch; 
	public float enginePitch; 
	public float rpmMultiplier; 
	private TreadAnimator treadAnimator; 
	private float lastTurretAngle; 
	[HeaderAttribute] 
	public List<Vector3> currentPath; 
	public int currentPathIndex; 
	public bool pathLooping; 
	[HeaderAttribute] 
	public float viewDistance; 
	public float searchRange; 
	public float searchFrequency; 
	public float memoryDuration; 
	public static float sightUpdateRate; 
	public List<BradleyAPC.TargetInfo> targetList; 
	[HeaderAttribute] 
	public float coaxFireRate; 
	public int coaxBurstLength; 
	public float coaxAimCone; 
	public float bulletDamage; 
	[HeaderAttribute] 
	public float topTurretFireRate; 
	public GameObjectRef gun_fire_effect; 
	public GameObjectRef bulletEffect; 
	private float lastLateUpdate; 
	[HeaderAttribute] 
	public WheelCollider[] leftWheels; 
	public WheelCollider[] rightWheels; 
	[HeaderAttribute] 
	public float moveForceMax; 
	public float brakeForce; 
	public float turnForce; 
	public float sideStiffnessMax; 
	public float sideStiffnessMin; 
	public Transform centerOfMass; 
	public float stoppingDist; 
	[HeaderAttribute] 
	public float throttle; 
	public float turning; 
	public float rightThrottle; 
	public float leftThrottle; 
	public bool brake; 
	[HeaderAttribute] 
	public Rigidbody myRigidBody; 
	public Collider myCollider; 
	public Vector3 destination; 
	private Vector3 finalDestination; 
	public Transform followTest; 
	public TriggerHurtEx impactDamager; 
	[HeaderAttribute] 
	public Transform mainTurretEyePos; 
	public Transform mainTurret; 
	public Transform CannonPitch; 
	public Transform CannonMuzzle; 
	public Transform coaxPitch; 
	public Transform coaxMuzzle; 
	public Transform topTurretEyePos; 
	public Transform topTurretYaw; 
	public Transform topTurretPitch; 
	public Transform topTurretMuzzle; 
	private Vector3 turretAimVector; 
	private Vector3 desiredAimVector; 
	private Vector3 topTurretAimVector; 
	private Vector3 desiredTopTurretAimVector; 
	[HeaderAttribute] 
	public GameObjectRef explosionEffect; 
	public GameObjectRef servergibs; 
	public GameObjectRef fireBall; 
	public GameObjectRef crateToDrop; 
	public GameObjectRef debrisFieldMarker; 
	[HeaderAttribute] 
	public int maxCratesToSpawn; 
	public int patrolPathIndex; 
	public BasePath patrolPath; 
	public bool DoAI; 
	public GameObjectRef mainCannonMuzzleFlash; 
	public GameObjectRef mainCannonProjectile; 
	public float recoilScale; 
	public NavMeshPath navMeshPath; 
	public int navMeshPathIndex; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void InitializeClientsideEffects() { }

	public void ShutdownClientsideEffects() { }

	public void UpdateSounds() { }

	[BaseEntity.RPC_Client] 
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	public void AimWeaponAt(Transform weaponYaw, Transform weaponPitch, Vector3 direction, float minPitch = -360, float maxPitch = 360, float maxYaw = 360, Transform parentOverride) { }

	public void LateUpdate() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override void ClientInit(Entity info) { }

	protected override void DoClientDestroy() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class BradleyAPC.TargetInfo : Pool.IPooled // TypeDefIndex: 10257
{
	public float damageReceivedFrom; 
	public BaseEntity entity; 
	public float lastSeenTime; 
	public Vector3 lastSeenPosition; 


	public void .ctor() { }

	public void EnterPool() { }

	public void Setup(BaseEntity ent, float time) { }

	public void LeavePool() { }

	public float GetPriorityScore(BradleyAPC apc) { }

	public bool IsVisible() { }

	public bool IsValid() { }

}

