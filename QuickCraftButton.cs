public class QuickCraftButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 11046
{
	public Image icon; 
	public Image favourite; 
	public Tooltip tooltip; 
	public Text CraftCount; 
	public Image FavouriteIcon; 
	private ItemBlueprint bp; 
	private int skinId; 
	private int oldCount; 
	private bool favourited; 
	private static int lastClickedItemID; 


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

