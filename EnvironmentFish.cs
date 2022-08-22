public class EnvironmentFish : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8948
{	public Animator animator; // 0x18
	public float minSpeed; // 0x20
	public float maxSpeed; // 0x24
	public float idealDepth; // 0x28
	public float minTurnSpeed; // 0x2C
	public float maxTurnSpeed; // 0x30
	public Vector3 destination; // 0x34
	public Vector3 spawnPos; // 0x40
	public Vector3 idealLocalScale; // 0x4C
	private float lastStartleTime; // 0x58
	private float startleDuration; // 0x5C
	private float currentSpeed; // 0x60
	private static BasePlayer[] playerQueryResults; // 0x0
	private float nextPlayerFleeTime; // 0x64
	public bool inQueue; // 0x68
	private float nextInvalidCheckTime; // 0x6C
	private bool cachedPositionInvalid; // 0x70
	private float nextDestinationTime; // 0x74


	public void Startle() { }

	public bool IsStartled() { }

	public void Start() { }

	private float GetDesiredSpeed() { }

	public float GetTurnSpeed() { }

	private float GetCurrentSpeed() { }

	private void UpdateDirection(float delta) { }

	public void QueuedUpdate() { }

	public void CheckForCollisions() { }

	private void UpdatePosition(float delta) { }

	private void UpdateSpeed(float delta) { }

	public bool InvalidPosition() { }

	private void Update() { }

	private void UpdateDestination() { }

	public void .ctor() { }

	private static void .cctor() { }

}

