public class FireBall : BaseEntity, ISplashable // TypeDefIndex: 9537
{	public float lifeTimeMin; // 0x168
	public float lifeTimeMax; // 0x16C
	public ParticleSystem[] movementSystems; // 0x170
	public ParticleSystem[] restingSystems; // 0x178
	public float generation; // 0x180
	public GameObjectRef spreadSubEntity; // 0x188
	public float tickRate; // 0x190
	public float damagePerSecond; // 0x194
	public float radius; // 0x198
	public int waterToExtinguish; // 0x19C
	public bool canMerge; // 0x1A0
	public LayerMask AttackLayers; // 0x1A4
	public bool ignoreNPC; // 0x1A8
	private bool wasResting; // 0x1A9


	public bool IsResting() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

