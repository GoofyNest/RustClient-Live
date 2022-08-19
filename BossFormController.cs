public class BossFormController : ArcadeEntityController // TypeDefIndex: 8763
{	// Fields
	public float animationSpeed; // 0x38
	public Sprite[] animationFrames; // 0x40
	public Vector2 roamDistance; // 0x48
	public Transform colliderParent; // 0x50
	public BossFormController.BossDamagePoint[] damagePoints; // 0x58
	public ArcadeEntityController flashController; // 0x60
	public float health; // 0x68
	private int currentFrame; // 0x6C
	private int animDirection; // 0x70

	// Methods

	// RVA: 0x535A60 Offset: 0x534E60 VA: 0x180535A60 Slot: 6
	public override void Initialize() { }

	// RVA: 0x535AE0 Offset: 0x534EE0 VA: 0x180535AE0
	public bool MainCoreVulnerable() { }

	// RVA: 0x5356C0 Offset: 0x534AC0 VA: 0x1805356C0
	public BossFormController.BossDamagePoint GetDamagePointFromCollider(Collider collider) { }

	// RVA: 0x5357A0 Offset: 0x534BA0 VA: 0x1805357A0
	public void Hurt(float damage, Vector3 hitPos, Collider collider) { }

	// RVA: 0x535B50 Offset: 0x534F50 VA: 0x180535B50
	public void RemoveMe() { }

	// RVA: 0x535310 Offset: 0x534710 VA: 0x180535310
	public void Animate() { }

	// RVA: 0x535CD0 Offset: 0x5350D0 VA: 0x180535CD0
	public void UpdateDamagePositions() { }

	// RVA: 0x535BB0 Offset: 0x534FB0 VA: 0x180535BB0 Slot: 7
	public override void Shutdown() { }

	// RVA: 0x5353A0 Offset: 0x5347A0 VA: 0x1805353A0
	public void FixedUpdate() { }

	// RVA: 0x535E40 Offset: 0x535240 VA: 0x180535E40
	public void .ctor() { }

}

public class BossFormController.BossDamagePoint // TypeDefIndex: 8764
{	// Fields
	public BoxCollider hitBox; // 0x10
	public float health; // 0x18
	public ArcadeEntityController damagePrefab; // 0x20
	public ArcadeEntityController damageInstance; // 0x28
	public bool destroyed; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

