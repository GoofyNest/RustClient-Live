public class ContainerIOEntity : IOEntity, IItemContainerEntity, LootPanel.IHasLootPanel, IContainerSounds // TypeDefIndex: 8375
{	// Fields
	private Option __menuOption_Menu_Occupied; // 0x288
	private Option __menuOption_Menu_Open; // 0x2E0
	public ItemDefinition onlyAllowedItem; // 0x338
	public ItemContainer.ContentsType allowedContents; // 0x340
	public int maxStackSize; // 0x344
	public int numSlots; // 0x348
	public string lootPanelName; // 0x350
	public Translate.Phrase panelTitle; // 0x358
	public bool needsBuildingPrivilegeToUse; // 0x360
	public bool isLootable; // 0x361
	public bool dropsLoot; // 0x362
	public bool dropFloats; // 0x363
	public bool onlyOneUser; // 0x364
	public SoundDefinition openSound; // 0x368
	public SoundDefinition closeSound; // 0x370

	// Properties
	public override bool HasMenuOptions { get; }
	public Translate.Phrase LootPanelTitle { get; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }

	// Methods

	// RVA: 0x513840 Offset: 0x512C40 VA: 0x180513840 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5141F0 Offset: 0x5135F0 VA: 0x1805141F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x513F20 Offset: 0x513320 VA: 0x180513F20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x514330 Offset: 0x513730 VA: 0x180514330 Slot: 161
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0x513E40 Offset: 0x513240 VA: 0x180513E40
	public bool OccupiedCheck(BasePlayer player) { }

	// RVA: 0x513DA0 Offset: 0x5131A0 VA: 0x180513DA0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.Description] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.Icon] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	// RVA: 0x513E00 Offset: 0x513200 VA: 0x180513E00
	public void Menu_Open(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E120 Offset: 0x8D520 VA: 0x18008E120
	[BaseEntity.Menu.Description] // RVA: 0x8E120 Offset: 0x8D520 VA: 0x18008E120
	[BaseEntity.Menu.Icon] // RVA: 0x8E120 Offset: 0x8D520 VA: 0x18008E120
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E120 Offset: 0x8D520 VA: 0x18008E120
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_Occupied(BasePlayer player) { }

	// RVA: 0x513DC0 Offset: 0x5131C0 VA: 0x180513DC0
	public bool Menu_Occupied_ShowIf(BasePlayer player) { }

	// RVA: 0x513DE0 Offset: 0x5131E0 VA: 0x180513DE0
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x514010 Offset: 0x513410 VA: 0x180514010 Slot: 164
	public virtual bool ShouldShowLootMenus() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 165
	public virtual int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x513D90 Offset: 0x513190 VA: 0x180513D90 Slot: 166
	public virtual int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x514340 Offset: 0x513740 VA: 0x180514340 Slot: 162
	public SoundDefinition get_OpenSound() { }

	// RVA: 0x5141E0 Offset: 0x5135E0 VA: 0x1805141E0 Slot: 163
	public SoundDefinition get_CloseSound() { }

	// RVA: 0x514110 Offset: 0x513510 VA: 0x180514110
	public void .ctor() { }

}

