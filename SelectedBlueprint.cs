public class SelectedBlueprint : SingletonComponent<SelectedBlueprint>, IInventoryChanged // TypeDefIndex: 10992
{	public ItemBlueprint blueprint; // 0x18
	public InputField craftAmountText; // 0x20
	public GameObject ingredientGrid; // 0x28
	public IconSkinPicker skinPicker; // 0x30
	public Image iconImage; // 0x38
	public RustText titleText; // 0x40
	public RustText descriptionText; // 0x48
	public CanvasGroup CraftArea; // 0x50
	public Button CraftButton; // 0x58
	public RustText CraftingTime; // 0x60
	public RustText CraftingAmount; // 0x68
	public Sprite FavouriteOnSprite; // 0x70
	public Sprite FavouriteOffSprite; // 0x78
	public Image FavouriteButtonStatusMarker; // 0x80
	public GameObject[] workbenchReqs; // 0x88
	private ItemInformationPanel[] informationPanels; // 0x90
	private bool needsRefresh; // 0x98
	private int craftAmount; // 0x9C
	private BlueprintCraftGridRow[] ingredientRows; // 0xA0

	public static bool isOpen { get; }


	public static void UpdateBlueprint(ItemBlueprint blueprint) { }

	public static void RefreshFavouriteDisplay() { }

	public static bool get_isOpen() { }

	private void Start() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void ChangeEffects() { }

	public void OnInventoryChanged() { }

	private void RefreshBlueprint() { }

	public void Max() { }

	public void StartCrafting() { }

	public void AddToCraft(int i) { }

	public void SetCraftFromTextbox(string i) { }

	public void SetCraft(int i) { }

	public void UpdateIngredients() { }

	private void Update() { }

	public bool CanCraft() { }

	public bool CanCraftAmount(int amount) { }

	public void Unlock() { }

	public void ToggleFavourite() { }

	private void RefreshFavouriteButton() { }

	public void .ctor() { }

}

private sealed class SelectedBlueprint.<>c__DisplayClass30_0 // TypeDefIndex: 10993
{	public int inventoryId; // 0x10


	public void .ctor() { }

	internal bool <StartCrafting>b__0(ItemSkinDirectory.Skin x) { }

	internal bool <StartCrafting>b__1(IPlayerItemDefinition x) { }

}

