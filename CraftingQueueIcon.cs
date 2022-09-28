public class CraftingQueueIcon : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 12671
{
	public CanvasGroup canvasGroup; 
	public Image icon; 
	public Image iconCancel; 
	public GameObject timeLeft; 
	public GameObject craftingCount; 
	public int taskid; 
	public float endTime; 
	public ItemDefinition item; 
	public int amount; 
	private ScrollRect scrollRect; 
	private bool pointerOverButton; 

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

