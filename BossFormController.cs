public class BossFormController : ArcadeEntityController // TypeDefIndex: 8763
{	public float animationSpeed; // 0x38
	public Sprite[] animationFrames; // 0x40
	public Vector2 roamDistance; // 0x48
	public Transform colliderParent; // 0x50
	public BossFormController.BossDamagePoint[] damagePoints; // 0x58
	public ArcadeEntityController flashController; // 0x60
	public float health; // 0x68
	private int currentFrame; // 0x6C
	private int animDirection; // 0x70


	public override void Initialize() { }

	public bool MainCoreVulnerable() { }

	public BossFormController.BossDamagePoint GetDamagePointFromCollider(Collider collider) { }

	public void Hurt(float damage, Vector3 hitPos, Collider collider) { }

	public void RemoveMe() { }

	public void Animate() { }

	public void UpdateDamagePositions() { }

	public override void Shutdown() { }

	public void FixedUpdate() { }

	public void .ctor() { }

}

public class BossFormController.BossDamagePoint // TypeDefIndex: 8764
{	public BoxCollider hitBox; // 0x10
	public float health; // 0x18
	public ArcadeEntityController damagePrefab; // 0x20
	public ArcadeEntityController damageInstance; // 0x28
	public bool destroyed; // 0x30


	public void .ctor() { }

}

