public class RFBroadcaster : IOEntity, IRFObject // TypeDefIndex: 8437
{	private Option __menuOption_Menu_SetFreqency; // 0x288
	public int frequency; // 0x2E0
	public GameObjectRef frequencyPanelPrefab; // 0x2E8
	public const BaseEntity.Flags Flag_Broadcasting = 512;
	public bool playerUsable; // 0x2F0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public int GetFrequency() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x80060 Offset: 0x7F460 VA: 0x180080060
	[BaseEntity.Menu.Description] // RVA: 0x80060 Offset: 0x7F460 VA: 0x180080060
	[BaseEntity.Menu.Icon] // RVA: 0x80060 Offset: 0x7F460 VA: 0x180080060
	[BaseEntity.Menu.ShowIf] // RVA: 0x80060 Offset: 0x7F460 VA: 0x180080060
	public void Menu_SetFreqency(BasePlayer player) { }

	public bool Menu_SetFrequency_ShowIf(BasePlayer player) { }

	public void ClientSetFrequency(int newFreq) { }

	public void .ctor() { }

}

