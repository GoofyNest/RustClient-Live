public class SelectedBlueprint : SingletonComponent<SelectedBlueprint>, IInventoryChanged // TypeDefIndex: 12725
{
	public ItemBlueprint blueprint; 
	public InputField craftAmountText; 
	public GameObject ingredientGrid; 
	public IconSkinPicker skinPicker; 
	public Image iconImage; 
	public RustText titleText; 
	public RustText descriptionText; 
	public CanvasGroup CraftArea; 
	public Button CraftButton; 
	public RustText CraftingTime; 
	public RustText CraftingAmount; 
	public Sprite FavouriteOnSprite; 
	public Sprite FavouriteOffSprite; 
	public Image FavouriteButtonStatusMarker; 
	public GameObject[] workbenchReqs; 
	private ItemInformationPanel[] informationPanels; 
	private bool needsRefresh; 
	private int craftAmount; 
	private BlueprintCraftGridRow[] ingredientRows; 

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

private sealed class SelectedBlueprint.<>c__DisplayClass30_0 // TypeDefIndex: 12726
{
	public int inventoryId; 


	public void .ctor() { }

	internal bool <StartCrafting>b__0(ItemSkinDirectory.Skin x) { }

	internal bool <StartCrafting>b__1(IPlayerItemDefinition x) { }

}

