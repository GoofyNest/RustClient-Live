public class CraftingQueueIcon : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 10991
{	// Fields
	public CanvasGroup canvasGroup; // 0x18
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

	// Properties
	public string timeLeftString { get; }

	// Methods

	// RVA: 0x51BFD0 Offset: 0x51B3D0 VA: 0x18051BFD0
	private void Awake() { }

	// RVA: 0x51C8F0 Offset: 0x51BCF0 VA: 0x18051C8F0
	private void Update() { }

	// RVA: 0x51C980 Offset: 0x51BD80 VA: 0x18051C980
	public string get_timeLeftString() { }

	// RVA: 0x51C850 Offset: 0x51BC50 VA: 0x18051C850
	internal void OnTaskStart(float endTime) { }

	// RVA: 0x51C890 Offset: 0x51BC90 VA: 0x18051C890
	internal void ResetEndTime() { }

	// RVA: 0x51C240 Offset: 0x51B640 VA: 0x18051C240
	internal void Finished(bool success, int amountleft) { }

	// RVA: 0x51C360 Offset: 0x51B760 VA: 0x18051C360
	internal void Init(int taskid, int itemid, int amount, int skinid, ScrollRect scrollRect) { }

	// RVA: 0x51C020 Offset: 0x51B420 VA: 0x18051C020
	private void Cancel() { }

	// RVA: 0x51C130 Offset: 0x51B530 VA: 0x18051C130
	private void FastTrack() { }

	// RVA: 0x51C4D0 Offset: 0x51B8D0 VA: 0x18051C4D0
	public void MoveIconToFront() { }

	// RVA: 0x51C5B0 Offset: 0x51B9B0 VA: 0x18051C5B0 Slot: 8
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x51C5E0 Offset: 0x51B9E0 VA: 0x18051C5E0 Slot: 9
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x51C610 Offset: 0x51BA10 VA: 0x18051C610 Slot: 4
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x51C550 Offset: 0x51B950 VA: 0x18051C550 Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x51C520 Offset: 0x51B920 VA: 0x18051C520 Slot: 6
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x51C580 Offset: 0x51B980 VA: 0x18051C580 Slot: 7
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

