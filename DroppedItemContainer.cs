public class DroppedItemContainer : BaseCombatEntity, LootPanel.IHasLootPanel, IContainerSounds // TypeDefIndex: 8383
{	// Fields
	private Option __menuOption_Menu_Open; // 0x240
	public string lootPanelName; // 0x298
	public int maxItemCount; // 0x2A0
	public ulong playerSteamID; // 0x2A8
	public string _playerName; // 0x2B0
	public bool onlyOwnerLoot; // 0x2B8
	public SoundDefinition openSound; // 0x2C0
	public SoundDefinition closeSound; // 0x2C8

	// Properties
	public override bool HasMenuOptions { get; }
	public Translate.Phrase LootPanelTitle { get; }
	public string playerName { get; set; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }

	// Methods

	// RVA: 0xAAD4C0 Offset: 0xAAC8C0 VA: 0x180AAD4C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAAD800 Offset: 0xAACC00 VA: 0x180AAD800 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAAD960 Offset: 0xAACD60 VA: 0x180AAD960 Slot: 145
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0xAAD9A0 Offset: 0xAACDA0 VA: 0x180AAD9A0
	public string get_playerName() { }

	// RVA: 0xAAD9C0 Offset: 0xAACDC0 VA: 0x180AAD9C0
	public void set_playerName(string value) { }

	// RVA: 0xAAD740 Offset: 0xAACB40 VA: 0x180AAD740 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDA000 Offset: 0xD9400 VA: 0x1800DA000
	[BaseEntity.Menu.Description] // RVA: 0xDA000 Offset: 0xD9400 VA: 0x1800DA000
	[BaseEntity.Menu.Icon] // RVA: 0xDA000 Offset: 0xD9400 VA: 0x1800DA000
	// RVA: 0xAAD7C0 Offset: 0xAACBC0 VA: 0x180AAD7C0
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0xAAD990 Offset: 0xAACD90 VA: 0x180AAD990 Slot: 146
	public SoundDefinition get_OpenSound() { }

	// RVA: 0xAAD950 Offset: 0xAACD50 VA: 0x180AAD950 Slot: 147
	public SoundDefinition get_CloseSound() { }

	// RVA: 0xAAD8F0 Offset: 0xAACCF0 VA: 0x180AAD8F0
	public void .ctor() { }

}

