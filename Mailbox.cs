public class Mailbox : StorageContainer // TypeDefIndex: 8408
{	private Option __menuOption_Full; // 0x3D0
	public string ownerPanel; // 0x428
	public GameObjectRef mailDropSound; // 0x430
	public ItemDefinition[] allowedItems; // 0x438
	public bool autoSubmitWhenClosed; // 0x440
	public bool shouldMarkAsFull; // 0x441

	public override bool HasMenuOptions { get; }
	public int mailInputSlot { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public int get_mailInputSlot() { }

	public virtual bool PlayerIsOwner(BasePlayer player) { }

	public bool IsFull() { }

	public void MarkFull(bool full) { }

	[BaseEntity.Menu] // RVA: 0xECDD0 Offset: 0xEC1D0 VA: 0x1800ECDD0
	[BaseEntity.Menu.Description] // RVA: 0xECDD0 Offset: 0xEC1D0 VA: 0x1800ECDD0
	[BaseEntity.Menu.Icon] // RVA: 0xECDD0 Offset: 0xEC1D0 VA: 0x1800ECDD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xECDD0 Offset: 0xEC1D0 VA: 0x1800ECDD0
	public void Full(BasePlayer player) { }

	public bool Full_ShowIf(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	public void TrySubmit() { }

	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	public void .ctor() { }

}

