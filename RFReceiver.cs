public class RFReceiver : IOEntity, IRFObject // TypeDefIndex: 8438
{	// Fields
	private Option __menuOption_Menu_SetFreqency; // 0x288
	public int frequency; // 0x2E0
	public GameObjectRef frequencyPanelPrefab; // 0x2E8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x69F1E0 Offset: 0x69E5E0 VA: 0x18069F1E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x69F900 Offset: 0x69ED00 VA: 0x18069F900 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x69F7B0 Offset: 0x69EBB0 VA: 0x18069F7B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x69E7B0 Offset: 0x69DBB0 VA: 0x18069E7B0 Slot: 160
	public int GetFrequency() { }

	// RVA: 0x69EAD0 Offset: 0x69DED0 VA: 0x18069EAD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x80520 Offset: 0x7F920 VA: 0x180080520
	[BaseEntity.Menu.Description] // RVA: 0x80520 Offset: 0x7F920 VA: 0x180080520
	[BaseEntity.Menu.Icon] // RVA: 0x80520 Offset: 0x7F920 VA: 0x180080520
	[BaseEntity.Menu.ShowIf] // RVA: 0x80520 Offset: 0x7F920 VA: 0x180080520
	// RVA: 0x69F4F0 Offset: 0x69E8F0 VA: 0x18069F4F0
	public void Menu_SetFreqency(BasePlayer player) { }

	// RVA: 0x69F700 Offset: 0x69EB00 VA: 0x18069F700
	public bool Menu_SetFrequency_ShowIf(BasePlayer player) { }

	// RVA: 0x69F190 Offset: 0x69E590 VA: 0x18069F190 Slot: 159
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x69F8A0 Offset: 0x69ECA0 VA: 0x18069F8A0
	public void .ctor() { }

}

