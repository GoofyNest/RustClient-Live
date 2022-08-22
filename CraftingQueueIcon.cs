public class CraftingQueueIcon : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 10991
{	public CanvasGroup canvasGroup; // 0x18
	public Image icon; // 0x20
	public Image iconCancel; // 0x28
	public GameObject timeLeft; // 0x30
	public GameObject craftingCount; // 0x38
	public int taskid; // 0x40
	public float endTime; // 0x44
	public ItemDefinition item; // 0x48
	public int amount; // 0x50
	private ScrollRect scrollRect; // 0x58
	private bool pointerOverButton; // 0x60

	public string timeLeftString { get; }


	private void Awake() { }

	private void Update() { }

	public string get_timeLeftString() { }

	internal void OnTaskStart(float endTime) { }

	internal void ResetEndTime() { }

	internal void Finished(bool success, int amountleft) { }

	internal void Init(int taskid, int itemid, int amount, int skinid, ScrollRect scrollRect) { }

	private void Cancel() { }

	private void FastTrack() { }

	public void MoveIconToFront() { }

	public void OnPointerEnter(PointerEventData eventData) { }

	public void OnPointerExit(PointerEventData eventData) { }

	public void OnPointerUp(PointerEventData eventData) { }

	public void OnDrag(PointerEventData eventData) { }

	public void OnBeginDrag(PointerEventData eventData) { }

	public void OnEndDrag(PointerEventData eventData) { }

	public void .ctor() { }

}

