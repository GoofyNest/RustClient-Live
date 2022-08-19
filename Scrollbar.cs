public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 4998
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
	public RectTransform handleRect { get; set; }
	public Scrollbar.Direction direction { get; set; }
	public float value { get; set; }
	public float size { get; set; }
	public int numberOfSteps { get; set; }
	public Scrollbar.ScrollEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Scrollbar.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x94E830 Offset: 0x94DC30 VA: 0x18094E830
	public RectTransform get_handleRect() { }

	// RVA: 0x171C440 Offset: 0x171B840 VA: 0x18171C440
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x1074C80 Offset: 0x1074080 VA: 0x181074C80
	public Scrollbar.Direction get_direction() { }

	// RVA: 0x171C3E0 Offset: 0x171B7E0 VA: 0x18171C3E0
	public void set_direction(Scrollbar.Direction value) { }

	// RVA: 0x171C1D0 Offset: 0x171B5D0 VA: 0x18171C1D0
	protected void .ctor() { }

	// RVA: 0x171C330 Offset: 0x171B730 VA: 0x18171C330
	public float get_value() { }

	// RVA: 0x171C5B0 Offset: 0x171B9B0 VA: 0x18171C5B0
	public void set_value(float value) { }

	// RVA: 0x171B990 Offset: 0x171AD90 VA: 0x18171B990 Slot: 47
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x1126D60 Offset: 0x1126160 VA: 0x181126D60
	public float get_size() { }

	// RVA: 0x171C520 Offset: 0x171B920 VA: 0x18171C520
	public void set_size(float value) { }

	// RVA: 0x1074CC0 Offset: 0x10740C0 VA: 0x181074CC0
	public int get_numberOfSteps() { }

	// RVA: 0x171C4B0 Offset: 0x171B8B0 VA: 0x18171C4B0
	public void set_numberOfSteps(int value) { }

	// RVA: 0xA09500 Offset: 0xA08900 VA: 0x180A09500
	public Scrollbar.ScrollEvent get_onValueChanged() { }

	// RVA: 0xA09800 Offset: 0xA08C00 VA: 0x180A09800
	public void set_onValueChanged(Scrollbar.ScrollEvent value) { }

	// RVA: 0x171C300 Offset: 0x171B700 VA: 0x18171C300
	private float get_stepSize() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 48
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 49
	public virtual void LayoutComplete() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 50
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x171B1F0 Offset: 0x171A5F0 VA: 0x18171B1F0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x171B0F0 Offset: 0x171A4F0 VA: 0x18171B0F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x171C1B0 Offset: 0x171B5B0 VA: 0x18171C1B0 Slot: 51
	protected virtual void Update() { }

	// RVA: 0x171BAE0 Offset: 0x171AEE0 VA: 0x18171BAE0
	private void UpdateCachedReferences() { }

	// RVA: 0x171B9A0 Offset: 0x171ADA0 VA: 0x18171B9A0
	private void Set(float input, bool sendCallback = True) { }

	// RVA: 0x171B7C0 Offset: 0x171ABC0 VA: 0x18171B7C0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x171C2D0 Offset: 0x171B6D0 VA: 0x18171C2D0
	private Scrollbar.Axis get_axis() { }

	// RVA: 0x171C2E0 Offset: 0x171B6E0 VA: 0x18171C2E0
	private bool get_reverseValue() { }

	// RVA: 0x171BFC0 Offset: 0x171B3C0 VA: 0x18171BFC0
	private void UpdateVisuals() { }

	// RVA: 0x171BBF0 Offset: 0x171AFF0 VA: 0x18171BBF0
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x171ABC0 Offset: 0x1719FC0 VA: 0x18171ABC0
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x171ADA0 Offset: 0x171A1A0 VA: 0x18171ADA0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x171AE10 Offset: 0x171A210 VA: 0x18171AE10 Slot: 52
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x171B120 Offset: 0x171A520 VA: 0x18171B120 Slot: 53
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x171B630 Offset: 0x171AA30 VA: 0x18171B630 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x7A2E0 Offset: 0x796E0 VA: 0x18007A2E0
	// RVA: 0x171AB30 Offset: 0x1719F30 VA: 0x18171AB30
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	// RVA: 0x171B740 Offset: 0x171AB40 VA: 0x18171B740 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x171B300 Offset: 0x171A700 VA: 0x18171B300 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x171AD10 Offset: 0x171A110 VA: 0x18171AD10 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x171AD40 Offset: 0x171A140 VA: 0x18171AD40 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x171AD70 Offset: 0x171A170 VA: 0x18171AD70 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x171ACE0 Offset: 0x171A0E0 VA: 0x18171ACE0 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0xFC9D40 Offset: 0xFC9140 VA: 0x180FC9D40 Slot: 54
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x171B800 Offset: 0x171AC00 VA: 0x18171B800
	public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts) { }

	// RVA: 0xAB8650 Offset: 0xAB7A50 VA: 0x180AB8650 Slot: 43
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum Scrollbar.Direction // TypeDefIndex: 4999
{	// Fields
	public int value__; // 0x0
	public const Scrollbar.Direction LeftToRight = 0;
	public const Scrollbar.Direction RightToLeft = 1;
	public const Scrollbar.Direction BottomToTop = 2;
	public const Scrollbar.Direction TopToBottom = 3;

}

public class Scrollbar.ScrollEvent : UnityEvent<float> // TypeDefIndex: 5000
{	// Methods

	// RVA: 0x1715CF0 Offset: 0x17150F0 VA: 0x181715CF0
	public void .ctor() { }

}

private enum Scrollbar.Axis // TypeDefIndex: 5001
{	// Fields
	public int value__; // 0x0
	public const Scrollbar.Axis Horizontal = 0;
	public const Scrollbar.Axis Vertical = 1;

}

private sealed class Scrollbar.<ClickRepeat>d__57 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5002
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Scrollbar <>4__this; // 0x20
	public PointerEventData eventData; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1721AB0 Offset: 0x1720EB0 VA: 0x181721AB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1721CF0 Offset: 0x17210F0 VA: 0x181721CF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

