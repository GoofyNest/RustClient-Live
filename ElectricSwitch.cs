public class ElectricSwitch : IOEntity // TypeDefIndex: 8386
{	private Option __menuOption_Menu_Toggle; // 0x288
	private Option __menuOption_Menu_TurnOff; // 0x2E0
	private Option __menuOption_Menu_TurnOn; // 0x338
	public bool isToggleSwitch; // 0x390

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool WantsPower() { }

	[BaseEntity.Menu] // RVA: 0x881C0 Offset: 0x875C0 VA: 0x1800881C0
	[BaseEntity.Menu.Description] // RVA: 0x881C0 Offset: 0x875C0 VA: 0x1800881C0
	[BaseEntity.Menu.Icon] // RVA: 0x881C0 Offset: 0x875C0 VA: 0x1800881C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x881C0 Offset: 0x875C0 VA: 0x1800881C0
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x88590 Offset: 0x87990 VA: 0x180088590
	[BaseEntity.Menu.Description] // RVA: 0x88590 Offset: 0x87990 VA: 0x180088590
	[BaseEntity.Menu.Icon] // RVA: 0x88590 Offset: 0x87990 VA: 0x180088590
	[BaseEntity.Menu.ShowIf] // RVA: 0x88590 Offset: 0x87990 VA: 0x180088590
	public void Menu_TurnOff(BasePlayer player) { }

	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDAC40 Offset: 0xDA040 VA: 0x1800DAC40
	[BaseEntity.Menu.Description] // RVA: 0xDAC40 Offset: 0xDA040 VA: 0x1800DAC40
	[BaseEntity.Menu.Icon] // RVA: 0xDAC40 Offset: 0xDA040 VA: 0x1800DAC40
	[BaseEntity.Menu.ShowIf] // RVA: 0xDAC40 Offset: 0xDA040 VA: 0x1800DAC40
	public void Menu_Toggle(BasePlayer player) { }

	public bool Menu_Toggle_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

