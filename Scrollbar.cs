public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 4998
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform m_HandleRect; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Scrollbar.Direction m_Direction; // 0xF0
	[RangeAttribute] // RVA: 0x799F0 Offset: 0x78DF0 VA: 0x1800799F0
	[SerializeField] // RVA: 0x799F0 Offset: 0x78DF0 VA: 0x1800799F0
	private float m_Value; // 0xF4
	[RangeAttribute] // RVA: 0x799F0 Offset: 0x78DF0 VA: 0x1800799F0
	[SerializeField] // RVA: 0x799F0 Offset: 0x78DF0 VA: 0x1800799F0
	private float m_Size; // 0xF8
	[RangeAttribute] // RVA: 0x79EF0 Offset: 0x792F0 VA: 0x180079EF0
	[SerializeField] // RVA: 0x79EF0 Offset: 0x792F0 VA: 0x180079EF0
	private int m_NumberOfSteps; // 0xFC
	[SpaceAttribute] // RVA: 0x7A180 Offset: 0x79580 VA: 0x18007A180
	[SerializeField] // RVA: 0x7A180 Offset: 0x79580 VA: 0x18007A180
	private Scrollbar.ScrollEvent m_OnValueChanged; // 0x100
	private RectTransform m_ContainerRect; // 0x108
	private Vector2 m_Offset; // 0x110
	private DrivenRectTransformTracker m_Tracker; // 0x118
	private Coroutine m_PointerDownRepeat; // 0x120
	private bool isPointerDownAndNotDragging; // 0x128
	private bool m_DelayedUpdateVisuals; // 0x129

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

	[IteratorStateMachineAttribute] // RVA: 0x7A2E0 Offset: 0x796E0 VA: 0x18007A2E0
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

public enum Scrollbar.Direction // TypeDefIndex: 4999
{	public int value__; // 0x0
	public const Scrollbar.Direction LeftToRight = 0;
	public const Scrollbar.Direction RightToLeft = 1;
	public const Scrollbar.Direction BottomToTop = 2;
	public const Scrollbar.Direction TopToBottom = 3;

}

public class Scrollbar.ScrollEvent : UnityEvent<float> // TypeDefIndex: 5000
{
	public void .ctor() { }

}

private enum Scrollbar.Axis // TypeDefIndex: 5001
{	public int value__; // 0x0
	public const Scrollbar.Axis Horizontal = 0;
	public const Scrollbar.Axis Vertical = 1;

}

private sealed class Scrollbar.<ClickRepeat>d__57 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5002
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Scrollbar <>4__this; // 0x20
	public PointerEventData eventData; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

