public class ChippyBoss : SpriteArcadeEntity // TypeDefIndex: 8766
{	// Fields
	public Vector2 roamDistance; // 0x98
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

	// Methods

	// RVA: 0x5537F0 Offset: 0x552BF0 VA: 0x1805537F0
	public void SetLevel(int newLevel) { }

	// RVA: 0x553600 Offset: 0x552A00 VA: 0x180553600 Slot: 6
	public override bool OnEntityMessage(string msg, bool predicted = False) { }

	// RVA: 0x553490 Offset: 0x552890 VA: 0x180553490
	public void Flash() { }

	// RVA: 0x553580 Offset: 0x552980 VA: 0x180553580 Slot: 11
	public override void Initialize() { }

	// RVA: 0x553790 Offset: 0x552B90 VA: 0x180553790
	public void RemoveMe() { }

	// RVA: 0x552FF0 Offset: 0x5523F0 VA: 0x180552FF0
	public void Animate() { }

	// RVA: 0x5534E0 Offset: 0x5528E0 VA: 0x1805534E0 Slot: 7
	public override void Hurt(ArcadeEntity damageSource, float damage, Vector3 hitPos, Collider collider) { }

	// RVA: 0x5536C0 Offset: 0x552AC0 VA: 0x1805536C0 Slot: 8
	public override void OnKilled() { }

	// RVA: 0x5530C0 Offset: 0x5524C0 VA: 0x1805530C0
	public void FixedUpdate() { }

	// RVA: 0x5538F0 Offset: 0x552CF0 VA: 0x1805538F0
	public void .ctor() { }

}

public class ChippyBoss.BossDamagePoint // TypeDefIndex: 8767
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

