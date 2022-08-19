public class ElectricalBranch : IOEntity // TypeDefIndex: 8385
{	// Fields
	private Option __menuOption_Menu_SetBranch; // 0x288
	public int branchAmount; // 0x2E0
	public GameObjectRef branchPanelPrefab; // 0x2E8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xABC7F0 Offset: 0xABBBF0 VA: 0x180ABC7F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xABCF10 Offset: 0xABC310 VA: 0x180ABCF10 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xABCDC0 Offset: 0xABC1C0 VA: 0x180ABCDC0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x69EAD0 Offset: 0x69DED0 VA: 0x18069EAD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDA5B0 Offset: 0xD99B0 VA: 0x1800DA5B0
	[BaseEntity.Menu.Description] // RVA: 0xDA5B0 Offset: 0xD99B0 VA: 0x1800DA5B0
	[BaseEntity.Menu.Icon] // RVA: 0xDA5B0 Offset: 0xD99B0 VA: 0x1800DA5B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA5B0 Offset: 0xD99B0 VA: 0x1800DA5B0
	// RVA: 0xABCBB0 Offset: 0xABBFB0 VA: 0x180ABCBB0
	public void Menu_SetBranch(BasePlayer player) { }

	// RVA: 0xABCB00 Offset: 0xABBF00 VA: 0x180ABCB00
	public bool Menu_SetBranch_ShowIf(BasePlayer player) { }

	// RVA: 0xABC7A0 Offset: 0xABBBA0 VA: 0x180ABC7A0
	public void ClientChangePower(int newAmount) { }

	// RVA: 0xABCEB0 Offset: 0xABC2B0 VA: 0x180ABCEB0
	public void .ctor() { }

}

