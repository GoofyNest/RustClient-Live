public class DoorCloser : BaseEntity // TypeDefIndex: 8382
{	private Option __menuOption_Menu_Remove; // 0x168
	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition itemType; // 0x1C0
	public float delay; // 0x1C8

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override float BoundsPadding() { }

	public Door GetDoor() { }

	[BaseEntity.Menu] // RVA: 0xD9E90 Offset: 0xD9290 VA: 0x1800D9E90
	[BaseEntity.Menu.Description] // RVA: 0xD9E90 Offset: 0xD9290 VA: 0x1800D9E90
	[BaseEntity.Menu.Icon] // RVA: 0xD9E90 Offset: 0xD9290 VA: 0x1800D9E90
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9E90 Offset: 0xD9290 VA: 0x1800D9E90
	public void Menu_Remove(BasePlayer player) { }

	public bool Menu_Remove_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

