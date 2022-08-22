public class SpookySpeaker : BaseCombatEntity // TypeDefIndex: 8453
{	private Option __menuOption_Menu_SoundOff; // 0x240
	private Option __menuOption_Menu_SoundOn; // 0x298
	public SoundPlayer soundPlayer; // 0x2F0
	public float soundSpacing; // 0x2F8
	public float soundSpacingRand; // 0x2FC

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void PlaySpookySound() { }

	[BaseEntity.Menu] // RVA: 0x8D340 Offset: 0x8C740 VA: 0x18008D340
	[BaseEntity.Menu.Description] // RVA: 0x8D340 Offset: 0x8C740 VA: 0x18008D340
	[BaseEntity.Menu.Icon] // RVA: 0x8D340 Offset: 0x8C740 VA: 0x18008D340
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D340 Offset: 0x8C740 VA: 0x18008D340
	public void Menu_SoundOn(BasePlayer player) { }

	public bool Menu_SoundOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8D570 Offset: 0x8C970 VA: 0x18008D570
	[BaseEntity.Menu.Description] // RVA: 0x8D570 Offset: 0x8C970 VA: 0x18008D570
	[BaseEntity.Menu.Icon] // RVA: 0x8D570 Offset: 0x8C970 VA: 0x18008D570
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D570 Offset: 0x8C970 VA: 0x18008D570
	public void Menu_SoundOff(BasePlayer player) { }

	public bool Menu_SoundOff_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

