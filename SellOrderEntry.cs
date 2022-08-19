public class SellOrderEntry : MonoBehaviour, IInventoryChanged // TypeDefIndex: 8734
{	// Fields
	public VirtualItemIcon MerchandiseIcon; // 0x18
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

	// Methods

	// RVA: 0x5A45E0 Offset: 0x5A39E0 VA: 0x1805A45E0
	public void OnEnable() { }

	// RVA: 0x5A44E0 Offset: 0x5A38E0 VA: 0x1805A44E0
	public void OnDisable() { }

	// RVA: 0x5A4780 Offset: 0x5A3B80 VA: 0x1805A4780
	public void Setup(VendingMachine.SellOrder so, int newIndex, IVendingMachineInterface panel, int minMultiplier = 1) { }

	// RVA: 0x5A46B0 Offset: 0x5A3AB0 VA: 0x1805A46B0 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0x5A5060 Offset: 0x5A4460 VA: 0x1805A5060
	public void Update() { }

	// RVA: 0x5A3C90 Offset: 0x5A3090 VA: 0x1805A3C90
	public void AmountTextChanged() { }

	// RVA: 0x5A46C0 Offset: 0x5A3AC0 VA: 0x1805A46C0
	public void SetAmount(int newAmount) { }

	// RVA: 0x5A42D0 Offset: 0x5A36D0 VA: 0x1805A42D0
	public int GetDesiredTransactionCount() { }

	// RVA: 0x5A3F70 Offset: 0x5A3370 VA: 0x1805A3F70
	public int CurrencyAvailable() { }

	// RVA: 0x5A44B0 Offset: 0x5A38B0 VA: 0x1805A44B0
	public int MaxTransactionsAffordable() { }

	// RVA: 0x5A44D0 Offset: 0x5A38D0 VA: 0x1805A44D0
	public int MaxTransactionsAvailable() { }

	// RVA: 0x5A4370 Offset: 0x5A3770 VA: 0x1805A4370
	public int GetMaxTransactionCount() { }

	// RVA: 0x5A4950 Offset: 0x5A3D50 VA: 0x1805A4950
	public void UpdateIcons() { }

	// RVA: 0x5A4E60 Offset: 0x5A4260 VA: 0x1805A4E60
	public void UpdateNotifications() { }

	// RVA: 0x5A3F30 Offset: 0x5A3330 VA: 0x1805A3F30
	public bool CanAfford() { }

	// RVA: 0x5A3E50 Offset: 0x5A3250 VA: 0x1805A3E50
	public void BuyClick() { }

	// RVA: 0x5A50A0 Offset: 0x5A44A0 VA: 0x1805A50A0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5A4910 Offset: 0x5A3D10 VA: 0x1805A4910
	private bool <CurrencyAvailable>b__30_0(Item x) { }

}

private sealed class SellOrderEntry.<>c // TypeDefIndex: 8735
{	// Fields
	public static readonly SellOrderEntry.<>c <>9; // 0x0
	public static Func<Item, bool> <>9__30_1; // 0x8
	public static Func<Item, int> <>9__30_2; // 0x10

	// Methods

	// RVA: 0x5BE4A0 Offset: 0x5BD8A0 VA: 0x1805BE4A0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5BDC80 Offset: 0x5BD080 VA: 0x1805BDC80
	internal bool <CurrencyAvailable>b__30_1(Item x) { }

	// RVA: 0x588420 Offset: 0x587820 VA: 0x180588420
	internal int <CurrencyAvailable>b__30_2(Item x) { }

}

