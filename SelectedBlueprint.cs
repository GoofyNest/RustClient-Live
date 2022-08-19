public class SelectedBlueprint : SingletonComponent<SelectedBlueprint>, IInventoryChanged // TypeDefIndex: 10992
{	// Fields
	public ItemBlueprint blueprint; // 0x18
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

	// Properties
	public static bool isOpen { get; }

	// Methods

	// RVA: 0x4A7460 Offset: 0x4A6860 VA: 0x1804A7460
	public static void UpdateBlueprint(ItemBlueprint blueprint) { }

	// RVA: 0x4A6B00 Offset: 0x4A5F00 VA: 0x1804A6B00
	public static void RefreshFavouriteDisplay() { }

	// RVA: 0x4A7B60 Offset: 0x4A6F60 VA: 0x1804A7B60
	public static bool get_isOpen() { }

	// RVA: 0x4A7200 Offset: 0x4A6600 VA: 0x1804A7200
	private void Start() { }

	// RVA: 0x4A6410 Offset: 0x4A5810 VA: 0x1804A6410
	private void OnEnable() { }

	// RVA: 0x4A6360 Offset: 0x4A5760 VA: 0x1804A6360
	private void OnDisable() { }

	// RVA: 0x4A6050 Offset: 0x4A5450 VA: 0x1804A6050
	public void ChangeEffects() { }

	// RVA: 0x4A64B0 Offset: 0x4A58B0 VA: 0x1804A64B0 Slot: 8
	public void OnInventoryChanged() { }

	// RVA: 0x4A64C0 Offset: 0x4A58C0 VA: 0x1804A64C0
	private void RefreshBlueprint() { }

	// RVA: 0x4A61F0 Offset: 0x4A55F0 VA: 0x1804A61F0
	public void Max() { }

	// RVA: 0x4A6CA0 Offset: 0x4A60A0 VA: 0x1804A6CA0
	public void StartCrafting() { }

	// RVA: 0x4A5EF0 Offset: 0x4A52F0 VA: 0x1804A5EF0
	public void AddToCraft(int i) { }

	// RVA: 0x4A6B70 Offset: 0x4A5F70 VA: 0x1804A6B70
	public void SetCraftFromTextbox(string i) { }

	// RVA: 0x4A6BB0 Offset: 0x4A5FB0 VA: 0x1804A6BB0
	public void SetCraft(int i) { }

	// RVA: 0x4A7800 Offset: 0x4A6C00 VA: 0x1804A7800
	public void UpdateIngredients() { }

	// RVA: 0x4A7A40 Offset: 0x4A6E40 VA: 0x1804A7A40
	private void Update() { }

	// RVA: 0x4A5F90 Offset: 0x4A5390 VA: 0x1804A5F90
	public bool CanCraft() { }

	// RVA: 0x4A5F00 Offset: 0x4A5300 VA: 0x1804A5F00
	public bool CanCraftAmount(int amount) { }

	// RVA: 0x4A7310 Offset: 0x4A6710 VA: 0x1804A7310
	public void Unlock() { }

	// RVA: 0x4A7250 Offset: 0x4A6650 VA: 0x1804A7250
	public void ToggleFavourite() { }

	// RVA: 0x4A6A00 Offset: 0x4A5E00 VA: 0x1804A6A00
	private void RefreshFavouriteButton() { }

	// RVA: 0x4A7B00 Offset: 0x4A6F00 VA: 0x1804A7B00
	public void .ctor() { }

}

private sealed class SelectedBlueprint.<>c__DisplayClass30_0 // TypeDefIndex: 10993
{	// Fields
	public int inventoryId; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B0A30 Offset: 0x4AFE30 VA: 0x1804B0A30
	internal bool <StartCrafting>b__0(ItemSkinDirectory.Skin x) { }

	// RVA: 0x4B0A40 Offset: 0x4AFE40 VA: 0x1804B0A40
	internal bool <StartCrafting>b__1(IPlayerItemDefinition x) { }

}

