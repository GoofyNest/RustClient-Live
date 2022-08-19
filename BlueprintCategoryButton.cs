public class BlueprintCategoryButton : MonoBehaviour, IInventoryChanged, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 10983
{	// Fields
	public TextMeshProUGUI amountLabel; // 0x18
	public ItemCategory Category; // 0x20
	public bool AlwaysShow; // 0x24
	public bool ShowItemCount; // 0x25
	public GameObject BackgroundHighlight; // 0x28
	public SoundDefinition clickSound; // 0x30
	public SoundDefinition hoverSound; // 0x38
	private bool needsRefresh; // 0x40
	private int CurrentAmount; // 0x44
	private bool Selected; // 0x48

	// Methods

	// RVA: 0x52E4E0 Offset: 0x52D8E0 VA: 0x18052E4E0
	private void OnEnable() { }

	// RVA: 0x52E430 Offset: 0x52D830 VA: 0x18052E430
	private void OnDisable() { }

	// RVA: 0x52E8D0 Offset: 0x52DCD0 VA: 0x18052E8D0
	private void Update() { }

	// RVA: 0x52E560 Offset: 0x52D960 VA: 0x18052E560 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0x52E7D0 Offset: 0x52DBD0 VA: 0x18052E7D0
	private void UpdateValue() { }

	// RVA: 0x52EA00 Offset: 0x52DE00 VA: 0x18052EA00
	public void ValueChanged(bool b) { }

	// RVA: 0x52E570 Offset: 0x52D970 VA: 0x18052E570 Slot: 5
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x52E750 Offset: 0x52DB50 VA: 0x18052E750 Slot: 6
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x52E300 Offset: 0x52D700 VA: 0x18052E300
	public void DoBounceAnim() { }

	// RVA: 0x52ED90 Offset: 0x52E190 VA: 0x18052ED90
	public void .ctor() { }

}

