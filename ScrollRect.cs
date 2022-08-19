public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 4994
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform m_Content; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_Horizontal; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_Vertical; // 0x21
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRect.MovementType m_MovementType; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_Elasticity; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_Inertia; // 0x2C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_DecelerationRate; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_ScrollSensitivity; // 0x34
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform m_Viewport; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Scrollbar m_HorizontalScrollbar; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Scrollbar m_VerticalScrollbar; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x54
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_HorizontalScrollbarSpacing; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_VerticalScrollbarSpacing; // 0x5C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRect.ScrollRectEvent m_OnValueChanged; // 0x60
	private Vector2 m_PointerStartLocalCursor; // 0x68
	protected Vector2 m_ContentStartPosition; // 0x70
	private RectTransform m_ViewRect; // 0x78
	protected Bounds m_ContentBounds; // 0x80
	private Bounds m_ViewBounds; // 0x98
	private Vector2 m_Velocity; // 0xB0
	private bool m_Dragging; // 0xB8
	private bool m_Scrolling; // 0xB9
	private Vector2 m_PrevPosition; // 0xBC
	private Bounds m_PrevContentBounds; // 0xC4
	private Bounds m_PrevViewBounds; // 0xDC
	private bool m_HasRebuiltLayout; // 0xF4
	private bool m_HSliderExpand; // 0xF5
	private bool m_VSliderExpand; // 0xF6
	private float m_HSliderHeight; // 0xF8
	private float m_VSliderWidth; // 0xFC
	private RectTransform m_Rect; // 0x100
	private RectTransform m_HorizontalScrollbarRect; // 0x108
	private RectTransform m_VerticalScrollbarRect; // 0x110
	private DrivenRectTransformTracker m_Tracker; // 0x118
	private readonly Vector3[] m_Corners; // 0x120

	// Properties
	public RectTransform content { get; set; }
	public bool horizontal { get; set; }
	public bool vertical { get; set; }
	public ScrollRect.MovementType movementType { get; set; }
	public float elasticity { get; set; }
	public bool inertia { get; set; }
	public float decelerationRate { get; set; }
	public float scrollSensitivity { get; set; }
	public RectTransform viewport { get; set; }
	public Scrollbar horizontalScrollbar { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
	public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
	public float horizontalScrollbarSpacing { get; set; }
	public float verticalScrollbarSpacing { get; set; }
	public ScrollRect.ScrollRectEvent onValueChanged { get; set; }
	protected RectTransform viewRect { get; }
	public Vector2 velocity { get; set; }
	private RectTransform rectTransform { get; }
	public Vector2 normalizedPosition { get; set; }
	public float horizontalNormalizedPosition { get; set; }
	public float verticalNormalizedPosition { get; set; }
	private bool hScrollingNeeded { get; }
	private bool vScrollingNeeded { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public RectTransform get_content() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_content(RectTransform value) { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public bool get_horizontal() { }

	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	public void set_horizontal(bool value) { }

	// RVA: 0xB0BB90 Offset: 0xB0AF90 VA: 0x180B0BB90
	public bool get_vertical() { }

	// RVA: 0x139E1C0 Offset: 0x139D5C0 VA: 0x18139E1C0
	public void set_vertical(bool value) { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public ScrollRect.MovementType get_movementType() { }

	// RVA: 0x7E8E00 Offset: 0x7E8200 VA: 0x1807E8E00
	public void set_movementType(ScrollRect.MovementType value) { }

	// RVA: 0x93F110 Offset: 0x93E510 VA: 0x18093F110
	public float get_elasticity() { }

	// RVA: 0x93F180 Offset: 0x93E580 VA: 0x18093F180
	public void set_elasticity(float value) { }

	// RVA: 0x171A2C0 Offset: 0x17196C0 VA: 0x18171A2C0
	public bool get_inertia() { }

	// RVA: 0xC3E1D0 Offset: 0xC3D5D0 VA: 0x180C3E1D0
	public void set_inertia(bool value) { }

	// RVA: 0x516B60 Offset: 0x515F60 VA: 0x180516B60
	public float get_decelerationRate() { }

	// RVA: 0x4E2D80 Offset: 0x4E2180 VA: 0x1804E2D80
	public void set_decelerationRate(float value) { }

	// RVA: 0xA12F50 Offset: 0xA12350 VA: 0x180A12F50
	public float get_scrollSensitivity() { }

	// RVA: 0x171A950 Offset: 0x1719D50 VA: 0x18171A950
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public RectTransform get_viewport() { }

	// RVA: 0x171AB00 Offset: 0x1719F00 VA: 0x18171AB00
	public void set_viewport(RectTransform value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x171A780 Offset: 0x1719B80 VA: 0x18171A780
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x171A980 Offset: 0x1719D80 VA: 0x18171A980
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x8C8B80 Offset: 0x8C7F80 VA: 0x1808C8B80
	public ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x171A770 Offset: 0x1719B70 VA: 0x18171A770
	public void set_horizontalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x5F8160 Offset: 0x5F7560 VA: 0x1805F8160
	public ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x171A970 Offset: 0x1719D70 VA: 0x18171A970
	public void set_verticalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x58DC20 Offset: 0x58D020 VA: 0x18058DC20
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x171A760 Offset: 0x1719B60 VA: 0x18171A760
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x171A650 Offset: 0x1719A50 VA: 0x18171A650
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x171A960 Offset: 0x1719D60 VA: 0x18171A960
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public ScrollRect.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_onValueChanged(ScrollRect.ScrollRectEvent value) { }

	// RVA: 0x171A660 Offset: 0x1719A60 VA: 0x18171A660
	protected RectTransform get_viewRect() { }

	// RVA: 0x171A440 Offset: 0x1719840 VA: 0x18171A440
	public Vector2 get_velocity() { }

	// RVA: 0x13EFA80 Offset: 0x13EEE80 VA: 0x1813EFA80
	public void set_velocity(Vector2 value) { }

	// RVA: 0x171A320 Offset: 0x1719720 VA: 0x18171A320
	private RectTransform get_rectTransform() { }

	// RVA: 0x1719F60 Offset: 0x1719360 VA: 0x181719F60
	protected void .ctor() { }

	// RVA: 0x1717A70 Offset: 0x1716E70 VA: 0x181717A70 Slot: 38
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 39
	public virtual void LayoutComplete() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 40
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1719220 Offset: 0x1718620 VA: 0x181719220
	private void UpdateCachedData() { }

	// RVA: 0x1717560 Offset: 0x1716960 VA: 0x181717560 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1717070 Offset: 0x1716470 VA: 0x181717070 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1716570 Offset: 0x1715970 VA: 0x181716570 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x1715F20 Offset: 0x1715320 VA: 0x181715F20
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x1718A30 Offset: 0x1717E30 VA: 0x181718A30 Slot: 41
	public virtual void StopMovement() { }

	// RVA: 0x17177C0 Offset: 0x1716BC0 VA: 0x1817177C0 Slot: 42
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x1717720 Offset: 0x1716B20 VA: 0x181717720 Slot: 43
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1716F00 Offset: 0x1716300 VA: 0x181716F00 Slot: 44
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x17176F0 Offset: 0x1716AF0 VA: 0x1817176F0 Slot: 45
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1717290 Offset: 0x1716690 VA: 0x181717290 Slot: 46
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1717BB0 Offset: 0x1716FB0 VA: 0x181717BB0 Slot: 47
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x17165E0 Offset: 0x17159E0 VA: 0x1817165E0 Slot: 48
	protected virtual void LateUpdate() { }

	// RVA: 0x1719730 Offset: 0x1718B30 VA: 0x181719730
	protected void UpdatePrevData() { }

	// RVA: 0x1719CC0 Offset: 0x17190C0 VA: 0x181719CC0
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x171A2D0 Offset: 0x17196D0 VA: 0x18171A2D0
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x171A900 Offset: 0x1719D00 VA: 0x18171A900
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x171A130 Offset: 0x1719530 VA: 0x18171A130
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x1717E10 Offset: 0x1717210 VA: 0x181717E10
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x171A460 Offset: 0x1719860 VA: 0x18171A460
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x1718A10 Offset: 0x1717E10 VA: 0x181718A10
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x1717E10 Offset: 0x1717210 VA: 0x181717E10
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x1718A10 Offset: 0x1717E10 VA: 0x181718A10
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x1718730 Offset: 0x1717B30 VA: 0x181718730 Slot: 49
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x1717B10 Offset: 0x1716F10 VA: 0x181717B10
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x17177B0 Offset: 0x1716BB0 VA: 0x1817177B0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x171A0C0 Offset: 0x17194C0 VA: 0x18171A0C0
	private bool get_hScrollingNeeded() { }

	// RVA: 0x171A3C0 Offset: 0x17197C0 VA: 0x18171A3C0
	private bool get_vScrollingNeeded() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 50
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 51
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 52
	public virtual float get_minWidth() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 53
	public virtual float get_preferredWidth() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 54
	public virtual float get_flexibleWidth() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 55
	public virtual float get_minHeight() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 56
	public virtual float get_preferredHeight() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 57
	public virtual float get_flexibleHeight() { }

	// RVA: 0x513D90 Offset: 0x513190 VA: 0x180513D90 Slot: 58
	public virtual int get_layoutPriority() { }

	// RVA: 0x1717E30 Offset: 0x1717230 VA: 0x181717E30 Slot: 59
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1718590 Offset: 0x1717990 VA: 0x181718590 Slot: 60
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1719C10 Offset: 0x1719010 VA: 0x181719C10
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x1719630 Offset: 0x1718A30 VA: 0x181719630
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x1719820 Offset: 0x1718C20 VA: 0x181719820
	private void UpdateScrollbarLayout() { }

	// RVA: 0x1718AA0 Offset: 0x1717EA0 VA: 0x181718AA0
	protected void UpdateBounds() { }

	// RVA: 0x1715D70 Offset: 0x1715170 VA: 0x181715D70
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	// RVA: 0x1715F90 Offset: 0x1715390 VA: 0x181715F90
	private Bounds GetBounds() { }

	// RVA: 0x1716300 Offset: 0x1715700 VA: 0x181716300
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x1715ED0 Offset: 0x17152D0 VA: 0x181715ED0
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x17160C0 Offset: 0x17154C0 VA: 0x1817160C0
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta) { }

	// RVA: 0x1717D90 Offset: 0x1717190 VA: 0x181717D90
	protected void SetDirty() { }

	// RVA: 0x1717CE0 Offset: 0x17170E0 VA: 0x181717CE0
	protected void SetDirtyCaching() { }

	// RVA: 0xAB8650 Offset: 0xAB7A50 VA: 0x180AB8650 Slot: 23
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum ScrollRect.MovementType // TypeDefIndex: 4995
{	// Fields
	public int value__; // 0x0
	public const ScrollRect.MovementType Unrestricted = 0;
	public const ScrollRect.MovementType Elastic = 1;
	public const ScrollRect.MovementType Clamped = 2;

}

public enum ScrollRect.ScrollbarVisibility // TypeDefIndex: 4996
{	// Fields
	public int value__; // 0x0
	public const ScrollRect.ScrollbarVisibility Permanent = 0;
	public const ScrollRect.ScrollbarVisibility AutoHide = 1;
	public const ScrollRect.ScrollbarVisibility AutoHideAndExpandViewport = 2;

}

public class ScrollRect.ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 4997
{	// Methods

	// RVA: 0x1715D30 Offset: 0x1715130 VA: 0x181715D30
	public void .ctor() { }

}

