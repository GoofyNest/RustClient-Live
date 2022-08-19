public class LootPanelVendingMachine : LootPanel, IVendingMachineInterface // TypeDefIndex: 8732
{	// Fields
	public GameObjectRef sellOrderPrefab; // 0x38
	public GameObject sellOrderContainer; // 0x40
	public GameObject busyOverlayPrefab; // 0x48
	private GameObject busyOverlayInstance; // 0x50
	public static LootPanelVendingMachine Instance; // 0x0

	// Methods

	// RVA: 0x569E70 Offset: 0x569270 VA: 0x180569E70
	public void OnEnable() { }

	// RVA: 0x569D70 Offset: 0x569170 VA: 0x180569D70 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x569D60 Offset: 0x569160 VA: 0x180569D60
	public void Initialize() { }

	// RVA: 0x569CD0 Offset: 0x5690D0 VA: 0x180569CD0
	public VendingMachine GetVendingMachine() { }

	// RVA: 0x56A0A0 Offset: 0x5694A0 VA: 0x18056A0A0
	public void UpdateSellOrders() { }

	// RVA: 0x569CA0 Offset: 0x5690A0 VA: 0x180569CA0
	public void ClearSellOrders() { }

	// RVA: 0x569EE0 Offset: 0x5692E0 VA: 0x180569EE0
	public void SetBusyOverlay(bool on) { }

	// RVA: 0x56A2F0 Offset: 0x5696F0 VA: 0x18056A2F0 Slot: 5
	public override void Update() { }

	// RVA: 0x569BE0 Offset: 0x568FE0 VA: 0x180569BE0 Slot: 7
	public void BuyButtonClicked(int index, int multiplier = 1) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

