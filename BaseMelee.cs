public class BaseMelee : AttackEntity // TypeDefIndex: 8523
{	[HeaderAttribute] // RVA: 0xA29D0 Offset: 0xA1DD0 VA: 0x1800A29D0
	public bool canThrowAsProjectile; // 0x280
	public bool canAiHearIt; // 0x281
	public bool onlyThrowAsProjectile; // 0x282
	[HeaderAttribute] // RVA: 0xA2AA0 Offset: 0xA1EA0 VA: 0x1800A2AA0
	public DamageProperties damageProperties; // 0x288
	public List<DamageTypeEntry> damageTypes; // 0x290
	public float maxDistance; // 0x298
	public float attackRadius; // 0x29C
	public bool isAutomatic; // 0x2A0
	public bool blockSprintOnAttack; // 0x2A1
	[HeaderAttribute] // RVA: 0x785E0 Offset: 0x779E0 VA: 0x1800785E0
	public GameObjectRef strikeFX; // 0x2A8
	public bool useStandardHitEffects; // 0x2B0
	[HeaderAttribute] // RVA: 0x715C0 Offset: 0x709C0 VA: 0x1800715C0
	public float aiStrikeDelay; // 0x2B4
	public GameObjectRef swingEffect; // 0x2B8
	public List<BaseMelee.MaterialFX> materialStrikeFX; // 0x2C0
	[HeaderAttribute] // RVA: 0xA2C60 Offset: 0xA2060 VA: 0x1800A2C60
	[RangeAttribute] // RVA: 0xA2C60 Offset: 0xA2060 VA: 0x1800A2C60
	public float heartStress; // 0x2C8
	public ResourceDispenser.GatherProperties gathering; // 0x2D0
	private bool throwReady; // 0x2D8

	protected virtual bool CanAttack { get; }
	protected virtual bool CanThrow { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

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

	public string GetStrikeEffectPath(string materialName) { }

	public void .ctor() { }

}

public class BaseMelee.MaterialFX // TypeDefIndex: 8524
{	public string materialName; // 0x10
	public GameObjectRef fx; // 0x18


	public void .ctor() { }

}

