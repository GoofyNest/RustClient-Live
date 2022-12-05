public class SmartSwitch : AppIOEntity // TypeDefIndex: 10171
{
	private Option __menuOption_Menu_TurnOff;
	private Option __menuOption_Menu_TurnOn;
	[HeaderAttribute]
	public Animator ReceiverAnimator;
	private static readonly int ReceiverNoPower;
	private static readonly int ReceiverOn;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool WantsPower() { }

	public void OnPowerStatusChange(bool isPowered) { }

	public void OnSwitchStatusChange(bool isOn) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_TurnOff(BasePlayer player) { }

	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	private static bool PlayerCanToggle(BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

