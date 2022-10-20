public class PatrolHelicopterAI : BaseMonoBehaviour // TypeDefIndex: 11321
{
	public List<PatrolHelicopterAI.targetinfo> _targetList; 
	public Vector3 interestZoneOrigin; 
	public Vector3 destination; 
	public bool hasInterestZone; 
	public float moveSpeed; 
	public float maxSpeed; 
	public float courseAdjustLerpTime; 
	public Quaternion targetRotation; 
	public Vector3 windVec; 
	public Vector3 targetWindVec; 
	public float windForce; 
	public float windFrequency; 
	public float targetThrottleSpeed; 
	public float throttleSpeed; 
	public float maxRotationSpeed; 
	public float rotationSpeed; 
	public float terrainPushForce; 
	public float obstaclePushForce; 
	public HelicopterTurret leftGun; 
	public HelicopterTurret rightGun; 
	public static PatrolHelicopterAI heliInstance; 
	public BaseHelicopter helicopterBase; 
	public PatrolHelicopterAI.aiState _currentState; 
	public List<MonumentInfo> _visitedMonuments; 
	public float arrivalTime; 
	public GameObjectRef rocketProjectile; 
	public GameObjectRef rocketProjectile_Napalm; 


	public void .ctor() { }

}

public class PatrolHelicopterAI.targetinfo // TypeDefIndex: 11322
{
	public BasePlayer ply; 
	public BaseEntity ent; 
	public float lastSeenTime; 
	public float visibleFor; 
	public float nextLOSCheck; 


	public void .ctor(BaseEntity initEnt, BasePlayer initPly) { }

	public bool IsVisible() { }

	public float TimeSinceSeen() { }

}

public enum PatrolHelicopterAI.aiState // TypeDefIndex: 11323
{
	public int value__; 
	public const PatrolHelicopterAI.aiState IDLE = 0;
	public const PatrolHelicopterAI.aiState MOVE = 1;
	public const PatrolHelicopterAI.aiState ORBIT = 2;
	public const PatrolHelicopterAI.aiState STRAFE = 3;
	public const PatrolHelicopterAI.aiState PATROL = 4;
	public const PatrolHelicopterAI.aiState GUARD = 5;
	public const PatrolHelicopterAI.aiState DEATH = 6;

}

