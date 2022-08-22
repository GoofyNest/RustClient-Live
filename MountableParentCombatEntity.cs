public class MountableParentCombatEntity : BaseCombatEntity // TypeDefIndex: 8423
{	private Option __menuOption_Menu_Mount; // 0x240
	private BaseMountable mountable; // 0x298

	public override bool HasMenuOptions { get; }
	private BaseMountable Mountable { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	private BaseMountable get_Mountable() { }

	[BaseEntity.Menu] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	[BaseEntity.Menu.Description] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	[BaseEntity.Menu.Icon] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	public void Menu_Mount(BasePlayer player) { }

	public bool Menu_Mount_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

