public class AddSellOrderManager : MonoBehaviour // TypeDefIndex: 10455
{
	public VirtualItemIcon sellItemIcon;
	public VirtualItemIcon currencyItemIcon;
	public GameObject itemSearchParent;
	public ItemSearchEntry itemSearchEntryPrefab;
	public InputField sellItemInput;
	public InputField sellItemAmount;
	public InputField currencyItemInput;
	public InputField currencyItemAmount;
	public VendingPanelAdmin adminPanel;


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

private sealed class AddSellOrderManager.<>c__DisplayClass10_0 // TypeDefIndex: 10456
{
	public AddSellOrderManager <>4__this;
	public string search;


	public void .ctor() { }

	internal bool <Search>

	internal float <Search>

}

