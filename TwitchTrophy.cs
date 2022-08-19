public class TwitchTrophy : BaseCombatEntity // TypeDefIndex: 8476
{	// Fields
	private Option __menuOption_Menu_OpenTrophy; // 0x240
	[HeaderAttribute] // RVA: 0x965E0 Offset: 0x959E0 VA: 0x1800965E0
	public GameObjectRef DialogPrefab; // 0x298

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x4D1890 Offset: 0x4D0C90 VA: 0x1804D1890 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x96680 Offset: 0x95A80 VA: 0x180096680
	[BaseEntity.Menu.Description] // RVA: 0x96680 Offset: 0x95A80 VA: 0x180096680
	[BaseEntity.Menu.Icon] // RVA: 0x96680 Offset: 0x95A80 VA: 0x180096680
	// RVA: 0x4D1B10 Offset: 0x4D0F10 VA: 0x1804D1B10
	public void Menu_OpenTrophy(BasePlayer player) { }

	// RVA: 0x499120 Offset: 0x498520 VA: 0x180499120
	public void .ctor() { }

}

