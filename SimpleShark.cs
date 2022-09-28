public class SimpleShark : BaseCombatEntity // TypeDefIndex: 10597
{
	public Vector3 destination; 
	public float minSpeed; 
	public float maxSpeed; 
	public float idealDepth; 
	public float minTurnSpeed; 
	public float maxTurnSpeed; 
	public float attackCooldown; 
	public float aggroRange; 
	public float obstacleDetectionRadius; 
	public Animator animator; 
	public GameObjectRef bloodCloud; 
	public GameObjectRef corpsePrefab; 
	private static int param_speed; 
	private static int param_mouthOpen; 
	private float currentMouthOpen; 

	public override bool IsNpc { get; }


	public override bool get_IsNpc() { }

	public void Update() { }

	public void UpdateAnimations() { }

	public void .ctor() { }

	private static void .cctor() { }

}

