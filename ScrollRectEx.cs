public class ScrollRectEx : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutGroup, ILayoutController // TypeDefIndex: 11707
{	// Fields
	public PointerEventData.InputButton scrollButton; // 0x18
	public PointerEventData.InputButton altScrollButton; // 0x1C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform m_Content; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_Horizontal; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_Vertical; // 0x29
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRectEx.MovementType m_MovementType; // 0x2C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_Elasticity; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_Inertia; // 0x34
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_DecelerationRate; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_ScrollSensitivity; // 0x3C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform m_Viewport; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Scrollbar m_HorizontalScrollbar; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Scrollbar m_VerticalScrollbar; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRectEx.ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRectEx.ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x5C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_HorizontalScrollbarSpacing; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_VerticalScrollbarSpacing; // 0x64
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRectEx.ScrollRectEvent m_OnValueChanged; // 0x68
	private Vector2 m_PointerStartLocalCursor; // 0x70
	private Vector2 m_ContentStartPosition; // 0x78
	private RectTransform m_ViewRect; // 0x80
	private Bounds m_ContentBounds; // 0x88
	private Bounds m_ViewBounds; // 0xA0
	private Vector2 m_Velocity; // 0xB8
	private bool m_Dragging; // 0xC0
	private Vector2 m_PrevPosition; // 0xC4
	private Bounds m_PrevContentBounds; // 0xCC
	private Bounds m_PrevViewBounds; // 0xE4
	private bool m_HasRebuiltLayout; // 0xFC
	private bool m_HSliderExpand; // 0xFD
	private bool m_VSliderExpand; // 0xFE
	private float m_HSliderHeight; // 0x100
	private float m_VSliderWidth; // 0x104
	private RectTransform m_Rect; // 0x108
	private RectTransform m_HorizontalScrollbarRect; // 0x110
	private RectTransform m_VerticalScrollbarRect; // 0x118
	private DrivenRectTransformTracker m_Tracker; // 0x120
	private readonly Vector3[] m_Corners; // 0x128

	// Properties
	public RectTransform content { get; set; }
	public bool horizontal { get; set; }
	public bool vertical { get; set; }
	public ScrollRectEx.MovementType movementType { get; set; }
	public float elasticity { get; set; }
	public bool inertia { get; set; }
	public float decelerationRate { get; set; }
	public float scrollSensitivity { get; set; }
	public RectTransform viewport { get; set; }
	public Scrollbar horizontalScrollbar { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public ScrollRectEx.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
	public ScrollRectEx.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
	public float horizontalScrollbarSpacing { get; set; }
	public float verticalScrollbarSpacing { get; set; }
	public ScrollRectEx.ScrollRectEvent onValueChanged { get; set; }
	protected RectTransform viewRect { get; }
	public Vector2 velocity { get; set; }
	private RectTransform rectTransform { get; }
	public Vector2 normalizedPosition { get; set; }
	public float horizontalNormalizedPosition { get; set; }
	public float verticalNormalizedPosition { get; set; }
	private bool hScrollingNeeded { get; }
	private bool vScrollingNeeded { get; }

	// Methods

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public RectTransform get_content() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_content(RectTransform value) { }

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0
	public bool get_horizontal() { }

	// RVA: 0x9775D0 Offset: 0x9769D0 VA: 0x1809775D0
	public void set_horizontal(bool value) { }

	// RVA: 0x754350 Offset: 0x753750 VA: 0x180754350
	public bool get_vertical() { }

	// RVA: 0x111F140 Offset: 0x111E540 VA: 0x18111F140
	public void set_vertical(bool value) { }

	// RVA: 0x5F7BF0 Offset: 0x5F6FF0 VA: 0x1805F7BF0
	public ScrollRectEx.MovementType get_movementType() { }

	// RVA: 0x10B2ED0 Offset: 0x10B22D0 VA: 0x1810B2ED0
	public void set_movementType(ScrollRectEx.MovementType value) { }

	// RVA: 0x516B60 Offset: 0x515F60 VA: 0x180516B60
	public float get_elasticity() { }

	// RVA: 0x4E2D80 Offset: 0x4E2180 VA: 0x1804E2D80
	public void set_elasticity(float value) { }

	// RVA: 0xB9D210 Offset: 0xB9C610 VA: 0x180B9D210
	public bool get_inertia() { }

	// RVA: 0xE86640 Offset: 0xE85A40 VA: 0x180E86640
	public void set_inertia(bool value) { }

	// RVA: 0x10B2CD0 Offset: 0x10B20D0 VA: 0x1810B2CD0
	public float get_decelerationRate() { }

	// RVA: 0x10B2D70 Offset: 0x10B2170 VA: 0x1810B2D70
	public void set_decelerationRate(float value) { }

	// RVA: 0xA004A0 Offset: 0x9FF8A0 VA: 0x180A004A0
	public float get_scrollSensitivity() { }

	// RVA: 0x53BBE0 Offset: 0x53AFE0 VA: 0x18053BBE0
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public RectTransform get_viewport() { }

	// RVA: 0x111F150 Offset: 0x111E550 VA: 0x18111F150
	public void set_viewport(RectTransform value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x111EDD0 Offset: 0x111E1D0 VA: 0x18111EDD0
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x111EFC0 Offset: 0x111E3C0 VA: 0x18111EFC0
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0xAE4F70 Offset: 0xAE4370 VA: 0x180AE4F70
	public ScrollRectEx.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x111EDC0 Offset: 0x111E1C0 VA: 0x18111EDC0
	public void set_horizontalScrollbarVisibility(ScrollRectEx.ScrollbarVisibility value) { }

	// RVA: 0x58DC00 Offset: 0x58D000 VA: 0x18058DC00
	public ScrollRectEx.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x111EFB0 Offset: 0x111E3B0 VA: 0x18111EFB0
	public void set_verticalScrollbarVisibility(ScrollRectEx.ScrollbarVisibility value) { }

	// RVA: 0x51BCC0 Offset: 0x51B0C0 VA: 0x18051BCC0
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x111EDB0 Offset: 0x111E1B0 VA: 0x18111EDB0
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x111ECA0 Offset: 0x111E0A0 VA: 0x18111ECA0
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x111EFA0 Offset: 0x111E3A0 VA: 0x18111EFA0
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public ScrollRectEx.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	public void set_onValueChanged(ScrollRectEx.ScrollRectEvent value) { }

	// RVA: 0x111ECB0 Offset: 0x111E0B0 VA: 0x18111ECB0
	protected RectTransform get_viewRect() { }

	// RVA: 0x111EB10 Offset: 0x111DF10 VA: 0x18111EB10
	public Vector2 get_velocity() { }

	// RVA: 0x111EF90 Offset: 0x111E390 VA: 0x18111EF90
	public void set_velocity(Vector2 value) { }

	// RVA: 0x111E9F0 Offset: 0x111DDF0 VA: 0x18111E9F0
	private RectTransform get_rectTransform() { }

	// RVA: 0x111E6B0 Offset: 0x111DAB0 VA: 0x18111E6B0
	protected void .ctor() { }

	// RVA: 0x111C5A0 Offset: 0x111B9A0 VA: 0x18111C5A0 Slot: 29
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x111D9A0 Offset: 0x111CDA0 VA: 0x18111D9A0
	private void UpdateCachedData() { }

	// RVA: 0x111C0F0 Offset: 0x111B4F0 VA: 0x18111C0F0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x111BC10 Offset: 0x111B010 VA: 0x18111BC10 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x111B210 Offset: 0x111A610 VA: 0x18111B210 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x111AE40 Offset: 0x111A240 VA: 0x18111AE40
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x111D540 Offset: 0x111C940 VA: 0x18111D540 Slot: 30
	public virtual void StopMovement() { }

	// RVA: 0x111C350 Offset: 0x111B750 VA: 0x18111C350 Slot: 31
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x111C2A0 Offset: 0x111B6A0 VA: 0x18111C2A0 Slot: 32
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x111BA90 Offset: 0x111AE90 VA: 0x18111BA90 Slot: 33
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x111C270 Offset: 0x111B670 VA: 0x18111C270 Slot: 34
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x111BE20 Offset: 0x111B220 VA: 0x18111BE20 Slot: 35
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x111C6E0 Offset: 0x111BAE0 VA: 0x18111C6E0 Slot: 36
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x111B280 Offset: 0x111A680 VA: 0x18111B280 Slot: 37
	protected virtual void LateUpdate() { }

	// RVA: 0x111DDB0 Offset: 0x111D1B0 VA: 0x18111DDB0
	private void UpdatePrevData() { }

	// RVA: 0x111E410 Offset: 0x111D810 VA: 0x18111E410
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x111E9A0 Offset: 0x111DDA0 VA: 0x18111E9A0
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x111EF50 Offset: 0x111E350 VA: 0x18111EF50
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x111E880 Offset: 0x111DC80 VA: 0x18111E880
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x111C940 Offset: 0x111BD40 VA: 0x18111C940
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x111EB30 Offset: 0x111DF30 VA: 0x18111EB30
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x111D530 Offset: 0x111C930 VA: 0x18111D530
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x111C940 Offset: 0x111BD40 VA: 0x18111C940
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x111D530 Offset: 0x111C930 VA: 0x18111D530
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x111D250 Offset: 0x111C650 VA: 0x18111D250
	private void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x111C640 Offset: 0x111BA40 VA: 0x18111C640
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x111C340 Offset: 0x111B740 VA: 0x18111C340 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x111E810 Offset: 0x111DC10 VA: 0x18111E810
	private bool get_hScrollingNeeded() { }

	// RVA: 0x111EA90 Offset: 0x111DE90 VA: 0x18111EA90
	private bool get_vScrollingNeeded() { }

	// RVA: 0x111C950 Offset: 0x111BD50 VA: 0x18111C950 Slot: 38
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x111D0B0 Offset: 0x111C4B0 VA: 0x18111D0B0 Slot: 39
	public virtual void SetLayoutVertical() { }

	// RVA: 0x111E290 Offset: 0x111D690 VA: 0x18111E290
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x111DEA0 Offset: 0x111D2A0 VA: 0x18111DEA0
	private void UpdateScrollbarLayout() { }

	// RVA: 0x111D5B0 Offset: 0x111C9B0 VA: 0x18111D5B0
	private void UpdateBounds() { }

	// RVA: 0x111AEB0 Offset: 0x111A2B0 VA: 0x18111AEB0
	private Bounds GetBounds() { }

	// RVA: 0x111A8C0 Offset: 0x1119CC0 VA: 0x18111A8C0
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x111C8C0 Offset: 0x111BCC0 VA: 0x18111C8C0
	protected void SetDirty() { }

	// RVA: 0x111C810 Offset: 0x111BC10 VA: 0x18111C810
	protected void SetDirtyCaching() { }

	// RVA: 0x111AB30 Offset: 0x1119F30 VA: 0x18111AB30
	public void CenterOnPosition(Vector2 pos) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 24
	public void LayoutComplete() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 25
	public void GraphicUpdateComplete() { }

	// RVA: 0xAB8650 Offset: 0xAB7A50 VA: 0x180AB8650 Slot: 23
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum ScrollRectEx.MovementType // TypeDefIndex: 11708
{	// Fields
	public int value__; // 0x0
	public const ScrollRectEx.MovementType Unrestricted = 0;
	public const ScrollRectEx.MovementType Elastic = 1;
	public const ScrollRectEx.MovementType Clamped = 2;

}

public enum ScrollRectEx.ScrollbarVisibility // TypeDefIndex: 11709
{	// Fields
	public int value__; // 0x0
	public const ScrollRectEx.ScrollbarVisibility Permanent = 0;
	public const ScrollRectEx.ScrollbarVisibility AutoHide = 1;
	public const ScrollRectEx.ScrollbarVisibility AutoHideAndExpandViewport = 2;

}

public class ScrollRectEx.ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 11710
{	// Methods

	// RVA: 0x111A880 Offset: 0x1119C80 VA: 0x18111A880
	public void .ctor() { }

}

