public class LootPanelMixingTable : LootPanel, IInventoryChanged // TypeDefIndex: 12823
{
	public GameObject controlsOn;
	public GameObject controlsOff;
	public Button StartMixingButton;
	public InfoBar ProgressBar;
	public GameObject recipeItemPrefab;
	public RectTransform recipeContentRect;
	private List<Item> inventoryItems;


	private void OnEnable() { }

	protected override void OnDisable() { }

	public void SetupRecipeBook() { }

	private void DestroyRecipeItems() { }

	public override void Update() { }

	public void OnInventoryChanged() { }

	private void RefreshRecipeValidity() { }

	public MixingTable GetMixingTable() { }

	public bool IsOn() { }

	public void Switch(bool onOff) { }

	public void .ctor() { }

}

