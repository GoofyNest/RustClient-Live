public class HitTest // TypeDefIndex: 11621
{
	public HitTest.Type type; 
	public Ray AttackRay; 
	public float Radius; 
	public float Forgiveness; 
	public float MaxDistance; 
	public RaycastHit RayHit; 
	public bool MultiHit; 
	public bool BestHit; 
	public bool DidHit; 
	public DamageProperties damageProperties; 
	public GameObject gameObject; 
	public Collider collider; 
	public BaseEntity ignoreEntity; 
	public BaseEntity HitEntity; 
	public Vector3 HitPoint; 
	public Vector3 HitNormal; 
	public float HitDistance; 
	public Transform HitTransform; 
	public uint HitPart; 
	public string HitMaterial; 


	public Vector3 HitPointWorld() { }

	public Vector3 HitNormalWorld() { }

	public Attack BuildAttackMessage() { }

	public void Clear() { }

	public void .ctor() { }

}

public enum HitTest.Type // TypeDefIndex: 11622
{
	public int value__; 
	public const HitTest.Type Generic = 0;
	public const HitTest.Type ProjectileEffect = 1;
	public const HitTest.Type Projectile = 2;
	public const HitTest.Type MeleeAttack = 3;
	public const HitTest.Type Use = 4;

}

