public class HitInfo // TypeDefIndex: 9899
{	public BaseEntity Initiator; // 0x10
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

	public BasePlayer InitiatorPlayer { get; }
	public Vector3 attackNormal { get; }
	public bool hasDamage { get; }
	public bool isHeadshot { get; }
	public Translate.Phrase bonePhrase { get; }
	public string boneName { get; }
	public HitArea boneArea { get; }


	public bool IsProjectile() { }

	public BasePlayer get_InitiatorPlayer() { }

	public Vector3 get_attackNormal() { }

	public bool get_hasDamage() { }

	public void .ctor() { }

	public void .ctor(BaseEntity attacker, BaseEntity target, DamageType type, float damageAmount, Vector3 vhitPosition) { }

	public void .ctor(BaseEntity attacker, BaseEntity target, DamageType type, float damageAmount) { }

	public void LoadFromAttack(Attack attack, bool serverSide) { }

	public bool get_isHeadshot() { }

	public Translate.Phrase get_bonePhrase() { }

	public string get_boneName() { }

	public HitArea get_boneArea() { }

	public Vector3 PositionOnRay(Vector3 position) { }

	public Vector3 HitPositionOnRay() { }

	public bool IsNaNOrInfinity() { }

}

