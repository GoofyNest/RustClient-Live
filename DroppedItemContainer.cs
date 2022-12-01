public class DroppedItemContainer : BaseCombatEntity, LootPanel.IHasLootPanel, IContainerSounds // TypeDefIndex: 10103
{
	private Option __menuOption_Menu_Open;
	public string lootPanelName;
	public int maxItemCount;
	public ulong playerSteamID;
	public string _playerName;
	public bool onlyOwnerLoot;
	public SoundDefinition openSound;
	public SoundDefinition closeSound;

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

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	public void Menu_Open(BasePlayer player) { }

	public SoundDefinition get_OpenSound() { }

	public SoundDefinition get_CloseSound() { }

	public void .ctor() { }

}

