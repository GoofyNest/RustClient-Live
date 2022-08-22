public class ChippyBoss : SpriteArcadeEntity // TypeDefIndex: 8766
{	public Vector2 roamDistance; // 0x98
	public float animationSpeed; // 0xA0
	public Sprite[] animationFrames; // 0xA8
	public ArcadeEntity bulletTest; // 0xB0
	public SpriteRenderer flashRenderer; // 0xB8
	public ChippyBoss.BossDamagePoint[] damagePoints; // 0xC0
	private float moveSpeed; // 0xC8
	private int bossLevel; // 0xCC
	private float fireRate; // 0xD0
	private int currentFrame; // 0xD4
	private int animDirection; // 0xD8
	private float nextBulletTime; // 0xDC


	public void SetLevel(int newLevel) { }

	public override bool OnEntityMessage(string msg, bool predicted = False) { }

	public void Flash() { }

	public override void Initialize() { }

	public void RemoveMe() { }

	public void Animate() { }

	public override void Hurt(ArcadeEntity damageSource, float damage, Vector3 hitPos, Collider collider) { }

	public override void OnKilled() { }

	public void FixedUpdate() { }

	public void .ctor() { }

}

public class ChippyBoss.BossDamagePoint // TypeDefIndex: 8767
{	public BoxCollider hitBox; // 0x10
	public float health; // 0x18
	public ArcadeEntityController damagePrefab; // 0x20
	public ArcadeEntityController damageInstance; // 0x28
	public bool destroyed; // 0x30


	public void .ctor() { }

}

