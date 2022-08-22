public class TimedExplosive : BaseEntity // TypeDefIndex: 9683
{	public float timerAmountMin; // 0x168
	public float timerAmountMax; // 0x16C
	public float minExplosionRadius; // 0x170
	public float explosionRadius; // 0x174
	public bool explodeOnContact; // 0x178
	public bool canStick; // 0x179
	public bool onlyDamageParent; // 0x17A
	public GameObjectRef explosionEffect; // 0x180
	[TooltipAttribute] // RVA: 0x84140 Offset: 0x83540 VA: 0x180084140
	public GameObjectRef underwaterExplosionEffect; // 0x188
	public GameObjectRef stickEffect; // 0x190
	public GameObjectRef bounceEffect; // 0x198
	public bool explosionUsesForward; // 0x1A0
	public bool waterCausesExplosion; // 0x1A1
	public List<DamageTypeEntry> damageTypes; // 0x1A8
	private float lastBounceTime; // 0x1B0


	public override void DoDestroyEffects(BaseNetworkable.DestroyMode mode, Message msg) { }

	public override float GetExtrapolationTime() { }

	public virtual void SetCollisionEnabled(bool wantsCollision) { }

	public void .ctor() { }

}

