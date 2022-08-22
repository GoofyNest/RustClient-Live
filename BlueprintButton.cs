public class BlueprintButton : MonoBehaviour, IClientComponent, IInventoryChanged, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 10982
{	public Image image; // 0x18
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


	public void Setup(ItemBlueprint bp, UIBlueprints parent) { }

	public void Awake() { }

	public void OnDestroy() { }

	private void Update() { }

	private void UpdateSelection() { }

	private void Refresh() { }

	public void OnInventoryChanged() { }

	public void OnPointerClick(PointerEventData eventData) { }

	public void OnToggleFavouriteClicked() { }

	public void OnPointerEnter(PointerEventData eventData) { }

	public void OnPointerExit(PointerEventData eventData) { }

	public void OnFavouriteHovered() { }

	public void OnFavouriteUnhovered() { }

	public void .ctor() { }

}

