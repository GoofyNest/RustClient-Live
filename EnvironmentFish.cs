public class EnvironmentFish : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8948
{	// Fields
	public Animator animator; // 0x18
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

	// Methods

	// RVA: 0x8B8530 Offset: 0x8B7930 VA: 0x1808B8530
	public void Startle() { }

	// RVA: 0x8B8490 Offset: 0x8B7890 VA: 0x1808B8490
	public bool IsStartled() { }

	// RVA: 0x8B84D0 Offset: 0x8B78D0 VA: 0x1808B84D0
	public void Start() { }

	// RVA: 0x8B8290 Offset: 0x8B7690 VA: 0x1808B8290
	private float GetDesiredSpeed() { }

	// RVA: 0x8B82E0 Offset: 0x8B76E0 VA: 0x1808B82E0
	public float GetTurnSpeed() { }

	// RVA: 0x51BCC0 Offset: 0x51B0C0 VA: 0x18051BCC0
	private float GetCurrentSpeed() { }

	// RVA: 0x8B86D0 Offset: 0x8B7AD0 VA: 0x1808B86D0
	private void UpdateDirection(float delta) { }

	// RVA: 0x8B84C0 Offset: 0x8B78C0 VA: 0x1808B84C0
	public void QueuedUpdate() { }

	// RVA: 0x8B7CA0 Offset: 0x8B70A0 VA: 0x1808B7CA0
	public void CheckForCollisions() { }

	// RVA: 0x8B88C0 Offset: 0x8B7CC0 VA: 0x1808B88C0
	private void UpdatePosition(float delta) { }

	// RVA: 0x8B8B00 Offset: 0x8B7F00 VA: 0x1808B8B00
	private void UpdateSpeed(float delta) { }

	// RVA: 0x8B8330 Offset: 0x8B7730 VA: 0x1808B8330
	public bool InvalidPosition() { }

	// RVA: 0x8B8BC0 Offset: 0x8B7FC0 VA: 0x1808B8BC0
	private void Update() { }

	// RVA: 0x8B8550 Offset: 0x8B7950 VA: 0x1808B8550
	private void UpdateDestination() { }

	// RVA: 0x8B9360 Offset: 0x8B8760 VA: 0x1808B9360
	public void .ctor() { }

	// RVA: 0x8B9310 Offset: 0x8B8710 VA: 0x1808B9310
	private static void .cctor() { }

}

