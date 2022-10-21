public class Mailbox : StorageContainer // TypeDefIndex: 10115
{
	private Option __menuOption_Full; 
	public string ownerPanel; 
	public GameObjectRef mailDropSound; 
	public ItemDefinition[] allowedItems; 
	public bool autoSubmitWhenClosed; 
	public bool shouldMarkAsFull; 

	public override bool HasMenuOptions { get; }
	public int mailInputSlot { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public int get_mailInputSlot() { }

	public virtual bool PlayerIsOwner(BasePlayer player) { }

	public bool IsFull() { }

	public void MarkFull(bool full) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Full(BasePlayer player) { }

	public bool Full_ShowIf(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	public void TrySubmit() { }

	public void .ctor() { }

}

