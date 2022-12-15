public class SellOrderEntry : MonoBehaviour, IInventoryChanged // TypeDefIndex: 10463
{
	public VirtualItemIcon MerchandiseIcon;
	public VirtualItemIcon CurrencyIcon;
	private ItemDefinition merchandiseInfo;
	private ItemDefinition currencyInfo;
	public GameObject buyButton;
	public GameObject cantaffordNotification;
	public GameObject outOfStockNotification;
	private IVendingMachineInterface vendingPanel;
	public UIIntegerEntry intEntry;
	public Action<SellOrderEntry, int> onAmountChanged;
	public VendingMachine.SellOrder sellOrder;
	private bool dirty;
	private int minMultiplier;
	private bool merchIsBP;
	private bool currencyIsBP;
	private int merchandiseSellSize;
	private int currencyAmountPerItem;
	private int index;
	private int numInStock;
	private float itemCondition;
	private float itemConditionMax;
	private int itemInstanceInt;


	public void OnEnable() { }

	public void OnDisable() { }

	public void Setup(VendingMachine.SellOrder so, int newIndex, IVendingMachineInterface panel, int minMultiplier = 1) { }

	public void OnInventoryChanged() { }

	public void Update() { }

	public void AmountTextChanged() { }

	public void SetAmount(int newAmount) { }

	public int GetDesiredTransactionCount() { }

	public int CurrencyAvailable() { }

	public int MaxTransactionsAffordable() { }

	public int MaxTransactionsAvailable() { }

	public int GetMaxTransactionCount() { }

	public void UpdateIcons() { }

	public void UpdateNotifications() { }

	public bool CanAfford() { }

	public void BuyClick() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute]
	private bool <CurrencyAvailable>

}

private sealed class SellOrderEntry.<>c // TypeDefIndex: 10464
{
	public static readonly SellOrderEntry.<>c <>9;
	public static Func<Item, bool> <>9__30_1;
	public static Func<Item, int> <>9__30_2;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <CurrencyAvailable>

	internal int <CurrencyAvailable>

}

