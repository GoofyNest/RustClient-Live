public class LootPanelVendingMachine : LootPanel, IVendingMachineInterface // TypeDefIndex: 10461
{
	public GameObjectRef sellOrderPrefab;
	public GameObject sellOrderContainer;
	public GameObject busyOverlayPrefab;
	private GameObject busyOverlayInstance;
	public static LootPanelVendingMachine Instance;


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

