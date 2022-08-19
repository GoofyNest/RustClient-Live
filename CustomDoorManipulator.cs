public class CustomDoorManipulator : DoorManipulator // TypeDefIndex: 8376
{	// Fields
	private Option __menuOption_Menu_Pair; // 0x2A8
	private Option __menuOption_Menu_SetClose; // 0x300
	private Option __menuOption_Menu_SetOpen; // 0x358

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x5219E0 Offset: 0x520DE0 VA: 0x1805219E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x522380 Offset: 0x521780 VA: 0x180522380 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5221E0 Offset: 0x5215E0 VA: 0x1805221E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 159
	public override bool PairWithLockedDoors() { }

	// RVA: 0x521940 Offset: 0x520D40 VA: 0x180521940
	public bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0x521F50 Offset: 0x521350 VA: 0x180521F50
	public bool IsPaired() { }

	[BaseEntity.Menu] // RVA: 0xD60B0 Offset: 0xD54B0 VA: 0x1800D60B0
	[BaseEntity.Menu.Description] // RVA: 0xD60B0 Offset: 0xD54B0 VA: 0x1800D60B0
	[BaseEntity.Menu.Icon] // RVA: 0xD60B0 Offset: 0xD54B0 VA: 0x1800D60B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD60B0 Offset: 0xD54B0 VA: 0x1800D60B0
	// RVA: 0x522050 Offset: 0x521450 VA: 0x180522050
	public void Menu_Pair(BasePlayer player) { }

	// RVA: 0x521FB0 Offset: 0x5213B0 VA: 0x180521FB0
	public bool Menu_Pair_ShowIf(BasePlayer player) { }

	// RVA: 0x522330 Offset: 0x521730 VA: 0x180522330
	public void RequestPair() { }

	// RVA: 0x5222D0 Offset: 0x5216D0 VA: 0x1805222D0
	public void RequestActionChange(DoorManipulator.DoorEffect newAction) { }

	[BaseEntity.Menu] // RVA: 0xD6360 Offset: 0xD5760 VA: 0x1800D6360
	[BaseEntity.Menu.Description] // RVA: 0xD6360 Offset: 0xD5760 VA: 0x1800D6360
	[BaseEntity.Menu.Icon] // RVA: 0xD6360 Offset: 0xD5760 VA: 0x1800D6360
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6360 Offset: 0xD5760 VA: 0x1800D6360
	// RVA: 0x522110 Offset: 0x521510 VA: 0x180522110
	public void Menu_SetOpen(BasePlayer player) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	public bool Menu_SetOpen_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD65B0 Offset: 0xD59B0 VA: 0x1800D65B0
	[BaseEntity.Menu.Description] // RVA: 0xD65B0 Offset: 0xD59B0 VA: 0x1800D65B0
	[BaseEntity.Menu.Icon] // RVA: 0xD65B0 Offset: 0xD59B0 VA: 0x1800D65B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD65B0 Offset: 0xD59B0 VA: 0x1800D65B0
	// RVA: 0x522110 Offset: 0x521510 VA: 0x180522110
	public void Menu_SetClose(BasePlayer player) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	public bool Menu_SetClose_ShowIf(BasePlayer player) { }

	// RVA: 0x522370 Offset: 0x521770 VA: 0x180522370
	public void .ctor() { }

}

