public class TwitchTrophy : BaseCombatEntity // TypeDefIndex: 10194
{
	private Option __menuOption_Menu_OpenTrophy; 
	[HeaderAttribute] 
	public GameObjectRef DialogPrefab; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	public void Menu_OpenTrophy(BasePlayer player) { }

	public void .ctor() { }

}

