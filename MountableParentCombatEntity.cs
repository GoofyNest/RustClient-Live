public class MountableParentCombatEntity : BaseCombatEntity // TypeDefIndex: 8423
{	// Fields
	private Option __menuOption_Menu_Mount; // 0x240
	private BaseMountable mountable; // 0x298

	// Properties
	public override bool HasMenuOptions { get; }
	private BaseMountable Mountable { get; }

	// Methods

	// RVA: 0x7B7770 Offset: 0x7B6B70 VA: 0x1807B7770 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7B7B70 Offset: 0x7B6F70 VA: 0x1807B7B70 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7B7C30 Offset: 0x7B7030 VA: 0x1807B7C30
	private BaseMountable get_Mountable() { }

	[BaseEntity.Menu] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	[BaseEntity.Menu.Description] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	[BaseEntity.Menu.Icon] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	// RVA: 0x7B7B40 Offset: 0x7B6F40 VA: 0x1807B7B40
	public void Menu_Mount(BasePlayer player) { }

	// RVA: 0x7B7A80 Offset: 0x7B6E80 VA: 0x1807B7A80
	public bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x499120 Offset: 0x498520 VA: 0x180499120
	public void .ctor() { }

}

