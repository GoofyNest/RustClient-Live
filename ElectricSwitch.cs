public class ElectricSwitch : IOEntity // TypeDefIndex: 8386
{	// Fields
	private Option __menuOption_Menu_Toggle; // 0x288
	private Option __menuOption_Menu_TurnOff; // 0x2E0
	private Option __menuOption_Menu_TurnOn; // 0x338
	public bool isToggleSwitch; // 0x390

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xABB3F0 Offset: 0xABA7F0 VA: 0x180ABB3F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xABBE40 Offset: 0xABB240 VA: 0x180ABBE40 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xABBCF0 Offset: 0xABB0F0 VA: 0x180ABBCF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5C9C90 Offset: 0x5C9090 VA: 0x1805C9C90 Slot: 148
	public override bool WantsPower() { }

	[BaseEntity.Menu] // RVA: 0x881C0 Offset: 0x875C0 VA: 0x1800881C0
	[BaseEntity.Menu.Description] // RVA: 0x881C0 Offset: 0x875C0 VA: 0x1800881C0
	[BaseEntity.Menu.Icon] // RVA: 0x881C0 Offset: 0x875C0 VA: 0x1800881C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x881C0 Offset: 0x875C0 VA: 0x1800881C0
	// RVA: 0xABBCA0 Offset: 0xABB0A0 VA: 0x180ABBCA0
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0xABBC70 Offset: 0xABB070 VA: 0x180ABBC70
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x88590 Offset: 0x87990 VA: 0x180088590
	[BaseEntity.Menu.Description] // RVA: 0x88590 Offset: 0x87990 VA: 0x180088590
	[BaseEntity.Menu.Icon] // RVA: 0x88590 Offset: 0x87990 VA: 0x180088590
	[BaseEntity.Menu.ShowIf] // RVA: 0x88590 Offset: 0x87990 VA: 0x180088590
	// RVA: 0xABBC20 Offset: 0xABB020 VA: 0x180ABBC20
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0xABBBF0 Offset: 0xABAFF0 VA: 0x180ABBBF0
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDAC40 Offset: 0xDA040 VA: 0x1800DAC40
	[BaseEntity.Menu.Description] // RVA: 0xDAC40 Offset: 0xDA040 VA: 0x1800DAC40
	[BaseEntity.Menu.Icon] // RVA: 0xDAC40 Offset: 0xDA040 VA: 0x1800DAC40
	[BaseEntity.Menu.ShowIf] // RVA: 0xDAC40 Offset: 0xDA040 VA: 0x1800DAC40
	// RVA: 0xABBBA0 Offset: 0xABAFA0 VA: 0x180ABBBA0
	public void Menu_Toggle(BasePlayer player) { }

	// RVA: 0xABBB70 Offset: 0xABAF70 VA: 0x180ABBB70
	public bool Menu_Toggle_ShowIf(BasePlayer player) { }

	// RVA: 0xABBDE0 Offset: 0xABB1E0 VA: 0x180ABBDE0
	public void .ctor() { }

}

