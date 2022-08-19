public class BaseLock : BaseEntity // TypeDefIndex: 8327
{	// Fields
	private Option __menuOption_Menu_RemoveLock; // 0x168
	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition itemType; // 0x1C0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA23670 Offset: 0xA22A70 VA: 0x180A23670 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA23B00 Offset: 0xA22F00 VA: 0x180A23B00 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA239B0 Offset: 0xA22DB0 VA: 0x180A239B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB8700 Offset: 0xB7B00 VA: 0x1800B8700
	[BaseEntity.Menu.Description] // RVA: 0xB8700 Offset: 0xB7B00 VA: 0x1800B8700
	[BaseEntity.Menu.Icon] // RVA: 0xB8700 Offset: 0xB7B00 VA: 0x1800B8700
	[BaseEntity.Menu.ShowIf] // RVA: 0xB8700 Offset: 0xB7B00 VA: 0x1800B8700
	// RVA: 0xA23970 Offset: 0xA22D70 VA: 0x180A23970
	public void Menu_RemoveLock(BasePlayer player) { }

	// RVA: 0x6B6600 Offset: 0x6B5A00 VA: 0x1806B6600
	public bool Menu_RemoveLock_ShowIf(BasePlayer player) { }

	// RVA: 0xA23570 Offset: 0xA22970 VA: 0x180A23570 Slot: 66
	public override List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x7A3AD0 Offset: 0x7A2ED0 VA: 0x1807A3AD0 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0xA23AA0 Offset: 0xA22EA0 VA: 0x180A23AA0
	public void .ctor() { }

}

