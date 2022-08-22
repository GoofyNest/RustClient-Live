public class VirtualItemIcon : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11066
{	public ItemDefinition itemDef; // 0x18
	public int itemAmount; // 0x20
	public bool asBlueprint; // 0x24
	public Image iconImage; // 0x28
	public Image bpUnderlay; // 0x30
	public Text amountText; // 0x38
	public Text hoverText; // 0x40
	public CanvasGroup iconContents; // 0x48
	public Tooltip ToolTip; // 0x50
	public CanvasGroup conditionObject; // 0x58
	public Image conditionFill; // 0x60
	public Image maxConditionFill; // 0x68
	public Image cornerIcon; // 0x70


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

private sealed class VirtualItemIcon.<>c__DisplayClass17_0 // TypeDefIndex: 11067
{	public ulong skin; // 0x10


	public void .ctor() { }

	internal bool <GetItemSkinSprite>b__0(ItemSkinDirectory.Skin x) { }

}

