public class DroppedItemContainer : BaseCombatEntity, LootPanel.IHasLootPanel, IContainerSounds // TypeDefIndex: 8383
{	private Option __menuOption_Menu_Open; // 0x240
	public string lootPanelName; // 0x298
	public int maxItemCount; // 0x2A0
	public ulong playerSteamID; // 0x2A8
	public string _playerName; // 0x2B0
	public bool onlyOwnerLoot; // 0x2B8
	public SoundDefinition openSound; // 0x2C0
	public SoundDefinition closeSound; // 0x2C8

	public override bool HasMenuOptions { get; }
	public Translate.Phrase LootPanelTitle { get; }
	public string playerName { get; set; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public Translate.Phrase get_LootPanelTitle() { }

	public string get_playerName() { }

	public void set_playerName(string value) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDA000 Offset: 0xD9400 VA: 0x1800DA000
	[BaseEntity.Menu.Description] // RVA: 0xDA000 Offset: 0xD9400 VA: 0x1800DA000
	[BaseEntity.Menu.Icon] // RVA: 0xDA000 Offset: 0xD9400 VA: 0x1800DA000
	public void Menu_Open(BasePlayer player) { }

	public SoundDefinition get_OpenSound() { }

	public SoundDefinition get_CloseSound() { }

	public void .ctor() { }

}

