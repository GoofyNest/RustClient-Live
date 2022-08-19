public class BlueprintButton : MonoBehaviour, IClientComponent, IInventoryChanged, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 10982
{	// Fields
	public Image image; // 0x18
	public Image imageFavourite; // 0x20
	public Button button; // 0x28
	public CanvasGroup group; // 0x30
	public GameObject newNotification; // 0x38
	public GameObject lockedOverlay; // 0x40
	public Tooltip Tip; // 0x48
	public Image FavouriteIcon; // 0x50
	internal bool needsRefresh; // 0x58
	internal ItemBlueprint blueprint; // 0x60
	private UIBlueprints parentBlueprints; // 0x68
	private bool favourited; // 0x70
	private bool hovered; // 0x71

	// Methods

	// RVA: 0x52E090 Offset: 0x52D490 VA: 0x18052E090
	public void Setup(ItemBlueprint bp, UIBlueprints parent) { }

	// RVA: 0x52D4C0 Offset: 0x52C8C0 VA: 0x18052D4C0
	public void Awake() { }

	// RVA: 0x52D540 Offset: 0x52C940 VA: 0x18052D540
	public void OnDestroy() { }

	// RVA: 0x52E280 Offset: 0x52D680 VA: 0x18052E280
	private void Update() { }

	// RVA: 0x52E250 Offset: 0x52D650 VA: 0x18052E250
	private void UpdateSelection() { }

	// RVA: 0x52D890 Offset: 0x52CC90 VA: 0x18052D890
	private void Refresh() { }

	// RVA: 0x52D6F0 Offset: 0x52CAF0 VA: 0x18052D6F0 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0x52D700 Offset: 0x52CB00 VA: 0x18052D700 Slot: 5
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x52D810 Offset: 0x52CC10 VA: 0x18052D810
	public void OnToggleFavouriteClicked() { }

	// RVA: 0x52D7B0 Offset: 0x52CBB0 VA: 0x18052D7B0 Slot: 6
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x52D7E0 Offset: 0x52CBE0 VA: 0x18052D7E0 Slot: 7
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x52D5F0 Offset: 0x52C9F0 VA: 0x18052D5F0
	public void OnFavouriteHovered() { }

	// RVA: 0x52D670 Offset: 0x52CA70 VA: 0x18052D670
	public void OnFavouriteUnhovered() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

