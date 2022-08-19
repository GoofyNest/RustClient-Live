public class BaseFishNPC : BaseNpc, IAIAttack, IAISenses // TypeDefIndex: 8324
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x370
	protected BaseAIBrain<BaseFishNPC> brain; // 0x3C8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7FF980 Offset: 0x7FED80 VA: 0x1807FF980 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7FFE20 Offset: 0x7FF220 VA: 0x1807FFE20 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	[BaseEntity.Menu.Description] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	[BaseEntity.Menu.ShowIf] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	// RVA: 0x7FFCF0 Offset: 0x7FF0F0 VA: 0x1807FFCF0
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x7FF8E0 Offset: 0x7FECE0 VA: 0x1807FF8E0
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x7FFDC0 Offset: 0x7FF1C0 VA: 0x1807FFDC0
	public void .ctor() { }

}

