public class CustomTimerSwitch : TimerSwitch // TypeDefIndex: 8377
{	// Fields
	private Option __menuOption_Menu_SetTime; // 0x2F8
	public GameObjectRef timerPanelPrefab; // 0x350

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x522610 Offset: 0x521A10 VA: 0x180522610 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x522E20 Offset: 0x522220 VA: 0x180522E20 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x522B70 Offset: 0x521F70 VA: 0x180522B70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x522570 Offset: 0x521970 VA: 0x180522570
	public bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0x522C60 Offset: 0x522060 VA: 0x180522C60
	public void SendNewTime(float seconds) { }

	[BaseEntity.Menu] // RVA: 0xD6750 Offset: 0xD5B50 VA: 0x1800D6750
	[BaseEntity.Menu.Description] // RVA: 0xD6750 Offset: 0xD5B50 VA: 0x1800D6750
	[BaseEntity.Menu.Icon] // RVA: 0xD6750 Offset: 0xD5B50 VA: 0x1800D6750
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6750 Offset: 0xD5B50 VA: 0x1800D6750
	// RVA: 0x522960 Offset: 0x521D60 VA: 0x180522960
	public void Menu_SetTime(BasePlayer player) { }

	// RVA: 0x522920 Offset: 0x521D20 VA: 0x180522920
	public bool Menu_SetTime_ShowIf(BasePlayer player) { }

	// RVA: 0x522E10 Offset: 0x522210 VA: 0x180522E10
	public void .ctor() { }

}

