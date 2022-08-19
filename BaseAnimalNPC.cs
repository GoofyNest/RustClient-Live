public class BaseAnimalNPC : BaseNpc, IAIAttack, IAITirednessAbove, IAISleep, IAIHungerAbove, IAISenses // TypeDefIndex: 8315
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x370
	public string deathStatName; // 0x3C8
	protected BaseAIBrain<BaseAnimalNPC> brain; // 0x3D0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7E8EF0 Offset: 0x7E82F0 VA: 0x1807E8EF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7E93A0 Offset: 0x7E87A0 VA: 0x1807E93A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	[BaseEntity.Menu.Description] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	[BaseEntity.Menu.ShowIf] // RVA: 0x83040 Offset: 0x82440 VA: 0x180083040
	// RVA: 0x7E9260 Offset: 0x7E8660 VA: 0x1807E9260
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x7E8E50 Offset: 0x7E8250 VA: 0x1807E8E50
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x7E9330 Offset: 0x7E8730 VA: 0x1807E9330
	public void .ctor() { }

}

