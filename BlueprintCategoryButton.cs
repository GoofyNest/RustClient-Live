public class BlueprintCategoryButton : MonoBehaviour, IInventoryChanged, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 10983
{
	public TextMeshProUGUI amountLabel; 
	public ItemCategory Category; 
	public bool AlwaysShow; 
	public bool ShowItemCount; 
	public GameObject BackgroundHighlight; 
	public SoundDefinition clickSound; 
	public SoundDefinition hoverSound; 
	private bool needsRefresh; 
	private int CurrentAmount; 
	private bool Selected; 


	private void OnEnable() { }

	private void OnDisable() { }

	private void Update() { }

	public void OnInventoryChanged() { }

	private void UpdateValue() { }

	public void ValueChanged(bool b) { }

	public void OnPointerEnter(PointerEventData eventData) { }

	public void OnPointerExit(PointerEventData eventData) { }

	public void DoBounceAnim() { }

	public void .ctor() { }

}

