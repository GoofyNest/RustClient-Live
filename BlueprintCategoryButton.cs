public class BlueprintCategoryButton : MonoBehaviour, IInventoryChanged, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 10983
{	public TextMeshProUGUI amountLabel; // 0x18
	public ItemCategory Category; // 0x20
	public bool AlwaysShow; // 0x24
	public bool ShowItemCount; // 0x25
	public GameObject BackgroundHighlight; // 0x28
	public SoundDefinition clickSound; // 0x30
	public SoundDefinition hoverSound; // 0x38
	private bool needsRefresh; // 0x40
	private int CurrentAmount; // 0x44
	private bool Selected; // 0x48


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

