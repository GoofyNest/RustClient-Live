public class ElectricalBranch : IOEntity // TypeDefIndex: 8385
{	private Option __menuOption_Menu_SetBranch; // 0x288
	public int branchAmount; // 0x2E0
	public GameObjectRef branchPanelPrefab; // 0x2E8

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDA5B0 Offset: 0xD99B0 VA: 0x1800DA5B0
	[BaseEntity.Menu.Description] // RVA: 0xDA5B0 Offset: 0xD99B0 VA: 0x1800DA5B0
	[BaseEntity.Menu.Icon] // RVA: 0xDA5B0 Offset: 0xD99B0 VA: 0x1800DA5B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA5B0 Offset: 0xD99B0 VA: 0x1800DA5B0
	public void Menu_SetBranch(BasePlayer player) { }

	public bool Menu_SetBranch_ShowIf(BasePlayer player) { }

	public void ClientChangePower(int newAmount) { }

	public void .ctor() { }

}

