internal struct SliderHandler // TypeDefIndex: 4063
{
	private readonly Rect position; 
	private readonly float currentValue; 
	private readonly float size; 
	private readonly float start; 
	private readonly float end; 
	private readonly GUIStyle slider; 
	private readonly GUIStyle thumb; 
	private readonly GUIStyle thumbExtent; 
	private readonly bool horiz; 
	private readonly int id; 


	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	public float Handle() { }

	private float OnMouseDown() { }

	private float OnMouseDrag() { }

	private float OnMouseUp() { }

	private float OnRepaint() { }

	private EventType CurrentEventType() { }

	private int CurrentScrollTroughSide() { }

	private bool IsEmptySlider() { }

	private bool SupportsPageMovements() { }

	private float PageMovementValue() { }

	private float PageUpMovementBound() { }

	private Event CurrentEvent() { }

	private float ValueForCurrentMousePosition() { }

	private float Clamp(float value) { }

	private Rect ThumbSelectionRect() { }

	private void StartDraggingWithValue(float dragStartValue) { }

	private SliderState SliderState() { }

	private Rect ThumbExtRect() { }

	private Rect ThumbRect() { }

	private Rect VerticalThumbRect() { }

	private Rect HorizontalThumbRect() { }

	private float ClampedCurrentValue() { }

	private float MousePosition() { }

	private float ValuesPerPixel() { }

	private float ThumbSize() { }

	private float MaxValue() { }

	private float MinValue() { }

}

