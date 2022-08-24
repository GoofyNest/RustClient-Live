public class ContainerIOEntity : IOEntity, IItemContainerEntity, LootPanel.IHasLootPanel, IContainerSounds // TypeDefIndex: 8375
{
	private Option __menuOption_Menu_Occupied; 
	private Option __menuOption_Menu_Open; 
	public ItemDefinition onlyAllowedItem; 
	public ItemContainer.ContentsType allowedContents; 
	public int maxStackSize; 
	public int numSlots; 
	public string lootPanelName; 
	public Translate.Phrase panelTitle; 
	public bool needsBuildingPrivilegeToUse; 
	public bool isLootable; 
	public bool dropsLoot; 
	public bool dropFloats; 
	public bool onlyOneUser; 
	public SoundDefinition openSound; 
	public SoundDefinition closeSound; 

public override bool HasMenuOptions { get; }
public Translate.Phrase LootPanelTitle { get; }
public SoundDefinition OpenSound { get; }
public SoundDefinition CloseSound { get; }


public override void GetMenuOptions(List<Option> list) { }

public override bool get_HasMenuOptions() { }

public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

public Translate.Phrase get_LootPanelTitle() { }

public bool OccupiedCheck(BasePlayer player) { }

public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
public void Menu_Open(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
public void Menu_Occupied(BasePlayer player) { }

public bool Menu_Occupied_ShowIf(BasePlayer player) { }

public bool Menu_Open_ShowIf(BasePlayer player) { }

public virtual bool ShouldShowLootMenus() { }

public virtual int GetMoveToContainerIndex(BasePlayer player, Item item) { }

public virtual int GetMoveToSlotIndex(BasePlayer player, Item item) { }

public SoundDefinition get_OpenSound() { }

public SoundDefinition get_CloseSound() { }

public void .ctor() { }

}

