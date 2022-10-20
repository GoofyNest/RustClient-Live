public class BaseMelee : AttackEntity // TypeDefIndex: 10231
{
	[HeaderAttribute] 
	public bool canThrowAsProjectile; 
	public bool canAiHearIt; 
	public bool onlyThrowAsProjectile; 
	[HeaderAttribute] 
	public DamageProperties damageProperties; 
	public List<DamageTypeEntry> damageTypes; 
	public float maxDistance; 
	public float attackRadius; 
	public bool isAutomatic; 
	public bool blockSprintOnAttack; 
	[HeaderAttribute] 
	public GameObjectRef strikeFX; 
	public bool useStandardHitEffects; 
	[HeaderAttribute] 
	public float aiStrikeDelay; 
	public GameObjectRef swingEffect; 
	public List<BaseMelee.MaterialFX> materialStrikeFX; 
	[HeaderAttribute] 
	[RangeAttribute] 
	public float heartStress; 
	public ResourceDispenser.GatherProperties gathering; 
	private bool throwReady; 

	protected virtual bool CanAttack { get; }
	protected virtual bool CanThrow { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override Vector3 GetInheritedVelocity(BasePlayer player, Vector3 direction) { }

	internal void DoThrow() { }

	private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity) { }

	public override void GetAttackStats(HitInfo info) { }

	public virtual void DoAttackShared(HitInfo info) { }

	public override void OnInput() { }

	protected virtual bool get_CanAttack() { }

	protected virtual bool get_CanThrow() { }

	public virtual void ClientAttack() { }

	public override void OnHolstered() { }

	protected virtual void ProcessAttack(HitTest hit) { }

	protected virtual void DoAttack() { }

	public virtual void DoViewmodelImpact(HitTest test) { }

	public override void OnViewmodelEvent(string name) { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public ResourceDispenser.GatherPropertyEntry GetGatherInfoFromIndex(ResourceDispenser.GatherType index) { }

	public virtual bool CanHit(HitTest info) { }

	public float TotalDamage() { }

	public override bool CanBeUsedInWater() { }

	public virtual string GetStrikeEffectPath(string materialName) { }

	public void .ctor() { }

}

public class BaseMelee.MaterialFX // TypeDefIndex: 10232
{
	public string materialName; 
	public GameObjectRef fx; 


	public void .ctor() { }

}

