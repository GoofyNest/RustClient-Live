public class VirtualItemIcon : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 12857
{
	public ItemDefinition itemDef;
	public int itemAmount;
	public bool asBlueprint;
	public Image iconImage;
	public Image bpUnderlay;
	public Text amountText;
	public Text hoverText;
	public CanvasGroup iconContents;
	public Tooltip ToolTip;
	public CanvasGroup conditionObject;
	public Image conditionFill;
	public Image maxConditionFill;
	public Image cornerIcon;


	public void SetVirtualItem(ItemDefinition info, int amount = 0, ulong skinId = 0, bool asBP = False, int dataInt = 0) { }

	public void SetToolTip(ItemDefinition info, int amount, bool asBP) { }

	public void SetTooltip(string itemName, int amount, bool asBP) { }

	public void UpdateAmount(int amount) { }

	public Sprite GetItemSkinSprite(ItemDefinition info, ulong skin) { }

	private void UpdateHoverText(int dataInt) { }

	public void UpdateIcon(ItemDefinition info, ulong skinId = 0) { }

	public void UpdateCondition(float itemMaxCondition, float itemConditionNormalized) { }

	public void DisableCondition() { }

	public void OnPointerEnter(PointerEventData eventData) { }

	public void OnPointerExit(PointerEventData eventData) { }

	public void .ctor() { }

}

private sealed class VirtualItemIcon.<>c__DisplayClass17_0 // TypeDefIndex: 12858
{
	public ulong skin;


	public void .ctor() { }

	internal bool <GetItemSkinSprite>

}

