public class ElectricalBranch : IOEntity // TypeDefIndex: 8387
{
	private Option __menuOption_Menu_SetBranch; 
	public int branchAmount; 
	public GameObjectRef branchPanelPrefab; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_SetBranch(BasePlayer player) { }

	public bool Menu_SetBranch_ShowIf(BasePlayer player) { }

	public void ClientChangePower(int newAmount) { }

	public void .ctor() { }

}

