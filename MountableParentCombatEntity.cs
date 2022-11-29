public class MountableParentCombatEntity : BaseCombatEntity // TypeDefIndex: 10141
{
	private Option __menuOption_Menu_Mount; 
	private BaseMountable mountable; 

	public override bool HasMenuOptions { get; }
	private BaseMountable Mountable { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	private BaseMountable get_Mountable() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Mount(BasePlayer player) { }

	public bool Menu_Mount_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

