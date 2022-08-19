public class PressButton : IOEntity // TypeDefIndex: 8430
{	// Fields
	private Option __menuOption_Menu_Press; // 0x288
	public float pressDuration; // 0x2E0
	public float pressPowerTime; // 0x2E4
	public int pressPowerAmount; // 0x2E8
	public const BaseEntity.Flags Flag_EmittingPower = 512;
	public bool smallBurst; // 0x2EC

	// Properties
	public override bool HasMenuOptions { get; }
	protected virtual bool ShowBasePressOption { get; }

	// Methods

	// RVA: 0x987720 Offset: 0x986B20 VA: 0x180987720 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9880F0 Offset: 0x9874F0 VA: 0x1809880F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x987B10 Offset: 0x986F10 VA: 0x180987B10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x987A30 Offset: 0x986E30 VA: 0x180987A30 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7D4C0 Offset: 0x7C8C0 VA: 0x18007D4C0
	[BaseEntity.Menu.Description] // RVA: 0x7D4C0 Offset: 0x7C8C0 VA: 0x18007D4C0
	[BaseEntity.Menu.Icon] // RVA: 0x7D4C0 Offset: 0x7C8C0 VA: 0x18007D4C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D4C0 Offset: 0x7C8C0 VA: 0x18007D4C0
	// RVA: 0x987AD0 Offset: 0x986ED0 VA: 0x180987AD0
	public void Menu_Press(BasePlayer player) { }

	// RVA: 0x987A90 Offset: 0x986E90 VA: 0x180987A90
	public bool Menu_Press_ShowIf(BasePlayer player) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 159
	protected virtual bool get_ShowBasePressOption() { }

	// RVA: 0x987F30 Offset: 0x987330 VA: 0x180987F30
	public void .ctor() { }

}

public class PressButton_TrainTunnel : PressButton // TypeDefIndex: 8431
{	// Fields
	private Option __menuOption_Menu_Press_TrainTunnel; // 0x2F0

	// Properties
	public override bool HasMenuOptions { get; }
	protected override bool ShowBasePressOption { get; }

	// Methods

	// RVA: 0x987C00 Offset: 0x987000 VA: 0x180987C00 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x987FA0 Offset: 0x9873A0 VA: 0x180987FA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x7D7E0 Offset: 0x7CBE0 VA: 0x18007D7E0
	[BaseEntity.Menu.Description] // RVA: 0x7D7E0 Offset: 0x7CBE0 VA: 0x18007D7E0
	[BaseEntity.Menu.Icon] // RVA: 0x7D7E0 Offset: 0x7CBE0 VA: 0x18007D7E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D7E0 Offset: 0x7CBE0 VA: 0x18007D7E0
	// RVA: 0x987EF0 Offset: 0x9872F0 VA: 0x180987EF0
	public void Menu_Press_TrainTunnel(BasePlayer player) { }

	// RVA: 0x6F2BD0 Offset: 0x6F1FD0 VA: 0x1806F2BD0
	public bool Menu_Press_ShowIf_TrainTunnel(BasePlayer player) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 159
	protected override bool get_ShowBasePressOption() { }

	// RVA: 0x987F30 Offset: 0x987330 VA: 0x180987F30
	public void .ctor() { }

}

