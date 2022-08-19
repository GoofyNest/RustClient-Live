public class ScarecrowNPC : NPCPlayer, IAISenses, IAIAttack // TypeDefIndex: 8442
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x7D8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseAIBrain<ScarecrowNPC> <Brain>k__BackingField; // 0x830
	public float BaseAttackRate; // 0x838
	public float BaseAttackDamge; // 0x83C
	public DamageType AttackDamageType; // 0x840
	[HeaderAttribute] // RVA: 0x82EE0 Offset: 0x822E0 VA: 0x180082EE0
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; // 0x848

	// Properties
	public override bool HasMenuOptions { get; }
	public BaseAIBrain<ScarecrowNPC> Brain { get; set; }

	// Methods

	// RVA: 0x49DA20 Offset: 0x49CE20 VA: 0x18049DA20 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x49DE30 Offset: 0x49D230 VA: 0x18049DE30 Slot: 50
	public override bool get_HasMenuOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x49DE20 Offset: 0x49D220 VA: 0x18049DE20
	public BaseAIBrain<ScarecrowNPC> get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x49DEF0 Offset: 0x49D2F0 VA: 0x18049DEF0
	protected void set_Brain(BaseAIBrain<ScarecrowNPC> value) { }

	[BaseEntity.Menu] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	[BaseEntity.Menu.Description] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	[BaseEntity.Menu.ShowIf] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	// RVA: 0x49DD20 Offset: 0x49D120 VA: 0x18049DD20
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x49D920 Offset: 0x49CD20 VA: 0x18049D920
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x49DDF0 Offset: 0x49D1F0 VA: 0x18049DDF0
	public void .ctor() { }

}

