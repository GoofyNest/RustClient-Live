public class BasePet : NPCPlayer // TypeDefIndex: 8335
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x7D8
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool queuedMovementsAllowed; // 0x0
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool onlyQueueBaseNavMovements; // 0x1
	[ServerVar] // RVA: 0xBB4A0 Offset: 0xBA8A0 VA: 0x1800BB4A0
	[HelpAttribute] // RVA: 0xBB4A0 Offset: 0xBA8A0 VA: 0x1800BB4A0
	public static float movementupdatebudgetms; // 0x4
	public float BaseAttackRate; // 0x830
	public float BaseAttackDamge; // 0x834
	public DamageType AttackDamageType; // 0x838
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseAIBrain<BasePet> <Brain>k__BackingField; // 0x840
	public GameObjectRef mapMarkerPrefab; // 0x848
	private BaseEntity _mapMarkerInstance; // 0x850

	// Properties
	public override bool HasMenuOptions { get; }
	public BaseAIBrain<BasePet> Brain { get; set; }

	// Methods

	// RVA: 0xA32030 Offset: 0xA31430 VA: 0x180A32030 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA324A0 Offset: 0xA318A0 VA: 0x180A324A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA32490 Offset: 0xA31890 VA: 0x180A32490
	public BaseAIBrain<BasePet> get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA32560 Offset: 0xA31960 VA: 0x180A32560
	protected void set_Brain(BaseAIBrain<BasePet> value) { }

	// RVA: 0x75F2D0 Offset: 0x75E6D0 VA: 0x18075F2D0 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x75F2D0 Offset: 0x75E6D0 VA: 0x18075F2D0 Slot: 144
	public override float StartMaxHealth() { }

	// RVA: 0x7EFB50 Offset: 0x7EEF50 VA: 0x1807EFB50 Slot: 111
	public override float MaxHealth() { }

	[BaseEntity.Menu] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	[BaseEntity.Menu.Description] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	[BaseEntity.Menu.ShowIf] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	// RVA: 0xA32330 Offset: 0xA31730 VA: 0x180A32330
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0xA31F30 Offset: 0xA31330 VA: 0x180A31F30
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0xA32460 Offset: 0xA31860 VA: 0x180A32460
	public void .ctor() { }

	// RVA: 0xA32400 Offset: 0xA31800 VA: 0x180A32400
	private static void .cctor() { }

}

