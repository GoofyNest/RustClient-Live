public class LootPanelVendingMachine : LootPanel, IVendingMachineInterface // TypeDefIndex: 8732
{	public GameObjectRef sellOrderPrefab; // 0x38
	public GameObject sellOrderContainer; // 0x40
	public GameObject busyOverlayPrefab; // 0x48
	private GameObject busyOverlayInstance; // 0x50
	public static LootPanelVendingMachine Instance; // 0x0


	public void OnEnable() { }

	protected override void OnDisable() { }

	public void Initialize() { }

	public VendingMachine GetVendingMachine() { }

	public void UpdateSellOrders() { }

	public void ClearSellOrders() { }

	public void SetBusyOverlay(bool on) { }

	public override void Update() { }

	public void BuyButtonClicked(int index, int multiplier = 1) { }

	public void .ctor() { }

	private static void .cctor() { }

}

