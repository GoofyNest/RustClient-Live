public class SpookySpeaker : BaseCombatEntity // TypeDefIndex: 8453
{	// Fields
	private Option __menuOption_Menu_SoundOff; // 0x240
	private Option __menuOption_Menu_SoundOn; // 0x298
	public SoundPlayer soundPlayer; // 0x2F0
	public float soundSpacing; // 0x2F8
	public float soundSpacingRand; // 0x2FC

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA7C070 Offset: 0xA7B470 VA: 0x180A7C070 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA7CB90 Offset: 0xA7BF90 VA: 0x180A7CB90 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA7C6A0 Offset: 0xA7BAA0 VA: 0x180A7C6A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA7CAD0 Offset: 0xA7BED0 VA: 0x180A7CAD0
	public void PlaySpookySound() { }

	[BaseEntity.Menu] // RVA: 0x8D340 Offset: 0x8C740 VA: 0x18008D340
	[BaseEntity.Menu.Description] // RVA: 0x8D340 Offset: 0x8C740 VA: 0x18008D340
	[BaseEntity.Menu.Icon] // RVA: 0x8D340 Offset: 0x8C740 VA: 0x18008D340
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D340 Offset: 0x8C740 VA: 0x18008D340
	// RVA: 0xA7C650 Offset: 0xA7BA50 VA: 0x180A7C650
	public void Menu_SoundOn(BasePlayer player) { }

	// RVA: 0x79DDE0 Offset: 0x79D1E0 VA: 0x18079DDE0
	public bool Menu_SoundOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8D570 Offset: 0x8C970 VA: 0x18008D570
	[BaseEntity.Menu.Description] // RVA: 0x8D570 Offset: 0x8C970 VA: 0x18008D570
	[BaseEntity.Menu.Icon] // RVA: 0x8D570 Offset: 0x8C970 VA: 0x18008D570
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D570 Offset: 0x8C970 VA: 0x18008D570
	// RVA: 0xA7C600 Offset: 0xA7BA00 VA: 0x180A7C600
	public void Menu_SoundOff(BasePlayer player) { }

	// RVA: 0x79DDA0 Offset: 0x79D1A0 VA: 0x18079DDA0
	public bool Menu_SoundOff_ShowIf(BasePlayer player) { }

	// RVA: 0xA7CB70 Offset: 0xA7BF70 VA: 0x180A7CB70
	public void .ctor() { }

}

