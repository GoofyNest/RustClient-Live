public class Candle : BaseCombatEntity, ISplashable, IIgniteable // TypeDefIndex: 8366
{	private Option __menuOption_Menu_Extinguish; // 0x240
	private Option __menuOption_Menu_Ignite; // 0x298

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xCFD00 Offset: 0xCF100 VA: 0x1800CFD00
	[BaseEntity.Menu.Description] // RVA: 0xCFD00 Offset: 0xCF100 VA: 0x1800CFD00
	[BaseEntity.Menu.Icon] // RVA: 0xCFD00 Offset: 0xCF100 VA: 0x1800CFD00
	[BaseEntity.Menu.ShowIf] // RVA: 0xCFD00 Offset: 0xCF100 VA: 0x1800CFD00
	public void Menu_Ignite(BasePlayer player) { }

	public bool Menu_Ignite_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCFFA0 Offset: 0xCF3A0 VA: 0x1800CFFA0
	[BaseEntity.Menu.Description] // RVA: 0xCFFA0 Offset: 0xCF3A0 VA: 0x1800CFFA0
	[BaseEntity.Menu.Icon] // RVA: 0xCFFA0 Offset: 0xCF3A0 VA: 0x1800CFFA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCFFA0 Offset: 0xCF3A0 VA: 0x1800CFFA0
	public void Menu_Extinguish(BasePlayer player) { }

	public bool Menu_Extinguish_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

