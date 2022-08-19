public class HitInfo // TypeDefIndex: 9899
{	// Fields
	public BaseEntity Initiator; // 0x10
	public BaseEntity WeaponPrefab; // 0x18
	public AttackEntity Weapon; // 0x20
	public bool DoHitEffects; // 0x28
	public bool DoDecals; // 0x29
	public bool IsPredicting; // 0x2A
	public bool UseProtection; // 0x2B
	public Connection Predicted; // 0x30
	public bool DidHit; // 0x38
	public BaseEntity HitEntity; // 0x40
	public uint HitBone; // 0x48
	public uint HitPart; // 0x4C
	public uint HitMaterial; // 0x50
	public Vector3 HitPositionWorld; // 0x54
	public Vector3 HitPositionLocal; // 0x60
	public Vector3 HitNormalWorld; // 0x6C
	public Vector3 HitNormalLocal; // 0x78
	public Vector3 PointStart; // 0x84
	public Vector3 PointEnd; // 0x90
	public int ProjectileID; // 0x9C
	public int ProjectileHits; // 0xA0
	public float ProjectileDistance; // 0xA4
	public float ProjectileIntegrity; // 0xA8
	public float ProjectileTravelTime; // 0xAC
	public float ProjectileTrajectoryMismatch; // 0xB0
	public Vector3 ProjectileVelocity; // 0xB4
	public Projectile ProjectilePrefab; // 0xC0
	public PhysicMaterial material; // 0xC8
	public DamageProperties damageProperties; // 0xD0
	public DamageTypeList damageTypes; // 0xD8
	public bool CanGather; // 0xE0
	public bool DidGather; // 0xE1
	public float gatherScale; // 0xE4

	// Properties
	public BasePlayer InitiatorPlayer { get; }
	public Vector3 attackNormal { get; }
	public bool hasDamage { get; }
	public bool isHeadshot { get; }
	public Translate.Phrase bonePhrase { get; }
	public string boneName { get; }
	public HitArea boneArea { get; }

	// Methods

	// RVA: 0x755AD0 Offset: 0x754ED0 VA: 0x180755AD0
	public bool IsProjectile() { }

	// RVA: 0x756320 Offset: 0x755720 VA: 0x180756320
	public BasePlayer get_InitiatorPlayer() { }

	// RVA: 0x7563B0 Offset: 0x7557B0 VA: 0x1807563B0
	public Vector3 get_attackNormal() { }

	// RVA: 0x7568B0 Offset: 0x755CB0 VA: 0x1807568B0
	public bool get_hasDamage() { }

	// RVA: 0x756140 Offset: 0x755540 VA: 0x180756140
	public void .ctor() { }

	// RVA: 0x7561C0 Offset: 0x7555C0 VA: 0x1807561C0
	public void .ctor(BaseEntity attacker, BaseEntity target, DamageType type, float damageAmount, Vector3 vhitPosition) { }

	// RVA: 0x755F90 Offset: 0x755390 VA: 0x180755F90
	public void .ctor(BaseEntity attacker, BaseEntity target, DamageType type, float damageAmount) { }

	// RVA: 0x755AE0 Offset: 0x754EE0 VA: 0x180755AE0
	public void LoadFromAttack(Attack attack, bool serverSide) { }

	// RVA: 0x7568E0 Offset: 0x755CE0 VA: 0x1807568E0
	public bool get_isHeadshot() { }

	// RVA: 0x756750 Offset: 0x755B50 VA: 0x180756750
	public Translate.Phrase get_bonePhrase() { }

	// RVA: 0x7565C0 Offset: 0x7559C0 VA: 0x1807565C0
	public string get_boneName() { }

	// RVA: 0x7564B0 Offset: 0x7558B0 VA: 0x1807564B0
	public HitArea get_boneArea() { }

	// RVA: 0x755CE0 Offset: 0x7550E0 VA: 0x180755CE0
	public Vector3 PositionOnRay(Vector3 position) { }

	// RVA: 0x7558A0 Offset: 0x754CA0 VA: 0x1807558A0
	public Vector3 HitPositionOnRay() { }

	// RVA: 0x7558F0 Offset: 0x754CF0 VA: 0x1807558F0
	public bool IsNaNOrInfinity() { }

}

