public class TwitchTrophy : BaseCombatEntity // TypeDefIndex: 8476
{	private Option __menuOption_Menu_OpenTrophy; // 0x240
	[HeaderAttribute] // RVA: 0x965E0 Offset: 0x959E0 VA: 0x1800965E0
	public GameObjectRef DialogPrefab; // 0x298

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x96680 Offset: 0x95A80 VA: 0x180096680
	[BaseEntity.Menu.Description] // RVA: 0x96680 Offset: 0x95A80 VA: 0x180096680
	[BaseEntity.Menu.Icon] // RVA: 0x96680 Offset: 0x95A80 VA: 0x180096680
	public void Menu_OpenTrophy(BasePlayer player) { }

	public void .ctor() { }

}

