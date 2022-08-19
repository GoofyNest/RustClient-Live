public class RFBroadcaster : IOEntity, IRFObject // TypeDefIndex: 8437
{	// Fields
	private Option __menuOption_Menu_SetFreqency; // 0x288
	public int frequency; // 0x2E0
	public GameObjectRef frequencyPanelPrefab; // 0x2E8
	public const BaseEntity.Flags Flag_Broadcasting = 512;
	public bool playerUsable; // 0x2F0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x69E7C0 Offset: 0x69DBC0 VA: 0x18069E7C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x69EF60 Offset: 0x69E360 VA: 0x18069EF60 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x69EE10 Offset: 0x69E210 VA: 0x18069EE10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x69E7B0 Offset: 0x69DBB0 VA: 0x18069E7B0 Slot: 160
	public int GetFrequency() { }

	// RVA: 0x69EAD0 Offset: 0x69DED0 VA: 0x18069EAD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x80060 Offset: 0x7F460 VA: 0x180080060
	[BaseEntity.Menu.Description] // RVA: 0x80060 Offset: 0x7F460 VA: 0x180080060
	[BaseEntity.Menu.Icon] // RVA: 0x80060 Offset: 0x7F460 VA: 0x180080060
	[BaseEntity.Menu.ShowIf] // RVA: 0x80060 Offset: 0x7F460 VA: 0x180080060
	// RVA: 0x69EB30 Offset: 0x69DF30 VA: 0x18069EB30
	public void Menu_SetFreqency(BasePlayer player) { }

	// RVA: 0x69ED40 Offset: 0x69E140 VA: 0x18069ED40
	public bool Menu_SetFrequency_ShowIf(BasePlayer player) { }

	// RVA: 0x69E760 Offset: 0x69DB60 VA: 0x18069E760 Slot: 159
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x69EF00 Offset: 0x69E300 VA: 0x18069EF00
	public void .ctor() { }

}

