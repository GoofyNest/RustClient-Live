public class QuickCraftButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 11046
{	// Fields
	public Image icon; // 0x18
	public Image favourite; // 0x20
	public Tooltip tooltip; // 0x28
	public Text CraftCount; // 0x30
	public Image FavouriteIcon; // 0x38
	private ItemBlueprint bp; // 0x40
	private int skinId; // 0x48
	private int oldCount; // 0x4C
	private bool favourited; // 0x50
	private static int lastClickedItemID; // 0x0

	// Methods

	// RVA: 0x69B380 Offset: 0x69A780 VA: 0x18069B380
	internal void Setup(ItemBlueprint item) { }

	// RVA: 0x69B2B0 Offset: 0x69A6B0 VA: 0x18069B2B0
	private void RefreshFavouriteIcon() { }

	// RVA: 0x69B560 Offset: 0x69A960 VA: 0x18069B560
	private void Update() { }

	// RVA: 0x69B010 Offset: 0x69A410 VA: 0x18069B010
	private void QueueItem(int quantity) { }

	// RVA: 0x69ABD0 Offset: 0x699FD0 VA: 0x18069ABD0 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x69AF90 Offset: 0x69A390 VA: 0x18069AF90
	public void OnToggleFavouriteClicked() { }

	// RVA: 0x69AF30 Offset: 0x69A330 VA: 0x18069AF30 Slot: 5
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x69AF60 Offset: 0x69A360 VA: 0x18069AF60 Slot: 6
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x69A9D0 Offset: 0x699DD0 VA: 0x18069A9D0
	public void OnFavouriteHovered() { }

	// RVA: 0x69AB50 Offset: 0x699F50 VA: 0x18069AB50
	public void OnFavouriteUnhovered() { }

	// RVA: 0x69B6A0 Offset: 0x69AAA0 VA: 0x18069B6A0
	public void .ctor() { }

	// RVA: 0x69B660 Offset: 0x69AA60 VA: 0x18069B660
	private static void .cctor() { }

}

