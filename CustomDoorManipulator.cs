public class CustomDoorManipulator : DoorManipulator // TypeDefIndex: 8376
{
	private Option __menuOption_Menu_Pair; 
	private Option __menuOption_Menu_SetClose; 
	private Option __menuOption_Menu_SetOpen; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool PairWithLockedDoors() { }

	public bool CanPlayerAdmin(BasePlayer player) { }

	public bool IsPaired() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Pair(BasePlayer player) { }

	public bool Menu_Pair_ShowIf(BasePlayer player) { }

	public void RequestPair() { }

	public void RequestActionChange(DoorManipulator.DoorEffect newAction) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_SetOpen(BasePlayer player) { }

	public bool Menu_SetOpen_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_SetClose(BasePlayer player) { }

	public bool Menu_SetClose_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

