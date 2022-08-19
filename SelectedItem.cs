public class SelectedItem : SingletonComponent<SelectedItem>, IInventoryChanged // TypeDefIndex: 11050
{	// Fields
	public Image icon; // 0x18
	public Image iconSplitter; // 0x20
	public RustText title; // 0x28
	public RustText description; // 0x30
	public GameObject splitPanel; // 0x38
	public GameObject itemProtection; // 0x40
	public GameObject menuOption; // 0x48
	public GameObject optionsParent; // 0x50
	public GameObject innerPanelContainer; // 0x58
	private Animator animator; // 0x60
	private ProtectionValue[] protectionValues; // 0x68
	private ItemInformationPanel[] informationPanels; // 0x70
	private List<Option> previousOptions; // 0x78
	private Item lastItem; // 0x80
	internal bool wasOpen; // 0x88
	public static ItemIcon selectedItem; // 0x0
	public static ItemIcon hoveredItem; // 0x8

	// Properties
	public static Item item { get; }

	// Methods

	// RVA: 0x4A9B00 Offset: 0x4A8F00 VA: 0x1804A9B00
	public static void UpdateItem() { }

	// RVA: 0x4A9DE0 Offset: 0x4A91E0 VA: 0x1804A9DE0
	public static Item get_item() { }

	// RVA: 0x4A98D0 Offset: 0x4A8CD0 VA: 0x1804A98D0
	private void Start() { }

	// RVA: 0x4A9000 Offset: 0x4A8400 VA: 0x1804A9000
	private void OnEnable() { }

	// RVA: 0x4A8F50 Offset: 0x4A8350 VA: 0x1804A8F50
	private void OnDisable() { }

	// RVA: 0x4A8C40 Offset: 0x4A8040 VA: 0x1804A8C40
	public bool NeedsOptionsUpdate(List<Option> oldOpts, List<Option> newOpts, Item item) { }

	// RVA: 0x4A90F0 Offset: 0x4A84F0 VA: 0x1804A90F0 Slot: 8
	public void OnInventoryChanged() { }

	// RVA: 0x4A9120 Offset: 0x4A8520 VA: 0x1804A9120
	private void RefreshItem(Item item) { }

	// RVA: 0x4A89B0 Offset: 0x4A7DB0 VA: 0x1804A89B0
	public static List<Option> ItemMenuOptions(Item item) { }

	// RVA: 0x4A9BE0 Offset: 0x4A8FE0 VA: 0x1804A9BE0
	public void Update() { }

	// RVA: 0x4A99D0 Offset: 0x4A8DD0 VA: 0x1804A99D0
	public static void TrySelect(ItemIcon newSelect, bool silent = False) { }

	// RVA: 0x4A8870 Offset: 0x4A7C70 VA: 0x1804A8870
	public static void ClearIfSelected(ItemIcon newSelect) { }

	// RVA: 0x4A88F0 Offset: 0x4A7CF0 VA: 0x1804A88F0
	public static void ClearSelection() { }

	// RVA: 0x4A97D0 Offset: 0x4A8BD0 VA: 0x1804A97D0
	internal static void SetHovered(ItemIcon item) { }

	// RVA: 0x4A9D80 Offset: 0x4A9180 VA: 0x1804A9D80
	public void .ctor() { }

}

