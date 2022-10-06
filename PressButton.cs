public class PressButton : IOEntity // TypeDefIndex: 10135
{
	private Option __menuOption_Menu_Press; 
	public float pressDuration; 
	public float pressPowerTime; 
	public int pressPowerAmount; 
	public const BaseEntity.Flags Flag_EmittingPower = 512;
	public bool smallBurst; 

	public override bool HasMenuOptions { get; }
	protected virtual bool ShowBasePressOption { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Press(BasePlayer player) { }

	public bool Menu_Press_ShowIf(BasePlayer player) { }

	protected virtual bool get_ShowBasePressOption() { }

	public void .ctor() { }

}

public class PressButton_TrainTunnel : PressButton // TypeDefIndex: 10136
{
	private Option __menuOption_Menu_Press_TrainTunnel; 

	public override bool HasMenuOptions { get; }
	protected override bool ShowBasePressOption { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Press_TrainTunnel(BasePlayer player) { }

	public bool Menu_Press_ShowIf_TrainTunnel(BasePlayer player) { }

	protected override bool get_ShowBasePressOption() { }

	public void .ctor() { }

}

