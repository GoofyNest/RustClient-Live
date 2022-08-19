public class BaseMelee : AttackEntity // TypeDefIndex: 8523
{	// Fields
	[HeaderAttribute] // RVA: 0xA29D0 Offset: 0xA1DD0 VA: 0x1800A29D0
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

	// Properties
	protected virtual bool CanAttack { get; }
	protected virtual bool CanThrow { get; }

	// Methods

	// RVA: 0xA24EE0 Offset: 0xA242E0 VA: 0x180A24EE0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x84DCC0 Offset: 0x84D0C0 VA: 0x18084DCC0 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0xA24200 Offset: 0xA23600 VA: 0x180A24200
	internal void DoThrow() { }

	// RVA: 0xA23BC0 Offset: 0xA22FC0 VA: 0x180A23BC0
	private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity) { }

	// RVA: 0xA248F0 Offset: 0xA23CF0 VA: 0x180A248F0 Slot: 158
	public override void GetAttackStats(HitInfo info) { }

	// RVA: 0xA23D70 Offset: 0xA23170 VA: 0x180A23D70 Slot: 160
	public virtual void DoAttackShared(HitInfo info) { }

	// RVA: 0xA24B00 Offset: 0xA23F00 VA: 0x180A24B00 Slot: 138
	public override void OnInput() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 161
	protected virtual bool get_CanAttack() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 162
	protected virtual bool get_CanThrow() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 163
	public virtual void ClientAttack() { }

	// RVA: 0xA24AE0 Offset: 0xA23EE0 VA: 0x180A24AE0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0xA25090 Offset: 0xA24490 VA: 0x180A25090 Slot: 164
	protected virtual void ProcessAttack(HitTest hit) { }

	// RVA: 0xA23FC0 Offset: 0xA233C0 VA: 0x180A23FC0 Slot: 165
	protected virtual void DoAttack() { }

	// RVA: 0xA24860 Offset: 0xA23C60 VA: 0x180A24860 Slot: 166
	public virtual void DoViewmodelImpact(HitTest test) { }

	// RVA: 0xA24FD0 Offset: 0xA243D0 VA: 0x180A24FD0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0xA253D0 Offset: 0xA247D0 VA: 0x180A253D0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0xA25320 Offset: 0xA24720 VA: 0x180A25320 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA24950 Offset: 0xA23D50 VA: 0x180A24950
	public ResourceDispenser.GatherPropertyEntry GetGatherInfoFromIndex(ResourceDispenser.GatherType index) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 167
	public virtual bool CanHit(HitTest info) { }

	// RVA: 0xA25480 Offset: 0xA24880 VA: 0x180A25480
	public float TotalDamage() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 154
	public override bool CanBeUsedInWater() { }

	// RVA: 0xA24980 Offset: 0xA23D80 VA: 0x180A24980
	public string GetStrikeEffectPath(string materialName) { }

	// RVA: 0xA255E0 Offset: 0xA249E0 VA: 0x180A255E0
	public void .ctor() { }

}

public class BaseMelee.MaterialFX // TypeDefIndex: 8524
{	// Fields
	public string materialName; // 0x10
	public GameObjectRef fx; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

