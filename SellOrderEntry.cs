public class SellOrderEntry : MonoBehaviour, IInventoryChanged // TypeDefIndex: 8734
{	public VirtualItemIcon MerchandiseIcon; // 0x18
	public VirtualItemIcon CurrencyIcon; // 0x20
	private ItemDefinition merchandiseInfo; // 0x28
	private ItemDefinition currencyInfo; // 0x30
	public GameObject buyButton; // 0x38
	public GameObject cantaffordNotification; // 0x40
	public GameObject outOfStockNotification; // 0x48
	private IVendingMachineInterface vendingPanel; // 0x50
	public UIIntegerEntry intEntry; // 0x58
	public Action<SellOrderEntry, int> onAmountChanged; // 0x60
	public VendingMachine.SellOrder sellOrder; // 0x68
	private bool dirty; // 0x70
	private int minMultiplier; // 0x74
	private bool merchIsBP; // 0x78
	private bool currencyIsBP; // 0x79
	private int merchandiseSellSize; // 0x7C
	private int currencyAmountPerItem; // 0x80
	private int index; // 0x84
	private int numInStock; // 0x88
	private float itemCondition; // 0x8C
	private float itemConditionMax; // 0x90
	private int itemInstanceInt; // 0x94


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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <CurrencyAvailable>b__30_0(Item x) { }

}

private sealed class SellOrderEntry.<>c // TypeDefIndex: 8735
{	public static readonly SellOrderEntry.<>c <>9; // 0x0
	public static Func<Item, bool> <>9__30_1; // 0x8
	public static Func<Item, int> <>9__30_2; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <CurrencyAvailable>b__30_1(Item x) { }

	internal int <CurrencyAvailable>b__30_2(Item x) { }

}

