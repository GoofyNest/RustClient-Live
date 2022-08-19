public class StorageContainer : DecayEntity, IItemContainerEntity, LootPanel.IHasLootPanel, IContainerSounds // TypeDefIndex: 8457
{	// Fields
	private Option __menuOption_Menu_Occupied; // 0x258
	private Option __menuOption_Menu_OnFire; // 0x2B0
	private Option __menuOption_Menu_Open; // 0x308
	[HeaderAttribute] // RVA: 0x8DE00 Offset: 0x8D200 VA: 0x18008DE00
	public static readonly Translate.Phrase LockedMessage; // 0x0
	public static readonly Translate.Phrase InUseMessage; // 0x8
	public int inventorySlots; // 0x360
	public bool dropsLoot; // 0x364
	public bool dropFloats; // 0x365
	public bool isLootable; // 0x366
	public bool isLockable; // 0x367
	public bool isMonitorable; // 0x368
	public string panelName; // 0x370
	public Translate.Phrase panelTitle; // 0x378
	public ItemContainer.ContentsType allowedContents; // 0x380
	public ItemDefinition allowedItem; // 0x388
	public ItemDefinition allowedItem2; // 0x390
	public int maxStackSize; // 0x398
	public bool needsBuildingPrivilegeToUse; // 0x39C
	public bool mustBeMountedToUse; // 0x39D
	public SoundDefinition openSound; // 0x3A0
	public SoundDefinition closeSound; // 0x3A8
	[HeaderAttribute] // RVA: 0x8DEA0 Offset: 0x8D2A0 VA: 0x18008DEA0
	public Vector3 dropPosition; // 0x3B0
	public Vector3 dropVelocity; // 0x3BC
	public ItemCategory onlyAcceptCategory; // 0x3C8
	public bool onlyOneUser; // 0x3CC

	// Properties
	public override bool HasMenuOptions { get; }
	public Translate.Phrase LootPanelTitle { get; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }

	// Methods

	// RVA: 0x79A6A0 Offset: 0x799AA0 VA: 0x18079A6A0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x79B520 Offset: 0x79A920 VA: 0x18079B520 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x79B180 Offset: 0x79A580 VA: 0x18079B180 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x79B690 Offset: 0x79AA90 VA: 0x18079B690 Slot: 147
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0x79B270 Offset: 0x79A670 VA: 0x18079B270 Slot: 27
	public override void ResetState() { }

	// RVA: 0x79AFD0 Offset: 0x79A3D0 VA: 0x18079AFD0 Slot: 150
	public virtual void OnDrawGizmos() { }

	// RVA: 0x79AE30 Offset: 0x79A230 VA: 0x18079AE30 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0x79AEF0 Offset: 0x79A2F0 VA: 0x18079AEF0
	public bool OccupiedCheck(BasePlayer player) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 151
	public virtual int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x513D90 Offset: 0x513190 VA: 0x180513D90 Slot: 152
	public virtual int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x79B280 Offset: 0x79A680 VA: 0x18079B280 Slot: 153
	public virtual bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.Description] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.Icon] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	// RVA: 0x79AEB0 Offset: 0x79A2B0 VA: 0x18079AEB0
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x79AE90 Offset: 0x79A290 VA: 0x18079AE90 Slot: 154
	protected virtual bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E120 Offset: 0x8D520 VA: 0x18008E120
	[BaseEntity.Menu.Description] // RVA: 0x8E120 Offset: 0x8D520 VA: 0x18008E120
	[BaseEntity.Menu.Icon] // RVA: 0x8E120 Offset: 0x8D520 VA: 0x18008E120
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E120 Offset: 0x8D520 VA: 0x18008E120
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_Occupied(BasePlayer player) { }

	// RVA: 0x79AE60 Offset: 0x79A260 VA: 0x18079AE60
	public bool Menu_Occupied_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E450 Offset: 0x8D850 VA: 0x18008E450
	[BaseEntity.Menu.Icon] // RVA: 0x8E450 Offset: 0x8D850 VA: 0x18008E450
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E450 Offset: 0x8D850 VA: 0x18008E450
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_OnFire(BasePlayer player) { }

	// RVA: 0x79AE80 Offset: 0x79A280 VA: 0x18079AE80
	public bool Menu_OnFire_ShowIf(BasePlayer player) { }

	// RVA: 0x5B5140 Offset: 0x5B4540 VA: 0x1805B5140 Slot: 148
	public SoundDefinition get_OpenSound() { }

	// RVA: 0x79B510 Offset: 0x79A910 VA: 0x18079B510 Slot: 149
	public SoundDefinition get_CloseSound() { }

	// RVA: 0x79B420 Offset: 0x79A820 VA: 0x18079B420
	public void .ctor() { }

	// RVA: 0x79B370 Offset: 0x79A770 VA: 0x18079B370
	private static void .cctor() { }

}

