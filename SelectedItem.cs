public class SelectedItem : SingletonComponent<SelectedItem>, IInventoryChanged // TypeDefIndex: 12840
{
	public Image icon;
	public Image iconSplitter;
	public RustText title;
	public RustText description;
	public GameObject splitPanel;
	public GameObject itemProtection;
	public GameObject menuOption;
	public GameObject optionsParent;
	public GameObject innerPanelContainer;
	private Animator animator;
	private ProtectionValue[] protectionValues;
	private ItemInformationPanel[] informationPanels;
	private List<Option> previousOptions;
	private Item lastItem;
	internal bool wasOpen;
	public static ItemIcon selectedItem;
	public static ItemIcon hoveredItem;

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

