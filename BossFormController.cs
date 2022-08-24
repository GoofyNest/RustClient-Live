public class BossFormController : ArcadeEntityController // TypeDefIndex: 8763
{
	public float animationSpeed; 
	public Sprite[] animationFrames; 
	public Vector2 roamDistance; 
	public Transform colliderParent; 
	public BossFormController.BossDamagePoint[] damagePoints; 
	public ArcadeEntityController flashController; 
	public float health; 
	private int currentFrame; 
	private int animDirection; 


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
{
	public BoxCollider hitBox; 
	public float health; 
	public ArcadeEntityController damagePrefab; 
	public ArcadeEntityController damageInstance; 
	public bool destroyed; 


	public void .ctor() { }

}

