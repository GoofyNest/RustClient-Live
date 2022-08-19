public class SimpleShark : BaseCombatEntity // TypeDefIndex: 8925
{	// Fields
	public Vector3 destination; // 0x240
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

	// Properties
	public override bool IsNpc { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 98
	public override bool get_IsNpc() { }

	// RVA: 0x5B7020 Offset: 0x5B6420 VA: 0x1805B7020
	public void Update() { }

	// RVA: 0x5B6E70 Offset: 0x5B6270 VA: 0x1805B6E70
	public void UpdateAnimations() { }

	// RVA: 0x5B7250 Offset: 0x5B6650 VA: 0x1805B7250
	public void .ctor() { }

	// RVA: 0x5B71E0 Offset: 0x5B65E0 VA: 0x1805B71E0
	private static void .cctor() { }

}

