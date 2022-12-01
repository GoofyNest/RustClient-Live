public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 5013
{
	[SerializeField]
	private RectTransform m_FillRect;
	[SerializeField]
	private RectTransform m_HandleRect;
	[SpaceAttribute]
	[SerializeField]
	private Slider.Direction m_Direction;
	[SerializeField]
	private float m_MinValue;
	[SerializeField]
	private float m_MaxValue;
	[SerializeField]
	private bool m_WholeNumbers;
	[SerializeField]
	protected float m_Value;
	[SpaceAttribute]
	[SerializeField]
	private Slider.SliderEvent m_OnValueChanged;
	private Image m_FillImage;
	private Transform m_FillTransform;
	private RectTransform m_FillContainerRect;
	private Transform m_HandleTransform;
	private RectTransform m_HandleContainerRect;
	private Vector2 m_Offset;
	private DrivenRectTransformTracker m_Tracker;
	private bool m_DelayedUpdateVisuals;

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

public enum Slider.Direction // TypeDefIndex: 5014
{
	public int value__;
	public const Slider.Direction LeftToRight = 0;
	public const Slider.Direction RightToLeft = 1;
	public const Slider.Direction BottomToTop = 2;
	public const Slider.Direction TopToBottom = 3;

}

public class Slider.SliderEvent : UnityEvent<float> // TypeDefIndex: 5015
{

	public void .ctor() { }

}

private enum Slider.Axis // TypeDefIndex: 5016
{
	public int value__;
	public const Slider.Axis Horizontal = 0;
	public const Slider.Axis Vertical = 1;

}

