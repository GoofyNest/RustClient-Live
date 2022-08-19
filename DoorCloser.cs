public class DoorCloser : BaseEntity // TypeDefIndex: 8382
{	// Fields
	private Option __menuOption_Menu_Remove; // 0x168
	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition itemType; // 0x1C0
	public float delay; // 0x1C8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAA7840 Offset: 0xAA6C40 VA: 0x180AA7840 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAA7E80 Offset: 0xAA7280 VA: 0x180AA7E80 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAA7D30 Offset: 0xAA7130 VA: 0x180AA7D30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4C0690 Offset: 0x4BFA90 VA: 0x1804C0690 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0xAA77B0 Offset: 0xAA6BB0 VA: 0x180AA77B0
	public Door GetDoor() { }

	[BaseEntity.Menu] // RVA: 0xD9E90 Offset: 0xD9290 VA: 0x1800D9E90
	[BaseEntity.Menu.Description] // RVA: 0xD9E90 Offset: 0xD9290 VA: 0x1800D9E90
	[BaseEntity.Menu.Icon] // RVA: 0xD9E90 Offset: 0xD9290 VA: 0x1800D9E90
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9E90 Offset: 0xD9290 VA: 0x1800D9E90
	// RVA: 0xAA7CF0 Offset: 0xAA70F0 VA: 0x180AA7CF0
	public void Menu_Remove(BasePlayer player) { }

	// RVA: 0xAA7B50 Offset: 0xAA6F50 VA: 0x180AA7B50
	public bool Menu_Remove_ShowIf(BasePlayer player) { }

	// RVA: 0xAA7E20 Offset: 0xAA7220 VA: 0x180AA7E20
	public void .ctor() { }

}

