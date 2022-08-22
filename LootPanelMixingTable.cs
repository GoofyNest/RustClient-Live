public class LootPanelMixingTable : LootPanel, IInventoryChanged // TypeDefIndex: 11033
{	public GameObject controlsOn; // 0x38
	public GameObject controlsOff; // 0x40
	public Button StartMixingButton; // 0x48
	public InfoBar ProgressBar; // 0x50
	public GameObject recipeItemPrefab; // 0x58
	public RectTransform recipeContentRect; // 0x60
	private List<Item> inventoryItems; // 0x68


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

