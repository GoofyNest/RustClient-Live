public class TimerSwitch : IOEntity // TypeDefIndex: 8466
{	private Option __menuOption_Menu_TurnOn; // 0x288
	public float timerLength; // 0x2E0
	public Transform timerDrum; // 0x2E8
	private float timePassed; // 0x2F0
	private float oldTimeFraction; // 0x2F4

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void Update() { }

	[BaseEntity.Menu] // RVA: 0x90960 Offset: 0x8FD60 VA: 0x180090960
	[BaseEntity.Menu.Description] // RVA: 0x90960 Offset: 0x8FD60 VA: 0x180090960
	[BaseEntity.Menu.Icon] // RVA: 0x90960 Offset: 0x8FD60 VA: 0x180090960
	[BaseEntity.Menu.ShowIf] // RVA: 0x90960 Offset: 0x8FD60 VA: 0x180090960
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_Activate_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

