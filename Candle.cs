public class Candle : BaseCombatEntity, ISplashable, IIgniteable // TypeDefIndex: 8366
{	// Fields
	private Option __menuOption_Menu_Extinguish; // 0x240
	private Option __menuOption_Menu_Ignite; // 0x298

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x716E40 Offset: 0x716240 VA: 0x180716E40 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7174F0 Offset: 0x7168F0 VA: 0x1807174F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x717400 Offset: 0x716800 VA: 0x180717400 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xCFD00 Offset: 0xCF100 VA: 0x1800CFD00
	[BaseEntity.Menu.Description] // RVA: 0xCFD00 Offset: 0xCF100 VA: 0x1800CFD00
	[BaseEntity.Menu.Icon] // RVA: 0xCFD00 Offset: 0xCF100 VA: 0x1800CFD00
	[BaseEntity.Menu.ShowIf] // RVA: 0xCFD00 Offset: 0xCF100 VA: 0x1800CFD00
	// RVA: 0x7173B0 Offset: 0x7167B0 VA: 0x1807173B0
	public void Menu_Ignite(BasePlayer player) { }

	// RVA: 0x6F2BD0 Offset: 0x6F1FD0 VA: 0x1806F2BD0
	public bool Menu_Ignite_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCFFA0 Offset: 0xCF3A0 VA: 0x1800CFFA0
	[BaseEntity.Menu.Description] // RVA: 0xCFFA0 Offset: 0xCF3A0 VA: 0x1800CFFA0
	[BaseEntity.Menu.Icon] // RVA: 0xCFFA0 Offset: 0xCF3A0 VA: 0x1800CFFA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCFFA0 Offset: 0xCF3A0 VA: 0x1800CFFA0
	// RVA: 0x717360 Offset: 0x716760 VA: 0x180717360
	public void Menu_Extinguish(BasePlayer player) { }

	// RVA: 0x5C9C90 Offset: 0x5C9090 VA: 0x1805C9C90
	public bool Menu_Extinguish_ShowIf(BasePlayer player) { }

	// RVA: 0x499120 Offset: 0x498520 VA: 0x180499120
	public void .ctor() { }

}

