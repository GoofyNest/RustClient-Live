public class TimerSwitch : IOEntity // TypeDefIndex: 8466
{	// Fields
	private Option __menuOption_Menu_TurnOn; // 0x288
	public float timerLength; // 0x2E0
	public Transform timerDrum; // 0x2E8
	private float timePassed; // 0x2F0
	private float oldTimeFraction; // 0x2F4

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x84FA00 Offset: 0x84EE00 VA: 0x18084FA00 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8500B0 Offset: 0x84F4B0 VA: 0x1808500B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x84FDC0 Offset: 0x84F1C0 VA: 0x18084FDC0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x84FD10 Offset: 0x84F110 VA: 0x18084FD10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x84FEB0 Offset: 0x84F2B0 VA: 0x18084FEB0
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0x90960 Offset: 0x8FD60 VA: 0x180090960
	[BaseEntity.Menu.Description] // RVA: 0x90960 Offset: 0x8FD60 VA: 0x180090960
	[BaseEntity.Menu.Icon] // RVA: 0x90960 Offset: 0x8FD60 VA: 0x180090960
	[BaseEntity.Menu.ShowIf] // RVA: 0x90960 Offset: 0x8FD60 VA: 0x180090960
	// RVA: 0x84FD80 Offset: 0x84F180 VA: 0x18084FD80
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x522920 Offset: 0x521D20 VA: 0x180522920
	public bool Menu_Activate_ShowIf(BasePlayer player) { }

	// RVA: 0x850040 Offset: 0x84F440 VA: 0x180850040
	public void .ctor() { }

}

