public class VendingPanelAdmin : UIDialog // TypeDefIndex: 8737
{	// Fields
	public GameObject sellOrderAdminContainer; // 0x30
	public GameObject sellOrderAdminPrefab; // 0x38
	public InputField storeNameInputField; // 0x40
	private VendingMachine vendingMachine; // 0x48

	// Methods

	// RVA: 0xAD8350 Offset: 0xAD7750 VA: 0x180AD8350 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0xAD81F0 Offset: 0xAD75F0 VA: 0x180AD81F0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0xAD81E0 Offset: 0xAD75E0 VA: 0x180AD81E0
	public void Awake() { }

	// RVA: 0xAD86D0 Offset: 0xAD7AD0 VA: 0x180AD86D0
	public void VendingMachineUpdated() { }

	// RVA: 0xAD83D0 Offset: 0xAD77D0 VA: 0x180AD83D0
	public void UpdateSellOrders() { }

	// RVA: 0xAD8370 Offset: 0xAD7770 VA: 0x180AD8370
	public void SetVendingMachine(VendingMachine vend) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public VendingMachine GetVendingMachine() { }

	// RVA: 0xAD8630 Offset: 0xAD7A30 VA: 0x180AD8630
	public void Update() { }

	// RVA: 0xAD82C0 Offset: 0xAD76C0 VA: 0x180AD82C0
	public void DeleteClicked(int index) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void StoreNameTextChanged() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void StoreNameTextComplete() { }

	// RVA: 0x4BE840 Offset: 0x4BDC40 VA: 0x1804BE840
	public void .ctor() { }

}

