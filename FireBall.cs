public class FireBall : BaseEntity, ISplashable // TypeDefIndex: 9541
{
	public float lifeTimeMin; 
	public float lifeTimeMax; 
	public ParticleSystem[] movementSystems; 
	public ParticleSystem[] restingSystems; 
	public float generation; 
	public GameObjectRef spreadSubEntity; 
	public float tickRate; 
	public float damagePerSecond; 
	public float radius; 
	public int waterToExtinguish; 
	public bool canMerge; 
	public LayerMask AttackLayers; 
	public bool ignoreNPC; 
	private bool wasResting; 


	public bool IsResting() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

