public class BaseCombatEntity : BaseEntity // TypeDefIndex: 8319
{	// Fields
	private Option __menuOption_Menu_Pickup; // 0x168
	[HeaderAttribute] // RVA: 0xB4BB0 Offset: 0xB3FB0 VA: 0x1800B4BB0
	public SkeletonProperties skeletonProperties; // 0x1C0
	public ProtectionProperties baseProtection; // 0x1C8
	public float startHealth; // 0x1D0
	public BaseCombatEntity.Pickup pickup; // 0x1D8
	public BaseCombatEntity.Repair repair; // 0x1F8
	public bool ShowHealthInfo; // 0x220
	public BaseCombatEntity.LifeState lifestate; // 0x224
	public bool sendsHitNotification; // 0x228
	public bool sendsMeleeHitNotification; // 0x229
	public bool markAttackerHostile; // 0x22A
	protected float _health; // 0x22C
	protected float _maxHealth; // 0x230
	public BaseCombatEntity.Faction faction; // 0x234
	protected float deathTime; // 0x238
	private int lastNotifyFrame; // 0x23C

	// Properties
	public override bool HasMenuOptions { get; }
	public float SecondsSinceDeath { get; }
	public float healthFraction { get; }
	public float health { get; set; }

	// Methods

	// RVA: 0x7EF590 Offset: 0x7EE990 VA: 0x1807EF590 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7F0790 Offset: 0x7EFB90 VA: 0x1807F0790 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7EFCE0 Offset: 0x7EF0E0 VA: 0x1807EFCE0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7EF8F0 Offset: 0x7EECF0 VA: 0x1807EF8F0
	public void HitNotify(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x7EEFA0 Offset: 0x7EE3A0 VA: 0x1807EEFA0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x502E90 Offset: 0x502290 VA: 0x180502E90 Slot: 131
	public virtual bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x7EF470 Offset: 0x7EE870 VA: 0x1807EF470 Slot: 71
	internal override Transform GetEyeTransform() { }

	// RVA: 0x7EFCB0 Offset: 0x7EF0B0 VA: 0x1807EFCB0 Slot: 132
	protected virtual void OnLifeStateChanged() { }

	// RVA: 0x7EF8D0 Offset: 0x7EECD0 VA: 0x1807EF8D0 Slot: 133
	protected virtual int GetPickupCount() { }

	// RVA: 0x7EEF00 Offset: 0x7EE300 VA: 0x1807EEF00 Slot: 134
	public virtual bool CanPickup(BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 135
	public virtual void OnPickedUp(Item createdItem, BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 136
	public virtual void OnPickedUpPreItemMove(Item createdItem, BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB61B0 Offset: 0xB55B0 VA: 0x1800B61B0
	[BaseEntity.Menu.Description] // RVA: 0xB61B0 Offset: 0xB55B0 VA: 0x1800B61B0
	[BaseEntity.Menu.Icon] // RVA: 0xB61B0 Offset: 0xB55B0 VA: 0x1800B61B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB61B0 Offset: 0xB55B0 VA: 0x1800B61B0
	// RVA: 0x7EFB80 Offset: 0x7EEF80 VA: 0x1807EFB80
	public void Menu_Pickup(BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_Pickup_TimeStart() { }

	// RVA: 0x7EFB60 Offset: 0x7EEF60 VA: 0x1807EFB60
	public bool Menu_Pickup_If(BasePlayer player) { }

	// RVA: 0x7EEE30 Offset: 0x7EE230 VA: 0x1807EEE30 Slot: 137
	public virtual List<ItemAmount> BuildCost() { }

	// RVA: 0x7EFAA0 Offset: 0x7EEEA0 VA: 0x1807EFAA0 Slot: 138
	public virtual bool IsDead() { }

	// RVA: 0x7EFA90 Offset: 0x7EEE90 VA: 0x1807EFA90 Slot: 139
	public virtual bool IsAlive() { }

	// RVA: 0x7EF580 Offset: 0x7EE980 VA: 0x1807EF580
	public BaseCombatEntity.Faction GetFaction() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 140
	public virtual bool IsFriendly(BaseCombatEntity other) { }

	// RVA: 0x7F0850 Offset: 0x7EFC50 VA: 0x1807F0850
	public float get_SecondsSinceDeath() { }

	// RVA: 0x7F0870 Offset: 0x7EFC70 VA: 0x1807F0870
	public float get_healthFraction() { }

	// RVA: 0x7F0320 Offset: 0x7EF720 VA: 0x1807F0320 Slot: 27
	public override void ResetState() { }

	// RVA: 0x7EF080 Offset: 0x7EE480 VA: 0x1807EF080 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 141
	public virtual float GetThreatLevel() { }

	// RVA: 0x7F0290 Offset: 0x7EF690 VA: 0x1807F0290 Slot: 114
	public override float PenetrationResistance(HitInfo info) { }

	// RVA: 0x7F0420 Offset: 0x7EF820 VA: 0x1807F0420 Slot: 142
	public virtual void ScaleDamage(HitInfo info) { }

	// RVA: 0x7F0560 Offset: 0x7EF960 VA: 0x1807F0560
	public HitArea SkeletonLookup(uint boneID) { }

	// RVA: 0x7EFAB0 Offset: 0x7EEEB0 VA: 0x1807EFAB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7EF8E0 Offset: 0x7EECE0 VA: 0x1807EF8E0
	public float get_health() { }

	// RVA: 0x7F08C0 Offset: 0x7EFCC0 VA: 0x1807F08C0
	public void set_health(float value) { }

	// RVA: 0x7EF8E0 Offset: 0x7EECE0 VA: 0x1807EF8E0 Slot: 110
	public override float Health() { }

	// RVA: 0x7EFB50 Offset: 0x7EEF50 VA: 0x1807EFB50 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x75F2D0 Offset: 0x75E6D0 VA: 0x18075F2D0 Slot: 143
	public virtual float StartHealth() { }

	// RVA: 0x7F0610 Offset: 0x7EFA10 VA: 0x1807F0610 Slot: 144
	public virtual float StartMaxHealth() { }

	// RVA: 0x7F04D0 Offset: 0x7EF8D0 VA: 0x1807F04D0
	public void SetMaxHealth(float newMax) { }

	// RVA: 0x7EF0A0 Offset: 0x7EE4A0 VA: 0x1807EF0A0
	public void DoHitNotify(HitInfo info) { }

	// RVA: 0x7EFBC0 Offset: 0x7EEFC0 VA: 0x1807EFBC0 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x7F0630 Offset: 0x7EFA30 VA: 0x1807F0630
	public void .ctor() { }

}

public struct BaseCombatEntity.Pickup // TypeDefIndex: 8320
{	// Fields
	public bool enabled; // 0x0
	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition itemTarget; // 0x8
	public int itemCount; // 0x10
	[TooltipAttribute] // RVA: 0xB6710 Offset: 0xB5B10 VA: 0x1800B6710
	public bool setConditionFromHealth; // 0x14
	[TooltipAttribute] // RVA: 0xB6880 Offset: 0xB5C80 VA: 0x1800B6880
	public float subtractCondition; // 0x18
	[TooltipAttribute] // RVA: 0xB6920 Offset: 0xB5D20 VA: 0x1800B6920
	public bool requireBuildingPrivilege; // 0x1C
	[TooltipAttribute] // RVA: 0xB6A90 Offset: 0xB5E90 VA: 0x1800B6A90
	public bool requireHammer; // 0x1D
	[TooltipAttribute] // RVA: 0xB6B50 Offset: 0xB5F50 VA: 0x1800B6B50
	public bool requireEmptyInv; // 0x1E

}

public struct BaseCombatEntity.Repair // TypeDefIndex: 8321
{	// Fields
	public bool enabled; // 0x0
	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition itemTarget; // 0x8
	public GameObjectRef repairEffect; // 0x10
	public GameObjectRef repairFullEffect; // 0x18
	public GameObjectRef repairFailedEffect; // 0x20

}

public enum BaseCombatEntity.LifeState // TypeDefIndex: 8322
{	// Fields
	public int value__; // 0x0
	public const BaseCombatEntity.LifeState Alive = 0;
	public const BaseCombatEntity.LifeState Dead = 1;

}

public enum BaseCombatEntity.Faction // TypeDefIndex: 8323
{	// Fields
	public int value__; // 0x0
	public const BaseCombatEntity.Faction Default = 0;
	public const BaseCombatEntity.Faction Player = 1;
	public const BaseCombatEntity.Faction Bandit = 2;
	public const BaseCombatEntity.Faction Scientist = 3;
	public const BaseCombatEntity.Faction Horror = 4;

}

