public class ResourceContainer : EntityComponent<BaseEntity> // TypeDefIndex: 8436
{	// Fields
	private Option __menuOption_MenuLoot; // 0x20
	public bool lootable; // 0x78

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x934D70 Offset: 0x934170 VA: 0x180934D70 Slot: 7
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x935220 Offset: 0x934620 VA: 0x180935220 Slot: 8
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9350F0 Offset: 0x9344F0 VA: 0x1809350F0 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x7FE80 Offset: 0x7F280 VA: 0x18007FE80
	[BaseEntity.Menu.Description] // RVA: 0x7FE80 Offset: 0x7F280 VA: 0x18007FE80
	[BaseEntity.Menu.Icon] // RVA: 0x7FE80 Offset: 0x7F280 VA: 0x18007FE80
	[BaseEntity.Menu.ShowIf] // RVA: 0x7FE80 Offset: 0x7F280 VA: 0x18007FE80
	// RVA: 0x935060 Offset: 0x934460 VA: 0x180935060
	public void MenuLoot(BasePlayer player) { }

	// RVA: 0x935050 Offset: 0x934450 VA: 0x180935050
	public bool MenuLoot_Test(BasePlayer player) { }

	// RVA: 0x9351E0 Offset: 0x9345E0 VA: 0x1809351E0
	public void .ctor() { }

}

