public class BaseCombatEntity : BaseEntity // TypeDefIndex: 10040
{
	private Option __menuOption_Menu_Pickup;
	[HeaderAttribute]
	public SkeletonProperties skeletonProperties;
	public ProtectionProperties baseProtection;
	public float startHealth;
	public BaseCombatEntity.Pickup pickup;
	public BaseCombatEntity.Repair repair;
	public bool ShowHealthInfo;
	public BaseCombatEntity.LifeState lifestate;
	public bool sendsHitNotification;
	public bool sendsMeleeHitNotification;
	public bool markAttackerHostile;
	protected float _health;
	protected float _maxHealth;
	public BaseCombatEntity.Faction faction;
	protected float deathTime;
	private int lastNotifyFrame;

	public override bool HasMenuOptions { get; }
	public float SecondsSinceDeath { get; }
	public float healthFraction { get; }
	public float health { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client]
	public void HitNotify(BaseEntity.RPCMessage rpc) { }

	protected override void ClientInit(Entity info) { }

	public virtual bool DisplayHealthInfo(BasePlayer player) { }

	internal override Transform GetEyeTransform() { }

	protected virtual void OnLifeStateChanged() { }

	protected virtual int GetPickupCount() { }

	public virtual bool CanPickup(BasePlayer player) { }

	public virtual void OnPickedUp(Item createdItem, BasePlayer player) { }

	public virtual void OnPickedUpPreItemMove(Item createdItem, BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Pickup(BasePlayer player) { }

	public void Menu_Pickup_TimeStart() { }

	public bool Menu_Pickup_If(BasePlayer player) { }

	public virtual List<ItemAmount> BuildCost() { }

	public virtual bool IsDead() { }

	public virtual bool IsAlive() { }

	public BaseCombatEntity.Faction GetFaction() { }

	public virtual bool IsFriendly(BaseCombatEntity other) { }

	public float get_SecondsSinceDeath() { }

	public float get_healthFraction() { }

	public override void ResetState() { }

	public override void DestroyShared() { }

	public virtual float GetThreatLevel() { }

	public override float PenetrationResistance(HitInfo info) { }

	public virtual void ScaleDamage(HitInfo info) { }

	public HitArea SkeletonLookup(uint boneID) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public float get_health() { }

	public void set_health(float value) { }

	public override float Health() { }

	public override float MaxHealth() { }

	public virtual float StartHealth() { }

	public virtual float StartMaxHealth() { }

	public void SetMaxHealth(float newMax) { }

	public void DoHitNotify(HitInfo info) { }

	public override void OnAttacked(HitInfo info) { }

	public void .ctor() { }

}

public struct BaseCombatEntity.Pickup // TypeDefIndex: 10041
{
	public bool enabled;
	[ItemSelector]
	public ItemDefinition itemTarget;
	public int itemCount;
	[TooltipAttribute]
	public bool setConditionFromHealth;
	[TooltipAttribute]
	public float subtractCondition;
	[TooltipAttribute]
	public bool requireBuildingPrivilege;
	[TooltipAttribute]
	public bool requireHammer;
	[TooltipAttribute]
	public bool requireEmptyInv;

}

public struct BaseCombatEntity.Repair // TypeDefIndex: 10042
{
	public bool enabled;
	[ItemSelector]
	public ItemDefinition itemTarget;
	public GameObjectRef repairEffect;
	public GameObjectRef repairFullEffect;
	public GameObjectRef repairFailedEffect;

}

public enum BaseCombatEntity.LifeState // TypeDefIndex: 10043
{
	public int value__;
	public const BaseCombatEntity.LifeState Alive = 0;
	public const BaseCombatEntity.LifeState Dead = 1;

}

public enum BaseCombatEntity.Faction // TypeDefIndex: 10044
{
	public int value__;
	public const BaseCombatEntity.Faction Default = 0;
	public const BaseCombatEntity.Faction Player = 1;
	public const BaseCombatEntity.Faction Bandit = 2;
	public const BaseCombatEntity.Faction Scientist = 3;
	public const BaseCombatEntity.Faction Horror = 4;

}

