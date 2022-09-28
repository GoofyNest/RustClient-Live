public class EnvironmentFish : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 10620
{
	public Animator animator; 
	public float minSpeed; 
	public float maxSpeed; 
	public float idealDepth; 
	public float minTurnSpeed; 
	public float maxTurnSpeed; 
	public Vector3 destination; 
	public Vector3 spawnPos; 
	public Vector3 idealLocalScale; 
	private float lastStartleTime; 
	private float startleDuration; 
	private float currentSpeed; 
	private static BasePlayer[] playerQueryResults; 
	private float nextPlayerFleeTime; 
	public bool inQueue; 
	private float nextInvalidCheckTime; 
	private bool cachedPositionInvalid; 
	private float nextDestinationTime; 


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

