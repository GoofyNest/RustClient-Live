public class Mailbox : StorageContainer // TypeDefIndex: 8408
{	// Fields
	private Option __menuOption_Full; // 0x3D0
	public string ownerPanel; // 0x428
	public GameObjectRef mailDropSound; // 0x430
	public ItemDefinition[] allowedItems; // 0x438
	public bool autoSubmitWhenClosed; // 0x440
	public bool shouldMarkAsFull; // 0x441

	// Properties
	public override bool HasMenuOptions { get; }
	public int mailInputSlot { get; }

	// Methods

	// RVA: 0x575480 Offset: 0x574880 VA: 0x180575480 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x575B00 Offset: 0x574F00 VA: 0x180575B00 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x575850 Offset: 0x574C50 VA: 0x180575850 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x575C00 Offset: 0x575000 VA: 0x180575C00
	public int get_mailInputSlot() { }

	// RVA: 0x575940 Offset: 0x574D40 VA: 0x180575940 Slot: 155
	public virtual bool PlayerIsOwner(BasePlayer player) { }

	// RVA: 0x575800 Offset: 0x574C00 VA: 0x180575800
	public bool IsFull() { }

	// RVA: 0x575820 Offset: 0x574C20 VA: 0x180575820
	public void MarkFull(bool full) { }

	[BaseEntity.Menu] // RVA: 0xECDD0 Offset: 0xEC1D0 VA: 0x1800ECDD0
	[BaseEntity.Menu.Description] // RVA: 0xECDD0 Offset: 0xEC1D0 VA: 0x1800ECDD0
	[BaseEntity.Menu.Icon] // RVA: 0xECDD0 Offset: 0xEC1D0 VA: 0x1800ECDD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xECDD0 Offset: 0xEC1D0 VA: 0x1800ECDD0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Full(BasePlayer player) { }

	// RVA: 0x575420 Offset: 0x574820 VA: 0x180575420
	public bool Full_ShowIf(BasePlayer player) { }

	// RVA: 0x575960 Offset: 0x574D60 VA: 0x180575960 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x575A60 Offset: 0x574E60 VA: 0x180575A60
	public void TrySubmit() { }

	// RVA: 0x5757C0 Offset: 0x574BC0 VA: 0x1805757C0 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x575AA0 Offset: 0x574EA0 VA: 0x180575AA0
	public void .ctor() { }

}

