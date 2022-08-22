public class SimpleShark : BaseCombatEntity // TypeDefIndex: 8925
{	public Vector3 destination; // 0x240
	public float minSpeed; // 0x24C
	public float maxSpeed; // 0x250
	public float idealDepth; // 0x254
	public float minTurnSpeed; // 0x258
	public float maxTurnSpeed; // 0x25C
	public float attackCooldown; // 0x260
	public float aggroRange; // 0x264
	public float obstacleDetectionRadius; // 0x268
	public Animator animator; // 0x270
	public GameObjectRef bloodCloud; // 0x278
	public GameObjectRef corpsePrefab; // 0x280
	private static int param_speed; // 0x0
	private static int param_mouthOpen; // 0x4
	private float currentMouthOpen; // 0x288

	public override bool IsNpc { get; }


	public override bool get_IsNpc() { }

	public void Update() { }

	public void UpdateAnimations() { }

	public void .ctor() { }

	private static void .cctor() { }

}

