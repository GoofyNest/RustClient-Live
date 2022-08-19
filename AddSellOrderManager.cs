public class AddSellOrderManager : MonoBehaviour // TypeDefIndex: 8726
{	// Fields
	public VirtualItemIcon sellItemIcon; // 0x18
	public VirtualItemIcon currencyItemIcon; // 0x20
	public GameObject itemSearchParent; // 0x28
	public ItemSearchEntry itemSearchEntryPrefab; // 0x30
	public InputField sellItemInput; // 0x38
	public InputField sellItemAmount; // 0x40
	public InputField currencyItemInput; // 0x48
	public InputField currencyItemAmount; // 0x50
	public VendingPanelAdmin adminPanel; // 0x58

	// Methods

	// RVA: 0xA99640 Offset: 0xA98A40 VA: 0x180A99640
	public void ItemSelectionMade(ItemDefinition info, bool asBP) { }

	// RVA: 0xA99BD0 Offset: 0xA98FD0 VA: 0x180A99BD0
	public void Search(string search) { }

	// RVA: 0xA994A0 Offset: 0xA988A0 VA: 0x180A994A0
	private bool IsValidSearchResult(string search, ItemDefinition target) { }

	// RVA: 0xA99940 Offset: 0xA98D40 VA: 0x180A99940
	private float ScoreSearchResult(string search, ItemDefinition target) { }

	// RVA: 0xA99830 Offset: 0xA98C30 VA: 0x180A99830
	public void OnSellSearchChanged() { }

	// RVA: 0xA997A0 Offset: 0xA98BA0 VA: 0x180A997A0
	public void OnCurrencySearchChanged() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void OnSellSearchComplete() { }

	// RVA: 0xA98EE0 Offset: 0xA982E0 VA: 0x180A98EE0
	public void AddSellOrder() { }

	// RVA: 0xA998C0 Offset: 0xA98CC0 VA: 0x180A998C0
	public void ResetSellOrderObjects() { }

	// RVA: 0xA99790 Offset: 0xA98B90 VA: 0x180A99790
	public void OnAmountTextChanged() { }

	// RVA: 0xA99170 Offset: 0xA98570 VA: 0x180A99170
	public void ClampAmountValues() { }

	// RVA: 0xA99310 Offset: 0xA98710 VA: 0x180A99310
	public int ClampedAmountValue(string amount, ItemDefinition itemDef, bool limitToStackable = True) { }

	// RVA: 0xA99470 Offset: 0xA98870 VA: 0x180A99470
	public int GetIntAmount(string text) { }

	// RVA: 0xA993F0 Offset: 0xA987F0 VA: 0x180A993F0
	public void CurrencyPlusMinus(int delta) { }

	// RVA: 0xA99F60 Offset: 0xA99360 VA: 0x180A99F60
	public void SellItemPlusMinus(int delta) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private sealed class AddSellOrderManager.<>c__DisplayClass10_0 // TypeDefIndex: 8727
{	// Fields
	public AddSellOrderManager <>4__this; // 0x10
	public string search; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xAA6B10 Offset: 0xAA5F10 VA: 0x180AA6B10
	internal bool <Search>b__0(ItemDefinition x) { }

	// RVA: 0xAA6CC0 Offset: 0xAA60C0 VA: 0x180AA6CC0
	internal float <Search>b__1(ItemDefinition y) { }

}

