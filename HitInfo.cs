public class HitInfo // TypeDefIndex: 11574
{
	public BaseEntity Initiator; 
	public BaseEntity WeaponPrefab; 
	public AttackEntity Weapon; 
	public bool DoHitEffects; 
	public bool DoDecals; 
	public bool IsPredicting; 
	public bool UseProtection; 
	public Connection Predicted; 
	public bool DidHit; 
	public BaseEntity HitEntity; 
	public uint HitBone; 
	public uint HitPart; 
	public uint HitMaterial; 
	public Vector3 HitPositionWorld; 
	public Vector3 HitPositionLocal; 
	public Vector3 HitNormalWorld; 
	public Vector3 HitNormalLocal; 
	public Vector3 PointStart; 
	public Vector3 PointEnd; 
	public int ProjectileID; 
	public int ProjectileHits; 
	public float ProjectileDistance; 
	public float ProjectileIntegrity; 
	public float ProjectileTravelTime; 
	public float ProjectileTrajectoryMismatch; 
	public Vector3 ProjectileVelocity; 
	public Projectile ProjectilePrefab; 
	public PhysicMaterial material; 
	public DamageProperties damageProperties; 
	public DamageTypeList damageTypes; 
	public bool CanGather; 
	public bool DidGather; 
	public float gatherScale; 

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

