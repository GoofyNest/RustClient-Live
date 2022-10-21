public class BaseLock : BaseEntity // TypeDefIndex: 10032
{
	private Option __menuOption_Menu_RemoveLock; 
	[ItemSelector] 
	public ItemDefinition itemType; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_RemoveLock(BasePlayer player) { }

	public bool Menu_RemoveLock_ShowIf(BasePlayer player) { }

	public override List<Option> GetMenuItems(BasePlayer player) { }

	public override float BoundsPadding() { }

	public void .ctor() { }

}

