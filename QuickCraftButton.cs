public class QuickCraftButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 11046
{	public Image icon; // 0x18
	public Image favourite; // 0x20
	public Tooltip tooltip; // 0x28
	public Text CraftCount; // 0x30
	public Image FavouriteIcon; // 0x38
	private ItemBlueprint bp; // 0x40
	private int skinId; // 0x48
	private int oldCount; // 0x4C
	private bool favourited; // 0x50
	private static int lastClickedItemID; // 0x0


	internal void Setup(ItemBlueprint item) { }

	private void RefreshFavouriteIcon() { }

	private void Update() { }

	private void QueueItem(int quantity) { }

	public void OnPointerClick(PointerEventData eventData) { }

	public void OnToggleFavouriteClicked() { }

	public void OnPointerEnter(PointerEventData eventData) { }

	public void OnPointerExit(PointerEventData eventData) { }

	public void OnFavouriteHovered() { }

	public void OnFavouriteUnhovered() { }

	public void .ctor() { }

	private static void .cctor() { }

}

