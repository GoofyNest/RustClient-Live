public class ChippyBoss : SpriteArcadeEntity // TypeDefIndex: 10492
{
	public Vector2 roamDistance;
	public float animationSpeed;
	public Sprite[] animationFrames;
	public ArcadeEntity bulletTest;
	public SpriteRenderer flashRenderer;
	public ChippyBoss.BossDamagePoint[] damagePoints;
	private float moveSpeed;
	private int bossLevel;
	private float fireRate;
	private int currentFrame;
	private int animDirection;
	private float nextBulletTime;


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

public class ChippyBoss.BossDamagePoint // TypeDefIndex: 10493
{
	public BoxCollider hitBox;
	public float health;
	public ArcadeEntityController damagePrefab;
	public ArcadeEntityController damageInstance;
	public bool destroyed;


	public void .ctor() { }

}

