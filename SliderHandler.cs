internal struct SliderHandler // TypeDefIndex: 4060
{	// Fields
	private readonly Rect position; // 0x0
	private readonly float currentValue; // 0x10
	private readonly float size; // 0x14
	private readonly float start; // 0x18
	private readonly float end; // 0x1C
	private readonly GUIStyle slider; // 0x20
	private readonly GUIStyle thumb; // 0x28
	private readonly GUIStyle thumbExtent; // 0x30
	private readonly bool horiz; // 0x38
	private readonly int id; // 0x3C

	// Methods

	// RVA: 0x22AF00 Offset: 0x22A300 VA: 0x18022AF00
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x22ACE0 Offset: 0x22A0E0 VA: 0x18022ACE0
	public float Handle() { }

	// RVA: 0x22AD60 Offset: 0x22A160 VA: 0x18022AD60
	private float OnMouseDown() { }

	// RVA: 0x22AD70 Offset: 0x22A170 VA: 0x18022AD70
	private float OnMouseDrag() { }

	// RVA: 0x22AD80 Offset: 0x22A180 VA: 0x18022AD80
	private float OnMouseUp() { }

	// RVA: 0x22AD90 Offset: 0x22A190 VA: 0x18022AD90
	private float OnRepaint() { }

	// RVA: 0x22AC80 Offset: 0x22A080 VA: 0x18022AC80
	private EventType CurrentEventType() { }

	// RVA: 0x22ACD0 Offset: 0x22A0D0 VA: 0x18022ACD0
	private int CurrentScrollTroughSide() { }

	// RVA: 0x22AD10 Offset: 0x22A110 VA: 0x18022AD10
	private bool IsEmptySlider() { }

	// RVA: 0x22AE30 Offset: 0x22A230 VA: 0x18022AE30
	private bool SupportsPageMovements() { }

	// RVA: 0x22ADA0 Offset: 0x22A1A0 VA: 0x18022ADA0
	private float PageMovementValue() { }

	// RVA: 0x22ADB0 Offset: 0x22A1B0 VA: 0x18022ADB0
	private float PageUpMovementBound() { }

	// RVA: 0x22AC90 Offset: 0x22A090 VA: 0x18022AC90
	private Event CurrentEvent() { }

	// RVA: 0x22AEC0 Offset: 0x22A2C0 VA: 0x18022AEC0
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x22AC50 Offset: 0x22A050 VA: 0x18022AC50
	private float Clamp(float value) { }

	// RVA: 0x22AE60 Offset: 0x22A260 VA: 0x18022AE60
	private Rect ThumbSelectionRect() { }

	// RVA: 0x22ADD0 Offset: 0x22A1D0 VA: 0x18022ADD0
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x22ADC0 Offset: 0x22A1C0 VA: 0x18022ADC0
	private SliderState SliderState() { }

	// RVA: 0x22AE40 Offset: 0x22A240 VA: 0x18022AE40
	private Rect ThumbExtRect() { }

	// RVA: 0x22AE60 Offset: 0x22A260 VA: 0x18022AE60
	private Rect ThumbRect() { }

	// RVA: 0x22AEE0 Offset: 0x22A2E0 VA: 0x18022AEE0
	private Rect VerticalThumbRect() { }

	// RVA: 0x22ACF0 Offset: 0x22A0F0 VA: 0x18022ACF0
	private Rect HorizontalThumbRect() { }

	// RVA: 0x22AC60 Offset: 0x22A060 VA: 0x18022AC60
	private float ClampedCurrentValue() { }

	// RVA: 0x22AD50 Offset: 0x22A150 VA: 0x18022AD50
	private float MousePosition() { }

	// RVA: 0x22AED0 Offset: 0x22A2D0 VA: 0x18022AED0
	private float ValuesPerPixel() { }

	// RVA: 0x22AEB0 Offset: 0x22A2B0 VA: 0x18022AEB0
	private float ThumbSize() { }

	// RVA: 0x22AD30 Offset: 0x22A130 VA: 0x18022AD30
	private float MaxValue() { }

	// RVA: 0x22AD40 Offset: 0x22A140 VA: 0x18022AD40
	private float MinValue() { }

}

