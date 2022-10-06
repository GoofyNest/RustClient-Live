public class ImagePainter : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IInitializePotentialDragHandler // TypeDefIndex: 12664
{
	public ImagePainter.OnDrawingEvent onDrawing; 
	public MonoBehaviour redirectRightClick; 
	[TooltipAttribute] 
	public float spacingScale; 
	internal Brush brush; 
	internal ImagePainter.PointerState[] pointerState; 

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

public class ImagePainter.OnDrawingEvent : UnityEvent<Vector2, Brush> // TypeDefIndex: 12665
{

	public void .ctor() { }

}

internal class ImagePainter.PointerState // TypeDefIndex: 12666
{
	public Vector2 lastPos; 
	public bool isDown; 


	public void .ctor() { }

}

