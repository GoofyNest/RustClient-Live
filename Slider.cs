public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 5007
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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


	public RectTransform get_fillRect() { }

	public void set_fillRect(RectTransform value) { }

	public RectTransform get_handleRect() { }

	public void set_handleRect(RectTransform value) { }

	public Slider.Direction get_direction() { }

	public void set_direction(Slider.Direction value) { }

	public float get_minValue() { }

	public void set_minValue(float value) { }

	public float get_maxValue() { }

	public void set_maxValue(float value) { }

	public bool get_wholeNumbers() { }

	public void set_wholeNumbers(bool value) { }

	public virtual float get_value() { }

	public virtual void set_value(float value) { }

	public virtual void SetValueWithoutNotify(float input) { }

	public float get_normalizedValue() { }

	public void set_normalizedValue(float value) { }

	public Slider.SliderEvent get_onValueChanged() { }

	public void set_onValueChanged(Slider.SliderEvent value) { }

	private float get_stepSize() { }

	protected void .ctor() { }

	public virtual void Rebuild(CanvasUpdate executing) { }

	public virtual void LayoutComplete() { }

	public virtual void GraphicUpdateComplete() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected virtual void Update() { }

	protected override void OnDidApplyAnimationProperties() { }

	private void UpdateCachedReferences() { }

	private float ClampValue(float input) { }

	protected virtual void Set(float input, bool sendCallback = True) { }

	protected override void OnRectTransformDimensionsChange() { }

	private Slider.Axis get_axis() { }

	private bool get_reverseValue() { }

	private void UpdateVisuals() { }

	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	private bool MayDrag(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	public override void OnMove(AxisEventData eventData) { }

	public override Selectable FindSelectableOnLeft() { }

	public override Selectable FindSelectableOnRight() { }

	public override Selectable FindSelectableOnUp() { }

	public override Selectable FindSelectableOnDown() { }

	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	public void SetDirection(Slider.Direction direction, bool includeRectLayouts) { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum Slider.Direction // TypeDefIndex: 5008
{	public int value__; // 0x0
	public const Slider.Direction LeftToRight = 0;
	public const Slider.Direction RightToLeft = 1;
	public const Slider.Direction BottomToTop = 2;
	public const Slider.Direction TopToBottom = 3;

}

public class Slider.SliderEvent : UnityEvent<float> // TypeDefIndex: 5009
{
	public void .ctor() { }

}

private enum Slider.Axis // TypeDefIndex: 5010
{	public int value__; // 0x0
	public const Slider.Axis Horizontal = 0;
	public const Slider.Axis Vertical = 1;

}

