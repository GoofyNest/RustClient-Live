public class PatrolHelicopterAI : BaseMonoBehaviour // TypeDefIndex: 9601
{	public List<PatrolHelicopterAI.targetinfo> _targetList; // 0x18
	public Vector3 interestZoneOrigin; // 0x20
	public Vector3 destination; // 0x2C
	public bool hasInterestZone; // 0x38
	public float moveSpeed; // 0x3C
	public float maxSpeed; // 0x40
	public float courseAdjustLerpTime; // 0x44
	public Quaternion targetRotation; // 0x48
	public Vector3 windVec; // 0x58
	public Vector3 targetWindVec; // 0x64
	public float windForce; // 0x70
	public float windFrequency; // 0x74
	public float targetThrottleSpeed; // 0x78
	public float throttleSpeed; // 0x7C
	public float maxRotationSpeed; // 0x80
	public float rotationSpeed; // 0x84
	public float terrainPushForce; // 0x88
	public float obstaclePushForce; // 0x8C
	public HelicopterTurret leftGun; // 0x90
	public HelicopterTurret rightGun; // 0x98
	public static PatrolHelicopterAI heliInstance; // 0x0
	public BaseHelicopter helicopterBase; // 0xA0
	public PatrolHelicopterAI.aiState _currentState; // 0xA8
	public List<MonumentInfo> _visitedMonuments; // 0xB0
	public float arrivalTime; // 0xB8
	public GameObjectRef rocketProjectile; // 0xC0
	public GameObjectRef rocketProjectile_Napalm; // 0xC8


	public void .ctor() { }

}

public class PatrolHelicopterAI.targetinfo // TypeDefIndex: 9602
{	public BasePlayer ply; // 0x10
	public BaseEntity ent; // 0x18
	public float lastSeenTime; // 0x20
	public float visibleFor; // 0x24
	public float nextLOSCheck; // 0x28


	public void .ctor(BaseEntity initEnt, BasePlayer initPly) { }

	public bool IsVisible() { }

	public float TimeSinceSeen() { }

}

public enum PatrolHelicopterAI.aiState // TypeDefIndex: 9603
{	public int value__; // 0x0
	public const PatrolHelicopterAI.aiState IDLE = 0;
	public const PatrolHelicopterAI.aiState MOVE = 1;
	public const PatrolHelicopterAI.aiState ORBIT = 2;
	public const PatrolHelicopterAI.aiState STRAFE = 3;
	public const PatrolHelicopterAI.aiState PATROL = 4;
	public const PatrolHelicopterAI.aiState GUARD = 5;
	public const PatrolHelicopterAI.aiState DEATH = 6;

}

