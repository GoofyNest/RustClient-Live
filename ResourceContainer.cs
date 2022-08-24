public class ResourceContainer : EntityComponent<BaseEntity> // TypeDefIndex: 8436
{
	private Option __menuOption_MenuLoot; 
	public bool lootable; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuLoot(BasePlayer player) { }

	public bool MenuLoot_Test(BasePlayer player) { }

	public void .ctor() { }

}

