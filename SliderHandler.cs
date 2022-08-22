internal struct SliderHandler // TypeDefIndex: 4060
{	private readonly Rect position; // 0x0
	private readonly float currentValue; // 0x10
	private readonly float size; // 0x14
	private readonly float start; // 0x18
	private readonly float end; // 0x1C
	private readonly GUIStyle slider; // 0x20
	private readonly GUIStyle thumb; // 0x28
	private readonly GUIStyle thumbExtent; // 0x30
	private readonly bool horiz; // 0x38
	private readonly int id; // 0x3C


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

