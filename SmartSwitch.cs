public class SmartSwitch : AppIOEntity // TypeDefIndex: 8450
{	private Option __menuOption_Menu_TurnOff; // 0x2E0
	private Option __menuOption_Menu_TurnOn; // 0x338
	[HeaderAttribute] // RVA: 0x88110 Offset: 0x87510 VA: 0x180088110
	public Animator ReceiverAnimator; // 0x390
	private static readonly int ReceiverNoPower; // 0x0
	private static readonly int ReceiverOn; // 0x4

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool WantsPower() { }

	public void OnPowerStatusChange(bool isPowered) { }

	public void OnSwitchStatusChange(bool isOn) { }

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

	private static bool PlayerCanToggle(BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

