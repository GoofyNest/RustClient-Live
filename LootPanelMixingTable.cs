public class LootPanelMixingTable : LootPanel, IInventoryChanged // TypeDefIndex: 11033
{	// Fields
	public GameObject controlsOn; // 0x38
	public GameObject controlsOff; // 0x40
	public Button StartMixingButton; // 0x48
	public InfoBar ProgressBar; // 0x50
	public GameObject recipeItemPrefab; // 0x58
	public RectTransform recipeContentRect; // 0x60
	private List<Item> inventoryItems; // 0x68

	// Methods

	// RVA: 0x505510 Offset: 0x504910 VA: 0x180505510
	private void OnEnable() { }

	// RVA: 0x505450 Offset: 0x504850 VA: 0x180505450 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x505810 Offset: 0x504C10 VA: 0x180505810
	public void SetupRecipeBook() { }

	// RVA: 0x5052C0 Offset: 0x5046C0 VA: 0x1805052C0
	private void DestroyRecipeItems() { }

	// RVA: 0x505CD0 Offset: 0x5050D0 VA: 0x180505CD0 Slot: 5
	public override void Update() { }

	// RVA: 0x5055A0 Offset: 0x5049A0 VA: 0x1805055A0 Slot: 7
	public void OnInventoryChanged() { }

	// RVA: 0x5055B0 Offset: 0x5049B0 VA: 0x1805055B0
	private void RefreshRecipeValidity() { }

	// RVA: 0x505390 Offset: 0x504790 VA: 0x180505390
	public MixingTable GetMixingTable() { }

	// RVA: 0x505420 Offset: 0x504820 VA: 0x180505420
	public bool IsOn() { }

	// RVA: 0x505B60 Offset: 0x504F60 VA: 0x180505B60
	public void Switch(bool onOff) { }

	// RVA: 0x505EE0 Offset: 0x5052E0 VA: 0x180505EE0
	public void .ctor() { }

}

