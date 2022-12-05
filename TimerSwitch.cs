public class TimerSwitch : IOEntity // TypeDefIndex: 10187
{
	private Option __menuOption_Menu_TurnOn;
	public float timerLength;
	public Transform timerDrum;
	private float timePassed;
	private float oldTimeFraction;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void Update() { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_Activate_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

