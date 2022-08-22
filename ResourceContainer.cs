public class ResourceContainer : EntityComponent<BaseEntity> // TypeDefIndex: 8436
{	private Option __menuOption_MenuLoot; // 0x20
	public bool lootable; // 0x78

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x7FE80 Offset: 0x7F280 VA: 0x18007FE80
	[BaseEntity.Menu.Description] // RVA: 0x7FE80 Offset: 0x7F280 VA: 0x18007FE80
	[BaseEntity.Menu.Icon] // RVA: 0x7FE80 Offset: 0x7F280 VA: 0x18007FE80
	[BaseEntity.Menu.ShowIf] // RVA: 0x7FE80 Offset: 0x7F280 VA: 0x18007FE80
	public void MenuLoot(BasePlayer player) { }

	public bool MenuLoot_Test(BasePlayer player) { }

	public void .ctor() { }

}

