public class DoorCloser : BaseEntity // TypeDefIndex: 10103
{
	private Option __menuOption_Menu_Remove;
	[ItemSelector]
	public ItemDefinition itemType;
	public float delay;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override float BoundsPadding() { }

	public Door GetDoor() { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Remove(BasePlayer player) { }

	public bool Menu_Remove_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

