public class StorageContainer : DecayEntity, IItemContainerEntity, IIdealSlotEntity, LootPanel.IHasLootPanel, IContainerSounds // TypeDefIndex: 10180
{
	private Option __menuOption_Menu_Occupied;
	private Option __menuOption_Menu_OnFire;
	private Option __menuOption_Menu_Open;
	[HeaderAttribute]
	public static readonly Translate.Phrase LockedMessage;
	public static readonly Translate.Phrase InUseMessage;
	public int inventorySlots;
	public bool dropsLoot;
	public bool dropFloats;
	public bool isLootable;
	public bool isLockable;
	public bool isMonitorable;
	public string panelName;
	public Translate.Phrase panelTitle;
	public ItemContainer.ContentsType allowedContents;
	public ItemDefinition allowedItem;
	public ItemDefinition allowedItem2;
	public int maxStackSize;
	public bool needsBuildingPrivilegeToUse;
	public bool mustBeMountedToUse;
	public SoundDefinition openSound;
	public SoundDefinition closeSound;
	[HeaderAttribute]
	public Vector3 dropPosition;
	public Vector3 dropVelocity;
	public ItemCategory onlyAcceptCategory;
	public bool onlyOneUser;

	public override bool HasMenuOptions { get; }
	public Translate.Phrase LootPanelTitle { get; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public Translate.Phrase get_LootPanelTitle() { }

	public override void ResetState() { }

	public virtual void OnDrawGizmos() { }

	public override bool HasSlot(BaseEntity.Slot slot) { }

	public bool OccupiedCheck(BasePlayer player) { }

	public virtual bool ShouldShowLootMenus() { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Open(BasePlayer player) { }

	protected virtual bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Occupied(BasePlayer player) { }

	public bool Menu_Occupied_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_OnFire(BasePlayer player) { }

	public bool Menu_OnFire_ShowIf(BasePlayer player) { }

	public SoundDefinition get_OpenSound() { }

	public SoundDefinition get_CloseSound() { }

	public void .ctor() { }

	private static void .cctor() { }

}

