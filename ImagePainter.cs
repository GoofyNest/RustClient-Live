public class ImagePainter : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IInitializePotentialDragHandler // TypeDefIndex: 10943
{	public ImagePainter.OnDrawingEvent onDrawing; // 0x18
	public MonoBehaviour redirectRightClick; // 0x20
	[TooltipAttribute] // RVA: 0x8CE10 Offset: 0x8C210 VA: 0x18008CE10
	public float spacingScale; // 0x28
	internal Brush brush; // 0x30
	internal ImagePainter.PointerState[] pointerState; // 0x38

	public RectTransform rectTransform { get; }


	public RectTransform get_rectTransform() { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnPointerUp(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	private void DrawAt(Vector2 position, PointerEventData.InputButton button) { }

	private void Start() { }

	public void UpdateBrush(Brush brush) { }

	public void .ctor() { }

}

public class ImagePainter.OnDrawingEvent : UnityEvent<Vector2, Brush> // TypeDefIndex: 10944
{
	public void .ctor() { }

}

internal class ImagePainter.PointerState // TypeDefIndex: 10945
{	public Vector2 lastPos; // 0x10
	public bool isDown; // 0x18


	public void .ctor() { }

}

