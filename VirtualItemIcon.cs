public class VirtualItemIcon : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11066
{	// Fields
	public ItemDefinition itemDef; // 0x18
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

	// Methods

	// RVA: 0x7DC5E0 Offset: 0x7DB9E0 VA: 0x1807DC5E0
	public void SetVirtualItem(ItemDefinition info, int amount = 0, ulong skinId = 0, bool asBP = False, int dataInt = 0) { }

	// RVA: 0x7DC310 Offset: 0x7DB710 VA: 0x1807DC310
	public void SetToolTip(ItemDefinition info, int amount, bool asBP) { }

	// RVA: 0x7DC4E0 Offset: 0x7DB8E0 VA: 0x1807DC4E0
	public void SetTooltip(string itemName, int amount, bool asBP) { }

	// RVA: 0x7DCAF0 Offset: 0x7DBEF0 VA: 0x1807DCAF0
	public void UpdateAmount(int amount) { }

	// RVA: 0x7DC040 Offset: 0x7DB440 VA: 0x1807DC040
	public Sprite GetItemSkinSprite(ItemDefinition info, ulong skin) { }

	// RVA: 0x7DCDD0 Offset: 0x7DC1D0 VA: 0x1807DCDD0
	private void UpdateHoverText(int dataInt) { }

	// RVA: 0x7DCEF0 Offset: 0x7DC2F0 VA: 0x1807DCEF0
	public void UpdateIcon(ItemDefinition info, ulong skinId = 0) { }

	// RVA: 0x7DCBD0 Offset: 0x7DBFD0 VA: 0x1807DCBD0
	public void UpdateCondition(float itemMaxCondition, float itemConditionNormalized) { }

	// RVA: 0x7DBF70 Offset: 0x7DB370 VA: 0x1807DBF70
	public void DisableCondition() { }

	// RVA: 0x7DC1E0 Offset: 0x7DB5E0 VA: 0x1807DC1E0 Slot: 4
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x7DC290 Offset: 0x7DB690 VA: 0x1807DC290 Slot: 5
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private sealed class VirtualItemIcon.<>c__DisplayClass17_0 // TypeDefIndex: 11067
{	// Fields
	public ulong skin; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7CFE60 Offset: 0x7CF260 VA: 0x1807CFE60
	internal bool <GetItemSkinSprite>b__0(ItemSkinDirectory.Skin x) { }

}

