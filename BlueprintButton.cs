public class BlueprintButton : MonoBehaviour, IClientComponent, IInventoryChanged, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 12703
{
	public Image image; 
	public Image imageFavourite; 
	public Button button; 
	public CanvasGroup group; 
	public GameObject newNotification; 
	public GameObject lockedOverlay; 
	public Tooltip Tip; 
	public Image FavouriteIcon; 
	internal bool needsRefresh; 
	internal ItemBlueprint blueprint; 
	private UIBlueprints parentBlueprints; 
	private bool favourited; 
	private bool hovered; 


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

