public class TimedExplosive : BaseEntity // TypeDefIndex: 9688
{
	public float timerAmountMin; 
	public float timerAmountMax; 
	public float minExplosionRadius; 
	public float explosionRadius; 
	public bool explodeOnContact; 
	public bool canStick; 
	public bool onlyDamageParent; 
	public GameObjectRef explosionEffect; 
	[TooltipAttribute] 
	public GameObjectRef underwaterExplosionEffect; 
	public GameObjectRef stickEffect; 
	public GameObjectRef bounceEffect; 
	public bool explosionUsesForward; 
	public bool waterCausesExplosion; 
	public List<DamageTypeEntry> damageTypes; 
	private float lastBounceTime; 


	public override void DoDestroyEffects(BaseNetworkable.DestroyMode mode, Message msg) { }

	public override float GetExtrapolationTime() { }

	public virtual void SetCollisionEnabled(bool wantsCollision) { }

	public void .ctor() { }

}

