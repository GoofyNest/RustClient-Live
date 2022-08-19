public class ImagePainter : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IInitializePotentialDragHandler // TypeDefIndex: 10943
{	// Fields
	public ImagePainter.OnDrawingEvent onDrawing; // 0x18
	public MonoBehaviour redirectRightClick; // 0x20
	[TooltipAttribute] // RVA: 0x8CE10 Offset: 0x8C210 VA: 0x18008CE10
	public float spacingScale; // 0x28
	internal Brush brush; // 0x30
	internal ImagePainter.PointerState[] pointerState; // 0x38

	// Properties
	public RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x80A140 Offset: 0x809540 VA: 0x18080A140
	public RectTransform get_rectTransform() { }

	// RVA: 0x809D70 Offset: 0x809170 VA: 0x180809D70 Slot: 10
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x809ED0 Offset: 0x8092D0 VA: 0x180809ED0 Slot: 11
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x809AB0 Offset: 0x808EB0 VA: 0x180809AB0 Slot: 12
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x809A10 Offset: 0x808E10 VA: 0x180809A10 Slot: 13
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x809C30 Offset: 0x809030 VA: 0x180809C30 Slot: 14
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x809CD0 Offset: 0x8090D0 VA: 0x180809CD0 Slot: 15
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x809720 Offset: 0x808B20 VA: 0x180809720
	private void DrawAt(Vector2 position, PointerEventData.InputButton button) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void Start() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void UpdateBrush(Brush brush) { }

	// RVA: 0x809F20 Offset: 0x809320 VA: 0x180809F20
	public void .ctor() { }

}

public class ImagePainter.OnDrawingEvent : UnityEvent<Vector2, Brush> // TypeDefIndex: 10944
{	// Methods

	// RVA: 0x81DF10 Offset: 0x81D310 VA: 0x18081DF10
	public void .ctor() { }

}

internal class ImagePainter.PointerState // TypeDefIndex: 10945
{	// Fields
	public Vector2 lastPos; // 0x10
	public bool isDown; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

