public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 5004
{
	[SerializeField] 
	private RectTransform m_HandleRect; 
	[SerializeField] 
	private Scrollbar.Direction m_Direction; 
	[RangeAttribute] 
	[SerializeField] 
	private float m_Value; 
	[RangeAttribute] 
	[SerializeField] 
	private float m_Size; 
	[RangeAttribute] 
	[SerializeField] 
	private int m_NumberOfSteps; 
	[SpaceAttribute] 
	[SerializeField] 
	private Scrollbar.ScrollEvent m_OnValueChanged; 
	private RectTransform m_ContainerRect; 
	private Vector2 m_Offset; 
	private DrivenRectTransformTracker m_Tracker; 
	private Coroutine m_PointerDownRepeat; 
	private bool isPointerDownAndNotDragging; 
	private bool m_DelayedUpdateVisuals; 

	public RectTransform handleRect { get; set; }
	public Scrollbar.Direction direction { get; set; }
	public float value { get; set; }
	public float size { get; set; }
	public int numberOfSteps { get; set; }
	public Scrollbar.ScrollEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Scrollbar.Axis axis { get; }
	private bool reverseValue { get; }


	public RectTransform get_handleRect() { }

	public void set_handleRect(RectTransform value) { }

	public Scrollbar.Direction get_direction() { }

	public void set_direction(Scrollbar.Direction value) { }

	protected void .ctor() { }

	public float get_value() { }

	public void set_value(float value) { }

	public virtual void SetValueWithoutNotify(float input) { }

	public float get_size() { }

	public void set_size(float value) { }

	public int get_numberOfSteps() { }

	public void set_numberOfSteps(int value) { }

	public Scrollbar.ScrollEvent get_onValueChanged() { }

	public void set_onValueChanged(Scrollbar.ScrollEvent value) { }

	private float get_stepSize() { }

	public virtual void Rebuild(CanvasUpdate executing) { }

	public virtual void LayoutComplete() { }

	public virtual void GraphicUpdateComplete() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected virtual void Update() { }

	private void UpdateCachedReferences() { }

	private void Set(float input, bool sendCallback = True) { }

	protected override void OnRectTransformDimensionsChange() { }

	private Scrollbar.Axis get_axis() { }

	private bool get_reverseValue() { }

	private void UpdateVisuals() { }

	private void UpdateDrag(PointerEventData eventData) { }

	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	private bool MayDrag(PointerEventData eventData) { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] 
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public override void OnMove(AxisEventData eventData) { }

	public override Selectable FindSelectableOnLeft() { }

	public override Selectable FindSelectableOnRight() { }

	public override Selectable FindSelectableOnUp() { }

	public override Selectable FindSelectableOnDown() { }

	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts) { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum Scrollbar.Direction // TypeDefIndex: 5005
{
	public int value__; 
	public const Scrollbar.Direction LeftToRight = 0;
	public const Scrollbar.Direction RightToLeft = 1;
	public const Scrollbar.Direction BottomToTop = 2;
	public const Scrollbar.Direction TopToBottom = 3;

}

public class Scrollbar.ScrollEvent : UnityEvent<float> // TypeDefIndex: 5006
{

	public void .ctor() { }

}

private enum Scrollbar.Axis // TypeDefIndex: 5007
{
	public int value__; 
	public const Scrollbar.Axis Horizontal = 0;
	public const Scrollbar.Axis Vertical = 1;

}

private sealed class Scrollbar.<ClickRepeat>d__57 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5008
{
	private int <>1__state; 
	private object <>2__current; 
	public Scrollbar <>4__this; 
	public PointerEventData eventData; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

