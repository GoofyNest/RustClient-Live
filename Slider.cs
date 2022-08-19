public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 5007
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform m_FillRect; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform m_HandleRect; // 0xF0
	[SpaceAttribute] // RVA: 0x7CB60 Offset: 0x7BF60 VA: 0x18007CB60
	[SerializeField] // RVA: 0x7CB60 Offset: 0x7BF60 VA: 0x18007CB60
	private Slider.Direction m_Direction; // 0xF8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_MinValue; // 0xFC
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_MaxValue; // 0x100
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_WholeNumbers; // 0x104
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_Value; // 0x108
	[SpaceAttribute] // RVA: 0x7CB60 Offset: 0x7BF60 VA: 0x18007CB60
	[SerializeField] // RVA: 0x7CB60 Offset: 0x7BF60 VA: 0x18007CB60
	private Slider.SliderEvent m_OnValueChanged; // 0x110
	private Image m_FillImage; // 0x118
	private Transform m_FillTransform; // 0x120
	private RectTransform m_FillContainerRect; // 0x128
	private Transform m_HandleTransform; // 0x130
	private RectTransform m_HandleContainerRect; // 0x138
	private Vector2 m_Offset; // 0x140
	private DrivenRectTransformTracker m_Tracker; // 0x148
	private bool m_DelayedUpdateVisuals; // 0x149

	// Properties
	public RectTransform fillRect { get; set; }
	public RectTransform handleRect { get; set; }
	public Slider.Direction direction { get; set; }
	public float minValue { get; set; }
	public float maxValue { get; set; }
	public bool wholeNumbers { get; set; }
	public virtual float value { get; set; }
	public float normalizedValue { get; set; }
	public Slider.SliderEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Slider.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x94E830 Offset: 0x94DC30 VA: 0x18094E830
	public RectTransform get_fillRect() { }

	// RVA: 0x17215A0 Offset: 0x17209A0 VA: 0x1817215A0
	public void set_fillRect(RectTransform value) { }

	// RVA: 0xC53210 Offset: 0xC52610 VA: 0x180C53210
	public RectTransform get_handleRect() { }

	// RVA: 0x1721610 Offset: 0x1720A10 VA: 0x181721610
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x1074CB0 Offset: 0x10740B0 VA: 0x181074CB0
	public Slider.Direction get_direction() { }

	// RVA: 0x1721540 Offset: 0x1720940 VA: 0x181721540
	public void set_direction(Slider.Direction value) { }

	// RVA: 0x11D02A0 Offset: 0x11CF6A0 VA: 0x1811D02A0
	public float get_minValue() { }

	// RVA: 0x1721700 Offset: 0x1720B00 VA: 0x181721700
	public void set_minValue(float value) { }

	// RVA: 0x7FEF50 Offset: 0x7FE350 VA: 0x1807FEF50
	public float get_maxValue() { }

	// RVA: 0x1721680 Offset: 0x1720A80 VA: 0x181721680
	public void set_maxValue(float value) { }

	// RVA: 0x1129B30 Offset: 0x1128F30 VA: 0x181129B30
	public bool get_wholeNumbers() { }

	// RVA: 0x1721850 Offset: 0x1720C50 VA: 0x181721850
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x17214C0 Offset: 0x17208C0 VA: 0x1817214C0 Slot: 46
	public virtual float get_value() { }

	// RVA: 0x1721830 Offset: 0x1720C30 VA: 0x181721830 Slot: 47
	public virtual void set_value(float value) { }

	// RVA: 0x1720780 Offset: 0x171FB80 VA: 0x181720780 Slot: 48
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x1721370 Offset: 0x1720770 VA: 0x181721370
	public float get_normalizedValue() { }

	// RVA: 0x1721780 Offset: 0x1720B80 VA: 0x181721780
	public void set_normalizedValue(float value) { }

	// RVA: 0x94E420 Offset: 0x94D820 VA: 0x18094E420
	public Slider.SliderEvent get_onValueChanged() { }

	// RVA: 0x94E870 Offset: 0x94DC70 VA: 0x18094E870
	public void set_onValueChanged(Slider.SliderEvent value) { }

	// RVA: 0x1721490 Offset: 0x1720890 VA: 0x181721490
	private float get_stepSize() { }

	// RVA: 0x1721280 Offset: 0x1720680 VA: 0x181721280
	protected void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 49
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 50
	public virtual void LayoutComplete() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 51
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1720070 Offset: 0x171F470 VA: 0x181720070 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x171FFC0 Offset: 0x171F3C0 VA: 0x18171FFC0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1721260 Offset: 0x1720660 VA: 0x181721260 Slot: 52
	protected virtual void Update() { }

	// RVA: 0x171FD70 Offset: 0x171F170 VA: 0x18171FD70 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1720850 Offset: 0x171FC50 VA: 0x181720850
	private void UpdateCachedReferences() { }

	// RVA: 0x171FBF0 Offset: 0x171EFF0 VA: 0x18171FBF0
	private float ClampValue(float input) { }

	// RVA: 0x17207A0 Offset: 0x171FBA0 VA: 0x1817207A0 Slot: 53
	protected virtual void Set(float input, bool sendCallback = True) { }

	// RVA: 0x17205B0 Offset: 0x171F9B0 VA: 0x1817205B0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1721360 Offset: 0x1720760 VA: 0x181721360
	private Slider.Axis get_axis() { }

	// RVA: 0x1721470 Offset: 0x1720870 VA: 0x181721470
	private bool get_reverseValue() { }

	// RVA: 0x1720F30 Offset: 0x1720330 VA: 0x181720F30
	private void UpdateVisuals() { }

	// RVA: 0x1720BE0 Offset: 0x171FFE0 VA: 0x181720BE0
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x171ADA0 Offset: 0x171A1A0 VA: 0x18171ADA0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1720370 Offset: 0x171F770 VA: 0x181720370 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x171FFF0 Offset: 0x171F3F0 VA: 0x18171FFF0 Slot: 54
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x17200C0 Offset: 0x171F4C0 VA: 0x1817200C0 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x171FCE0 Offset: 0x171F0E0 VA: 0x18171FCE0 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x171FD10 Offset: 0x171F110 VA: 0x18171FD10 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x171FD40 Offset: 0x171F140 VA: 0x18171FD40 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x171FCB0 Offset: 0x171F0B0 VA: 0x18171FCB0 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0xFC9D40 Offset: 0xFC9140 VA: 0x180FC9D40 Slot: 55
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x17205F0 Offset: 0x171F9F0 VA: 0x1817205F0
	public void SetDirection(Slider.Direction direction, bool includeRectLayouts) { }

	// RVA: 0xAB8650 Offset: 0xAB7A50 VA: 0x180AB8650 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum Slider.Direction // TypeDefIndex: 5008
{	// Fields
	public int value__; // 0x0
	public const Slider.Direction LeftToRight = 0;
	public const Slider.Direction RightToLeft = 1;
	public const Slider.Direction BottomToTop = 2;
	public const Slider.Direction TopToBottom = 3;

}

public class Slider.SliderEvent : UnityEvent<float> // TypeDefIndex: 5009
{	// Methods

	// RVA: 0x223EF60 Offset: 0x223E360 VA: 0x18223EF60
	public void .ctor() { }

}

private enum Slider.Axis // TypeDefIndex: 5010
{	// Fields
	public int value__; // 0x0
	public const Slider.Axis Horizontal = 0;
	public const Slider.Axis Vertical = 1;

}

