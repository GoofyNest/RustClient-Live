public class SelectedItem : SingletonComponent<SelectedItem>, IInventoryChanged // TypeDefIndex: 11050
{	public Image icon; // 0x18
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

	public static Item item { get; }


	public static void UpdateItem() { }

	public static Item get_item() { }

	private void Start() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public bool NeedsOptionsUpdate(List<Option> oldOpts, List<Option> newOpts, Item item) { }

	public void OnInventoryChanged() { }

	private void RefreshItem(Item item) { }

	public static List<Option> ItemMenuOptions(Item item) { }

	public void Update() { }

	public static void TrySelect(ItemIcon newSelect, bool silent = False) { }

	public static void ClearIfSelected(ItemIcon newSelect) { }

	public static void ClearSelection() { }

	internal static void SetHovered(ItemIcon item) { }

	public void .ctor() { }

}

