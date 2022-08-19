public class SmartSwitch : AppIOEntity // TypeDefIndex: 8450
{	// Fields
	private Option __menuOption_Menu_TurnOff; // 0x2E0
	private Option __menuOption_Menu_TurnOn; // 0x338
	[HeaderAttribute] // RVA: 0x88110 Offset: 0x87510 VA: 0x180088110
	public Animator ReceiverAnimator; // 0x390
	private static readonly int ReceiverNoPower; // 0x0
	private static readonly int ReceiverOn; // 0x4

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x5C9290 Offset: 0x5C8690 VA: 0x1805C9290 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5C9D10 Offset: 0x5C9110 VA: 0x1805C9D10 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5C9A90 Offset: 0x5C8E90 VA: 0x1805C9A90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5C9C90 Offset: 0x5C9090 VA: 0x1805C9C90 Slot: 148
	public override bool WantsPower() { }

	// RVA: 0x5C9A00 Offset: 0x5C8E00 VA: 0x1805C9A00
	public void OnPowerStatusChange(bool isPowered) { }

	// RVA: 0x5C9B80 Offset: 0x5C8F80 VA: 0x1805C9B80
	public void OnSwitchStatusChange(bool isOn) { }

	[BaseEntity.Menu] // RVA: 0x881C0 Offset: 0x875C0 VA: 0x1800881C0
	[BaseEntity.Menu.Description] // RVA: 0x881C0 Offset: 0x875C0 VA: 0x1800881C0
	[BaseEntity.Menu.Icon] // RVA: 0x881C0 Offset: 0x875C0 VA: 0x1800881C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x881C0 Offset: 0x875C0 VA: 0x1800881C0
	// RVA: 0x5C99C0 Offset: 0x5C8DC0 VA: 0x1805C99C0
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x5C98F0 Offset: 0x5C8CF0 VA: 0x1805C98F0
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x88590 Offset: 0x87990 VA: 0x180088590
	[BaseEntity.Menu.Description] // RVA: 0x88590 Offset: 0x87990 VA: 0x180088590
	[BaseEntity.Menu.Icon] // RVA: 0x88590 Offset: 0x87990 VA: 0x180088590
	[BaseEntity.Menu.ShowIf] // RVA: 0x88590 Offset: 0x87990 VA: 0x180088590
	// RVA: 0x5C98B0 Offset: 0x5C8CB0 VA: 0x1805C98B0
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x5C97E0 Offset: 0x5C8BE0 VA: 0x1805C97E0
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	// RVA: 0x5C9C10 Offset: 0x5C9010 VA: 0x1805C9C10
	private static bool PlayerCanToggle(BasePlayer player) { }

	// RVA: 0x5C9170 Offset: 0x5C8570 VA: 0x1805C9170
	public void .ctor() { }

	// RVA: 0x5C9CA0 Offset: 0x5C90A0 VA: 0x1805C9CA0
	private static void .cctor() { }

}

