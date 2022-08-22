public class AddSellOrderManager : MonoBehaviour // TypeDefIndex: 8726
{	public VirtualItemIcon sellItemIcon; // 0x18
	public VirtualItemIcon currencyItemIcon; // 0x20
	public GameObject itemSearchParent; // 0x28
	public ItemSearchEntry itemSearchEntryPrefab; // 0x30
	public InputField sellItemInput; // 0x38
	public InputField sellItemAmount; // 0x40
	public InputField currencyItemInput; // 0x48
	public InputField currencyItemAmount; // 0x50
	public VendingPanelAdmin adminPanel; // 0x58


	public void ItemSelectionMade(ItemDefinition info, bool asBP) { }

	public void Search(string search) { }

	private bool IsValidSearchResult(string search, ItemDefinition target) { }

	private float ScoreSearchResult(string search, ItemDefinition target) { }

	public void OnSellSearchChanged() { }

	public void OnCurrencySearchChanged() { }

	public void OnSellSearchComplete() { }

	public void AddSellOrder() { }

	public void ResetSellOrderObjects() { }

	public void OnAmountTextChanged() { }

	public void ClampAmountValues() { }

	public int ClampedAmountValue(string amount, ItemDefinition itemDef, bool limitToStackable = True) { }

	public int GetIntAmount(string text) { }

	public void CurrencyPlusMinus(int delta) { }

	public void SellItemPlusMinus(int delta) { }

	public void .ctor() { }

}

private sealed class AddSellOrderManager.<>c__DisplayClass10_0 // TypeDefIndex: 8727
{	public AddSellOrderManager <>4__this; // 0x10
	public string search; // 0x18


	public void .ctor() { }

	internal bool <Search>b__0(ItemDefinition x) { }

	internal float <Search>b__1(ItemDefinition y) { }

}

