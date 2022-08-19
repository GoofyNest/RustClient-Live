public class HumanNPC : NPCPlayer, IAISenses, IAIAttack // TypeDefIndex: 8399
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x7D8
	[HeaderAttribute] // RVA: 0xE7B00 Offset: 0xE6F00 VA: 0x1800E7B00
	public int AdditionalLosBlockingLayer; // 0x830
	[HeaderAttribute] // RVA: 0x82EE0 Offset: 0x822E0 VA: 0x180082EE0
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; // 0x838
	[HeaderAttribute] // RVA: 0xCB4E0 Offset: 0xCA8E0 VA: 0x1800CB4E0
	public float aimConeScale; // 0x840
	public float lastDismountTime; // 0x844
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseAIBrain<HumanNPC> <Brain>k__BackingField; // 0x848

	// Properties
	public override bool HasMenuOptions { get; }
	public BaseAIBrain<HumanNPC> Brain { get; set; }

	// Methods

	// RVA: 0x75EFD0 Offset: 0x75E3D0 VA: 0x18075EFD0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x75F3E0 Offset: 0x75E7E0 VA: 0x18075F3E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x75F2D0 Offset: 0x75E6D0 VA: 0x18075F2D0 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x75F2D0 Offset: 0x75E6D0 VA: 0x18075F2D0 Slot: 144
	public override float StartMaxHealth() { }

	// RVA: 0x75F2D0 Offset: 0x75E6D0 VA: 0x18075F2D0 Slot: 111
	public override float MaxHealth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x75F3D0 Offset: 0x75E7D0 VA: 0x18075F3D0
	public BaseAIBrain<HumanNPC> get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x75F4A0 Offset: 0x75E8A0 VA: 0x18075F4A0
	private void set_Brain(BaseAIBrain<HumanNPC> value) { }

	[BaseEntity.Menu] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	[BaseEntity.Menu.Description] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	[BaseEntity.Menu.ShowIf] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	// RVA: 0x75F2E0 Offset: 0x75E6E0 VA: 0x18075F2E0
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x75EED0 Offset: 0x75E2D0 VA: 0x18075EED0
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 151
	public override bool IsOnGround() { }

	// RVA: 0x75F3B0 Offset: 0x75E7B0 VA: 0x18075F3B0
	public void .ctor() { }

}

